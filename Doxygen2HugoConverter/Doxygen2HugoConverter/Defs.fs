﻿module Defs

open System.Collections.Generic
open System.IO
open System.Xml.Linq
open Markup

//type Description = {Brief: SimpleMarkupDef list; Detailed: string}

[<Literal>]
let defaultStartEnumValue = 0

type EnumValueDef = {Id: string;
                     Name: string;
                     Initializer: int;
                     BriefDescription: SimpleMarkupDef list;
                     DetailedDescription: string}

type EnumDef = {Id: string;
                ParentId: string;
                Name: string;
                QualifiedName: string;
                BaseType: string;
                BriefDescription: SimpleMarkupDef list;
                DetailedDescription: DetailedDescription;
                Values: EnumValueDef list}

type TypedefDef = {Id: string;
                   ParentId: string;
                   Name: string;
                   QualifiedName: string;
                   SourceType: string;
                   Definition: string;
                   BriefDescription: SimpleMarkupDef list;
                   DetailedDescription: DetailedDescription}

type MethodArgDef = {Name: string; Type: SimpleMarkupDef list}

type MethodDef = {Id: string;
                  ParentId: string;
                  Name: string;
                  ClassName: string;
                  IsStatic: bool;
                  IsConst: bool;
                  IsExplicit: bool;
                  IsVirtual: bool;
                  IsOverride: bool;
                  BriefDescription: SimpleMarkupDef list;
                  DetailedDescription: MethodDetailedDescription;
                  Definition: string;
                  ArgString: string;
                  TemplateParameters: string list;
                  Args: MethodArgDef list;
                  ReturnType: SimpleMarkupDef list}

type MethodGroupDef = {Name: string; Methods: MethodDef[]}

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
                 BriefDescription: SimpleMarkupDef list;
                 DetailedDescription: ClassDetailedDescription;
                 BaseClasses: BaseClassDef list;
                 TemplateParameters: string list;
                 DirectMethods: MethodGroupDef list;
                 MemberRefs: Refs.MemberRef list}

type NamespaceDef = {Id: string;
                     Name: string;
                     BriefDescription: SimpleMarkupDef list;
                     DetailedDescription: DetailedDescription;
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

type Context = {ParentId: string; ParentName: string; CommonEntityRepo: IDictionary<string, EntityDef>}

let createEmptyContext() =
    {Context.ParentId = ""; Context.ParentName = ""; Context.CommonEntityRepo = new Dictionary<string, EntityDef>()}

// parse defs

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

let parseTemplateParameters (source: XElement) =
    match source.Elements("templateparamlist") |> Seq.toList with
    | [] -> []
    | [parametersElement] -> parametersElement.Elements("param") |> Seq.map (fun element -> (element.Descendants("type") |> Seq.exactlyOne).Value) |> Seq.toList
    | _ -> failwith "Several sections \"templateparamlist\" found"

//let parseDescription (source: XElement) =
//    let brief = source.Element("briefdescription") |> parseBriefDescription
//    let detailed = "detaileddescription" |> getElementValue source
//    let detailed = ""
//    {Description.Brief = brief; Description.Detailed = detailed}

let parseBriefDescription (source: XElement) =
    source.Element("briefdescription") |> Markup.parseSimpleMarkup

let parseEnumDetailedDescription (source: XElement) = source.Element("detaileddescription") |> Markup.parseDetailedDescription

let parseTypedefDetailedDescription (source: XElement) = source.Element("detaileddescription") |> Markup.parseDetailedDescription

let parseMethodDetailedDescription (source: XElement) = source.Element("detaileddescription") |> Markup.parseMethodDetailedDescription

let parseClassDetailedDescription (source: XElement) = source.Element("detaileddescription") |> Markup.parseClassDetailedDescription

let parseNamespaceDetailedDescription (source: XElement) = source.Element("detaileddescription") |> Markup.parseDetailedDescription

(*let parseEnumValueInitializer (source: XElement) =
    match "initializer" |> Utils.findElementValue source with
    | None -> None
    | Some value -> value.Trim(' ', '=') |> int |> Some*)

let parseEnumValueDef (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let briefDescription = source |> parseBriefDescription
    let detailedDescription = ""
    let name = "name" |> Utils.getElementValue source
    //let initializer = source |> parseEnumValueInitializer
    {EnumValueDef.Id = id;
     EnumValueDef.Name = name;
     EnumValueDef.Initializer = 0;
     EnumValueDef.BriefDescription = briefDescription;
     EnumValueDef.DetailedDescription = detailedDescription;}

let parseEnumDef (context: Context) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let briefDescription = source |> parseBriefDescription
        let detailedDescription = source |> parseEnumDetailedDescription
        let name = "name" |> Utils.getElementValue source
        let qualifiedName = "qualifiedname" |> Utils.getElementValue source
        let baseType = "type" |> Utils.getElementValue source
        let values = source.Elements("enumvalue") |> Seq.map parseEnumValueDef |> Seq.toList
        let enumDef = {EnumDef.Id = id;
                       EnumDef.ParentId = context.ParentId;
                       EnumDef.Name = name;
                       EnumDef.QualifiedName = qualifiedName;
                       EnumDef.BaseType = baseType;
                       EnumDef.BriefDescription = briefDescription;
                       EnumDef.DetailedDescription = detailedDescription;
                       EnumDef.Values = values}
        context.CommonEntityRepo.Add(id, enumDef |> EntityDef.Enum)
        enumDef |> Some
    | _ -> None

(*let parseEnumValueInitializer (values: ResizeArray<EnumValueDef>) (source: XElement) =
    match "initializer" |> Utils.findElementValue source with
    | None when values.Count = 0 -> defaultStartEnumValue
    | None -> values.[values.Count - 1].Initializer + 1
    | Some value ->
        let preparedValue = value.Trim(' ', '=')
        match preparedValue.StartsWith("0x") with
        | true ->
            match System.Int32.TryParse(preparedValue.Substring("0x".Length), NumberStyles.HexNumber, CultureInfo.InvariantCulture) with
            | true, parsedValue -> parsedValue
            | false, _ -> failwithf "Bad initializer value \"%s\"" value
        | false ->
            match System.Int32.TryParse(preparedValue, NumberStyles.Integer, CultureInfo.InvariantCulture) with
            | true, parsedValue -> parsedValue
            // when initializer equals similar the following: "= static_cast<int32_t>(Unspecified)"
            | false, _ ->
                let openBracket = value.IndexOf('(')
                let closeBracket = value.IndexOf(')')
                match (openBracket <> -1) && (closeBracket <> -1) with
                | false -> failwithf "Bad initializer value \"%s\"" value
                | true ->
                    let name = value.Substring(openBracket + 1, closeBracket - openBracket - 1)
                    (values |> Seq.filter (fun enumValue -> enumValue.Name = name) |> Seq.exactlyOne).Initializer

let parseEnumValueDef (values: ResizeArray<EnumValueDef>) (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let briefDescription = source |> parseBriefDescription
    let detailedDescription = source |> parseDetailedDescription
    let name = "name" |> Utils.getElementValue source
    let initializer = source |> parseEnumValueInitializer values
    {EnumValueDef.Id = id;
     EnumValueDef.Name = name;
     EnumValueDef.Initializer = initializer;
     EnumValueDef.BriefDescription = briefDescription;
     EnumValueDef.DetailedDescription = detailedDescription;} |> values.Add

let parseEnumDef (context: Context) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let briefDescription = source |> parseBriefDescription
        let detailedDescription = source |> parseEnumDetailedDescription
        let name = "name" |> Utils.getElementValue source
        let qualifiedName = "qualifiedname" |> Utils.getElementValue source
        let baseType = "type" |> Utils.getElementValue source
        let values = ResizeArray<EnumValueDef>()
        source.Elements("enumvalue") |> Seq.iter (fun element -> element |> parseEnumValueDef values)
        let enumDef = {EnumDef.Id = id;
                       EnumDef.ParentId = context.ParentId;
                       EnumDef.Name = name;
                       EnumDef.QualifiedName = qualifiedName;
                       EnumDef.BaseType = baseType;
                       EnumDef.BriefDescription = briefDescription;
                       EnumDef.DetailedDescription = detailedDescription;
                       EnumDef.Values = values |> Seq.toList}
        context.CommonEntityRepo.Add(id, enumDef |> EntityDef.Enum)
        enumDef |> Some
    | _ -> None*)

let parseTypedefDef (context: Context) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let briefDescription = source |> parseBriefDescription
        let detailedDescription = source |> parseTypedefDetailedDescription
        let name = "name" |> Utils.getElementValue source
        let qualifiedName = "qualifiedname" |> Utils.getElementValue source
        let sourceType = "type" |> Utils.getElementValue source
        let definition = "definition" |> Utils.getElementValue source
        let typedefDef = {TypedefDef.Id = id;
                          TypedefDef.ParentId = context.ParentId;
                          TypedefDef.Name = name;
                          TypedefDef.QualifiedName = qualifiedName;
                          TypedefDef.SourceType = sourceType;
                          TypedefDef.Definition = definition;
                          TypedefDef.BriefDescription = briefDescription;
                          TypedefDef.DetailedDescription = detailedDescription;}
        context.CommonEntityRepo.Add(id, typedefDef |> EntityDef.Typedef)
        typedefDef |> Some
    | _ -> None

let parseMethodParameter (source: XElement) =
    let paramName = "declname" |> Utils.getElementValue source
    let paramType = "type" |> Utils.getElement source |> Markup.parseSimpleMarkup
    {MethodArgDef.Name = paramName; MethodArgDef.Type = paramType}

[<Literal>]
let OverrideSuffix = " override"

let parseMethodDef (context: Context) (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let staticValue = source |> getYesNoValue "static"
    let constValue = source |> getYesNoValue "const"
    let explicitValue = source |> getYesNoValue "explicit"
    let virtualValue = source |> getVirtualValue
    let name = "name" |> Utils.getElementValue source
    //let qualifiedName = "qualifiedname" |> getElementValue source
    let returnType = "type" |> Utils.getElement source |> Markup.parseSimpleMarkup
    let definition = "definition" |> Utils.getElementValue source
    let argString = "argsstring" |> Utils.getElementValue source
    let briefDescription = source |> parseBriefDescription
    let detailedDescription = source |> parseMethodDetailedDescription
    let overrideValue = argString.EndsWith(OverrideSuffix)
    let templateParameters = source |> parseTemplateParameters
    let parameters = source.Elements("param") |> Seq.map parseMethodParameter |> Seq.toList
    let methodDef = {MethodDef.Id = id;
                     MethodDef.ParentId = context.ParentId;
                     MethodDef.Name = name;
                     MethodDef.ClassName = context.ParentName;
                     MethodDef.IsStatic = staticValue;
                     MethodDef.IsConst = constValue;
                     MethodDef.IsExplicit = explicitValue;
                     MethodDef.IsVirtual = virtualValue;
                     MethodDef.IsOverride = overrideValue;
                     MethodDef.BriefDescription = briefDescription;
                     MethodDef.DetailedDescription = detailedDescription;
                     MethodDef.Definition = definition;
                     MethodDef.ArgString = argString;
                     MethodDef.TemplateParameters = templateParameters;
                     MethodDef.Args = parameters;
                     MethodDef.ReturnType = returnType}
    context.CommonEntityRepo.Add(id, methodDef |> EntityDef.Method)
    methodDef

let parseDirectMethods (context: Context) (source: XElement) =
    source.Elements("sectiondef")
        |> Seq.filter (fun element -> let kind = "kind" |> Utils.getAttributeValue element in kind = "public-func" || kind = "public-static-func")
        |> Seq.map (fun section -> section.Elements("memberdef"))
        |> Seq.concat
        |> Seq.map (fun element -> element |> parseMethodDef context)
        |> Seq.groupBy (fun methodDef -> methodDef.Name)
        |> Seq.map (fun (name, methods) -> {MethodGroupDef.Name = name; MethodGroupDef.Methods = methods |> Seq.toArray})
        |> Seq.toList

let parseBaseClassDef (source: XElement) =
    let access = "prot" |> Utils.getAttributeValue source
    let virtualValue = source |> getVirtualValue
    let qualifiedName = source.Value
    {BaseClassDef.Access = access; BaseClassDef.Virtual = virtualValue; BaseClassDef.QualifiedName = qualifiedName}

let parseClassDef (context: Context) (source: XElement) =
    match "prot" |> Utils.getAttributeValue source with
    | "public" ->
        let id = "id" |> Utils.getAttributeValue source
        let kind = match "kind" |> Utils.getAttributeValue source with
                   | "class" -> ClassKind.Class
                   | "interface" -> ClassKind.Interface
                   | value -> value |> failwithf "Unexpected kind value \"%s\""
        let briefDescription = source |> parseBriefDescription
        let detailedDescription = source |> parseClassDetailedDescription
        let fullName = "compoundname" |> Utils.getElementValue source
        let name = fullName |> Utils.getClassName
        let finalValue = source |> findYesNoValue "final"
        let baseClasses = "basecompoundref" |> source.Elements |> Seq.map parseBaseClassDef |> Seq.toList
        let templateParameters = source |> parseTemplateParameters
        let directMethods = source |> parseDirectMethods {context with ParentId = id; ParentName = name}
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
        let classDef = {ClassDef.Id = id;
                        ClassDef.ParentId = context.ParentId;
                        ClassDef.Name = name;
                        ClassDef.FullName = fullName;
                        ClassDef.Final = finalValue;
                        ClassDef.Kind = kind;
                        ClassDef.BriefDescription = briefDescription;
                        ClassDef.DetailedDescription = detailedDescription;
                        ClassDef.BaseClasses = baseClasses;
                        ClassDef.TemplateParameters = templateParameters;
                        ClassDef.DirectMethods = directMethods;
                        ClassDef.MemberRefs = memberRefs}
        let entityConstructor = match kind with
                                | ClassKind.Class -> EntityDef.Class
                                | ClassKind.Interface -> EntityDef.Interface
        context.CommonEntityRepo.Add(id, classDef |> entityConstructor)
        classDef |> Some
    | _ -> None

let parseEnumSectionDef (context: Context) (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> Utils.getAttributeValue sectionDef = "enum") |> Seq.toList with
    | [] -> []
    | [enumSection] -> enumSection.Elements("memberdef") |> Seq.choose (fun def -> def |> parseEnumDef context) |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"enum\""

let parseTypedefSectionDef (context: Context) (source: XElement) =
    match source.Elements("sectiondef") |> Seq.filter (fun sectionDef -> "kind" |> Utils.getAttributeValue sectionDef = "typedef") |> Seq.toList with
    | [] -> []
    | [typedefSection] -> typedefSection.Elements("memberdef") |> Seq.choose (fun def -> def |> parseTypedefDef context) |> Seq.toList
    | _ -> failwith "There are several sectiondef elements with kind = \"typedef\""

let parseClassRefEntry (context: Context) (config: Config.ConfigData) (refEntry: XElement) =
    match "prot" |> Utils.getAttributeValue refEntry with
    | "public" ->
        let refId = "refid" |> Utils.getAttributeValue refEntry
        let document = Path.Combine(config.SourceDirectory, refId + ".xml") |> XDocument.Load
        document.Root.Elements("compounddef") |> Seq.choose (fun def -> def |> parseClassDef context) |> Some
    | _ -> None

let parseNamespaceDef (config: Config.ConfigData) (context: Context) (source: XElement) =
    let id = "id" |> Utils.getAttributeValue source
    let name = "compoundname" |> Utils.getElementValue source
    let briefDescription = source |> parseBriefDescription
    let detailedDescription = source |> parseNamespaceDetailedDescription
    let currentContext = {context with ParentId = id; ParentName = name}
    let classDefSources = source.Elements("innerclass") |> Seq.choose (fun refEntry -> refEntry |> parseClassRefEntry currentContext config) |> Seq.concat |> Seq.toList
    let classDefs = classDefSources |> List.filter (fun def -> def.Kind = ClassKind.Class)
    let interfaceDefs = classDefSources |> List.filter (fun def -> def.Kind = ClassKind.Interface)
    let enumDefs = source |> parseEnumSectionDef currentContext
    let typedefs = source |> parseTypedefSectionDef currentContext
    let namespaceDef = {NamespaceDef.Id = id;
                        NamespaceDef.Name = name;
                        NamespaceDef.BriefDescription = briefDescription;
                        NamespaceDef.DetailedDescription = detailedDescription;
                        NamespaceDef.Enums = enumDefs;
                        NamespaceDef.Typedefs = typedefs;
                        NamespaceDef.Classes = classDefs;
                        NamespaceDef.Interfaces = interfaceDefs}
    context.CommonEntityRepo.Add(id, namespaceDef |> EntityDef.Namespace)
    namespaceDef

let parseNamespaceFile (config: Config.ConfigData) (context: Context) (refEntry: Refs.NamespaceRefEntry) =
    let document = Path.Combine(config.SourceDirectory, refEntry.RefId + ".xml") |> XDocument.Load
    document.Root.Elements("compounddef") |> Seq.exactlyOne |> parseNamespaceDef config context