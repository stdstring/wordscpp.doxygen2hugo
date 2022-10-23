module MarkupGenerator

open System.Text
open GeneratorCommon
open Markup

type UrlGenerator = string -> string option

let generateSimpleMarkup (dest: StringBuilder) (relativeUrlGenerator: UrlGenerator) (markupEntry: SimpleMarkupDef) =
    match markupEntry with
    | SimpleMarkupDef.Text text -> text |> dest.Append |> ignore
    | SimpleMarkupDef.Ref data ->
        match data.RefId |> relativeUrlGenerator with
        | Some relativeUrl ->
            relativeUrl |> generateLink data.Text |> dest.Append |> ignore
        | None ->
            "**" |> dest.Append |> ignore
            data.Text |> dest.Append |> ignore
            "**" |> dest.Append |> ignore
    | SimpleMarkupDef.ExternalLink link -> link.Url |> generateLink link.Text |> dest.Append |> ignore
    | SimpleMarkupDef.ParagraphStart -> dest.AppendLine() |> ignore
    | SimpleMarkupDef.ParagraphEnd -> dest.AppendLine() |> ignore
    //| SimpleMarkupDef.ParagraphStart -> ()
    //| SimpleMarkupDef.ParagraphEnd -> ()
    | SimpleMarkupDef.BoldStart -> "**" |> dest.Append |> ignore
    | SimpleMarkupDef.BoldEnd -> "**" |> dest.Append |> ignore
    | SimpleMarkupDef.LineBreak -> dest.AppendLine() |> ignore

let GenerateBriefDescriptionForTitle (description: SimpleMarkupDef list) =
    let result = new StringBuilder()
    for markupEntry in description do
        match markupEntry with
        | SimpleMarkupDef.Text text -> text |> result.Append |> ignore
        | SimpleMarkupDef.Ref data -> data.Text |> result.Append |> ignore
        | _ -> ()
    result.ToString()

// TODO (std_string) : probably rename into GenerateMarkup
let GenerateBriefDescription (relativeUrlGenerator: UrlGenerator) (description: SimpleMarkup) =
    let result = new StringBuilder()
    description |> Seq.iter (fun entry -> entry |> generateSimpleMarkup result relativeUrlGenerator)
    // TODO (std_string) : think about removing call of Trim method
    result.ToString().Trim()

let generateCodeBlock (codeBlock: CodeBlockMarkup) =
    let result = new StringBuilder()
    "```cpp" |> result.AppendLine |> ignore
    for line in codeBlock do
        for portion in line do
            match portion with
            | CodeBlockPortionMarkup.Text text -> text |> result.Append |> ignore
            | CodeBlockPortionMarkup.HighlightStart _ -> ()
            | CodeBlockPortionMarkup.HighlightEnd -> ()
            | CodeBlockPortionMarkup.Space -> " " |> result.Append |> ignore
            | CodeBlockPortionMarkup.Ref data -> data.Text |> result.Append |> ignore
        result.AppendLine() |> ignore
        ()
    "```" |> result.AppendLine |> ignore
    result.ToString()

let generateList (dest: StringBuilder) (relativeUrlGenerator: UrlGenerator) (data: MarkupList) =
    let listMarker = match data.Ordered with
                     | true -> "1. "
                     | false -> "* "
    data.Items |> Seq.iter (fun item -> let line = new StringBuilder()
                                        item |> Seq.iter (fun entry -> entry |> generateSimpleMarkup line relativeUrlGenerator)
                                        listMarker |> dest.Append |> ignore
                                        line.ToString().Trim() |> dest.AppendLine |> ignore)
    dest.AppendLine() |> ignore

let GenerateDetailedDescription (relativeUrlGenerator: UrlGenerator) (detailedDescription: DetailedDescription) =
    let result = new StringBuilder()
    for part in detailedDescription do
        match part with
        | DetailedDescriptionPart.SimpleMarkupPart markupEntry -> markupEntry |> generateSimpleMarkup result relativeUrlGenerator
        | DetailedDescriptionPart.Title title -> generateHeader title 2 |> result.Append |> ignore
        | DetailedDescriptionPart.CodeBlock codeBlock ->
            result.AppendLine() |> ignore
            codeBlock |> generateCodeBlock |> result.Append |> ignore
        | DetailedDescriptionPart.List listData -> listData |> generateList result relativeUrlGenerator
    result.ToString()