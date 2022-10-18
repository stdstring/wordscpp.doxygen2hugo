---
title: StructuredDocumentTagRangeStart
second_title: Aspose.Words for C++ API Reference
description: Initializes a new instance of the Structured document tag range start class. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/structureddocumenttagrangestart/structureddocumenttagrangestart/
---
## StructuredDocumentTagRangeStart.StructuredDocumentTagRangeStart method


Initializes a new instance of the **Structured document tag range start** class.

```cpp
Aspose::Words::Markup::StructuredDocumentTagRangeStart::StructuredDocumentTagRangeStart(const System::SharedPtr<Aspose::Words::DocumentBase> &doc, Aspose::Words::Markup::SdtType type)
```


| Parameter | Type | Description |
| --- | --- | --- |
| doc | `-` | The owner document. |
| type | `-` | Type of SDT node. |

The following types of SDT can be created:

* **Checkbox**
* **DropDownList**
* **ComboBox**
* **Date**
* **BuildingBlockGallery**
* **Group**
* **Picture**
* **RichText**
* **PlainText**



## Examples




Shows how to create/remove structured document tag and its content. 
```cpp
void SdtRangeExtendedMethods()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    builder->Writeln(u"StructuredDocumentTag element");

    SharedPtr<StructuredDocumentTagRangeStart> rangeStart;
    InsertStructuredDocumentTagRanges(doc, rangeStart);

    // Removes ranged structured document tag, but keeps content inside.
    rangeStart->RemoveSelfOnly();

    rangeStart = System::DynamicCast<StructuredDocumentTagRangeStart>(doc->GetChild(NodeType::StructuredDocumentTagRangeStart, 0, false));
    ASPOSE_ASSERT_EQ(nullptr, rangeStart);

    auto rangeEnd = System::DynamicCast<StructuredDocumentTagRangeEnd>(doc->GetChild(NodeType::StructuredDocumentTagRangeEnd, 0, false));

    ASPOSE_ASSERT_EQ(nullptr, rangeEnd);
    ASSERT_EQ(u"StructuredDocumentTag element", doc->GetText().Trim());

    InsertStructuredDocumentTagRanges(doc, rangeStart);

    SharedPtr<Node> paragraphNode = rangeStart->LINQ_LastOrDefault();
    ASPOSE_ASSERT_EQ(u"StructuredDocumentTag element",
                     paragraphNode != nullptr ? System::ObjectExt::Box<String>(paragraphNode->GetText().Trim()) : nullptr);

    // Removes ranged structured document tag and content inside.
    rangeStart->RemoveAllChildren();

    paragraphNode = rangeStart->LINQ_LastOrDefault();
    ASPOSE_ASSERT_EQ(nullptr, paragraphNode != nullptr ? System::ObjectExt::Box<String>(paragraphNode->GetText()) : nullptr);
}

void InsertStructuredDocumentTagRanges(SharedPtr<Document> doc, SharedPtr<StructuredDocumentTagRangeStart>& rangeStart)
{
    rangeStart = MakeObject<StructuredDocumentTagRangeStart>(doc, SdtType::PlainText);
    auto rangeEnd = MakeObject<StructuredDocumentTagRangeEnd>(doc, rangeStart->get_Id());

    doc->get_FirstSection()->get_Body()->InsertBefore(rangeStart, doc->get_FirstSection()->get_Body()->get_FirstParagraph());
    doc->get_LastSection()->get_Body()->InsertAfter(rangeEnd, doc->get_FirstSection()->get_Body()->get_FirstParagraph());
}
```

