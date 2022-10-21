﻿module Generator

open System.Collections.Generic
open System.IO
open System.Text
open GeneratorUtils
open MarkupGenerator

type KeyValueEntry = {Key: string; Value: string}

type GenerateEntry = {Title: string; BriefDescription: string}

[<Literal>]
let weightDelta = 13

type Context = {Directory: string;
                Url: string[];
                mutable Weight: int;
                CommonEntityRepo: IDictionary<string, Defs.EntityDef>}

let createUrlForEntity (context: Context) (entityId: string) =
    let rec collectDependencyChain (storage: ResizeArray<string>) (entity: Defs.EntityDef) =
        match entity with
        | Defs.EntityDef.Namespace def ->
            def.Name |> Utils.createNamespaceFolderName |> storage.Add
            storage
        | Defs.EntityDef.Class def ->
            def.Name |> Utils.createSimpleFolderName |> storage.Add
            context.CommonEntityRepo.[def.ParentId] |> collectDependencyChain storage
        | Defs.EntityDef.Interface def ->
            def.Name |> Utils.createSimpleFolderName |> storage.Add
            context.CommonEntityRepo.[def.ParentId] |> collectDependencyChain storage
        | Defs.EntityDef.Enum def ->
            def.Name |> Utils.createSimpleFolderName |> storage.Add
            context.CommonEntityRepo.[def.ParentId] |> collectDependencyChain storage
        | Defs.EntityDef.Typedef def ->
            def.Name |> Utils.createSimpleFolderName |> storage.Add
            context.CommonEntityRepo.[def.ParentId] |> collectDependencyChain storage
        | Defs.EntityDef.Method def ->
            def.Name |> Utils.createSimpleFolderName |> storage.Add
            context.CommonEntityRepo.[def.ParentId] |> collectDependencyChain storage
        | Defs.EntityDef.Field def ->
            def.Name |> Utils.createSimpleFolderName |> storage.Add
            context.CommonEntityRepo.[def.ParentId] |> collectDependencyChain storage
    let dest = context.CommonEntityRepo.[entityId] |> collectDependencyChain (new ResizeArray<string>())
    // TODO (std_string) : think about another approach
    Common.RootDirectory |> dest.Add
    dest |> Seq.rev |> Seq.toArray

let createRelativeUrl (sourceUrl: string[]) (destUrl: string[]) =
    let rec getCommonPrefixLength (source: string[]) (dest: string[]) (index: int) =
        match index with
        | _ when index = source.Length -> source.Length
        | _ when index = dest.Length -> dest.Length
        | _ when source[index] <> dest[index] -> index
        | _ -> (index + 1) |> getCommonPrefixLength source dest
    let storage = new ResizeArray<string>()
    let commonPrefixLength = 0 |> getCommonPrefixLength sourceUrl destUrl
    match commonPrefixLength with
    | _ when commonPrefixLength = sourceUrl.Length ->
        "." |> storage.Add
    | _ ->
        ".." |> Array.create (sourceUrl.Length - commonPrefixLength) |> storage.AddRange
    destUrl |> Seq.skip commonPrefixLength |> storage.AddRange
    storage |> Seq.toArray

let generateUrl (isRelative: bool) (url: string[]) =
    let result = url |> String.concat "/"
    match isRelative with
    | true -> sprintf $"{result}/"
    | false -> sprintf $"/{result}/"

let generateRelativeUrlForEntity (context: Context) (entityId: string) =
    match entityId |> context.CommonEntityRepo.ContainsKey with
    | false -> None
    | true ->
        let entityUrl = entityId |> createUrlForEntity context
        let relativeUrl = createRelativeUrl context.Url entityUrl
        relativeUrl |> generateUrl true |> Some

let generatePageHeader (dest: StringBuilder) (data: seq<KeyValueEntry>) =
    "---" |> dest.AppendLine |> ignore
    for entry in data do
        entry.Key |> dest.Append |> ignore
        ": " |> dest.Append |> ignore
        entry.Value |> dest.AppendLine |> ignore
    "---" |> dest.AppendLine |> ignore

let generateRootPageHeader (url: string[]) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = "Aspose.Words for C++"};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "666"};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url |> generateUrl false};
     {KeyValueEntry.Key = "keywords"; KeyValueEntry.Value = "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\""};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = "Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks."};
     {KeyValueEntry.Key = "is_root"; KeyValueEntry.Value = "true"}] |> generatePageHeader dest

let generateDefPageHeader (title: string) (description: string) (url: string[]) (weight: int) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = title};
     {KeyValueEntry.Key = "second_title"; KeyValueEntry.Value = "Aspose.Words for C++ API Reference"};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = description};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = weight |> string};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url |> generateUrl false}] |> generatePageHeader dest

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

let prepareDirectory (config: Config.ConfigData) =
    let rootDirectory = Path.Combine(config.DestDirectory, Common.RootDirectory)
    if rootDirectory |> Directory.Exists then
        Directory.Delete(rootDirectory, true)
    rootDirectory |> Directory.CreateDirectory |> ignore
    rootDirectory

let generateForEnum (context: Context) (enumDef: Defs.EnumDef) =
    let folderName = enumDef.Name |> Utils.createSimpleFolderName
    let enumDirectory = Path.Combine(context.Directory, folderName)
    enumDirectory |> Directory.CreateDirectory |> ignore
    let enumUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = enumDirectory; Url = enumUrl; Weight = 1}
    let builder = new StringBuilder()
    let descriptionForTitle = enumDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader enumDef.Name descriptionForTitle enumUrl context.Weight
    context.Weight <- context.Weight + weightDelta
    GenerateHeader (sprintf $"{enumDef.Name} enum") 2 |> builder.Append |> ignore
    let briefDescription = enumDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity currentContext)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    GenerateHeader "Values" 3 |> builder.Append |> ignore
    builder |> generateTableHeader ["Name"; "Value"; "Description"]
    for enumValueDef in enumDef.Values do
        let valueBriefDescription = enumValueDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity currentContext)
        let initializer = match enumValueDef.Initializer with
                          | None -> "n/a"
                          | Some value -> value |> string
        sprintf $"| {enumValueDef.Name} | {initializer} | {valueBriefDescription} |" |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    let detailedDescription = enumDef.DetailedDescription |> GenerateDetailedDescription (generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> GenerateChildUrl |> GenerateLink enumDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateTypedefDefinition (typedefDef: Defs.TypedefDef) (dest: StringBuilder) =
    match typedefDef.Definition |> System.String.IsNullOrEmpty with
    | true -> ()
    | false ->
        "```cpp" |> dest.AppendLine |> ignore
        typedefDef.Definition.Trim() |> dest.AppendLine |> ignore
        "```" |> dest.AppendLine |> ignore
        dest.AppendLine() |> ignore

let generateForTypedef (context: Context) (typedefDef: Defs.TypedefDef) =
    let folderName = typedefDef.Name |> Utils.createSimpleFolderName
    let typedefDirectory = Path.Combine(context.Directory, folderName)
    typedefDirectory |> Directory.CreateDirectory |> ignore
    let typedefUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = typedefDirectory; Url = typedefUrl; Weight = 1}
    let builder = new StringBuilder()
    let descriptionForTitle = typedefDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader typedefDef.Name descriptionForTitle typedefUrl context.Weight
    context.Weight <- context.Weight + weightDelta
    GenerateHeader (sprintf $"{typedefDef.Name} typedef") 2 |> builder.Append |> ignore
    let briefDescription = typedefDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity currentContext)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateTypedefDefinition typedefDef
    let detailedDescription = typedefDef.DetailedDescription |> GenerateDetailedDescription (generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(typedefDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> GenerateChildUrl |> GenerateLink typedefDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateTemplateParameters (context: Context) (templateParameters: Markup.TemplateParameter list) (dest: StringBuilder) =
    if templateParameters.IsEmpty |> not then
        dest.AppendLine() |> ignore
        dest |> generateTableHeader ["Parameter"; "Description"]
        for templateParameter in templateParameters do
            let parameterDescription = templateParameter.Description |> GenerateBriefDescription (generateRelativeUrlForEntity context)
            sprintf $"| {templateParameter.Name} | {parameterDescription} |" |> dest.AppendLine |> ignore

let generateMethodArgs (context: Context) (methodArgs: Markup.MethodArg list) (argsTypes: string list) (dest: StringBuilder) =
    if methodArgs.IsEmpty |> not then
        dest.AppendLine() |> ignore
        dest |> generateTableHeader ["Parameter"; "Type"; "Description"]
        for methodArg, argType in Seq.zip methodArgs argsTypes do
            let methodArgDescription = methodArg.Description |> GenerateBriefDescription (generateRelativeUrlForEntity context)
            sprintf $"| {methodArg.Name} | {argType} | {methodArgDescription} |" |> dest.AppendLine |> ignore

let generateReturnValue (context: Context) (returnValue: Markup.SimpleMarkup) (dest: StringBuilder) =
    if returnValue.IsEmpty |> not then
        dest.AppendLine() |> ignore
        GenerateHeader "ReturnValue" 3 |> dest.AppendLine |> ignore
        returnValue |> GenerateBriefDescription (generateRelativeUrlForEntity context) |> dest.AppendLine |> ignore

let generateMethodDefinition (methodDef: Defs.MethodDef) (dest: StringBuilder) =
    "```cpp" |> dest.AppendLine |> ignore
    if methodDef.TemplateParameters.IsEmpty |> not then
        "template<" |> dest.Append |> ignore
        methodDef.TemplateParameters |> String.concat "," |> dest.Append |> ignore
        "> " |> dest.Append |> ignore
    methodDef.Definition.Replace("< ", "<").Replace(" >", ">") |> dest.Append |> ignore
    methodDef.ArgString.Replace("< ", "<").Replace(" >", ">") |> dest.Append |> ignore
    dest.AppendLine() |> ignore
    "```" |> dest.AppendLine |> ignore
    dest.AppendLine() |> ignore

let createArgTypeList (parameters: Defs.MethodArgDef list) =
    let createTypeRepresentation (sourceType: Markup.SimpleMarkupDef list) =
        let mapFun = fun part -> match part with
                                 | Markup.SimpleMarkupDef.Text text -> text
                                 | Markup.SimpleMarkupDef.Ref data -> data.Text
                                 | _ -> failwith "Unsupported markup element for type"
        let typeRepresentation = sourceType |> Seq.map mapFun |> String.concat ""
        typeRepresentation.Replace("< ", "\\<").Replace(" >", "\\>").Replace(" &", "\\&")
    parameters |> Seq.map (fun parameter -> parameter.Type |> createTypeRepresentation) |> Seq.toList

let generateMethodHeader (hasOverloads: bool) (argsTypes: string list) (methodDef: Defs.MethodDef) =
    let result = new StringBuilder()
    sprintf $"{methodDef.ClassName}.{methodDef.Name}" |> result.Append |> ignore
    if hasOverloads then
        "(" |> result.Append |> ignore
        argsTypes |> String.concat ", " |> result.Append |> ignore
        ")" |> result.Append |> ignore
        if methodDef.IsConst then
            " const" |> result.Append |> ignore
    " method" |> result.Append |> ignore
    result.ToString()

let generateForDirectMethod (context: Context) (isFirst: bool) (hasOverloads: bool) (methodDef: Defs.MethodDef) =
    let folderName = methodDef.Name |> Utils.createSimpleFolderName
    let methodDirectory = Path.Combine(context.Directory, folderName)
    methodDirectory |> Directory.CreateDirectory |> ignore
    let methodUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = methodDirectory; Url = methodUrl; Weight = 1}
    let builder = new StringBuilder()
    if isFirst then
        let descriptionForTitle = methodDef.BriefDescription |> GenerateBriefDescriptionForTitle
        builder |> generateDefPageHeader methodDef.Name descriptionForTitle methodUrl context.Weight
        context.Weight <- context.Weight + weightDelta
    let argsTypes = methodDef.Args |> createArgTypeList
    GenerateHeader (methodDef |> generateMethodHeader hasOverloads argsTypes) 2 |> builder.Append |> ignore
    let briefDescription = methodDef.BriefDescription |> GenerateBriefDescription  (generateRelativeUrlForEntity currentContext)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateMethodDefinition methodDef
    builder |> generateTemplateParameters currentContext methodDef.DetailedDescription.TemplateParameters
    builder |> generateMethodArgs currentContext methodDef.DetailedDescription.Args argsTypes
    builder |> generateReturnValue currentContext methodDef.DetailedDescription.ReturnValue
    let detailedDescription = methodDef.DetailedDescription.Description |> GenerateDetailedDescription (generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(methodDirectory, Common.MarkdownFilename), builder.ToString())

let generateForDirectMethodGroup (context: Context) (group: Defs.MethodGroupDef) =
    match group.Methods.Length with
    | 1 -> group.Methods.[0] |> generateForDirectMethod context true false
    | _ ->
        group.Methods |> Seq.iteri (fun index method -> method |> generateForDirectMethod context (index = 0) true)

let getMemberMethods (context: Context) (memberRefs: Refs.MemberRef list) =
    let filterFun (memberRef: Refs.MemberRef) =
        match memberRef.RefId |> context.CommonEntityRepo.ContainsKey with
        | false -> None
        | true ->
            match context.CommonEntityRepo.[memberRef.RefId] with
            | Defs.EntityDef.Method methodDef -> methodDef |> Some
            | _ -> None
    memberRefs |> Seq.choose filterFun |> Seq.toList

let createMethodEntry (context: Context) (methodDef: Defs.MethodDef) =
    match generateRelativeUrlForEntity context methodDef.Id with
    | Some relativeUrl ->
        let builder = new StringBuilder()
        if methodDef.IsVirtual && (methodDef.IsOverride |> not) then
            "virtual " |> builder.Append |> ignore
        if methodDef.IsExplicit then
            "explicit " |> builder.Append |> ignore
        if methodDef.IsStatic then
            "static " |> builder.Append |> ignore
        relativeUrl |> GenerateLink methodDef.Name |> builder.Append |> ignore
        "(" |> builder.Append |> ignore
        methodDef.Args |> createArgTypeList |> String.concat ", " |> builder.Append |> ignore
        ")" |> builder.Append |> ignore
        if methodDef.IsConst then
            " const" |> builder.Append |> ignore
        if methodDef.IsOverride then
            " override" |> builder.Append |> ignore
        let briefDescription = methodDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity context)
        {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}
    | None -> failwith "Unknown method ref"

let generateFieldDefinition (fieldDef: Defs.FieldDef) (dest: StringBuilder) =
    "```cpp" |> dest.AppendLine |> ignore
    if fieldDef.IsStatic |> not then
        "static " |> dest.Append |> ignore
    fieldDef.Definition.Replace("< ", "<").Replace(" >", ">") |> dest.Append |> ignore
    dest.AppendLine() |> ignore
    "```" |> dest.AppendLine |> ignore
    dest.AppendLine() |> ignore

let generateForDirectField (context: Context) (fieldDef: Defs.FieldDef) =
    let folderName = fieldDef.Name |> Utils.createSimpleFolderName
    let fieldDirectory = Path.Combine(context.Directory, folderName)
    fieldDirectory |> Directory.CreateDirectory |> ignore
    let fieldUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = fieldDirectory; Url = fieldUrl; Weight = 1}
    let builder = new StringBuilder()
    let descriptionForTitle = fieldDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader fieldDef.Name descriptionForTitle fieldUrl context.Weight
    context.Weight <- context.Weight + weightDelta
    GenerateHeader (sprintf $"{fieldDef.Name} field") 2 |> builder.Append |> ignore
    let briefDescription = fieldDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity context)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateFieldDefinition fieldDef
    let detailedDescription = fieldDef.DetailedDescription |> GenerateDetailedDescription (generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(fieldDirectory, Common.MarkdownFilename), builder.ToString())

let getMemberFields (context: Context) (memberRefs: Refs.MemberRef list) =
    let filterFun (memberRef: Refs.MemberRef) =
        match memberRef.RefId |> context.CommonEntityRepo.ContainsKey with
        | false -> None
        | true ->
            match context.CommonEntityRepo.[memberRef.RefId] with
            | Defs.EntityDef.Field fieldDef -> fieldDef |> Some
            | _ -> None
    memberRefs |> Seq.choose filterFun |> Seq.toList

let createFieldEntry (context: Context) (fieldDef: Defs.FieldDef) =
    match generateRelativeUrlForEntity context fieldDef.Id with
    | Some relativeUrl ->
        let builder = new StringBuilder()
        if fieldDef.IsStatic then
            "static " |> builder.Append |> ignore
        if fieldDef.IsConstexpr then
            "constexpr " |> builder.Append |> ignore
        if fieldDef.IsMutable then
            "mutable " |> builder.Append |> ignore
        relativeUrl |> GenerateLink fieldDef.Name |> builder.Append |> ignore
        let briefDescription = fieldDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity context)
        {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}
    | None -> failwith "Unknown method ref"

let generateClassKind (classDef: Defs.ClassDef) =
    match classDef.Kind with
    | Defs.ClassKind.Class -> "class"
    | Defs.ClassKind.Interface -> "interface"

let generateBaseClass (baseClassDef: Defs.BaseClassDef) =
    let result = new StringBuilder()
    baseClassDef.Access |> result.Append |> ignore
    " "|> result.Append |> ignore
    if baseClassDef.Virtual then
        "virtual "|> result.Append |> ignore
    baseClassDef.QualifiedName.Replace("< ", "<").Replace(" >", ">") |> result.Append |> ignore
    result.ToString()

let generateClassDefinition (classDef: Defs.ClassDef) (dest: StringBuilder) =
    "```cpp" |> dest.AppendLine |> ignore
    if classDef.TemplateParameters.IsEmpty |> not then
        "template<" |> dest.Append |> ignore
        classDef.TemplateParameters |> String.concat "," |> dest.Append |> ignore
        "> " |> dest.Append |> ignore
    "class " |> dest.Append |> ignore
    classDef.Name |> dest.Append |> ignore
    if classDef.BaseClasses.IsEmpty |> not then
        " : " |> dest.Append |> ignore
        classDef.BaseClasses |> Seq.map generateBaseClass |> String.concat ", " |> dest.Append |> ignore
    dest.AppendLine() |> ignore
    "```" |> dest.AppendLine |> ignore
    dest.AppendLine() |> ignore

let generateForClass (context: Context) (classDef: Defs.ClassDef) =
    let folderName = classDef.Name |> Utils.createSimpleFolderName
    let classDirectory = Path.Combine(context.Directory, folderName)
    classDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = classDirectory; Url = classUrl; Weight = 1}
    let builder = new StringBuilder()
    let descriptionForTitle = classDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader classDef.Name descriptionForTitle classUrl context.Weight
    context.Weight <- context.Weight + weightDelta
    GenerateHeader (sprintf $"{classDef.Name} {classDef |> generateClassKind}") 2 |> builder.Append |> ignore
    let briefDescription = classDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity context)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateClassDefinition classDef
    builder |> generateTemplateParameters context classDef.DetailedDescription.TemplateParameters
    classDef.DirectMethods |> Seq.iter (fun group -> group |> generateForDirectMethodGroup currentContext)
    classDef.Fields |> Seq.iter (fun field -> field |> generateForDirectField currentContext)
    let classMethods = classDef.MemberRefs |> getMemberMethods context
    if classMethods.IsEmpty |> not then
        GenerateHeader "Methods" 2 |> builder.Append |> ignore
        builder |> generateTableHeader ["Method"; "Description"]
        classMethods
            |> Seq.map (fun methodDef -> methodDef |> createMethodEntry currentContext)
            |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    let classFields = classDef.MemberRefs |> getMemberFields context
    if classFields.IsEmpty |> not then
        GenerateHeader "Fields" 2 |> builder.Append |> ignore
        builder |> generateTableHeader ["Field"; "Description"]
        classFields
            |> Seq.map (fun fieldDef -> fieldDef |> createFieldEntry currentContext)
            |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    let detailedDescription = classDef.DetailedDescription.Description |> GenerateDetailedDescription (generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(classDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> GenerateChildUrl |> GenerateLink classDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForNamespace (context: Context) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> None
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
        let namespaceDirectory = Path.Combine(context.Directory, folderName)
        namespaceDirectory |> Directory.CreateDirectory |> ignore
        let namespaceUrl = [|folderName|] |> Array.append context.Url
        let currentContext = {context with Directory = namespaceDirectory; Url = namespaceUrl; Weight = 1}
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.BriefDescription |> GenerateBriefDescriptionForTitle
        builder |> generateDefPageHeader namespaceDef.Name descriptionForTitle namespaceUrl context.Weight
        context.Weight <- context.Weight + weightDelta
        let briefDescription = namespaceDef.BriefDescription |> GenerateBriefDescription  (generateRelativeUrlForEntity context)
        builder.AppendLine() |> ignore
        briefDescription |> builder.AppendLine |> ignore
        builder.AppendLine() |> ignore
        if namespaceDef.Classes.IsEmpty |> not then
            GenerateHeader "Classes" 2 |> builder.Append |> ignore
            builder |> generateTableHeader ["Class"; "Description"]
            namespaceDef.Classes
                |> Seq.map (fun def -> def |> generateForClass currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Interfaces.IsEmpty |> not then
            GenerateHeader "Interfaces" 2 |> builder.Append |> ignore
            builder |> generateTableHeader ["Interface"; "Description"]
            namespaceDef.Interfaces
                |> Seq.map (fun def -> def |> generateForClass currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Enums.IsEmpty |> not then
            GenerateHeader "Enums" 2 |> builder.Append |> ignore
            builder |> generateTableHeader ["Enum"; "Description"]
            namespaceDef.Enums
                |> Seq.map (fun def -> def |> generateForEnum currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Typedefs.IsEmpty |> not then
            GenerateHeader "Typedefs" 2 |> builder.Append |> ignore
            builder |> generateTableHeader ["Typedef"; "Description"]
            namespaceDef.Typedefs
                |> Seq.map (fun def -> def |> generateForTypedef currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString())
        {GenerateEntry.Title = folderName |> GenerateChildUrl |> GenerateLink namespaceDef.Name;
         GenerateEntry.BriefDescription = briefDescription} |> Some

let generateDest (config: Config.ConfigData) (repo: IDictionary<string, Defs.EntityDef>) (namespaceDefs: Defs.NamespaceDef list) =
    let rootDirectory = config |> prepareDirectory
    let rootUrl = [|Common.RootDirectory|]
    let context = {Context.Directory = rootDirectory; Context.Url = rootUrl; Context.CommonEntityRepo = repo; Context.Weight = 1}
    let builder = new StringBuilder()
    builder |> generateRootPageHeader rootUrl
    builder.AppendLine() |> ignore
    GenerateHeader "Namespaces" 2 |> builder.Append |> ignore
    builder |> generateTableHeader ["Namespace"; "Description"]
    namespaceDefs
        |> Seq.choose (fun def -> def |> generateForNamespace context)
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString())