---
title: get_Color
second_title: Aspose.Words for C++ API Reference
description: Gets or sets the border color. 
type: docs
weight: 27
url: /cpp/aspose.words/border/get_color/
---
## Border.get_Color method


Gets or sets the border color.

```cpp
System::Drawing::Color Aspose::Words::Border::get_Color()
```


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

