---
title: Aspose::Words::WebExtensions::BaseWebExtensionCollection::idx_set method
linktitle: idx_set
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::WebExtensions::BaseWebExtensionCollection::idx_set method. Gets or sets an item at the specified index in C++.
type: docs
weight: 1100
url: /cpp/aspose.words.webextensions/basewebextensioncollection/idx_set/
---
## BaseWebExtensionCollection::idx_set method


Gets or sets an item at the specified index.

```cpp
void Aspose::Words::WebExtensions::BaseWebExtensionCollection<T>::idx_set(int32_t index, T value)
```


| Parameter | Type | Description |
| --- | --- | --- |
| index | int32_t | Zero-based index of the item. |

## Examples



Shows how to work with a document's collection of web extensions. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Web extension.docx");

ASSERT_EQ(1, doc->get_WebExtensionTaskPanes()->get_Count());

// Print all properties of the document's web extension.
SharedPtr<WebExtensionPropertyCollection> webExtensionPropertyCollection =
    doc->get_WebExtensionTaskPanes()->idx_get(0)->get_WebExtension()->get_Properties();
{
    SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<WebExtensionProperty>>> enumerator = webExtensionPropertyCollection->GetEnumerator();
    while (enumerator->MoveNext())
    {
        SharedPtr<WebExtensionProperty> webExtensionProperty = enumerator->get_Current();
        std::cout << "Binding name: " << webExtensionProperty->get_Name() << "; Binding value: " << webExtensionProperty->get_Value() << std::endl;
    }
}

// Remove the web extension.
doc->get_WebExtensionTaskPanes()->Remove(0);

ASSERT_EQ(0, doc->get_WebExtensionTaskPanes()->get_Count());
```

## See Also

* Class [BaseWebExtensionCollection](../)
* Namespace [Aspose::Words::WebExtensions](../../)
* Library [Aspose.Words for C++](../../../)
