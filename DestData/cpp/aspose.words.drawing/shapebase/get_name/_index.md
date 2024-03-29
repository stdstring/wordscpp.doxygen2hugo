---
title: Aspose::Words::Drawing::ShapeBase::get_Name method
linktitle: get_Name
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Drawing::ShapeBase::get_Name method. Gets or sets the optional shape name in C++.'
type: docs
weight: 3900
url: /cpp/aspose.words.drawing/shapebase/get_name/
---
## ShapeBase::get_Name method


Gets or sets the optional shape name.

```cpp
System::String Aspose::Words::Drawing::ShapeBase::get_Name()
```

## Remarks


Default is empty string.

Cannot be null, but can be an empty string.

## Examples



Shows how to use a shape's alternative text. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);
SharedPtr<Shape> shape = builder->InsertShape(ShapeType::Cube, 150, 150);
shape->set_Name(u"MyCube");

shape->set_AlternativeText(u"Alt text for MyCube.");

// We can access the alternative text of a shape by right-clicking it, and then via "Format AutoShape" -> "Alt Text".
doc->Save(ArtifactsDir + u"Shape.AltText.docx");

// Save the document to HTML, and then delete the linked image that belongs to our shape.
// The browser that is reading our HTML will display the alt text in place of the missing image.
doc->Save(ArtifactsDir + u"Shape.AltText.html");
System::IO::File::Delete(ArtifactsDir + u"Shape.AltText.001.png");
```

## See Also

* Class [ShapeBase](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
