---
title: EmphasisMark
second_title: Aspose.Words for C++ API Reference
description: Specifies possible types of emphasis mark. 
type: docs
weight: 0
url: /cpp/aspose.words/emphasismark/
---
## EmphasisMark enum


Specifies possible types of emphasis mark.


## Examples




Shows how to add additional character rendered above/below the glyph-character. 
```cpp
auto builder = MakeObject<DocumentBuilder>();

// Possible types of emphasis mark:
// https://apireference.aspose.com/words/net/aspose.words/emphasismark
builder->get_Font()->set_EmphasisMark(emphasisMark);

builder->Write(u"Emphasis text");
builder->Writeln();
builder->get_Font()->ClearFormatting();
builder->Write(u"Simple text");

builder->get_Document()->Save(ArtifactsDir + u"Fonts.SetEmphasisMark.docx");
```

