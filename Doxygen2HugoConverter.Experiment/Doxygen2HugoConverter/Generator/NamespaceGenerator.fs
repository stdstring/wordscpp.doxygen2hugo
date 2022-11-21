module NamespaceGenerator

open System.IO
open System.Text

let kindHeaderPlurals = Map [("Class", "Classes"); ("Interface", "Interfaces")]

let processEnums (context: GeneratorCommon.Context) (enumDefs: Defs.EnumDef list) (dest: StringBuilder) =
    match enumDefs.IsEmpty with
    | true -> ()
    | false ->
        GeneratorCommon.generateHeader "Enums" 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Enum"; "Description"]
        enumDefs |> Seq.iter (fun enumDef -> enumDef |> EnumGenerator.generate context)
        enumDefs
            |> EnumGenerator.createEnumEntries context
            |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let processTypedefs (context: GeneratorCommon.Context) (typedefDefs: Defs.TypedefDef list) (dest: StringBuilder) =
    match typedefDefs.IsEmpty with
    | true -> ()
    | false ->
        GeneratorCommon.generateHeader "Typedefs" 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Typedef"; "Description"]
        typedefDefs |> Seq.iter (fun typedefDef -> typedefDef |> TypedefGenerator.generate context)
        typedefDefs
            |> TypedefGenerator.createTypedefEntries context
            |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let processClassType (context: GeneratorCommon.Context) (classDefs: Defs.ClassDef list) (kindHeader: string) (dest: StringBuilder) =
    match classDefs.IsEmpty with
    | true -> ()
    | false ->
        GeneratorCommon.generateHeader (kindHeaderPlurals |> Map.find kindHeader) 2 |> dest.Append |> ignore
        dest |> GeneratorCommon.generateTableHeader [kindHeader; "Description"]
        classDefs |> Seq.iter (fun typedefDef -> typedefDef |> ClassGenerator.generate context)
        classDefs
            |> ClassGenerator.createClassEntries context
            |> Seq.iter (fun entry -> sprintf $"| {entry.Title} | {entry.BriefDescription} |" |> dest.AppendLine |> ignore)

let generate (context: GeneratorCommon.Context) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> ()
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
        let namespaceDirectory = Path.Combine(context.Directory, folderName)
        namespaceDirectory |> Directory.CreateDirectory |> ignore
        let namespaceUrl = [|folderName|] |> Array.append context.Url
        let currentContext = {context with Directory = namespaceDirectory; Url = namespaceUrl; Weight = 1}
        let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
        let briefDescriptionGenerator = MarkupGenerator.generateSimpleMarkup urlGenerator
        let builder = new StringBuilder()
        let descriptionForTitle = namespaceDef.BriefDescription |> MarkupGenerator.generateBriefDescriptionForTitle
        builder |> GeneratorCommon.generateDefPageHeader namespaceDef.Name descriptionForTitle namespaceUrl context.Weight
        context.Weight <- context.Weight + GeneratorCommon.WeightDelta
        let briefDescription = namespaceDef.BriefDescription |> briefDescriptionGenerator
        builder.AppendLine() |> ignore
        briefDescription |> builder.AppendLine |> ignore
        builder.AppendLine() |> ignore
        builder |> processClassType currentContext namespaceDef.Classes "Class"
        builder |> processClassType currentContext namespaceDef.Interfaces "Interface"
        builder |> processEnums currentContext namespaceDef.Enums
        builder |> processTypedefs currentContext namespaceDef.Typedefs
        File.AppendAllText(Path.Combine(namespaceDirectory, Common.MarkdownFilename), builder.ToString())

let createEntry (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (namespaceDef: Defs.NamespaceDef) =
    match namespaceDef.Enums.IsEmpty && namespaceDef.Typedefs.IsEmpty && namespaceDef.Classes.IsEmpty && namespaceDef.Interfaces.IsEmpty with
    | true -> None
    | false ->
        let folderName = namespaceDef.Name |> Utils.createNamespaceFolderName
        let briefDescription = namespaceDef.BriefDescription |> briefDescriptionGenerator
        {GeneratorCommon.GenerateEntry.Title = folderName |> GeneratorCommon.generateChildUrl |> GeneratorCommon.generateLink namespaceDef.Name;
         GeneratorCommon.GenerateEntry.BriefDescription = briefDescription} |> Some

let createNamespaceEntries (context: GeneratorCommon.Context) (namespaceDefs: Defs.NamespaceDef list) =
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity context
    let briefDescriptionGenerator = MarkupGenerator.generateSimpleMarkup urlGenerator
    namespaceDefs |> Seq.choose (fun namespaceDef -> namespaceDef |> createEntry briefDescriptionGenerator) |> Seq.toList