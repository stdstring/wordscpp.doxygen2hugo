---
title: Row
second_title: Aspose.Words for C++ API Reference
description: Represents a table row. 
type: docs
weight: 0
url: /cpp/aspose.words.tables/row/
---
## Row class


Represents a table row. 

## Methods

| Method | Description |
| --- | --- |
|  [Row](./row/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Row** class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| void [EnsureMinimum](./ensureminimum/)() | If the **Row** has no cells, creates and appends one **Cell**.  |
| System::SharedPtr< Aspose::Words::Tables::CellCollection > [get_Cells](./get_cells/)() | Provides typed access to the **Cell** child nodes of the row.  |
| System::SharedPtr< Aspose::Words::Tables::Cell > [get_FirstCell](./get_firstcell/)() | Returns the first **Cell** in the row.  |
| bool [get_IsFirstRow](./get_isfirstrow/)() | True if this is the first row in a table; false otherwise.  |
| bool [get_IsLastRow](./get_islastrow/)() | True if this is the last row in a table; false otherwise.  |
| System::SharedPtr< Aspose::Words::Tables::Cell > [get_LastCell](./get_lastcell/)() | Returns the last **Cell** in the row.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Row**.  |
| System::SharedPtr< Aspose::Words::Tables::Table > [get_ParentTable](./get_parenttable/)() | Returns the immediate parent table of the row.  |
| System::SharedPtr< Aspose::Words::Tables::RowFormat > [get_RowFormat](./get_rowformat/)() | Provides access to the formatting properties of the row.  |
| System::String [GetText](./gettext/)() override | Gets the text of all cells in this row including the end of row character.  |
