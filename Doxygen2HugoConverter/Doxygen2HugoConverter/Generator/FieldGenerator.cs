using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Refs;
using System.Text;

namespace Doxygen2HugoConverter.Generator
{
    internal static class FieldGenerator
    {
        public static void GenerateForField(this EntityDef.FieldEntity entity, GenerateState state)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String fieldDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(fieldDirectory);
            IList<String> fieldUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = new GenerateState(fieldDirectory, fieldUrl, state.CommonEntityRepo);
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle();
            GeneratorUtils.GenerateDefPageHeader(entity.Name, descriptionForTitle, fieldUrl, state.Weight, builder);
            state.IncreaseWeight();
            GeneratorUtils.GenerateHeader($"{entity.Name} field", 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateFieldDefinition(builder);
            entity.DetailedDescription.GenerateDetailedDescription(CreateUrl, builder);
            entity.GenerateSeeAlso(currentState, builder);
            File.AppendAllText(Path.Combine(fieldDirectory, Common.MarkdownFilename), builder.ToString());
        }

        public static IList<GenerateEntry> GetFieldEntries(this IList<MemberRef> memberRefs, GenerateState state)
        {
            GenerateEntry? ChooseMethodFun(MemberRef memberRef) =>
                state.CommonEntityRepo.ContainsKey(memberRef.RefId) switch
                {
                    false => null,
                    true => state.CommonEntityRepo[memberRef.RefId] switch
                    {
                        EntityDef.FieldEntity entity => entity.CreateFieldEntry(state),
                        _ => null
                    }
                };
            return memberRefs.Choose(ChooseMethodFun).ToList();
        }

        private static void GenerateFieldDefinition(this EntityDef.FieldEntity entity, StringBuilder dest)
        {
            dest.AppendLine("```cpp");
            if (entity.IsStatic)
                dest.Append("static ");
            dest.Append(entity.Definition.Replace("< ", "<").Replace(" >", ">"));
            dest.AppendLine();
            dest.AppendLine("```");
            dest.AppendLine();
        }

        private static GenerateEntry CreateFieldEntry(this EntityDef.FieldEntity entity, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            switch (CreateUrl(entity.Id))
            {
                case null:
                    throw new InvalidOperationException($"Can't generate url for field {entity.FullName}");
                case var relativeUrl:
                    StringBuilder builder = new StringBuilder();
                    if (entity.IsStatic)
                        builder.Append("static ");
                    if (entity.IsConstexpr)
                        builder.Append("constexpr ");
                    if (entity.IsMutable)
                        builder.Append("mutable ");
                    builder.Append(GeneratorUtils.CreateLink(entity.Name, relativeUrl));
                    String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
                    return new GenerateEntry(builder.ToString(), briefDescription);
            }
        }

        private static void GenerateSeeAlso(this EntityDef.FieldEntity entity, GenerateState state, StringBuilder dest)
        {
            GeneratorUtils.GenerateHeader("See Also", 2, dest);
            entity.GenerateSeeAlsoCommonPart(state.CommonEntityRepo, dest);
        }
    }
}
