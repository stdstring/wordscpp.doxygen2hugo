using Doxygen2HugoConverter.Entities;

namespace Doxygen2HugoConverter.Generator
{
    internal static class UrlGenerator
    {
        public static IList<String> CreateUrlForEntity(String entityId, GenerateState state)
        {
            IList<String> dependencyChain = new List<String>();
            EntityDef? current = state.CommonEntityRepo[entityId];
            while (current != null)
            {
                switch (current)
                {
                    case EntityDef.NamespaceEntity entity:
                        dependencyChain.Add(NameUtils.CreateNamespaceFolderName(entity.Name));
                        current = null;
                        break;
                    case EntityDef.ClassEntity entity:
                        dependencyChain.Add(NameUtils.CreateSimpleFolderName(entity.Name));
                        current = state.CommonEntityRepo[entity.ParentId];
                        break;
                    case EntityDef.EnumEntity entity:
                        dependencyChain.Add(NameUtils.CreateSimpleFolderName(entity.Name));
                        current = state.CommonEntityRepo[entity.ParentId];
                        break;
                    case EntityDef.TypedefEntity entity:
                        dependencyChain.Add(NameUtils.CreateSimpleFolderName(entity.Name));
                        current = state.CommonEntityRepo[entity.ParentId];
                        break;
                    case EntityDef.MethodEntity entity:
                        dependencyChain.Add(NameUtils.CreateSimpleFolderName(entity.Name));
                        current = state.CommonEntityRepo[entity.ParentId];
                        break;
                    case EntityDef.FieldEntity entity:
                        dependencyChain.Add(NameUtils.CreateSimpleFolderName(entity.Name));
                        current = state.CommonEntityRepo[entity.ParentId];
                        break;
                }
            }
            dependencyChain.Add(Common.RootDirectory);
            return dependencyChain.Reverse().ToList();
        }

        public static IList<String> CreateRelativeUrl(IList<String> sourceUrl, IList<String> destUrl)
        {
            Int32 commonPrefixLength = 0;
            for (Int32 index = 0; (index < sourceUrl.Count) && (index < destUrl.Count); ++index)
            {
                if (sourceUrl[index] != destUrl[index])
                    break;
                ++commonPrefixLength;
            }
            List<String> relativeUrl = new List<String>();
            switch (commonPrefixLength)
            {
                case var _ when commonPrefixLength == sourceUrl.Count:
                    relativeUrl.Add(".");
                    break;
                default:
                    Enumerable.Range(1, sourceUrl.Count - commonPrefixLength).Iterate(_ => { relativeUrl.Add(".."); });
                    break;
            }
            relativeUrl.AddRange(destUrl.Skip(commonPrefixLength));
            return relativeUrl.ToList();
        }

        public static String? CreateRelativeUrlForEntity(String entityId, GenerateState state)
        {
            if (!state.CommonEntityRepo.ContainsKey(entityId))
                return null;
            IList<String> entityUrl = CreateUrlForEntity(entityId, state);
            IList<String> relativeUrl = CreateRelativeUrl(state.Url, entityUrl);
            return CreateUrl(relativeUrl, true);
        }

        public static String CreateUrl(IList<String> url, Boolean isRelative)
        {
            String result = String.Join("/", url);
            return isRelative switch
            {
                true => $"{result}/",
                false => $"/{result}/"
            };
        }

        public static String CreateChildUrl(String folderName) => $"./{folderName}/";
    }
}
