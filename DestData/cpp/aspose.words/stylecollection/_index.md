---
title: StyleCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of Style objects that represent both the built-in and user-defined styles in a document. 
type: docs
weight: 0
url: /cpp/aspose.words/stylecollection/
---
## StyleCollection class


A collection of [Style](./style/) objects that represent both the built-in and user-defined styles in a document.

## Methods

| Method | Description |
| --- | --- |
| [Add](./add/)(Aspose::Words::StyleType, const System::String\&) | Creates a new user defined style and adds it the collection. |
| [AddCopy](./addcopy/)(const System::SharedPtr\<Aspose::Words::Style\>\&) | Copies a style into this collection. |
| [ClearQuickStyleGallery](./clearquickstylegallery/)() | Removes all styles from the Quick [Style](../style/) Gallery panel. |
| [get_Count](./get_count/)() | Gets the number of styles in the collection. |
| [get_DefaultFont](./get_defaultfont/)() | Gets document default text formatting. |
| [get_DefaultParagraphFormat](./get_defaultparagraphformat/)() | Gets document default paragraph formatting. |
| [get_Document](./get_document/)() const | Gets the owner document. |
| [GetEnumerator](./getenumerator/)() override | Gets an enumerator object that will enumerate styles in the alphabetical order of their names. |
| [idx_get](./idx_get/)(const System::String\&) | Gets a style by name or alias. |
| [idx_get](./idx_get/)(Aspose::Words::StyleIdentifier) | Gets a built-in style by its locale independent identifier. |
| [idx_get](./idx_get/)(int32_t) | Gets a style by index. |
