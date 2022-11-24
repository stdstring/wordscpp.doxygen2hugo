---
title: After
second_title: Aspose.Words for C++ API Reference
description: Gets a first tab stop to the right of the specified position.
type: docs
weight: 14
url: /cpp/aspose.words/tabstopcollection/after/
---
## TabStopCollection::After method


Gets a first tab stop to the right of the specified position.

```cpp
System::SharedPtr<Aspose::Words::TabStop> Aspose::Words::TabStopCollection::After(double position)
```


| Parameter | Type | Description |
| --- | --- | --- |
| position | double | The reference position (in points). |

### ReturnValue

A tab stop object or null if a suitable tab stop was not found.
## Remarks


Skips tab stops with **Alignment** set to **TabAlignment.Bar**.

## Examples



Shows how to work with a document's collection of tab stops. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<TabStopCollection> tabStops = builder->get_ParagraphFormat()->get_TabStops();

// 72 points is one "inch" on the Microsoft Word tab stop ruler.
tabStops->Add(MakeObject<TabStop>(72.0));
tabStops->Add(MakeObject<TabStop>(432.0, TabAlignment::Right, TabLeader::Dashes));

ASSERT_EQ(2, tabStops->get_Count());
ASSERT_FALSE(tabStops->idx_get(0)->get_IsClear());
ASSERT_FALSE(System::ObjectExt::Equals(tabStops->idx_get(0), tabStops->idx_get(1)));

// Every "tab" character takes the builder's cursor to the location of the next tab stop.
builder->Writeln(u"Start\tTab 1\tTab 2");

SharedPtr<ParagraphCollection> paragraphs = doc->get_FirstSection()->get_Body()->get_Paragraphs();

ASSERT_EQ(2, paragraphs->get_Count());

// Each paragraph gets its tab stop collection, which clones its values from the document builder's tab stop collection.
ASPOSE_ASSERT_EQ(paragraphs->idx_get(0)->get_ParagraphFormat()->get_TabStops(), paragraphs->idx_get(1)->get_ParagraphFormat()->get_TabStops());
ASPOSE_ASSERT_NS(paragraphs->idx_get(0)->get_ParagraphFormat()->get_TabStops(), paragraphs->idx_get(1)->get_ParagraphFormat()->get_TabStops());

// A tab stop collection can point us to TabStops before and after certain positions.
ASPOSE_ASSERT_EQ(72.0, tabStops->Before(100.0)->get_Position());
ASPOSE_ASSERT_EQ(432.0, tabStops->After(100.0)->get_Position());

// We can clear a paragraph's tab stop collection to revert to the default tabbing behavior.
paragraphs->idx_get(1)->get_ParagraphFormat()->get_TabStops()->Clear();

ASSERT_EQ(0, paragraphs->idx_get(1)->get_ParagraphFormat()->get_TabStops()->get_Count());

doc->Save(ArtifactsDir + u"TabStopCollection.TabStopCollection.docx");
```

