namespace Doxygen2HugoConverter.Markup
{
    using SimpleMarkupPortion = IList<SimpleMarkupEntry>;
    using CodeBlockMarkupLine = IList<CodeBlockMarkupEntry>;
    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;
    using TemplateParameters = IList<TemplateParameter>;
    using MethodArgs = IList<MethodArg>;

    // TODO (std_string) : think about moving data into RefEntry
    internal record MarkupRef(String RefId, String? Kind, String? External, String? Tooltip, String Text);

    // TODO (std_string) : think about moving data into ExternalLinkEntry
    internal record ExternalLinkData(String Url, String Text);

    internal abstract record SimpleMarkupEntry
    {
        internal record TextEntry(String Text) : SimpleMarkupEntry;

        internal record ParagraphStartEntry : SimpleMarkupEntry;

        internal record ParagraphEndEntry : SimpleMarkupEntry;

        internal record BoldStartEntry : SimpleMarkupEntry;

        internal record BoldEndEntry : SimpleMarkupEntry;

        internal record LineBreakEntry : SimpleMarkupEntry;

        internal record RefEntry(MarkupRef Ref) : SimpleMarkupEntry;

        internal record ExternalLinkEntry(ExternalLinkData Link) : SimpleMarkupEntry;

        private SimpleMarkupEntry()
        {
        }
    }

    internal abstract record CodeBlockMarkupEntry
    {
        internal record TextEntry(String Text) : CodeBlockMarkupEntry;

        internal record HighlightStartEntry(String HighlightClass) : CodeBlockMarkupEntry;

        internal record HighlightEndEntry : CodeBlockMarkupEntry;

        internal record SpaceEntry : CodeBlockMarkupEntry;

        internal record RefEntry(MarkupRef Ref) : CodeBlockMarkupEntry;

        private CodeBlockMarkupEntry()
        {
        }
    }

    internal abstract record DetailedDescriptionMarkupEntry
    {
        // TODO (std_string) : think about replacing by direct cases
        internal record SimpleMarkupPartEntry(SimpleMarkupEntry SimpleMarkup) : DetailedDescriptionMarkupEntry;

        internal record TitleEntry(String Title) : DetailedDescriptionMarkupEntry;

        internal record CodeBlockEntry(IList<CodeBlockMarkupLine> CodeBlockLines) : DetailedDescriptionMarkupEntry;

        internal record ListEntry(Boolean Ordered, IList<SimpleMarkupPortion> Items) : DetailedDescriptionMarkupEntry;

        private DetailedDescriptionMarkupEntry()
        {
        }
    }

    internal record TemplateParameter(String Name, SimpleMarkupPortion Description);

    internal record ClassDetailedDescription(TemplateParameters TemplateParameters, DetailedDescriptionPortion Description);

    internal record MethodArg(String Name, SimpleMarkupPortion Description);

    internal record MethodDetailedDescription(TemplateParameters TemplateParameters,
                                              MethodArgs Args,
                                              SimpleMarkupPortion ReturnValue,
                                              DetailedDescriptionPortion Description);
}
