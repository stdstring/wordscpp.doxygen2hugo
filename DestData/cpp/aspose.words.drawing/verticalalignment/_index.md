---
title: VerticalAlignment
second_title: Aspose.Words for C++ API Reference
description: Specifies vertical alignment of a floating shape, text frame or a floating table. 
type: docs
weight: 547
url: /cpp/aspose.words.drawing/verticalalignment/
---
## VerticalAlignment enum


Specifies vertical alignment of a floating shape, text frame or a floating table.

### Values

| Name | Value | Description |
| --- | --- | --- |
| None | `0` | The object is explicitly positioned, usually using its **Top** property. |
| Top | `0` | Specifies that the object shall be at the top of the vertical alignment base. |
| Center | `0` | Specifies that the object shall be centered with respect to the vertical alignment base. |
| Bottom | `0` | Specifies that the object shall be at the bottom of the vertical alignment base. |
| Inside | `0` | Specifies that the object shall be inside of the horizontal alignment base. |
| Outside | `0` | Specifies that the object shall be outside of the vertical alignment base. |
| Inline | `0` | Not documented. Seems to be a possible value for floating paragraphs and tables. |
| Default | `0` | Same as **None**. |


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

