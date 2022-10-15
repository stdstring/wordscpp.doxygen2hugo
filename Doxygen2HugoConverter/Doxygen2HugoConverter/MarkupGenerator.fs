module MarkupGenerator

open System.Text
open GeneratorUtils
open Markup

type UrlGenerator = string -> string option

let GenerateBriefDescriptionForTitle (description: Defs.Description) =
    let result = new StringBuilder()
    for markupEntry in description.Brief do
        match markupEntry with
        | SimpleMarkupDef.Text text -> text |> result.Append |> ignore
        | SimpleMarkupDef.Ref data -> data.Text |> result.Append |> ignore
        | _ -> ()
    result.ToString()

let GenerateBriefDescription (relativeUrlGenerator: UrlGenerator) (description: Defs.Description) =
    let result = new StringBuilder()
    for markupEntry in description.Brief do
        match markupEntry with
        | SimpleMarkupDef.Text text -> text |> result.Append |> ignore
        | SimpleMarkupDef.Ref data ->
            match data.RefId |> relativeUrlGenerator with
            | Some relativeUrl ->
                relativeUrl |> GenerateLink data.Text |> result.Append |> ignore
            | None ->
                "**" |> result.Append |> ignore
                data.Text |> result.Append |> ignore
                "**" |> result.Append |> ignore
        //| SimpleMarkupDef.ParagraphStart -> result.AppendLine() |> ignore
        //| SimpleMarkupDef.ParagraphEnd -> result.AppendLine() |> ignore
        | SimpleMarkupDef.ParagraphStart -> ()
        | SimpleMarkupDef.ParagraphEnd -> ()
        | SimpleMarkupDef.BoldStart -> "**" |> result.Append |> ignore
        | SimpleMarkupDef.BoldEnd -> "**" |> result.Append |> ignore
    // TODO (std_string) : think about removing call of Trim method
    result.ToString().Trim()