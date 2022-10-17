---
title: ChartLegend
second_title: Aspose.Words for C++ API Reference
description: Represents chart legend properties. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing.charts/chartlegend/
---
## ChartLegend class


Represents chart legend properties.

```cpp
class ChartLegend : public Aspose::Words::Drawing::Core::Dml::IDmlExtensionListSource
```


## Methods

| Method | Description |
| --- | --- |
| [ChartLegend](./chartlegend/)() |  |
| [get_LegendEntries](./get_legendentries/)() const | Returns a collection of legend entries for all series and trendlines of the parent chart. |
| [get_Overlay](./get_overlay/)() const | Determines whether other chart elements shall be allowed to overlap legend. Default value is false. |
| [get_Position](./get_position/)() const | Specifies the position of the legend on a chart. Default value is **Right**. |
| [set_Overlay](./set_overlay/)(bool) | Setter for [Aspose::Words::Drawing::Charts::ChartLegend::get_Overlay](./get_overlay/). |
| [set_Position](./set_position/)(Aspose::Words::Drawing::Charts::LegendPosition) | Setter for [Aspose::Words::Drawing::Charts::ChartLegend::get_Position](./get_position/). |

## Examples




Shows how to edit the appearance of a chart's legend. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> shape = builder->InsertChart(ChartType::Line, 450, 300);
SharedPtr<Chart> chart = shape->get_Chart();

ASSERT_EQ(3, chart->get_Series()->get_Count());
ASSERT_EQ(u"Series 1", chart->get_Series()->idx_get(0)->get_Name());
ASSERT_EQ(u"Series 2", chart->get_Series()->idx_get(1)->get_Name());
ASSERT_EQ(u"Series 3", chart->get_Series()->idx_get(2)->get_Name());

// Move the chart's legend to the top right corner.
SharedPtr<ChartLegend> legend = chart->get_Legend();
legend->set_Position(LegendPosition::TopRight);

// Give other chart elements, such as the graph, more room by allowing them to overlap the legend.
legend->set_Overlay(true);

doc->Save(ArtifactsDir + u"Charts.ChartLegend.docx");
```

