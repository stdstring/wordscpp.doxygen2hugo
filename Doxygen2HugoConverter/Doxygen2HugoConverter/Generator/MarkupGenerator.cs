using System.Text;
using Doxygen2HugoConverter.Logger;
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
        public static String CreateSimpleMarkup(this SimpleMarkupPortion description, Func<String, String?> relativeUrlGenerator, ILogger logger)
        {
            StringBuilder result = new StringBuilder();
            description.Iterate(entry => entry.GenerateSimpleMarkupEntry(relativeUrlGenerator, result, logger));
            // TODO (std_string) : think about removing call of Trim method (probably use more smart solution)
            return result.ToString().Trim();
        }

        public static void GenerateDetailedDescription(this DetailedDescriptionPortion detailedDescription, Func<String, String?> relativeUrlGenerator, StringBuilder dest, ILogger logger)
        {
            foreach (DetailedDescriptionMarkupEntry part in detailedDescription)
            {
                switch (part)
                {
                    case DetailedDescriptionMarkupEntry.TextEntry entry:
                        dest.Append(entry.Text);
                        break;
                    case DetailedDescriptionMarkupEntry.RefEntry entry:
                        entry.Ref.GenerateRef(relativeUrlGenerator, dest, logger);
                        break;
                    case DetailedDescriptionMarkupEntry.ExternalLinkEntry entry:
                        entry.Link.GenerateExternalLink(dest, logger);
                        break;
                    case DetailedDescriptionMarkupEntry.ParagraphStartEntry:
                        dest.AppendLine();
                        break;
                    case DetailedDescriptionMarkupEntry.ParagraphEndEntry:
                        dest.AppendLine();
                        break;
                    case DetailedDescriptionMarkupEntry.BoldStartEntry:
                        dest.Append("**");
                        break;
                    case DetailedDescriptionMarkupEntry.BoldEndEntry:
                        dest.Append("**");
                        break;
                    case DetailedDescriptionMarkupEntry.LineBreakEntry:
                        dest.AppendLine();
                        break;
                    case DetailedDescriptionMarkupEntry.TitleEntry entry:
                        GeneratorUtils.GenerateHeader(entry.Title, 2, dest);
                        break;
                    case DetailedDescriptionMarkupEntry.CodeBlockEntry entry:
                        entry.CodeBlockLines.GenerateCodeBlock(dest);
                        break;
                    case DetailedDescriptionMarkupEntry.ListEntry entry:
                        entry.GenerateList(relativeUrlGenerator, dest, logger);
                        break;
                }
            }
        }

        private static void GenerateSimpleMarkupEntry(this SimpleMarkupEntry markupEntry, Func<String, String?> relativeUrlGenerator, StringBuilder dest, ILogger logger)
        {
            switch (markupEntry)
            {
                case SimpleMarkupEntry.TextEntry entry:
                    dest.Append(entry.Text);
                    break;
                case SimpleMarkupEntry.RefEntry entry:
                    entry.Ref.GenerateRef(relativeUrlGenerator, dest, logger);
                    break;
                case SimpleMarkupEntry.ExternalLinkEntry entry:
                    entry.Link.GenerateExternalLink(dest, logger);
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

        private static void GenerateRef(this MarkupRef reference, Func<String, String?> relativeUrlGenerator, StringBuilder dest, ILogger logger)
        {
            switch (reference.RefId)
            {
                case "":
                    logger.LogInfo($"Resolved ref for parent of \"{reference.Text}\"");
                    dest.Append(GeneratorUtils.CreateLink(reference.Text, Common.ParentUrl));
                    break;
                default:
                    switch (relativeUrlGenerator(reference.RefId))
                    {
                        case null:
                            logger.LogWarning($"Can't resolve ref with id = \"{reference.RefId}\" text = \"{reference.Text}\", kind = \"{reference.Kind}\", external = \"{reference.External}\"");
                            dest.Append($"**{reference.Text}**");
                            break;
                        case var relativeUrl:
                            logger.LogInfo($"Resolved ref for \"{reference.Text}\": {relativeUrl}");
                            dest.Append(GeneratorUtils.CreateLink(reference.Text, relativeUrl));
                            break;
                    }
                    break;
            }
        }

        private static void GenerateExternalLink(this ExternalLinkData link, StringBuilder dest, ILogger logger)
        {
            String url = link.Url;
            if (url.StartsWith(Common.AsposeDocsPrefix))
                url = url.Replace("/net/", "/cpp/");
            logger.LogInfo($"Process external link for \"{link.Text}\": {url}");
            dest.Append(GeneratorUtils.CreateLink(link.Text, url));
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

        private static void GenerateList(this DetailedDescriptionMarkupEntry.ListEntry listEntry, Func<String, String?> relativeUrlGenerator, StringBuilder dest, ILogger logger)
        {
            String listMarker = listEntry.Ordered switch
            {
                true => "1. ",
                false => "* "
            };
            listEntry.Items.Iterate(item =>
            {
                StringBuilder line = new StringBuilder();
                item.Iterate(entry => entry.GenerateSimpleMarkupEntry(relativeUrlGenerator, line, logger));
                dest.Append(listMarker);
                dest.AppendLine(line.ToString().Trim());
            });
            dest.AppendLine();
        }
    }
}
