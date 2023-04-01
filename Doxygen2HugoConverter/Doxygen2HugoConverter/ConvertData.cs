using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Logger;

namespace Doxygen2HugoConverter
{
    internal record ConvertData(ConfigData ConfigData,
                                String RootPageHeader,
                                String LibraryName,
                                Func<IDictionary<String, String>, String> PageHeaderGenerator,
                                ILogger Logger)
    {
        public IDictionary<String, EntityDef> EntityRepo = new Dictionary<String, EntityDef>();

        public static ConvertData Create(ConfigData configData)
        {
            const String rootPageHeaderTemplateFilename = "rootfrontmatters.md";
            const String pageHeaderTemplateFilename = "frontmatters.md";
            const String titleKey = "title";
            String rootPageHeaderTemplate = File.ReadAllText(Path.Combine(configData.TemplatesDirectory, rootPageHeaderTemplateFilename));
            String pageHeaderTemplate = File.ReadAllText(Path.Combine(configData.TemplatesDirectory, pageHeaderTemplateFilename));
            IDictionary<String, String> rootPageHeaderTemplateData = HeaderUtils.ParseData(rootPageHeaderTemplate);
            String libraryName = rootPageHeaderTemplateData[titleKey];
            Func<IDictionary<String, String>, String> pageHeaderGenerator = HeaderTemplateFactory.CreateFromSource(pageHeaderTemplate);
            ILogger logger = new ConsoleLogger(configData.LogLevel);
            return new ConvertData(configData, rootPageHeaderTemplate, libraryName, pageHeaderGenerator, logger);
        }
    }
}
