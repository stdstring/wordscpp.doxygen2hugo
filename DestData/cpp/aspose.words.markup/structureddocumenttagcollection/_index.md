---
title: StructuredDocumentTagCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of IStructuredDocumentTag instances that represent the structured document tags in the specified range. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/structureddocumenttagcollection/
---
## StructuredDocumentTagCollection class


A collection of IStructuredDocumentTag instances that represent the structured document tags in the specified range. 

## Methods

| Method | Description |
| --- | --- |
| int32_t [get_Count](./get_count/)() | Returns the number of structured document tags in the collection.  |
| System::SharedPtr< Aspose::Words::Markup::IStructuredDocumentTag > [GetById](./getbyid/)(int32_t) | Returns the structured document tag by identifier.  |
| System::SharedPtr< Aspose::Words::Markup::IStructuredDocumentTag > [GetByTag](./getbytag/)(const System::String &) | Returns the first structured document tag encountered in the collection with the specified tag.  |
| System::SharedPtr< Aspose::Words::Markup::IStructuredDocumentTag > [GetByTitle](./getbytitle/)(const System::String &) | Returns the first structured document tag encountered in the collection with the specified title.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Markup::IStructuredDocumentTag > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object.  |
| System::SharedPtr< Aspose::Words::Markup::IStructuredDocumentTag > [idx_get](./idx_get/)(int32_t) | Returns the structured document tag at the specified index.  |
| void [Remove](./remove/)(int32_t) | Removes the structured document tag with the specified identifier.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a structured document tag at the specified index.  |
