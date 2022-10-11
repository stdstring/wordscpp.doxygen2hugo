---
title: ChartDataLabelCollection
second_title: Aspose.Words for C++ API Reference
description: Represents a collection of ChartDataLabel. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing.charts/chartdatalabelcollection/
---
## ChartDataLabelCollection class


Represents a collection of ChartDataLabel. 

## Methods

| Method | Description |
| --- | --- |
| void [ClearFormat](./clearformat/)() | Clears format of all ChartDataLabel in this collection.  |
| int32_t [get_Count](./get_count/)() | Returns the number of ChartDataLabel in this collection.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartNumberFormat > [get_NumberFormat](./get_numberformat/)() | Gets an ChartNumberFormat instance allowing to set number format for the data labels of the entire series.  |
| System::String [get_Separator](./get_separator/)() | Gets or sets string separator used for the data labels of the entire series. The default is a comma, except for pie charts showing only category name and percentage, when a line break shall be used instead.  |
| bool [get_ShowBubbleSize](./get_showbubblesize/)() | Allows to specify whether bubble size is to be displayed for the data labels of the entire series. Applies only to Bubble charts. Default value is **false**.  |
| bool [get_ShowCategoryName](./get_showcategoryname/)() | Allows to specify whether category name is to be displayed for the data labels of the entire series. Default value is **false**.  |
| bool [get_ShowDataLabelsRange](./get_showdatalabelsrange/)() | Allows to specify whether values from data labels range to be displayed in the data labels of the entire series. Default value is **false**.  |
| bool [get_ShowLeaderLines](./get_showleaderlines/)() | Allows to specify whether data label leader lines need be shown for the data labels of the entire series. Default value is **false**.  |
| bool [get_ShowLegendKey](./get_showlegendkey/)() | Allows to specify whether legend key is to be displayed for the data labels of the entire series. Default value is **false**.  |
| bool [get_ShowPercentage](./get_showpercentage/)() | Allows to specify whether percentage value is to be displayed for the data labels of the entire series. Default value is **false**. Applies only to Pie charts.  |
| bool [get_ShowSeriesName](./get_showseriesname/)() | Returns or sets a Boolean to indicate the series name display behavior for the data labels of the entire series. **True** to show the series name. **False** to hide. By default **false**.  |
| bool [get_ShowValue](./get_showvalue/)() | Allows to specify whether values are to be displayed in the data labels of the entire series. Default value is **false**.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Drawing::Charts::ChartDataLabel > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object.  |
| System::SharedPtr< Aspose::Words::Drawing::Charts::ChartDataLabel > [idx_get](./idx_get/)(int32_t) | Returns ChartDataLabel for the specified index.  |
| void [set_Separator](./set_separator/)(const System::String &) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_Separator.  |
| void [set_ShowBubbleSize](./set_showbubblesize/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowBubbleSize.  |
| void [set_ShowCategoryName](./set_showcategoryname/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowCategoryName.  |
| void [set_ShowDataLabelsRange](./set_showdatalabelsrange/)(bool) | Allows to specify whether values from data labels range to be displayed in the data labels of the entire series. Default value is **false**.  |
| void [set_ShowLeaderLines](./set_showleaderlines/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowLeaderLines.  |
| void [set_ShowLegendKey](./set_showlegendkey/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowLegendKey.  |
| void [set_ShowPercentage](./set_showpercentage/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowPercentage.  |
| void [set_ShowSeriesName](./set_showseriesname/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowSeriesName.  |
| void [set_ShowValue](./set_showvalue/)(bool) | Setter for Aspose::Words::Drawing::Charts::ChartDataLabelCollection::get_ShowValue.  |
