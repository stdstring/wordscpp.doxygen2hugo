---
title: Aspose::Words::Drawing::Charts::ChartSeries::get_Smooth method
linktitle: get_Smooth
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Drawing::Charts::ChartSeries::get_Smooth method. Allows to specify whether the line connecting the points on the chart shall be smoothed using Catmull-Rom splines in C++.'
type: docs
weight: 1100
url: /cpp/aspose.words.drawing.charts/chartseries/get_smooth/
---
## ChartSeries::get_Smooth method


Allows to specify whether the line connecting the points on the chart shall be smoothed using Catmull-Rom splines.

```cpp
bool Aspose::Words::Drawing::Charts::ChartSeries::get_Smooth() const
```


## Examples



Shows how to work with data points on a line chart. 
```cpp
void ChartDataPoint_()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    SharedPtr<Shape> shape = builder->InsertChart(ChartType::Line, 500, 350);
    SharedPtr<Chart> chart = shape->get_Chart();

    ASSERT_EQ(3, chart->get_Series()->get_Count());
    ASSERT_EQ(u"Series 1", chart->get_Series()->idx_get(0)->get_Name());
    ASSERT_EQ(u"Series 2", chart->get_Series()->idx_get(1)->get_Name());
    ASSERT_EQ(u"Series 3", chart->get_Series()->idx_get(2)->get_Name());

    // Emphasize the chart's data points by making them appear as diamond shapes.
    for (const auto& series : System::IterateOver(chart->get_Series()))
    {
        ApplyDataPoints(series, 4, MarkerSymbol::Diamond, 15);
    }

    // Smooth out the line that represents the first data series.
    chart->get_Series()->idx_get(0)->set_Smooth(true);

    // Verify that data points for the first series will not invert their colors if the value is negative.
    {
        SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<ChartDataPoint>>> enumerator =
            chart->get_Series()->idx_get(0)->get_DataPoints()->GetEnumerator();
        while (enumerator->MoveNext())
        {
            ASSERT_FALSE(enumerator->get_Current()->get_InvertIfNegative());
        }
    }

    // For a cleaner looking graph, we can clear format individually.
    chart->get_Series()->idx_get(1)->get_DataPoints()->idx_get(2)->ClearFormat();

    // We can also strip an entire series of data points at once.
    chart->get_Series()->idx_get(2)->get_DataPoints()->ClearFormat();

    doc->Save(ArtifactsDir + u"Charts.ChartDataPoint.docx");
}

static void ApplyDataPoints(SharedPtr<ChartSeries> series, int dataPointsCount, MarkerSymbol markerSymbol, int dataPointSize)
{
    for (int i = 0; i < dataPointsCount; i++)
    {
        SharedPtr<ChartDataPoint> point = series->get_DataPoints()->idx_get(i);
        point->get_Marker()->set_Symbol(markerSymbol);
        point->get_Marker()->set_Size(dataPointSize);

        ASSERT_EQ(i, point->get_Index());
    }
}
```

## See Also

* Class [ChartSeries](../)
* Namespace [Aspose::Words::Drawing::Charts](../../)
* Library [Aspose.Words for C++](../../../)
