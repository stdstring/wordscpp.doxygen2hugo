﻿using Doxygen2HugoConverter.Markup;
using System.Xml.Linq;

namespace Doxygen2HugoConverter.Entities
{
    using BriefDescriptionPortion = IList<SimpleMarkupEntry>;

    internal static class MethodParser
    {
        public static EntityDef.MethodEntity ParseMethodEntity(this XElement source, ParseState state)
        {
            String id = source.GetAttributeValue("id");
            Boolean staticValue = source.GetYesNoValue("static");
            Boolean constValue = source.GetYesNoValue("const");
            Boolean explicitValue = source.GetYesNoValue("explicit");
            Boolean virtualValue = source.GetVirtualValue();
            String name = source.GetChildElementValue("name");
            String qualifiedName = source.GetChildElementValue("qualifiedname");
            MethodKind kind = name.Equals(state.ParentName) switch
            {
                true => MethodKind.Constructor,
                false => MethodKind.Method
            };
            BriefDescriptionPortion returnType = source.GetChildElement("type").ParseSimpleMarkup();
            String definition = source.GetChildElementValue("definition");
            String argString = source.GetChildElementValue("argsstring");
            BriefDescriptionPortion briefDescription = source.ParseBriefDescription();
            MethodDetailedDescription detailedDescription = source.ParseDetailedDescriptionForMethod();
            Boolean overrideValue = argString.EndsWith(OverrideSuffix);
            IList<String> templateParameters = source.ParseTemplateParameters();
            IList<MethodArgEntity> parameters = source.Elements("param").Select(ParseMethodParameter).ToList();
            EntityDef.MethodEntity result = new EntityDef.MethodEntity(id,
                                                                       state.ParentId,
                                                                       name,
                                                                       state.ParentName,
                                                                       qualifiedName,
                                                                       staticValue,
                                                                       constValue,
                                                                       explicitValue,
                                                                       virtualValue,
                                                                       overrideValue,
                                                                       kind,
                                                                       briefDescription,
                                                                       detailedDescription,
                                                                       definition,
                                                                       argString,
                                                                       templateParameters,
                                                                       parameters,
                                                                       returnType);
            state.ConvertData.EntityRepo.Add(id, result);
            return result;
        }

        private static MethodArgEntity ParseMethodParameter(XElement source)
        {
            String paramName = source.GetChildElementValue("declname");
            BriefDescriptionPortion paramType = source.GetChildElement("type").ParseSimpleMarkup();
            return new MethodArgEntity(paramName, paramType);
        }

        private static MethodDetailedDescription ParseDetailedDescriptionForMethod(this XElement source) =>
            source.Element("detaileddescription")!.ParseMethodDetailedDescription();

        private const String OverrideSuffix = " override";
    }
}
