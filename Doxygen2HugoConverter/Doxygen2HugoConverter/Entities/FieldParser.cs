using Doxygen2HugoConverter.Markup;
using System.Xml.Linq;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;
    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

    internal static class FieldParser
    {
        public static EntityDef.FieldEntity ParseFieldEntity(this XElement source, ParseState state)
        {
            String id = source.GetAttributeValue("id");
            Boolean staticValue = source.GetYesNoValue("static");
            Boolean constexprValue = source.GetYesNoValue("constexpr");
            Boolean mutableValue = source.GetYesNoValue("mutable");
            String name = source.GetChildElementValue("name");
            String fullName = source.GetChildElementValue("qualifiedname");
            String fieldType = source.GetChildElementValue("type");
            String definition = source.GetChildElementValue("definition");
            String? initializer = source.FindChildElementValue("initializer");
            BriefDescriptionPortion briefDescription = source.ParseBriefDescription();
            DetailedDescriptionPortion detailedDescription = source.ParseDetailedDescriptionForField();
            EntityDef.FieldEntity result = new EntityDef.FieldEntity(id,
                                                                     state.ParentId,
                                                                     staticValue,
                                                                     constexprValue,
                                                                     mutableValue,
                                                                     name,
                                                                     fullName,
                                                                     fieldType,
                                                                     definition,
                                                                     initializer,
                                                                     briefDescription,
                                                                     detailedDescription);
            state.CommonEntityRepo.Add(id, result);
            return result;
        }

        private static DetailedDescriptionPortion ParseDetailedDescriptionForField(this XElement source) =>
            source.Element("detaileddescription")!.ParseDetailedDescription();
    }
}
