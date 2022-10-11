---
title: Bookmark
second_title: Aspose.Words for C++ API Reference
description: Represents a single bookmark. 
type: docs
weight: 0
url: /cpp/aspose.words/bookmark/
---
## Bookmark class


Represents a single bookmark. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::BookmarkEnd > [get_BookmarkEnd](./get_bookmarkend/)() | Gets the node that represents the end of the bookmark.  |
| System::SharedPtr< Aspose::Words::BookmarkStart > [get_BookmarkStart](./get_bookmarkstart/)() const | Gets the node that represents the start of the bookmark.  |
| int32_t [get_FirstColumn](./get_firstcolumn/)() | Gets the zero-based index of the first column of the table column range associated with the bookmark.  |
| bool [get_IsColumn](./get_iscolumn/)() | Returns **true** if this bookmark is a table column bookmark.  |
| int32_t [get_LastColumn](./get_lastcolumn/)() | Gets the zero-based index of the last column of the table column range associated with the bookmark.  |
| System::String [get_Name](./get_name/)() | Gets or sets the name of the bookmark.  |
| System::String [get_Text](./get_text/)() | Gets or sets the text enclosed in the bookmark.  |
| void [Remove](./remove/)() | Removes the bookmark from the document. Does not remove text inside the bookmark.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Bookmark::get_Name.  |
| void [set_Text](./set_text/)(const System::String &) | Setter for Aspose::Words::Bookmark::get_Text.  |
