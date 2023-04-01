---
title: Aspose::Words::Drawing::ShapeBase::get_IsHorizontalRule method
linktitle: get_IsHorizontalRule
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Drawing::ShapeBase::get_IsHorizontalRule method. Returns true if this shape is a horizontal rule in C++.'
type: docs
weight: 2700
url: /cpp/aspose.words.drawing/shapebase/get_ishorizontalrule/
---
## ShapeBase::get_IsHorizontalRule method


Returns true if this shape is a horizontal rule.

```cpp
bool Aspose::Words::Drawing::ShapeBase::get_IsHorizontalRule()
```


## Examples



Shows how to insert a horizontal rule shape, and customize its formatting. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);
SharedPtr<Shape> shape = builder->InsertHorizontalRule();

SharedPtr<HorizontalRuleFormat> horizontalRuleFormat = shape->get_HorizontalRuleFormat();
horizontalRuleFormat->set_Alignment(HorizontalRuleAlignment::Center);
horizontalRuleFormat->set_WidthPercent(70);
horizontalRuleFormat->set_Height(3);
horizontalRuleFormat->set_Color(System::Drawing::Color::get_Blue());
horizontalRuleFormat->set_NoShade(true);

ASSERT_TRUE(shape->get_IsHorizontalRule());
ASSERT_TRUE(shape->get_HorizontalRuleFormat()->get_NoShade());
```

## See Also

* Class [ShapeBase](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
