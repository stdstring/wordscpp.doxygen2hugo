---
title: StyleCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of Style objects that represent both the built-in and user-defined styles in a document. 
type: docs
weight: 0
url: /cpp/aspose.words/stylecollection/
---
## StyleCollection class


A collection of Style objects that represent both the built-in and user-defined styles in a document. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Style > [Add](./add/)(Aspose::Words::StyleType, const System::String &) | Creates a new user defined style and adds it the collection.  |
| System::SharedPtr< Aspose::Words::Style > [AddCopy](./addcopy/)(const System::SharedPtr< Aspose::Words::Style > &) | Copies a style into this collection.  |
| void [ClearQuickStyleGallery](./clearquickstylegallery/)() | Removes all styles from the Quick Style Gallery panel.  |
| int32_t [get_Count](./get_count/)() | Gets the number of styles in the collection.  |
| System::SharedPtr< Aspose::Words::Font > [get_DefaultFont](./get_defaultfont/)() | Gets document default text formatting.  |
| System::SharedPtr< Aspose::Words::ParagraphFormat > [get_DefaultParagraphFormat](./get_defaultparagraphformat/)() | Gets document default paragraph formatting.  |
| System::SharedPtr< Aspose::Words::DocumentBase > [get_Document](./get_document/)() const | Gets the owner document.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Style > > > [GetEnumerator](./getenumerator/)() override | Gets an enumerator object that will enumerate styles in the alphabetical order of their names.  |
| System::SharedPtr< Aspose::Words::Style > [idx_get](./idx_get/)(Aspose::Words::StyleIdentifier) | Gets a built-in style by its locale independent identifier.  |
| System::SharedPtr< Aspose::Words::Style > [idx_get](./idx_get/)(const System::String &) | Gets a style by name or alias.  |
| System::SharedPtr< Aspose::Words::Style > [idx_get](./idx_get/)(int32_t) | Gets a style by index.  |
