﻿using Doxygen2HugoConverter.Entities;
using Doxygen2HugoConverter.Markup;
using Doxygen2HugoConverter.Refs;
using System.Text;

namespace Doxygen2HugoConverter.Generator
{
    using SimpleMarkupPortion = IList<SimpleMarkupEntry>;
    using MethodArgs = IList<MethodArg>;

    internal static class MethodGenerator
    {
        public static void GenerateForMethodGroup(this MethodGroupEntity entity, GenerateState state)
        {
            for (Int32 index = 0; index < entity.Methods.Count; ++index)
                entity.Methods[index].GenerateForMethod(state, index == 0, entity.Methods.Count > 1);
        }

        public static IList<GenerateEntry> GetMethodEntries(this IList<MemberRef> memberRefs, GenerateState state)
        {
            GenerateEntry? ChooseMethodFun(MemberRef memberRef) =>
                state.CommonEntityRepo.ContainsKey(memberRef.RefId) switch
                {
                    false => null,
                    true => state.CommonEntityRepo[memberRef.RefId] switch
                    {
                        EntityDef.MethodEntity entity => entity.CreateEntry(state),
                        _ => null
                    }
                };
            return memberRefs.Choose(ChooseMethodFun).ToList();
        }

        public static void GenerateForMethod(this EntityDef.MethodEntity entity, GenerateState state, Boolean isFirst, Boolean hasOverloads)
        {
            String folderName = NameUtils.CreateSimpleFolderName(entity.Name);
            String methodDirectory = Path.Combine(state.Directory, folderName);
            Directory.CreateDirectory(methodDirectory);
            IList<String> methodUrl = state.Url.Append(folderName).ToList();
            GenerateState currentState = state with {Directory = methodDirectory, Url = methodUrl};
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, currentState);
            StringBuilder builder = new StringBuilder();
            if (isFirst)
            {
                String descriptionForTitle = entity.BriefDescription.CreateBriefDescriptionForTitle();
                GeneratorUtils.GenerateDefPageHeader(entity.Name, descriptionForTitle, methodUrl, state.Weight, builder);
                state.IncreaseWeight();
            }
            IList<String> argsTypes = entity.Args.CreateArgTypeList();
            GeneratorUtils.GenerateHeader(entity.CreateMethodHeader(hasOverloads, argsTypes), 2, builder);
            String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
            builder.AppendLine();
            builder.AppendLine(briefDescription);
            builder.AppendLine();
            entity.GenerateDefinition(builder);
            entity.DetailedDescription.TemplateParameters.GenerateTemplateParameters(CreateUrl, builder);
            entity.DetailedDescription.Args.GenerateArgs(CreateUrl, argsTypes, builder);
            entity.DetailedDescription.ReturnValue.GenerateReturnValue(CreateUrl, builder);
            entity.DetailedDescription.Description.GenerateDetailedDescription(CreateUrl, builder);
            File.AppendAllText(Path.Combine(methodDirectory, Common.MarkdownFilename), builder.ToString());
        }

        private static GenerateEntry CreateEntry(this EntityDef.MethodEntity entity, GenerateState state)
        {
            String? CreateUrl(String entityId) => UrlGenerator.CreateRelativeUrlForEntity(entityId, state);
            switch (CreateUrl(entity.Id))
            {
                case null:
                    throw new InvalidOperationException($"Can't generate url for method {entity.QualifiedName}");
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
                    String briefDescription = entity.BriefDescription.CreateSimpleMarkup(CreateUrl);
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
            result.Append(" method");
            return result.ToString();
        }

        private static void GenerateDefinition(this EntityDef.MethodEntity entity, StringBuilder dest)
        {
            dest.AppendLine("```cpp");
            if (!entity.TemplateParameters.IsEmpty())
                dest.AppendLine($"template<{String.Join(",", entity.TemplateParameters)}>");
            dest.Append(entity.Definition.Replace("< ", "<").Replace(" >", ">"));
            dest.Append(entity.ArgString.Replace("< ", "<").Replace(" >", ">"));
            dest.AppendLine();
            dest.AppendLine("```");
            dest.AppendLine();
        }

        private static void GenerateArgs(this MethodArgs methodArgs, Func<String, String?> relativeUrlGenerator, IList<String> argsTypes, StringBuilder dest)
        {
            if (methodArgs.IsEmpty())
                return;
            dest.AppendLine();
            GeneratorUtils.GenerateTableHeader(new[]{"Parameter", "Type", "Description"}, dest);
            foreach (var (methodArg, argType) in methodArgs.Zip(argsTypes))
            {
                String methodArgDescription = methodArg.Description.CreateSimpleMarkup(relativeUrlGenerator);
                dest.AppendLine($"| {methodArg.Name} | {argType} | {methodArgDescription} |");
            }
        }

        private static void GenerateReturnValue(this SimpleMarkupPortion returnValue, Func<String, String?> relativeUrlGenerator, StringBuilder dest)
        {
            if (returnValue.IsEmpty())
                return;
            dest.AppendLine();
            GeneratorUtils.GenerateHeader("ReturnValue", 3, dest);
            dest.AppendLine(returnValue.CreateSimpleMarkup(relativeUrlGenerator));
        }
    }
}
