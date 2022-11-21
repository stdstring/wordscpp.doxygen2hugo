module MarkupGenerator

open System.Text

type UrlGenerator = string -> string option

let generateSimpleMarkupEntry (dest: StringBuilder) (relativeUrlGenerator: UrlGenerator) (markupEntry: Markup.SimpleMarkupDef) =
    match markupEntry with
    | Markup.SimpleMarkupDef.Text text -> text |> dest.Append |> ignore
    | Markup.SimpleMarkupDef.Ref data ->
        match data.RefId |> relativeUrlGenerator with
        | Some relativeUrl ->
            relativeUrl |> GeneratorCommon.generateLink data.Text |> dest.Append |> ignore
        | None ->
            "**" |> dest.Append |> ignore
            data.Text |> dest.Append |> ignore
            "**" |> dest.Append |> ignore
    | Markup.SimpleMarkupDef.ExternalLink link -> link.Url |> GeneratorCommon.generateLink link.Text |> dest.Append |> ignore
    | Markup.SimpleMarkupDef.ParagraphStart -> dest.AppendLine() |> ignore
    | Markup.SimpleMarkupDef.ParagraphEnd -> dest.AppendLine() |> ignore
    //| Markup.SimpleMarkupDef.ParagraphStart -> ()
    //| Markup.SimpleMarkupDef.ParagraphEnd -> ()
    | Markup.SimpleMarkupDef.BoldStart -> "**" |> dest.Append |> ignore
    | Markup.SimpleMarkupDef.BoldEnd -> "**" |> dest.Append |> ignore
    | Markup.SimpleMarkupDef.LineBreak -> dest.AppendLine() |> ignore

let generateBriefDescriptionForTitle (description: Markup.SimpleMarkup) =
    let result = new StringBuilder()
    for markupEntry in description do
        match markupEntry with
        | Markup.SimpleMarkupDef.Text text -> text |> result.Append |> ignore
        | Markup.SimpleMarkupDef.Ref data -> data.Text |> result.Append |> ignore
        | _ -> ()
    result.ToString().Trim()

let generateSimpleMarkup (relativeUrlGenerator: UrlGenerator) (description: Markup.SimpleMarkup) =
    let result = new StringBuilder()
    description |> Seq.iter (fun entry -> entry |> generateSimpleMarkupEntry result relativeUrlGenerator)
    // TODO (std_string) : think about removing call of Trim method
    result.ToString().Trim()

let generateCodeBlock (codeBlock: Markup.CodeBlockMarkup) =
    let result = new StringBuilder()
    "```cpp" |> result.AppendLine |> ignore
    for line in codeBlock do
        for portion in line do
            match portion with
            | Markup.CodeBlockPortionMarkup.Text text -> text |> result.Append |> ignore
            | Markup.CodeBlockPortionMarkup.HighlightStart _ -> ()
            | Markup.CodeBlockPortionMarkup.HighlightEnd -> ()
            | Markup.CodeBlockPortionMarkup.Space -> " " |> result.Append |> ignore
            | Markup.CodeBlockPortionMarkup.Ref data -> data.Text |> result.Append |> ignore
        result.AppendLine() |> ignore
    "```" |> result.AppendLine |> ignore
    result.ToString()

let generateList (dest: StringBuilder) (relativeUrlGenerator: UrlGenerator) (data: Markup.MarkupList) =
    let listMarker = match data.Ordered with
                     | true -> "1. "
                     | false -> "* "
    data.Items |> Seq.iter (fun item -> let line = new StringBuilder()
                                        item |> Seq.iter (fun entry -> entry |> generateSimpleMarkupEntry line relativeUrlGenerator)
                                        listMarker |> dest.Append |> ignore
                                        line.ToString().Trim() |> dest.AppendLine |> ignore)
    dest.AppendLine() |> ignore

let generateDetailedDescription (relativeUrlGenerator: UrlGenerator) (detailedDescription: Markup.DetailedDescription) =
    let result = new StringBuilder()
    for part in detailedDescription do
        match part with
        | Markup.DetailedDescriptionPart.SimpleMarkupPart markupEntry -> markupEntry |> generateSimpleMarkupEntry result relativeUrlGenerator
        | Markup.DetailedDescriptionPart.Title title -> GeneratorCommon.generateHeader title 2 |> result.Append |> ignore
        | Markup.DetailedDescriptionPart.CodeBlock codeBlock ->
            result.AppendLine() |> ignore
            codeBlock |> generateCodeBlock |> result.Append |> ignore
        | Markup.DetailedDescriptionPart.List listData -> listData |> generateList result relativeUrlGenerator
    result.ToString()