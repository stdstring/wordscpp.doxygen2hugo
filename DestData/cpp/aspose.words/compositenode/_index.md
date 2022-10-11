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
| System::SharedPtr< Aspose::Words::Node > [AppendChild](./appendchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the end of the list of child nodes for this node.  |
| System::SharedPtr< Aspose::Words::NodeCollection > [get_ChildNodes](./get_childnodes/)() | Gets all immediate child nodes of this node.  |
| int32_t [get_Count](./get_count/)() | Gets the number of immediate children of this node.  |
| System::SharedPtr< Aspose::Words::Node > [get_FirstChild](./get_firstchild/)() const | Gets the first child of the node.  |
| bool [get_HasChildNodes](./get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| bool [get_IsComposite](./get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| System::SharedPtr< Aspose::Words::Node > [get_LastChild](./get_lastchild/)() const | Gets the last child of the node.  |
| System::SharedPtr< Aspose::Words::Node > [GetChild](./getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| System::SharedPtr< Aspose::Words::NodeCollection > [GetChildNodes](./getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Node > > > [GetEnumerator](./getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| System::String [GetText](./gettext/)() override | Gets the text of this node and of all its children.  |
| int32_t [IndexOf](./indexof/)(const System::SharedPtr< Aspose::Words::Node > &) | Returns the index of the specified child node in the child node array.  |
| System::SharedPtr< Aspose::Words::Node > [InsertAfter](./insertafter/)(const System::SharedPtr< Aspose::Words::Node > &, const System::SharedPtr< Aspose::Words::Node > &) | Inserts the specified node immediately after the specified reference node.  |
| System::SharedPtr< Aspose::Words::Node > [InsertBefore](./insertbefore/)(const System::SharedPtr< Aspose::Words::Node > &, const System::SharedPtr< Aspose::Words::Node > &) | Inserts the specified node immediately before the specified reference node.  |
| System::SharedPtr< Aspose::Words::Node > [PrependChild](./prependchild/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| void [RemoveAllChildren](./removeallchildren/)() | Removes all the child nodes of the current node.  |
| System::SharedPtr< Aspose::Words::Node > [RemoveChild](./removechild/)(const System::SharedPtr< Aspose::Words::Node > &) | Removes the specified child node.  |
| void [RemoveSmartTags](./removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| System::SharedPtr< Aspose::Words::NodeList > [SelectNodes](./selectnodes/)(const System::String &) | Selects a list of nodes matching the XPath expression.  |
| System::SharedPtr< Aspose::Words::Node > [SelectSingleNode](./selectsinglenode/)(const System::String &) | Selects the first Node that matches the XPath expression.  |
| void [SetTemplateWeakPtr](./settemplateweakptr/)(uint32_t) override |  |
