---
title: MailMergeRegionInfo
second_title: Aspose.Words for C++ API Reference
description: Contains information about a mail merge region. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/mailmergeregioninfo/
---
## MailMergeRegionInfo class


Contains information about a mail merge region. 

## Methods

| Method | Description |
| --- | --- |
| const System::SharedPtr< Aspose::Words::Fields::FieldMergeField > & [get_EndField](./get_endfield/)() const | Returns an end field for the region.  |
| System::SharedPtr< System::Collections::Generic::IList< System::SharedPtr< Aspose::Words::Fields::Field > > > [get_Fields](./get_fields/)() const | Returns a list of child fields.  |
| int32_t [get_Level](./get_level/)() const | Returns the nesting level for the region.  |
| System::String [get_Name](./get_name/)() const | Returns the name of region.  |
| const System::SharedPtr< Aspose::Words::MailMerging::MailMergeRegionInfo > & [get_ParentRegion](./get_parentregion/)() const | Returns parent region info (null for top-level region).  |
| System::SharedPtr< System::Collections::Generic::IList< System::SharedPtr< Aspose::Words::MailMerging::MailMergeRegionInfo > > > [get_Regions](./get_regions/)() const | Returns a list of child regions.  |
| const System::SharedPtr< Aspose::Words::Fields::FieldMergeField > & [get_StartField](./get_startfield/)() const | Returns a start field for the region.  |
