---
title: ChartSeries
second_title: Aspose.Words for C++ API Reference
description: Represents chart series properties. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing.charts/chartseries/
---
## ChartSeries class


Represents chart series properties. 

## Methods

| Method | Description |
| --- | --- |
| bool [get_Bubble3D](./get_bubble3d/)() override | Specifies whether the bubbles in Bubble chart should have a 3-D effect applied to them.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartDataLabelCollection > [get_DataLabels](./get_datalabels/)() | Specifies the settings for the data labels for the entire series.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartDataPointCollection > [get_DataPoints](./get_datapoints/)() const | Returns a collection of formatting objects for all data points in this series.  |
| int32_t [get_Explosion](./get_explosion/)() override | Specifies the amount the data point shall be moved from the center of the pie. Can be negative, negative means that property is not set and no explosion should be applied. Applies only to Pie charts.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartFormat > [get_Format](./get_format/)() | Provides access to fill and line formatting of the series.  |
| bool [get_HasDataLabels](./get_hasdatalabels/)() const | Gets a flag indicating whether data labels are displayed for the series.  |
| bool [get_InvertIfNegative](./get_invertifnegative/)() override | Specifies whether the parent element shall inverts its colors if the value is negative.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartLegendEntry > [get_LegendEntry](./get_legendentry/)() | Gets a legend entry for this chart series.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartMarker > [get_Marker](./get_marker/)() override | Specifies a data marker. Marker is automatically created when requested.  |
| System::String [get_Name](./get_name/)() | Gets or sets the name of the series, if name is not set explicitly it is generated using index. By default returns Series plus one based index.  |
| bool [get_Smooth](./get_smooth/)() const | Allows to specify whether the line connecting the points on the chart shall be smoothed using Catmull-Rom splines.  |
| void [set_Bubble3D](./set_bubble3d/)(bool) override | Setter for Aspose::Words::Drawing::Charts::IChartDataPoint::get_Bubble3D.  |
| void [set_Explosion](./set_explosion/)(int32_t) override | Setter for Aspose::Words::Drawing::Charts::IChartDataPoint::get_Explosion.  |
| void [set_HasDataLabels](./set_hasdatalabels/)(bool) | Sets a flag indicating whether data labels are displayed for the series.  |
| void [set_InvertIfNegative](./set_invertifnegative/)(bool) override | Setter for Aspose::Words::Drawing::Charts::IChartDataPoint::get_InvertIfNegative.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Drawing::Charts::ChartSeries::get_Name.  |
| void [set_Smooth](./set_smooth/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartSeries::get_Smooth.  |
