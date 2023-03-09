---
title: Aspose::Words::Saving::OutlineOptions::get_BookmarksOutlineLevels method
linktitle: get_BookmarksOutlineLevels
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Saving::OutlineOptions::get_BookmarksOutlineLevels method. Allows to specify individual bookmarks outline level in C++.
type: docs
weight: 14
url: /cpp/aspose.words.saving/outlineoptions/get_bookmarksoutlinelevels/
---
## OutlineOptions::get_BookmarksOutlineLevels method


Allows to specify individual bookmarks outline level.

```cpp
System::SharedPtr<Aspose::Words::Saving::BookmarksOutlineLevelCollection> Aspose::Words::Saving::OutlineOptions::get_BookmarksOutlineLevels() const
```

## Remarks


If bookmark level is not specified in this collection then [DefaultBookmarksOutlineLevel](../get_defaultbookmarksoutlinelevel/) value is used.

## Examples



Shows how to set outline levels for bookmarks. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a bookmark with another bookmark nested inside it.
builder->StartBookmark(u"Bookmark 1");
builder->Writeln(u"Text inside Bookmark 1.");

builder->StartBookmark(u"Bookmark 2");
builder->Writeln(u"Text inside Bookmark 1 and 2.");
builder->EndBookmark(u"Bookmark 2");

builder->Writeln(u"Text inside Bookmark 1.");
builder->EndBookmark(u"Bookmark 1");

// Insert another bookmark.
builder->StartBookmark(u"Bookmark 3");
builder->Writeln(u"Text inside Bookmark 3.");
builder->EndBookmark(u"Bookmark 3");

// When saving to .pdf, bookmarks can be accessed via a drop-down menu and used as anchors by most readers.
// Bookmarks can also have numeric values for outline levels,
// enabling lower level outline entries to hide higher-level child entries when collapsed in the reader.
auto pdfSaveOptions = MakeObject<PdfSaveOptions>();
SharedPtr<BookmarksOutlineLevelCollection> outlineLevels = pdfSaveOptions->get_OutlineOptions()->get_BookmarksOutlineLevels();

outlineLevels->Add(u"Bookmark 1", 1);
outlineLevels->Add(u"Bookmark 2", 2);
outlineLevels->Add(u"Bookmark 3", 3);

ASSERT_EQ(3, outlineLevels->get_Count());
ASSERT_TRUE(outlineLevels->Contains(u"Bookmark 1"));
ASSERT_EQ(1, outlineLevels->idx_get(0));
ASSERT_EQ(2, outlineLevels->idx_get(u"Bookmark 2"));
ASSERT_EQ(2, outlineLevels->IndexOfKey(u"Bookmark 3"));

// We can remove two elements so that only the outline level designation for "Bookmark 1" is left.
outlineLevels->RemoveAt(2);
outlineLevels->Remove(u"Bookmark 2");

// There are nine outline levels. Their numbering will be optimized during the save operation.
// In this case, levels "5" and "9" will become "2" and "3".
outlineLevels->Add(u"Bookmark 2", 5);
outlineLevels->Add(u"Bookmark 3", 9);

doc->Save(ArtifactsDir + u"BookmarksOutlineLevelCollection.BookmarkLevels.pdf", pdfSaveOptions);

// Emptying this collection will preserve the bookmarks and put them all on the same outline level.
outlineLevels->Clear();
```

## See Also

* Class [BookmarksOutlineLevelCollection](../../bookmarksoutlinelevelcollection/)
* Class [OutlineOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
