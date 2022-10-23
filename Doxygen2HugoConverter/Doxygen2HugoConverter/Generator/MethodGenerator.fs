module MethodGenerator

open System.IO
open System.Text

let generateArgs (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (methodArgs: Markup.MethodArgs) (argsTypes: string list) (dest: StringBuilder) =
    if methodArgs.IsEmpty |> not then
        dest.AppendLine() |> ignore
        dest |> GeneratorCommon.generateTableHeader ["Parameter"; "Type"; "Description"]
        for methodArg, argType in Seq.zip methodArgs argsTypes do
            let methodArgDescription = methodArg.Description |> briefDescriptionGenerator
            sprintf $"| {methodArg.Name} | {argType} | {methodArgDescription} |" |> dest.AppendLine |> ignore

let generateReturnValue (briefDescriptionGenerator: Markup.SimpleMarkup -> string) (returnValue: Markup.SimpleMarkup) (dest: StringBuilder) =
    if returnValue.IsEmpty |> not then
        dest.AppendLine() |> ignore
        GeneratorCommon.generateHeader "ReturnValue" 3 |> dest.AppendLine |> ignore
        returnValue |> briefDescriptionGenerator |> dest.AppendLine |> ignore

let generateDefinition (methodDef: Defs.MethodDef) (dest: StringBuilder) =
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
    let createTypeRepresentation (sourceType: Markup.SimpleMarkup) =
        let mapFun = fun part -> match part with
                                 | Markup.SimpleMarkupDef.Text text -> text
                                 | Markup.SimpleMarkupDef.Ref data -> data.Text
                                 | _ -> failwith "Unsupported markup element for type"
        let typeRepresentation = sourceType |> Seq.map mapFun |> String.concat ""
        typeRepresentation.Replace("< ", "\\<").Replace(" >", "\\>").Replace(" &", "\\&")
    parameters |> Seq.map (fun parameter -> parameter.Type |> createTypeRepresentation) |> Seq.toList

let generateHeader (hasOverloads: bool) (argsTypes: string list) (methodDef: Defs.MethodDef) =
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

let generateForMethod (context: GeneratorCommon.Context) (isFirst: bool) (hasOverloads: bool) (methodDef: Defs.MethodDef) =
    let folderName = methodDef.Name |> Utils.createSimpleFolderName
    let methodDirectory = Path.Combine(context.Directory, folderName)
    methodDirectory |> Directory.CreateDirectory |> ignore
    let methodUrl = [|folderName|] |> Array.append context.Url
    let currentContext = {context with Directory = methodDirectory; Url = methodUrl; Weight = 1}
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity currentContext
    let briefDescriptionGenerator = MarkupGenerator.generateSimpleMarkup urlGenerator
    let builder = new StringBuilder()
    if isFirst then
        let descriptionForTitle = methodDef.BriefDescription |> MarkupGenerator.generateBriefDescriptionForTitle
        builder |> GeneratorCommon.generateDefPageHeader methodDef.Name descriptionForTitle methodUrl context.Weight
        context.Weight <- context.Weight + GeneratorCommon.WeightDelta
    let argsTypes = methodDef.Args |> createArgTypeList
    GeneratorCommon.generateHeader (methodDef |> generateHeader hasOverloads argsTypes) 2 |> builder.Append |> ignore
    let briefDescription = methodDef.BriefDescription |> briefDescriptionGenerator
    builder.AppendLine() |> ignore
    briefDescription |> builder.AppendLine |> ignore
    builder.AppendLine() |> ignore
    builder |> generateDefinition methodDef
    builder |> GeneratorCommon.generateTemplateParameters briefDescriptionGenerator methodDef.DetailedDescription.TemplateParameters
    builder |> generateArgs briefDescriptionGenerator methodDef.DetailedDescription.Args argsTypes
    builder |> generateReturnValue briefDescriptionGenerator methodDef.DetailedDescription.ReturnValue
    let detailedDescription = methodDef.DetailedDescription.Description |> MarkupGenerator.generateDetailedDescription (GeneratorUrl.generateRelativeUrlForEntity currentContext)
    detailedDescription |> builder.Append |> ignore
    File.AppendAllText(Path.Combine(methodDirectory, Common.MarkdownFilename), builder.ToString())

let generateForMethodGroup (context: GeneratorCommon.Context) (group: Defs.MethodGroupDef) =
    match group.Methods.Length with
    | 1 -> group.Methods.[0] |> generateForMethod context true false
    | _ ->
        group.Methods |> Seq.iteri (fun index method -> method |> generateForMethod context (index = 0) true)

let createEntry (context: GeneratorCommon.Context) (methodDef: Defs.MethodDef) =
    let urlGenerator = GeneratorUrl.generateRelativeUrlForEntity context
    match methodDef.Id |> urlGenerator with
    | Some relativeUrl ->
        let builder = new StringBuilder()
        if methodDef.IsVirtual && (methodDef.IsOverride |> not) then
            "virtual " |> builder.Append |> ignore
        if methodDef.IsExplicit then
            "explicit " |> builder.Append |> ignore
        if methodDef.IsStatic then
            "static " |> builder.Append |> ignore
        relativeUrl |> GeneratorCommon.generateLink methodDef.Name |> builder.Append |> ignore
        "(" |> builder.Append |> ignore
        methodDef.Args |> createArgTypeList |> String.concat ", " |> builder.Append |> ignore
        ")" |> builder.Append |> ignore
        if methodDef.IsConst then
            " const" |> builder.Append |> ignore
        if methodDef.IsOverride then
            " override" |> builder.Append |> ignore
        let briefDescription = methodDef.BriefDescription |> MarkupGenerator.generateSimpleMarkup urlGenerator
        {GeneratorCommon.GenerateEntry.Title = builder.ToString(); GeneratorCommon.GenerateEntry.BriefDescription = briefDescription}
    | None -> failwith "Unknown method ref"

let getMethodEntries (context: GeneratorCommon.Context) (memberRefs: Refs.MemberRef list) =
    let filterFun (memberRef: Refs.MemberRef) =
        match memberRef.RefId |> context.CommonEntityRepo.ContainsKey with
        | false -> None
        | true ->
            match context.CommonEntityRepo.[memberRef.RefId] with
            | Defs.EntityDef.Method methodDef -> methodDef |> createEntry context |> Some
            | _ -> None
    memberRefs |> Seq.choose filterFun |> Seq.toList
