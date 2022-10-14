---
title: FieldPrintDate
second_title: Aspose.Words for C++ API Reference
description: Implements the PRINTDATE field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldprintdate/
---
## FieldPrintDate class


Implements the PRINTDATE field. 

## Methods

| Method | Description |
| --- | --- |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [get_UseLunarCalendar](./get_uselunarcalendar/)() | Gets or sets whether to use the Hijri Lunar or Hebrew Lunar calendar.  |
| [get_UseSakaEraCalendar](./get_usesakaeracalendar/)() | Gets or sets whether to use the Saka Era calendar.  |
| [get_UseUmAlQuraCalendar](./get_useumalquracalendar/)() | Gets or sets whether to use the Um-al-Qura calendar.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_Result](../field/set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_UseLunarCalendar](./set_uselunarcalendar/)(bool) | Setter for Aspose::Words::Fields::FieldPrintDate::get_UseLunarCalendar.  |
| [set_UseSakaEraCalendar](./set_usesakaeracalendar/)(bool) | Setter for Aspose::Words::Fields::FieldPrintDate::get_UseSakaEraCalendar.  |
| [set_UseUmAlQuraCalendar](./set_useumalquracalendar/)(bool) | Setter for Aspose::Words::Fields::FieldPrintDate::get_UseUmAlQuraCalendar.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
