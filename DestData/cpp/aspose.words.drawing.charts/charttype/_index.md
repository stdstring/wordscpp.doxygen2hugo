---
title: ChartType
second_title: Aspose.Words for C++ API Reference
description: Specifies type of a chart. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing.charts/charttype/
---
## ChartType enum


Specifies type of a chart.

### Values

| Name | Value | Description |
| --- | --- | --- |
| Area | `0` | Area chart. |
| AreaStacked | `0` | Stacked Area chart. |
| AreaPercentStacked | `0` | 100% Stacked Area chart. |
| Area3D | `0` | 3D Area chart. |
| Area3DStacked | `0` | 3D Stacked Area chart. |
| Area3DPercentStacked | `0` | 3D 100% Stacked Area chart. |
| Bar | `0` | Bar chart. |
| BarStacked | `0` | Stacked Bar chart. |
| BarPercentStacked | `0` | 100% Stacked Bar chart. |
| Bar3D | `0` | 3D Bar chart. |
| Bar3DStacked | `0` | 3D Stacked Bar chart. |
| Bar3DPercentStacked | `0` | 3D 100% Stacked Bar chart. |
| Bubble | `0` | Bubble chart. |
| Bubble3D | `0` | 3D Bubble chart. |
| Column | `0` | Column chart. |
| ColumnStacked | `0` | Stacked Column chart. |
| ColumnPercentStacked | `0` | 100% Stacked Column chart. |
| Column3D | `0` | 3D Column chart. |
| Column3DStacked | `0` | 3D Stacked Column chart. |
| Column3DPercentStacked | `0` | 3D 100% Stacked Column chart. |
| Column3DClustered | `0` | 3D Clustered Column chart. |
| Doughnut | `0` | Doughnut chart. |
| Line | `0` | Line chart. |
| LineStacked | `0` | Stacked Line chart. |
| LinePercentStacked | `0` | 100% Stacked Line chart. |
| Line3D | `0` | 3D Line chart. |
| Pie | `0` | Pie chart. |
| Pie3D | `0` | 3D Pie chart. |
| PieOfBar | `0` | Pie of Bar chart. |
| PieOfPie | `0` | Pie of Pie chart. |
| Radar | `0` | Radar chart. |
| Scatter | `0` | Scatter chart. |
| Stock | `0` | Stock chart. |
| Surface | `0` | Surface chart. |
| Surface3D | `0` | 3D Surface chart. |


## Examples




Shows how to create an appropriate type of chart series for a graph type. 
```cpp
void ChartSeriesCollection_()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    // There are several ways of populating a chart's series collection.
    // Different series schemas are intended for different chart types.
    // 1 -  Column chart with columns grouped and banded along the X-axis by category:
    SharedPtr<Chart> chart = AppendChart(builder, ChartType::Column, 500, 300);

    ArrayPtr<String> categories = MakeArray<String>({u"Category 1", u"Category 2", u"Category 3"});

    // Insert two series of decimal values containing a value for each respective category.
    // This column chart will have three groups, each with two columns.
    chart->get_Series()->Add(u"Series 1", categories, MakeArray<double>({76.6, 82.1, 91.6}));
    chart->get_Series()->Add(u"Series 2", categories, MakeArray<double>({64.2, 79.5, 94.0}));

    // Categories are distributed along the X-axis, and values are distributed along the Y-axis.
    ASSERT_EQ(ChartAxisType::Category, chart->get_AxisX()->get_Type());
    ASSERT_EQ(ChartAxisType::Value, chart->get_AxisY()->get_Type());

    // 2 -  Area chart with dates distributed along the X-axis:
    chart = AppendChart(builder, ChartType::Area, 500, 300);

    ArrayPtr<System::DateTime> dates =
        MakeArray<System::DateTime>({System::DateTime(2014, 3, 31), System::DateTime(2017, 1, 23), System::DateTime(2017, 6, 18),
                                     System::DateTime(2019, 11, 22), System::DateTime(2020, 9, 7)});

    // Insert a series with a decimal value for each respective date.
    // The dates will be distributed along a linear X-axis,
    // and the values added to this series will create data points.
    chart->get_Series()->Add(u"Series 1", dates, MakeArray<double>({15.8, 21.5, 22.9, 28.7, 33.1}));

    ASSERT_EQ(ChartAxisType::Category, chart->get_AxisX()->get_Type());
    ASSERT_EQ(ChartAxisType::Value, chart->get_AxisY()->get_Type());

    // 3 -  2D scatter plot:
    chart = AppendChart(builder, ChartType::Scatter, 500, 300);

    // Each series will need two decimal arrays of equal length.
    // The first array contains X-values, and the second contains corresponding Y-values
    // of data points on the chart's graph.
    chart->get_Series()->Add(u"Series 1", MakeArray<double>({3.1, 3.5, 6.3, 4.1, 2.2, 8.3, 1.2, 3.6}),
                             MakeArray<double>({3.1, 6.3, 4.6, 0.9, 8.5, 4.2, 2.3, 9.9}));
    chart->get_Series()->Add(u"Series 2", MakeArray<double>({2.6, 7.3, 4.5, 6.6, 2.1, 9.3, 0.7, 3.3}),
                             MakeArray<double>({7.1, 6.6, 3.5, 7.8, 7.7, 9.5, 1.3, 4.6}));

    ASSERT_EQ(ChartAxisType::Value, chart->get_AxisX()->get_Type());
    ASSERT_EQ(ChartAxisType::Value, chart->get_AxisY()->get_Type());

    // 4 -  Bubble chart:
    chart = AppendChart(builder, ChartType::Bubble, 500, 300);

    // Each series will need three decimal arrays of equal length.
    // The first array contains X-values, the second contains corresponding Y-values,
    // and the third contains diameters for each of the graph's data points.
    chart->get_Series()->Add(u"Series 1", MakeArray<double>({1.1, 5.0, 9.8}), MakeArray<double>({1.2, 4.9, 9.9}), MakeArray<double>({2.0, 4.0, 8.0}));

    doc->Save(ArtifactsDir + u"Charts.ChartSeriesCollection.docx");
}

static SharedPtr<Chart> AppendChart(SharedPtr<DocumentBuilder> builder, ChartType chartType, double width, double height)
{
    SharedPtr<Shape> chartShape = builder->InsertChart(chartType, width, height);
    SharedPtr<Chart> chart = chartShape->get_Chart();
    chart->get_Series()->Clear();

    return chart;
}
```

