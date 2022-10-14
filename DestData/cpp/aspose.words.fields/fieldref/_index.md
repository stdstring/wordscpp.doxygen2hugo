---
title: FieldRef
second_title: Aspose.Words for C++ API Reference
description: Implements the REF field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldref/
---
## FieldRef class


Implements the REF field. 

## Methods

| Method | Description |
| --- | --- |
| [get_BookmarkName](./get_bookmarkname/)() | Gets or sets the referenced bookmark's name.  |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](./get_end/)() override | Gets the node that represents the field end.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_IncludeNoteOrComment](./get_includenoteorcomment/)() | Gets or sets whether to increment footnote, endnote, and annotation numbers that are marked by the bookmark, and insert the corresponding footnote, endnote, and comment text.  |
| [get_InsertHyperlink](./get_inserthyperlink/)() | Gets or sets whether to create a hyperlink to the bookmarked paragraph.  |
| [get_InsertParagraphNumber](./get_insertparagraphnumber/)() | Gets or sets whether to insert the paragraph number of the referenced paragraph exactly as it appears in the document.  |
| [get_InsertParagraphNumberInFullContext](./get_insertparagraphnumberinfullcontext/)() | Gets or sets whether to insert the paragraph number of the referenced paragraph in full context.  |
| [get_InsertParagraphNumberInRelativeContext](./get_insertparagraphnumberinrelativecontext/)() | Gets or sets whether to insert the paragraph number of the referenced paragraph in relative context.  |
| [get_InsertRelativePosition](./get_insertrelativeposition/)() | Gets or sets whether to insert the relative position of the referenced paragraph.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_NumberSeparator](./get_numberseparator/)() | Gets or sets the character sequence that is used to separate sequence numbers and page numbers.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](./get_separator/)() override | Gets the node that represents the field separator. Can be null.  |
| [get_Start](./get_start/)() override | Gets the node that represents the start of the field.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| [get_SuppressNonDelimiters](./get_suppressnondelimiters/)() | Gets or sets whether to suppress non-delimiter characters.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_BookmarkName](./set_bookmarkname/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldRef::get_BookmarkName.  |
| [set_IncludeNoteOrComment](./set_includenoteorcomment/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_IncludeNoteOrComment.  |
| [set_InsertHyperlink](./set_inserthyperlink/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_InsertHyperlink.  |
| [set_InsertParagraphNumber](./set_insertparagraphnumber/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_InsertParagraphNumber.  |
| [set_InsertParagraphNumberInFullContext](./set_insertparagraphnumberinfullcontext/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_InsertParagraphNumberInFullContext.  |
| [set_InsertParagraphNumberInRelativeContext](./set_insertparagraphnumberinrelativecontext/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_InsertParagraphNumberInRelativeContext.  |
| [set_InsertRelativePosition](./set_insertrelativeposition/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_InsertRelativePosition.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_NumberSeparator](./set_numberseparator/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldRef::get_NumberSeparator.  |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_SuppressNonDelimiters](./set_suppressnondelimiters/)(bool) | Setter for Aspose::Words::Fields::FieldRef::get_SuppressNonDelimiters.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
