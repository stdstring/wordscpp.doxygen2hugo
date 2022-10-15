---
title: FieldXE
second_title: Aspose.Words for C++ API Reference
description: Implements the XE field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldxe/
---
## FieldXE class


Implements the XE field.

## Methods

| Method | Description |
| --- | --- |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result. |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end. |
| [get_EntryType](./get_entrytype/)() | Gets or sets an index entry type. |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end. |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field. |
| [get_Format](../field/get_format/)() | Gets a [FieldFormat](../fieldformat/) object that provides typed access to field's formatting. |
| [get_IsBold](./get_isbold/)() | Gets or sets whether to apply bold formatting to the entry's page number. |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document. |
| [get_IsItalic](./get_isitalic/)() | Gets or sets whether to apply italic formatting to the entry's page number. |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result). |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field. |
| [get_PageNumberReplacement](./get_pagenumberreplacement/)() | Gets or sets text used in place of a page number. |
| [get_PageRangeBookmarkName](./get_pagerangebookmarkname/)() | Gets or sets the name of the bookmark that marks a range of pages that is inserted as the entry's page number. |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end. |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null. |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field. |
| [get_Text](./get_text/)() | Gets or sets the text of the entry. |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type. |
| [get_Yomi](./get_yomi/)() | Gets or sets the yomi (first phonetic character for sorting indexes) for the index entry. |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included. |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator). |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**. |
| [set_EntryType](./set_entrytype/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldXE::get_EntryType](./get_entrytype/). |
| [set_IsBold](./set_isbold/)(bool) | Setter for [Aspose::Words::Fields::FieldXE::get_IsBold](./get_isbold/). |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsDirty](../field/get_isdirty/). |
| [set_IsItalic](./set_isitalic/)(bool) | Setter for [Aspose::Words::Fields::FieldXE::get_IsItalic](./get_isitalic/). |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsLocked](../field/get_islocked/). |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for [Aspose::Words::Fields::Field::get_LocaleId](../field/get_localeid/). |
| [set_PageNumberReplacement](./set_pagenumberreplacement/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldXE::get_PageNumberReplacement](./get_pagenumberreplacement/). |
| [set_PageRangeBookmarkName](./set_pagerangebookmarkname/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldXE::get_PageRangeBookmarkName](./get_pagerangebookmarkname/). |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for [Aspose::Words::Fields::Field::get_Result](../field/get_result/). |
| [set_Text](./set_text/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldXE::get_Text](./get_text/). |
| [set_Yomi](./set_yomi/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldXE::get_Yomi](./get_yomi/). |
| [Unlink](../field/unlink/)() | Performs the field unlink. |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already. |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already. |
