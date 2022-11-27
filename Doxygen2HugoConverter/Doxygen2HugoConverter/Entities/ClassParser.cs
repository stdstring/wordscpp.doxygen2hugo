using System.Xml.Linq;
using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;

    internal static class ClassParser
    {
        public static EntityDef.ClassEntity? ParseClassEntity(this XElement source, ParseState state)
        {
            switch (source.GetAttributeValue("prot"))
            {
                case "public":
                    String id = source.GetAttributeValue("id");
                    ClassKind kind = source.GetAttributeValue("kind") switch
                    {
                        "class" => ClassKind.Class,
                        "interface" => ClassKind.Interface,
                        var value => throw new InvalidOperationException($"Unexpected kind value \"{value}\"")
                    };
                    BriefDescriptionPortion briefDescription = source.ParseBriefDescription();
                    ClassDetailedDescription detailedDescription = source.ParseDetailedDescriptionForClass();
                    String fullName = source.GetChildElementValue("compoundname");
                    String name = NameUtils.GetClassName(fullName);
                    Boolean finalValue = source.FindYesNoValue("final");
                    IList<BaseClassEntity> baseClasses = source.Elements("basecompoundref").Select(ParseBaseClassDef).ToList();
                    IList<String> templateParameters = source.ParseTemplateParameters();
                    ParseState currentState = state with {ParentId = id, ParentName = name};
                    // Possible kind attribute values:
                    // "private-type",
                    // "private-attrib",
                    // "private-func",
                    // "private-static-attrib",
                    // "public-func",
                    // "public-static-func",
                    // "public-static-attrib",
                    // "public-type"
                    IList<MethodGroupEntity> directMethods = source.ParseDirectMethods(currentState);
                    IList<EntityDef.FieldEntity> fields = source.ParseDirectFields(currentState);
                    IList<EntityDef.TypedefEntity> typedefs = source.ParseDirectTypedefs(currentState);
                    IList<MemberRef> memberRefs = source.Element("listofallmembers")!
                                                        .Elements("member")
                                                        .Choose(RefParser.ParseMemberRef)
                                                        .ToList();
                    EntityDef.ClassEntity result = new EntityDef.ClassEntity(id,
                                                                             state.ParentId,
                                                                             name,
                                                                             fullName,
                                                                             finalValue,
                                                                             kind,
                                                                             briefDescription,
                                                                             detailedDescription,
                                                                             baseClasses,
                                                                             templateParameters,
                                                                             directMethods,
                                                                             fields,
                                                                             typedefs,
                                                                             memberRefs);
                    state.ConvertData.EntityRepo.Add(id, result);
                    return result;
                default:
                    return null;
            }
        }

        private static BaseClassEntity ParseBaseClassDef(XElement source)
        {
            String access = source.GetAttributeValue("prot");
            Boolean virtualValue = source.GetVirtualValue();
            String qualifiedName = source.Value;
            return new BaseClassEntity(access, virtualValue, qualifiedName);
        }

        private static IList<MethodGroupEntity> ParseDirectMethods(this XElement source, ParseState state)
        {
            Boolean KindFilterFun(XElement element)
            {
                return element.GetAttributeValue("kind") switch
                {
                    "public-func" => true,
                    "public-static-func" => true,
                    _ => false
                };
            }
            return source.Elements("sectiondef")
                         .Where(KindFilterFun)
                         .SelectMany(section => section.Elements("memberdef"))
                         .Select(element => element.ParseMethodEntity(state))
                         .GroupBy(methodEntity => methodEntity.Name)
                         .Select(group => new MethodGroupEntity(group.Key, group.ToList()))
                         .ToList();
        }

        private static IList<EntityDef.FieldEntity> ParseDirectFields(this XElement source, ParseState state)
        {
            Boolean KindFilterFun(XElement element)
            {
                return element.GetAttributeValue("kind") switch
                {
                    "public-static-attrib" => true,
                    _ => false
                };
            }
            return source.Elements("sectiondef")
                         .Where(KindFilterFun)
                         .SelectMany(section => section.Elements("memberdef"))
                         .Select(element => element.ParseFieldEntity(state))
                         .ToList();
        }

        private static IList<EntityDef.TypedefEntity> ParseDirectTypedefs(this XElement source, ParseState state)
        {
            Boolean KindFilterFun(XElement element)
            {
                return element.GetAttributeValue("kind") switch
                {
                    "public-type" => true,
                    _ => false
                };
            }
            return source.Elements("sectiondef")
                         .Where(KindFilterFun)
                         .SelectMany(section => section.Elements("memberdef"))
                         .Choose(element => element.ParseTypedefEntity(state))
                         .ToList();
        }

        private static ClassDetailedDescription ParseDetailedDescriptionForClass(this XElement source) =>
            source.Element("detaileddescription")!.ParseClassDetailedDescription();
    }
}
