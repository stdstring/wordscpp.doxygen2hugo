---
title: RelativeVerticalPosition
second_title: Aspose.Words for C++ API Reference
description: Specifies to what the vertical position of a shape or text frame is relative. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/relativeverticalposition/
---
## RelativeVerticalPosition enum


Specifies to what the vertical position of a shape or text frame is relative.


## Examples




Shows how to insert an image, and use it as a watermark. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert the image into the header so that it will be visible on every page.
SharedPtr<System::Drawing::Image> image = System::Drawing::Image::FromFile(ImageDir + u"Transparent background logo.png");
builder->MoveToHeaderFooter(HeaderFooterType::HeaderPrimary);
SharedPtr<Shape> shape = builder->InsertImage(image);
shape->set_WrapType(WrapType::None);
shape->set_BehindText(true);

// Place the image at the center of the page.
shape->set_RelativeHorizontalPosition(RelativeHorizontalPosition::Page);
shape->set_RelativeVerticalPosition(RelativeVerticalPosition::Page);
shape->set_Left((builder->get_PageSetup()->get_PageWidth() - shape->get_Width()) / 2);
shape->set_Top((builder->get_PageSetup()->get_PageHeight() - shape->get_Height()) / 2);

doc->Save(ArtifactsDir + u"DocumentBuilder.InsertWatermark.docx");
```


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

