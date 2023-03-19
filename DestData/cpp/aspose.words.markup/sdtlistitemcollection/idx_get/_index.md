---
title: Aspose::Words::Markup::SdtListItemCollection::idx_get method
linktitle: idx_get
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Markup::SdtListItemCollection::idx_get method. Returns a SdtListItem object given its zero-based index in the collection in C++.
type: docs
weight: 1000
url: /cpp/aspose.words.markup/sdtlistitemcollection/idx_get/
---
## SdtListItemCollection::idx_get method


Returns a [SdtListItem](../../sdtlistitem/) object given its zero-based index in the collection.

```cpp
System::SharedPtr<Aspose::Words::Markup::SdtListItem> Aspose::Words::Markup::SdtListItemCollection::idx_get(int32_t index)
```


## Examples



Shows how to work with drop down-list structured document tags. 
```cpp
auto doc = MakeObject<Document>();
auto tag = MakeObject<StructuredDocumentTag>(doc, SdtType::DropDownList, MarkupLevel::Block);
doc->get_FirstSection()->get_Body()->AppendChild(tag);

// A drop-down list structured document tag is a form that allows the user to
// select an option from a list by left-clicking and opening the form in Microsoft Word.
// The "ListItems" property contains all list items, and each list item is an "SdtListItem".
SharedPtr<SdtListItemCollection> listItems = tag->get_ListItems();
listItems->Add(MakeObject<SdtListItem>(u"Value 1"));

ASSERT_EQ(listItems->idx_get(0)->get_DisplayText(), listItems->idx_get(0)->get_Value());

// Add 3 more list items. Initialize these items using a different constructor to the first item
// to display strings that are different from their values.
listItems->Add(MakeObject<SdtListItem>(u"Item 2", u"Value 2"));
listItems->Add(MakeObject<SdtListItem>(u"Item 3", u"Value 3"));
listItems->Add(MakeObject<SdtListItem>(u"Item 4", u"Value 4"));

ASSERT_EQ(4, listItems->get_Count());

// The drop-down list is displaying the first item. Assign a different list item to the "SelectedValue" to display it.
listItems->set_SelectedValue(listItems->idx_get(3));

ASSERT_EQ(u"Value 4", listItems->get_SelectedValue()->get_Value());

// Enumerate over the collection and print each element.
{
    SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<SdtListItem>>> enumerator = listItems->GetEnumerator();
    while (enumerator->MoveNext())
    {
        if (enumerator->get_Current() != nullptr)
        {
            std::cout << "List item: " << enumerator->get_Current()->get_DisplayText() << ", value: " << enumerator->get_Current()->get_Value()
                      << std::endl;
        }
    }
}

// Remove the last list item.
listItems->RemoveAt(3);

ASSERT_EQ(3, listItems->get_Count());

// Since our drop-down control is set to display the removed item by default, give it an item to display which exists.
listItems->set_SelectedValue(listItems->idx_get(1));

doc->Save(ArtifactsDir + u"StructuredDocumentTag.ListItemCollection.docx");

// Use the "Clear" method to empty the entire drop-down item collection at once.
listItems->Clear();

ASSERT_EQ(0, listItems->get_Count());
```

## See Also

* Class [SdtListItem](../../sdtlistitem/)
* Class [SdtListItemCollection](../)
* Namespace [Aspose::Words::Markup](../../)
* Library [Aspose.Words for C++](../../../)
