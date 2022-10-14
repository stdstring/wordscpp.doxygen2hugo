---
title: Section
second_title: Aspose.Words for C++ API Reference
description: Represents a single section in a document. 
type: docs
weight: 0
url: /cpp/aspose.words/section/
---
## Section class


Represents a single section in a document. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) override | Accepts a visitor.  |
| [AppendChild](../compositenode/appendchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the end of the list of child nodes for this node.  |
| [AppendContent](./appendcontent/)(const System::SharedPtr\<Aspose::Words::Section\>\&) | Inserts a copy of content of the source section at the end of this section.  |
| [ClearContent](./clearcontent/)() | Clears the section.  |
| [ClearHeadersFooters](./clearheadersfooters/)() | Clears the headers and footers of this section.  |
| [Clone](./clone/)() | Creates a duplicate of this section.  |
| [Clone](../node/clone/)(bool) | Creates a duplicate of the node.  |
| [DeleteHeaderFooterShapes](./deleteheaderfootershapes/)() | Deletes all shapes (drawing objects) from the headers and footers of this section.  |
| [EnsureMinimum](./ensureminimum/)() | Ensures that the section has Body with one Paragraph.  |
| [get_Body](./get_body/)() | Returns the **Body** child node of the section.  |
| [get_ChildNodes](../compositenode/get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Count](../compositenode/get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../node/get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](../node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_FirstChild](../compositenode/get_firstchild/)() const | Gets the first child of the node.  |
| [get_HasChildNodes](../compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_HeadersFooters](./get_headersfooters/)() | Provides access to the headers and footers nodes of the section.  |
| [get_IsComposite](../compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_LastChild](../compositenode/get_lastchild/)() const | Gets the last child of the node.  |
| [get_NextSibling](../node/get_nextsibling/)() | Gets the node immediately following this node.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Section**.  |
| [get_PageSetup](./get_pagesetup/)() | Returns an object that represents page setup and section properties.  |
| [get_ParentNode](../node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_PreviousSibling](../node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_ProtectedForForms](./get_protectedforforms/)() | True if the section is protected for forms. When a section is protected for forms, users can select and modify text only in form fields in Microsoft Word.  |
| [get_Range](../node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [GetAncestor](../node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../node/getancestorof/)() |  |
| [GetChild](../compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](../compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEnumerator](../compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](../compositenode/gettext/)() override | Gets the text of this node and of all its children.  |
| [IndexOf](../compositenode/indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](../compositenode/insertafter/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](../compositenode/insertbefore/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately before the specified reference node.  |
| [NextPreOrder](../node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PrependChild](../compositenode/prependchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PrependContent](./prependcontent/)(const System::SharedPtr\<Aspose::Words::Section\>\&) | Inserts a copy of content of the source section at the beginning of this section.  |
| [PreviousPreOrder](../node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](../compositenode/removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](../compositenode/removechild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the specified child node.  |
| [RemoveSmartTags](../compositenode/removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [Section](./section/)(const System::SharedPtr\<Aspose::Words::DocumentBase\>\&) | Initializes a new instance of the Section class.  |
| [SelectNodes](../compositenode/selectnodes/)(const System::String\&) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](../compositenode/selectsinglenode/)(const System::String\&) | Selects the first Node that matches the XPath expression.  |
| [set_CustomNodeId](../node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [set_ProtectedForForms](./set_protectedforforms/)(bool) | Setter for Aspose::Words::Section::get_ProtectedForForms.  |
| [SetTemplateWeakPtr](../compositenode/settemplateweakptr/)(uint32_t) override |  |
| [ToString](../node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options.  |
