module Markup

open System.Xml.Linq

type MarkupRef = {RefId: string; Kind: string option; External: string option; Text: string}

type SimpleMarkupDef =
    | Text of string
    | ParagraphStart
    | ParagraphEnd
    | BoldStart
    | BoldEnd
    | Ref of MarkupRef

let parseMarkupRef (source: XElement) =
    let refId = "refid" |> Utils.getAttributeValue source
    let kind = "kindref" |> Utils.findAttributeValue source
    let external = "external" |> Utils.findAttributeValue source
    let text = source.Value
    {MarkupRef.RefId = refId; MarkupRef.Kind = kind; MarkupRef.External = external; MarkupRef.Text = text}

let parseMarkup (source: XElement) =
    let rec parseMarkupImpl (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "para" ->
                seq {yield SimpleMarkupDef.ParagraphStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.ParagraphEnd}
            | "bold" ->
                seq {yield SimpleMarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.BoldEnd}
            // TODO (std_string) : think about special processing of computeroutput node
            | "computeroutput" ->
                seq {yield SimpleMarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.BoldEnd}
            | "ref" ->
                seq {yield element |> parseMarkupRef |> SimpleMarkupDef.Ref}
            | name -> name |> failwithf "Unexpected Markup XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> SimpleMarkupDef.Text |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected Markup XML node with type %A"
    match source.IsEmpty with
    | true -> []
    | false ->
        source.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat |> Seq.toList