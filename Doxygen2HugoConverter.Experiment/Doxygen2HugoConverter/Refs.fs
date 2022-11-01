module Refs

open System.IO
open System.Xml.Linq

type RefData = {RefId: string; Name: string}

type NamespaceDefRef =
    | EnumRef of RefData
    | TypedefRef of RefData

type NamespaceRefEntry = {RefId: string; Name: string; Defs: NamespaceDefRef list}

type MemberRef = {Name: string; RefId: string}

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