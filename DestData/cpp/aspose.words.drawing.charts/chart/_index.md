---
title: Chart
second_title: Aspose.Words for C++ API Reference
description: Provides access to the chart shape properties. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing.charts/chart/
---
## Chart class


Provides access to the chart shape properties.

```cpp
class Chart : public System::Object
```


## Methods

| Method | Description |
| --- | --- |
| [get_AxisX](./get_axisx/)() | Provides access to properties of the X axis of the chart. |
| [get_AxisY](./get_axisy/)() | Provides access to properties of the Y axis of the chart. |
| [get_AxisZ](./get_axisz/)() | Provides access to properties of the Z axis of the chart. |
| [get_Legend](./get_legend/)() | Provides access to the chart legend properties. |
| [get_Series](./get_series/)() | Provides access to series collection. |
| [get_SourceFullName](./get_sourcefullname/)() | Gets the path and name of an xls/xlsx file this chart is linked to. |
| [get_Title](./get_title/)() | Provides access to the chart title properties. |
| [set_SourceFullName](./set_sourcefullname/)(const System::String\&) | Gets the path and name of an xls/xlsx file this chart is linked to. |

## Examples




Shows how to insert a chart and set a title. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a chart shape with a document builder and get its chart.
SharedPtr<Shape> chartShape = builder->InsertChart(ChartType::Bar, 400, 300);
SharedPtr<Chart> chart = chartShape->get_Chart();

// Use the "Title" property to give our chart a title, which appears at the top center of the chart area.
SharedPtr<ChartTitle> title = chart->get_Title();
title->set_Text(u"My Chart");

// Set the "Show" property to "true" to make the title visible.
title->set_Show(true);

// Set the "Overlay" property to "true" Give other chart elements more room by allowing them to overlap the title
title->set_Overlay(true);

doc->Save(ArtifactsDir + u"Charts.ChartTitle.docx");
```

