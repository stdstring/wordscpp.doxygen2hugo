---
title: BookmarkCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of Bookmark objects that represent the bookmarks in the specified range. 
type: docs
weight: 0
url: /cpp/aspose.words/bookmarkcollection/
---
## BookmarkCollection class


A collection of Bookmark objects that represent the bookmarks in the specified range. 

## Methods

| Method | Description |
| --- | --- |
| void [Clear](./clear/)() | Removes all bookmarks from this collection and from the document.  |
| int32_t [get_Count](./get_count/)() | Returns the number of bookmarks in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Bookmark > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object.  |
| System::SharedPtr< Aspose::Words::Bookmark > [idx_get](./idx_get/)(const System::String &) | Returns a bookmark by name.  |
| System::SharedPtr< Aspose::Words::Bookmark > [idx_get](./idx_get/)(int32_t) | Returns a bookmark at the specified index.  |
| void [Remove](./remove/)(const System::SharedPtr< Aspose::Words::Bookmark > &) | Removes the specified bookmark from the document.  |
| void [Remove](./remove/)(const System::String &) | Removes a bookmark with the specified name.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a bookmark at the specified index.  |
