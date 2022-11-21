using Doxygen2HugoConverter.Markup;
using System.Xml.Linq;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;
    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

    internal static class TypedefParser
    {
        public static EntityDef.TypedefEntity? ParseTypedefEntity(this XElement source, ParseState state)
        {
            switch (source.GetAttributeValue("prot"))
            {
                case "public":
                    String id = source.GetAttributeValue("id");
                    BriefDescriptionPortion briefDescription = source.ParseBriefDescription();
                    DetailedDescriptionPortion detailedDescription = source.ParseDetailedDescriptionForTypedef();
                    String name = source.GetChildElementValue("name");
                    String qualifiedName = source.GetChildElementValue("qualifiedname");
                    String sourceType = source.GetChildElementValue("type");
                    String definition = source.GetChildElementValue("definition");
                    EntityDef.TypedefEntity result = new EntityDef.TypedefEntity(id,
                                                                                 state.ParentId,
                                                                                 name,
                                                                                 qualifiedName,
                                                                                 sourceType,
                                                                                 definition,
                                                                                 briefDescription,
                                                                                 detailedDescription);
                    state.CommonEntityRepo.Add(id, result);
                    return result;
                default:
                    return null;
            }
        }

        private static DetailedDescriptionPortion ParseDetailedDescriptionForTypedef(this XElement source) =>
            source.Element("detaileddescription")!.ParseDetailedDescription();
    }
}
