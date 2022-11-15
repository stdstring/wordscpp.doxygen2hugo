using System.Xml.Linq;
using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;

    internal static class ClassParser
    {
        public static EntityDef.ClassEntity? Parse(ParseState state, XElement source)
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
                    BriefDescriptionPortion briefDescription = ParserUtils.ParseBriefDescription(source);
                    ClassDetailedDescription detailedDescription = MarkupParser.ParseClassDetailedDescription(source);
                    String fullName = source.GetChildElementValue("compoundname");
                    String name = NameUtils.GetClassName(fullName);
                    Boolean finalValue = source.FindYesNoValue("final");
                    IList<BaseClassEntity> baseClasses = source.Elements("basecompoundref").Select(ParseBaseClassDef).ToList();
                    IList<String> templateParameters = ParserUtils.ParseTemplateParameters(source);
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
                    IList<EntityDef.MethodGroupEntity> directMethods = ParseDirectMethods(currentState, source);
                    IList<EntityDef.FieldEntity> fields = ParseDirectFields(currentState, source);
                    IList<EntityDef.TypedefEntity> typedefs = ParseDirectTypedefs(currentState, source);
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
            throw new NotImplementedException();
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

        private static ClassDetailedDescription ParseClassDetailedDescription(XElement source) =>
            MarkupParser.ParseClassDetailedDescription(source.Element("detaileddescription")!);

        private static IList<EntityDef.MethodGroupEntity> ParseDirectMethods(ParseState state, XElement source)
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
                         .Select(element => MethodParser.Parse(state, element))
                         .GroupBy(methodEntity => methodEntity.Name)
                         .Select(group => new EntityDef.MethodGroupEntity(group.Key, group.ToList()))
                         .ToList();
        }

        private static IList<EntityDef.FieldEntity> ParseDirectFields(ParseState state, XElement source)
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
                         .Select(element => FieldParser.Parse(state, element))
                         .ToList();
        }

        private static IList<EntityDef.TypedefEntity> ParseDirectTypedefs(ParseState state, XElement source)
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
                         .Choose(element => TypedefParser.Parse(state, element))
                         .ToList();
        }
    }
}
