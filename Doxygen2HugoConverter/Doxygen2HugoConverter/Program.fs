// For more information see https://aka.ms/fsharp-console-apps

open Config
open Defs
open Generator
open Refs

// generator

[<EntryPoint>]
let main argv = 
    let config = {ConfigData.SourceDirectory = "../../../../../SourceData/"; ConfigData.DestDirectory = "../../../../../DestData/"}
    let namespaceRefs = config |> parseIndexFile
    let namespaceDefs = namespaceRefs |>
                        Seq.filter (fun refEntry -> ["namespace_aspose"; "namespacestd"] |> List.contains refEntry.RefId |> not) |>
                        Seq.map (fun refEntry -> refEntry |> parseNamespaceFile config) |>
                        Seq.toList
    namespaceDefs |> generateDest config
    0 // return an integer exit code
