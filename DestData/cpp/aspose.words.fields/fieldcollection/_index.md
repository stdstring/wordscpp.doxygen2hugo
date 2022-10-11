---
title: FieldCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of Field objects that represents the fields in the specified range. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldcollection/
---
## FieldCollection class


A collection of Field objects that represents the fields in the specified range. 

## Methods

| Method | Description |
| --- | --- |
| void [Clear](./clear/)() | Removes all fields of this collection from the document and from this collection itself.  |
| int32_t [get_Count](./get_count/)() | Returns the number of the fields in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Fields::Field > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [idx_get](./idx_get/)(int32_t) | Returns a field at the specified index.  |
| void [Remove](./remove/)(const System::SharedPtr< Aspose::Words::Fields::Field > &) | Removes the specified field from this collection and from the document.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a field at the specified index from this collection and from the document.  |
