---
title: Aspose::Words::Font::get_Subscript method
linktitle: get_Subscript
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Font::get_Subscript method. True if the font is formatted as subscript in C++.
type: docs
weight: 560
url: /cpp/aspose.words/font/get_subscript/
---
## Font::get_Subscript method


True if the font is formatted as subscript.

```cpp
bool Aspose::Words::Font::get_Subscript()
```


## Examples



Shows how to format text to offset its position. 
```cpp
auto doc = MakeObject<Document>();
auto para = System::DynamicCast<Paragraph>(doc->GetChild(NodeType::Paragraph, 0, true));

// Raise this run of text 5 points above the baseline.
auto run = MakeObject<Run>(doc, u"Raised text. ");
run->get_Font()->set_Position(5);
para->AppendChild(run);

// Lower this run of text 10 points below the baseline.
run = MakeObject<Run>(doc, u"Lowered text. ");
run->get_Font()->set_Position(-10);
para->AppendChild(run);

// Add a run of normal text.
run = MakeObject<Run>(doc, u"Text in its default position. ");
para->AppendChild(run);

// Add a run of text that appears as subscript.
run = MakeObject<Run>(doc, u"Subscript. ");
run->get_Font()->set_Subscript(true);
para->AppendChild(run);

// Add a run of text that appears as superscript.
run = MakeObject<Run>(doc, u"Superscript.");
run->get_Font()->set_Superscript(true);
para->AppendChild(run);

doc->Save(ArtifactsDir + u"Font.PositionSubscript.docx");
```

## See Also

* Class [Font](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
