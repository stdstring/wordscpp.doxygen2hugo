---
title: Aspose::Words::Drawing::ShapeBase::get_Target method
linktitle: get_Target
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Drawing::ShapeBase::get_Target method. Gets or sets the target frame for the shape hyperlink in C++.
type: docs
weight: 4900
url: /cpp/aspose.words.drawing/shapebase/get_target/
---
## ShapeBase::get_Target method


Gets or sets the target frame for the shape hyperlink.

```cpp
System::String Aspose::Words::Drawing::ShapeBase::get_Target()
```

## Remarks


The default value is an empty string.

## Examples



Shows how to insert a shape which contains an image, and is also a hyperlink. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> shape = builder->InsertImage(ImageDir + u"Logo.jpg");
shape->set_HRef(u"https://forum.aspose.com/");
shape->set_Target(u"New Window");
shape->set_ScreenTip(u"Aspose.Words Support Forums");

// Ctrl + left-clicking the shape in Microsoft Word will open a new web browser window
// and take us to the hyperlink in the "HRef" property.
doc->Save(ArtifactsDir + u"Image.InsertImageWithHyperlink.docx");
```

## See Also

* Class [ShapeBase](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
