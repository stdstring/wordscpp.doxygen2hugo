---
title: Paragraph
second_title: Aspose.Words for C++ API Reference
description: Represents a paragraph of text. 
type: docs
weight: 0
url: /cpp/aspose.words/paragraph/
---
## Paragraph class


Represents a paragraph of text. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) override | Accepts a visitor.  |
| [AppendChild](../compositenode/appendchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the end of the list of child nodes for this node.  |
| [AppendField](./appendfield/)(Aspose::Words::Fields::FieldType, bool) | Appends a field to this paragraph.  |
| [AppendField](./appendfield/)(const System::String\&) | Appends a field to this paragraph.  |
| [AppendField](./appendfield/)(const System::String\&, const System::String\&) | Appends a field to this paragraph.  |
| [Clone](../node/clone/)(bool) | Creates a duplicate of the node.  |
| [get_BreakIsStyleSeparator](./get_breakisstyleseparator/)() | True if this paragraph break is a Style Separator. A style separator allows one paragraph to consist of parts that have different paragraph styles.  |
| [get_ChildNodes](../compositenode/get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Count](../compositenode/get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../node/get_customnodeid/)() const | Specifies custom node identifier.  |
| virtual [get_Document](../node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_FirstChild](../compositenode/get_firstchild/)() const | Gets the first child of the node.  |
| [get_FrameFormat](./get_frameformat/)() | Provides access to the paragraph formatting properties.  |
| [get_HasChildNodes](../compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_IsComposite](../compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_IsDeleteRevision](./get_isdeleterevision/)() | Returns true if this object was deleted in Microsoft Word while change tracking was enabled.  |
| [get_IsEndOfCell](./get_isendofcell/)() | True if this paragraph is the last paragraph in a Cell; false otherwise.  |
| [get_IsEndOfDocument](./get_isendofdocument/)() | True if this paragraph is the last paragraph in the last section of the document.  |
| [get_IsEndOfHeaderFooter](./get_isendofheaderfooter/)() | True if this paragraph is the last paragraph in the **HeaderFooter** (main text story) of a **Section**; false otherwise.  |
| [get_IsEndOfSection](./get_isendofsection/)() | True if this paragraph is the last paragraph in the **Body** (main text story) of a **Section**; false otherwise.  |
| [get_IsFormatRevision](./get_isformatrevision/)() | Returns true if formatting of the object was changed in Microsoft Word while change tracking was enabled.  |
| [get_IsInCell](./get_isincell/)() | True if this paragraph is an immediate child of Cell; false otherwise.  |
| [get_IsInsertRevision](./get_isinsertrevision/)() | Returns true if this object was inserted in Microsoft Word while change tracking was enabled.  |
| [get_IsListItem](./get_islistitem/)() | True when the paragraph is an item in a bulleted or numbered list in original revision.  |
| [get_IsMoveFromRevision](./get_ismovefromrevision/)() | Returns **true** if this object was moved (deleted) in Microsoft Word while change tracking was enabled.  |
| [get_IsMoveToRevision](./get_ismovetorevision/)() | Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled.  |
| [get_LastChild](../compositenode/get_lastchild/)() const | Gets the last child of the node.  |
| [get_ListFormat](./get_listformat/)() | Provides access to the list formatting properties of the paragraph.  |
| [get_ListLabel](./get_listlabel/)() | Gets a ListLabel object that provides access to list numbering value and formatting for this paragraph.  |
| [get_NextSibling](../node/get_nextsibling/)() | Gets the node immediately following this node.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Paragraph**.  |
| [get_ParagraphBreakFont](./get_paragraphbreakfont/)() | Provides access to the font formatting of the paragraph break character.  |
| [get_ParagraphFormat](./get_paragraphformat/)() | Provides access to the paragraph formatting properties.  |
| [get_ParentNode](../node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_ParentSection](./get_parentsection/)() | Retrieves the parent Section of the paragraph.  |
| [get_ParentStory](./get_parentstory/)() | Retrieves the parent section-level story that can be Body or HeaderFooter.  |
| [get_PreviousSibling](../node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](../node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [get_Runs](./get_runs/)() | Provides access to the typed collection of pieces of text inside the paragraph.  |
| [GetAncestor](../node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../node/getancestorof/)() |  |
| [GetChild](../compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](../compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEffectiveTabStops](./geteffectivetabstops/)() | Returns array of all tab stops applied to this paragraph, including applied indirectly by styles or lists.  |
| [GetEnumerator](../compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](./gettext/)() override | Gets the text of this paragraph including the end of paragraph character.  |
| [IndexOf](../compositenode/indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](../compositenode/insertafter/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](../compositenode/insertbefore/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately before the specified reference node.  |
| [InsertField](./insertfield/)(Aspose::Words::Fields::FieldType, bool, const System::SharedPtr\<Aspose::Words::Node\>\&, bool) | Inserts a field into this paragraph.  |
| [InsertField](./insertfield/)(const System::String\&, const System::SharedPtr\<Aspose::Words::Node\>\&, bool) | Inserts a field into this paragraph.  |
| [InsertField](./insertfield/)(const System::String\&, const System::String\&, const System::SharedPtr\<Aspose::Words::Node\>\&, bool) | Inserts a field into this paragraph.  |
| [JoinRunsWithSameFormatting](./joinrunswithsameformatting/)() | Joins runs with the same formatting in the paragraph.  |
| [NextPreOrder](../node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [Paragraph](./paragraph/)(const System::SharedPtr\<Aspose::Words::DocumentBase\>\&) | Initializes a new instance of the **Paragraph** class.  |
| [PrependChild](../compositenode/prependchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PreviousPreOrder](../node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](../compositenode/removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](../compositenode/removechild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the specified child node.  |
| [RemoveSmartTags](../compositenode/removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [SelectNodes](../compositenode/selectnodes/)(const System::String\&) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](../compositenode/selectsinglenode/)(const System::String\&) | Selects the first Node that matches the XPath expression.  |
| [set_CustomNodeId](../node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [SetTemplateWeakPtr](../compositenode/settemplateweakptr/)(uint32_t) override |  |
| [ToString](../node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options.  |
