---
title: get_LineSpacing
second_title: Aspose.Words for C++ API Reference
description: Returns line spacing of this font (in points). 
type: docs
weight: 248
url: /cpp/aspose.words/font/get_linespacing/
---
## Font.get_LineSpacing method


Returns line spacing of this font (in points).

```cpp
double Aspose::Words::Font::get_LineSpacing()
```


## Examples




Shows how to get a font's line spacing, in points. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Set different fonts for the DocumentBuilder and verify their line spacing.
builder->get_Font()->set_Name(u"Calibri");
ASPOSE_ASSERT_EQ(14.6484375, builder->get_Font()->get_LineSpacing());

builder->get_Font()->set_Name(u"Times New Roman");
ASPOSE_ASSERT_EQ(13.798828125, builder->get_Font()->get_LineSpacing());
```

