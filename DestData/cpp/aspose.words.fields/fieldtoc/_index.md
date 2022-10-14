---
title: FieldToc
second_title: Aspose.Words for C++ API Reference
description: Implements the TOC field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldtoc/
---
## FieldToc class


Implements the TOC field. 

## Methods

| Method | Description |
| --- | --- |
| [FieldToc](./fieldtoc/)() |  |
| [get_BookmarkName](./get_bookmarkname/)() | Gets or sets the name of the bookmark that marks the portion of the document used to build the table.  |
| [get_CaptionlessTableOfFiguresLabel](./get_captionlesstableoffigureslabel/)() override | Gets the name of the sequence identifier used when building a table of figures that does not include caption's label and number.  |
| [get_CustomStyles](./get_customstyles/)() | Gets or sets a list of styles other than the built-in heading styles to include in the table of contents.  |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_End](./get_end/)() override | Gets the node that represents the field end.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_EntryIdentifier](./get_entryidentifier/)() | Gets or sets a string that should match type identifiers of TC fields being included.  |
| [get_EntryLevelRange](./get_entrylevelrange/)() | Gets or sets a range of levels of the table of contents entries to be included.  |
| [get_EntrySeparator](./get_entryseparator/)() | Gets or sets a sequence of characters that separate an entry and its page number.  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_HeadingLevelRange](./get_headinglevelrange/)() | Gets or sets a range of heading levels to include.  |
| [get_HideInWebLayout](./get_hideinweblayout/)() | Gets or sets whether to hide tab leader and page numbers in Web layout view.  |
| [get_InsertHyperlinks](./get_inserthyperlinks/)() | Gets or sets whether to make the table of contents entries hyperlinks.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_PageNumberOmittingLevelRange](./get_pagenumberomittinglevelrange/)() | Gets or sets a range of levels of the table of contents entries from which to omits page numbers.  |
| [get_PrefixedSequenceIdentifier](./get_prefixedsequenceidentifier/)() | Gets or sets the identifier of a sequence for which a prefix should be added to the entry's page number.  |
| [get_PreserveLineBreaks](./get_preservelinebreaks/)() | Gets or sets whether to preserve newline characters within table entries.  |
| [get_PreserveTabs](./get_preservetabs/)() | Gets or sets whether to preserve tab entries within table entries.  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_SequenceSeparator](./get_sequenceseparator/)() | Gets or sets the character sequence that is used to separate sequence numbers and page numbers.  |
| [get_Start](./get_start/)() override | Gets the node that represents the start of the field.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| [get_TableOfFiguresLabel](./get_tableoffigureslabel/)() override | Gets or sets the name of the sequence identifier used when building a table of figures.  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [get_UseParagraphOutlineLevel](./get_useparagraphoutlinelevel/)() override | Gets or sets whether to use the applied paragraph outline level.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_BookmarkName](./set_bookmarkname/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_BookmarkName.  |
| [set_CaptionlessTableOfFiguresLabel](./set_captionlesstableoffigureslabel/)(const System::String\&) | Sets the name of the sequence identifier used when building a table of figures that does not include caption's label and number.  |
| [set_CustomStyles](./set_customstyles/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_CustomStyles.  |
| [set_EntryIdentifier](./set_entryidentifier/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_EntryIdentifier.  |
| [set_EntryLevelRange](./set_entrylevelrange/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_EntryLevelRange.  |
| [set_EntrySeparator](./set_entryseparator/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_EntrySeparator.  |
| [set_HeadingLevelRange](./set_headinglevelrange/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_HeadingLevelRange.  |
| [set_HideInWebLayout](./set_hideinweblayout/)(bool) | Setter for Aspose::Words::Fields::FieldToc::get_HideInWebLayout.  |
| [set_InsertHyperlinks](./set_inserthyperlinks/)(bool) | Setter for Aspose::Words::Fields::FieldToc::get_InsertHyperlinks.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_PageNumberOmittingLevelRange](./set_pagenumberomittinglevelrange/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_PageNumberOmittingLevelRange.  |
| [set_PrefixedSequenceIdentifier](./set_prefixedsequenceidentifier/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_PrefixedSequenceIdentifier.  |
| [set_PreserveLineBreaks](./set_preservelinebreaks/)(bool) | Setter for Aspose::Words::Fields::FieldToc::get_PreserveLineBreaks.  |
| [set_PreserveTabs](./set_preservetabs/)(bool) | Setter for Aspose::Words::Fields::FieldToc::get_PreserveTabs.  |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_SequenceSeparator](./set_sequenceseparator/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_SequenceSeparator.  |
| [set_TableOfFiguresLabel](./set_tableoffigureslabel/)(const System::String\&) | Setter for Aspose::Words::Fields::FieldToc::get_TableOfFiguresLabel.  |
| [set_UseParagraphOutlineLevel](./set_useparagraphoutlinelevel/)(bool) | Setter for Aspose::Words::Fields::FieldToc::get_UseParagraphOutlineLevel.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
| [UpdatePageNumbers](./updatepagenumbers/)() | Updates the page numbers for items in this table of contents.  |
