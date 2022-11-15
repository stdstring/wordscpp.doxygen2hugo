using Doxygen2HugoConverter.Markup;
using System.Globalization;
using System.Xml.Linq;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;
    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

    internal static class EnumParser
    {
        public static EntityDef.EnumEntity? Parse(ParseState state, XElement source)
        {
            switch (source.GetAttributeValue("prot"))
            {
                case "public":
                    String id = source.GetAttributeValue("id");
                    BriefDescriptionPortion briefDescription = ParserUtils.ParseBriefDescription(source);
                    DetailedDescriptionPortion detailedDescription = ParseEnumDetailedDescription(source);
                    String name = source.GetChildElementValue("name");
                    String qualifiedName = source.GetChildElementValue("qualifiedname");
                    String baseType = source.GetChildElementValue("type");
                    IList<EnumValueEntity> values = new List<EnumValueEntity>();
                    foreach (XElement valueElement in source.Elements("enumvalue"))
                    {
                        Int32? prevValue = values.Count switch
                        {
                            0 => null,
                            _ => values.Last().Initializer
                        };
                        values.Add(ParseEnumValueEntity(values.Count == 0, prevValue, valueElement));
                    }
                    EntityDef.EnumEntity result = new EntityDef.EnumEntity(id,
                                                                           state.ParentId,
                                                                           name,
                                                                           qualifiedName,
                                                                           baseType,
                                                                           briefDescription,
                                                                           detailedDescription,
                                                                           values);
                    state.CommonEntityRepo.Add(id, result);
                    return result;
                default:
                    return null;
            }
        }

        private static Int32? ParseEnumValueInitializer(Boolean isFirst, Int32? prevValue, String? initializerSource)
        {
            return initializerSource?.Trim(' ', '=') switch
            {
                null when isFirst => DefaultStartEnumValue,
                null => prevValue switch
                {
                    null => null,
                    var value => value + 1
                },
                var value => value.StartsWith("0x") switch
                {
                    true => Int32.TryParse(value.Substring("0x".Length), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out Int32 result) switch
                    {
                        true => result,
                        false => null
                    },
                    false => Int32.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out Int32 result) switch
                    {
                        true => result,
                        false => null
                    }
                }
            };
        }

        private static EnumValueEntity ParseEnumValueEntity(Boolean isFirst, Int32? prevValue, XElement source)
        {
            String id = source.GetAttributeValue("id");
            String name = source.GetChildElementValue("name");
            BriefDescriptionPortion briefDescription = ParserUtils.ParseBriefDescription(source);
            Int32? initializer = ParseEnumValueInitializer(isFirst, prevValue, source.FindChildElementValue("initializer"));
            return new EnumValueEntity(id, name, initializer, briefDescription);
        }

        private static DetailedDescriptionPortion ParseEnumDetailedDescription(XElement source) =>
            MarkupParser.ParseDetailedDescription(source.Element("detaileddescription")!);

        private const Int32 DefaultStartEnumValue = 0;
    }
}
