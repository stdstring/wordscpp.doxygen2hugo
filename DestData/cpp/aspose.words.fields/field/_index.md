---
title: field
second_title: Aspose.Words for C++ API Reference
description: Represents a Microsoft Word document field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/field/
---

Represents a Microsoft Word document field. 

## Methods

| Method | Description |
| --- | --- |
| [get_DisplayResult](./get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](./get_end/)() const | Gets the node that represents the field end.  |
| [get_FieldEnd](./get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](./get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](./get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_IsDirty](./get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](./get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](./get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_Result](./get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](./get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_Start](./get_start/)() const | Gets the node that represents the start of the field.  |
| virtual [get_Type](./get_type/)() const | Gets the Microsoft Word field type.  |
| [GetFieldCode](./getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](./getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](./remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_IsDirty](./set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](./set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](./set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_Result](./set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [Unlink](./unlink/)() | Performs the field unlink.  |
| [Update](./update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](./update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
