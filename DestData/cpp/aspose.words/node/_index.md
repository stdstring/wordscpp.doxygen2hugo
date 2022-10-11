---
title: Node
second_title: Aspose.Words for C++ API Reference
description: Base class for all nodes of a Word document. 
type: docs
weight: 0
url: /cpp/aspose.words/node/
---
## Node class


Base class for all nodes of a Word document. 

## Methods

| Method | Description |
| --- | --- |
| virtual [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) | Accepts a visitor.  |
| [Clone](./clone/)(bool) | Creates a duplicate of the node.  |
| [get_CustomNodeId](./get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](./get_document/)() const | Gets the document to which this node belongs.  |
| virtual [get_IsComposite](./get_iscomposite/)() | Returns true if this node can contain other nodes.  |
| [get_NextSibling](./get_nextsibling/)() | Gets the node immediately following this node.  |
| virtual [get_NodeType](./get_nodetype/)() const | Gets the type of this node.  |
| [get_ParentNode](./get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_PreviousSibling](./get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](./get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [GetAncestor](./getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](./getancestorof/)() |  |
| virtual [GetText](./gettext/)() | Gets the text of this node and of all its children.  |
| [NextPreOrder](./nextpreorder/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets next node according to the pre-order tree traversal algorithm.  |
| [PreviousPreOrder](./previouspreorder/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](./remove/)() | Removes itself from the parent.  |
| [set_CustomNodeId](./set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [ToString](./tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](./tostring/)(const System::SharedPtr< Aspose::Words::Saving::SaveOptions > &) | Exports the content of the node into a string using the specified save options.  |
| static [NodeTypeToString](./nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |