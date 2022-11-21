using System.Text;
using Doxygen2HugoConverter.Entities;

namespace Doxygen2HugoConverter.Generator
{
    internal static class ClassGenerator
    {
        public static void GenerateForClass(this EntityDef.ClassEntity entity, GenerateState state)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String classDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(classDirectory);
            IList<String> classUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = new GenerateState(classDirectory, classUrl, state.CommonEntityRepo);
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle();
            GeneratorUtils.GenerateDefPageHeader(entity.Name, descriptionForTitle, classUrl, state.Weight, builder);
            state.IncreaseWeight();
            String kind = entity.Kind switch
            {
                ClassKind.Class => "class",
                ClassKind.Interface => "interface",
                _ => throw new ArgumentOutOfRangeException(nameof(entity.Kind), entity.Kind, null)
            };
            GeneratorUtils.GenerateHeader($"{entity.Name} {kind}", 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateClassDefinition(builder);
            entity.DetailedDescription.TemplateParameters.GenerateTemplateParameters(CreateUrl, builder);
            entity.ProcessMethods(currentState, builder);
            entity.ProcessFields(currentState, builder);
            entity.ProcessTypedefs(currentState, builder);
            entity.DetailedDescription.Description.GenerateDetailedDescription(CreateUrl, builder);
            File.AppendAllText(Path.Combine(classDirectory, Common.MarkdownFilename), builder.ToString());
        }

        public static IList<GenerateEntry> CreateClassEntries(this IList<EntityDef.ClassEntity> entities, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            GenerateEntry? CreateEntry(EntityDef.ClassEntity entity)
            {
                String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
                String title = GeneratorUtils.CreateLink(entity.Name, UrlGenerator.CreateChildUrl(folderName));
                String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
                return new GenerateEntry(title, briefDescription);
            }
            return entities.Choose(CreateEntry).ToList();
        }

        private static String CreateBaseClass(BaseClassEntity entity)
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{entity.Access} ");
            if (entity.Virtual)
                result.Append("virtual ");
            result.Append(entity.QualifiedName.Replace("< ", "<").Replace(" >", ">"));
            return result.ToString();
        }

        private static void GenerateClassDefinition(this EntityDef.ClassEntity entity, StringBuilder dest)
        {
            dest.AppendLine("```cpp");
            if (!entity.TemplateParameters.IsEmpty())
                dest.Append($"template<{String.Join(',', entity.TemplateParameters)}>");
            dest.Append($"class {entity.Name}");
            if (!entity.BaseClasses.IsEmpty())
                dest.Append($" : {String.Join(", ", entity.BaseClasses.Select(CreateBaseClass))}");
            dest.AppendLine();
            dest.AppendLine("```");
            dest.AppendLine();
        }

        private static void ProcessMethods(this EntityDef.ClassEntity entity, GenerateState state, StringBuilder dest)
        {
            entity.DirectMethods.Iterate(group => { group.GenerateForMethodGroup(state); });
            IList<GenerateEntry> entries = entity.MemberRefs.GetMethodEntries(state);
            if (entries.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Methods", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[]{"Method", "Description"}, dest);
            entries.Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessFields(this EntityDef.ClassEntity entity, GenerateState state, StringBuilder dest)
        {
            entity.Fields.Iterate(field => { field.GenerateForField(state); });
            IList<GenerateEntry> entries = entity.MemberRefs.GetFieldEntries(state);
            if (entries.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Fields", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Field", "Description"}, dest);
            entries.Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessTypedefs(this EntityDef.ClassEntity entity, GenerateState state, StringBuilder dest)
        {
            entity.Typedefs.Iterate(typedef => { typedef.GenerateForTypedef(state); });
            IList<GenerateEntry> entries = entity.Typedefs.GetTypedefEntries(state);
            if (entries.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Typedefs", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Typedef", "Description"}, dest);
            entries.Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }
    }
}
