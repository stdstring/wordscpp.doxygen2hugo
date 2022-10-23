module ClassGenerator

open System.IO
open System.Text

let processFields (context: GeneratorCommon.Context) (classDef: Defs.ClassDef) (dest: StringBuilder) =
    classDef.Fields |> Seq.iter (fun fieldDef -> fieldDef |> FieldGenerator.generate context)
    match classDef.MemberRefs |> FieldGenerator.getFieldEntries context with
    | [] -> ()
    |fieldEntries ->
        GeneratorCommon.generateHeader "Fields" 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Field"; "Description"]
        fieldEntries |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let processMethods (context: GeneratorCommon.Context) (classDef: Defs.ClassDef) (dest: StringBuilder) =
    classDef.DirectMethods |> Seq.iter (fun group -> group |> MethodGenerator.generateForMethodGroup context)
    match classDef.MemberRefs |> MethodGenerator.getMethodEntries context with
    | [] -> ()
    | methodEntries ->
        GeneratorCommon.generateHeader "Methods" 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Method"; "Description"]
        methodEntries |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let processTypedefs (context: GeneratorCommon.Context) (classDef: Defs.ClassDef) (dest: StringBuilder) =
    classDef.Typedefs |> Seq.iter (fun field -> field |> TypedefGenerator.generate context |> ignore)
    match classDef.Typedefs |> TypedefGenerator.createTypedefEntries context with
    | [] -> ()
    | typedefEntries ->
        GeneratorCommon.generateHeader "Typedefs" 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Typedef"; "Description"]
        typedefEntries |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let generateKind (classDef: Defs.ClassDef) =
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

let generateDefinition (classDef: Defs.ClassDef) (dest: StringBuilder) =
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

let generate (context: GeneratorCommon.Context) (classDef: Defs.ClassDef) =
    let folderName = classDef.Name |> Utils.createSimpleFolderName
    let classDirectory = Path.Combine(context.Directory, folderName)
    classDirectory |> Directory.CreateDirectory |> ignore
    let classUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = classDirectory; Url = classUrl; Weight = 1}
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
    let briefDescriptionGenerator = MarkupGenerator.GenerateBriefDescription urlGenerator
    let builder = new StringBuilder()
    let descriptionForTitle = classDef.BriefDescription |> MarkupGenerator.GenerateBriefDescriptionForTitle
    builder |> GeneratorCommon.generateDefPageHeader classDef.Name descriptionForTitle classUrl context.Weight
    context.Weight <- context.Weight + GeneratorCommon.WeightDelta
    GeneratorCommon.generateHeader (sprintf $"{classDef.Name} {classDef |> generateKind}") 2 |> builder.Append |> ignore
    let briefDescription = classDef.BriefDescription |> briefDescriptionGenerator
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateDefinition classDef
    builder |> GeneratorCommon.generateTemplateParameters briefDescriptionGenerator classDef.DetailedDescription.TemplateParameters
    builder |> processMethods currentContext classDef
    builder |> processFields currentContext classDef
    builder |> processTypedefs currentContext classDef
    let detailedDescription = classDef.DetailedDescription.Description |> MarkupGenerator.GenerateDetailedDescription urlGenerator
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(classDirectory, Common.MarkdownFilename), builder.ToString())

let createEntry (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (classDef: Defs.ClassDef) =
    let folderName = classDef.Name |> Utils.createSimpleFolderName
    let briefDescription = classDef.BriefDescription |> briefDescriptionGenerator
    {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink classDef.Name;
     GeneratorCommon.GenerateEntry.BriefDescription = briefDescription}

let createClassEntries (context: GeneratorCommon.Context) (classDefs: Defs.ClassDef list) =
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity context
    let briefDescriptionGenerator = MarkupGenerator.GenerateBriefDescription urlGenerator
    classDefs |> Seq.map (fun classDef -> classDef |> createEntry briefDescriptionGenerator) |> Seq.toList