---
title: FieldTC
second_title: Aspose.Words for C++ API Reference
description: Implements the TC field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldtc/
---
## FieldTC class


Implements the TC field. 

## Methods

| Method | Description |
| --- | --- |
| [FieldTC](./fieldtc/)() |  |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_EntryLevel](./get_entrylevel/)() | Gets or sets the level of the entry.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_OmitPageNumber](./get_omitpagenumber/)() override | Gets or sets whether page number in TOC should be omitted for this field.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| [get_Text](./get_text/)() | Gets or sets the text of the entry.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [get_TypeIdentifier](./get_typeidentifier/)() | Gets or sets a type identifier for this field (which is typically a letter).  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_EntryLevel](./set_entrylevel/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTC::get_EntryLevel.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_OmitPageNumber](./set_omitpagenumber/)(bool) | Setter for Aspose::Words::Fields::FieldTC::get_OmitPageNumber.  |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_Text](./set_text/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTC::get_Text.  |
| [set_TypeIdentifier](./set_typeidentifier/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldTC::get_TypeIdentifier.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
