module GeneratorUtils

open System.Text

let GenerateChildUrl (folderName: string) = sprintf $"./{folderName}/"

let GenerateLink (name: string) (url: string) = $"[{name}]({url})"

let GenerateHeader (headerText: string) (headerLevel: int) =
    let result = new StringBuilder()
    "#" |> String.replicate headerLevel |> result.Append |> ignore
    " " |> result.Append |> ignore
    headerText |> result.AppendLine |> ignore
    result.AppendLine() |> ignore
    result.ToString()