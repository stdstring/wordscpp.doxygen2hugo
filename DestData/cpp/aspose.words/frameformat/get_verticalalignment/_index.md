---
title: Aspose::Words::FrameFormat::get_VerticalAlignment method
linktitle: get_VerticalAlignment
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::FrameFormat::get_VerticalAlignment method. Gets vertical alignment of the specified frame in C++.'
type: docs
weight: 900
url: /cpp/aspose.words/frameformat/get_verticalalignment/
---
## FrameFormat::get_VerticalAlignment method


Gets vertical alignment of the specified frame.

```cpp
Aspose::Words::Drawing::VerticalAlignment Aspose::Words::FrameFormat::get_VerticalAlignment()
```


## Examples



Shows how to get information about formatting properties of paragraphs that are frames. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Paragraph frame.docx");

SharedPtr<Paragraph> paragraphFrame = doc->get_FirstSection()->get_Body()->get_Paragraphs()->LINQ_OfType<SharedPtr<Paragraph>>()->LINQ_First(
    [](SharedPtr<Paragraph> p) { return p->get_FrameFormat()->get_IsFrame(); });

ASPOSE_ASSERT_EQ(233.3, paragraphFrame->get_FrameFormat()->get_Width());
ASPOSE_ASSERT_EQ(138.8, paragraphFrame->get_FrameFormat()->get_Height());
ASSERT_EQ(HeightRule::AtLeast, paragraphFrame->get_FrameFormat()->get_HeightRule());
ASSERT_EQ(HorizontalAlignment::Default, paragraphFrame->get_FrameFormat()->get_HorizontalAlignment());
ASSERT_EQ(VerticalAlignment::Default, paragraphFrame->get_FrameFormat()->get_VerticalAlignment());
ASPOSE_ASSERT_EQ(34.05, paragraphFrame->get_FrameFormat()->get_HorizontalPosition());
ASSERT_EQ(RelativeHorizontalPosition::Page, paragraphFrame->get_FrameFormat()->get_RelativeHorizontalPosition());
ASPOSE_ASSERT_EQ(9.0, paragraphFrame->get_FrameFormat()->get_HorizontalDistanceFromText());
ASPOSE_ASSERT_EQ(20.5, paragraphFrame->get_FrameFormat()->get_VerticalPosition());
ASSERT_EQ(RelativeVerticalPosition::Paragraph, paragraphFrame->get_FrameFormat()->get_RelativeVerticalPosition());
ASPOSE_ASSERT_EQ(0.0, paragraphFrame->get_FrameFormat()->get_VerticalDistanceFromText());
```

## See Also

* Enum [VerticalAlignment](../../../aspose.words.drawing/verticalalignment/)
* Class [FrameFormat](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
