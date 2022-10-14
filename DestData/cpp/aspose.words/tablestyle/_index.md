---
title: TableStyle
second_title: Aspose.Words for C++ API Reference
description: Represents a table style. 
type: docs
weight: 0
url: /cpp/aspose.words/tablestyle/
---
## TableStyle class


Represents a table style. 

## Methods

| Method | Description |
| --- | --- |
| [Equals](../style/equals/)(const System::SharedPtr< Aspose::Words::Style > &) | Compares with the specified style. Styles Istds are compared for built-in styles only. Styles defaults are not included in comparison. Base style, linked style and next paragraph style are recursively compared.  |
| [get_Aliases](../style/get_aliases/)() | Gets all aliases of this style. If style has no aliases then empty array of string is returned.  |
| [get_Alignment](./get_alignment/)() | Specifies the alignment for the table style.  |
| [get_AllowBreakAcrossPages](./get_allowbreakacrosspages/)() | Gets or sets a flag indicating whether text in a table row is allowed to split across a page break.  |
| [get_BaseStyleName](../style/get_basestylename/)() | Gets/sets the name of the style this style is based on.  |
| [get_Bidi](./get_bidi/)() | Gets or sets whether this is a style for a right-to-left table.  |
| [get_Borders](./get_borders/)() | Gets the collection of default cell borders for the style.  |
| [get_BottomPadding](./get_bottompadding/)() | Gets or sets the amount of space (in points) to add below the contents of table cells.  |
| [get_BuiltIn](../style/get_builtin/)() | True if this style is one of the built-in styles in MS Word.  |
| [get_CellSpacing](./get_cellspacing/)() | Gets or sets the amount of space (in points) between the cells.  |
| [get_ColumnStripe](./get_columnstripe/)() | Gets or sets a number of columns to include in the banding when the style specifies odd/even columns banding.  |
| [get_ConditionalStyles](./get_conditionalstyles/)() | Collection of conditional styles that may be defined for this table style.  |
| [get_Document](../style/get_document/)() | Gets the owner document.  |
| [get_Font](../style/get_font/)() | Gets the character formatting of the style.  |
| [get_IsHeading](../style/get_isheading/)() | True when the style is one of the built-in Heading styles.  |
| [get_IsQuickStyle](../style/get_isquickstyle/)() const | Specifies whether this style is shown in the Quick Style gallery inside MS Word UI.  |
| [get_LeftIndent](./get_leftindent/)() | Gets or sets the value that represents the left indent of a table.  |
| [get_LeftPadding](./get_leftpadding/)() | Gets or sets the amount of space (in points) to add to the left of the contents of table cells.  |
| [get_LinkedStyleName](../style/get_linkedstylename/)() | Gets the name of the Style linked to this one. Returns Empty string if no styles are linked.  |
| [get_List](../style/get_list/)() | Gets the list that defines formatting of this list style.  |
| [get_ListFormat](../style/get_listformat/)() | Provides access to the list formatting properties of a paragraph style.  |
| [get_Name](../style/get_name/)() const | Gets or sets the name of the style.  |
| [get_NextParagraphStyleName](../style/get_nextparagraphstylename/)() | Gets/sets the name of the style to be applied automatically to a new paragraph inserted after a paragraph formatted with the specified style.  |
| [get_ParagraphFormat](../style/get_paragraphformat/)() | Gets the paragraph formatting of the style.  |
| [get_RightPadding](./get_rightpadding/)() | Gets or sets the amount of space (in points) to add to the right of the contents of table cells.  |
| [get_RowStripe](./get_rowstripe/)() | Gets or sets a number of rows to include in the banding when the style specifies odd/even row banding.  |
| [get_Shading](./get_shading/)() | Gets a Shading object that refers to the shading formatting for table cells.  |
| [get_StyleIdentifier](../style/get_styleidentifier/)() const | Gets the locale independent style identifier for a built-in style.  |
| [get_Styles](../style/get_styles/)() const | Gets the collection of styles this style belongs to.  |
| [get_TopPadding](./get_toppadding/)() | Gets or sets the amount of space (in points) to add above the contents of table cells.  |
| [get_Type](../style/get_type/)() const | Gets the style type (paragraph or character).  |
| [get_VerticalAlignment](./get_verticalalignment/)() | Specifies the vertical alignment for the cells.  |
| [Remove](../style/remove/)() | Removes the specified style from the document.  |
| [set_Alignment](./set_alignment/)(Aspose::Words::Tables::TableAlignment) | Setter for Aspose::Words::TableStyle::get_Alignment.  |
| [set_AllowBreakAcrossPages](./set_allowbreakacrosspages/)(bool) | Setter for Aspose::Words::TableStyle::get_AllowBreakAcrossPages.  |
| [set_BaseStyleName](../style/set_basestylename/)(const System::String &) | Setter for Aspose::Words::Style::get_BaseStyleName.  |
| [set_Bidi](./set_bidi/)(bool) | Setter for Aspose::Words::TableStyle::get_Bidi.  |
| [set_BottomPadding](./set_bottompadding/)(double) | Setter for Aspose::Words::TableStyle::get_BottomPadding.  |
| [set_CellSpacing](./set_cellspacing/)(double) | Setter for Aspose::Words::TableStyle::get_CellSpacing.  |
| [set_ColumnStripe](./set_columnstripe/)(int32_t) | Setter for Aspose::Words::TableStyle::get_ColumnStripe.  |
| [set_IsQuickStyle](../style/set_isquickstyle/)(bool) | Setter for Aspose::Words::Style::get_IsQuickStyle.  |
| [set_LeftIndent](./set_leftindent/)(double) | Setter for Aspose::Words::TableStyle::get_LeftIndent.  |
| [set_LeftPadding](./set_leftpadding/)(double) | Setter for Aspose::Words::TableStyle::get_LeftPadding.  |
| [set_Name](../style/set_name/)(const System::String &) | Setter for Aspose::Words::Style::get_Name.  |
| [set_NextParagraphStyleName](../style/set_nextparagraphstylename/)(const System::String &) | Setter for Aspose::Words::Style::get_NextParagraphStyleName.  |
| [set_RightPadding](./set_rightpadding/)(double) | Setter for Aspose::Words::TableStyle::get_RightPadding.  |
| [set_RowStripe](./set_rowstripe/)(int32_t) | Setter for Aspose::Words::TableStyle::get_RowStripe.  |
| [set_TopPadding](./set_toppadding/)(double) | Setter for Aspose::Words::TableStyle::get_TopPadding.  |
| [set_VerticalAlignment](./set_verticalalignment/)(Aspose::Words::Tables::CellVerticalAlignment) | Setter for Aspose::Words::TableStyle::get_VerticalAlignment.  |
