﻿module MarkupGenerator

open System.Text
open GeneratorUtils
open Markup

type UrlGenerator = string -> string option

let generateSimpleMarkup (dest: StringBuilder) (relativeUrlGenerator: UrlGenerator) (markupEntry: SimpleMarkupDef) =
    match markupEntry with
    | SimpleMarkupDef.Text text -> text |> dest.Append |> ignore
    | SimpleMarkupDef.Ref data ->
        match data.RefId |> relativeUrlGenerator with
        | Some relativeUrl ->
            relativeUrl |> GenerateLink data.Text |> dest.Append |> ignore
        | None ->
            "**" |> dest.Append |> ignore
            data.Text |> dest.Append |> ignore
            "**" |> dest.Append |> ignore
    | SimpleMarkupDef.ParagraphStart -> dest.AppendLine() |> ignore
    | SimpleMarkupDef.ParagraphEnd -> dest.AppendLine() |> ignore
    //| SimpleMarkupDef.ParagraphStart -> ()
    //| SimpleMarkupDef.ParagraphEnd -> ()
    | SimpleMarkupDef.BoldStart -> "**" |> dest.Append |> ignore
    | SimpleMarkupDef.BoldEnd -> "**" |> dest.Append |> ignore

let GenerateBriefDescriptionForTitle (description: SimpleMarkupDef list) =
    let result = new StringBuilder()
    for markupEntry in description do
        match markupEntry with
        | SimpleMarkupDef.Text text -> text |> result.Append |> ignore
        | SimpleMarkupDef.Ref data -> data.Text |> result.Append |> ignore
        | _ -> ()
    result.ToString()

let GenerateBriefDescription (relativeUrlGenerator: UrlGenerator) (description: SimpleMarkupDef list) =
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
        | SimpleMarkupPart markupEntry -> markupEntry |> generateSimpleMarkup result relativeUrlGenerator
        | Title title -> GenerateHeader title 2 |> result.Append |> ignore
        | CodeBlock codeBlock ->
            result.AppendLine() |> ignore
            codeBlock |> generateCodeBlock |> result.Append |> ignore
        | List listData -> listData |> generateList result relativeUrlGenerator
        | ExternalLink link -> link.Url |> GenerateLink link.Text |> result.Append |> ignore
    result.ToString()