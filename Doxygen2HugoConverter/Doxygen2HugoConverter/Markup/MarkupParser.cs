using System.Xml.Linq;

namespace Doxygen2HugoConverter.Markup
{
    using SimpleMarkupPortion = IList<SimpleMarkupEntry>;

    using CodeBlockMarkupLine = IList<CodeBlockMarkupEntry>;

    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

    using TemplateParameters = IList<TemplateParameter>;

    using MethodArgs = IList<MethodArg>;

    internal static class MarkupParser
    {
        public static SimpleMarkupPortion ParseSimpleMarkup(this XElement source)
        {
            IEnumerable<SimpleMarkupEntry> ParseSimpleMarkupImpl(XNode node)
            {
                switch (node)
                {
                    case XElement elementNode:
                        switch (elementNode.Name.LocalName)
                        {
                            case "para":
                                SimpleMarkupEntry paragraphStart = new SimpleMarkupEntry.ParagraphStartEntry();
                                SimpleMarkupEntry paragraphEnd = new SimpleMarkupEntry.ParagraphEndEntry();
                                IList<SimpleMarkupEntry> innerEntries = elementNode.Nodes().SelectMany(ParseSimpleMarkupImpl).ToList();
                                return innerEntries.IsEmpty() ?
                                    EnumerableUtils.CreateSingle(new SimpleMarkupEntry.LineBreakEntry()) :
                                    innerEntries.CreateFrame(paragraphStart, paragraphEnd);
                            // TODO (std_string) : think about special processing of computeroutput node
                            case "computeroutput":
                            case "bold":
                                SimpleMarkupEntry boldStart = new SimpleMarkupEntry.BoldStartEntry();
                                SimpleMarkupEntry boldEnd = new SimpleMarkupEntry.BoldEndEntry();
                                return elementNode.Nodes().SelectMany(ParseSimpleMarkupImpl).CreateFrame(boldStart, boldEnd);
                            case "emphasis":
                                SimpleMarkupEntry emphasisStart = new SimpleMarkupEntry.EmphasisStartEntry();
                                SimpleMarkupEntry emphasisEnd = new SimpleMarkupEntry.EmphasisEndEntry();
                                return elementNode.Nodes().SelectMany(ParseSimpleMarkupImpl).CreateFrame(emphasisStart, emphasisEnd);
                            case "ref":
                                return EnumerableUtils.CreateSingle(new SimpleMarkupEntry.RefEntry(elementNode.ParseMarkupRef()));
                            case "ulink":
                                return EnumerableUtils.CreateSingle(new SimpleMarkupEntry.ExternalLinkEntry(elementNode.ParseExternalLink()));
                            default:
                                throw new InvalidOperationException($"Unexpected SimpleMarkupEntry XML element named \"{elementNode.Name}\"");
                        }
                    case XText textNode:
                        return EnumerableUtils.CreateSingle(new SimpleMarkupEntry.TextEntry(textNode.Value));
                    default:
                        throw new InvalidOperationException($"Unexpected SimpleMarkupEntry XML node with type {node.NodeType}");
                }
            }
            return source.IsEmpty switch
            {
                true => Array.Empty<SimpleMarkupEntry>(),
                false => source.Nodes().SelectMany(ParseSimpleMarkupImpl).ToList()
            };
        }

        public static DetailedDescriptionPortion ParseDetailedDescription(this XElement source)
        {
            IEnumerable<DetailedDescriptionMarkupEntry> ParseDetailedDescriptionImpl(XNode node)
            {
                switch (node)
                {
                    case XElement elementNode:
                        switch (elementNode.Name.LocalName)
                        {
                            case "para":
                                DetailedDescriptionMarkupEntry paragraphStart = new DetailedDescriptionMarkupEntry.ParagraphStartEntry();
                                DetailedDescriptionMarkupEntry paragraphEnd = new DetailedDescriptionMarkupEntry.ParagraphEndEntry();
                                IList<DetailedDescriptionMarkupEntry> innerEntries = elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl).ToList();
                                return innerEntries.IsEmpty() ?
                                    EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.LineBreakEntry()) :
                                    innerEntries.CreateFrame(paragraphStart, paragraphEnd);
                            // TODO (std_string) : think about special processing of computeroutput node
                            case "computeroutput":
                            case "bold":
                                DetailedDescriptionMarkupEntry boldStart = new DetailedDescriptionMarkupEntry.BoldStartEntry();
                                DetailedDescriptionMarkupEntry boldEnd = new DetailedDescriptionMarkupEntry.BoldEndEntry();
                                return elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl).CreateFrame(boldStart, boldEnd);
                            case "emphasis":
                                DetailedDescriptionMarkupEntry emphasisStart = new DetailedDescriptionMarkupEntry.EmphasisStartEntry();
                                DetailedDescriptionMarkupEntry emphasisEnd = new DetailedDescriptionMarkupEntry.EmphasisEndEntry();
                                return elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl).CreateFrame(emphasisStart, emphasisEnd);
                            case "ref":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.RefEntry(elementNode.ParseMarkupRef()));
                            case "ulink":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.ExternalLinkEntry(elementNode.ParseExternalLink()));
                            case "linebreak":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.LineBreakEntry());
                            case "title":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.TitleEntry(elementNode.Value));
                            case "simplesect":
                                return elementNode.GetAttributeValue("kind") switch
                                {
                                    "par" => elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl),
                                    "note" => elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl),
                                    "see" => Enumerable.Empty<DetailedDescriptionMarkupEntry>(),
                                    // special processing for outer code (for classes)
                                    "return" => Enumerable.Empty<DetailedDescriptionMarkupEntry>(),
                                    var kind => throw new InvalidOperationException($"Unexpected \"simplesect\" XML element with kind \"{kind}\"")
                                };
                            case "orderedlist":
                            case "itemizedlist":
                                return EnumerableUtils.CreateSingle(elementNode.ParseMarkupList());
                            case "programlisting":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.CodeBlockEntry(elementNode.ParseCodeBlock()));
                            // special processing for outer code (for classes & methods)
                            case "parameterlist":
                                return Enumerable.Empty<DetailedDescriptionMarkupEntry>();
                            default:
                                throw new InvalidOperationException($"Unexpected DetailedDescriptionMarkupEntry XML element named \"{elementNode.Name}\"");
                        }
                    case XText textNode:
                        return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.TextEntry(textNode.Value));
                    default:
                        throw new InvalidOperationException($"Unexpected DetailedDescriptionMarkupEntry XML node with type {node.NodeType}");
                }
            }
            return source.Nodes().SelectMany(ParseDetailedDescriptionImpl).ToList().PostProcessDetailedDescription().ToList();
        }

        public static ClassDetailedDescription ParseClassDetailedDescription(this XElement source)
        {
            DetailedDescriptionPortion detailedDescription = source.ParseDetailedDescription();
            IList<TemplateParameter> templateParameters = source.Descendants("parameterlist")
                                                                .Where(element => element.GetAttributeValue("kind") == "templateparam")
                                                                .SelectMany(ParseTemplateParameters)
                                                                .ToList();
            return new ClassDetailedDescription(templateParameters, detailedDescription);
        }

        public static MethodDetailedDescription ParseMethodDetailedDescription(this XElement source)
        {
            DetailedDescriptionPortion detailedDescription = source.ParseDetailedDescription();
            IList<TemplateParameter> templateParameters = source.Descendants("parameterlist")
                                                                .Where(element => element.GetAttributeValue("kind") == "templateparam")
                                                                .SelectMany(ParseTemplateParameters)
                                                                .ToList();
            XElement? returnValueSource = source.Descendants("simplesect")
                                                .SingleOrDefault(element => element.GetAttributeValue("kind") == "return");
            SimpleMarkupPortion returnValue = returnValueSource == null
                ? new List<SimpleMarkupEntry>()
                : returnValueSource.ParseSimpleMarkup();
            IList<MethodArg> methodArgs = source.Descendants("parameterlist")
                                                .Where(element => element.GetAttributeValue("kind") == "param")
                                                .SelectMany(ParseMethodArgs)
                                                .ToList();
            return new MethodDetailedDescription(templateParameters, methodArgs, returnValue, detailedDescription);
        }

        private static MarkupRef ParseMarkupRef(this XElement source)
        {
            String refId = source.GetAttributeValue("refid");
            String? kind = source.FindAttributeValue("kindref");
            String? external = source.FindAttributeValue("external");
            String? tooltip = source.FindAttributeValue("tooltip");
            String text = source.Value;
            return new MarkupRef(refId, kind, external, tooltip, text);
        }

        private static ExternalLinkData ParseExternalLink(this XElement source)
        {
            String url = source.GetAttributeValue("url");
            String text = source.Value;
            return new ExternalLinkData(url, text);
        }

        private static CodeBlockMarkupLine ParseCodeBlockLine(XElement source)
        {
            IEnumerable<CodeBlockMarkupEntry> ParseCodeBlockLineImpl(XNode node)
            {
                switch (node)
                {
                    case XElement elementNode:
                        switch (elementNode.Name.LocalName)
                        {
                            case "highlight":
                                String highlightClass = elementNode.GetAttributeValue("class");
                                CodeBlockMarkupEntry frameStart = new CodeBlockMarkupEntry.HighlightStartEntry(highlightClass);
                                CodeBlockMarkupEntry frameEnd = new CodeBlockMarkupEntry.HighlightEndEntry();
                                return elementNode.Nodes().SelectMany(ParseCodeBlockLineImpl).CreateFrame(frameStart, frameEnd);
                            case "ref":
                                return EnumerableUtils.CreateSingle(new CodeBlockMarkupEntry.RefEntry(elementNode.ParseMarkupRef()));
                            case "sp":
                                return EnumerableUtils.CreateSingle(new CodeBlockMarkupEntry.SpaceEntry());
                            default:
                                throw new InvalidOperationException($"Unexpected CodeBlockMarkupEntry XML element named \"{elementNode.Name}\"");
                        }
                    case XText textNode:
                        return EnumerableUtils.CreateSingle(new CodeBlockMarkupEntry.TextEntry(textNode.Value));
                    default:
                        throw new InvalidOperationException($"Unexpected CodeBlockMarkupEntry XML node with type {node.NodeType}");
                }
            }
            return source.Nodes().SelectMany(ParseCodeBlockLineImpl).ToList();
        }

        private static IList<CodeBlockMarkupLine> ParseCodeBlock(this XElement source) =>
            source.Elements("codeline").Select(ParseCodeBlockLine).ToList();

        private static DetailedDescriptionMarkupEntry.ListEntry ParseMarkupList(this XElement source)
        {
            IList<SimpleMarkupPortion> items = source.Elements("listitem").Select(ParseSimpleMarkup).ToList();
            return source.Name.LocalName switch
            {
                "orderedlist" => new DetailedDescriptionMarkupEntry.ListEntry(true, items),
                "itemizedlist" => new DetailedDescriptionMarkupEntry.ListEntry(false, items),
                var value => throw new InvalidOperationException($"Unexpected list XML element named \"{value}\"")
            };
        }

        private static TemplateParameter ParseTemplateParameter(XElement source)
        {
            String name = source.Descendants("parametername").Single().Value;
            SimpleMarkupPortion description = source.Descendants("parameterdescription").Single().ParseSimpleMarkup();
            return new TemplateParameter(name, description);
        }

        private static TemplateParameters ParseTemplateParameters(XElement source) =>
            source.Elements("parameteritem").Select(ParseTemplateParameter).ToList();

        private static MethodArg ParseMethodArg(XElement source)
        {
            String name = source.Descendants("parametername").Single().Value;
            SimpleMarkupPortion description = source.Descendants("parameterdescription").Single().ParseSimpleMarkup();
            return new MethodArg(name, description);
        }

        private static MethodArgs ParseMethodArgs(XElement source) =>
            source.Elements("parameteritem").Select(ParseMethodArg).ToList();

        private static IEnumerable<DetailedDescriptionMarkupEntry> PostProcessDetailedDescription(this IList<DetailedDescriptionMarkupEntry> source)
        {
            Boolean IsTextFirst()
            {
                foreach (DetailedDescriptionMarkupEntry entry in source)
                {
                    switch (entry)
                    {
                        case DetailedDescriptionMarkupEntry.TitleEntry:
                            return false;
                        case DetailedDescriptionMarkupEntry.TextEntry:
                        case DetailedDescriptionMarkupEntry.RefEntry:
                        case DetailedDescriptionMarkupEntry.ExternalLinkEntry:
                        case DetailedDescriptionMarkupEntry.CodeBlockEntry:
                        case DetailedDescriptionMarkupEntry.ListEntry:
                            return true;
                    }
                }
                return false;
            }
            // we insert title "Remarks" if detailed description isn't started with other title
            return IsTextFirst() ? EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.TitleEntry("Remarks")).Concat(source) : source;
        }
    }
}
