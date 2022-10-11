---
title: GlossaryDocument
second_title: Aspose.Words for C++ API Reference
description: Represents the root element for a glossary document within a Word document. A glossary document is a storage for AutoText, AutoCorrect entries and Building Blocks. 
type: docs
weight: 0
url: /cpp/aspose.words.buildingblocks/glossarydocument/
---
## GlossaryDocument class


Represents the root element for a glossary document within a Word document. A glossary document is a storage for AutoText, AutoCorrect entries and Building Blocks. 

## Methods

| Method | Description |
| --- | --- |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlockCollection > [get_BuildingBlocks](./get_buildingblocks/)() | Returns a typed collection that represents all building blocks in the glossary document.  |
| System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock > [get_FirstBuildingBlock](./get_firstbuildingblock/)() | Gets the first building block in the glossary document.  |
| System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock > [get_LastBuildingBlock](./get_lastbuildingblock/)() | Gets the last building block in the glossary document.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns the GlossaryDocument value.  |
| System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock > [GetBuildingBlock](./getbuildingblock/)(Aspose::Words::BuildingBlocks::BuildingBlockGallery, const System::String &, const System::String &) | Finds a building block using the specified gallery, category and name.  |
