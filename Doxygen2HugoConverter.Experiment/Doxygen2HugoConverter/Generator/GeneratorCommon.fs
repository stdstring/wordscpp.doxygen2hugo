module GeneratorCommon

open System.Collections.Generic
open System.Text

type GenerateEntry = {Title: string; BriefDescription: string}

[<Literal>]
let WeightDelta = 13

type Context = {Directory: string;
                Url: string[];
                mutable Weight: int;
                CommonEntityRepo: IDictionary<string, Defs.EntityDef>}

let generateChildUrl (folderName: string) = sprintf $"./{folderName}/"

let generateLink (name: string) (url: string) = $"[{name}]({url})"

let generateHeader (headerText: string) (headerLevel: int) =
    let result = new StringBuilder()
    "#" |> String.replicate headerLevel |> result.Append |> ignore
    " " |> result.Append |> ignore
    headerText |> result.AppendLine |> ignore
    result.AppendLine() |> ignore
    result.ToString()

let generateUrl (isRelative: bool) (url: string[]) =
    let result = url |> String.concat "/"
    match isRelative with
    | true -> sprintf $"{result}/"
    | false -> sprintf $"/{result}/"

let generatePageHeader (dest: StringBuilder) (data: seq<KeyValuePair<string, string>>) =
    "---" |> dest.AppendLine |> ignore
    for entry in data do
        entry.Key |> dest.Append |> ignore
        ": " |> dest.Append |> ignore
        entry.Value |> dest.AppendLine |> ignore
    "---" |> dest.AppendLine |> ignore

let prepareHeaderValue (value: string) =
    match ':' |> value.IndexOf with
    | -1 -> value
    | _ -> sprintf $"'{value}'"

let generateDefPageHeader (title: string) (description: string) (url: string[]) (weight: int) (dest: StringBuilder) =
    [KeyValuePair.Create("title", title |> prepareHeaderValue);
     KeyValuePair.Create("second_title", "Aspose.Words for C++ API Reference");
     KeyValuePair.Create("description", description |> prepareHeaderValue);
     KeyValuePair.Create("type", "docs");
     KeyValuePair.Create("weight", weight |> string);
     KeyValuePair.Create("url", url |> generateUrl false)] |> generatePageHeader dest

let generateTableHeader (columnHeaders: string list) (dest: StringBuilder) =
    "|" |> dest.Append |> ignore
    for columnHeader in columnHeaders do
        " " |> dest.Append |> ignore
        columnHeader |> dest.Append |> ignore
        " |" |> dest.Append |> ignore
    dest.AppendLine() |> ignore
    "|" |> dest.Append |> ignore
    for _ in 1 .. columnHeaders.Length do
        " --- |" |> dest.Append |> ignore
    dest.AppendLine() |> ignore

let generateTemplateParameters (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (templateParameters: Markup.TemplateParameters) (dest: StringBuilder) =
    if templateParameters.IsEmpty |> not then
        dest.AppendLine() |> ignore
        dest |> generateTableHeader ["Parameter"; "Description"]
        for templateParameter in templateParameters do
            let parameterDescription = templateParameter.Description |> briefDescriptionGenerator
            sprintf $"| {templateParameter.Name} | {parameterDescription} |" |> dest.AppendLine |> ignore