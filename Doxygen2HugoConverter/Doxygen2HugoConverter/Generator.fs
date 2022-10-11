module Generator

open System.IO
open System.Text

type KeyValueEntry = {Key: string; Value: string}

type GenerateEntry = {Title: string; BriefDescription: string}

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

let prepareDirectory (config: Config.ConfigData) =
    let rootDirectory = Path.Combine(config.DestDirectory, Common.RootDirectory)
    if rootDirectory |> Directory.Exists then
        Directory.Delete(rootDirectory, true)
    rootDirectory |> Directory.CreateDirectory |> ignore
    rootDirectory

let generateForEnum (parentDirectory: string) (parentUrl: string) (enumDef: Defs.EnumDef) =
    let folderName = enumDef.Name |> Utils.createSimpleFolderName
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
    File.AppendAllText(Path.Combine(enumDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink enumDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForTypedef (parentDirectory: string) (parentUrl: string) (typedefDef: Defs.TypedefDef) =
    let folderName = typedefDef.Name |> Utils.createSimpleFolderName
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
    File.AppendAllText(Path.Combine(typedefDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink typedefDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateTypeRepresentation (sourceType: Defs.TextWithRefs list) =
    let mapFun = fun part -> match part with
                             | Defs.TextWithRefs.Text text -> text
                             | Defs.TextWithRefs.Ref data -> data.Text
    let typeRepresentation = sourceType |> Seq.map mapFun |> String.concat ""
    typeRepresentation

let createMethodEntry (folderName: string) (briefDescription: string) (methodDef: Defs.MethodDef) =
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
    sprintf $"./{folderName}/" |> generateLink methodDef.Name |> builder.Append |> ignore
    "(" |> builder.Append |> ignore
    methodDef.Parameters |> generateParameterList builder
    ")" |> builder.Append |> ignore
    if methodDef.IsConst then
        " const" |> builder.Append |> ignore
    if methodDef.IsOverride then
        " override" |> builder.Append |> ignore
    {GenerateEntry.Title = builder.ToString(); GenerateEntry.BriefDescription = briefDescription}

let generateForDirectMethod (parentDirectory: string) (parentUrl: string) (methodDef: Defs.MethodDef) =
    let folderName = methodDef.Name |> Utils.createSimpleFolderName
    let methodDirectory = Path.Combine(parentDirectory, folderName)
    methodDirectory |> Directory.CreateDirectory |> ignore
    let methodUrl = sprintf $"{parentUrl}{folderName}/"
    let builder = new StringBuilder()
    let descriptionForTitle = methodDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader methodDef.Name descriptionForTitle methodUrl
    builder |> generateHeader (sprintf $"{methodDef.ClassName}.{methodDef.Name} method") 2
    let briefDescription = methodDef.Description |> generateBriefDescription
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    File.AppendAllText(Path.Combine(methodDirectory, Common.MarkdownFilename), builder.ToString())
    methodDef |> createMethodEntry folderName briefDescription

let generateForClass (parentDirectory: string) (parentUrl: string) (classDef: Defs.ClassDef) =
    let folderName = classDef.Name |> Utils.createSimpleFolderName
    let classDirectory = Path.Combine(parentDirectory, folderName)
    classDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = sprintf $"{parentUrl}{folderName}/"
    let builder = new StringBuilder()
    let descriptionForTitle = classDef.Description |> generateBriefDescriptionForTitle
    builder |> generateDefPageHeader classDef.Name descriptionForTitle classUrl
    builder |> generateHeader (sprintf $"{classDef.Name} class") 2
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
    File.AppendAllText(Path.Combine(classDirectory, Common.MarkdownFilename), builder.ToString())
    {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink classDef.Name;
     GenerateEntry.BriefDescription = briefDescription}

let generateForNamespace (parentDirectory: string) (parentUrl: string) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> None
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
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
        File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString())
        {GenerateEntry.Title = sprintf $"./{folderName}/" |> generateLink namespaceDef.Name;
         GenerateEntry.BriefDescription = briefDescription} |> Some

let generateDest (config: Config.ConfigData) (namespaceDefs: Defs.NamespaceDef list) =
    let rootDirectory = config |> prepareDirectory
    let rootUrl = sprintf $"/{Common.RootDirectory}/"
    let builder = new StringBuilder()
    builder |> generateRootPageHeader rootUrl
    builder.AppendLine() |> ignore
    builder |> generateHeader "Namespaces" 2
    builder |> generateTableHeader ["Namespace"; "Description"]
    namespaceDefs
        |> Seq.choose (fun def -> def |> generateForNamespace rootDirectory rootUrl)
        |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> builder.AppendLine |> ignore)
    File.AppendAllText(Path.Combine(rootDirectory, Common.MarkdownFilename), builder.ToString())