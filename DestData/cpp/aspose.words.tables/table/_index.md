---
title: Table
second_title: Aspose.Words for C++ API Reference
description: Represents a table in a Word document. 
type: docs
weight: 0
url: /cpp/aspose.words.tables/table/
---
## Table class


Represents a table in a Word document. 

## Methods

| Method | Description |
| --- | --- |
|  [Table](./table/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Table** class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| void [AutoFit](./autofit/)(Aspose::Words::Tables::AutoFitBehavior) | Resizes the table and cells according to the specified auto fit behavior.  |
| void [ClearBorders](./clearborders/)() | Removes all table and cell borders on this table.  |
| void [ClearShading](./clearshading/)() | Removes all shading on the table.  |
| void [ConvertToHorizontallyMergedCells](./converttohorizontallymergedcells/)() | Converts cells horizontally merged by width to cells merged by HorizontalMerge.  |
| void [EnsureMinimum](./ensureminimum/)() | If the table has no rows, creates and appends one **Row**.  |
| double [get_AbsoluteHorizontalDistance](./get_absolutehorizontaldistance/)() | Gets or sets absolute horizontal floating table position specified by the table properties, in points. Default value is 0.  |
| double [get_AbsoluteVerticalDistance](./get_absoluteverticaldistance/)() | Gets or sets absolute vertical floating table position specified by the table properties, in points. Default value is 0.  |
| Aspose::Words::Tables::TableAlignment [get_Alignment](./get_alignment/)() | Specifies how an inline table is aligned in the document.  |
| bool [get_AllowAutoFit](./get_allowautofit/)() | Allows Microsoft Word and Aspose.Words to automatically resize cells in a table to fit their contents.  |
| bool [get_AllowCellSpacing](./get_allowcellspacing/)() | Gets or sets the "Allow spacing between cells" option.  |
| bool [get_AllowOverlap](./get_allowoverlap/)() | Gets whether a floating table shall allow other floating objects in the document to overlap its extents when displayed. Default value is **true**.  |
| bool [get_Bidi](./get_bidi/)() | Gets or sets whether this is a right-to-left table.  |
| double [get_BottomPadding](./get_bottompadding/)() | Gets or sets the amount of space (in points) to add below the contents of cells.  |
| double [get_CellSpacing](./get_cellspacing/)() | Gets or sets the amount of space (in points) between the cells.  |
| System::String [get_Description](./get_description/)() | Gets or sets description of this table. It provides an alternative text representation of the information contained in the table.  |
| double [get_DistanceBottom](./get_distancebottom/)() | Gets distance between table bottom and the surrounding text, in points.  |
| double [get_DistanceLeft](./get_distanceleft/)() | Gets distance between table left and the surrounding text, in points.  |
| double [get_DistanceRight](./get_distanceright/)() | Gets distance between table right and the surrounding text, in points.  |
| double [get_DistanceTop](./get_distancetop/)() | Gets distance between table top and the surrounding text, in points.  |
| System::SharedPtr< Aspose::Words::Tables::Row > [get_FirstRow](./get_firstrow/)() | Returns the first **Row** node in the table.  |
| Aspose::Words::Drawing::RelativeHorizontalPosition [get_HorizontalAnchor](./get_horizontalanchor/)() | Gets the base object from which the horizontal positioning of floating table should be calculated. Default value is Column.  |
| System::SharedPtr< Aspose::Words::Tables::Row > [get_LastRow](./get_lastrow/)() | Returns the last **Row** node in the table.  |
| double [get_LeftIndent](./get_leftindent/)() | Gets or sets the value that represents the left indent of the table.  |
| double [get_LeftPadding](./get_leftpadding/)() | Gets or sets the amount of space (in points) to add to the left of the contents of cells.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Table**.  |
| System::SharedPtr< Aspose::Words::Tables::PreferredWidth > [get_PreferredWidth](./get_preferredwidth/)() | Gets or sets the table preferred width.  |
| Aspose::Words::Drawing::HorizontalAlignment [get_RelativeHorizontalAlignment](./get_relativehorizontalalignment/)() | Gets or sets floating table relative horizontal alignment.  |
| Aspose::Words::Drawing::VerticalAlignment [get_RelativeVerticalAlignment](./get_relativeverticalalignment/)() | Gets or sets floating table relative vertical alignment.  |
| double [get_RightPadding](./get_rightpadding/)() | Gets or sets the amount of space (in points) to add to the right of the contents of cells.  |
| System::SharedPtr< Aspose::Words::Tables::RowCollection > [get_Rows](./get_rows/)() | Provides typed access to the rows of the table.  |
| System::SharedPtr< Aspose::Words::Style > [get_Style](./get_style/)() | Gets or sets the table style applied to this table.  |
| Aspose::Words::StyleIdentifier [get_StyleIdentifier](./get_styleidentifier/)() | Gets or sets the locale independent style identifier of the table style applied to this table.  |
| System::String [get_StyleName](./get_stylename/)() | Gets or sets the name of the table style applied to this table.  |
| Aspose::Words::Tables::TableStyleOptions [get_StyleOptions](./get_styleoptions/)() | Gets or sets bit flags that specify how a table style is applied to this table.  |
| Aspose::Words::Tables::TextWrapping [get_TextWrapping](./get_textwrapping/)() | Gets or sets TextWrapping for table.  |
| System::String [get_Title](./get_title/)() | Gets or sets title of this table. It provides an alternative text representation of the information contained in the table.  |
| double [get_TopPadding](./get_toppadding/)() | Gets or sets the amount of space (in points) to add above the contents of cells.  |
| Aspose::Words::Drawing::RelativeVerticalPosition [get_VerticalAnchor](./get_verticalanchor/)() | Gets the base object from which the vertical positioning of floating table should be calculated. Default value is Margin.  |
| void [set_AbsoluteHorizontalDistance](./set_absolutehorizontaldistance/)(double) | Setter for Aspose::Words::Tables::Table::get_AbsoluteHorizontalDistance.  |
| void [set_AbsoluteVerticalDistance](./set_absoluteverticaldistance/)(double) | Setter for Aspose::Words::Tables::Table::get_AbsoluteVerticalDistance.  |
| void [set_Alignment](./set_alignment/)(Aspose::Words::Tables::TableAlignment) | Setter for Aspose::Words::Tables::Table::get_Alignment.  |
| void [set_AllowAutoFit](./set_allowautofit/)(bool) | Setter for Aspose::Words::Tables::Table::get_AllowAutoFit.  |
| void [set_AllowCellSpacing](./set_allowcellspacing/)(bool) | Setter for Aspose::Words::Tables::Table::get_AllowCellSpacing.  |
| void [set_Bidi](./set_bidi/)(bool) | Setter for Aspose::Words::Tables::Table::get_Bidi.  |
| void [set_BottomPadding](./set_bottompadding/)(double) | Setter for Aspose::Words::Tables::Table::get_BottomPadding.  |
| void [set_CellSpacing](./set_cellspacing/)(double) | Setter for Aspose::Words::Tables::Table::get_CellSpacing.  |
| void [set_Description](./set_description/)(const System::String &) | Setter for Aspose::Words::Tables::Table::get_Description.  |
| void [set_HorizontalAnchor](./set_horizontalanchor/)(Aspose::Words::Drawing::RelativeHorizontalPosition) | Setter for Aspose::Words::Tables::Table::get_HorizontalAnchor.  |
| void [set_LeftIndent](./set_leftindent/)(double) | Setter for Aspose::Words::Tables::Table::get_LeftIndent.  |
| void [set_LeftPadding](./set_leftpadding/)(double) | Setter for Aspose::Words::Tables::Table::get_LeftPadding.  |
| void [set_PreferredWidth](./set_preferredwidth/)(const System::SharedPtr< Aspose::Words::Tables::PreferredWidth > &) | Setter for Aspose::Words::Tables::Table::get_PreferredWidth.  |
| void [set_RelativeHorizontalAlignment](./set_relativehorizontalalignment/)(Aspose::Words::Drawing::HorizontalAlignment) | Setter for Aspose::Words::Tables::Table::get_RelativeHorizontalAlignment.  |
| void [set_RelativeVerticalAlignment](./set_relativeverticalalignment/)(Aspose::Words::Drawing::VerticalAlignment) | Setter for Aspose::Words::Tables::Table::get_RelativeVerticalAlignment.  |
| void [set_RightPadding](./set_rightpadding/)(double) | Setter for Aspose::Words::Tables::Table::get_RightPadding.  |
| void [set_Style](./set_style/)(const System::SharedPtr< Aspose::Words::Style > &) | Setter for Aspose::Words::Tables::Table::get_Style.  |
| void [set_StyleIdentifier](./set_styleidentifier/)(Aspose::Words::StyleIdentifier) | Setter for Aspose::Words::Tables::Table::get_StyleIdentifier.  |
| void [set_StyleName](./set_stylename/)(const System::String &) | Setter for Aspose::Words::Tables::Table::get_StyleName.  |
| void [set_StyleOptions](./set_styleoptions/)(Aspose::Words::Tables::TableStyleOptions) | Setter for Aspose::Words::Tables::Table::get_StyleOptions.  |
| void [set_TextWrapping](./set_textwrapping/)(Aspose::Words::Tables::TextWrapping) | Setter for Aspose::Words::Tables::Table::get_TextWrapping.  |
| void [set_Title](./set_title/)(const System::String &) | Setter for Aspose::Words::Tables::Table::get_Title.  |
| void [set_TopPadding](./set_toppadding/)(double) | Setter for Aspose::Words::Tables::Table::get_TopPadding.  |
| void [set_VerticalAnchor](./set_verticalanchor/)(Aspose::Words::Drawing::RelativeVerticalPosition) | Setter for Aspose::Words::Tables::Table::get_VerticalAnchor.  |
| void [SetBorder](./setborder/)(Aspose::Words::BorderType, Aspose::Words::LineStyle, double, System::Drawing::Color, bool) | Sets the specified table border to the specified line style, width and color.  |
| void [SetBorders](./setborders/)(Aspose::Words::LineStyle, double, System::Drawing::Color) | Sets all table borders to the specified line style, width and color.  |
| void [SetShading](./setshading/)(Aspose::Words::TextureIndex, System::Drawing::Color, System::Drawing::Color) | Sets shading to the specified values on whole table.  |
