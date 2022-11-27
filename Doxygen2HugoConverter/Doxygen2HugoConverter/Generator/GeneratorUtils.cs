using System.Text;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Logger;
using Doxygen2HugoConverter.Markup;

namespace Doxygen2HugoConverter.Generator
{
    using TemplateParameters = IList<TemplateParameter>;

    internal record GenerateEntry(String Title, String BriefDescription);

    internal record GenerateState(String Directory, IList<String> Url, ConvertData ConvertData)
    {
        public Int32 Weight { get; private set; } = 1;

        public void IncreaseWeight()
        {
            Weight += WeightDelta;
        }

        private const Int32 WeightDelta = 13;
    }

    internal static class GeneratorUtils
    {
        public static void GeneratePageHeader(IEnumerable<KeyValuePair<String, String>> data, StringBuilder dest)
        {
            dest.AppendLine("---");
            data.Iterate(item => { dest.AppendLine($"{item.Key}: {item.Value}"); });
            dest.AppendLine("---");
        }

        public static void GenerateDefPageHeader(String title, String description, IList<String> url, Int32 weight, StringBuilder dest)
        {
            String PrepareValue(String value) =>
                value.IndexOf(':') switch
                {
                    -1 => value,
                    _ => $"'{value}'"
                };
            KeyValuePair<String, String>[] data =
            {
                KeyValuePair.Create("title", PrepareValue(title)),
                KeyValuePair.Create("second_title", "Aspose.Words for C++ API Reference"),
                KeyValuePair.Create("description", PrepareValue(description)),
                KeyValuePair.Create("type", "docs"),
                KeyValuePair.Create("weight", weight.ToString()),
                KeyValuePair.Create("url", UrlGenerator.CreateUrl(url, false))
            };
            GeneratePageHeader(data, dest);
        }

        public static void GenerateHeader(String headerText, Int32 headerLevel, StringBuilder dest)
        {
            StringBuilder header = new StringBuilder();
            header.Append(new String('#', headerLevel)).Append(' ').AppendLine(headerText).AppendLine();
            dest.Append(header.ToString());
        }

        public static void GenerateTableHeader(IList<String> columnHeaders, StringBuilder dest)
        {
            dest.Append("|");
            columnHeaders.Iterate(header => { dest.Append($" {header} |"); });
            dest.AppendLine();
            dest.Append("|");
            Enumerable.Range(1, columnHeaders.Count).Iterate(_ => { dest.Append(" --- |"); });
            dest.AppendLine();
        }

        public static void GenerateTemplateParameters(this TemplateParameters templateParameters, Func<String, String?> relativeUrlGenerator, StringBuilder dest, ILogger logger)
        {
            if (templateParameters.IsEmpty())
                return;
            dest.AppendLine();
            GenerateTableHeader(new[]{"Parameter", "Description"}, dest);
            foreach (TemplateParameter templateParameter in templateParameters)
            {
                String parameterDescription = templateParameter.Description.CreateSimpleMarkup(relativeUrlGenerator, logger);
                dest.AppendLine($"| {templateParameter.Name} | {parameterDescription} |");
            }
        }

        public static String CreateLink(String name, String url) => $"[{name}]({url})";

        public static void GenerateSeeAlsoCommonPart(this EntityDef definition, IDictionary<String, EntityDef> commonEntityRepo, StringBuilder dest)
        {
            IList<EntityDef> CreateParentList()
            {
                IList<EntityDef> parentList = new List<EntityDef>();
                EntityDef? current = definition;
                while (current != null)
                {
                    switch (current)
                    {
                        case EntityDef.NamespaceEntity:
                            current = null;
                            break;
                        case EntityDef.ClassEntity entity:
                            parentList.Add(current = commonEntityRepo[entity.ParentId]);
                            break;
                        case EntityDef.MethodEntity entity:
                            parentList.Add(current = commonEntityRepo[entity.ParentId]);
                            break;
                        case EntityDef.FieldEntity entity:
                            parentList.Add(current = commonEntityRepo[entity.ParentId]);
                            break;
                        case EntityDef.EnumEntity entity:
                            parentList.Add(current = commonEntityRepo[entity.ParentId]);
                            break;
                        case EntityDef.TypedefEntity entity:
                            parentList.Add(current = commonEntityRepo[entity.ParentId]);
                            break;
                    }
                }
                return parentList;
            }
            StringBuilder parentUrl = new StringBuilder();
            IList<EntityDef> parentList = CreateParentList();
            foreach (EntityDef parent in parentList)
            {
                parentUrl.Append(Common.ParentUrl);
                switch (parent)
                {
                    case EntityDef.NamespaceEntity entity:
                        dest.AppendLine($"* Namespace {CreateLink(entity.Name, parentUrl.ToString())}");
                        break;
                    case EntityDef.ClassEntity entity:
                        dest.AppendLine($"* Class {CreateLink(entity.Name, parentUrl.ToString())}");
                        break;
                    //case EntityDef.MethodEntity entity:
                    //    break;
                    //case EntityDef.FieldEntity entity:
                    //    break;
                    //case EntityDef.EnumEntity entity:
                    //    break;
                    //case EntityDef.TypedefEntity entity:
                    //    break;
                }
            }
            parentUrl.Append(Common.ParentUrl);
            dest.AppendLine($"* Library {CreateLink("Aspose.Words", parentUrl.ToString())}");
        }
    }
}
