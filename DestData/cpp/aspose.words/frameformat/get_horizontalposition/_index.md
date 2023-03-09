---
title: Aspose::Words::FrameFormat::get_HorizontalPosition method
linktitle: get_HorizontalPosition
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::FrameFormat::get_HorizontalPosition method. Gets horizontal distance between the edge of the frame and the item specified by the RelativeHorizontalPosition property in C++.
type: docs
weight: 53
url: /cpp/aspose.words/frameformat/get_horizontalposition/
---
## FrameFormat::get_HorizontalPosition method


Gets horizontal distance between the edge of the frame and the item specified by the [RelativeHorizontalPosition](../get_relativehorizontalposition/) property.

```cpp
double Aspose::Words::FrameFormat::get_HorizontalPosition()
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

* Class [FrameFormat](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
