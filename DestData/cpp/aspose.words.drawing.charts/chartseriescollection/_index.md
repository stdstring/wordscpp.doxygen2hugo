---
title: ChartSeriesCollection
second_title: Aspose.Words for C++ API Reference
description: Represents collection of a ChartSeries. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing.charts/chartseriescollection/
---
## ChartSeriesCollection class


Represents collection of a ChartSeries. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartSeries > [Add](./add/)(const System::String &, const System::ArrayPtr< double > &, const System::ArrayPtr< double > &) | Adds new ChartSeries to this collection. Use this method to add series to any type of Scatter charts.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartSeries > [Add](./add/)(const System::String &, const System::ArrayPtr< double > &, const System::ArrayPtr< double > &, const System::ArrayPtr< double > &) | Adds new ChartSeries to this collection. Use this method to add series to any type of Bubble charts.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartSeries > [Add](./add/)(const System::String &, const System::ArrayPtr< System::DateTime > &, const System::ArrayPtr< double > &) | Adds new ChartSeries to this collection. Use this method to add series to any type of Area, Radar and Stock charts.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartSeries > [Add](./add/)(const System::String &, const System::ArrayPtr< System::String > &, const System::ArrayPtr< double > &) | Adds new ChartSeries to this collection. Use this method to add series to any type of Bar, Column, Line and Surface charts.  |
| void [Clear](./clear/)() | Removes all ChartSeries from this collection.  |
| int32_t [get_Count](./get_count/)() | Returns the number of ChartSeries in this collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Drawing::Charts::ChartSeries > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartSeries > [idx_get](./idx_get/)(int32_t) | Returns a ChartSeries at the specified index.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a ChartSeries at the specified index.  |
