---
title: FieldSeq
second_title: Aspose.Words for C++ API Reference
description: Implements the SEQ field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldseq/
---
## FieldSeq class


Implements the SEQ field. 

## Methods

| Method | Description |
| --- | --- |
| [get_BookmarkName](./get_bookmarkname/)() | Gets or sets a bookmark name that refers to an item elsewhere in the document rather than in the current location.  |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_InsertNextNumber](./get_insertnextnumber/)() | Gets or sets whether to insert the next sequence number for the specified item.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_ResetHeadingLevel](./get_resetheadinglevel/)() | Gets or sets an integer number representing a heading level to reset the sequence number to. Returns -1 if the number is absent.  |
| [get_ResetNumber](./get_resetnumber/)() | Gets or sets an integer number to reset the sequence number to. Returns -1 if the number is absent.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_SequenceIdentifier](./get_sequenceidentifier/)() | Gets or sets the name assigned to the series of items that are to be numbered.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_BookmarkName](./set_bookmarkname/)(const System::String &) | Setter for Aspose::Words::Fields::FieldSeq::get_BookmarkName.  |
| [set_InsertNextNumber](./set_insertnextnumber/)(bool) | Setter for Aspose::Words::Fields::FieldSeq::get_InsertNextNumber.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_ResetHeadingLevel](./set_resetheadinglevel/)(const System::String &) | Setter for Aspose::Words::Fields::FieldSeq::get_ResetHeadingLevel.  |
| [set_ResetNumber](./set_resetnumber/)(const System::String &) | Setter for Aspose::Words::Fields::FieldSeq::get_ResetNumber.  |
| [set_Result](../field/set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_SequenceIdentifier](./set_sequenceidentifier/)(const System::String &) | Setter for Aspose::Words::Fields::FieldSeq::get_SequenceIdentifier.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
