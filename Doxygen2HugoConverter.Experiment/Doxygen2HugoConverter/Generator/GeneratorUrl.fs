module GeneratorUrl

let createUrlForEntity (context: GeneratorCommon.Context) (entityId: string) =
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

let generateRelativeUrlForEntity (context: GeneratorCommon.Context) (entityId: string) =
    match entityId |> context.CommonEntityRepo.ContainsKey with
    | false -> None
    | true ->
        let entityUrl = entityId |> createUrlForEntity context
        let relativeUrl = createRelativeUrl context.Url entityUrl
        relativeUrl |> GeneratorCommon.generateUrl true |> Some