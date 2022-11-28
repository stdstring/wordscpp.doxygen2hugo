using System.Xml.Serialization;
using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Generator;
using Doxygen2HugoConverter.Logger;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter;

internal record ConvertData(ConfigData ConfigData, SpecificInfo SpecificInfo, IDictionary<String, EntityDef> EntityRepo, ILogger Logger);

internal static class ConvertProcessor
{
    public static void Convert(ConfigData configData)
    {
        ILogger logger = new ConsoleLogger(configData.LogLevel);
        IDictionary<String, EntityDef> entityRepo = new Dictionary<String, EntityDef>();
        SpecificInfo specificInfo = ReadSpecificInfo(configData.SpecificInfoSource);
        ConvertData convertData = new ConvertData(configData, specificInfo, entityRepo, logger);
        IList<NamespaceRef> namespaceRefs = RefParser.ParseIndexFile(convertData);
        List<EntityDef.NamespaceEntity> entities = namespaceRefs.Where(namespaceRef => !specificInfo.IngoredNamespaces.Contains(namespaceRef.RefId))
                                                                .Select(namespaceRef => namespaceRef.ParseNamespaceFile(convertData))
                                                                .ToList();
        entities.GenerateForNamespaces(convertData);
    }

    private static SpecificInfo ReadSpecificInfo(String specificInfoSource)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(SpecificInfo));
        using StreamReader source = new StreamReader(specificInfoSource);
        return (SpecificInfo)serializer.Deserialize(source)!;
    }
}