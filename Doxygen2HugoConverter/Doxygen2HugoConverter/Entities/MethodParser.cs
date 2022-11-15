using Doxygen2HugoConverter.Markup;
using System.Xml.Linq;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;

    internal static class MethodParser
    {
        public static EntityDef.MethodEntity Parse(ParseState state, XElement source)
        {
            String id = source.GetAttributeValue("id");
            Boolean staticValue = source.GetYesNoValue("static");
            Boolean constValue = source.GetYesNoValue("const");
            Boolean explicitValue = source.GetYesNoValue("explicit");
            Boolean virtualValue = source.GetVirtualValue();
            String name = source.GetChildElementValue("name");
            //String qualifiedName = source.GetChildElementValue("qualifiedname");
            BriefDescriptionPortion returnType = MarkupParser.ParseSimpleMarkup(source.GetChildElement("type"));
            String definition = source.GetChildElementValue("definition");
            String argString = source.GetChildElementValue("argsstring");
            BriefDescriptionPortion briefDescription = MarkupParser.ParseSimpleMarkup(source);
            MethodDetailedDescription detailedDescription = ParseMethodDetailedDescription(source);
            Boolean overrideValue = argString.EndsWith(OverrideSuffix);
            IList<String> templateParameters = ParserUtils.ParseTemplateParameters(source);
            IList<MethodArgEntity> parameters = source.Elements("param").Select(ParseMethodParameter).ToList();
            EntityDef.MethodEntity result = new EntityDef.MethodEntity(id,
                                                                       state.ParentId,
                                                                       name,
                                                                       state.ParentName,
                                                                       staticValue,
                                                                       constValue,
                                                                       explicitValue,
                                                                       virtualValue,
                                                                       overrideValue,
                                                                       briefDescription,
                                                                       detailedDescription,
                                                                       definition,
                                                                       argString,
                                                                       templateParameters,
                                                                       parameters,
                                                                       returnType);
            state.CommonEntityRepo.Add(id, result);
            return result;
        }

        private static MethodArgEntity ParseMethodParameter(XElement source)
        {
            String paramName = source.GetChildElementValue("declname");
            BriefDescriptionPortion paramType = MarkupParser.ParseSimpleMarkup(source.GetChildElement("type"));
            return new MethodArgEntity(paramName, paramType);
        }

        private static MethodDetailedDescription ParseMethodDetailedDescription(XElement source) =>
            MarkupParser.ParseMethodDetailedDescription(source.Element("detaileddescription")!);

        private const String OverrideSuffix = " override";
    }
}
