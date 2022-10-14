---
title: FieldPageRef
second_title: Aspose.Words for C++ API Reference
description: Implements the PAGEREF field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldpageref/
---
## FieldPageRef class


Implements the PAGEREF field. 

## Methods

| Method | Description |
| --- | --- |
| [get_BookmarkName](./get_bookmarkname/)() | Gets or sets the name of the bookmark.  |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_InsertHyperlink](./get_inserthyperlink/)() | Gets or sets whether to insert a hyperlink to the bookmarked paragraph.  |
| [get_InsertRelativePosition](./get_insertrelativeposition/)() | Gets or sets whether to insert a relative position of the bookmarked paragraph.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_BookmarkName](./set_bookmarkname/)(const System::String &) | Setter for Aspose::Words::Fields::FieldPageRef::get_BookmarkName.  |
| [set_InsertHyperlink](./set_inserthyperlink/)(bool) | Setter for Aspose::Words::Fields::FieldPageRef::get_InsertHyperlink.  |
| [set_InsertRelativePosition](./set_insertrelativeposition/)(bool) | Setter for Aspose::Words::Fields::FieldPageRef::get_InsertRelativePosition.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_Result](../field/set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
