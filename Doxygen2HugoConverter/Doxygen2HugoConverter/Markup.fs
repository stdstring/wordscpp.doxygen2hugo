module Markup

open System.Xml.Linq

type MarkupRef = {RefId: string; Kind: string option; External: string option; Tooltip: string option; Text: string}

type ExternalLinkData = {Text: string; Url: string}

type SimpleMarkupDef =
    | Text of string
    | ParagraphStart
    | ParagraphEnd
    | BoldStart
    | BoldEnd
    | LineBreak
    | Ref of MarkupRef
    | ExternalLink of ExternalLinkData

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

type DetailedDescriptionPart =
    | SimpleMarkupPart of SimpleMarkupDef
    | Title of string
    | CodeBlock of CodeBlockMarkup
    | List of MarkupList

type DetailedDescription = DetailedDescriptionPart list

type TemplateParameter = {Name: string; Description: SimpleMarkup}

type TemplateParameters = TemplateParameter list

type ClassDetailedDescription = {TemplateParameters: TemplateParameters; Description: DetailedDescription}

type MethodArg = {Name: string; Description: SimpleMarkup}

type MethodArgs = MethodArg list

type MethodDetailedDescription = {TemplateParameters: TemplateParameters;
                                  Args: MethodArgs;
                                  ReturnValue: SimpleMarkup;
                                  Description: DetailedDescription}

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

let parseExternalLink (source: XElement) =
    let url = "url" |> Utils.getAttributeValue source
    let text = source.Value
    {ExternalLinkData.Text = text; ExternalLinkData.Url = url}

let parseSimpleMarkup (source: XElement): SimpleMarkup =
    let rec parseSimpleMarkupImpl (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "para" ->
                seq {yield SimpleMarkupDef.ParagraphStart; yield! element.Nodes() |> Seq.map parseSimpleMarkupImpl |> Seq.concat; yield SimpleMarkupDef.ParagraphEnd}
            // TODO (std_string) : think about special processing of computeroutput node
            | "computeroutput"
            | "bold" ->
                seq {yield SimpleMarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseSimpleMarkupImpl |> Seq.concat; yield SimpleMarkupDef.BoldEnd}
            (*| "computeroutput" ->
                seq {yield SimpleMarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkupImpl |> Seq.concat; yield SimpleMarkupDef.BoldEnd}*)
            | "ref" -> seq {yield element |> parseMarkupRef |> SimpleMarkupDef.Ref}
            | "ulink" -> element |> parseExternalLink |> SimpleMarkupDef.ExternalLink |> Seq.singleton
            | name -> name |> failwithf "Unexpected Markup XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> SimpleMarkupDef.Text |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected Markup XML node with type %A"
    match source.IsEmpty with
    | true -> []
    | false ->
        source.Nodes() |> Seq.map parseSimpleMarkupImpl |> Seq.concat |> Seq.toList

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
    let items = source.Elements("listitem") |> Seq.map parseSimpleMarkup |> Seq.toList
    match source.Name.LocalName with
    | "orderedlist" -> {MarkupList.Ordered = true; Items = items}
    | "itemizedlist" -> {MarkupList.Ordered = false; Items = items}
    | name -> name |> failwithf "Unexpected list XML element with name \"%s\""

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
            | "ulink" -> element |> parseExternalLink |> SimpleMarkupDef.ExternalLink |> DetailedDescriptionPart.SimpleMarkupPart |> Seq.singleton
            | "linebreak" -> SimpleMarkupDef.LineBreak |> DetailedDescriptionPart.SimpleMarkupPart |> Seq.singleton
            | "title" -> seq {yield element.Value |> DetailedDescriptionPart.Title}
            | "simplesect" ->
                match "kind" |> Utils.getAttributeValue element with
                | "par"
                | "note" -> element.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat
                | "see" -> Seq.empty
                // special processing for outer code (for classes)
                | "return" -> Seq.empty
                | kind -> kind |> failwithf "Unexpected \"simplesect\" XML element with kind \"%s\""
            | "orderedlist"
            | "itemizedlist" -> element |> parseMarkupList |> DetailedDescriptionPart.List |> Seq.singleton
            | "programlisting" -> seq {yield element |> parseCodeBlock |> DetailedDescriptionPart.CodeBlock}
            | "emphasis" -> element.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat
            // special processing for outer code (for classes & methods)
            | "parameterlist" -> Seq.empty
            | name -> name |> failwithf "Unexpected enum detailed description XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> SimpleMarkupDef.Text |> DetailedDescriptionPart.SimpleMarkupPart |> Seq.singleton
        | _ -> node.NodeType |> failwithf "Unexpected enum detailed description XML node with type %A"
    source.Nodes() |> Seq.map parseDetailedDescriptionPart |> Seq.concat |> Seq.toList

let parseTemplateParameter (source: XElement) =
    let name = (source.Descendants("parametername") |> Seq.exactlyOne).Value
    let description = source.Descendants("parameterdescription") |> Seq.exactlyOne |> parseSimpleMarkup
    {TemplateParameter.Name = name; TemplateParameter.Description = description}

let parseTemplateParameters (source: XElement) =
    source.Elements("parameteritem") |> Seq.map parseTemplateParameter |> Seq.toList

let parseClassDetailedDescription (source: XElement) =
    let detailedDescription = source |> parseDetailedDescription
    let parametersSource = source.Descendants("parameterlist") |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "templateparam")
    let templateParameters = match parametersSource |> Seq.toList with
                             | [] -> []
                             | [parameterListElement] -> parameterListElement |> parseTemplateParameters
                             | _ -> failwith "Several sections with template parameters found"
    {ClassDetailedDescription.TemplateParameters = templateParameters;
     ClassDetailedDescription.Description = detailedDescription}

let parseMethodArg (source: XElement) =
    let name = (source.Descendants("parametername") |> Seq.exactlyOne).Value
    let description = source.Descendants("parameterdescription") |> Seq.exactlyOne |> parseSimpleMarkup
    {MethodArg.Name = name; MethodArg.Description = description}

let parseMethodArgs (source: XElement) =
    source.Elements("parameteritem") |> Seq.map parseMethodArg |> Seq.toList

let parseMethodDetailedDescription (source: XElement) =
    let detailedDescription = source |> parseDetailedDescription
    let templateSource = source.Descendants("parameterlist") |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "templateparam")
    let templateParameters = match templateSource |> Seq.toList with
                             | [] -> []
                             | [parameterListElement] -> parameterListElement |> parseTemplateParameters
                             | _ -> failwith "Several sections with template parameters found"
    let returnValueSource = source.Descendants("simplesect") |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "return")
    let returnValue = match returnValueSource |> Seq.toList with
                      | [] -> []
                      | [returnValueElement] -> returnValueElement |> parseSimpleMarkup
                      | _ -> failwith "Several sections with return value found"
    let methodArgsSource = source.Descendants("parameterlist") |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "param")
    let methodArgs = match methodArgsSource |> Seq.toList with
                     | [] -> []
                     | [methodArgsElement] -> methodArgsElement |> parseMethodArgs
                     | _ -> failwith "Several sections with method args found"
    {MethodDetailedDescription.TemplateParameters = templateParameters;
     MethodDetailedDescription.Args = methodArgs;
     MethodDetailedDescription.ReturnValue = returnValue;
     MethodDetailedDescription.Description = detailedDescription}