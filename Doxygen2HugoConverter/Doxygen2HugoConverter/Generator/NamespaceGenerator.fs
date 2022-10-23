module NamespaceGenerator

open System.IO
open System.Text

let processEnums (context: GeneratorCommon.Context) (enumDefs: Defs.EnumDef list) (dest: StringBuilder) =
    match enumDefs.IsEmpty with
    | true -> ()
    | false ->
        GeneratorCommon.generateHeader "Enums" 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Enum"; "Description"]
        enumDefs |> Seq.iter (fun enumDef -> enumDef |> EnumGenerator.generate context)
        enumDefs
            |> EnumGenerator.createEnumEntries context
            |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let generate (context: GeneratorCommon.Context) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> ()
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
        let namespaceDirectory = Path.Combine(context.Directory, folderName)
        namespaceDirectory |> Directory.CreateDirectory |> ignore
        let namespaceUrl = [|folderName|] |> Array.append context.Url
        let currentContext = {context with Directory = namespaceDirectory; Url = namespaceUrl; Weight = 1}
        let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
        let briefDescriptionGenerator = MarkupGenerator.GenerateBriefDescription urlGenerator
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.BriefDescription |> MarkupGenerator.GenerateBriefDescriptionForTitle
        builder |> GeneratorCommon.generateDefPageHeader namespaceDef.Name descriptionForTitle namespaceUrl context.Weight
        context.Weight <- context.Weight + GeneratorCommon.WeightDelta
        let briefDescription = namespaceDef.BriefDescription |> briefDescriptionGenerator
        builder.AppendLine() |> ignore
        briefDescription |> builder.AppendLine |> ignore
        builder.AppendLine() |> ignore
        if namespaceDef.Classes.IsEmpty |> not then
            namespaceDef.Classes |> Seq.iter (fun classDef -> classDef |> ClassGenerator.generate currentContext)
            GeneratorCommon.generateHeader "Classes" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Class"; "Description"]
            namespaceDef.Classes
                |> ClassGenerator.createClassEntries currentContext
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Interfaces.IsEmpty |> not then
            namespaceDef.Interfaces |> Seq.iter (fun classDef -> classDef |> ClassGenerator.generate currentContext)
            GeneratorCommon.generateHeader "Interfaces" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Interface"; "Description"]
            namespaceDef.Interfaces
                |> ClassGenerator.createClassEntries currentContext
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        builder |> processEnums currentContext namespaceDef.Enums
        if namespaceDef.Typedefs.IsEmpty |> not then
            GeneratorCommon.generateHeader "Typedefs" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Typedef"; "Description"]
            namespaceDef.Typedefs
                |> Seq.map (fun def -> def |> TypedefGenerator.generate currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString())

let createEntry (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> None
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
        let briefDescription = namespaceDef.BriefDescription |> briefDescriptionGenerator
        {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink namespaceDef.Name;
         GeneratorCommon.GenerateEntry.BriefDescription = briefDescription} |> Some

let createNamespaceEntries (context: GeneratorCommon.Context) (namespaceDefs: Defs.NamespaceDef list) =
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity context
    let briefDescriptionGenerator = MarkupGenerator.GenerateBriefDescription urlGenerator
    namespaceDefs |> Seq.choose (fun namespaceDef -> namespaceDef |> createEntry briefDescriptionGenerator) |> Seq.toList