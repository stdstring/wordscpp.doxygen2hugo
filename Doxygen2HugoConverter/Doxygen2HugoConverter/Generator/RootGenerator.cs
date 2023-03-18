using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using System.Text;
using Doxygen2HugoConverter.Lookup;

namespace Doxygen2HugoConverter.Generator
{
    internal static class RootGenerator
    {
        internal static void GenerateForNamespaces(this IList<EntityDef.NamespaceEntity> entities, ConvertData convertData, LookupFrame rootFrame)
        {
            String rootDirectory = PrepareDirectory(convertData.ConfigData);
            IList<String> rootUrl = new List<String>{Common.RootDirectory};
            GenerateState state = new GenerateState(rootDirectory, rootUrl, convertData);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(convertData.RootPageHeader);
            GeneratorUtils.GenerateHeader("Namespaces", 2, builder);
            GeneratorUtils.GenerateTableHeader(new[] {"Namespace", "Description"}, builder);
            rootFrame.FillKnownChildren(entities);
            entities.GenerateForChildren(rootFrame, (entity, childFrame) => entity.GenerateForNamespace(state, childFrame));
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
    }
}
