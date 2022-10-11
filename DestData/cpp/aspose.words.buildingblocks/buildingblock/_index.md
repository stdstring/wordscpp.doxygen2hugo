---
title: BuildingBlock
second_title: Aspose.Words for C++ API Reference
description: Represents a glossary document entry such as a Building Block, AutoText or an AutoCorrect entry. 
type: docs
weight: 0
url: /cpp/aspose.words.buildingblocks/buildingblock/
---
## BuildingBlock class


Represents a glossary document entry such as a Building Block, AutoText or an AutoCorrect entry. 

## Methods

| Method | Description |
| --- | --- |
|  [BuildingBlock](./buildingblock/)(const System::SharedPtr< Aspose::Words::BuildingBlocks::GlossaryDocument > &) | Initializes a new instance of this class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| Aspose::Words::BuildingBlocks::BuildingBlockBehavior [get_Behavior](./get_behavior/)() const | Specifies the behavior that shall be applied when the contents of the building block is inserted into the main document.  |
| System::String [get_Category](./get_category/)() const | Specifies the second-level categorization for the building block.  |
| System::String [get_Description](./get_description/)() const | Gets or sets the description associated with this building block.  |
| System::SharedPtr< Aspose::Words::Section > [get_FirstSection](./get_firstsection/)() | Gets the first section in the building block.  |
| Aspose::Words::BuildingBlocks::BuildingBlockGallery [get_Gallery](./get_gallery/)() const | Specifies the first-level categorization for the building block for the purposes of classification or user interface sorting.  |
| System::Guid [get_Guid](./get_guid/)() const | Gets or sets an identifier (a 128-bit GUID) that uniquely identifies this building block.  |
| System::SharedPtr< Aspose::Words::Section > [get_LastSection](./get_lastsection/)() | Gets the last section in the building block.  |
| System::String [get_Name](./get_name/)() const | Gets or sets the name of this building block.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns the BuildingBlock value.  |
| System::SharedPtr< Aspose::Words::SectionCollection > [get_Sections](./get_sections/)() | Returns a collection that represents all sections in the building block.  |
| Aspose::Words::BuildingBlocks::BuildingBlockType [get_Type](./get_type/)() const | Specifies the building block type.  |
| void [set_Behavior](./set_behavior/)(Aspose::Words::BuildingBlocks::BuildingBlockBehavior) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Behavior.  |
| void [set_Category](./set_category/)(const System::String &) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Category.  |
| void [set_Description](./set_description/)(const System::String &) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Description.  |
| void [set_Gallery](./set_gallery/)(Aspose::Words::BuildingBlocks::BuildingBlockGallery) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Gallery.  |
| void [set_Guid](./set_guid/)(System::Guid) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Guid.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Name.  |
| void [set_Type](./set_type/)(Aspose::Words::BuildingBlocks::BuildingBlockType) | Setter for Aspose::Words::BuildingBlocks::BuildingBlock::get_Type.  |
