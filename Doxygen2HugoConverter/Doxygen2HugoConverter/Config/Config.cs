namespace Doxygen2HugoConverter.Config
{
    internal record ConfigData(String SourceDirectory, String DestDirectory);

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
            String[] mandatoryKeys = {SourceKey, DestKey};
            foreach (String key in mandatoryKeys)
            {
                if (!configData.ContainsKey(key) || String.IsNullOrEmpty(configData[key]))
                    return new ConfigResult.WrongConfig(Help);
            }
            ConfigData data = new ConfigData(configData[SourceKey], configData[DestKey]);
            return new ConfigResult.MainConfig(data);
        }

        public const String SourceKey = "--source";

        public const String DestKey = "--dest";

        public const String HelpKey = "--help";

        public const String VersionKey = "--version";

        public const String Version = "0.0.1";

        /*public const String Help = "Doxygen 2 HUGO converter for Aspose.Words for C++\n" +
                                   "Usage: <app> --source=<source-directory> --dest=<dest-directory>";*/
        public const String Help = "Usage: <app> --source=<source-directory> --dest=<dest-directory>";
    }
}
