using System.Text;
using Doxygen2HugoConverter.Markup;

namespace Doxygen2HugoConverter.Generator
{
    using SimpleMarkupPortion = IList<SimpleMarkupEntry>;
    using CodeBlockMarkupLine = IList<CodeBlockMarkupEntry>;
    using DetailedDescriptionPortion = IList<DetailedDescriptionMarkupEntry>;

    internal static class MarkupGenerator
    {
        public static String CreateBriefDescriptionForTitle(this SimpleMarkupPortion description)
        {
            StringBuilder result = new StringBuilder();
            foreach (SimpleMarkupEntry markupEntry in description)
            {
                switch (markupEntry)
                {
                    case SimpleMarkupEntry.TextEntry entry:
                        result.Append(entry.Text);
                        break;
                    case SimpleMarkupEntry.RefEntry entry:
                        result.Append(entry.Ref.Text);
                        break;
                }
            }
            // TODO (std_string) : think about removing call of Trim method
            return result.ToString().Trim();
        }

        // TODO (std_string) : think about name
        public static String CreateSimpleMarkup(this SimpleMarkupPortion description, Func<String, String?> relativeUrlGenerator)
        {
            StringBuilder result = new StringBuilder();
            description.Iterate(entry => entry.GenerateSimpleMarkupEntry(relativeUrlGenerator, result));
            // TODO (std_string) : think about removing call of Trim method
            return result.ToString().Trim();
        }

        public static void GenerateDetailedDescription(this DetailedDescriptionPortion detailedDescription, Func<String, String?> relativeUrlGenerator, StringBuilder dest)
        {
            foreach (DetailedDescriptionMarkupEntry part in detailedDescription)
            {
                switch (part)
                {
                    case DetailedDescriptionMarkupEntry.SimpleMarkupPartEntry entry:
                        entry.SimpleMarkup.GenerateSimpleMarkupEntry(relativeUrlGenerator, dest);
                        break;
                    case DetailedDescriptionMarkupEntry.TitleEntry entry:
                        GeneratorUtils.GenerateHeader(entry.Title, 2, dest);
                        break;
                    case DetailedDescriptionMarkupEntry.CodeBlockEntry entry:
                        entry.CodeBlockLines.GenerateCodeBlock(dest);
                        break;
                    case DetailedDescriptionMarkupEntry.ListEntry entry:
                        entry.GenerateList(relativeUrlGenerator, dest);
                        break;
                }
            }
        }

        private static void GenerateSimpleMarkupEntry(this SimpleMarkupEntry markupEntry, Func<String, String?> relativeUrlGenerator, StringBuilder dest)
        {
            switch (markupEntry)
            {
                case SimpleMarkupEntry.TextEntry entry:
                    dest.Append(entry.Text);
                    break;
                case SimpleMarkupEntry.RefEntry entry:
                    entry.GenerateRef(relativeUrlGenerator, dest);
                    break;
                case SimpleMarkupEntry.ExternalLinkEntry entry:
                    dest.Append(GeneratorUtils.CreateLink(entry.Link.Text, entry.Link.Url));
                    break;
                case SimpleMarkupEntry.ParagraphStartEntry:
                    dest.AppendLine();
                    break;
                case SimpleMarkupEntry.ParagraphEndEntry:
                    dest.AppendLine();
                    break;
                case SimpleMarkupEntry.BoldStartEntry:
                    dest.Append("**");
                    break;
                case SimpleMarkupEntry.BoldEndEntry:
                    dest.Append("**");
                    break;
                case SimpleMarkupEntry.LineBreakEntry:
                    dest.AppendLine();
                    break;
            }
        }

        private static void GenerateRef(this SimpleMarkupEntry.RefEntry entry, Func<String, String?> relativeUrlGenerator, StringBuilder dest)
        {
            switch (relativeUrlGenerator(entry.Ref.RefId))
            {
                case null:
                    dest.Append($"**{entry.Ref.Text}**");
                    break;
                case var relativeUrl:
                    dest.Append(GeneratorUtils.CreateLink(entry.Ref.Text, relativeUrl));
                    break;
            }
        }

        private static void GenerateCodeBlock(this IList<CodeBlockMarkupLine> codeBlock, StringBuilder dest)
        {
            dest.AppendLine();
            dest.AppendLine("```cpp");
            foreach (CodeBlockMarkupLine line in codeBlock)
            {
                foreach (CodeBlockMarkupEntry portion in line)
                {
                    switch (portion)
                    {
                        case CodeBlockMarkupEntry.TextEntry entry:
                            dest.Append(entry.Text);
                            break;
                        case CodeBlockMarkupEntry.HighlightStartEntry:
                            break;
                        case CodeBlockMarkupEntry.HighlightEndEntry:
                            break;
                        case CodeBlockMarkupEntry.SpaceEntry:
                            dest.Append(" ");
                            break;
                        case CodeBlockMarkupEntry.RefEntry entry:
                            dest.Append(entry.Ref.Text);
                            break;
                    }
                }
                dest.AppendLine();
            }
            dest.AppendLine("```");
        }

        private static void GenerateList(this DetailedDescriptionMarkupEntry.ListEntry listEntry, Func<String, String?> relativeUrlGenerator, StringBuilder dest)
        {
            String listMarker = listEntry.Ordered switch
            {
                true => "1. ",
                false => "* "
            };
            listEntry.Items.Iterate(item =>
            {
                StringBuilder line = new StringBuilder();
                item.Iterate(entry => entry.GenerateSimpleMarkupEntry(relativeUrlGenerator, line));
                dest.Append(listMarker);
                dest.AppendLine(line.ToString().Trim());
            });
            dest.AppendLine();
        }
    }
}
