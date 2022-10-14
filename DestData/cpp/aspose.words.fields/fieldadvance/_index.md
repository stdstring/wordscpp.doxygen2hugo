---
title: FieldAdvance
second_title: Aspose.Words for C++ API Reference
description: Implements the ADVANCE field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldadvance/
---
## FieldAdvance class


Implements the ADVANCE field. 

## Methods

| Method | Description |
| --- | --- |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_DownOffset](./get_downoffset/)() | Gets or sets the number of points by which the text that follows the field should be moved down.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_HorizontalPosition](./get_horizontalposition/)() | Gets or sets the number of points by which the text that follows the field should be moved horizontally from the left edge of the column, frame, or text box.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LeftOffset](./get_leftoffset/)() | Gets or sets the number of points by which the text that follows the field should be moved left.  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_RightOffset](./get_rightoffset/)() | Gets or sets the number of points by which the text that follows the field should be moved right.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [get_UpOffset](./get_upoffset/)() | Gets or sets the number of points by which the text that follows the field should be moved up.  |
| [get_VerticalPosition](./get_verticalposition/)() | Gets or sets the number of points by which the text that follows the field should be moved vertically from the top edge of the page.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_DownOffset](./set_downoffset/)(const System::String &) | Setter for Aspose::Words::Fields::FieldAdvance::get_DownOffset.  |
| [set_HorizontalPosition](./set_horizontalposition/)(const System::String &) | Setter for Aspose::Words::Fields::FieldAdvance::get_HorizontalPosition.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LeftOffset](./set_leftoffset/)(const System::String &) | Setter for Aspose::Words::Fields::FieldAdvance::get_LeftOffset.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_Result](../field/set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_RightOffset](./set_rightoffset/)(const System::String &) | Setter for Aspose::Words::Fields::FieldAdvance::get_RightOffset.  |
| [set_UpOffset](./set_upoffset/)(const System::String &) | Setter for Aspose::Words::Fields::FieldAdvance::get_UpOffset.  |
| [set_VerticalPosition](./set_verticalposition/)(const System::String &) | Setter for Aspose::Words::Fields::FieldAdvance::get_VerticalPosition.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
