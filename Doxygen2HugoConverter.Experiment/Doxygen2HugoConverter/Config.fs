module Config

open System.Collections.Generic
open System.IO

type ConfigData = {SourceDirectory: string; DestDirectory: string}

[<Literal>]
let sourceKey = "--source"

[<Literal>]
let destKey = "--dest"

let parseFromArgs (args: string[]) =
    let configStorage = new Dictionary<string, string>()
    for arg in args do
        match arg.Split('=') with
        | parts when parts.Length = 2 ->
            let key = parts.[0].Trim()
            let value = parts.[1].Trim()
            configStorage.[key] <- value
        | _ -> ()
    match [sourceKey; destKey] |> Seq.forall configStorage.ContainsKey with
    | false -> None
    | true ->
        let sourceDirectory = configStorage.[sourceKey]
        let destDirectory = configStorage.[destKey]
        match sourceDirectory |> Directory.Exists with
        | false -> None
        | true -> {ConfigData.SourceDirectory = sourceDirectory; ConfigData.DestDirectory = destDirectory} |> Some