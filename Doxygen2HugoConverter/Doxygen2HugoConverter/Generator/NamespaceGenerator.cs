using System.Text;
using Doxygen2HugoConverter.Entities;

namespace Doxygen2HugoConverter.Generator
{
    internal static class NamespaceGenerator
    {
        public static void GenerateForNamespace(this EntityDef.NamespaceEntity entity, GenerateState state)
        {
            Boolean isEmptyNamespaces = entity.Enums.IsEmpty() &&
                                        entity.Typedefs.IsEmpty() &&
                                        entity.Classes.IsEmpty() &&
                                        entity.Interfaces.IsEmpty();
            if (isEmptyNamespaces)
                return;
            String folderName = NameUtils.CreateNamespaceFolderName(entity.Name);
            String namespaceDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(namespaceDirectory);
            IList<String> namespaceUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = new GenerateState(namespaceDirectory, namespaceUrl, state.ConvertData);
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle();
            GeneratorUtils.GenerateDefPageHeader(entity.Name, descriptionForTitle, namespaceUrl, state.Weight, builder);
            state.IncreaseWeight();
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, currentState.ConvertData.Logger);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.Classes.ProcessClassType(currentState, ClassKind.Class, builder);
            entity.Interfaces.ProcessClassType(currentState, ClassKind.Interface, builder);
            entity.Enums.ProcessEnums(currentState, builder);
            entity.Typedefs.ProcessTypedefs(currentState, builder);
            File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString());
        }

        public static IList<GenerateEntry> CreateNamespaceEntries(this IList<EntityDef.NamespaceEntity> entities, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            GenerateEntry? CreateEntry(EntityDef.NamespaceEntity entity)
            {
                Boolean isEmptyNamespaces = entity.Enums.IsEmpty() &&
                                            entity.Typedefs.IsEmpty() &&
                                            entity.Classes.IsEmpty() &&
                                            entity.Interfaces.IsEmpty();
                if (isEmptyNamespaces)
                    return null;
                String folderName = NameUtils.CreateNamespaceFolderName(entity.Name);
                String title = GeneratorUtils.CreateLink(entity.Name, UrlGenerator.CreateChildUrl(folderName));
                String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger);
                return new GenerateEntry(title, briefDescription);
            }
            return entities.Choose(CreateEntry).ToList();
        }

        private static void ProcessClassType(this IList<EntityDef.ClassEntity> classEntities, GenerateState state, ClassKind kind, StringBuilder dest)
        {
            if (classEntities.IsEmpty())
                return;
            String kindSingular = kind switch
            {
                ClassKind.Class => "Class",
                ClassKind.Interface => "Interface",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
            String kindPlural = kind switch
            {
                ClassKind.Class => "Classes",
                ClassKind.Interface => "Interfaces",
                _ => throw new ArgumentOutOfRangeException(nameof(kind), kind, null)
            };
            GeneratorUtils.GenerateHeader(kindPlural, 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {kindSingular, "Description"}, dest);
            classEntities.Iterate(entity => entity.GenerateForClass(state));
            classEntities.CreateClassEntries(state).Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessTypedefs(this IList<EntityDef.TypedefEntity> typedefEntities, GenerateState state, StringBuilder dest)
        {
            if (typedefEntities.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Typedefs", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Typedef", "Description"}, dest);
            typedefEntities.Iterate(entity => entity.GenerateForTypedef(state));
            typedefEntities.GetTypedefEntries(state).Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessEnums(this IList<EntityDef.EnumEntity> enumEntities, GenerateState state, StringBuilder dest)
        {
            if (enumEntities.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Enums", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Enum", "Description"}, dest);
            enumEntities.Iterate(entity => entity.GenerateForEnum(state));
            enumEntities.CreateEnumEntries(state).Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }
    }
}
