---
title: get_StrikeThrough
second_title: Aspose.Words for C++ API Reference
description: True if the font is formatted as strikethrough text. 
type: docs
weight: 0
url: /cpp/aspose.words/font/get_strikethrough/
---
## Font.get_StrikeThrough method


True if the font is formatted as strikethrough text.

```cpp
bool Aspose::Words::Font::get_StrikeThrough()
```


## Examples




Shows how to add a line strikethrough to text. 
```cpp
auto doc = MakeObject<Document>();
auto para = System::DynamicCast<Paragraph>(doc->GetChild(NodeType::Paragraph, 0, true));

auto run = MakeObject<Run>(doc, u"Text with a single-line strikethrough.");
run->get_Font()->set_StrikeThrough(true);
para->AppendChild(run);

para = System::DynamicCast<Paragraph>(para->get_ParentNode()->AppendChild(MakeObject<Paragraph>(doc)));

run = MakeObject<Run>(doc, u"Text with a double-line strikethrough.");
run->get_Font()->set_DoubleStrikeThrough(true);
para->AppendChild(run);

doc->Save(ArtifactsDir + u"Font.StrikeThrough.docx");
```

