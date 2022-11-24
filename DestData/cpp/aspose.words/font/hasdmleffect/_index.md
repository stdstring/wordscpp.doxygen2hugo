---
title: HasDmlEffect
second_title: Aspose.Words for C++ API Reference
description: Checks if particular DrawingML text effect is applied.
type: docs
weight: 716
url: /cpp/aspose.words/font/hasdmleffect/
---
## Font::HasDmlEffect method


Checks if particular DrawingML text effect is applied.

```cpp
bool Aspose::Words::Font::HasDmlEffect(Aspose::Words::TextDmlEffect dmlEffectType)
```


| Parameter | Type | Description |
| --- | --- | --- |
| dmlEffectType | Aspose::Words::TextDmlEffect | DrawingML text effect type. |

### ReturnValue

True if particular DrawingML text effect is applied.

## Examples



Shows how to check if a run displays a DrawingML text effect. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"DrawingML text effects.docx");

SharedPtr<RunCollection> runs = doc->get_FirstSection()->get_Body()->get_FirstParagraph()->get_Runs();

ASSERT_TRUE(runs->idx_get(0)->get_Font()->HasDmlEffect(TextDmlEffect::Shadow));
ASSERT_TRUE(runs->idx_get(1)->get_Font()->HasDmlEffect(TextDmlEffect::Shadow));
ASSERT_TRUE(runs->idx_get(2)->get_Font()->HasDmlEffect(TextDmlEffect::Reflection));
ASSERT_TRUE(runs->idx_get(3)->get_Font()->HasDmlEffect(TextDmlEffect::Effect3D));
ASSERT_TRUE(runs->idx_get(4)->get_Font()->HasDmlEffect(TextDmlEffect::Fill));
```

## See Also

* Class [Font](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words](../../../)
