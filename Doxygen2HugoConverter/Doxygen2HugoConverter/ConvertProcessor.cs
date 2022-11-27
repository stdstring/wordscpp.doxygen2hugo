using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Generator;
using Doxygen2HugoConverter.Logger;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter;

internal record ConvertData(ConfigData ConfigData, IDictionary<String, EntityDef> EntityRepo, ILogger Logger);

internal static class ConvertProcessor
{
    public static void Convert(ConfigData configData)
    {
        ILogger logger = new ConsoleLogger(configData.LogLevel);
        IDictionary<String, EntityDef> entityRepo = new Dictionary<String, EntityDef>();
        ConvertData convertData = new ConvertData(configData, entityRepo, logger);
        IList<NamespaceRef> namespaceRefs = RefParser.ParseIndexFile(convertData);
        IList<String> unusedNamespaces = new[] {"namespace_aspose", "namespacestd"};
        List<EntityDef.NamespaceEntity> namespaceEntities = namespaceRefs.Where(namespaceRef => !unusedNamespaces.Contains(namespaceRef.RefId))
                                                                         .Select(namespaceRef => namespaceRef.ParseNamespaceFile(convertData))
                                                                         .ToList();
        namespaceEntities.GenerateForNamespaces(convertData);
    }
}