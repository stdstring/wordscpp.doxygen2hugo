module Generator

open System.Collections.Generic
open System.IO
open System.Text

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
    namespaceDefs |> Seq.iter (fun namespaceDef -> namespaceDef |> NamespaceGenerator.generate context)
    namespaceDefs
        |> NamespaceGenerator.createNamespaceEntries context
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString())