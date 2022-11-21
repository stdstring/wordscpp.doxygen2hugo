using System.Xml.Linq;
using Doxygen2HugoConverter.Markup;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;

    internal record ParseState(String ParentId, String ParentName, IDictionary<String, EntityDef> CommonEntityRepo);

    internal static class ParserUtils
    {
        public static Boolean GetVirtualValue(this XElement source) =>
            source.GetAttributeValue("virt") switch
            {
                "virtual" => true,
                "pure-virtual" => true,
                "non-virtual" => false,
                var value=> throw new InvalidOperationException($"Unexpected \"virt\" attribute value \"{value}\"")
            };

        // TODO (std_string) : think about name
        public static Boolean GetYesNoValue(this XElement source, String name) =>
            source.GetAttributeValue(name) switch
            {
                "no" => false,
                "yes" => true,
                var value => throw new InvalidOperationException($"Unexpected \"{name}\" attribute value \"{value}\"")
            };

        // TODO (std_string) : think about name
        public static Boolean FindYesNoValue(this XElement source, String name) =>
            source.FindAttributeValue(name) switch
            {
                null => false,
                "no" => false,
                "yes" => true,
                var value => throw new InvalidOperationException($"Unexpected \"{name}\" attribute value \"{value}\"")
            };

        public static IList<String> ParseTemplateParameters(this XElement source) =>
            source.Elements("templateparamlist")
                  .SelectMany(paramElement => paramElement.Elements("param").Select(element => element.Descendants("type").Single().Value))
                  .ToList();

        public static BriefDescriptionPortion ParseBriefDescription(this XElement source) =>
            source.Element("briefdescription")!.ParseSimpleMarkup();
    }
}
