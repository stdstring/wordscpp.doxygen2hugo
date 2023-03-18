using System.Text;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Lookup;

namespace Doxygen2HugoConverter.Generator
{
    internal static class NamespaceGenerator
    {
        public static void GenerateForNamespace(this EntityDef.NamespaceEntity entity, GenerateState state, LookupFrame currentFrame)
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
            String defaultTitleDescription = entity.CreateDefaultHeaderDescription(state.ConvertData);
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle($"{entity.Name} namespace", defaultTitleDescription);
            GeneratorUtils.GenerateDefPageHeader($"{entity.Name} namespace", entity.Name, descriptionForTitle, namespaceUrl, currentFrame.CurrentWeight, state.ConvertData, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, currentState.ConvertData.Logger);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            IList<EntityDef> entities = entity.Classes
                .Cast<EntityDef>()
                .Union(entity.Interfaces)
                .Union(entity.Enums)
                .Union(entity.Typedefs)
                .ToList();
            currentFrame.FillKnownChildren(entities);
            entity.Classes.ProcessClassType(currentState, currentFrame, ClassKind.Class, builder);
            entity.Interfaces.ProcessClassType(currentState, currentFrame, ClassKind.Interface, builder);
            entity.Enums.ProcessEnums(currentState, currentFrame, builder);
            entity.Typedefs.ProcessTypedefs(currentState, currentFrame, builder);
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

        private static void ProcessClassType(this IList<EntityDef.ClassEntity> classEntities, GenerateState state, LookupFrame currentFrame, ClassKind kind, StringBuilder dest)
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
            classEntities.GenerateForChildren(currentFrame, (classEntity, childFrame) => classEntity.GenerateForClass(state, childFrame));
            classEntities.CreateClassEntries(state).Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessTypedefs(this IList<EntityDef.TypedefEntity> typedefEntities, GenerateState state, LookupFrame currentFrame, StringBuilder dest)
        {
            if (typedefEntities.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Typedefs", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Typedef", "Description"}, dest);
            typedefEntities.GenerateForChildren(currentFrame, (typedefEntity, childFrame) => typedefEntity.GenerateForTypedef(state, childFrame));
            typedefEntities.GetTypedefEntries(state).Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessEnums(this IList<EntityDef.EnumEntity> enumEntities, GenerateState state, LookupFrame currentFrame, StringBuilder dest)
        {
            if (enumEntities.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Enums", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Enum", "Description"}, dest);
            enumEntities.GenerateForChildren(currentFrame, (enumEntity, childFrame) => enumEntity.GenerateForEnum(state, childFrame));
            enumEntities.CreateEnumEntries(state).Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }
    }
}
