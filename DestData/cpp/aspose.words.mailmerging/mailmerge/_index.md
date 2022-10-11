---
title: MailMerge
second_title: Aspose.Words for C++ API Reference
description: Represents the mail merge functionality. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/mailmerge/
---
## MailMerge class


Represents the mail merge functionality. 

## Methods

| Method | Description |
| --- | --- |
| void [DeleteFields](./deletefields/)() | Removes mail merge related fields from the document.  |
| void [Execute](./execute/)(const System::ArrayPtr< System::String > &, const System::ArrayPtr< System::SharedPtr< System::Object > > &) | Performs a mail merge operation for a single record.  |
| void [Execute](./execute/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeDataSource > &) | Performs a mail merge from a custom data source.  |
| void [ExecuteWithRegions](./executewithregions/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeDataSource > &) | Performs a mail merge from a custom data source with mail merge regions.  |
| void [ExecuteWithRegions](./executewithregions/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeDataSourceRoot > &) | Performs a mail merge from a custom data source with mail merge regions.  |
| Aspose::Words::MailMerging::MailMergeCleanupOptions [get_CleanupOptions](./get_cleanupoptions/)() const | Gets a set of flags that specify what items should be removed during mail merge.  |
| bool [get_CleanupParagraphsWithPunctuationMarks](./get_cleanupparagraphswithpunctuationmarks/)() const | Gets or sets a value indicating whether paragraphs with punctuation marks are considered as empty and should be removed if the RemoveEmptyParagraphs option is specified.  |
| const System::SharedPtr< Aspose::Words::MailMerging::IFieldMergingCallback > & [get_FieldMergingCallback](./get_fieldmergingcallback/)() const | Occurs during mail merge when a mail merge field is encountered in the document.  |
| const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeCallback > & [get_MailMergeCallback](./get_mailmergecallback/)() const | Allows to handle particular events during mail merge.  |
| System::SharedPtr< Aspose::Words::MailMerging::MappedDataFieldCollection > [get_MappedDataFields](./get_mappeddatafields/)() | Returns a collection that represents mapped data fields for the mail merge operation.  |
| bool [get_MergeDuplicateRegions](./get_mergeduplicateregions/)() const | Gets a value indicating whether all of the document mail merge regions with the name of a data source should be merged while executing of a mail merge with regions against the data source or just the first one.  |
| bool [get_MergeWholeDocument](./get_mergewholedocument/)() const | Gets a value indicating whether fields in whole document are updated while executing of a mail merge with regions.  |
| bool [get_PreserveUnusedTags](./get_preserveunusedtags/)() const | Gets a value indicating whether the unused "mustache" tags should be preserved.  |
| System::String [get_RegionEndTag](./get_regionendtag/)() const | Gets or sets a mail merge region end tag.  |
| System::String [get_RegionStartTag](./get_regionstarttag/)() const | Gets or sets a mail merge region start tag.  |
| bool [get_RestartListsAtEachSection](./get_restartlistsateachsection/)() const | Gets or sets a value indicating whether lists are restarted at each section after executing of a mail merge.  |
| bool [get_RetainFirstSectionStart](./get_retainfirstsectionstart/)() const | Gets a value indicating whether the SectionStart of the first document section and its copies for subsequent data source rows are retained during mail merge or updated according to MS Word behaviour.  |
| bool [get_TrimWhitespaces](./get_trimwhitespaces/)() const | Gets or sets a value indicating whether trailing and leading whitespaces are trimmed from mail merge values.  |
| bool [get_UnconditionalMergeFieldsAndRegions](./get_unconditionalmergefieldsandregions/)() const | Gets a value indicating whether merge fields and merge regions are merged regardless of the parent IF field's condition.  |
| bool [get_UseNonMergeFields](./get_usenonmergefields/)() const | When true, specifies that in addition to MERGEFIELD fields, mail merge is performed into some other types of fields and also into "{{fieldName}}" tags.  |
| bool [get_UseWholeParagraphAsRegion](./get_usewholeparagraphasregion/)() const | Gets a value indicating whether whole paragraph with TableStart or TableEnd field or particular range between TableStart and TableEnd fields should be included into mail merge region.  |
| System::ArrayPtr< System::String > [GetFieldNames](./getfieldnames/)() | Returns a collection of mail merge field names available in the document.  |
| System::ArrayPtr< System::String > [GetFieldNamesForRegion](./getfieldnamesforregion/)(const System::String &) | Returns a collection of mail merge field names available in the region.  |
| System::ArrayPtr< System::String > [GetFieldNamesForRegion](./getfieldnamesforregion/)(const System::String &, int32_t) | Returns a collection of mail merge field names available in the region.  |
| System::SharedPtr< System::Collections::Generic::IList< System::SharedPtr< Aspose::Words::MailMerging::MailMergeRegionInfo > > > [GetRegionsByName](./getregionsbyname/)(const System::String &) | Returns a collection of mail merge regions with the specified name.  |
| System::SharedPtr< Aspose::Words::MailMerging::MailMergeRegionInfo > [GetRegionsHierarchy](./getregionshierarchy/)() | Returns a full hierarchy of regions (with fields) available in the document.  |
| void [set_CleanupOptions](./set_cleanupoptions/)(Aspose::Words::MailMerging::MailMergeCleanupOptions) | Sets a set of flags that specify what items should be removed during mail merge.  |
| void [set_CleanupParagraphsWithPunctuationMarks](./set_cleanupparagraphswithpunctuationmarks/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_CleanupParagraphsWithPunctuationMarks.  |
| void [set_FieldMergingCallback](./set_fieldmergingcallback/)(const System::SharedPtr< Aspose::Words::MailMerging::IFieldMergingCallback > &) | Setter for Aspose::Words::MailMerging::MailMerge::get_FieldMergingCallback.  |
| void [set_MailMergeCallback](./set_mailmergecallback/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeCallback > &) | Allows to handle particular events during mail merge.  |
| void [set_MergeDuplicateRegions](./set_mergeduplicateregions/)(bool) | Sets a value indicating whether all of the document mail merge regions with the name of a data source should be merged while executing of a mail merge with regions against the data source or just the first one.  |
| void [set_MergeWholeDocument](./set_mergewholedocument/)(bool) | Sets a value indicating whether fields in whole document are updated while executing of a mail merge with regions.  |
| void [set_PreserveUnusedTags](./set_preserveunusedtags/)(bool) | Sets a value indicating whether the unused "mustache" tags should be preserved.  |
| void [set_RegionEndTag](./set_regionendtag/)(const System::String &) | Setter for Aspose::Words::MailMerging::MailMerge::get_RegionEndTag.  |
| void [set_RegionStartTag](./set_regionstarttag/)(const System::String &) | Setter for Aspose::Words::MailMerging::MailMerge::get_RegionStartTag.  |
| void [set_RestartListsAtEachSection](./set_restartlistsateachsection/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_RestartListsAtEachSection.  |
| void [set_RetainFirstSectionStart](./set_retainfirstsectionstart/)(bool) | Sets a value indicating whether the SectionStart of the first document section and its copies for subsequent data source rows are retained during mail merge or updated according to MS Word behaviour.  |
| void [set_TrimWhitespaces](./set_trimwhitespaces/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_TrimWhitespaces.  |
| void [set_UnconditionalMergeFieldsAndRegions](./set_unconditionalmergefieldsandregions/)(bool) | Sets a value indicating whether merge fields and merge regions are merged regardless of the parent IF field's condition.  |
| void [set_UseNonMergeFields](./set_usenonmergefields/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_UseNonMergeFields.  |
| void [set_UseWholeParagraphAsRegion](./set_usewholeparagraphasregion/)(bool) | Sets a value indicating whether whole paragraph with TableStart or TableEnd field or particular range between TableStart and TableEnd fields should be included into mail merge region.  |
