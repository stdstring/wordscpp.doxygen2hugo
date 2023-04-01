---
title: Aspose::Words::Drawing::Stroke::get_On method
linktitle: get_On
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Drawing::Stroke::get_On method. Defines whether the path will be stroked in C++.'
type: docs
weight: 1300
url: /cpp/aspose.words.drawing/stroke/get_on/
---
## Stroke::get_On method


Defines whether the path will be stroked.

```cpp
bool Aspose::Words::Drawing::Stroke::get_On()
```

## Remarks


The default value for a [Shape](../../shape/) is **true**.

## Examples



Shows how change stroke properties. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> shape = builder->InsertShape(ShapeType::Rectangle, RelativeHorizontalPosition::LeftMargin, 100, RelativeVerticalPosition::TopMargin,
                                              100, 200, 200, WrapType::None);

// Basic shapes, such as the rectangle, have two visible parts.
// 1 -  The fill, which applies to the area within the outline of the shape:
shape->get_Fill()->set_ForeColor(System::Drawing::Color::get_White());

// 2 -  The stroke, which marks the outline of the shape:
// Modify various properties of this shape's stroke.
SharedPtr<Stroke> stroke = shape->get_Stroke();
stroke->set_On(true);
stroke->set_Weight(5);
stroke->set_Color(System::Drawing::Color::get_Red());
stroke->set_DashStyle(DashStyle::ShortDashDotDot);
stroke->set_JoinStyle(JoinStyle::Miter);
stroke->set_EndCap(EndCap::Square);
stroke->set_LineStyle(ShapeLineStyle::Triple);

doc->Save(ArtifactsDir + u"Shape.Stroke.docx");
```

## See Also

* Class [Stroke](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
