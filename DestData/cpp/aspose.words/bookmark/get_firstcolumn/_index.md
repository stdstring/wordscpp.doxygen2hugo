---
title: get_FirstColumn
second_title: Aspose.Words for C++ API Reference
description: Gets the zero-based index of the first column of the table column range associated with the bookmark. 
type: docs
weight: 27
url: /cpp/aspose.words/bookmark/get_firstcolumn/
---
## Bookmark.get_FirstColumn method


Gets the zero-based index of the first column of the table column range associated with the bookmark.

```cpp
int32_t Aspose::Words::Bookmark::get_FirstColumn()
```


## Examples




Shows how to get information about table column bookmarks. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Table column bookmarks.doc");

for (const auto& bookmark : System::IterateOver(doc->get_Range()->get_Bookmarks()))
{
    // If a bookmark encloses columns of a table, it is a table column bookmark, and its IsColumn flag set to true.
    std::cout << "Bookmark: " << bookmark->get_Name() << (bookmark->get_IsColumn() ? String(u" (Column)") : String(u"")) << std::endl;
    if (bookmark->get_IsColumn())
    {
        auto row = System::DynamicCast_noexcept<Row>(bookmark->get_BookmarkStart()->GetAncestor(NodeType::Row));
        if (row != nullptr && bookmark->get_FirstColumn() < row->get_Cells()->get_Count())
        {
            // Print the contents of the first and last columns enclosed by the bookmark.
            std::cout << row->get_Cells()->idx_get(bookmark->get_FirstColumn())->GetText().TrimEnd(MakeArray<char16_t>({ControlChar::CellChar}))
                      << std::endl;
            std::cout << row->get_Cells()->idx_get(bookmark->get_LastColumn())->GetText().TrimEnd(MakeArray<char16_t>({ControlChar::CellChar}))
                      << std::endl;
        }
    }
}
```

