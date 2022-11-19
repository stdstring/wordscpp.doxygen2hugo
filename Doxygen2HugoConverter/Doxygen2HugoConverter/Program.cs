using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Generator;
using Doxygen2HugoConverter.Refs;

namespace Doxygen2HugoConverter;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AppDescription);
        switch (ConfigParser.Parse(args))
        {
            case ConfigResult.VersionConfig config:
                Console.WriteLine($"Version: {config.Version}");
                break;
            case ConfigResult.HelpConfig config:
                Console.WriteLine(config.Help);
                break;
            case ConfigResult.WrongConfig config:
                Console.WriteLine(WrongConfig);
                Console.WriteLine(config.Help);
                break;
            case ConfigResult.MainConfig config:
                Convert(config.Data);
                break;
        }
    }

    private static void Convert(ConfigData configData)
    {
        IList<NamespaceRef> namespaceRefs = RefParser.ParseIndexFile(configData);
        IList<String> unusedNamespaces = new[] { "namespace_aspose", "namespacestd" };
        IDictionary<String, EntityDef> commonEntityRepo = new Dictionary<String, EntityDef>();
        List<EntityDef.NamespaceEntity> namespaceEntities = namespaceRefs.Where(namespaceRef => !unusedNamespaces.Contains(namespaceRef.RefId))
                                                                         .Select(namespaceRef => namespaceRef.ParseNamespaceFile(configData, commonEntityRepo))
                                                                         .ToList();
        namespaceEntities.GenerateForNamespaces(configData, commonEntityRepo);
        Console.WriteLine("That's all folks !!!");
    }

    private const String AppDescription = "Doxygen 2 HUGO converter for Aspose.Words for C++";
    private const String WrongConfig = "Wrong config data";
}