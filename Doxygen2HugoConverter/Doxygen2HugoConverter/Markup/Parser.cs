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
        public static SimpleMarkupPortion ParseSimpleMarkup(XElement source)
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
                                return elementNode.Nodes().SelectMany(ParseSimpleMarkupImpl).CreateFrame(paragraphStart, paragraphEnd);
                            // TODO (std_string) : think about special processing of computeroutput node
                            case "computeroutput":
                            case "bold":
                                SimpleMarkupEntry boldStart = new SimpleMarkupEntry.BoldStartEntry();
                                SimpleMarkupEntry boldEnd = new SimpleMarkupEntry.BoldEndEntry();
                                return elementNode.Nodes().SelectMany(ParseSimpleMarkupImpl).CreateFrame(boldStart, boldEnd);
                            case "ref":
                                return EnumerableUtils.CreateSingle(new SimpleMarkupEntry.RefEntry(ParseMarkupRef(elementNode)));
                            case "ulink":
                                return EnumerableUtils.CreateSingle(new SimpleMarkupEntry.ExternalLinkEntry(ParseExternalLink(elementNode)));
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

        public static DetailedDescriptionPortion ParseDetailedDescription(XElement source)
        {
            IEnumerable<DetailedDescriptionMarkupEntry> ParseDetailedDescriptionImpl(XNode node)
            {
                switch (node)
                {
                    case XElement elementNode:
                        switch (elementNode.Name.LocalName)
                        {
                            case "para":
                                DetailedDescriptionMarkupEntry paragraphStart = new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.ParagraphStartEntry());
                                DetailedDescriptionMarkupEntry paragraphEnd = new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.ParagraphEndEntry());
                                return elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl).CreateFrame(paragraphStart, paragraphEnd);
                            // TODO (std_string) : think about special processing of computeroutput node
                            case "computeroutput":
                            case "bold":
                                DetailedDescriptionMarkupEntry boldStart = new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.BoldStartEntry());
                                DetailedDescriptionMarkupEntry boldEnd = new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.BoldEndEntry());
                                return elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl).CreateFrame(boldStart, boldEnd);
                            case "ref":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.RefEntry(ParseMarkupRef(elementNode))));
                            case "ulink":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.ExternalLinkEntry(ParseExternalLink(elementNode))));
                            case "linebreak":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.LineBreakEntry()));
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
                                return EnumerableUtils.CreateSingle(ParseMarkupList(elementNode));
                            case "programlisting":
                                return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.CodeBlockEntry(ParseCodeBlock(elementNode)));
                            case "emphasis":
                                return elementNode.Nodes().SelectMany(ParseDetailedDescriptionImpl);
                            // special processing for outer code (for classes & methods)
                            case "parameterlist":
                                return Enumerable.Empty<DetailedDescriptionMarkupEntry>();
                            default:
                                throw new InvalidOperationException($"Unexpected DetailedDescriptionMarkupEntry XML element named \"{elementNode.Name}\"");
                        }
                    case XText textNode:
                        return EnumerableUtils.CreateSingle(new DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry(new SimpleMarkupEntry.TextEntry(textNode.Value)));
                    default:
                        throw new InvalidOperationException($"Unexpected DetailedDescriptionMarkupEntry XML node with type {node.NodeType}");
                }
            }
            return source.Nodes().SelectMany(ParseDetailedDescriptionImpl).ToList();
        }

        public static ClassDetailedDescription ParseClassDetailedDescription(XElement source)
        {
            DetailedDescriptionPortion detailedDescription = ParseDetailedDescription(source);
            IList<TemplateParameter> templateParameters = source.Descendants("parameterlist")
                                                                .Where(element => element.GetAttributeValue("kind") == "templateparam")
                                                                .SelectMany(ParseTemplateParameters)
                                                                .ToList();
            return new ClassDetailedDescription(templateParameters, detailedDescription);
        }

        public static MethodDetailedDescription ParseMethodDetailedDescription(XElement source)
        {
            DetailedDescriptionPortion detailedDescription = ParseDetailedDescription(source);
            IList<TemplateParameter> templateParameters = source.Descendants("parameterlist")
                                                                .Where(element => element.GetAttributeValue("kind") == "templateparam")
                                                                .SelectMany(ParseTemplateParameters)
                                                                .ToList();
            XElement? returnValueSource = source.Descendants("simplesect")
                                                .SingleOrDefault(element => element.GetAttributeValue("kind") == "return");
            SimpleMarkupPortion returnValue = returnValueSource == null
                ? new List<SimpleMarkupEntry>()
                : ParseSimpleMarkup(returnValueSource);
            IList<MethodArg> methodArgs = source.Descendants("parameterlist")
                                                .Where(element => element.GetAttributeValue("kind") == "param")
                                                .SelectMany(ParseMethodArgs)
                                                .ToList();
            return new MethodDetailedDescription(templateParameters, methodArgs, returnValue, detailedDescription);
        }

    private static MarkupRef ParseMarkupRef(XElement source)
        {
            String refId = source.GetAttributeValue("refid");
            String? kind = source.FindAttributeValue("kindref");
            String? external = source.FindAttributeValue("external");
            String? tooltip = source.FindAttributeValue("tooltip");
            String text = source.Value;
            return new MarkupRef(refId, kind, external, tooltip, text);
        }

        private static ExternalLinkData ParseExternalLink(XElement source)
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
                                return EnumerableUtils.CreateSingle(new CodeBlockMarkupEntry.RefEntry(ParseMarkupRef(elementNode)));
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

        private static IList<CodeBlockMarkupLine> ParseCodeBlock(XElement source) =>
            source.Elements("codeline").Select(ParseCodeBlockLine).ToList();

        private static DetailedDescriptionMarkupEntry.ListEntry ParseMarkupList(XElement source)
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
            SimpleMarkupPortion description = ParseSimpleMarkup(source.Descendants("parameterdescription").Single());
            return new TemplateParameter(name, description);
        }

        private static TemplateParameters ParseTemplateParameters(XElement source) =>
            source.Elements("parameteritem").Select(ParseTemplateParameter).ToList();

        private static MethodArg ParseMethodArg(XElement source)
        {
            String name = source.Descendants("parametername").Single().Value;
            SimpleMarkupPortion description = ParseSimpleMarkup(source.Descendants("parameterdescription").Single());
            return new MethodArg(name, description);
        }

        private static MethodArgs ParseMethodArgs(XElement source) =>
            source.Elements("parameteritem").Select(ParseMethodArg).ToList();
    }
}
