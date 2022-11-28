---
title: CustomDocumentProperties
second_title: Aspose.Words for C++ API Reference
description: A collection of custom document properties.
type: docs
weight: 14
url: /cpp/aspose.words.properties/customdocumentproperties/
---
## CustomDocumentProperties class


A collection of custom document properties.

```cpp
class CustomDocumentProperties : public Aspose::Words::Properties::DocumentPropertyCollection
```

## Methods

| Method | Description |
| --- | --- |
| [Add](./add/)(const System::String\&, const System::String\&) | Creates a new custom document property of the **PropertyType.String** data type. |
| [Add](./add/)(const System::String\&, int32_t) | Creates a new custom document property of the **PropertyType.Number** data type. |
| [Add](./add/)(const System::String\&, System::DateTime) | Creates a new custom document property of the **PropertyType.DateTime** data type. |
| [Add](./add/)(const System::String\&, bool) | Creates a new custom document property of the **PropertyType.Boolean** data type. |
| [Add](./add/)(const System::String\&, double) | Creates a new custom document property of the **PropertyType.Float** data type. |
| [AddLinkToContent](./addlinktocontent/)(const System::String\&, const System::String\&) | Creates a new linked to content custom document property. |
| [Clear](../documentpropertycollection/clear/)() | Removes all properties from the collection. |
| [Contains](../documentpropertycollection/contains/)(const System::String\&) | Returns true if a property with the specified name exists in the collection. |
| [get_Count](../documentpropertycollection/get_count/)() | Gets number of items in the collection. |
| [GetEnumerator](../documentpropertycollection/getenumerator/)() override | Returns an enumerator object that can be used to iterate over all items in the collection. |
| virtual [idx_get](../documentpropertycollection/idx_get/)(System::String) | Returns a [DocumentProperty](../documentproperty/) object by the name of the property. |
| [idx_get](../documentpropertycollection/idx_get/)(int32_t) | Returns a [DocumentProperty](../documentproperty/) object by index. |
| [IndexOf](../documentpropertycollection/indexof/)(const System::String\&) | Gets the index of a property by name. |
| [Remove](../documentpropertycollection/remove/)(const System::String\&) | Removes a property with the specified name from the collection. |
| [RemoveAt](../documentpropertycollection/removeat/)(int32_t) | Removes a property at the specified index. |
## Remarks


Each [DocumentProperty](../documentproperty/) object represents a custom property of a container document.

The names of the properties are case-insensitive.

The properties in the collection are sorted alphabetically by name.

## Examples



Shows how to work with custom document properties. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Properties.docx");

// Every document contains a collection of custom properties, which, like the built-in properties, are key-value pairs.
// The document has a fixed list of built-in properties. The user creates all of the custom properties.
ASSERT_EQ(u"Value of custom document property", System::ObjectExt::ToString(doc->get_CustomDocumentProperties()->idx_get(u"CustomProperty")));

doc->get_CustomDocumentProperties()->Add(u"CustomProperty2", String(u"Value of custom document property #2"));

std::cout << "Custom Properties:" << std::endl;
for (const auto& customDocumentProperty : System::IterateOver(doc->get_CustomDocumentProperties()))
{
    std::cout << customDocumentProperty->get_Name() << std::endl;
    std::cout << String::Format(u"\tType:\t{0}", customDocumentProperty->get_Type()) << std::endl;
    std::cout << "\tValue:\t\"" << customDocumentProperty->get_Value() << "\"" << std::endl;
}
```

## See Also

* Class [DocumentPropertyCollection](../documentpropertycollection/)
* Namespace [Aspose::Words::Properties](../)
* Library [Aspose.Words](../../)
