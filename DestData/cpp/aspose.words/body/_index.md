---
title: Body
second_title: Aspose.Words for C++ API Reference
description: Represents a container for the main text of a section. 
type: docs
weight: 0
url: /cpp/aspose.words/body/
---
## Body class


Represents a container for the main text of a section. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [AppendChild](../compositenode/appendchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the end of the list of child nodes for this node.  |
| [AppendParagraph](../story/appendparagraph/)(const System::String &) | A shortcut method that creates a Paragraph object with optional text and appends it to the end of this object.  |
| [Body](./body/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Body** class.  |
| [Clone](../node/clone/)(bool) | Creates a duplicate of the node.  |
| [DeleteShapes](../story/deleteshapes/)() | Deletes all shapes from the text of this story.  |
| [EnsureMinimum](./ensureminimum/)() | If the last child is not a paragraph, creates and appends one empty paragraph.  |
| [get_ChildNodes](../compositenode/get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Count](../compositenode/get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../node/get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](../node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_FirstChild](../compositenode/get_firstchild/)() const | Gets the first child of the node.  |
| [get_FirstParagraph](../story/get_firstparagraph/)() | Gets the first paragraph in the story.  |
| [get_HasChildNodes](../compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_IsComposite](../compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_LastChild](../compositenode/get_lastchild/)() const | Gets the last child of the node.  |
| [get_LastParagraph](../story/get_lastparagraph/)() | Gets the last paragraph in the story.  |
| [get_NextSibling](../node/get_nextsibling/)() | Gets the node immediately following this node.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Body**.  |
| [get_Paragraphs](../story/get_paragraphs/)() | Gets a collection of paragraphs that are immediate children of the story.  |
| [get_ParentNode](../node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_ParentSection](./get_parentsection/)() | Gets the parent section of this story.  |
| [get_PreviousSibling](../node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](../node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [get_StoryType](../story/get_storytype/)() const | Gets the type of this story.  |
| [get_Tables](../story/get_tables/)() | Gets a collection of tables that are immediate children of the story.  |
| [GetAncestor](../node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../node/getancestorof/)() |  |
| [GetChild](../compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](../compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEnumerator](../compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](../compositenode/gettext/)() override | Gets the text of this node and of all its children.  |
| [IndexOf](../compositenode/indexof/)(const System::SharedPtr< Aspose::Words::Node > &) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](../compositenode/insertafter/)(const System::SharedPtr< Aspose::Words::Node > &, const System::SharedPtr< Aspose::Words::Node > &) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](../compositenode/insertbefore/)(const System::SharedPtr< Aspose::Words::Node > &, const System::SharedPtr< Aspose::Words::Node > &) | Inserts the specified node immediately before the specified reference node.  |
| [NextPreOrder](../node/nextpreorder/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PrependChild](../compositenode/prependchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PreviousPreOrder](../node/previouspreorder/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](../compositenode/removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](../compositenode/removechild/)(const System::SharedPtr< Aspose::Words::Node > &) | Removes the specified child node.  |
| [RemoveSmartTags](../compositenode/removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [SelectNodes](../compositenode/selectnodes/)(const System::String &) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](../compositenode/selectsinglenode/)(const System::String &) | Selects the first Node that matches the XPath expression.  |
| [set_CustomNodeId](../node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [SetTemplateWeakPtr](../compositenode/settemplateweakptr/)(uint32_t) override |  |
| [ToString](../node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../node/tostring/)(const System::SharedPtr< Aspose::Words::Saving::SaveOptions > &) | Exports the content of the node into a string using the specified save options.  |
