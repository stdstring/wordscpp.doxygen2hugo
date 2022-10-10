module Defs

open System.IO
open System.Xml.Linq

type MarkupRef = {RefId: string; Kind: string option; External: string option; Text: string}

type MarkupDef =
    | Text of string
    | ParagraphStart
    | ParagraphEnd
    | BoldStart
    | BoldEnd
    | Ref of MarkupRef

type TextWithRefs =
    | Text of string
    | Ref of MarkupRef

type Description = {Brief: MarkupDef list; Detailed: string}

type EnumValueDef = {Id: string;
                     Name: string;
                     Initializer: string option;
                     Description: Description}

type EnumDef = {Id: string;
                ParentId: string;
                Name: string;
                QualifiedName: string;
                BaseType: string;
                Description: Description;
                Values: EnumValueDef list}

type TypedefDef = {Id: string;
                   ParentId: string;
                   Name: string;
                   QualifiedName: string;
                   SourceType: string;
                   Definition: string;
                   Description: Description}

type MethodParameterDef = {Name: string; Type: TextWithRefs list}

type MethodDef = {Id: string;
                  ParentId: string;
                  Name: string;
                  ClassName: string;
                  IsStatic: bool;
                  IsConst: bool;
                  IsExplicit: bool;
                  IsVirtual: bool;
                  IsOverride: bool;
                  Description: Description;
                  Parameters: MethodParameterDef list;
                  ReturnType: TextWithRefs list}

type ClassKind = 
    | Class
    | Interface

type BaseClassDef = {Access: string; Virtual: bool; QualifiedName: string}

type ClassDef = {Id: string;
                 ParentId: string;
                 Name: string;
                 FullName: string;
                 Final: bool;
                 Kind: ClassKind;
                 Description: Description
                 BaseClasses: BaseClassDef list;
                 DirectMethods: MethodDef list;
                 MemberRefs: Refs.MemberRef list}

type NamespaceDef = {Id: string;
                     Name: string;
                     Description: Description;
                     Enums: EnumDef list;
                     Typedefs: TypedefDef list;
                     Classes: ClassDef list
                     Interfaces: ClassDef list}

type EntityDef = 
    | Namespace of NamespaceDef
    | Class of ClassDef
    | Interface of ClassDef
    | Enum of EnumDef
    | Typedef of TypedefDef
    | Method of MethodDef
    // field

// parse defs

(*let getFinalValue (source: XElement) =
    match "final" |> findAttributeValue source with
    | None -> false
    | Some "no" -> false
    | Some "yes" -> true
    | _ -> failwith "Unexpected \"final\" attribute value"*)

let getVirtualValue (source: XElement) =
    match "virt" |> Utils.getAttributeValue source with
    | "virtual" -> true
    | "pure-virtual" -> true
    | "non-virtual" -> false
    | value -> value |> failwithf "Unexpected \"virt\" attribute value \"%s\""

// TODO (std_string) : think about name
let getYesNoValue (name: string) (source: XElement) =
    match name |> Utils.getAttributeValue source with
    | "no" -> false
    | "yes" -> true
    | _ -> name |> failwithf "Unexpected \"%s\" attribute value"

// TODO (std_string) : think about name
let findYesNoValue (name: string) (source: XElement) =
    match name |> Utils.findAttributeValue source with
    | None -> false
    | Some "no" -> false
    | Some "yes" -> true
    | _ -> name |> failwithf "Unexpected \"%s\" attribute value"

let parseMarkupRef (source: XElement) =
    let refId = "refid" |> Utils.getAttributeValue source
    let kind = "kindref" |> Utils.findAttributeValue source
    let external = "external" |> Utils.findAttributeValue source
    let text = source.Value
    {MarkupRef.RefId = refId; MarkupRef.Kind = kind; MarkupRef.External = external; MarkupRef.Text = text}

let parseTextWithMarkupRefs (source: XElement) =
    let parseFun (node: XNode) =
        match node with
        | :? XElement ->
            let element = node :?> XElement
            match element.Name.LocalName with
            | "ref" -> element |> parseMarkupRef |> TextWithRefs.Ref
            | name -> name |> failwithf "Unexpected text with refs XML element with name \"%s\""
        | :? XText -> (node :?> XText).Value |> TextWithRefs.Text
        | _ -> node.NodeType |> failwithf "Unexpected text with refs XML node with type %A"
    source.Nodes() |> Seq.map parseFun |> Seq.toList

let rec parseMarkup (node: XNode) =
    match node with
    | :? XElement ->
        let element = node :?> XElement
        match element.Name.LocalName with
        | "para" ->
            seq {yield MarkupDef.ParagraphStart; yield! element.Nodes() |> Seq.map parseMarkup |> Seq.concat; yield MarkupDef.ParagraphEnd}
        | "bold" ->
            seq {yield MarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkup |> Seq.concat; yield MarkupDef.BoldEnd}
        // TODO (std_string) : think about processing of computeroutput node
        | "computeroutput" ->
            seq {yield MarkupDef.BoldStart; yield! element.Nodes() |> Seq.map parseMarkup |> Seq.concat; yield MarkupDef.BoldEnd}
        | "ref" ->
            seq {yield element |> parseMarkupRef |> MarkupDef.Ref}
        | name -> name |> failwithf "Unexpected Markup XML element with name \"%s\""
    | :? XText -> (node :?> XText).Value |> MarkupDef.Text |> Seq.singleton
    | _ -> node.NodeType |> failwithf "Unexpected Markup XML node with type %A"

let parseBriefDescription (briefDescriptionElement: XElement) =
    match briefDescriptionElement.IsEmpty with
    | true -> []
    | false ->
        match briefDescriptionElement.Nodes() |> Seq.toList with
        | [] -> []
        | nodes -> nodes |> Seq.map parseMarkup |> Seq.concat |>  Seq.toList

let parseDescription (source: XElement) =
    let brief = source.Element("briefdescription") |> parseBriefDescription
    //let detailed = "detaileddescription" |> getElementValue source
    let detailed = ""
    {Description.Brief = brief; Description.Detailed = detailed}

let parseEnumValueDef (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let description = source |> parseDescription
    let name = "name" |> Utils.getElementValue source
    let initializer = "initializer" |> Utils.findElementValue source
    {EnumValueDef.Id = id;
     EnumValueDef.Name = name;
     EnumValueDef.Initializer = initializer;
     EnumValueDef.Description = description}

let parseEnumDef (parentId: string) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let description = source |> parseDescription
        let name = "name" |> Utils.getElementValue source
        let qualifiedName = "qualifiedname" |> Utils.getElementValue source
        let baseType = "type" |> Utils.getElementValue source
        let values = source.Elements("enumvalue") |> Seq.map parseEnumValueDef |> Seq.toList
        {EnumDef.Id = id;
         EnumDef.ParentId = parentId;
         EnumDef.Name = name;
         EnumDef.QualifiedName = qualifiedName;
         EnumDef.BaseType = baseType;
         EnumDef.Description = description;
         EnumDef.Values = values} |> Some
    | _ -> None

let parseTypedefDef (parentId: string) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let description = source |> parseDescription
        let name = "name" |> Utils.getElementValue source
        let qualifiedName = "qualifiedname" |> Utils.getElementValue source
        let sourceType = "type" |> Utils.getElementValue source
        let definition = "definition" |> Utils.getElementValue source
        {TypedefDef.Id = id;
         TypedefDef.ParentId = parentId;
         TypedefDef.Name = name;
         TypedefDef.QualifiedName = qualifiedName;
         TypedefDef.SourceType = sourceType;
         TypedefDef.Definition = definition;
         TypedefDef.Description = description} |> Some
    | _ -> None

let parseMethodParameter (source: XElement) =
    let paramName = "declname" |> Utils.getElementValue source
    let paramType = "type" |> Utils.getElement source |> parseTextWithMarkupRefs
    {MethodParameterDef.Name = paramName; MethodParameterDef.Type = paramType}

[<Literal>]
let OverrideSuffix = " override"

let parseMethodDef (parentId: string) (className: string) (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let staticValue = source |> getYesNoValue "static"
    let constValue = source |> getYesNoValue "const"
    let explicitValue = source |> getYesNoValue "explicit"
    let virtualValue = source |> getVirtualValue
    let name = "name" |> Utils.getElementValue source
    //let qualifiedName = "qualifiedname" |> getElementValue source
    let returnType = "type" |> Utils.getElement source |> parseTextWithMarkupRefs
    //let definition = "definition" |> getElementValue source
    let argString = "argsstring" |> Utils.getElementValue source
    let description = source |> parseDescription
    let overrideValue = argString.EndsWith(OverrideSuffix)
    let parameters = source.Elements("param") |> Seq.map parseMethodParameter |> Seq.toList
    {MethodDef.Id = id;
     MethodDef.ParentId = parentId;
     MethodDef.Name = name;
     MethodDef.ClassName = className;
     MethodDef.IsStatic = staticValue;
     MethodDef.IsConst = constValue;
     MethodDef.IsExplicit = explicitValue;
     MethodDef.IsVirtual = virtualValue;
     MethodDef.IsOverride = overrideValue;
     MethodDef.Description = description;
     MethodDef.Parameters = parameters;
     MethodDef.ReturnType = returnType}

let parseDirectMethods (parentId: string) (className: string) (source: XElement) =
    source.Elements("sectiondef")
        |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "public-func" || kind = "public-static-func")
        |> Seq.map (fun section -> section.Elements("memberdef"))
        |> Seq.concat
        |> Seq.map (fun element -> element |> parseMethodDef parentId className)
        |> Seq.toList

let parseBaseClassDef (source: XElement) =
    let access = "prot" |> Utils.getAttributeValue source
    let virtualValue = source |> getVirtualValue
    let qualifiedName = source.Value
    {BaseClassDef.Access = access; BaseClassDef.Virtual = virtualValue; BaseClassDef.QualifiedName = qualifiedName}

let parseClassDef (parentId: string) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let kind = match "kind" |> Utils.getAttributeValue source with
                   | "class" -> ClassKind.Class
                   | "interface" -> ClassKind.Interface
                   | value -> value |> failwithf "Unexpected kind value \"%s\""
        let description = source |> parseDescription
        let fullName = "compoundname" |> Utils.getElementValue source
        let name = fullName |> Utils.getClassName
        let finalValue = source |> findYesNoValue "final"
        let baseClasses = "basecompoundref" |> source.Elements |> Seq.map parseBaseClassDef |> Seq.toList
        let directMethods = source |> parseDirectMethods parentId name
        let memberRefs = source.Element("listofallmembers").Elements("member") |> Seq.choose Refs.parseMemberRef |> Seq.toList
        (*for e in source.Descendants("sectiondef") do
            match "kind" |> getAttributeValue e with
            | "private-type" -> ()
            | "private-attrib" -> ()
            | "private-func" -> ()
            | "private-static-attrib" -> ()
            | "public-func" -> ()
            | "public-static-func" -> ()
            | "public-static-attrib" -> ()
            | "public-type" -> ()
            | value -> value |> failwithf "Unexpected kind value \"%s\""*)
        {ClassDef.Id = id;
         ClassDef.ParentId = parentId;
         ClassDef.Name = name;
         ClassDef.FullName = fullName;
         ClassDef.Final = finalValue;
         ClassDef.Kind = kind;
         ClassDef.Description = description;
         ClassDef.BaseClasses = baseClasses;
         ClassDef.DirectMethods = directMethods;
         ClassDef.MemberRefs = memberRefs} |> Some
    | _ -> None

let parseEnumSectionDef (parentId: string) (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> Utils.getAttributeValue sectionDef = "enum") |> Seq.toList with
    | [] -> []
    | [enumSection] -> enumSection.Elements("memberdef") |> Seq.choose (fun def -> def |> parseEnumDef parentId) |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"enum\""

let parseTypedefSectionDef (parentId: string) (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> Utils.getAttributeValue sectionDef = "typedef") |> Seq.toList with
    | [] -> []
    | [typedefSection] -> typedefSection.Elements("memberdef") |> Seq.choose (fun def -> def |> parseTypedefDef parentId) |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"typedef\""

let parseClassRefEntry (parentId: string) (config: Config.ConfigData) (refEntry: XElement) =
    match "prot" |> Utils.getAttributeValue refEntry with
    | "public" ->
        let refId = "refid" |> Utils.getAttributeValue refEntry
        let document = Path.Combine(config.SourceDirectory, refId + ".xml") |> XDocument.Load
        document.Root.Elements("compounddef") |> Seq.choose (fun def -> def |> parseClassDef parentId) |> Some
    | _ -> None

let parseNamespaceDef (config: Config.ConfigData) (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let name = "compoundname" |> Utils.getElementValue source
    let description = source |> parseDescription
    let classDefSources = source.Elements("innerclass") |> Seq.choose (fun refEntry -> refEntry |> parseClassRefEntry id config) |> Seq.concat |> Seq.toList
    let classDefs = classDefSources |> List.filter (fun def -> def.Kind = ClassKind.Class)
    let interfaceDefs = classDefSources |> List.filter (fun def -> def.Kind = ClassKind.Interface)
    let enumDefs = source |> parseEnumSectionDef id
    let typedefs = source |> parseTypedefSectionDef id
    {NamespaceDef.Id = id;
     NamespaceDef.Name = name;
     NamespaceDef.Description = description;
     NamespaceDef.Enums = enumDefs;
     NamespaceDef.Typedefs = typedefs;
     NamespaceDef.Classes = classDefs;
     NamespaceDef.Interfaces = interfaceDefs;}

let parseNamespaceFile (config: Config.ConfigData) (refEntry: Refs.NamespaceRefEntry) =
    let document = Path.Combine(config.SourceDirectory, refEntry.RefId + ".xml") |> XDocument.Load
    document.Root.Elements("compounddef") |> Seq.exactlyOne |> parseNamespaceDef config