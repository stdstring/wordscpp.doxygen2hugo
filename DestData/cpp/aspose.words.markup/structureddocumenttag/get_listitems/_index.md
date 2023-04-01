---
title: Aspose::Words::Markup::StructuredDocumentTag::get_ListItems method
linktitle: get_ListItems
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Markup::StructuredDocumentTag::get_ListItems method. Gets SdtListItemCollection associated with this SDT in C++.'
type: docs
weight: 2000
url: /cpp/aspose.words.markup/structureddocumenttag/get_listitems/
---
## StructuredDocumentTag::get_ListItems method


Gets [SdtListItemCollection](../../sdtlistitemcollection/) associated with this **SDT**.

```cpp
System::SharedPtr<Aspose::Words::Markup::SdtListItemCollection> Aspose::Words::Markup::StructuredDocumentTag::get_ListItems()
```

## Remarks


Accessing this property will only work for [ComboBox](../../sdttype/) or [DropDownList](../../sdttype/) SDT types.

For all other SDT types exception will occur.

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

* Class [SdtListItemCollection](../../sdtlistitemcollection/)
* Class [StructuredDocumentTag](../)
* Namespace [Aspose::Words::Markup](../../)
* Library [Aspose.Words for C++](../../../)
