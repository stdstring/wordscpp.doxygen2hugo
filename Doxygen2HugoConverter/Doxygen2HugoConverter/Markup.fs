module Markup

open System.Xml.Linq

type MarkupRef = {RefId: string; Kind: string option; External: string option; Tooltip: string option; Text: string}

type SimpleMarkupDef =
    | Text of string
    | ParagraphStart
    | ParagraphEnd
    | BoldStart
    | BoldEnd
    | Ref of MarkupRef

type SimpleMarkup = SimpleMarkupDef list

type CodeBlockPortionMarkup =
    | Text of string
    | HighlightStart of string
    | HighlightEnd
    | Space
    | Ref of MarkupRef

type CodeBlockLineMarkup = CodeBlockPortionMarkup list

type CodeBlockMarkup = CodeBlockLineMarkup list

type MarkupList = {Ordered: bool; Items: SimpleMarkup list}

type ExternalLinkData = {Text: string; Url: string}

type EnumDetailedDescriptionPart =
    | SimpleMarkupPart of SimpleMarkupDef
    | Title of string
    | CodeBlock of CodeBlockMarkup
    | List of MarkupList
    | ExternalLink of ExternalLinkData

type EnumDetailedDescription = EnumDetailedDescriptionPart list

let parseMarkupRef (source: XElement) =
    let refId = "refid" |> Utils.getAttributeValue source
    let kind = "kindref" |> Utils.findAttributeValue source
    let external = "external" |> Utils.findAttributeValue source
    let tooltip = "tooltip" |> Utils.findAttributeValue source
    let text = source.Value
    {MarkupRef.RefId = refId;
     MarkupRef.Kind = kind;
     MarkupRef.External = external;
     MarkupRef.Tooltip = tooltip;
     MarkupRef.Text = text}

let parseMarkup (source: XElement): SimpleMarkup =
    let rec parseMarkupImpl (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "para" ->
                seq {yield SimpleMarkupDef.ParagraphStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.ParagraphEnd}
            // TODO (std_string) : think about special processing of computeroutput node
            | "computeroutput"
            | "bold" ->
                seq {yield SimpleMarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.BoldEnd}
            (*| "computeroutput" ->
                seq {yield SimpleMarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.BoldEnd}*)
            | "ref" ->
                seq {yield element |> parseMarkupRef |> SimpleMarkupDef.Ref}
            | name -> name |> failwithf "Unexpected Markup XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> SimpleMarkupDef.Text |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected Markup XML node with type %A"
    match source.IsEmpty with
    | true -> []
    | false ->
        source.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat |> Seq.toList

let parseCodeBlockLine (source: XElement): CodeBlockLineMarkup =
    let rec parseCodeBlockLineImpl (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "highlight" ->
                let highlightClass = "class" |> Utils.getAttributeValue element
                seq {yield highlightClass |> CodeBlockPortionMarkup.HighlightStart;
                     yield! element.Nodes() |> Seq.map parseCodeBlockLineImpl |> Seq.concat;
                     yield CodeBlockPortionMarkup.HighlightEnd}
            | "ref" ->
                seq {yield element |> parseMarkupRef |> CodeBlockPortionMarkup.Ref}
            | "sp" -> CodeBlockPortionMarkup.Space |> Seq.singleton
            | name -> name |> failwithf "Unexpected Codeline markup XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> CodeBlockPortionMarkup.Text |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected Codeline markup XML node with type %A"
    source.Nodes() |> Seq.map parseCodeBlockLineImpl |> Seq.concat |> Seq.toList

let parseCodeBlock (source: XElement): CodeBlockMarkup =
    source.Elements("codeline") |> Seq.map parseCodeBlockLine |> Seq.toList

let parseMarkupList (source: XElement) =
    let items = source.Elements("listitem") |> Seq.map parseMarkup |> Seq.toList
    match source.Name.LocalName with
    | "orderedlist" -> {MarkupList.Ordered = true; Items = items}
    | name -> name |> failwithf "Unexpected list XML element with name \"%s\""

let parseExternalLink (source: XElement) =
    let url = "url" |> Utils.getAttributeValue source
    let text = source.Value
    {ExternalLinkData.Text = text; ExternalLinkData.Url = url}

let parseEnumDetailedDescription (source: XElement): EnumDetailedDescription =
    let rec parseEnumDetailedDescriptionPart (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "para" ->
                seq {yield SimpleMarkupDef.ParagraphStart |> EnumDetailedDescriptionPart.SimpleMarkupPart;
                     yield! element.Nodes() |> Seq.map parseEnumDetailedDescriptionPart |> Seq.concat;
                     yield SimpleMarkupDef.ParagraphEnd |> EnumDetailedDescriptionPart.SimpleMarkupPart}
            // TODO (std_string) : think about special processing of computeroutput node
            | "computeroutput"
            | "bold" ->
                seq {yield SimpleMarkupDef.BoldStart |> EnumDetailedDescriptionPart.SimpleMarkupPart;
                     yield! element.Nodes() |> Seq.map parseEnumDetailedDescriptionPart |> Seq.concat;
                     yield SimpleMarkupDef.BoldEnd |> EnumDetailedDescriptionPart.SimpleMarkupPart}
            | "ref" -> seq {yield element |> parseMarkupRef |> SimpleMarkupDef.Ref |> EnumDetailedDescriptionPart.SimpleMarkupPart}
            | "title" -> seq {yield element.Value |> EnumDetailedDescriptionPart.Title}
            | "simplesect" ->
                match "kind" |> Utils.getAttributeValue element with
                | "par" -> element.Nodes() |> Seq.map parseEnumDetailedDescriptionPart |> Seq.concat
                | "see" -> Seq.empty
                | kind -> kind |> failwithf "Unexpected \"simplesect\" XML element with kind \"%s\""
            | "orderedlist" -> element |> parseMarkupList |> EnumDetailedDescriptionPart.List |> Seq.singleton
            | "programlisting" -> seq {yield element |> parseCodeBlock |> EnumDetailedDescriptionPart.CodeBlock}
            | "ulink" -> element |> parseExternalLink |> EnumDetailedDescriptionPart.ExternalLink |> Seq.singleton
            | name -> name |> failwithf "Unexpected enum detailed description XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> SimpleMarkupDef.Text |> EnumDetailedDescriptionPart.SimpleMarkupPart |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected enum detailed description XML node with type %A"
    source.Nodes() |> Seq.map parseEnumDetailedDescriptionPart |> Seq.concat |> Seq.toList