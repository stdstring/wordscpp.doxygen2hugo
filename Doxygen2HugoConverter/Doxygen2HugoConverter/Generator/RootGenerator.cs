using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using System.Text;

namespace Doxygen2HugoConverter.Generator
{
    internal static class RootGenerator
    {
        internal static void GenerateForNamespaces(this IList<EntityDef.NamespaceEntity> entities, ConvertData convertData)
        {
            String rootDirectory = PrepareDirectory(convertData.ConfigData);
            IList<String> rootUrl = new List<String>{Common.RootDirectory};
            GenerateState state = new GenerateState(rootDirectory, rootUrl, convertData);
            StringBuilder builder = new StringBuilder();
            GenerateRootPageHeader(convertData.SpecificInfo, rootUrl, builder);
            GeneratorUtils.GenerateHeader("Namespaces", 2, builder);
            GeneratorUtils.GenerateTableHeader(new[] {"Namespace", "Description"}, builder);
            entities.Iterate(entity => { entity.GenerateForNamespace(state); });
            entities.CreateNamespaceEntries(state).Iterate(entry => { builder.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
            File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString());
        }

        private static String PrepareDirectory(ConfigData config)
        {
            String rootDirectory = Path.Combine(config.DestDirectory, Common.RootDirectory);
            if (Directory.Exists(rootDirectory))
                Directory.Delete(rootDirectory, true);
            Directory.CreateDirectory(rootDirectory);
            return rootDirectory;
        }

        public static void GenerateRootPageHeader(SpecificInfo specificInfo, IList<String> url, StringBuilder dest)
        {
            KeyValuePair<String, String>[] data =
            {
                KeyValuePair.Create("title", specificInfo.RootPageTitle),
                KeyValuePair.Create("type", "docs"),
                KeyValuePair.Create("weight", "666"),
                KeyValuePair.Create("url", UrlGenerator.CreateUrl(url, false)),
                KeyValuePair.Create("keywords", specificInfo.RootPageKeywords),
                KeyValuePair.Create("description",specificInfo.RootPageDescription),
                KeyValuePair.Create("is_root", "true")
            };
            GeneratorUtils.GeneratePageHeader(data, dest);
        }
    }
}
