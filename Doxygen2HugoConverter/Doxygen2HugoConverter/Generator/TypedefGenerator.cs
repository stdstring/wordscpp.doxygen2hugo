using Doxygen2HugoConverter.Entities;
using System.Text;

namespace Doxygen2HugoConverter.Generator
{
    internal static class TypedefGenerator
    {
        public static void GenerateForTypedef(this EntityDef.TypedefEntity entity, GenerateState state)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String typedefDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(typedefDirectory);
            IList<String> typedefUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = state with {Directory = typedefDirectory, Url = typedefUrl};
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle();
            GeneratorUtils.GenerateDefPageHeader(entity.Name, descriptionForTitle, typedefUrl, state.Weight, builder);
            state.IncreaseWeight();
            GeneratorUtils.GenerateHeader($"{entity.Name} typedef", 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateTypedefDefinition(builder);
            entity.DetailedDescription.GenerateDetailedDescription(CreateUrl, builder);
            File.AppendAllText(Path.Combine(typedefDirectory, Common.MarkdownFilename), builder.ToString());
        }

        public static IList<GenerateEntry> GetTypedefEntries(this IList<EntityDef.TypedefEntity> entities, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            GenerateEntry CreateEntry(EntityDef.TypedefEntity entity)
            {
                String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
                String title = GeneratorUtils.CreateLink(entity.Name, UrlGenerator.CreateChildUrl(folderName));
                String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
                return new GenerateEntry(title, briefDescription);
            }
            return entities.Select(CreateEntry).ToList();
        }

        private static void GenerateTypedefDefinition(this EntityDef.TypedefEntity entity, StringBuilder dest)
        {
            if (String.IsNullOrEmpty(entity.Definition))
                return;
            dest.AppendLine("```cpp");
            dest.AppendLine(entity.Definition.Trim());
            dest.AppendLine("```");
            dest.AppendLine();
        }
    }
}
