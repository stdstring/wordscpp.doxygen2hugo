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
    let context = Defs.createEmptyContext()
    let namespaceDefs = namespaceRefs |>
                        Seq.filter (fun refEntry -> ["namespace_aspose"; "namespacestd"] |> List.contains refEntry.RefId |> not) |>
                        Seq.map (fun refEntry -> refEntry |> parseNamespaceFile config context) |>
                        Seq.toList
    namespaceDefs |> generateDest config context.CommonEntityRepo
    0 // return an integer exit code
