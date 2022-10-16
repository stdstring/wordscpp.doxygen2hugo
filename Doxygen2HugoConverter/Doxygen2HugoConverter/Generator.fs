module Generator

open System.Collections.Generic
open System.IO
open System.Text
open GeneratorUtils
open MarkupGenerator

type KeyValueEntry = {Key: string; Value: string}

type GenerateEntry = {Title: string; BriefDescription: string}

type Context = {Directory: string; Url: string[]; CommonEntityRepo: IDictionary<string, Defs.EntityDef>}

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
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "0"};
     {KeyValueEntry.Key = "url"; KeyValueEntry.Value = url |> generateUrl false};
     {KeyValueEntry.Key = "keywords"; KeyValueEntry.Value = "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\""};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = "Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks."};
     {KeyValueEntry.Key = "is_root"; KeyValueEntry.Value = "true"}] |> generatePageHeader dest

let generateDefPageHeader (title: string) (description: string) (url: string[]) (dest: StringBuilder) =
    [{KeyValueEntry.Key = "title"; KeyValueEntry.Value = title};
     {KeyValueEntry.Key = "second_title"; KeyValueEntry.Value = "Aspose.Words for C++ API Reference"};
     {KeyValueEntry.Key = "description"; KeyValueEntry.Value = description};
     {KeyValueEntry.Key = "type"; KeyValueEntry.Value = "docs"};
     {KeyValueEntry.Key = "weight"; KeyValueEntry.Value = "0"};
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
    let currentContext = {context with Directory = enumDirectory; Url = enumUrl}
    let builder = new StringBuilder()
    let descriptionForTitle = enumDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader enumDef.Name descriptionForTitle enumUrl
    GenerateHeader (sprintf $"{enumDef.Name} enum") 2 |> builder.Append |> ignore
    let briefDescription = enumDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity currentContext)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    let detailedDescription = enumDef.DetailedDescription |> GenerateEnumDetailedDescription (generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> GenerateChildUrl |> GenerateLink enumDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForTypedef (context: Context) (typedefDef: Defs.TypedefDef) =
    let folderName = typedefDef.Name |> Utils.createSimpleFolderName
    let typedefDirectory = Path.Combine(context.Directory, folderName)
    typedefDirectory |> Directory.CreateDirectory |> ignore
    let typedefUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = typedefDirectory; Url = typedefUrl}
    let builder = new StringBuilder()
    let descriptionForTitle = typedefDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader typedefDef.Name descriptionForTitle typedefUrl
    GenerateHeader (sprintf $"{typedefDef.Name} typedef") 2 |> builder.Append |> ignore
    let briefDescription = typedefDef.BriefDescription |> GenerateBriefDescription (generateRelativeUrlForEntity currentContext)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(typedefDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> GenerateChildUrl |> GenerateLink typedefDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateTypeRepresentation (sourceType: Markup.SimpleMarkupDef list) =
    let mapFun = fun part -> match part with
                             | Markup.SimpleMarkupDef.Text text -> text
                             | Markup.SimpleMarkupDef.Ref data -> data.Text
                             | _ -> failwith "Unsupported markup element for type"
    let typeRepresentation = sourceType |> Seq.map mapFun |> String.concat ""
    typeRepresentation.Replace("< ", "\\<").Replace(" >", "\\>").Replace(" &", "\\&")

let createMethodEntry (context: Context) (relativeUrl: string) (methodDef: Defs.MethodDef) =
    let generateParameterList (dest: StringBuilder) (parameters: Defs.MethodParameterDef list) =
        parameters |> Seq.iteri (fun index parameter -> match index with
                                                        | 0 -> ()
                                                        | _ -> ", " |> dest.Append |> ignore
                                                        parameter.Type |> generateTypeRepresentation |> dest.Append |> ignore)
    let builder = new StringBuilder()
    if methodDef.IsVirtual && (methodDef.IsOverride |> not) then
        "virtual " |> builder.Append |> ignore
    if methodDef.IsExplicit then
        "explicit " |> builder.Append |> ignore
    if methodDef.IsStatic then
        "static " |> builder.Append |> ignore
    relativeUrl |> GenerateLink methodDef.Name |> builder.Append |> ignore
    "(" |> builder.Append |> ignore
    methodDef.Parameters |> generateParameterList builder
    ")" |> builder.Append |> ignore
    if methodDef.IsConst then
        " const" |> builder.Append |> ignore
    if methodDef.IsOverride then
        " override" |> builder.Append |> ignore
    let briefDescription = methodDef.BriefDescription |> GenerateBriefDescription  (generateRelativeUrlForEntity context)
    {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}

let createMemberEntry (context: Context) (memberRef: Refs.MemberRef) =
    match memberRef.RefId |> context.CommonEntityRepo.ContainsKey with
    | false -> None
    | true ->
        let entity = context.CommonEntityRepo[memberRef.RefId]
        match entity with
        | Defs.EntityDef.Method methodDef ->
            match generateRelativeUrlForEntity context methodDef.Id with
            | Some relativeUrl -> methodDef |> createMethodEntry context relativeUrl |> Some
            | _ -> failwith "Unknown method ref"
        | _ -> failwith "Unsupported member in class/interface"

let generateForDirectMethod (context: Context) (methodDef: Defs.MethodDef) =
    let folderName = methodDef.Name |> Utils.createSimpleFolderName
    let methodDirectory = Path.Combine(context.Directory, folderName)
    methodDirectory |> Directory.CreateDirectory |> ignore
    let methodUrl = [|folderName|] |> Array.append context.Url
    let builder = new StringBuilder()
    let descriptionForTitle = methodDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader methodDef.Name descriptionForTitle methodUrl
    GenerateHeader (sprintf $"{methodDef.ClassName}.{methodDef.Name} method") 2 |> builder.Append |> ignore
    let briefDescription = methodDef.BriefDescription |> GenerateBriefDescription  (generateRelativeUrlForEntity context)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(methodDirectory, Common.MarkdownFilename), builder.ToString())

let generateClassKind (classDef: Defs.ClassDef) =
    match classDef.Kind with
    | Defs.ClassKind.Class -> "class"
    | Defs.ClassKind.Interface -> "interface"

let generateForClass (context: Context) (classDef: Defs.ClassDef) =
    let folderName = classDef.Name |> Utils.createSimpleFolderName
    let classDirectory = Path.Combine(context.Directory, folderName)
    classDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = classDirectory; Url = classUrl}
    let builder = new StringBuilder()
    let descriptionForTitle = classDef.BriefDescription |> GenerateBriefDescriptionForTitle
    builder |> generateDefPageHeader classDef.Name descriptionForTitle classUrl
    GenerateHeader (sprintf $"{classDef.Name} {classDef |> generateClassKind}") 2 |> builder.Append |> ignore
    let briefDescription = classDef.BriefDescription |> GenerateBriefDescription  (generateRelativeUrlForEntity context)
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    classDef.DirectMethods |> Seq.iter (fun def -> def |> generateForDirectMethod currentContext)
    if classDef.MemberRefs.IsEmpty |> not then
        GenerateHeader "Methods" 2 |> builder.Append |> ignore
        builder |> generateTableHeader ["Method"; "Description"]
        classDef.MemberRefs
                |> Seq.choose (fun memberRef -> memberRef |> createMemberEntry currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
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
        let currentContext = {context with Directory = namespaceDirectory; Url = namespaceUrl}
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.BriefDescription |> GenerateBriefDescriptionForTitle
        builder |> generateDefPageHeader namespaceDef.Name descriptionForTitle namespaceUrl
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
    let context = {Context.Directory = rootDirectory; Context.Url = rootUrl; Context.CommonEntityRepo = repo}
    let builder = new StringBuilder()
    builder |> generateRootPageHeader rootUrl
    builder.AppendLine() |> ignore
    GenerateHeader "Namespaces" 2 |> builder.Append |> ignore
    builder |> generateTableHeader ["Namespace"; "Description"]
    namespaceDefs
        |> Seq.choose (fun def -> def |> generateForNamespace context)
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString())