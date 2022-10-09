---
title: MailMerge
second_title: Aspose.Words for C++ API Reference
description: Represents the mail merge functionality. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/mailmerge/
---

Represents the mail merge functionality. 

## Methods

| Method | Description |
| --- | --- |
| [DeleteFields](./deletefields/)() | Removes mail merge related fields from the document.  |
| [Execute](./execute/)(const System::ArrayPtr< System::String > &, const System::ArrayPtr< System::SharedPtr< System::Object > > &) | Performs a mail merge operation for a single record.  |
| [Execute](./execute/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeDataSource > &) | Performs a mail merge from a custom data source.  |
| [ExecuteWithRegions](./executewithregions/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeDataSource > &) | Performs a mail merge from a custom data source with mail merge regions.  |
| [ExecuteWithRegions](./executewithregions/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeDataSourceRoot > &) | Performs a mail merge from a custom data source with mail merge regions.  |
| [get_CleanupOptions](./get_cleanupoptions/)() const | Gets a set of flags that specify what items should be removed during mail merge.  |
| [get_CleanupParagraphsWithPunctuationMarks](./get_cleanupparagraphswithpunctuationmarks/)() const | Gets or sets a value indicating whether paragraphs with punctuation marks are considered as empty and should be removed if the RemoveEmptyParagraphs option is specified.  |
| [get_FieldMergingCallback](./get_fieldmergingcallback/)() const | Occurs during mail merge when a mail merge field is encountered in the document.  |
| [get_MailMergeCallback](./get_mailmergecallback/)() const | Allows to handle particular events during mail merge.  |
| [get_MappedDataFields](./get_mappeddatafields/)() | Returns a collection that represents mapped data fields for the mail merge operation.  |
| [get_MergeDuplicateRegions](./get_mergeduplicateregions/)() const | Gets a value indicating whether all of the document mail merge regions with the name of a data source should be merged while executing of a mail merge with regions against the data source or just the first one.  |
| [get_MergeWholeDocument](./get_mergewholedocument/)() const | Gets a value indicating whether fields in whole document are updated while executing of a mail merge with regions.  |
| [get_PreserveUnusedTags](./get_preserveunusedtags/)() const | Gets a value indicating whether the unused "mustache" tags should be preserved.  |
| [get_RegionEndTag](./get_regionendtag/)() const | Gets or sets a mail merge region end tag.  |
| [get_RegionStartTag](./get_regionstarttag/)() const | Gets or sets a mail merge region start tag.  |
| [get_RestartListsAtEachSection](./get_restartlistsateachsection/)() const | Gets or sets a value indicating whether lists are restarted at each section after executing of a mail merge.  |
| [get_RetainFirstSectionStart](./get_retainfirstsectionstart/)() const | Gets a value indicating whether the SectionStart of the first document section and its copies for subsequent data source rows are retained during mail merge or updated according to MS Word behaviour.  |
| [get_TrimWhitespaces](./get_trimwhitespaces/)() const | Gets or sets a value indicating whether trailing and leading whitespaces are trimmed from mail merge values.  |
| [get_UnconditionalMergeFieldsAndRegions](./get_unconditionalmergefieldsandregions/)() const | Gets a value indicating whether merge fields and merge regions are merged regardless of the parent IF field's condition.  |
| [get_UseNonMergeFields](./get_usenonmergefields/)() const | When true, specifies that in addition to MERGEFIELD fields, mail merge is performed into some other types of fields and also into "{{fieldName}}" tags.  |
| [get_UseWholeParagraphAsRegion](./get_usewholeparagraphasregion/)() const | Gets a value indicating whether whole paragraph with TableStart or TableEnd field or particular range between TableStart and TableEnd fields should be included into mail merge region.  |
| [GetFieldNames](./getfieldnames/)() | Returns a collection of mail merge field names available in the document.  |
| [GetFieldNamesForRegion](./getfieldnamesforregion/)(const System::String &) | Returns a collection of mail merge field names available in the region.  |
| [GetFieldNamesForRegion](./getfieldnamesforregion/)(const System::String &, int32_t) | Returns a collection of mail merge field names available in the region.  |
| [GetRegionsByName](./getregionsbyname/)(const System::String &) | Returns a collection of mail merge regions with the specified name.  |
| [GetRegionsHierarchy](./getregionshierarchy/)() | Returns a full hierarchy of regions (with fields) available in the document.  |
| [set_CleanupOptions](./set_cleanupoptions/)(Aspose::Words::MailMerging::MailMergeCleanupOptions) | Sets a set of flags that specify what items should be removed during mail merge.  |
| [set_CleanupParagraphsWithPunctuationMarks](./set_cleanupparagraphswithpunctuationmarks/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_CleanupParagraphsWithPunctuationMarks.  |
| [set_FieldMergingCallback](./set_fieldmergingcallback/)(const System::SharedPtr< Aspose::Words::MailMerging::IFieldMergingCallback > &) | Setter for Aspose::Words::MailMerging::MailMerge::get_FieldMergingCallback.  |
| [set_MailMergeCallback](./set_mailmergecallback/)(const System::SharedPtr< Aspose::Words::MailMerging::IMailMergeCallback > &) | Allows to handle particular events during mail merge.  |
| [set_MergeDuplicateRegions](./set_mergeduplicateregions/)(bool) | Sets a value indicating whether all of the document mail merge regions with the name of a data source should be merged while executing of a mail merge with regions against the data source or just the first one.  |
| [set_MergeWholeDocument](./set_mergewholedocument/)(bool) | Sets a value indicating whether fields in whole document are updated while executing of a mail merge with regions.  |
| [set_PreserveUnusedTags](./set_preserveunusedtags/)(bool) | Sets a value indicating whether the unused "mustache" tags should be preserved.  |
| [set_RegionEndTag](./set_regionendtag/)(const System::String &) | Setter for Aspose::Words::MailMerging::MailMerge::get_RegionEndTag.  |
| [set_RegionStartTag](./set_regionstarttag/)(const System::String &) | Setter for Aspose::Words::MailMerging::MailMerge::get_RegionStartTag.  |
| [set_RestartListsAtEachSection](./set_restartlistsateachsection/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_RestartListsAtEachSection.  |
| [set_RetainFirstSectionStart](./set_retainfirstsectionstart/)(bool) | Sets a value indicating whether the SectionStart of the first document section and its copies for subsequent data source rows are retained during mail merge or updated according to MS Word behaviour.  |
| [set_TrimWhitespaces](./set_trimwhitespaces/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_TrimWhitespaces.  |
| [set_UnconditionalMergeFieldsAndRegions](./set_unconditionalmergefieldsandregions/)(bool) | Sets a value indicating whether merge fields and merge regions are merged regardless of the parent IF field's condition.  |
| [set_UseNonMergeFields](./set_usenonmergefields/)(bool) | Setter for Aspose::Words::MailMerging::MailMerge::get_UseNonMergeFields.  |
| [set_UseWholeParagraphAsRegion](./set_usewholeparagraphasregion/)(bool) | Sets a value indicating whether whole paragraph with TableStart or TableEnd field or particular range between TableStart and TableEnd fields should be included into mail merge region.  |
