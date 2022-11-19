module FieldGenerator

open System.IO
open System.Text

let generateDefinition (fieldDef: Defs.FieldDef) (dest: StringBuilder) =
    "```cpp" |> dest.AppendLine |> ignore
    if fieldDef.IsStatic then
        "static " |> dest.Append |> ignore
    fieldDef.Definition.Replace("< ", "<").Replace(" >", ">") |> dest.Append |> ignore
    dest.AppendLine() |> ignore
    "```" |> dest.AppendLine |> ignore
    dest.AppendLine() |> ignore

let generate (context: GeneratorCommon.Context) (fieldDef: Defs.FieldDef) =
    let folderName = fieldDef.Name |> Utils.createSimpleFolderName
    let fieldDirectory = Path.Combine(context.Directory, folderName)
    fieldDirectory |> Directory.CreateDirectory |> ignore
    let fieldUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = fieldDirectory; Url = fieldUrl; Weight = 1}
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
    let builder = new StringBuilder()
    let descriptionForTitle = fieldDef.BriefDescription |> MarkupGenerator.generateBriefDescriptionForTitle
    builder |> GeneratorCommon.generateDefPageHeader fieldDef.Name descriptionForTitle fieldUrl context.Weight
    context.Weight <- context.Weight + GeneratorCommon.WeightDelta
    GeneratorCommon.generateHeader (sprintf $"{fieldDef.Name} field") 2 |> builder.Append |> ignore
    let briefDescription = fieldDef.BriefDescription |> MarkupGenerator.generateSimpleMarkup urlGenerator
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateDefinition fieldDef
    let detailedDescription = fieldDef.DetailedDescription |> MarkupGenerator.generateDetailedDescription urlGenerator
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(fieldDirectory, Common.MarkdownFilename), builder.ToString())

let createFieldEntry (context: GeneratorCommon.Context) (fieldDef: Defs.FieldDef) =
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity context
    match fieldDef.Id |> urlGenerator with
    | Some relativeUrl ->
        let builder = new StringBuilder()
        if fieldDef.IsStatic then
            "static " |> builder.Append |> ignore
        if fieldDef.IsConstexpr then
            "constexpr " |> builder.Append |> ignore
        if fieldDef.IsMutable then
            "mutable " |> builder.Append |> ignore
        relativeUrl |> GeneratorCommon.generateLink fieldDef.Name |> builder.Append |> ignore
        let briefDescription = fieldDef.BriefDescription |> MarkupGenerator.generateSimpleMarkup urlGenerator
        {GeneratorCommon.GenerateEntry.Title = builder.ToString(); GeneratorCommon.GenerateEntry.BriefDescription = briefDescription}
    | None -> failwith "Unknown method ref"

let getFieldEntries (context: GeneratorCommon.Context) (memberRefs: Refs.MemberRef list) =
    let filterFun (memberRef: Refs.MemberRef) =
        match memberRef.RefId |> context.CommonEntityRepo.ContainsKey with
        | false -> None
        | true ->
            match context.CommonEntityRepo.[memberRef.RefId] with
            | Defs.EntityDef.Field fieldDef -> fieldDef |> createFieldEntry context |> Some
            | _ -> None
    memberRefs |> Seq.choose filterFun |> Seq.toList