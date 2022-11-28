using Doxygen2HugoConverter.Entities;
using System.Text;

namespace Doxygen2HugoConverter.Generator
{
    internal static class EnumGenerator
    {
        public static void GenerateForEnum(this EntityDef.EnumEntity entity, GenerateState state)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String enumDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(enumDirectory);
            IList<String> enumUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = new GenerateState(enumDirectory, enumUrl, state.ConvertData);
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle();
            GeneratorUtils.GenerateDefPageHeader(entity.Name, descriptionForTitle, enumUrl, state.Weight, state.ConvertData.SpecificInfo, builder);
            state.IncreaseWeight();
            GeneratorUtils.GenerateHeader($"{entity.Name} enum", 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, currentState.ConvertData.Logger);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateEnumDefinition(builder);
            entity.Values.ProcessEnumValues(currentState, builder);
            builder.AppendLine();
            entity.DetailedDescription.GenerateDetailedDescription(CreateUrl, builder, currentState.ConvertData.Logger);
            entity.GenerateSeeAlso(currentState, builder);
            File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString());
        }

        public static IList<GenerateEntry> CreateEnumEntries(this IList<EntityDef.EnumEntity> entities, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            GenerateEntry CreateEntry(EntityDef.EnumEntity entity)
            {
                String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
                String title = GeneratorUtils.CreateLink(entity.Name, UrlGenerator.CreateChildUrl(folderName));
                String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger);
                return new GenerateEntry(title, briefDescription);
            }
            return entities.Select(CreateEntry).ToList();
        }

        private static void GenerateEnumDefinition(this EntityDef.EnumEntity entity, StringBuilder dest)
        {
            dest.AppendLine("```cpp");
            dest.Append($"enum class {entity.Name}");
            if (entity.BaseType != null)
                dest.Append($" : {entity.BaseType}");
            dest.AppendLine();
            dest.AppendLine("```");
            dest.AppendLine();
        }

        private static void ProcessEnumValues(this IList<EnumValueEntity> enumValues, GenerateState state, StringBuilder dest)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            GeneratorUtils.GenerateHeader("Values", 3, dest);
            GeneratorUtils.GenerateTableHeader(new[]{"Name", "Value", "Description"}, dest);
            foreach (EnumValueEntity enumValue in enumValues)
            {
                String valueBriefDescription = enumValue.BriefDescription.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger);
                String initializer = enumValue.Initializer switch
                {
                    null => "n/a",
                    var value => value.Value.ToString()
                };
                dest.AppendLine($"| {enumValue.Name} | {initializer} | {valueBriefDescription} |");
            }
        }

        private static void GenerateSeeAlso(this EntityDef.EnumEntity entity, GenerateState state, StringBuilder dest)
        {
            GeneratorUtils.GenerateHeader("See Also", 2, dest);
            entity.GenerateSeeAlsoCommonPart(state.ConvertData.EntityRepo, state.ConvertData.SpecificInfo, dest);
        }
    }
}
