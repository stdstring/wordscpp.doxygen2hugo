---
title: Aspose::Words::PageSetup::get_LeftMargin method
linktitle: get_LeftMargin
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::PageSetup::get_LeftMargin method. Returns or sets the distance (in points) between the left edge of the page and the left boundary of the body text in C++.'
type: docs
weight: 2100
url: /cpp/aspose.words/pagesetup/get_leftmargin/
---
## PageSetup::get_LeftMargin method


Returns or sets the distance (in points) between the left edge of the page and the left boundary of the body text.

```cpp
double Aspose::Words::PageSetup::get_LeftMargin()
```


## Examples



Shows how to adjust paper size, orientation, margins, along with other settings for a section. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_PageSetup()->set_PaperSize(PaperSize::Legal);
builder->get_PageSetup()->set_Orientation(Orientation::Landscape);
builder->get_PageSetup()->set_TopMargin(ConvertUtil::InchToPoint(1.0));
builder->get_PageSetup()->set_BottomMargin(ConvertUtil::InchToPoint(1.0));
builder->get_PageSetup()->set_LeftMargin(ConvertUtil::InchToPoint(1.5));
builder->get_PageSetup()->set_RightMargin(ConvertUtil::InchToPoint(1.5));
builder->get_PageSetup()->set_HeaderDistance(ConvertUtil::InchToPoint(0.2));
builder->get_PageSetup()->set_FooterDistance(ConvertUtil::InchToPoint(0.2));

builder->Writeln(u"Hello world!");

doc->Save(ArtifactsDir + u"PageSetup.PageMargins.docx");
```

## See Also

* Class [PageSetup](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
