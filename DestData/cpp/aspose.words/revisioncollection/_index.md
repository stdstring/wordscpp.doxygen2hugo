---
title: RevisionCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of Revision objects that represent revisions in the document. 
type: docs
weight: 0
url: /cpp/aspose.words/revisioncollection/
---
## RevisionCollection class


A collection of Revision objects that represent revisions in the document. 

## Methods

| Method | Description |
| --- | --- |
| void [AcceptAll](./acceptall/)() | Accepts all revisions in this collection.  |
| int32_t [get_Count](./get_count/)() | Returns the number of revisions in the collection.  |
| System::SharedPtr< Aspose::Words::RevisionGroupCollection > [get_Groups](./get_groups/)() | Collection of revision groups.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Revision > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object.  |
| System::SharedPtr< Aspose::Words::Revision > [idx_get](./idx_get/)(int32_t) | Returns a Revision at the specified index.  |
| void [RejectAll](./rejectall/)() | Rejects all revisions in this collection.  |
