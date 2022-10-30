---
title: get_WrapType
second_title: Aspose.Words for C++ API Reference
description: Defines whether the shape is inline or floating. For floating shapes defines the wrapping mode for text around the shape.
type: docs
weight: 703
url: /cpp/aspose.words.drawing/shapebase/get_wraptype/
---
## ShapeBase::get_WrapType method


Defines whether the shape is inline or floating. For floating shapes defines the wrapping mode for text around the shape.

```cpp
Aspose::Words::Drawing::WrapType Aspose::Words::Drawing::ShapeBase::get_WrapType()
```


The default value is **None**.

Has effect only for top level shapes.

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


Shows how to create and format a text box. 
```cpp
auto doc = MakeObject<Document>();

// Create a floating text box.
auto textBox = MakeObject<Shape>(doc, ShapeType::TextBox);
textBox->set_WrapType(WrapType::None);
textBox->set_Height(50);
textBox->set_Width(200);

// Set the horizontal, and vertical alignment of the text inside the shape.
textBox->set_HorizontalAlignment(HorizontalAlignment::Center);
textBox->set_VerticalAlignment(VerticalAlignment::Top);

// Add a paragraph to the text box and add a run of text that the text box will display.
textBox->AppendChild(MakeObject<Paragraph>(doc));
SharedPtr<Paragraph> para = textBox->get_FirstParagraph();
para->get_ParagraphFormat()->set_Alignment(ParagraphAlignment::Center);
auto run = MakeObject<Run>(doc);
run->set_Text(u"Hello world!");
para->AppendChild(run);

doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(textBox);

doc->Save(ArtifactsDir + u"Shape.CreateTextBox.docx");
```

