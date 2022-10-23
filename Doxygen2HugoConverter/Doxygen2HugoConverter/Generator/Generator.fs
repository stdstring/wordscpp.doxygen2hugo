module Generator

open System.Collections.Generic
open System.IO
open System.Text
open MarkupGenerator

let generateRootPageHeader (url: string[]) (dest: StringBuilder) =
    [KeyValuePair.Create("title", "Aspose.Words for C++");
     KeyValuePair.Create("type", "docs");
     KeyValuePair.Create("weight", "666");
     KeyValuePair.Create("url", url |> GeneratorCommon.generateUrl false);
     KeyValuePair.Create("keywords", "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\"");
     KeyValuePair.Create("description", "Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks.");
     KeyValuePair.Create("is_root", "true")] |> GeneratorCommon.generatePageHeader dest

let prepareDirectory (config: Config.ConfigData) =
    let rootDirectory = Path.Combine(config.DestDirectory, Common.RootDirectory)
    if rootDirectory |> Directory.Exists then
        Directory.Delete(rootDirectory, true)
    rootDirectory |> Directory.CreateDirectory |> ignore
    rootDirectory

let generateForNamespace (context: GeneratorCommon.Context) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> None
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
        let namespaceDirectory = Path.Combine(context.Directory, folderName)
        namespaceDirectory |> Directory.CreateDirectory |> ignore
        let namespaceUrl = [|folderName|] |> Array.append context.Url
        let currentContext = {context with Directory = namespaceDirectory; Url = namespaceUrl; Weight = 1}
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.BriefDescription |> GenerateBriefDescriptionForTitle
        builder |> GeneratorCommon.generateDefPageHeader namespaceDef.Name descriptionForTitle namespaceUrl context.Weight
        context.Weight <- context.Weight + GeneratorCommon.WeightDelta
        let briefDescription = namespaceDef.BriefDescription |> GenerateBriefDescription (GeneratorUrl.generateRelativeUrlForEntity context)
        builder.AppendLine() |> ignore
        briefDescription |> builder.AppendLine |> ignore
        builder.AppendLine() |> ignore
        if namespaceDef.Classes.IsEmpty |> not then
            GeneratorCommon.generateHeader "Classes" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Class"; "Description"]
            namespaceDef.Classes
                |> Seq.map (fun def -> def |> ClassGenerator.generate currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Interfaces.IsEmpty |> not then
            GeneratorCommon.generateHeader "Interfaces" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Interface"; "Description"]
            namespaceDef.Interfaces
                |> Seq.map (fun def -> def |> ClassGenerator.generate currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Enums.IsEmpty |> not then
            GeneratorCommon.generateHeader "Enums" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Enum"; "Description"]
            namespaceDef.Enums
                |> Seq.map (fun def -> def |> EnumGenerator.generate currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Typedefs.IsEmpty |> not then
            GeneratorCommon.generateHeader "Typedefs" 2 |> builder.Append |> ignore
            builder |> GeneratorCommon.generateTableHeader ["Typedef"; "Description"]
            namespaceDef.Typedefs
                |> Seq.map (fun def -> def |> TypedefGenerator.generate currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString())
        {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink namespaceDef.Name;
         GeneratorCommon.GenerateEntry.BriefDescription = briefDescription} |> Some

let generateDest (config: Config.ConfigData) (repo: IDictionary<string, Defs.EntityDef>) (namespaceDefs: Defs.NamespaceDef list) =
    let rootDirectory = config |> prepareDirectory
    let rootUrl = [|Common.RootDirectory|]
    let context = {GeneratorCommon.Context.Directory = rootDirectory;
                   GeneratorCommon.Context.Url = rootUrl;
                   GeneratorCommon.Context.CommonEntityRepo = repo;
                   GeneratorCommon.Context.Weight = 1}
    let builder = new StringBuilder()
    builder |> generateRootPageHeader rootUrl
    builder.AppendLine() |> ignore
    GeneratorCommon.generateHeader "Namespaces" 2 |> builder.Append |> ignore
    builder |> GeneratorCommon.generateTableHeader ["Namespace"; "Description"]
    namespaceDefs
        |> Seq.choose (fun def -> def |> generateForNamespace context)
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString())