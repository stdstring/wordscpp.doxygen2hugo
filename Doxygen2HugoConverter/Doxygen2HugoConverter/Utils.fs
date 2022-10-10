module Utils

open System.Xml.Linq

let getAttributeValue (source: XElement) (attributeName: string) = (source.Attributes(attributeName) |> Seq.exactlyOne).Value

let findAttributeValue (source: XElement) (attributeName: string) =
    match source.Attribute(attributeName) with
    | null -> None
    | attribute -> attribute.Value |> Some

let getElement (source: XElement) (elementName: string) = source.Elements(elementName) |> Seq.exactlyOne

let getElementValue (source: XElement) (elementName: string) = (elementName |> getElement source).Value

let findElementValue (source: XElement) (elementName: string) =
    match source.Element(elementName) with
    | null -> None
    | element -> element.Value |> Some

let getClassName (fullName: string) =
    match fullName.LastIndexOf(Common.NameDelimiter) with
    | -1 -> Common.NameDelimiter |> failwithf "Unprocessed class name \"%s\""
    | lastDelimiterPos -> fullName.Substring(lastDelimiterPos + Common.NameDelimiter.Length)

let createNamespaceFolderName (name: string) = name.ToLower().Replace("::", ".")

let createSimpleFolderName (name: string) = name.ToLower()
