---
title: StructuredDocumentTagRangeStart
second_title: Aspose.Words for C++ API Reference
description: Represents a start of ranged structured document tag which accepts multi-sections content. See also StructuredDocumentTagRangeEnd. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/structureddocumenttagrangestart/
---
## StructuredDocumentTagRangeStart class


Represents a start of **ranged** structured document tag which accepts multi-sections content. See also StructuredDocumentTagRangeEnd. 

## Methods

| Method | Description |
| --- | --- |
|  [StructuredDocumentTagRangeStart](./structureddocumenttagrangestart/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, Aspose::Words::Markup::SdtType) | Initializes a new instance of the **Structured document tag range start** class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| System::SharedPtr< Aspose::Words::Node > [AppendChild](./appendchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the end of the stdContent range.  |
| System::SharedPtr< Aspose::Words::NodeCollection > [get_ChildNodes](./get_childnodes/)() | Gets all nodes between this range start node and the range end node.  |
| System::Drawing::Color [get_Color](./get_color/)() override | Gets or sets the color of the structured document tag.  |
| int32_t [get_Id](./get_id/)() override | Specifies a unique read-only persistent numerical Id for this structured document tag.  |
| bool [get_IsShowingPlaceholderText](./get_isshowingplaceholdertext/)() override | Specifies whether the content of this structured document tag shall be interpreted to contain placeholder text (as opposed to regular text contents within the structured document tag). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| System::SharedPtr< Aspose::Words::Node > [get_LastChild](./get_lastchild/)() | Gets the last child in the stdContent range.  |
| Aspose::Words::Markup::MarkupLevel [get_Level](./get_level/)() const override | Gets the level at which this structured document tag range start occurs in the document tree.  |
| bool [get_LockContentControl](./get_lockcontentcontrol/)() override | When set to true, this property will prohibit a user from deleting this structured document tag.  |
| bool [get_LockContents](./get_lockcontents/)() override | When set to true, this property will prohibit a user from editing the contents of this structured document tag.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Gets the type of this node.  |
| System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock > [get_Placeholder](./get_placeholder/)() override | Gets the BuildingBlock containing placeholder text which should be displayed when this structured document tag run contents are empty, the associated mapped XML element is empty as specified via the XmlMapping element or the IsShowingPlaceholderText element is true.  |
| System::String [get_PlaceholderName](./get_placeholdername/)() override | Gets or sets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTagRangeEnd > [get_RangeEnd](./get_rangeend/)() | Specifies end of range if the StructuredDocumentTag is a ranged structured document tag. Otherwise returns null.  |
| Aspose::Words::Markup::SdtType [get_SdtType](./get_sdttype/)() override | Gets type of this structured document tag.  |
| System::String [get_Tag](./get_tag/)() const override | Specifies a tag associated with the current structured document tag node. Can not be null.  |
| System::String [get_Title](./get_title/)() const override | Specifies the friendly name associated with this structured document tag. Can not be null.  |
| System::String [get_WordOpenXML](./get_wordopenxml/)() override | Gets a string that represents the XML contained within the node in the FlatOpc format.  |
| System::SharedPtr< Aspose::Words::Markup::XmlMapping > [get_XmlMapping](./get_xmlmapping/)() override | Gets an object that represents the mapping of this structured document tag range to XML data in a custom XML part of the current document.  |
| System::SharedPtr< Aspose::Words::NodeCollection > [GetChildNodes](./getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified types.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Node > > > [GetEnumerator](./getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| void [RemoveAllChildren](./removeallchildren/)() | Removes all the nodes between this range start node and the range end node.  |
| void [RemoveSelfOnly](./removeselfonly/)() | Removes this range start and appropriate range end nodes of the structured document tag, but keeps its content inside the document tree.  |
| void [set_Color](./set_color/)(System::Drawing::Color) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_Color.  |
| void [set_IsShowingPlaceholderText](./set_isshowingplaceholdertext/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_IsShowingPlaceholderText.  |
| void [set_LockContentControl](./set_lockcontentcontrol/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_LockContentControl.  |
| void [set_LockContents](./set_lockcontents/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_LockContents.  |
| void [set_PlaceholderName](./set_placeholdername/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_PlaceholderName.  |
| void [set_Tag](./set_tag/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_Tag.  |
| void [set_Title](./set_title/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_Title.  |
| void [SetTemplateWeakPtr](./settemplateweakptr/)(uint32_t) override |  |
