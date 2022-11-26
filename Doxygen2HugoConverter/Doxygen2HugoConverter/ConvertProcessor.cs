using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Generator;
using Doxygen2HugoConverter.Logger;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter;

internal static class ConvertProcessor
{
    public static void Convert(ConfigData configData)
    {
        ILogger logger = new ConsoleLogger(configData.LogLevel);
        IList<NamespaceRef> namespaceRefs = RefParser.ParseIndexFile(configData, logger);
        IList<String> unusedNamespaces = new[] {"namespace_aspose", "namespacestd"};
        IDictionary<String, EntityDef> commonEntityRepo = new Dictionary<String, EntityDef>();
        List<EntityDef.NamespaceEntity> namespaceEntities = namespaceRefs.Where(namespaceRef => !unusedNamespaces.Contains(namespaceRef.RefId))
                                                                         .Select(namespaceRef => namespaceRef.ParseNamespaceFile(configData, commonEntityRepo, logger))
                                                                         .ToList();
        namespaceEntities.GenerateForNamespaces(configData, commonEntityRepo, logger);
    }
}