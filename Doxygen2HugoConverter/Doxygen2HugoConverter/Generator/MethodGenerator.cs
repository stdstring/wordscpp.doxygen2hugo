﻿using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Lookup;
using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;
using System.Text;

namespace Doxygen2HugoConverter.Generator
{
    using SimpleMarkupPortion = IList<SimpleMarkupEntry>;
    using MethodArgs = IList<MethodArg>;

    internal static class MethodGenerator
    {
        public static void GenerateForMethodGroup(this MethodGroupEntity entity, GenerateState state, LookupFrame currentFrame)
        {
            for (Int32 index = 0; index < entity.Methods.Count; ++index)
                entity.Methods[index].GenerateForMethod(state, index == 0, entity.Methods.Count > 1, currentFrame);
        }

        public static IList<GenerateEntry> GetMethodEntries(this IList<MemberRef> memberRefs, GenerateState state)
        {
            GenerateEntry? ChooseMethodFun(MemberRef memberRef) =>
                state.ConvertData.EntityRepo.ContainsKey(memberRef.RefId) switch
                {
                    false => null,
                    true => state.ConvertData.EntityRepo[memberRef.RefId] switch
                    {
                        EntityDef.MethodEntity entity => entity.CreateEntry(state),
                        _ => null
                    }
                };
            return memberRefs.Choose(ChooseMethodFun).ToList();
        }

        private static void GenerateForMethod(this EntityDef.MethodEntity entity, GenerateState state, Boolean isFirst, Boolean hasOverloads, LookupFrame currentFrame)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String methodDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(methodDirectory);
            IList<String> methodUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = new GenerateState(methodDirectory, methodUrl, state.ConvertData);
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            if (isFirst)
            {
                String methodKind = entity.GetMethodKind();
                String defaultTitleDescription = entity.CreateDefaultHeaderDescription(state.ConvertData);
                String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle($"{entity.FullName} {methodKind}", defaultTitleDescription);
                GeneratorUtils.GenerateDefPageHeader($"{entity.FullName} {methodKind}", entity.Name, descriptionForTitle, methodUrl, currentFrame.CurrentWeight, state.ConvertData, builder);
            }
            IList<String> argsTypes = entity.Args.CreateArgTypeList();
            GeneratorUtils.GenerateHeader(entity.CreateMethodHeader(hasOverloads, argsTypes), 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, currentState.ConvertData.Logger);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateDefinition(builder);
            entity.DetailedDescription.TemplateParameters.GenerateTemplateParameters(CreateUrl, builder, currentState.ConvertData.Logger);
            entity.DetailedDescription.Args.GenerateArgs(currentState, argsTypes, builder);
            entity.DetailedDescription.ReturnValue.GenerateReturnValue(currentState, builder);
            entity.DetailedDescription.Description.GenerateDetailedDescription(CreateUrl, builder, currentState.ConvertData.Logger);
            entity.GenerateSeeAlso(currentState, builder);
            File.AppendAllText(Path.Combine(methodDirectory, Common.MarkdownFilename), builder.ToString());
        }

        private static GenerateEntry CreateEntry(this EntityDef.MethodEntity entity, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            switch (CreateUrl(entity.Id))
            {
                case null:
                    throw new InvalidOperationException($"Can't generate url for method {entity.FullName}");
                case var relativeUrl:
                    StringBuilder builder = new StringBuilder();
                    if (entity.IsVirtual && !entity.IsOverride)
                        builder.Append("virtual ");
                    if (entity.IsExplicit)
                        builder.Append("explicit ");
                    if (entity.IsStatic)
                        builder.Append("static ");
                    builder.Append(GeneratorUtils.CreateLink(entity.Name, relativeUrl));
                    builder.Append($"({String.Join(", ", entity.Args.CreateArgTypeList())})");
                    if (entity.IsConst)
                        builder.Append(" const");
                    if (entity.IsOverride)
                        builder.Append(" override");
                    String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger);
                    return new GenerateEntry(builder.ToString(), briefDescription);
            }
        }

        private static IList<String> CreateArgTypeList(this IList<MethodArgEntity> parameters)
        {
            String MapPartFun(SimpleMarkupEntry part) =>
                part switch
                {
                    SimpleMarkupEntry.TextEntry entry => entry.Text,
                    SimpleMarkupEntry.RefEntry entry => entry.Ref.Text,
                    _ => throw new InvalidOperationException("Unsupported markup element for type")
                };
            String CreateTypeRepresentation(SimpleMarkupPortion sourceType)
            {
                String typeRepresentation = String.Join("", sourceType.Select(MapPartFun));
                return typeRepresentation.Replace("< ", "\\<").Replace(" >", "\\>").Replace(" &", "\\&");
            }
            return parameters.Select(parameter => CreateTypeRepresentation(parameter.Type)).ToList();
        }

        private static String CreateMethodHeader(this EntityDef.MethodEntity entity, Boolean hasOverloads, IList<String> argsTypes)
        {
            StringBuilder result = new StringBuilder();
            result.Append($"{entity.ClassName}::{entity.Name}");
            if (hasOverloads)
            {
                result.Append($"({String.Join(", ", argsTypes)})");
                if (entity.IsConst)
                    result.Append(" const");
            }
            result.Append($" {entity.GetMethodKind()}");
            return result.ToString();
        }

        private static void GenerateDefinition(this EntityDef.MethodEntity entity, StringBuilder dest)
        {
            dest.AppendLine("```cpp");
            if (!entity.TemplateParameters.IsEmpty())
                dest.Append($"template<{String.Join(",", entity.TemplateParameters)}> ");
            dest.Append(entity.Definition.Replace("< ", "<").Replace(" >", ">"));
            dest.Append(entity.ArgString.Replace("< ", "<").Replace(" >", ">"));
            dest.AppendLine();
            dest.AppendLine("```");
            dest.AppendLine();
        }

        private static void GenerateArgs(this MethodArgs methodArgs, GenerateState state, IList<String> argsTypes, StringBuilder dest)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            if (methodArgs.IsEmpty())
                return;
            dest.AppendLine();
            GeneratorUtils.GenerateTableHeader(new[]{"Parameter", "Type", "Description"}, dest);
            foreach (var (methodArg, argType) in methodArgs.Zip(argsTypes))
            {
                String methodArgDescription = methodArg.Description.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger);
                dest.AppendLine($"| {methodArg.Name} | {argType} | {methodArgDescription} |");
            }
        }

        private static void GenerateReturnValue(this SimpleMarkupPortion returnValue, GenerateState state, StringBuilder dest)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            if (returnValue.IsEmpty())
                return;
            dest.AppendLine();
            GeneratorUtils.GenerateHeader("ReturnValue", 3, dest);
            dest.AppendLine(returnValue.CreateSimpleMarkup(CreateUrl, state.ConvertData.Logger));
        }

        // TODO (std_string) : think about place
        private static IEnumerable<MarkupRef> ExtractRefs(this SimpleMarkupPortion markup) =>
            markup.OfType<SimpleMarkupEntry.RefEntry>().Select(reference => reference.Ref);

        // TODO (std_string) : think about place
        private static void GenerateSeeAlsoEntry(this MarkupRef reference, GenerateState state, StringBuilder dest)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            switch (state.ConvertData.EntityRepo.ContainsKey(reference.RefId))
            {
                case false:
                    state.ConvertData.Logger.LogWarning($"Can't resolve ref with id = \"{reference.RefId}\"");
                    break;
                case true:
                    String url = CreateUrl(reference.RefId)!;
                    state.ConvertData.Logger.LogInfo($"Resolved ref for \"{reference.Text}\": \"{url}\"");
                    state.ConvertData.EntityRepo[reference.RefId].GenerateSeeAlsoEntry(url, dest);
                    break;
            }
        }

        private static void GenerateSeeAlso(this EntityDef.MethodEntity entity, GenerateState state, StringBuilder dest)
        {
            GeneratorUtils.GenerateHeader("See Also", 2, dest);
            entity.ReturnType.ExtractRefs()
                             .Concat(entity.Args.SelectMany(arg => arg.Type.ExtractRefs()))
                             .Where(reference => !String.IsNullOrEmpty(reference.RefId))
                             .DistinctBy(reference => reference.RefId)
                             .Iterate(reference => reference.GenerateSeeAlsoEntry(state, dest));
            entity.GenerateSeeAlsoCommonPart(state.ConvertData.EntityRepo, state.ConvertData, dest);
        }

        private static String GetMethodKind(this EntityDef.MethodEntity entity)
        {
            return entity.Kind switch
            {
                MethodKind.Constructor => "constructor",
                MethodKind.Method => "method",
                _ => throw new InvalidOperationException("Unknown method kind")
            };
        }
    }
}
