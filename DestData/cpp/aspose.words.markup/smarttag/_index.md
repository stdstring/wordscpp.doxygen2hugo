---
title: SmartTag
second_title: Aspose.Words for C++ API Reference
description: This element specifies the presence of a smart tag around one or more inline structures (runs, images, fields,etc.) within a paragraph. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/smarttag/
---
## SmartTag class


This element specifies the presence of a smart tag around one or more inline structures (runs, images, fields,etc.) within a paragraph. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [AppendChild](../../aspose.words/compositenode/appendchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the end of the list of child nodes for this node.  |
| [Clone](../../aspose.words/node/clone/)(bool) | Creates a duplicate of the node.  |
| [get_ChildNodes](../../aspose.words/compositenode/get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Count](../../aspose.words/compositenode/get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../../aspose.words/node/get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](../../aspose.words/node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_Element](./get_element/)() const | Specifies the name of the smart tag within the document.  |
| [get_FirstChild](../../aspose.words/compositenode/get_firstchild/)() const | Gets the first child of the node.  |
| [get_HasChildNodes](../../aspose.words/compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_IsComposite](../../aspose.words/compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_LastChild](../../aspose.words/compositenode/get_lastchild/)() const | Gets the last child of the node.  |
| [get_NextSibling](../../aspose.words/node/get_nextsibling/)() | Gets the node immediately following this node.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.SmartTag**.  |
| [get_ParentNode](../../aspose.words/node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_PreviousSibling](../../aspose.words/node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Properties](./get_properties/)() const | A collection of the smart tag properties.  |
| [get_Range](../../aspose.words/node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [get_Uri](./get_uri/)() const | Specifies the namespace URI of the smart tag.  |
| [GetAncestor](../../aspose.words/node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../../aspose.words/node/getancestorof/)() |  |
| [GetChild](../../aspose.words/compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](../../aspose.words/compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEnumerator](../../aspose.words/compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](../../aspose.words/compositenode/gettext/)() override | Gets the text of this node and of all its children.  |
| [IndexOf](../../aspose.words/compositenode/indexof/)(const System::SharedPtr< Aspose::Words::Node > &) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](../../aspose.words/compositenode/insertafter/)(const System::SharedPtr< Aspose::Words::Node > &, const System::SharedPtr< Aspose::Words::Node > &) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](../../aspose.words/compositenode/insertbefore/)(const System::SharedPtr< Aspose::Words::Node > &, const System::SharedPtr< Aspose::Words::Node > &) | Inserts the specified node immediately before the specified reference node.  |
| [NextPreOrder](../../aspose.words/node/nextpreorder/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../../aspose.words/node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PrependChild](../../aspose.words/compositenode/prependchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PreviousPreOrder](../../aspose.words/node/previouspreorder/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../../aspose.words/node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](../../aspose.words/compositenode/removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](../../aspose.words/compositenode/removechild/)(const System::SharedPtr< Aspose::Words::Node > &) | Removes the specified child node.  |
| [RemoveSmartTags](../../aspose.words/compositenode/removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [SelectNodes](../../aspose.words/compositenode/selectnodes/)(const System::String &) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](../../aspose.words/compositenode/selectsinglenode/)(const System::String &) | Selects the first Node that matches the XPath expression.  |
| [set_CustomNodeId](../../aspose.words/node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [set_Element](./set_element/)(const System::String &) | Setter for Aspose::Words::Markup::SmartTag::get_Element.  |
| [set_Uri](./set_uri/)(const System::String &) | Setter for Aspose::Words::Markup::SmartTag::get_Uri.  |
| [SetTemplateWeakPtr](../../aspose.words/compositenode/settemplateweakptr/)(uint32_t) override |  |
| [SmartTag](./smarttag/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the SmartTag class.  |
| [ToString](../../aspose.words/node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../../aspose.words/node/tostring/)(const System::SharedPtr< Aspose::Words::Saving::SaveOptions > &) | Exports the content of the node into a string using the specified save options.  |
