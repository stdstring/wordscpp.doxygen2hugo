---
title: Aspose::Words::Drawing::LayoutFlow enum
linktitle: LayoutFlow
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Drawing::LayoutFlow enum. Determines the flow of the text layout in a textbox in C++.'
type: docs
weight: 3000
url: /cpp/aspose.words.drawing/layoutflow/
---
## LayoutFlow enum


Determines the flow of the text layout in a textbox.

```cpp
enum class LayoutFlow
```

### Values

| Name | Value | Description |
| --- | --- | --- |
| Horizontal | 0 | Text is displayed horizontally. |
| TopToBottomIdeographic | 1 | Ideographic text is displayed vertically. |
| BottomToTop | 2 | Text is displayed vertically. |
| TopToBottom | 3 | Text is displayed vertically. |
| HorizontalIdeographic | 4 | Ideographic text is displayed horizontally. |
| Vertical | 5 | Text is displayed vertically. |


## Examples



Shows how to add text to a text box, and change its orientation 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

auto textbox = MakeObject<Shape>(doc, ShapeType::TextBox);
textbox->set_Width(100);
textbox->set_Height(100);
textbox->get_TextBox()->set_LayoutFlow(LayoutFlow::BottomToTop);

textbox->AppendChild(MakeObject<Paragraph>(doc));
builder->InsertNode(textbox);

builder->MoveTo(textbox->get_FirstParagraph());
builder->Write(u"This text is flipped 90 degrees to the left.");

doc->Save(ArtifactsDir + u"Drawing.TextBox.docx");
```

## See Also

* Namespace [Aspose::Words::Drawing](../)
* Library [Aspose.Words for C++](../../)
