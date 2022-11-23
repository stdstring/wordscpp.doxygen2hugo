---
title: get_DisplayType
second_title: Aspose.Words for C++ API Reference
description: Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.
type: docs
weight: 14
url: /cpp/aspose.words.math/officemath/get_displaytype/
---
## OfficeMath::get_DisplayType method


Gets/sets Office [Math](../../) display format type which represents whether an equation is displayed inline with the text or displayed on its own line.

```cpp
Aspose::Words::Math::OfficeMathDisplayType Aspose::Words::Math::OfficeMath::get_DisplayType()
```


Display format type has effect for top level Office [Math](../../) only.

Returned display format type is always **Inline** for nested Office [Math](../../).

## Examples



Shows how to set office math display formatting. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Office math.docx");

auto officeMath = System::DynamicCast<OfficeMath>(doc->GetChild(NodeType::OfficeMath, 0, true));

// OfficeMath nodes that are children of other OfficeMath nodes are always inline.
// The node we are working with is the base node to change its location and display type.
ASSERT_EQ(MathObjectType::OMathPara, officeMath->get_MathObjectType());
ASSERT_EQ(NodeType::OfficeMath, officeMath->get_NodeType());
ASPOSE_ASSERT_EQ(officeMath->get_ParentNode(), officeMath->get_ParentParagraph());

// OOXML and WML formats use the "EquationXmlEncoding" property.
ASSERT_TRUE(officeMath->get_EquationXmlEncoding() == nullptr);

// Change the location and display type of the OfficeMath node.
officeMath->set_DisplayType(OfficeMathDisplayType::Display);
officeMath->set_Justification(OfficeMathJustification::Left);

doc->Save(ArtifactsDir + u"Shape.OfficeMath.docx");
```

