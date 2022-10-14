---
title: CompositeNode
second_title: Aspose.Words for C++ API Reference
description: Base class for nodes that can contain other nodes. 
type: docs
weight: 0
url: /cpp/aspose.words/compositenode/
---
## CompositeNode class


Base class for nodes that can contain other nodes. 

## Methods

| Method | Description |
| --- | --- |
| virtual [Accept](../node/accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) | Accepts a visitor.  |
| [AppendChild](./appendchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the end of the list of child nodes for this node.  |
| [Clone](../node/clone/)(bool) | Creates a duplicate of the node.  |
| [get_ChildNodes](./get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Count](./get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../node/get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](../node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_FirstChild](./get_firstchild/)() const | Gets the first child of the node.  |
| [get_HasChildNodes](./get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_IsComposite](./get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_LastChild](./get_lastchild/)() const | Gets the last child of the node.  |
| [get_NextSibling](../node/get_nextsibling/)() | Gets the node immediately following this node.  |
| virtual [get_NodeType](../node/get_nodetype/)() const | Gets the type of this node.  |
| [get_ParentNode](../node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_PreviousSibling](../node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](../node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [GetAncestor](../node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../node/getancestorof/)() |  |
| [GetChild](./getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](./getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEnumerator](./getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](./gettext/)() override | Gets the text of this node and of all its children.  |
| [IndexOf](./indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](./insertafter/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](./insertbefore/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately before the specified reference node.  |
| [NextPreOrder](../node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PrependChild](./prependchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PreviousPreOrder](../node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](./removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](./removechild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the specified child node.  |
| [RemoveSmartTags](./removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [SelectNodes](./selectnodes/)(const System::String\&) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](./selectsinglenode/)(const System::String\&) | Selects the first Node that matches the XPath expression.  |
| [set_CustomNodeId](../node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [SetTemplateWeakPtr](./settemplateweakptr/)(uint32_t) override |  |
| [ToString](../node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options.  |
