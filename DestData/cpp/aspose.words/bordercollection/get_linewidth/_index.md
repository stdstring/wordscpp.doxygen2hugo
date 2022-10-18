---
title: get_LineWidth
second_title: Aspose.Words for C++ API Reference
description: Gets or sets the border width in points. 
type: docs
weight: 0
url: /cpp/aspose.words/bordercollection/get_linewidth/
---
## BorderCollection.get_LineWidth method


Gets or sets the border width in points.

```cpp
double Aspose::Words::BorderCollection::get_LineWidth()
```


Returns the width of the first border in the collection.

Sets the width of all borders in the collection excluding diagonal borders.

## Examples




Shows how to create green wavy page border with a shadow. 
```cpp
auto doc = MakeObject<Document>();
SharedPtr<PageSetup> pageSetup = doc->get_Sections()->idx_get(0)->get_PageSetup();

pageSetup->get_Borders()->set_LineStyle(LineStyle::DoubleWave);
pageSetup->get_Borders()->set_LineWidth(2);
pageSetup->get_Borders()->set_Color(System::Drawing::Color::get_Green());
pageSetup->get_Borders()->set_DistanceFromText(24);
pageSetup->get_Borders()->set_Shadow(true);

doc->Save(ArtifactsDir + u"PageSetup.PageBorders.docx");
```

