---
title: Range
second_title: Aspose.Words for C++ API Reference
description: Represents a contiguous area in a document. 
type: docs
weight: 0
url: /cpp/aspose.words/range/
---
## Range class


Represents a contiguous area in a document. 

## Methods

| Method | Description |
| --- | --- |
| void [Delete](./delete/)() | Deletes all characters of the range.  |
| System::SharedPtr< Aspose::Words::BookmarkCollection > [get_Bookmarks](./get_bookmarks/)() | Returns a Bookmarks collection that represents all bookmarks in the range.  |
| System::SharedPtr< Aspose::Words::Fields::FieldCollection > [get_Fields](./get_fields/)() | Returns a Fields collection that represents all fields in the range.  |
| System::SharedPtr< Aspose::Words::Fields::FormFieldCollection > [get_FormFields](./get_formfields/)() | Returns a FormFields collection that represents all form fields in the range.  |
| System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTagCollection > [get_StructuredDocumentTags](./get_structureddocumenttags/)() | Returns a StructuredDocumentTags collection that represents all structured document tags in the range.  |
| System::String [get_Text](./get_text/)() | Gets the text of the range.  |
| void [NormalizeFieldTypes](./normalizefieldtypes/)() | Changes field type values FieldType of FieldStart, FieldSeparator, FieldEnd in this range so that they correspond to the field types contained in the field codes.  |
| int32_t [Replace](./replace/)(const System::SharedPtr< System::Text::RegularExpressions::Regex > &, const System::String &) | Replaces all occurrences of a character pattern specified by a regular expression with another string.  |
| int32_t [Replace](./replace/)(const System::SharedPtr< System::Text::RegularExpressions::Regex > &, const System::String &, const System::SharedPtr< Aspose::Words::Replacing::FindReplaceOptions > &) | Replaces all occurrences of a character pattern specified by a regular expression with another string.  |
| int32_t [Replace](./replace/)(const System::String &, const System::String &) | Replaces all occurrences of a specified character string pattern with a replacement string.  |
| int32_t [Replace](./replace/)(const System::String &, const System::String &, const System::SharedPtr< Aspose::Words::Replacing::FindReplaceOptions > &) | Replaces all occurrences of a specified character string pattern with a replacement string.  |
| System::SharedPtr< Aspose::Words::Document > [ToDocument](./todocument/)() | Constructs a new fully formed document that contains the range.  |
| void [UnlinkFields](./unlinkfields/)() | Unlinks fields in this range.  |
| void [UpdateFields](./updatefields/)() | Updates the values of document fields in this range.  |
