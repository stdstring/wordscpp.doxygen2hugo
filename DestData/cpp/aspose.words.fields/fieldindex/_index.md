---
title: FieldIndex
second_title: Aspose.Words for C++ API Reference
description: Implements the INDEX field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldindex/
---
## FieldIndex class


Implements the INDEX field.

## Methods

| Method | Description |
| --- | --- |
| [get_BookmarkName](./get_bookmarkname/)() | Gets or sets the name of the bookmark that marks the portion of the document used to build the index. |
| [get_CrossReferenceSeparator](./get_crossreferenceseparator/)() | Gets or sets the character sequence that is used to separate cross references and other entries. |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result. |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end. |
| [get_EntryType](./get_entrytype/)() | Gets or sets an index entry type used to build the index. |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end. |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field. |
| [get_Format](../field/get_format/)() | Gets a [FieldFormat](../fieldformat/) object that provides typed access to field's formatting. |
| [get_HasPageNumberSeparator](./get_haspagenumberseparator/)() | Gets a value indicating whether a page number separator is overridden through the field's code. |
| [get_HasSequenceName](./get_hassequencename/)() | Gets a value indicating whether a sequence should be used while the field's result building. |
| [get_Heading](./get_heading/)() | Gets or sets a heading that appears at the start of each set of entries for any given letter. |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document. |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result). |
| [get_LanguageId](./get_languageid/)() | Gets or sets the language ID used to generate the index. |
| [get_LetterRange](./get_letterrange/)() | Gets or sets a range of letters to which limit the index. |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field. |
| [get_NumberOfColumns](./get_numberofcolumns/)() | Gets or sets the number of columns per page used when building the index. |
| [get_PageNumberListSeparator](./get_pagenumberlistseparator/)() | Gets or sets the character sequence that is used to separate two page numbers in a page number list. |
| [get_PageNumberSeparator](./get_pagenumberseparator/)() | Gets or sets the character sequence that is used to separate an index entry and its page number. |
| [get_PageRangeSeparator](./get_pagerangeseparator/)() | Gets or sets the character sequence that is used to separate the start and end of a page range. |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end. |
| [get_RunSubentriesOnSameLine](./get_runsubentriesonsameline/)() | Gets or sets whether run subentries into the same line as the main entry. |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null. |
| [get_SequenceName](./get_sequencename/)() | Gets or sets the name of a sequence whose number is included with the page number. |
| [get_SequenceSeparator](./get_sequenceseparator/)() | Gets or sets the character sequence that is used to separate sequence numbers and page numbers. |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field. |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type. |
| [get_UseYomi](./get_useyomi/)() | Gets or sets whether to enable the use of yomi text for index entries. |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included. |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator). |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**. |
| [set_BookmarkName](./set_bookmarkname/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_BookmarkName](./get_bookmarkname/). |
| [set_CrossReferenceSeparator](./set_crossreferenceseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_CrossReferenceSeparator](./get_crossreferenceseparator/). |
| [set_EntryType](./set_entrytype/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_EntryType](./get_entrytype/). |
| [set_Heading](./set_heading/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_Heading](./get_heading/). |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsDirty](../field/get_isdirty/). |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsLocked](../field/get_islocked/). |
| [set_LanguageId](./set_languageid/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_LanguageId](./get_languageid/). |
| [set_LetterRange](./set_letterrange/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_LetterRange](./get_letterrange/). |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for [Aspose::Words::Fields::Field::get_LocaleId](../field/get_localeid/). |
| [set_NumberOfColumns](./set_numberofcolumns/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_NumberOfColumns](./get_numberofcolumns/). |
| [set_PageNumberListSeparator](./set_pagenumberlistseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_PageNumberListSeparator](./get_pagenumberlistseparator/). |
| [set_PageNumberSeparator](./set_pagenumberseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_PageNumberSeparator](./get_pagenumberseparator/). |
| [set_PageRangeSeparator](./set_pagerangeseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_PageRangeSeparator](./get_pagerangeseparator/). |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for [Aspose::Words::Fields::Field::get_Result](../field/get_result/). |
| [set_RunSubentriesOnSameLine](./set_runsubentriesonsameline/)(bool) | Setter for [Aspose::Words::Fields::FieldIndex::get_RunSubentriesOnSameLine](./get_runsubentriesonsameline/). |
| [set_SequenceName](./set_sequencename/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_SequenceName](./get_sequencename/). |
| [set_SequenceSeparator](./set_sequenceseparator/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldIndex::get_SequenceSeparator](./get_sequenceseparator/). |
| [set_UseYomi](./set_useyomi/)(bool) | Setter for [Aspose::Words::Fields::FieldIndex::get_UseYomi](./get_useyomi/). |
| [Unlink](../field/unlink/)() | Performs the field unlink. |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already. |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already. |
