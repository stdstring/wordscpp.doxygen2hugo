---
title: FieldTA
second_title: Aspose.Words for C++ API Reference
description: Implements the TA field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldta/
---
## FieldTA class


Implements the TA field. 

## Methods

| Method | Description |
| --- | --- |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_EntryCategory](./get_entrycategory/)() | Gets or sets the integral entry category, which is a number that corresponds to the order of categories.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_IsBold](./get_isbold/)() | Gets or sets whether to apply bold formatting to the page number for the entry.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsItalic](./get_isitalic/)() | Gets or sets whether to apply italic formatting to the page number for the entry.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_LongCitation](./get_longcitation/)() | Gets or sets the long citation for the entry.  |
| [get_PageRangeBookmarkName](./get_pagerangebookmarkname/)() | Gets or sets the name of the bookmark that marks a range of pages that is inserted as the entry's page number.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_ShortCitation](./get_shortcitation/)() | Gets or sets the short citation for the entry.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_EntryCategory](./set_entrycategory/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTA::get_EntryCategory.  |
| [set_IsBold](./set_isbold/)(bool) | Setter for Aspose::Words::Fields::FieldTA::get_IsBold.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsItalic](./set_isitalic/)(bool) | Setter for Aspose::Words::Fields::FieldTA::get_IsItalic.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_LongCitation](./set_longcitation/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTA::get_LongCitation.  |
| [set_PageRangeBookmarkName](./set_pagerangebookmarkname/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTA::get_PageRangeBookmarkName.  |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_ShortCitation](./set_shortcitation/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTA::get_ShortCitation.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
