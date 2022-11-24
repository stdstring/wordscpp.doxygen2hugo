---
title: InsertParagraph
second_title: Aspose.Words for C++ API Reference
description: Inserts a paragraph break into the document.
type: docs
weight: 534
url: /cpp/aspose.words/documentbuilder/insertparagraph/
---
## DocumentBuilder::InsertParagraph method


Inserts a paragraph break into the document.

```cpp
System::SharedPtr<Aspose::Words::Paragraph> Aspose::Words::DocumentBuilder::InsertParagraph()
```


### ReturnValue

The paragraph node that was just inserted. It is the same node as [CurrentParagraph](../get_currentparagraph/).
## Remarks


Current paragraph formatting specified by the [ParagraphFormat](../get_paragraphformat/) property is used.

Breaks the current paragraph in two. After inserting the paragraph, the cursor is placed at the beginning of the new paragraph.

## Examples



Shows how to insert a paragraph into the document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Font> font = builder->get_Font();
font->set_Size(16);
font->set_Bold(true);
font->set_Color(System::Drawing::Color::get_Blue());
font->set_Name(u"Arial");
font->set_Underline(Underline::Dash);

SharedPtr<ParagraphFormat> paragraphFormat = builder->get_ParagraphFormat();
paragraphFormat->set_FirstLineIndent(8);
paragraphFormat->set_Alignment(ParagraphAlignment::Justify);
paragraphFormat->set_AddSpaceBetweenFarEastAndAlpha(true);
paragraphFormat->set_AddSpaceBetweenFarEastAndDigit(true);
paragraphFormat->set_KeepTogether(true);

// The "Writeln" method ends the paragraph after appending text
// and then starts a new line, adding a new paragraph.
builder->Writeln(u"Hello world!");

ASSERT_TRUE(builder->get_CurrentParagraph()->get_IsEndOfDocument());
```

