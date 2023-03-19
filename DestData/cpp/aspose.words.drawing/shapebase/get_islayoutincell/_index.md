---
title: Aspose::Words::Drawing::ShapeBase::get_IsLayoutInCell method
linktitle: get_IsLayoutInCell
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Drawing::ShapeBase::get_IsLayoutInCell method. Gets or sets a flag indicating whether the shape is displayed inside a table or outside of it in C++.
type: docs
weight: 3100
url: /cpp/aspose.words.drawing/shapebase/get_islayoutincell/
---
## ShapeBase::get_IsLayoutInCell method


Gets or sets a flag indicating whether the shape is displayed inside a table or outside of it.

```cpp
bool Aspose::Words::Drawing::ShapeBase::get_IsLayoutInCell()
```

## Remarks


The default value is **true**.

Has effect only for top level shapes, the property [WrapType](../get_wraptype/) of which is set to value other than [Inline](../../../aspose.words/inline/).

## Examples



Shows how to determine how to display a shape in a table cell. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Table> table = builder->StartTable();
builder->InsertCell();
builder->InsertCell();
builder->EndTable();

auto tableStyle = System::DynamicCast<TableStyle>(doc->get_Styles()->Add(StyleType::Table, u"MyTableStyle1"));
tableStyle->set_BottomPadding(20);
tableStyle->set_LeftPadding(10);
tableStyle->set_RightPadding(10);
tableStyle->set_TopPadding(20);
tableStyle->get_Borders()->set_Color(System::Drawing::Color::get_Black());
tableStyle->get_Borders()->set_LineStyle(LineStyle::Single);

table->set_Style(tableStyle);

builder->MoveTo(table->get_FirstRow()->get_FirstCell()->get_FirstParagraph());

SharedPtr<Shape> shape = builder->InsertShape(ShapeType::Rectangle, RelativeHorizontalPosition::LeftMargin, 50, RelativeVerticalPosition::TopMargin,
                                              100, 100, 100, WrapType::None);

// Set the "IsLayoutInCell" property to "true" to display the shape as an inline element inside the cell's paragraph.
// The coordinate origin that will determine the shape's location will be the top left corner of the shape's cell.
// If we re-size the cell, the shape will move to maintain the same position starting from the cell's top left.
// Set the "IsLayoutInCell" property to "false" to display the shape as an independent floating shape.
// The coordinate origin that will determine the shape's location will be the top left corner of the page,
// and the shape will not respond to any re-sizing of its cell.
shape->set_IsLayoutInCell(isLayoutInCell);

// We can only apply the "IsLayoutInCell" property to floating shapes.
shape->set_WrapType(WrapType::None);

doc->Save(ArtifactsDir + u"Shape.LayoutInTableCell.docx");
```

## See Also

* Class [ShapeBase](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
