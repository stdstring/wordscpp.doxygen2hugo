---
title: LineStyle
second_title: Aspose.Words for C++ API Reference
description: Specifies line style of a Border. 
type: docs
weight: 1249
url: /cpp/aspose.words/linestyle/
---
## LineStyle enum


Specifies line style of a [Border](../border/).

### Values

| Name | Value | Description |
| --- | --- | --- |
| None | `0` |  |
| Single | `0` |  |
| Thick | `0` |  |
| Double | `0` |  |
| Hairline | `0` |  |
| Dot | `0` |  |
| DashLargeGap | `0` |  |
| DotDash | `0` |  |
| DotDotDash | `0` |  |
| Triple | `0` |  |
| ThinThickSmallGap | `0` |  |
| ThickThinSmallGap | `0` |  |
| ThinThickThinSmallGap | `0` |  |
| ThinThickMediumGap | `0` |  |
| ThickThinMediumGap | `0` |  |
| ThinThickThinMediumGap | `0` |  |
| ThinThickLargeGap | `0` |  |
| ThickThinLargeGap | `0` |  |
| ThinThickThinLargeGap | `0` |  |
| Wave | `0` |  |
| DoubleWave | `0` |  |
| DashSmallGap | `0` |  |
| DashDotStroker | `0` |  |
| Emboss3D | `0` |  |
| Engrave3D | `0` |  |
| Outset | `0` |  |
| Inset | `0` |  |


## Examples




Shows how to insert a string surrounded by a border into a document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_Font()->get_Border()->set_Color(System::Drawing::Color::get_Green());
builder->get_Font()->get_Border()->set_LineWidth(2.5);
builder->get_Font()->get_Border()->set_LineStyle(LineStyle::DashDotStroker);

builder->Write(u"Text surrounded by green border.");

doc->Save(ArtifactsDir + u"Border.FontBorder.docx");
```

