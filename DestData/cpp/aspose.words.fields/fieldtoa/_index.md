---
title: FieldToa
second_title: Aspose.Words for C++ API Reference
description: Implements the TOA field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldtoa/
---
## FieldToa class


Implements the TOA field.

## Methods

| Method | Description |
| --- | --- |
| [get_BookmarkName](./get_bookmarkname/)() | Gets or sets the name of the bookmark that marks the portion of the document used to build the table. |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result. |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end. |
| [get_EntryCategory](./get_entrycategory/)() | Gets or sets the integral category for entries included in the table. |
| [get_EntrySeparator](./get_entryseparator/)() | Gets or sets the character sequence that is used to separate a table of authorities entry and its page number. |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end. |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field. |
| [get_Format](../field/get_format/)() | Gets a [FieldFormat](../fieldformat/) object that provides typed access to field's formatting. |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document. |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result). |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field. |
| [get_PageNumberListSeparator](./get_pagenumberlistseparator/)() | Gets or sets the character sequence that is used to separate two page numbers in a page number list. |
| [get_PageRangeSeparator](./get_pagerangeseparator/)() | Gets or sets the character sequence that is used to separate the start and end of a page range. |
| [get_RemoveEntryFormatting](./get_removeentryformatting/)() | Gets or sets whether to remove the formatting of the entry text in the document from the entry in the table of authorities. |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end. |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null. |
| [get_SequenceName](./get_sequencename/)() | Gets or sets the name of a sequence whose number is included with the page number. |
| [get_SequenceSeparator](./get_sequenceseparator/)() | Gets or sets the character sequence that is used to separate sequence numbers and page numbers. |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field. |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type. |
| [get_UseHeading](./get_useheading/)() | Gets or sets whether to include the category heading for the entries in a table of authorities. |
| [get_UsePassim](./get_usepassim/)() | Gets or sets whether to replace five or more different page references to the same authority with "passim", which is used to indicate that a word or passage occurs frequently in the work cited. |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included. |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator). |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**. |
| [set_BookmarkName](./set_bookmarkname/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_BookmarkName](./get_bookmarkname/). |
| [set_EntryCategory](./set_entrycategory/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_EntryCategory](./get_entrycategory/). |
| [set_EntrySeparator](./set_entryseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_EntrySeparator](./get_entryseparator/). |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsDirty](../field/get_isdirty/). |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsLocked](../field/get_islocked/). |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for [Aspose::Words::Fields::Field::get_LocaleId](../field/get_localeid/). |
| [set_PageNumberListSeparator](./set_pagenumberlistseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_PageNumberListSeparator](./get_pagenumberlistseparator/). |
| [set_PageRangeSeparator](./set_pagerangeseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_PageRangeSeparator](./get_pagerangeseparator/). |
| [set_RemoveEntryFormatting](./set_removeentryformatting/)(bool) | Setter for [Aspose::Words::Fields::FieldToa::get_RemoveEntryFormatting](./get_removeentryformatting/). |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for [Aspose::Words::Fields::Field::get_Result](../field/get_result/). |
| [set_SequenceName](./set_sequencename/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_SequenceName](./get_sequencename/). |
| [set_SequenceSeparator](./set_sequenceseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldToa::get_SequenceSeparator](./get_sequenceseparator/). |
| [set_UseHeading](./set_useheading/)(bool) | Setter for [Aspose::Words::Fields::FieldToa::get_UseHeading](./get_useheading/). |
| [set_UsePassim](./set_usepassim/)(bool) | Setter for [Aspose::Words::Fields::FieldToa::get_UsePassim](./get_usepassim/). |
| [Unlink](../field/unlink/)() | Performs the field unlink. |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already. |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already. |
