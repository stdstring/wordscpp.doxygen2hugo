---
title: Aspose::Words::Drawing::Stroke::get_Transparency method
linktitle: get_Transparency
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Drawing::Stroke::get_Transparency method. Gets or sets a value between 0.0 (opaque) and 1.0 (clear) representing the degree of transparency of the stroke in C++.
type: docs
weight: 222
url: /cpp/aspose.words.drawing/stroke/get_transparency/
---
## Stroke::get_Transparency method


Gets or sets a value between 0.0 (opaque) and 1.0 (clear) representing the degree of transparency of the stroke.

```cpp
double Aspose::Words::Drawing::Stroke::get_Transparency()
```


## Examples



Show how to set marker formatting. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> shape = builder->InsertChart(ChartType::Scatter, 432, 252);
SharedPtr<Chart> chart = shape->get_Chart();

// Delete default generated series.
chart->get_Series()->Clear();
SharedPtr<ChartSeries> series =
    chart->get_Series()->Add(u"AW Series 1", MakeArray<double>({0.7, 1.8, 2.6, 3.9}), MakeArray<double>({2.7, 3.2, 0.8, 1.7}));

// Set marker formatting.
series->get_Marker()->set_Size(40);
series->get_Marker()->set_Symbol(MarkerSymbol::Square);
SharedPtr<ChartDataPointCollection> dataPoints = series->get_DataPoints();
dataPoints->idx_get(0)->get_Marker()->get_Format()->get_Fill()->PresetTextured(PresetTexture::Denim);
dataPoints->idx_get(0)->get_Marker()->get_Format()->get_Stroke()->set_ForeColor(System::Drawing::Color::get_Yellow());
dataPoints->idx_get(0)->get_Marker()->get_Format()->get_Stroke()->set_BackColor(System::Drawing::Color::get_Red());
dataPoints->idx_get(1)->get_Marker()->get_Format()->get_Fill()->PresetTextured(PresetTexture::WaterDroplets);
dataPoints->idx_get(1)->get_Marker()->get_Format()->get_Stroke()->set_ForeColor(System::Drawing::Color::get_Yellow());
dataPoints->idx_get(1)->get_Marker()->get_Format()->get_Stroke()->set_Visible(false);
dataPoints->idx_get(2)->get_Marker()->get_Format()->get_Fill()->PresetTextured(PresetTexture::GreenMarble);
dataPoints->idx_get(2)->get_Marker()->get_Format()->get_Stroke()->set_ForeColor(System::Drawing::Color::get_Yellow());
dataPoints->idx_get(3)->get_Marker()->get_Format()->get_Fill()->PresetTextured(PresetTexture::Oak);
dataPoints->idx_get(3)->get_Marker()->get_Format()->get_Stroke()->set_ForeColor(System::Drawing::Color::get_Yellow());
dataPoints->idx_get(3)->get_Marker()->get_Format()->get_Stroke()->set_Transparency(0.5);

doc->Save(ArtifactsDir + u"Charts.MarkerFormatting.docx");
```

## See Also

* Class [Stroke](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
