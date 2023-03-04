using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Generator;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter;

internal static class ConvertProcessor
{
    public static void Convert(ConfigData configData)
    {
        ConvertData convertData = ConvertData.Create(configData);
        IList<NamespaceRef> namespaceRefs = RefParser.ParseIndexFile(convertData);
        List<EntityDef.NamespaceEntity> entities = namespaceRefs.Where(namespaceRef => namespaceRef.Name.StartsWith(configData.NamespacePrefix))
                                                                .Select(namespaceRef => namespaceRef.ParseNamespaceFile(convertData))
                                                                .ToList();
        entities.GenerateForNamespaces(convertData);
    }
}