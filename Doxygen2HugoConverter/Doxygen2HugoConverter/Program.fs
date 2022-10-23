// For more information see https://aka.ms/fsharp-console-apps

let showUsage () =
    "Usage: <app> --source=<source-directory> --dest=<dest-directory>" |> System.Console.Error.WriteLine

[<EntryPoint>]
let main argv = 
    //let config = {Config.ConfigData.SourceDirectory = "../../../../../SourceData/"; Config.ConfigData.DestDirectory = "../../../../../DestData/"}
    match argv |> Config.parseFromArgs with
    | None ->
        showUsage()
        -1
    | Some config ->
        let namespaceRefs = config |> Refs.parseIndexFile
        let context = Defs.createEmptyContext()
        let namespaceDefs = namespaceRefs
                                |> Seq.filter (fun refEntry -> ["namespace_aspose"; "namespacestd"] |> List.contains refEntry.RefId |> not)
                                |> Seq.map (fun refEntry -> refEntry |> Defs.parseNamespaceFile config context)
                                |> Seq.toList
        namespaceDefs |> RootGenerator.generate config context.CommonEntityRepo
        0 // return an integer exit code
