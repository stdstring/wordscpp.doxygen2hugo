using Doxygen2HugoConverter.Logger;

namespace Doxygen2HugoConverter.Config
{
    internal record ConfigData(String SourceDirectory,
                               String DestDirectory,
                               String TemplatesDirectory,
                               String NamespacePrefix,
                               LogLevel LogLevel,
                               String? SourceWeightDataPath,
                               String? DestWeightDataPath);

    internal abstract record ConfigResult
    {
        internal record VersionConfig(String Version) : ConfigResult;

        internal record HelpConfig(String Help) : ConfigResult;

        internal record MainConfig(ConfigData Data) : ConfigResult;

        internal record WrongConfig(String Help) : ConfigResult;

        private ConfigResult()
        {
        }
    }

    internal static class ConfigParser
    {
        public static ConfigResult Parse(String[] args)
        {
            switch (args)
            {
                case var _ when args.IsEmpty():
                    return new ConfigResult.HelpConfig(Help);
                case var _ when (args.Length == 1) && (args[0] == VersionKey):
                    return new ConfigResult.VersionConfig(Version);
                case var _ when (args.Length == 1) && (args[0] == HelpKey):
                    return new ConfigResult.HelpConfig(Help);
                default:
                    return ProcessMainConfig(args);
            }
        }

        private static bool CheckConfigKeys(IDictionary<String, String> configData)
        {
            // check mandatory keys
            String[] mandatoryKeys = {SourceKey, DestKey, TemplatesKey, NamespaceKey};
            if (mandatoryKeys.Any(key => !configData.ContainsKey(key) || String.IsNullOrEmpty(configData[key])))
                return false;
            // check actual keys
            ISet<String> allKeys = new HashSet<String> {SourceKey, DestKey, TemplatesKey, NamespaceKey, LogLevelKey, SourceWeightDataKey, DestWeightDataKey};
            if (configData.Keys.Any(key => !allKeys.Contains(key)))
                return false;
            return true;
        }

        private static Tuple<Boolean, LogLevel> ParseLogLevel(IDictionary<String, String> configData) =>
            configData.ContainsKey(LogLevelKey) switch
            {
                false => new Tuple<Boolean, LogLevel>(true, LogLevel.Info),
                true => configData[LogLevelKey] switch
                {
                    "info" => new Tuple<Boolean, LogLevel>(true, LogLevel.Info),
                    "warning" => new Tuple<Boolean, LogLevel>(true, LogLevel.Warning),
                    "error" => new Tuple<Boolean, LogLevel>(true, LogLevel.Error),
                    _ => new Tuple<Boolean, LogLevel>(false, LogLevel.Error)
                }
            };

        private static ConfigResult ProcessMainConfig(String[] args)
        {
            const Char keyValueDelimiter = '=';
            IDictionary<String, String> configData = new Dictionary<String, String>();
            foreach (String arg in args)
            {
                switch (arg.Split(keyValueDelimiter))
                {
                    case var parts when parts.Length == 2:
                        configData[parts[0]] = parts[1];
                        break;
                    default:
                        return new ConfigResult.WrongConfig(Help);
                }
            }
            if (!CheckConfigKeys(configData))
                return new ConfigResult.WrongConfig(Help);
            (Boolean parseLogLevelResult, LogLevel logLevel) = ParseLogLevel(configData);
            if (!parseLogLevelResult)
                return new ConfigResult.WrongConfig(Help);
            String? sourceWeightDataPath = configData.ContainsKey(SourceWeightDataKey) ? configData[SourceWeightDataKey] :null;
            String? destWeightDataPath = configData.ContainsKey(DestWeightDataKey) ? configData[DestWeightDataKey] : null;
            ConfigData data = new ConfigData(configData[SourceKey],
                                             configData[DestKey],
                                             configData[TemplatesKey],
                                             configData[NamespaceKey],
                                             logLevel,
                                             sourceWeightDataPath,
                                             destWeightDataPath);
            return new ConfigResult.MainConfig(data);
        }

        public const String SourceKey = "--source";

        public const String DestKey = "--dest";

        public const String TemplatesKey = "--templates";

        public const String NamespaceKey = "--namespace";

        public const String LogLevelKey = "--log-level";

        public const String SourceWeightDataKey = "--source-weight";

        public const String DestWeightDataKey = "--dest-weight";

        public const String HelpKey = "--help";

        public const String VersionKey = "--version";

        public const String Version = "0.0.2";

        public const String Help = "Usage: <app> " +
                                   "--source=<source directory> " +
                                   "--dest=<dest directory> " +
                                   "--templates=<templates directory> " +
                                   "--namespace=<namespace prefix, e.g. Aspose::Words> " +
                                   "--log-level=<info|warning|error (default info)> " +
                                   "--source-weight=<path to source weight data (optional)> " +
                                   "--dest-weight=<path to dest weight data (optional)>";
    }
}
