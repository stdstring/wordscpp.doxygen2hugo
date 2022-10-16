---
title: ShapeType
second_title: Aspose.Words for C++ API Reference
description: Specifies the type of shape in a Microsoft Word document. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/shapetype/
---
## ShapeType enum


Specifies the type of shape in a Microsoft Word document.


## Examples




Shows how to insert a shape with an image from the local file system into a document. 
```cpp
auto doc = MakeObject<Document>();

// The "Shape" class's public constructor will create a shape with "ShapeMarkupLanguage.Vml" markup type.
// If you need to create a shape of a non-primitive type, such as SingleCornerSnipped, TopCornersSnipped, DiagonalCornersSnipped,
// TopCornersOneRoundedOneSnipped, SingleCornerRounded, TopCornersRounded, or DiagonalCornersRounded,
// please use DocumentBuilder.InsertShape.
auto shape = MakeObject<Shape>(doc, ShapeType::Image);
shape->get_ImageData()->SetImage(ImageDir + u"Windows MetaFile.wmf");
shape->set_Width(100);
shape->set_Height(100);

doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(shape);

doc->Save(ArtifactsDir + u"Image.FromFile.docx");
```


Shows how Aspose.Words identify shapes. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->InsertShape(ShapeType::Heptagon, RelativeHorizontalPosition::Page, 0, RelativeVerticalPosition::Page, 0, 0, 0, WrapType::None);

builder->InsertShape(ShapeType::Cloud, RelativeHorizontalPosition::RightMargin, 0, RelativeVerticalPosition::Page, 0, 0, 0, WrapType::None);

builder->InsertShape(ShapeType::MathPlus, RelativeHorizontalPosition::RightMargin, 0, RelativeVerticalPosition::Page, 0, 0, 0, WrapType::None);

// To correct identify shape types you need to work with shapes as DML.
auto saveOptions = MakeObject<OoxmlSaveOptions>(SaveFormat::Docx);
saveOptions->set_Compliance(OoxmlCompliance::Iso29500_2008_Transitional);

doc->Save(ArtifactsDir + u"Shape.ShapeTypes.docx", saveOptions);
doc = MakeObject<Document>(ArtifactsDir + u"Shape.ShapeTypes.docx");

ArrayPtr<SharedPtr<Shape>> shapes = doc->GetChildNodes(NodeType::Shape, true)->LINQ_OfType<SharedPtr<Shape>>()->LINQ_ToArray();

for (SharedPtr<Shape> shape : shapes)
{
    std::cout << System::EnumGetName(shape->get_ShapeType()) << std::endl;
}
```

