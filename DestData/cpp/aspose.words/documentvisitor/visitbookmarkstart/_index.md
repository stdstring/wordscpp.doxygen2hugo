---
title: Aspose::Words::DocumentVisitor::VisitBookmarkStart method
linktitle: VisitBookmarkStart
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::DocumentVisitor::VisitBookmarkStart method. Called when a start of a bookmark is encountered in the document in C++.'
type: docs
weight: 500
url: /cpp/aspose.words/documentvisitor/visitbookmarkstart/
---
## DocumentVisitor::VisitBookmarkStart method


Called when a start of a bookmark is encountered in the document.

```cpp
virtual Aspose::Words::VisitorAction Aspose::Words::DocumentVisitor::VisitBookmarkStart(System::SharedPtr<Aspose::Words::BookmarkStart> bookmarkStart)
```


| Parameter | Type | Description |
| --- | --- | --- |
| bookmarkStart | System::SharedPtr\<Aspose::Words::BookmarkStart\> | The object that is being visited. |

### ReturnValue

A [VisitorAction](../../visitoraction/) value that specifies how to continue the enumeration.

## Examples



Shows how to add bookmarks and update their contents. 
```cpp
void CreateUpdateAndPrintBookmarks()
{
    // Create a document with three bookmarks, then use a custom document visitor implementation to print their contents.
    SharedPtr<Document> doc = CreateDocumentWithBookmarks(3);
    SharedPtr<BookmarkCollection> bookmarks = doc->get_Range()->get_Bookmarks();

    PrintAllBookmarkInfo(bookmarks);

    // Bookmarks can be accessed in the bookmark collection by index or name, and their names can be updated.
    bookmarks->idx_get(0)->set_Name(String::Format(u"{0}_NewName", bookmarks->idx_get(0)->get_Name()));
    bookmarks->idx_get(u"MyBookmark_2")->set_Text(String::Format(u"Updated text contents of {0}", bookmarks->idx_get(1)->get_Name()));

    // Print all bookmarks again to see updated values.
    PrintAllBookmarkInfo(bookmarks);
}

static SharedPtr<Document> CreateDocumentWithBookmarks(int numberOfBookmarks)
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    for (int i = 1; i <= numberOfBookmarks; i++)
    {
        String bookmarkName = String(u"MyBookmark_") + i;

        builder->Write(u"Text before bookmark.");
        builder->StartBookmark(bookmarkName);
        builder->Write(String::Format(u"Text inside {0}.", bookmarkName));
        builder->EndBookmark(bookmarkName);
        builder->Writeln(u"Text after bookmark.");
    }

    return doc;
}

static void PrintAllBookmarkInfo(SharedPtr<BookmarkCollection> bookmarks)
{
    auto bookmarkVisitor = MakeObject<ExBookmarks::BookmarkInfoPrinter>();

    // Get each bookmark in the collection to accept a visitor that will print its contents.
    {
        SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<Bookmark>>> enumerator = bookmarks->GetEnumerator();
        while (enumerator->MoveNext())
        {
            SharedPtr<Bookmark> currentBookmark = enumerator->get_Current();

            if (currentBookmark != nullptr)
            {
                currentBookmark->get_BookmarkStart()->Accept(bookmarkVisitor);
                currentBookmark->get_BookmarkEnd()->Accept(bookmarkVisitor);

                std::cout << currentBookmark->get_BookmarkStart()->GetText() << std::endl;
            }
        }
    }
}

class BookmarkInfoPrinter : public DocumentVisitor
{
public:
    VisitorAction VisitBookmarkStart(SharedPtr<BookmarkStart> bookmarkStart) override
    {
        std::cout << "BookmarkStart name: \"" << bookmarkStart->get_Name() << "\", Contents: \"" << bookmarkStart->get_Bookmark()->get_Text() << "\""
                  << std::endl;
        return VisitorAction::Continue;
    }

    VisitorAction VisitBookmarkEnd(SharedPtr<BookmarkEnd> bookmarkEnd) override
    {
        std::cout << "BookmarkEnd name: \"" << bookmarkEnd->get_Name() << "\"" << std::endl;
        return VisitorAction::Continue;
    }
};
```

## See Also

* Enum [VisitorAction](../../visitoraction/)
* Class [BookmarkStart](../../bookmarkstart/)
* Class [DocumentVisitor](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
