---
title: Cell
second_title: Aspose.Words for C++ API Reference
description: Represents a table cell. 
type: docs
weight: 0
url: /cpp/aspose.words.tables/cell/
---
## Cell class


Represents a table cell. 

## Methods

| Method | Description |
| --- | --- |
| [Cell](./cell/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Cell** class.  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [EnsureMinimum](./ensureminimum/)() | If the last child is not a paragraph, creates and appends one empty paragraph.  |
| [get_CellFormat](./get_cellformat/)() | Provides access to the formatting properties of the cell.  |
| [get_FirstParagraph](./get_firstparagraph/)() | Gets the first paragraph among the immediate children.  |
| [get_IsFirstCell](./get_isfirstcell/)() | True if this is the first cell inside a row; false otherwise.  |
| [get_IsLastCell](./get_islastcell/)() | True if this is the last cell inside a row; false otherwise.  |
| [get_LastParagraph](./get_lastparagraph/)() | Gets the last paragraph among the immediate children.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Cell**.  |
| [get_Paragraphs](./get_paragraphs/)() | Gets a collection of paragraphs that are immediate children of the cell.  |
| [get_ParentRow](./get_parentrow/)() | Returns the parent row of the cell.  |
| [get_Tables](./get_tables/)() | Gets a collection of tables that are immediate children of the cell.  |
