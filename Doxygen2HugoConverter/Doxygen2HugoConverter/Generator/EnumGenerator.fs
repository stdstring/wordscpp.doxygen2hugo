module EnumGenerator

open System.IO
open System.Text

let getInitializerAsString (initializer: int option) =
    match initializer with
          | None -> "n/a"
          | Some value -> value |> string

let generate (context: GeneratorCommon.Context) (enumDef: Defs.EnumDef) =
    let folderName = enumDef.Name |> Utils.createSimpleFolderName
    let enumDirectory = Path.Combine(context.Directory, folderName)
    enumDirectory |> Directory.CreateDirectory |> ignore
    let enumUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = enumDirectory; Url = enumUrl; Weight = 1}
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
    let briefDescriptionGenerator = MarkupGenerator.GenerateBriefDescription urlGenerator
    let builder = new StringBuilder()
    let descriptionForTitle = enumDef.BriefDescription |> MarkupGenerator.GenerateBriefDescriptionForTitle
    builder |> GeneratorCommon.generateDefPageHeader enumDef.Name descriptionForTitle enumUrl context.Weight
    context.Weight <- context.Weight + GeneratorCommon.WeightDelta
    GeneratorCommon.generateHeader (sprintf $"{enumDef.Name} enum") 2 |> builder.Append |> ignore
    let briefDescription = enumDef.BriefDescription |> briefDescriptionGenerator
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    GeneratorCommon.generateHeader "Values" 3 |> builder.Append |> ignore
    builder |> GeneratorCommon.generateTableHeader ["Name"; "Value"; "Description"]
    for enumValueDef in enumDef.Values do
        let valueBriefDescription = enumValueDef.BriefDescription |> briefDescriptionGenerator
        let initializer = enumValueDef.Initializer |> getInitializerAsString
        sprintf $"| {enumValueDef.Name} | {initializer} | {valueBriefDescription} |" |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    let detailedDescription = enumDef.DetailedDescription |> MarkupGenerator.GenerateDetailedDescription urlGenerator
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString())
    {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink enumDef.Name;
     GeneratorCommon.GenerateEntry.BriefDescription = briefDescription}