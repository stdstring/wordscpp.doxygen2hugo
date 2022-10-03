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

let getAttributeValue (source: XElement) (attributeName: string) =
    (source.Attributes(attributeName) |> Seq.exactlyOne).Value

let findAttributeValue (source: XElement) (attributeName: string) =
    match source.Attribute(attributeName) with
    | null -> None
    | attribute -> attribute.Value |> Some

let getElementValue (source: XElement) (elementName: string) =
    (source.Elements(elementName) |> Seq.exactlyOne).Value

let findElementValue (source: XElement) (elementName: string) =
    match source.Element(elementName) with
    | null -> None
    | element -> element.Value |> Some

let createNamespaceFolderName (name: string) =
    name.ToLower().Replace("::", ".")

let createClassFolderName (name: string) =
    match name.LastIndexOf("::") with
    | -1 -> name |> failwithf "Unprocessed class name \"%s\""
    | lastDelimiterPos ->
        name.Substring(lastDelimiterPos + nameDelimiter.Length).ToLower()

let createEnumFolderName (name: string) =
    name.ToLower()

let createTypedefFolderName (name: string) =
    name.ToLower()

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

// defs

type MarkupRef = {RefId: string; Text: string}

type MarkupDef =
    | Text of string
    | ParagraphStart
    | ParagraphEnd
    | BoldStart
    | BoldEnd
    | Ref of MarkupRef

type Description = {Brief: MarkupDef list; Detailed: string}

type EnumValueDef = {Id: string;
                     Name: string;
                     Initializer: string option;
                     Description: Description}

type EnumDef = {Id: string;
                Name: string;
                QualifiedName: string;
                BaseType: string;
                Description: Description;
                Values: EnumValueDef list}

type TypedefDef = {Id: string;
                   Name: string;
                   QualifiedName: string;
                   SourceType: string;
                   Definition: string;
                   Description: Description}

type BaseClassDef = {Access: string; Virtual: bool; QualifiedName: string}

type ClassDef = {Id: string;
                 Name: string;
                 Final: bool;
                 Description: Description
                 BaseClasses: BaseClassDef list}

type NamespaceDef = {Id: string;
                     Name: string;
                     Description: Description;
                     Enums: EnumDef list;
                     Typedefs: TypedefDef list;
                     Classes: ClassDef list}

// parse defs

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
            let refId = "refid" |> getAttributeValue element
            let text = element.Value
            seq {yield {MarkupRef.RefId = refId; MarkupRef.Text = text} |> MarkupDef.Ref}
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

let parseEnumDef (source: XElement) =
    match "prot" |> getAttributeValue source with
    | "public" ->
        let id = "id" |> getAttributeValue source
        let description = source |> parseDescription
        let name = "name" |> getElementValue source
        let qualifiedName = "qualifiedname" |> getElementValue source
        let baseType = "type" |> getElementValue source
        let values = source.Elements("enumvalue") |> Seq.map parseEnumValueDef |> Seq.toList
        {EnumDef.Id = id;
         EnumDef.Name = name;
         EnumDef.QualifiedName = qualifiedName;
         EnumDef.BaseType = baseType;
         EnumDef.Description = description;
         EnumDef.Values = values} |> Some
    | _ -> None

let parseTypedefDef (source: XElement) =
    match "prot" |> getAttributeValue source with
    | "public" ->
        let id = "id" |> getAttributeValue source
        let description = source |> parseDescription
        let name = "name" |> getElementValue source
        let qualifiedName = "qualifiedname" |> getElementValue source
        let sourceType = "type" |> getElementValue source
        let definition = "definition" |> getElementValue source
        {TypedefDef.Id = id;
         TypedefDef.Name = name;
         TypedefDef.QualifiedName = qualifiedName;
         TypedefDef.SourceType = sourceType;
         TypedefDef.Definition = definition;
         TypedefDef.Description = description} |> Some
    | _ -> None

let getFinalValue (source: XElement) =
    match "final" |> findAttributeValue source with
    | None -> false
    | Some "no" -> false
    | Some "yes" -> true
    | _ -> failwith "Unexpected \"final\" attribute value"

let getVirtualValue (source: XElement) =
    match "virt" |> getAttributeValue source with
    | "virtual" -> true
    | "non-virtual" -> false
    | _ -> failwith "Unexpected \"virt\" attribute value"

let parseBaseClassDef (source: XElement) =
    let access = "prot" |> getAttributeValue source
    let virtualValue = source |> getVirtualValue
    let qualifiedName = source.Value
    {BaseClassDef.Access = access; BaseClassDef.Virtual = virtualValue; BaseClassDef.QualifiedName = qualifiedName}

let parseClassDef (source: XElement) =
    match "prot" |> getAttributeValue source with
    | "public" ->
        let id = "id" |> getAttributeValue source
        let description = source |> parseDescription
        let name = "compoundname" |> getElementValue source
        let finalValue = source |> getFinalValue
        let baseClasses = "basecompoundref" |> source.Elements |> Seq.map parseBaseClassDef |> Seq.toList
        {ClassDef.Id = id;
         ClassDef.Name = name;
         ClassDef.Final = finalValue;
         ClassDef.Description = description;
         ClassDef.BaseClasses = baseClasses} |> Some
    | _ -> None

let parseEnumSectionDef (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> getAttributeValue sectionDef = "enum") |> Seq.toList with
    | [] -> []
    | [enumSection] -> enumSection.Elements("memberdef") |> Seq.choose parseEnumDef |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"enum\""

let parseTypedefSectionDef (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> getAttributeValue sectionDef = "typedef") |> Seq.toList with
    | [] -> []
    | [typedefSection] -> typedefSection.Elements("memberdef") |> Seq.choose parseTypedefDef |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"typedef\""

let parseClassRefEntry (config: ConfigData) (refEntry: XElement) =
    match "prot" |> getAttributeValue refEntry with
    | "public" ->
        let refId = "refid" |> getAttributeValue refEntry
        let document = Path.Combine(config.SourceDirectory, refId + ".xml") |> XDocument.Load
        document.Root.Elements("compounddef") |> Seq.choose parseClassDef |> Some
    | _ -> None

let parseNamespaceDef (config: ConfigData) (source: XElement) =
    let id = "id" |> getAttributeValue source
    let name = "compoundname" |> getElementValue source
    let description = source |> parseDescription
    let classDefSources = source.Elements("innerclass") |> Seq.choose (fun refEntry -> refEntry |> parseClassRefEntry config) |> Seq.concat |> Seq.toList
    let enumDefs = source |> parseEnumSectionDef
    let typedefs = source |> parseTypedefSectionDef
    {NamespaceDef.Id = id;
     NamespaceDef.Name = name;
     NamespaceDef.Description = description;
     NamespaceDef.Enums = enumDefs;
     NamespaceDef.Typedefs = typedefs;
     NamespaceDef.Classes = classDefSources}

let parseNamespaceFile (config: ConfigData) (refEntry: NamespaceRefEntry) =
    let document = Path.Combine(config.SourceDirectory, refEntry.RefId + ".xml") |> XDocument.Load
    document.Root.Elements("compounddef") |> Seq.exactlyOne |> parseNamespaceDef config

// generator

type KeyValueEntry = {Key: string; Value: string}

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
        | MarkupDef.ParagraphStart -> result.AppendLine() |> ignore
        | MarkupDef.ParagraphEnd -> result.AppendLine() |> ignore
        | MarkupDef.BoldStart -> "**" |> result.Append |> ignore
        | MarkupDef.BoldEnd -> "**" |> result.Append |> ignore
    result.ToString()

let generateHeader (dest: StringBuilder) (data: seq<KeyValueEntry>) =
    "---" |> dest.AppendLine |> ignore
    for entry in data do
        entry.Key |> dest.Append |> ignore
        ": " |> dest.Append |> ignore
        entry.Value |> dest.AppendLine |> ignore
    "---" |> dest.AppendLine |> ignore

let generateRootHeader (url: string) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = "Aspose.Words for C++"};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "0"};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url};
     {KeyValueEntry.Key = "keywords"; KeyValueEntry.Value = "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\""};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = "Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks."};
     {KeyValueEntry.Key = "is_root"; KeyValueEntry.Value = "true"}] |> generateHeader dest

let generateDefHeader (title: string) (description: string) (url: string) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = title};
     {KeyValueEntry.Key = "second_title"; KeyValueEntry.Value = "Aspose.Words for C++ API Reference"};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = description};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "0"};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url}] |> generateHeader dest

let prepareDirectory (config: ConfigData) =
    let rootDirectory = Path.Combine(config.DestDirectory, RootDirectory)
    if rootDirectory |> Directory.Exists then
        Directory.Delete(rootDirectory, true)
    rootDirectory |> Directory.CreateDirectory |> ignore
    rootDirectory

let generateForNamespace (parentDirectory: string) (parentUrl: string) (namespaceDef: NamespaceDef) =
    match namespaceDef.Classes.IsEmpty && namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty with
    | true -> ()
    | false ->
        let folderName = namespaceDef.Name |> createNamespaceFolderName
        let namespaceDirectory = Path.Combine(parentDirectory, folderName)
        namespaceDirectory |> Directory.CreateDirectory |> ignore
        let namespaceUrl = sprintf $"{parentUrl}{folderName}/"
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.Description |> generateBriefDescriptionForTitle
        builder |> generateDefHeader namespaceDef.Name descriptionForTitle namespaceUrl
        namespaceDef.Description |> generateBriefDescription |> builder.Append |> ignore
        File.AppendAllText(Path.Combine(namespaceDirectory, MarkdownFilename), builder.ToString())

let generateResult (config: ConfigData) (namespaceDefs: NamespaceDef list) =
    let rootDirectory = config |> prepareDirectory
    let rootUrl = sprintf $"/{RootDirectory}/"
    let builder = new StringBuilder()
    builder |> generateRootHeader rootUrl
    for namespaceDef in namespaceDefs do
        namespaceDef |> generateForNamespace rootDirectory rootUrl
    File.AppendAllText(Path.Combine(rootDirectory, MarkdownFilename), builder.ToString())

[<EntryPoint>]
let main argv = 
    let config = {ConfigData.SourceDirectory = "../../../../../SourceData/"; ConfigData.DestDirectory = "../../../../../DestData/"}
    let namespaceRefs = config |> parseIndexFile
    let namespaceDefs = namespaceRefs |>
                        Seq.filter (fun refEntry -> ["namespace_aspose"; "namespacestd"] |> List.contains refEntry.RefId |> not) |>
                        Seq.map (fun refEntry -> refEntry |> parseNamespaceFile config) |>
                        Seq.toList
    namespaceDefs |> generateResult config
    0 // return an integer exit code
