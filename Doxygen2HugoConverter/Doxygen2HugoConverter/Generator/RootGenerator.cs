using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using System.Text;
using Doxygen2HugoConverter.Logger;

namespace Doxygen2HugoConverter.Generator
{
    internal static class RootGenerator
    {
        internal static void GenerateForNamespaces(this IList<EntityDef.NamespaceEntity> entities, ConfigData config, IDictionary<string, EntityDef> commonEntityRepo, ILogger logger)
        {
            String rootDirectory = PrepareDirectory(config);
            IList<String> rootUrl = new List<String>{Common.RootDirectory};
            GenerateState state = new GenerateState(rootDirectory, rootUrl, commonEntityRepo, logger);
            StringBuilder builder = new StringBuilder();
            GenerateRootPageHeader(builder, rootUrl);
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

        public static void GenerateRootPageHeader(StringBuilder dest, IList<String> url)
        {
            KeyValuePair<String, String>[] data =
            {
                KeyValuePair.Create("title", "Aspose.Words for C++"),
                KeyValuePair.Create("type", "docs"),
                KeyValuePair.Create("weight", "666"),
                KeyValuePair.Create("url", UrlGenerator.CreateUrl(url, false)),
                KeyValuePair.Create("keywords", "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\""),
                KeyValuePair.Create("description","Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks."),
                KeyValuePair.Create("is_root", "true")
            };
            GeneratorUtils.GeneratePageHeader(data, dest);
        }
    }
}
