---
title: DocumentPropertyCollection
second_title: Aspose.Words for C++ API Reference
description: Base class for BuiltInDocumentProperties and CustomDocumentProperties collections. 
type: docs
weight: 0
url: /cpp/aspose.words.properties/documentpropertycollection/
---
## DocumentPropertyCollection class


Base class for BuiltInDocumentProperties and CustomDocumentProperties collections. 

## Methods

| Method | Description |
| --- | --- |
| void [Clear](./clear/)() | Removes all properties from the collection.  |
| bool [Contains](./contains/)(const System::String &) | Returns true if a property with the specified name exists in the collection.  |
| int32_t [get_Count](./get_count/)() | Gets number of items in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Properties::DocumentProperty > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object that can be used to iterate over all items in the collection.  |
| System::SharedPtr< Aspose::Words::Properties::DocumentProperty > [idx_get](./idx_get/)(int32_t) | Returns a DocumentProperty object by index.  |
| virtual System::SharedPtr< Aspose::Words::Properties::DocumentProperty > [idx_get](./idx_get/)(System::String) | Returns a DocumentProperty object by the name of the property.  |
| int32_t [IndexOf](./indexof/)(const System::String &) | Gets the index of a property by name.  |
| void [Remove](./remove/)(const System::String &) | Removes a property with the specified name from the collection.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a property at the specified index.  |
