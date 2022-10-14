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
| [Accept](./accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) override | Accepts a visitor.  |
| [AppendChild](../../aspose.words/compositenode/appendchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the end of the list of child nodes for this node.  |
| [AutoFit](./autofit/)(Aspose::Words::Tables::AutoFitBehavior) | Resizes the table and cells according to the specified auto fit behavior.  |
| [ClearBorders](./clearborders/)() | Removes all table and cell borders on this table.  |
| [ClearShading](./clearshading/)() | Removes all shading on the table.  |
| [Clone](../../aspose.words/node/clone/)(bool) | Creates a duplicate of the node.  |
| [ConvertToHorizontallyMergedCells](./converttohorizontallymergedcells/)() | Converts cells horizontally merged by width to cells merged by HorizontalMerge.  |
| [EnsureMinimum](./ensureminimum/)() | If the table has no rows, creates and appends one **Row**.  |
| [get_AbsoluteHorizontalDistance](./get_absolutehorizontaldistance/)() | Gets or sets absolute horizontal floating table position specified by the table properties, in points. Default value is 0.  |
| [get_AbsoluteVerticalDistance](./get_absoluteverticaldistance/)() | Gets or sets absolute vertical floating table position specified by the table properties, in points. Default value is 0.  |
| [get_Alignment](./get_alignment/)() | Specifies how an inline table is aligned in the document.  |
| [get_AllowAutoFit](./get_allowautofit/)() | Allows Microsoft Word and Aspose.Words to automatically resize cells in a table to fit their contents.  |
| [get_AllowCellSpacing](./get_allowcellspacing/)() | Gets or sets the "Allow spacing between cells" option.  |
| [get_AllowOverlap](./get_allowoverlap/)() | Gets whether a floating table shall allow other floating objects in the document to overlap its extents when displayed. Default value is **true**.  |
| [get_Bidi](./get_bidi/)() | Gets or sets whether this is a right-to-left table.  |
| [get_BottomPadding](./get_bottompadding/)() | Gets or sets the amount of space (in points) to add below the contents of cells.  |
| [get_CellSpacing](./get_cellspacing/)() | Gets or sets the amount of space (in points) between the cells.  |
| [get_ChildNodes](../../aspose.words/compositenode/get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Count](../../aspose.words/compositenode/get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../../aspose.words/node/get_customnodeid/)() const | Specifies custom node identifier.  |
| [get_Description](./get_description/)() | Gets or sets description of this table. It provides an alternative text representation of the information contained in the table.  |
| [get_DistanceBottom](./get_distancebottom/)() | Gets distance between table bottom and the surrounding text, in points.  |
| [get_DistanceLeft](./get_distanceleft/)() | Gets distance between table left and the surrounding text, in points.  |
| [get_DistanceRight](./get_distanceright/)() | Gets distance between table right and the surrounding text, in points.  |
| [get_DistanceTop](./get_distancetop/)() | Gets distance between table top and the surrounding text, in points.  |
| virtual [get_Document](../../aspose.words/node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_FirstChild](../../aspose.words/compositenode/get_firstchild/)() const | Gets the first child of the node.  |
| [get_FirstRow](./get_firstrow/)() | Returns the first **Row** node in the table.  |
| [get_HasChildNodes](../../aspose.words/compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_HorizontalAnchor](./get_horizontalanchor/)() | Gets the base object from which the horizontal positioning of floating table should be calculated. Default value is Column.  |
| [get_IsComposite](../../aspose.words/compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_LastChild](../../aspose.words/compositenode/get_lastchild/)() const | Gets the last child of the node.  |
| [get_LastRow](./get_lastrow/)() | Returns the last **Row** node in the table.  |
| [get_LeftIndent](./get_leftindent/)() | Gets or sets the value that represents the left indent of the table.  |
| [get_LeftPadding](./get_leftpadding/)() | Gets or sets the amount of space (in points) to add to the left of the contents of cells.  |
| [get_NextSibling](../../aspose.words/node/get_nextsibling/)() | Gets the node immediately following this node.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Table**.  |
| [get_ParentNode](../../aspose.words/node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_PreferredWidth](./get_preferredwidth/)() | Gets or sets the table preferred width.  |
| [get_PreviousSibling](../../aspose.words/node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](../../aspose.words/node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [get_RelativeHorizontalAlignment](./get_relativehorizontalalignment/)() | Gets or sets floating table relative horizontal alignment.  |
| [get_RelativeVerticalAlignment](./get_relativeverticalalignment/)() | Gets or sets floating table relative vertical alignment.  |
| [get_RightPadding](./get_rightpadding/)() | Gets or sets the amount of space (in points) to add to the right of the contents of cells.  |
| [get_Rows](./get_rows/)() | Provides typed access to the rows of the table.  |
| [get_Style](./get_style/)() | Gets or sets the table style applied to this table.  |
| [get_StyleIdentifier](./get_styleidentifier/)() | Gets or sets the locale independent style identifier of the table style applied to this table.  |
| [get_StyleName](./get_stylename/)() | Gets or sets the name of the table style applied to this table.  |
| [get_StyleOptions](./get_styleoptions/)() | Gets or sets bit flags that specify how a table style is applied to this table.  |
| [get_TextWrapping](./get_textwrapping/)() | Gets or sets TextWrapping for table.  |
| [get_Title](./get_title/)() | Gets or sets title of this table. It provides an alternative text representation of the information contained in the table.  |
| [get_TopPadding](./get_toppadding/)() | Gets or sets the amount of space (in points) to add above the contents of cells.  |
| [get_VerticalAnchor](./get_verticalanchor/)() | Gets the base object from which the vertical positioning of floating table should be calculated. Default value is Margin.  |
| [GetAncestor](../../aspose.words/node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../../aspose.words/node/getancestorof/)() |  |
| [GetChild](../../aspose.words/compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](../../aspose.words/compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEnumerator](../../aspose.words/compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](../../aspose.words/compositenode/gettext/)() override | Gets the text of this node and of all its children.  |
| [IndexOf](../../aspose.words/compositenode/indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](../../aspose.words/compositenode/insertafter/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](../../aspose.words/compositenode/insertbefore/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately before the specified reference node.  |
| [NextPreOrder](../../aspose.words/node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../../aspose.words/node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PrependChild](../../aspose.words/compositenode/prependchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PreviousPreOrder](../../aspose.words/node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../../aspose.words/node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](../../aspose.words/compositenode/removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](../../aspose.words/compositenode/removechild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the specified child node.  |
| [RemoveSmartTags](../../aspose.words/compositenode/removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [SelectNodes](../../aspose.words/compositenode/selectnodes/)(const System::String\&) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](../../aspose.words/compositenode/selectsinglenode/)(const System::String\&) | Selects the first Node that matches the XPath expression.  |
| [set_AbsoluteHorizontalDistance](./set_absolutehorizontaldistance/)(double) | Setter for Aspose::Words::Tables::Table::get_AbsoluteHorizontalDistance.  |
| [set_AbsoluteVerticalDistance](./set_absoluteverticaldistance/)(double) | Setter for Aspose::Words::Tables::Table::get_AbsoluteVerticalDistance.  |
| [set_Alignment](./set_alignment/)(Aspose::Words::Tables::TableAlignment) | Setter for Aspose::Words::Tables::Table::get_Alignment.  |
| [set_AllowAutoFit](./set_allowautofit/)(bool) | Setter for Aspose::Words::Tables::Table::get_AllowAutoFit.  |
| [set_AllowCellSpacing](./set_allowcellspacing/)(bool) | Setter for Aspose::Words::Tables::Table::get_AllowCellSpacing.  |
| [set_Bidi](./set_bidi/)(bool) | Setter for Aspose::Words::Tables::Table::get_Bidi.  |
| [set_BottomPadding](./set_bottompadding/)(double) | Setter for Aspose::Words::Tables::Table::get_BottomPadding.  |
| [set_CellSpacing](./set_cellspacing/)(double) | Setter for Aspose::Words::Tables::Table::get_CellSpacing.  |
| [set_CustomNodeId](../../aspose.words/node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [set_Description](./set_description/)(const System::String\&) | Setter for Aspose::Words::Tables::Table::get_Description.  |
| [set_HorizontalAnchor](./set_horizontalanchor/)(Aspose::Words::Drawing::RelativeHorizontalPosition) | Setter for Aspose::Words::Tables::Table::get_HorizontalAnchor.  |
| [set_LeftIndent](./set_leftindent/)(double) | Setter for Aspose::Words::Tables::Table::get_LeftIndent.  |
| [set_LeftPadding](./set_leftpadding/)(double) | Setter for Aspose::Words::Tables::Table::get_LeftPadding.  |
| [set_PreferredWidth](./set_preferredwidth/)(const System::SharedPtr\<Aspose::Words::Tables::PreferredWidth\>\&) | Setter for Aspose::Words::Tables::Table::get_PreferredWidth.  |
| [set_RelativeHorizontalAlignment](./set_relativehorizontalalignment/)(Aspose::Words::Drawing::HorizontalAlignment) | Setter for Aspose::Words::Tables::Table::get_RelativeHorizontalAlignment.  |
| [set_RelativeVerticalAlignment](./set_relativeverticalalignment/)(Aspose::Words::Drawing::VerticalAlignment) | Setter for Aspose::Words::Tables::Table::get_RelativeVerticalAlignment.  |
| [set_RightPadding](./set_rightpadding/)(double) | Setter for Aspose::Words::Tables::Table::get_RightPadding.  |
| [set_Style](./set_style/)(const System::SharedPtr\<Aspose::Words::Style\>\&) | Setter for Aspose::Words::Tables::Table::get_Style.  |
| [set_StyleIdentifier](./set_styleidentifier/)(Aspose::Words::StyleIdentifier) | Setter for Aspose::Words::Tables::Table::get_StyleIdentifier.  |
| [set_StyleName](./set_stylename/)(const System::String\&) | Setter for Aspose::Words::Tables::Table::get_StyleName.  |
| [set_StyleOptions](./set_styleoptions/)(Aspose::Words::Tables::TableStyleOptions) | Setter for Aspose::Words::Tables::Table::get_StyleOptions.  |
| [set_TextWrapping](./set_textwrapping/)(Aspose::Words::Tables::TextWrapping) | Setter for Aspose::Words::Tables::Table::get_TextWrapping.  |
| [set_Title](./set_title/)(const System::String\&) | Setter for Aspose::Words::Tables::Table::get_Title.  |
| [set_TopPadding](./set_toppadding/)(double) | Setter for Aspose::Words::Tables::Table::get_TopPadding.  |
| [set_VerticalAnchor](./set_verticalanchor/)(Aspose::Words::Drawing::RelativeVerticalPosition) | Setter for Aspose::Words::Tables::Table::get_VerticalAnchor.  |
| [SetBorder](./setborder/)(Aspose::Words::BorderType, Aspose::Words::LineStyle, double, System::Drawing::Color, bool) | Sets the specified table border to the specified line style, width and color.  |
| [SetBorders](./setborders/)(Aspose::Words::LineStyle, double, System::Drawing::Color) | Sets all table borders to the specified line style, width and color.  |
| [SetShading](./setshading/)(Aspose::Words::TextureIndex, System::Drawing::Color, System::Drawing::Color) | Sets shading to the specified values on whole table.  |
| [SetTemplateWeakPtr](../../aspose.words/compositenode/settemplateweakptr/)(uint32_t) override |  |
| [Table](./table/)(const System::SharedPtr\<Aspose::Words::DocumentBase\>\&) | Initializes a new instance of the **Table** class.  |
| [ToString](../../aspose.words/node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../../aspose.words/node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options.  |
