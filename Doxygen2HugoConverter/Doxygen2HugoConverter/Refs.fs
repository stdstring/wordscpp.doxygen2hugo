module Refs

open System.IO
open System.Xml.Linq

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

// parse

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
    let refId = "refid" |> Utils.getAttributeValue source
    let kind = "kind" |> Utils.getAttributeValue source
    let name = "name" |> Utils.getElementValue source
    let refData = {RefData.RefId = refId; RefData.Name = name}
    match kind with
    | "enum" -> refData |> NamespaceDefRef.EnumRef |> Some
    | "enumvalue" -> None
    | "typedef" -> refData |> NamespaceDefRef.TypedefRef |> Some
    | _ -> failwithf "Unknown namespace def kind: \"%s\"" kind
    //| _ -> None

let parseNamespaceRef (source: XElement) =
    let refId = "refid" |> Utils.getAttributeValue source
    let name = "name" |> Utils.getElementValue source
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

let parseIndexFile (config: Config.ConfigData) =
    let document = Path.Combine(config.SourceDirectory, Common.IndexFilename) |> XDocument.Load
    let root = document.Root;
    root.Elements("compound") |> Seq.choose parseCompondElement |> Seq.toArray

let parseMemberRef (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let refId = "refid" |> Utils.getAttributeValue source
        let name = "name" |> Utils.getElementValue source
        {MemberRef.Name = name; MemberRef.RefId = refId} |> Some
    | _ -> None