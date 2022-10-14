module Generator

open System.Collections.Generic
open System.IO
open System.Text

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

let generateChildUrl (folderName: string) = sprintf $"./{folderName}/"

let generateRelativeUrlForEntity (context: Context) (entityId: string) =
    let entityUrl = entityId |> createUrlForEntity context
    let relativeUrl = createRelativeUrl context.Url entityUrl
    relativeUrl |> generateUrl true

let generateLink (name: string) (url: string) = $"[{name}]({url})"

let generateBriefDescriptionForTitle (description: Defs.Description) =
    let result = new StringBuilder()
    for markupEntry in description.Brief do
        match markupEntry with
        | Defs.MarkupDef.Text text -> text |> result.Append |> ignore
        | Defs.MarkupDef.Ref data -> data.Text |> result.Append |> ignore
        | _ -> ()
    result.ToString()

let generateBriefDescription (description: Defs.Description) =
    let result = new StringBuilder()
    for markupEntry in description.Brief do
        match markupEntry with
        | Defs.MarkupDef.Text text -> text |> result.Append |> ignore
        // TODO (std_string) : fix ref generation
        | Defs.MarkupDef.Ref data -> data.Text |> result.Append |> ignore
        //| MarkupDef.ParagraphStart -> result.AppendLine() |> ignore
        //| MarkupDef.ParagraphEnd -> result.AppendLine() |> ignore
        | Defs.MarkupDef.ParagraphStart -> ()
        | Defs.MarkupDef.ParagraphEnd -> ()
        | Defs.MarkupDef.BoldStart -> "**" |> result.Append |> ignore
        | Defs.MarkupDef.BoldEnd -> "**" |> result.Append |> ignore
    result.ToString()

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
    let builder = new StringBuilder()
    let descriptionForTitle = enumDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader enumDef.Name descriptionForTitle enumUrl
    builder |> generateHeader (sprintf $"{enumDef.Name} enum") 2
    let briefDescription = enumDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> generateChildUrl |> generateLink enumDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForTypedef (context: Context) (typedefDef: Defs.TypedefDef) =
    let folderName = typedefDef.Name |> Utils.createSimpleFolderName
    let typedefDirectory = Path.Combine(context.Directory, folderName)
    typedefDirectory |> Directory.CreateDirectory |> ignore
    let typedefUrl = [|folderName|] |> Array.append context.Url
    let builder = new StringBuilder()
    let descriptionForTitle = typedefDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader typedefDef.Name descriptionForTitle typedefUrl
    builder |> generateHeader (sprintf $"{typedefDef.Name} typedef") 2
    let briefDescription = typedefDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(typedefDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> generateChildUrl |> generateLink typedefDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateTypeRepresentation (sourceType: Defs.TextWithRefs list) =
    let mapFun = fun part -> match part with
                             | Defs.TextWithRefs.Text text -> text
                             | Defs.TextWithRefs.Ref data -> data.Text
    let typeRepresentation = sourceType |> Seq.map mapFun |> String.concat ""
    typeRepresentation.Replace("< ", "\\<").Replace(" >", "\\>").Replace(" &", "\\&")

(*let createMethodEntry (folderName: string) (briefDescription: string) (methodDef: Defs.MethodDef) =
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
    //let returnTypeRepresentation = methodDef.ReturnType |> generateTypeRepresentation
    //sprintf $"{returnTypeRepresentation} " |> builder.Append |> ignore
    folderName |> generateChildUrl |> generateLink methodDef.Name |> builder.Append |> ignore
    "(" |> builder.Append |> ignore
    methodDef.Parameters |> generateParameterList builder
    ")" |> builder.Append |> ignore
    if methodDef.IsConst then
        " const" |> builder.Append |> ignore
    if methodDef.IsOverride then
        " override" |> builder.Append |> ignore
    {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}*)

let createMethodEntry (relativeUrl: string) (methodDef: Defs.MethodDef) =
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
    relativeUrl |> generateLink methodDef.Name |> builder.Append |> ignore
    "(" |> builder.Append |> ignore
    methodDef.Parameters |> generateParameterList builder
    ")" |> builder.Append |> ignore
    if methodDef.IsConst then
        " const" |> builder.Append |> ignore
    if methodDef.IsOverride then
        " override" |> builder.Append |> ignore
    let briefDescription = methodDef.Description |> generateBriefDescription
    {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}

let createMemberEntry (context: Context) (memberRef: Refs.MemberRef) =
    match memberRef.RefId |> context.CommonEntityRepo.ContainsKey with
    | false -> None
    | true ->
        let entity = context.CommonEntityRepo[memberRef.RefId]
        match entity with
        | Defs.EntityDef.Method methodDef ->
            //let folderName = memberRef.Name |> Utils.createSimpleFolderName
            //let methodUrl = [|folderName|] |> Array.append context.Url
            //let currentContext = {context with Directory = ""; Url = methodUrl}
            //let relativeUrl = generateRelativeUrlForEntity currentContext methodDef.Id
            let relativeUrl = generateRelativeUrlForEntity context methodDef.Id
            methodDef |> createMethodEntry relativeUrl |> Some
        | _ -> failwith "Unsupported member in class/interface"

let generateForDirectMethod (context: Context) (methodDef: Defs.MethodDef) =
    let folderName = methodDef.Name |> Utils.createSimpleFolderName
    let methodDirectory = Path.Combine(context.Directory, folderName)
    methodDirectory |> Directory.CreateDirectory |> ignore
    let methodUrl = [|folderName|] |> Array.append context.Url
    let builder = new StringBuilder()
    let descriptionForTitle = methodDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader methodDef.Name descriptionForTitle methodUrl
    builder |> generateHeader (sprintf $"{methodDef.ClassName}.{methodDef.Name} method") 2
    let briefDescription = methodDef.Description |> generateBriefDescription
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
    let descriptionForTitle = classDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader classDef.Name descriptionForTitle classUrl
    builder |> generateHeader (sprintf $"{classDef.Name} {classDef |> generateClassKind}") 2
    let briefDescription = classDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    classDef.DirectMethods |> Seq.iter (fun def -> def |> generateForDirectMethod currentContext)
    if classDef.MemberRefs.IsEmpty |> not then
        builder |> generateHeader "Methods" 2
        builder |> generateTableHeader ["Method"; "Description"]
        classDef.MemberRefs
                |> Seq.choose (fun memberRef -> memberRef |> createMemberEntry currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(classDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = folderName |> generateChildUrl |> generateLink classDef.Name;
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
                |> Seq.map (fun def -> def |> generateForClass currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Interfaces.IsEmpty |> not then
            builder |> generateHeader "Interfaces" 2
            builder |> generateTableHeader ["Interface"; "Description"]
            namespaceDef.Interfaces
                |> Seq.map (fun def -> def |> generateForClass currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Enums.IsEmpty |> not then
            builder |> generateHeader "Enums" 2
            builder |> generateTableHeader ["Enum"; "Description"]
            namespaceDef.Enums
                |> Seq.map (fun def -> def |> generateForEnum currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        if namespaceDef.Typedefs.IsEmpty |> not then
            builder |> generateHeader "Typedefs" 2
            builder |> generateTableHeader ["Typedef"; "Description"]
            namespaceDef.Typedefs
                |> Seq.map (fun def -> def |> generateForTypedef currentContext)
                |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
        File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString())
        {GenerateEntry.Title = folderName |> generateChildUrl |> generateLink namespaceDef.Name;
         GenerateEntry.BriefDescription = briefDescription} |> Some

let generateDest (config: Config.ConfigData) (repo: IDictionary<string, Defs.EntityDef>) (namespaceDefs: Defs.NamespaceDef list) =
    let rootDirectory = config |> prepareDirectory
    let rootUrl = [|Common.RootDirectory|]
    let context = {Context.Directory = rootDirectory; Context.Url = rootUrl; Context.CommonEntityRepo = repo}
    let builder = new StringBuilder()
    builder |> generateRootPageHeader rootUrl
    builder.AppendLine() |> ignore
    builder |> generateHeader "Namespaces" 2
    builder |> generateTableHeader ["Namespace"; "Description"]
    namespaceDefs
        |> Seq.choose (fun def -> def |> generateForNamespace context)
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString())