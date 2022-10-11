---
title: Field
second_title: Aspose.Words for C++ API Reference
description: Represents a Microsoft Word document field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/field/
---
## Field class


Represents a Microsoft Word document field. 

## Methods

| Method | Description |
| --- | --- |
| System::String [get_DisplayResult](./get_displayresult/)() | Gets the text that represents the displayed field result.  |
| System::SharedPtr< Aspose::Words::Fields::FieldEnd > [get_End](./get_end/)() const | Gets the node that represents the field end.  |
| System::SharedPtr< Aspose::Words::Fields::FieldEnd > [get_FieldEnd](./get_fieldend/)() const | Gets the node that represents the field end.  |
| System::SharedPtr< Aspose::Words::Fields::FieldStart > [get_FieldStart](./get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| System::SharedPtr< Aspose::Words::Fields::FieldFormat > [get_Format](./get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| bool [get_IsDirty](./get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| bool [get_IsLocked](./get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| int32_t [get_LocaleId](./get_localeid/)() | Gets or sets the LCID of the field.  |
| System::String [get_Result](./get_result/)() | Gets or sets text that is between the field separator and field end.  |
| System::SharedPtr< Aspose::Words::Fields::FieldSeparator > [get_Separator](./get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| System::SharedPtr< Aspose::Words::Fields::FieldStart > [get_Start](./get_start/)() const | Gets the node that represents the start of the field.  |
| virtual Aspose::Words::Fields::FieldType [get_Type](./get_type/)() const | Gets the Microsoft Word field type.  |
| System::String [GetFieldCode](./getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| System::String [GetFieldCode](./getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| System::SharedPtr< Aspose::Words::Node > [Remove](./remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| void [set_IsDirty](./set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| void [set_IsLocked](./set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| void [set_LocaleId](./set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| void [set_Result](./set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| bool [Unlink](./unlink/)() | Performs the field unlink.  |
| void [Update](./update/)() | Performs the field update. Throws if the field is being updated already.  |
| void [Update](./update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
