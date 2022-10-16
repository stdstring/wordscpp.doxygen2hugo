---
title: LineStyle
second_title: Aspose.Words for C++ API Reference
description: Specifies line style of a Border. 
type: docs
weight: 0
url: /cpp/aspose.words/linestyle/
---
## LineStyle enum


Specifies line style of a [Border](./border/).


## Examples




Shows how to insert a string surrounded by a border into a document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_Font()->get_Border()->set_Color(System::Drawing::Color::get_Green());
builder->get_Font()->get_Border()->set_LineWidth(2.5);
builder->get_Font()->get_Border()->set_LineStyle(LineStyle::DashDotStroker);

builder->Write(u"Text surrounded by green border.");

doc->Save(ArtifactsDir + u"Border.FontBorder.docx");
```

