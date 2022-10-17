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

type DetailedDescriptionPart =
    | SimpleMarkupPart of SimpleMarkupDef
    | Title of string
    | CodeBlock of CodeBlockMarkup
    | List of MarkupList
    | ExternalLink of ExternalLinkData

type DetailedDescription = DetailedDescriptionPart list

type TemplateParameter = {Name: string; Description: SimpleMarkup}

type ClassDetailedDescription = {TemplateParameters: TemplateParameter list; Description: DetailedDescription}

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
    | "itemizedlist" -> {MarkupList.Ordered = false; Items = items}
    | name -> name |> failwithf "Unexpected list XML element with name \"%s\""

let parseExternalLink (source: XElement) =
    let url = "url" |> Utils.getAttributeValue source
    let text = source.Value
    {ExternalLinkData.Text = text; ExternalLinkData.Url = url}

let parseDetailedDescription (source: XElement): DetailedDescription =
    let rec parseDetailedDescriptionPart (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "para" ->
                seq {yield SimpleMarkupDef.ParagraphStart |> DetailedDescriptionPart.SimpleMarkupPart;
                     yield! element.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat;
                     yield SimpleMarkupDef.ParagraphEnd |> DetailedDescriptionPart.SimpleMarkupPart}
            // TODO (std_string) : think about special processing of computeroutput node
            | "computeroutput"
            | "bold" ->
                seq {yield SimpleMarkupDef.BoldStart |> DetailedDescriptionPart.SimpleMarkupPart;
                     yield! element.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat;
                     yield SimpleMarkupDef.BoldEnd |> DetailedDescriptionPart.SimpleMarkupPart}
            | "ref" -> seq {yield element |> parseMarkupRef |> SimpleMarkupDef.Ref |> DetailedDescriptionPart.SimpleMarkupPart}
            | "title" -> seq {yield element.Value |> DetailedDescriptionPart.Title}
            | "simplesect" ->
                match "kind" |> Utils.getAttributeValue element with
                | "par"
                | "note" -> element.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat
                | "see" -> Seq.empty
                | kind -> kind |> failwithf "Unexpected \"simplesect\" XML element with kind \"%s\""
            | "orderedlist"
            | "itemizedlist" -> element |> parseMarkupList |> DetailedDescriptionPart.List |> Seq.singleton
            | "programlisting" -> seq {yield element |> parseCodeBlock |> DetailedDescriptionPart.CodeBlock}
            | "ulink" -> element |> parseExternalLink |> DetailedDescriptionPart.ExternalLink |> Seq.singleton
            | "emphasis" -> element.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat
            // special processing for outer code
            | "parameterlist" -> Seq.empty
            | name -> name |> failwithf "Unexpected enum detailed description XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> SimpleMarkupDef.Text |> DetailedDescriptionPart.SimpleMarkupPart |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected enum detailed description XML node with type %A"
    source.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat |> Seq.toList

let parseTemplateParameter (source: XElement) =
    let name = (source.Descendants("parametername") |> Seq.exactlyOne).Value
    let description = source.Descendants("parameterdescription") |> Seq.exactlyOne |> parseMarkup
    {TemplateParameter.Name = name; TemplateParameter.Description = description}

let parseTemplateParameters (source: XElement) =
    source.Elements("parameteritem") |> Seq.map parseTemplateParameter |> Seq.toList

let parseClassDetailedDescription (source: XElement) =
    let detailedDescription = source |> parseDetailedDescription
    let parametersSource = source.Descendants("parameterlist") |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "templateparam")
    let templateParameters = match parametersSource |> Seq.toList with
                             | [] -> []
                             | [parameterListElement] -> parameterListElement |> parseTemplateParameters
                             | _ -> failwith "Several sections \"parameterlist\" found"
    {ClassDetailedDescription.TemplateParameters = templateParameters;
     ClassDetailedDescription.Description = detailedDescription}