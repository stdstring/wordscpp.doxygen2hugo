using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Generator;
using Doxygen2HugoConverter.Lookup;
using Doxygen2HugoConverter.Refs;
using System.Xml.Serialization;

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
        LookupData sourceData = RetrieveSourceWeightData(configData);
        LookupManager lookupManager = new LookupManager(sourceData);
        using (LookupFrame rootFrame = lookupManager.EnterRootFrame())
            entities.GenerateForNamespaces(convertData, rootFrame);
        StoreDestWeightData(configData, lookupManager.GetDestData());
    }

    private static LookupData RetrieveSourceWeightData(ConfigData configData)
    {
        if (String.IsNullOrEmpty(configData.SourceWeightDataPath))
            return new LookupData(Common.DefaultWeightDelta);
        XmlSerializer serializer = new XmlSerializer(typeof(LookupData));
        using (StreamReader reader = new StreamReader(configData.SourceWeightDataPath!))
            return (LookupData)serializer.Deserialize(reader)!;
    }

    private static void StoreDestWeightData(ConfigData configData, LookupData destData)
    {
        if (String.IsNullOrEmpty(configData.DestWeightDataPath))
            return;
        XmlSerializer serializer = new XmlSerializer(typeof(LookupData));
        using (StreamWriter writer = new StreamWriter(configData.DestWeightDataPath!, false))
            serializer.Serialize(writer, destData);
    }
}