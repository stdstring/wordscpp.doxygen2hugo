module TypedefGenerator

open System.IO
open System.Text

let generateDefinition (typedefDef: Defs.TypedefDef) (dest: StringBuilder) =
    match typedefDef.Definition |> System.String.IsNullOrEmpty with
    | true -> ()
    | false ->
        "```cpp" |> dest.AppendLine |> ignore
        typedefDef.Definition.Trim() |> dest.AppendLine |> ignore
        "```" |> dest.AppendLine |> ignore
        dest.AppendLine() |> ignore

let generate (context: GeneratorCommon.Context) (typedefDef: Defs.TypedefDef) =
    let folderName = typedefDef.Name |> Utils.createSimpleFolderName
    let typedefDirectory = Path.Combine(context.Directory, folderName)
    typedefDirectory |> Directory.CreateDirectory |> ignore
    let typedefUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = typedefDirectory; Url = typedefUrl; Weight = 1}
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
    let builder = new StringBuilder()
    let descriptionForTitle = typedefDef.BriefDescription |> MarkupGenerator.GenerateBriefDescriptionForTitle
    builder |> GeneratorCommon.generateDefPageHeader typedefDef.Name descriptionForTitle typedefUrl context.Weight
    context.Weight <- context.Weight + GeneratorCommon.WeightDelta
    GeneratorCommon.generateHeader (sprintf $"{typedefDef.Name} typedef") 2 |> builder.Append |> ignore
    let briefDescription = typedefDef.BriefDescription |> MarkupGenerator.GenerateBriefDescription urlGenerator
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateDefinition typedefDef
    let detailedDescription = typedefDef.DetailedDescription |> MarkupGenerator.GenerateDetailedDescription urlGenerator
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(typedefDirectory, Common.MarkdownFilename), builder.ToString())
    {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink typedefDef.Name;
     GeneratorCommon.GenerateEntry.BriefDescription = briefDescription}