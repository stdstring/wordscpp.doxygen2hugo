// For more information see https://aka.ms/fsharp-console-apps

open System.IO
open System.Text
open System.Xml.Linq

// global defs

[<Literal>]
let IndexFilename = "index.xml"

[<Literal>]
let RootDirectory = "cpp"

[<Literal>]
let MarkdownFilename = "_index.md"

[<Literal>]
let nameDelimiter = "::"

// config

type ConfigData = {SourceDirectory: string; DestDirectory: string}

// utils

let getAttributeValue (source: XElement) (attributeName: string) = (source.Attributes(attributeName) |> Seq.exactlyOne).Value

let findAttributeValue (source: XElement) (attributeName: string) =
    match source.Attribute(attributeName) with
    | null -> None
    | attribute -> attribute.Value |> Some

let getElement (source: XElement) (elementName: string) = source.Elements(elementName) |> Seq.exactlyOne

let getElementValue (source: XElement) (elementName: string) = (elementName |> getElement source).Value

let findElementValue (source: XElement) (elementName: string) =
    match source.Element(elementName) with
    | null -> None
    | element -> element.Value |> Some

let getClassName (fullName: string) =
    match fullName.LastIndexOf(nameDelimiter) with
    | -1 -> nameDelimiter |> failwithf "Unprocessed class name \"%s\""
    | lastDelimiterPos -> fullName.Substring(lastDelimiterPos + nameDelimiter.Length).ToLower()

let createNamespaceFolderName (name: string) = name.ToLower().Replace("::", ".")

let createSimpleFolderName (name: string) = name.ToLower()

(*let createClassFolderName (name: string) =
    match name.LastIndexOf("::") with
    | -1 -> name |> failwithf "Unprocessed class name \"%s\""
    | lastDelimiterPos ->
        name.Substring(lastDelimiterPos + nameDelimiter.Length).ToLower()

let createEnumFolderName (name: string) = name.ToLower()

let createTypedefFolderName (name: string) = name.ToLower()*)

// ref data

(*type RefData = {RefId: string; Name: string}

type ClassMemberRef =
    | TypedefRef of RefData
    | VarRef of RefData
    | FuncRef of RefData
    | EnumRef of RefData

type NamespaceDefRef =
    | EnumRef of RefData
    | TypedefRef of RefData

type ClassRefData = {RefId: string; Name: string; Members: ClassMemberRef list}

type NamespaceRefData = {RefId: string; Name: string; Defs: NamespaceDefRef list}

type IndexFileEntry =
    | ClassRef of ClassRefData
    | InterfaceRef of ClassRefData
    | NamespaceRef of NamespaceRefData*)

type RefData = {RefId: string; Name: string}

type NamespaceDefRef =
    | EnumRef of RefData
    | TypedefRef of RefData

type NamespaceRefEntry = {RefId: string; Name: string; Defs: NamespaceDefRef list}

type MemberRef = {Name: string; RefId: string}

// parse refs

(*let parseClassMemberRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let kind = "kind" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let refData = {RefData.RefId = refId; RefData.Name = name}
    match kind with
    | "typedef" -> refData |> ClassMemberRef.TypedefRef |> Some
    | "variable" -> refData |> ClassMemberRef.VarRef |> Some
    | "function" -> refData |> ClassMemberRef.FuncRef |> Some
    | "enum" -> refData |> ClassMemberRef.EnumRef |> Some
    | "enumvalue" -> None
    //| _ -> None
    | _ -> failwithf "Unknown class member kind: \"%s\"" kind

let parseNamespaceDefRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let kind = "kind" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let refData = {RefData.RefId = refId; RefData.Name = name}
    match kind with
    | "enum" -> refData |> NamespaceDefRef.EnumRef |> Some
    | "enumvalue" -> None
    | "typedef" -> refData |> NamespaceDefRef.TypedefRef |> Some
    | _ -> failwithf "Unknown namespace def kind: \"%s\"" kind
    //| _ -> None

let parseClassRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let members = source.Elements("member") |> Seq.choose parseClassMemberRef |> Seq.toList
    {ClassRefData.RefId = refId; ClassRefData.Name = name; ClassRefData.Members = members} |> IndexFileEntry.ClassRef

let parseInterfaceRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let members = source.Elements("member") |> Seq.choose parseClassMemberRef |> Seq.toList
    {ClassRefData.RefId = refId; ClassRefData.Name = name; ClassRefData.Members = members} |> IndexFileEntry.InterfaceRef

let parseNamespaceRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let defs = source.Elements("member") |> Seq.choose parseNamespaceDefRef |> Seq.toList
    {NamespaceRefData.RefId = refId; NamespaceRefData.Name = name; NamespaceRefData.Defs = defs} |> IndexFileEntry.NamespaceRef

let parseCompondElement (source: XElement) =
    let kind = source.Attribute("kind").Value
    match kind with
    | "class" -> source |> parseClassRef |> Some
    | "interface" -> source |> parseInterfaceRef |> Some
    | "namespace" -> source |> parseNamespaceRef |> Some
    | "file" -> None
    | "dir" -> None
    | _ -> failwithf "Unknown index entry kind: \"%s\"" kind
    //| _ -> None

let parseIndexFile (path: string) =
    let document = path |> XDocument.Load
    let root = document.Root;
    root.Elements("compound") |> Seq.choose parseCompondElement |> Seq.toArray*)

let parseNamespaceRefDef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let kind = "kind" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let refData = {RefData.RefId = refId; RefData.Name = name}
    match kind with
    | "enum" -> refData |> NamespaceDefRef.EnumRef |> Some
    | "enumvalue" -> None
    | "typedef" -> refData |> NamespaceDefRef.TypedefRef |> Some
    | _ -> failwithf "Unknown namespace def kind: \"%s\"" kind
    //| _ -> None

let parseNamespaceRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let name = "name" |> getElementValue source
    let defs = source.Elements("member") |> Seq.choose parseNamespaceRefDef |> Seq.toList
    {NamespaceRefEntry.RefId = refId; NamespaceRefEntry.Name = name; NamespaceRefEntry.Defs = defs}

let parseCompondElement (source: XElement) =
    let kind = source.Attribute("kind").Value
    match kind with
    | "class" -> None
    | "interface" -> None
    | "namespace" -> source |> parseNamespaceRef |> Some
    | "file" -> None
    | "dir" -> None
    | _ -> failwithf "Unknown index entry kind: \"%s\"" kind
    //| _ -> None

let parseIndexFile (config: ConfigData) =
    let document = Path.Combine(config.SourceDirectory, IndexFilename) |> XDocument.Load
    let root = document.Root;
    root.Elements("compound") |> Seq.choose parseCompondElement |> Seq.toArray

let parseMemberRef (source: XElement) =
    match "prot" |> getAttributeValue source with
    | "public" ->
        let refId = "refid" |> getAttributeValue source
        let name = "name" |> getElementValue source
        {MemberRef.Name = name; MemberRef.RefId = refId} |> Some
    | _ -> None

// defs

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
                 MemberRefs: MemberRef list}

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
    match "virt" |> getAttributeValue source with
    | "virtual" -> true
    | "pure-virtual" -> true
    | "non-virtual" -> false
    | value -> value |> failwithf "Unexpected \"virt\" attribute value \"%s\""

// TODO (std_string) : think about name
let getYesNoValue (name: string) (source: XElement) =
    match name |> getAttributeValue source with
    | "no" -> false
    | "yes" -> true
    | _ -> name |> failwithf "Unexpected \"%s\" attribute value"

// TODO (std_string) : think about name
let findYesNoValue (name: string) (source: XElement) =
    match name |> findAttributeValue source with
    | None -> false
    | Some "no" -> false
    | Some "yes" -> true
    | _ -> name |> failwithf "Unexpected \"%s\" attribute value"

let parseMarkupRef (source: XElement) =
    let refId = "refid" |> getAttributeValue source
    let kind = "kindref" |> findAttributeValue source
    let external = "external" |> findAttributeValue source
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
    let id = "id" |> getAttributeValue source
    let description = source |> parseDescription
    let name = "name" |> getElementValue source
    let initializer = "initializer" |> findElementValue source
    {EnumValueDef.Id = id;
     EnumValueDef.Name = name;
     EnumValueDef.Initializer = initializer;
     EnumValueDef.Description = description}

let parseEnumDef (parentId: string) (source: XElement) =
    match "prot" |> getAttributeValue source with
    | "public" ->
        let id = "id" |> getAttributeValue source
        let description = source |> parseDescription
        let name = "name" |> getElementValue source
        let qualifiedName = "qualifiedname" |> getElementValue source
        let baseType = "type" |> getElementValue source
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
    match "prot" |> getAttributeValue source with
    | "public" ->
        let id = "id" |> getAttributeValue source
        let description = source |> parseDescription
        let name = "name" |> getElementValue source
        let qualifiedName = "qualifiedname" |> getElementValue source
        let sourceType = "type" |> getElementValue source
        let definition = "definition" |> getElementValue source
        {TypedefDef.Id = id;
         TypedefDef.ParentId = parentId;
         TypedefDef.Name = name;
         TypedefDef.QualifiedName = qualifiedName;
         TypedefDef.SourceType = sourceType;
         TypedefDef.Definition = definition;
         TypedefDef.Description = description} |> Some
    | _ -> None

let parseMethodParameter (source: XElement) =
    let paramName = "declname" |> getElementValue source
    let paramType = "type" |> getElement source |> parseTextWithMarkupRefs
    {MethodParameterDef.Name = paramName; MethodParameterDef.Type = paramType}

[<Literal>]
let OverrideSuffix = " override"

let parseMethodDef (parentId: string) (className: string) (source: XElement) =
    let id = "id" |> getAttributeValue source
    let staticValue = source |> getYesNoValue "static"
    let constValue = source |> getYesNoValue "const"
    let explicitValue = source |> getYesNoValue "explicit"
    let virtualValue = source |> getVirtualValue
    let name = "name" |> getElementValue source
    //let qualifiedName = "qualifiedname" |> getElementValue source
    let returnType = "type" |> getElement source |> parseTextWithMarkupRefs
    //let definition = "definition" |> getElementValue source
    let argString = "argsstring" |> getElementValue source
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
        |> Seq.filter (fun element -> let kind = "kind" |> getAttributeValue element in kind = "public-func" || kind = "public-static-func")
        |> Seq.map (fun section -> section.Elements("memberdef"))
        |> Seq.concat
        |> Seq.map (fun element -> element |> parseMethodDef parentId className)
        |> Seq.toList

let parseBaseClassDef (source: XElement) =
    let access = "prot" |> getAttributeValue source
    let virtualValue = source |> getVirtualValue
    let qualifiedName = source.Value
    {BaseClassDef.Access = access; BaseClassDef.Virtual = virtualValue; BaseClassDef.QualifiedName = qualifiedName}

let parseClassDef (parentId: string) (source: XElement) =
    match "prot" |> getAttributeValue source with
    | "public" ->
        let id = "id" |> getAttributeValue source
        let kind = match "kind" |> getAttributeValue source with
                   | "class" -> ClassKind.Class
                   | "interface" -> ClassKind.Interface
                   | value -> value |> failwithf "Unexpected kind value \"%s\""
        let description = source |> parseDescription
        let fullName = "compoundname" |> getElementValue source
        let name = fullName |> getClassName
        let finalValue = source |> findYesNoValue "final"
        let baseClasses = "basecompoundref" |> source.Elements |> Seq.map parseBaseClassDef |> Seq.toList
        let directMethods = source |> parseDirectMethods parentId name
        let memberRefs = source.Element("listofallmembers").Elements("member") |> Seq.choose parseMemberRef |> Seq.toList
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
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> getAttributeValue sectionDef = "enum") |> Seq.toList with
    | [] -> []
    | [enumSection] -> enumSection.Elements("memberdef") |> Seq.choose (fun def -> def |> parseEnumDef parentId) |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"enum\""

let parseTypedefSectionDef (parentId: string) (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> getAttributeValue sectionDef = "typedef") |> Seq.toList with
    | [] -> []
    | [typedefSection] -> typedefSection.Elements("memberdef") |> Seq.choose (fun def -> def |> parseTypedefDef parentId) |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"typedef\""

let parseClassRefEntry (parentId: string) (config: ConfigData) (refEntry: XElement) =
    match "prot" |> getAttributeValue refEntry with
    | "public" ->
        let refId = "refid" |> getAttributeValue refEntry
        let document = Path.Combine(config.SourceDirectory, refId + ".xml") |> XDocument.Load
        document.Root.Elements("compounddef") |> Seq.choose (fun def -> def |> parseClassDef parentId) |> Some
    | _ -> None

let parseNamespaceDef (config: ConfigData) (source: XElement) =
    let id = "id" |> getAttributeValue source
    let name = "compoundname" |> getElementValue source
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

let parseNamespaceFile (config: ConfigData) (refEntry: NamespaceRefEntry) =
    let document = Path.Combine(config.SourceDirectory, refEntry.RefId + ".xml") |> XDocument.Load
    document.Root.Elements("compounddef") |> Seq.exactlyOne |> parseNamespaceDef config

// generator

type KeyValueEntry = {Key: string; Value: string}

type GenerateEntry = {Title: string; BriefDescription: string}

let generateLink (name: string) (url: string) = $"[{name}]({url})"

let generateBriefDescriptionForTitle (description: Description) =
    let result = new StringBuilder()
    for markupEntry in description.Brief do
        match markupEntry with
        | MarkupDef.Text text -> text |> result.Append |> ignore
        | MarkupDef.Ref data -> data.Text |> result.Append |> ignore
        | _ -> ()
    result.ToString()

let generateBriefDescription (description: Description) =
    let result = new StringBuilder()
    for markupEntry in description.Brief do
        match markupEntry with
        | MarkupDef.Text text -> text |> result.Append |> ignore
        // TODO (std_string) : fix ref generation
        | MarkupDef.Ref data -> data.Text |> result.Append |> ignore
        //| MarkupDef.ParagraphStart -> result.AppendLine() |> ignore
        //| MarkupDef.ParagraphEnd -> result.AppendLine() |> ignore
        | MarkupDef.ParagraphStart -> ()
        | MarkupDef.ParagraphEnd -> ()
        | MarkupDef.BoldStart -> "**" |> result.Append |> ignore
        | MarkupDef.BoldEnd -> "**" |> result.Append |> ignore
    result.ToString()

let generatePageHeader (dest: StringBuilder) (data: seq<KeyValueEntry>) =
    "---" |> dest.AppendLine |> ignore
    for entry in data do
        entry.Key |> dest.Append |> ignore
        ": " |> dest.Append |> ignore
        entry.Value |> dest.AppendLine |> ignore
    "---" |> dest.AppendLine |> ignore

let generateRootPageHeader (url: string) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = "Aspose.Words for C++"};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "0"};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url};
     {KeyValueEntry.Key = "keywords"; KeyValueEntry.Value = "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\""};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = "Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks."};
     {KeyValueEntry.Key = "is_root"; KeyValueEntry.Value = "true"}] |> generatePageHeader dest

let generateDefPageHeader (title: string) (description: string) (url: string) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = title};
     {KeyValueEntry.Key = "second_title"; KeyValueEntry.Value = "Aspose.Words for C++ API Reference"};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = description};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "0"};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url}] |> generatePageHeader dest

let generateHeader (headerText: string) (headerLevel: int) (dest: StringBuilder) =
    "#" |> String.replicate headerLevel |> dest.Append |> ignore
    " " |> dest.Append |> ignore
    headerText |> dest.AppendLine |> ignore
    dest.AppendLine() |> ignore

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

let prepareDirectory (config: ConfigData) =
    let rootDirectory = Path.Combine(config.DestDirectory, RootDirectory)
    if rootDirectory |> Directory.Exists then
        Directory.Delete(rootDirectory, true)
    rootDirectory |> Directory.CreateDirectory |> ignore
    rootDirectory

let generateForEnum (parentDirectory: string) (parentUrl: string) (enumDef: EnumDef) =
    let folderName = enumDef.Name |> createSimpleFolderName
    let enumDirectory = Path.Combine(parentDirectory, folderName)
    enumDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = sprintf $"{parentUrl}{folderName}/"
    let builder = new StringBuilder()
    let descriptionForTitle = enumDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader enumDef.Name descriptionForTitle classUrl
    let briefDescription = enumDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(enumDirectory, MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink enumDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForTypedef (parentDirectory: string) (parentUrl: string) (typedefDef: TypedefDef) =
    let folderName = typedefDef.Name |> createSimpleFolderName
    let typedefDirectory = Path.Combine(parentDirectory, folderName)
    typedefDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = sprintf $"{parentUrl}{folderName}/"
    let builder = new StringBuilder()
    let descriptionForTitle = typedefDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader typedefDef.Name descriptionForTitle classUrl
    let briefDescription = typedefDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(typedefDirectory, MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink typedefDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let createMethodEntry (folderName: string) (briefDescription: string) (methodDef: MethodDef) =
    let generateParameterType (dest: StringBuilder) (parameter: MethodParameterDef) =
        parameter.Type |> Seq.iter (fun part -> match part with
                                                | TextWithRefs.Text text -> text |> dest.Append |> ignore
                                                | TextWithRefs.Ref data -> data.Text |> dest.Append |> ignore)
    let generateParameterList (dest: StringBuilder) (parameters: MethodParameterDef list) =
        parameters |> Seq.iteri (fun index parameter -> match index with
                                                        | 0 -> ()
                                                        | _ -> ", " |> dest.Append |> ignore
                                                        parameter |> generateParameterType dest)
    let builder = new StringBuilder()
    if methodDef.IsVirtual && (methodDef.IsOverride |> not) then
        "virtual " |> builder.Append |> ignore
    if methodDef.IsExplicit then
        "explicit " |> builder.Append |> ignore
    if methodDef.IsStatic then
        "static " |> builder.Append |> ignore
    sprintf $"./{folderName}/" |> generateLink methodDef.Name |> builder.Append |> ignore
    "(" |> builder.Append |> ignore
    methodDef.Parameters |> generateParameterList builder
    ")" |> builder.Append |> ignore
    if methodDef.IsConst then
        " const" |> builder.Append |> ignore
    if methodDef.IsOverride then
        " override" |> builder.Append |> ignore
    {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}

let generateForDirectMethod (parentDirectory: string) (parentUrl: string) (methodDef: MethodDef) =
    let folderName = methodDef.Name |> createSimpleFolderName
    let methodDirectory = Path.Combine(parentDirectory, folderName)
    methodDirectory |> Directory.CreateDirectory |> ignore
    let methodUrl = sprintf $"{parentUrl}{folderName}/"
    let builder = new StringBuilder()
    let descriptionForTitle = methodDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader methodDef.Name descriptionForTitle methodUrl
    let briefDescription = methodDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(methodDirectory, MarkdownFilename), builder.ToString())
    methodDef |> createMethodEntry folderName briefDescription

let generateForClass (parentDirectory: string) (parentUrl: string) (classDef: ClassDef) =
    let folderName = classDef.Name |> createSimpleFolderName
    let classDirectory = Path.Combine(parentDirectory, folderName)
    classDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = sprintf $"{parentUrl}{folderName}/"
    let builder = new StringBuilder()
    let descriptionForTitle = classDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader classDef.Name descriptionForTitle classUrl
    let briefDescription = classDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    if classDef.DirectMethods.IsEmpty |> not then
        builder |> generateHeader "Methods" 2
        builder |> generateTableHeader ["Method"; "Description"]
        classDef.DirectMethods
                |> Seq.map (fun def -> def |> generateForDirectMethod classDirectory classUrl)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(classDirectory, MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink classDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForNamespace (parentDirectory: string) (parentUrl: string) (namespaceDef: NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> None
    | false ->
        let folderName = namespaceDef.Name |> createNamespaceFolderName
        let namespaceDirectory = Path.Combine(parentDirectory, folderName)
        namespaceDirectory |> Directory.CreateDirectory |> ignore
        let namespaceUrl = sprintf $"{parentUrl}{folderName}/"
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.Description |> generateBriefDescriptionForTitle
        builder |> generateDefPageHeader namespaceDef.Name descriptionForTitle namespaceUrl
        let briefDescription = namespaceDef.Description |> generateBriefDescription
        builder.AppendLine() |> ignore
        briefDescription |> builder.AppendLine |> ignore
        builder.AppendLine() |> ignore
        if namespaceDef.Classes.IsEmpty |> not then
            builder |> generateHeader "Classes" 2
            builder |> generateTableHeader ["Class"; "Description"]
            namespaceDef.Classes
                |> Seq.map (fun def -> def |> generateForClass namespaceDirectory namespaceUrl)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Interfaces.IsEmpty |> not then
            builder |> generateHeader "Interfaces" 2
            builder |> generateTableHeader ["Interface"; "Description"]
            namespaceDef.Interfaces
                |> Seq.map (fun def -> def |> generateForClass namespaceDirectory namespaceUrl)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Enums.IsEmpty |> not then
            builder |> generateHeader "Enums" 2
            builder |> generateTableHeader ["Enum"; "Description"]
            namespaceDef.Enums
                |> Seq.map (fun def -> def |> generateForEnum namespaceDirectory namespaceUrl)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Typedefs.IsEmpty |> not then
            builder |> generateHeader "Typedefs" 2
            builder |> generateTableHeader ["Typedef"; "Description"]
            namespaceDef.Typedefs
                |> Seq.map (fun def -> def |> generateForTypedef namespaceDirectory namespaceUrl)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        File.AppendAllText(Path.Combine(namespaceDirectory, MarkdownFilename), builder.ToString())
        {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink namespaceDef.Name;
         GenerateEntry.BriefDescription = briefDescription} |> Some

let generateDest (config: ConfigData) (namespaceDefs: NamespaceDef list) =
    let rootDirectory = config |> prepareDirectory
    let rootUrl = sprintf $"/{RootDirectory}/"
    let builder = new StringBuilder()
    builder |> generateRootPageHeader rootUrl
    builder.AppendLine() |> ignore
    builder |> generateHeader "Namespaces" 2
    builder |> generateTableHeader ["Namespace"; "Description"]
    namespaceDefs
        |> Seq.choose (fun def -> def |> generateForNamespace rootDirectory rootUrl)
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, MarkdownFilename), builder.ToString())

[<EntryPoint>]
let main argv = 
    let config = {ConfigData.SourceDirectory = "../../../../../SourceData/"; ConfigData.DestDirectory = "../../../../../DestData/"}
    let namespaceRefs = config |> parseIndexFile
    let namespaceDefs = namespaceRefs |>
                        Seq.filter (fun refEntry -> ["namespace_aspose"; "namespacestd"] |> List.contains refEntry.RefId |> not) |>
                        Seq.map (fun refEntry -> refEntry |> parseNamespaceFile config) |>
                        Seq.toList
    namespaceDefs |> generateDest config
    0 // return an integer exit code
