---
title: HorizontalAlignment
second_title: Aspose.Words for C++ API Reference
description: Specifies horizontal alignment of a floating shape, text frame or floating table. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/horizontalalignment/
---
## HorizontalAlignment enum


Specifies horizontal alignment of a floating shape, text frame or floating table.


## Examples




Shows how to insert a floating image to the center of a page. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a floating image that will appear behind the overlapping text and align it to the page's center.
SharedPtr<Shape> shape = builder->InsertImage(ImageDir + u"Logo.jpg");
shape->set_WrapType(WrapType::None);
shape->set_BehindText(true);
shape->set_RelativeHorizontalPosition(RelativeHorizontalPosition::Page);
shape->set_RelativeVerticalPosition(RelativeVerticalPosition::Page);
shape->set_HorizontalAlignment(HorizontalAlignment::Center);
shape->set_VerticalAlignment(VerticalAlignment::Center);

doc->Save(ArtifactsDir + u"Image.CreateFloatingPageCenter.docx");
```

