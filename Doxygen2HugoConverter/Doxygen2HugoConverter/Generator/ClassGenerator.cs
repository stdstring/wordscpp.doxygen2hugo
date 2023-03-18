using System.Text;
using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Lookup;

namespace Doxygen2HugoConverter.Generator
{
    internal static class ClassGenerator
    {
        public static void GenerateForClass(this EntityDef.ClassEntity entity, GenerateState state, LookupFrame currentFrame)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String classDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(classDirectory);
            IList<String> classUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = new GenerateState(classDirectory, classUrl, state.ConvertData);
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            String classKind = entity.GetClassKind();
            String defaultTitleDescription = entity.CreateDefaultHeaderDescription(state.ConvertData);
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle($"{entity.FullName} {classKind}", defaultTitleDescription);
            GeneratorUtils.GenerateDefPageHeader($"{entity.FullName} {classKind}", entity.Name, descriptionForTitle, classUrl, currentFrame.CurrentWeight, state.ConvertData, builder);
            GeneratorUtils.GenerateHeader($"{entity.Name} {classKind}", 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, currentState.ConvertData.Logger);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateClassDefinition(builder);
            entity.DetailedDescription.TemplateParameters.GenerateTemplateParameters(CreateUrl, builder, currentState.ConvertData.Logger);
            String[] entities = entity.DirectMethods
                .Select(group => group.Name)
                .Union(entity.Fields.Select(field => field.Name))
                .Union(entity.Typedefs.Select(typedef => typedef.Name))
                .ToArray();
            currentFrame.FillKnownChildren(entities);
            entity.ProcessMethods(currentState, currentFrame, builder);
            entity.ProcessFields(currentState, currentFrame, builder);
            entity.ProcessTypedefs(currentState, currentFrame, builder);
            entity.DetailedDescription.Description.GenerateDetailedDescription(CreateUrl, builder, currentState.ConvertData.Logger);
            entity.GenerateSeeAlso(currentState, builder);
            File.AppendAllText(Path.Combine(classDirectory, Common.MarkdownFilename), builder.ToString());
        }

        public static IList<GenerateEntry> CreateClassEntries(this IList<EntityDef.ClassEntity> entities, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            GenerateEntry? CreateEntry(EntityDef.ClassEntity entity)
            {
                String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
                String title = GeneratorUtils.CreateLink(entity.Name, UrlGenerator.CreateChildUrl(folderName));
                String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger);
                return new GenerateEntry(title, briefDescription);
            }
            return entities.Choose(CreateEntry).ToList();
        }

        private static String CreateBaseClass(this BaseClassEntity entity)
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{entity.Access} ");
            if (entity.Virtual)
                result.Append("virtual ");
            result.Append(entity.QualifiedName.Replace("< ", "<").Replace(" >", ">"));
            return result.ToString();
        }

        private static void GenerateBaseClasses(this IList<BaseClassEntity> entities, Int32 indentationValue, StringBuilder dest)
        {
            dest.AppendLine($"{entities[0].CreateBaseClass()}{(entities.Count > 1 ? "," : "")}");
            String indentation = new String(' ', indentationValue);
            Int32 maxIndex = entities.Count - 1;
            for (Int32 index = 1; index < entities.Count; ++index)
                dest.AppendLine($"{indentation}{entities[index].CreateBaseClass()}{(index < maxIndex ? "," : "")}");
        }

        private static void GenerateClassDefinition(this EntityDef.ClassEntity entity, StringBuilder dest)
        {
            dest.AppendLine("```cpp");
            Int32 startSize = dest.Length;
            if (!entity.TemplateParameters.IsEmpty())
                dest.Append($"template<{String.Join(',', entity.TemplateParameters)}>");
            dest.Append($"class {entity.Name}");
            if (entity.BaseClasses.IsEmpty())
                dest.AppendLine();
            else
            {
                dest.Append(" : ");
                Int32 indentationValue = dest.Length - startSize;
                entity.BaseClasses.GenerateBaseClasses(indentationValue, dest);
            }
            dest.AppendLine("```");
            dest.AppendLine();
        }

        private static void ProcessMethods(this EntityDef.ClassEntity entity, GenerateState state, LookupFrame currentFrame, StringBuilder dest)
        {
            entity.DirectMethods.GenerateForChildren(currentFrame, (group, childFrame) => group.GenerateForMethodGroup(state, childFrame), group => group.Name);
            IList<GenerateEntry> entries = entity.MemberRefs.GetMethodEntries(state);
            if (entries.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Methods", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[]{"Method", "Description"}, dest);
            entries.Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessFields(this EntityDef.ClassEntity entity, GenerateState state, LookupFrame currentFrame, StringBuilder dest)
        {
            entity.Fields.GenerateForChildren(currentFrame, (fieldEntity, childFrame) => fieldEntity.GenerateForField(state, childFrame));
            IList<GenerateEntry> entries = entity.MemberRefs.GetFieldEntries(state);
            if (entries.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Fields", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Field", "Description"}, dest);
            entries.Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void ProcessTypedefs(this EntityDef.ClassEntity entity, GenerateState state, LookupFrame currentFrame, StringBuilder dest)
        {
            entity.Typedefs.GenerateForChildren(currentFrame, (typedefEntity, childFrame) => typedefEntity.GenerateForTypedef(state, childFrame));
            IList<GenerateEntry> entries = entity.Typedefs.GetTypedefEntries(state);
            if (entries.IsEmpty())
                return;
            GeneratorUtils.GenerateHeader("Typedefs", 2, dest);
            GeneratorUtils.GenerateTableHeader(new[] {"Typedef", "Description"}, dest);
            entries.Iterate(entry => { dest.AppendLine($"| {entry.Title} | {entry.BriefDescription} |"); });
        }

        private static void GenerateSeeAlso(this BaseClassEntity baseClassEntity, GenerateState state, StringBuilder dest)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            String refId = baseClassEntity.RefId!;
            switch (state.ConvertData.EntityRepo.ContainsKey(refId))
            {
                case false:
                    state.ConvertData.Logger.LogWarning($"Can't resolve ref with id = \"{refId}\"");
                    break;
                case true:
                    String url = CreateUrl(refId)!;
                    state.ConvertData.Logger.LogInfo($"Resolved ref for \"{baseClassEntity.QualifiedName}\": \"{url}\"");
                    state.ConvertData.EntityRepo[refId].GenerateSeeAlsoEntry(url, dest);
                    break;
            }
        }

        private static void GenerateSeeAlso(this EntityDef.ClassEntity entity, GenerateState state, StringBuilder dest)
        {
            GeneratorUtils.GenerateHeader("See Also", 2, dest);
            entity.BaseClasses
                  .Where(baseClassEntity => !String.IsNullOrEmpty(baseClassEntity.RefId))
                  .DistinctBy(baseClassEntity => baseClassEntity.RefId)
                  .Iterate(baseClassEntity => baseClassEntity.GenerateSeeAlso(state, dest));
            entity.GenerateSeeAlsoCommonPart(state.ConvertData.EntityRepo, state.ConvertData, dest);
        }

        private static String GetClassKind(this EntityDef.ClassEntity entity)
        {
            return entity.Kind switch
            {
                ClassKind.Class => "class",
                ClassKind.Interface => "interface",
                _ => throw new ArgumentOutOfRangeException(nameof(entity.Kind), entity.Kind, null)
            };
        }
    }
}
