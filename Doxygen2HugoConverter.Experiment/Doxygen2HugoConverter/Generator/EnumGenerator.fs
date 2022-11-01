module EnumGenerator

open System.IO
open System.Text

let getInitializerAsString (initializer: int option) =
    match initializer with
          | None -> "n/a"
          | Some value -> value |> string

let processEnumValues (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (enumValueDefs: Defs.EnumValueDef list) (dest: StringBuilder) =
    GeneratorCommon.generateHeader "Values" 3 |> dest.Append |> ignore
    dest |> GeneratorCommon.generateTableHeader ["Name"; "Value"; "Description"]
    for enumValueDef in enumValueDefs do
        let valueBriefDescription = enumValueDef.BriefDescription |> briefDescriptionGenerator
        let initializer = enumValueDef.Initializer |> getInitializerAsString
        sprintf $"| {enumValueDef.Name} | {initializer} | {valueBriefDescription} |" |> dest.AppendLine |> ignore

let generate (context: GeneratorCommon.Context) (enumDef: Defs.EnumDef) =
    let folderName = enumDef.Name |> Utils.createSimpleFolderName
    let enumDirectory = Path.Combine(context.Directory, folderName)
    enumDirectory |> Directory.CreateDirectory |> ignore
    let enumUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = enumDirectory; Url = enumUrl; Weight = 1}
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
    let briefDescriptionGenerator = MarkupGenerator.generateSimpleMarkup urlGenerator
    let builder = new StringBuilder()
    let descriptionForTitle = enumDef.BriefDescription |> MarkupGenerator.generateBriefDescriptionForTitle
    builder |> GeneratorCommon.generateDefPageHeader enumDef.Name descriptionForTitle enumUrl context.Weight
    context.Weight <- context.Weight + GeneratorCommon.WeightDelta
    GeneratorCommon.generateHeader (sprintf $"{enumDef.Name} enum") 2 |> builder.Append |> ignore
    let briefDescription = enumDef.BriefDescription |> briefDescriptionGenerator
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> processEnumValues briefDescriptionGenerator enumDef.Values
    builder.AppendLine() |> ignore
    let detailedDescription = enumDef.DetailedDescription |> MarkupGenerator.generateDetailedDescription urlGenerator
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString())

let createEntry (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (enumDef: Defs.EnumDef) =
    let folderName = enumDef.Name |> Utils.createSimpleFolderName
    let briefDescription = enumDef.BriefDescription |> briefDescriptionGenerator
    {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink enumDef.Name;
     GeneratorCommon.GenerateEntry.BriefDescription = briefDescription}

let createEnumEntries (context: GeneratorCommon.Context) (enumDefs: Defs.EnumDef list) =
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity context
    let briefDescriptionGenerator = MarkupGenerator.generateSimpleMarkup urlGenerator
    enumDefs |> Seq.map (fun enumDef -> enumDef |> createEntry briefDescriptionGenerator) |> Seq.toList