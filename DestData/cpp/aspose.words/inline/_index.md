---
title: Inline
second_title: Aspose.Words for C++ API Reference
description: Base class for inline-level nodes that can have character formatting associated with them, but cannot have child nodes of their own. 
type: docs
weight: 0
url: /cpp/aspose.words/inline/
---
## Inline class


Base class for inline-level nodes that can have character formatting associated with them, but cannot have child nodes of their own. 

## Methods

| Method | Description |
| --- | --- |
| virtual [Accept](../node/accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) | Accepts a visitor.  |
| [Clone](../node/clone/)(bool) | Creates a duplicate of the node.  |
| [get_CustomNodeId](../node/get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](../node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_Font](./get_font/)() | Provides access to the font formatting of this object.  |
| virtual [get_IsComposite](../node/get_iscomposite/)() | Returns true if this node can contain other nodes.  |
| [get_IsDeleteRevision](./get_isdeleterevision/)() | Returns true if this object was deleted in Microsoft Word while change tracking was enabled.  |
| [get_IsFormatRevision](./get_isformatrevision/)() | Returns true if formatting of the object was changed in Microsoft Word while change tracking was enabled.  |
| [get_IsInsertRevision](./get_isinsertrevision/)() | Returns true if this object was inserted in Microsoft Word while change tracking was enabled.  |
| [get_IsMoveFromRevision](./get_ismovefromrevision/)() | Returns **true** if this object was moved (deleted) in Microsoft Word while change tracking was enabled.  |
| [get_IsMoveToRevision](./get_ismovetorevision/)() | Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled.  |
| [get_NextSibling](../node/get_nextsibling/)() | Gets the node immediately following this node.  |
| virtual [get_NodeType](../node/get_nodetype/)() const | Gets the type of this node.  |
| [get_ParentNode](../node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_ParentParagraph](./get_parentparagraph/)() | Retrieves the parent Paragraph of this node.  |
| [get_PreviousSibling](../node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](../node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [GetAncestor](../node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../node/getancestorof/)() |  |
| virtual [GetText](../node/gettext/)() | Gets the text of this node and of all its children.  |
| [NextPreOrder](../node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PreviousPreOrder](../node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../node/remove/)() | Removes itself from the parent.  |
| [set_CustomNodeId](../node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [ToString](../node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options.  |
