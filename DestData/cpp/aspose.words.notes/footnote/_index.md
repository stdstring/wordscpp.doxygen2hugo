---
title: Footnote
second_title: Aspose.Words for C++ API Reference
description: Represents a container for text of a footnote or endnote. 
type: docs
weight: 0
url: /cpp/aspose.words.notes/footnote/
---
## Footnote class


Represents a container for text of a footnote or endnote.

```cpp
class Footnote : public Aspose::Words::InlineStory, public Aspose::Words::Revisions::ITrackableNode
```

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) override | Accepts a visitor. |
| [AppendChild](../../aspose.words/compositenode/appendchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the end of the list of child nodes for this node. |
| [Clone](../../aspose.words/node/clone/)(bool) | Creates a duplicate of the node. |
| [EnsureMinimum](../../aspose.words/inlinestory/ensureminimum/)() | If the last child is not a paragraph, creates and appends one empty paragraph. |
| [Footnote](./footnote/)(const System::SharedPtr\<Aspose::Words::DocumentBase\>\&, Aspose::Words::Notes::FootnoteType) | Initializes an instance of the **Footnote** class. |
| [get_ChildNodes](../../aspose.words/compositenode/get_childnodes/)() | Gets all immediate child nodes of this node. |
| [get_Count](../../aspose.words/compositenode/get_count/)() | Gets the number of immediate children of this node. |
| [get_CustomNodeId](../../aspose.words/node/get_customnodeid/)() const | Specifies custom node identifier. |
| virtual [get_Document](../../aspose.words/node/get_document/)() const | Gets the document to which this node belongs. |
| [get_FirstChild](../../aspose.words/compositenode/get_firstchild/)() const | Gets the first child of the node. |
| [get_FirstParagraph](../../aspose.words/inlinestory/get_firstparagraph/)() | Gets the first paragraph in the story. |
| [get_Font](../../aspose.words/inlinestory/get_font/)() | Provides access to the font formatting of the anchor character of this object. |
| [get_FootnoteType](./get_footnotetype/)() const | Returns a value that specifies whether this is a footnote or endnote. |
| [get_HasChildNodes](../../aspose.words/compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes. |
| [get_IsAuto](./get_isauto/)() const | Holds a value that specifies whether this is a auto-numbered footnote or footnote with user defined custom reference mark. |
| [get_IsComposite](../../aspose.words/compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes. |
| [get_IsDeleteRevision](../../aspose.words/inlinestory/get_isdeleterevision/)() | Returns true if this object was deleted in Microsoft Word while change tracking was enabled. |
| [get_IsInsertRevision](../../aspose.words/inlinestory/get_isinsertrevision/)() | Returns true if this object was inserted in Microsoft Word while change tracking was enabled. |
| [get_IsMoveFromRevision](../../aspose.words/inlinestory/get_ismovefromrevision/)() | Returns **true** if this object was moved (deleted) in Microsoft Word while change tracking was enabled. |
| [get_IsMoveToRevision](../../aspose.words/inlinestory/get_ismovetorevision/)() | Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled. |
| [get_LastChild](../../aspose.words/compositenode/get_lastchild/)() const | Gets the last child of the node. |
| [get_LastParagraph](../../aspose.words/inlinestory/get_lastparagraph/)() | Gets the last paragraph in the story. |
| [get_NextSibling](../../aspose.words/node/get_nextsibling/)() | Gets the node immediately following this node. |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Footnote**. |
| [get_Paragraphs](../../aspose.words/inlinestory/get_paragraphs/)() | Gets a collection of paragraphs that are immediate children of the story. |
| [get_ParentNode](../../aspose.words/node/get_parentnode/)() | Gets the immediate parent of this node. |
| [get_ParentParagraph](../../aspose.words/inlinestory/get_parentparagraph/)() | Retrieves the parent [Paragraph](../../aspose.words/paragraph/) of this node. |
| [get_PreviousSibling](../../aspose.words/node/get_previoussibling/)() | Gets the node immediately preceding this node. |
| [get_Range](../../aspose.words/node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node. |
| [get_ReferenceMark](./get_referencemark/)() const | Gets/sets custom reference mark to be used for this footnote. Default value is **empty string**, meaning auto-numbered footnotes are used. |
| [get_StoryType](./get_storytype/)() override | Returns **StoryType.Footnotes** or **StoryType.Endnotes**. |
| [get_Tables](../../aspose.words/inlinestory/get_tables/)() | Gets a collection of tables that are immediate children of the story. |
| [GetAncestor](../../aspose.words/node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified [NodeType](../../aspose.words/nodetype/). |
| [GetAncestorOf](../../aspose.words/node/getancestorof/)() |  |
| [GetChild](../../aspose.words/compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type. |
| [GetChildNodes](../../aspose.words/compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type. |
| [GetEnumerator](../../aspose.words/compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node. |
| [GetText](../../aspose.words/compositenode/gettext/)() override | Gets the text of this node and of all its children. |
| [IndexOf](../../aspose.words/compositenode/indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the index of the specified child node in the child node array. |
| [InsertAfter](../../aspose.words/compositenode/insertafter/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately after the specified reference node. |
| [InsertBefore](../../aspose.words/compositenode/insertbefore/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately before the specified reference node. |
| [NextPreOrder](../../aspose.words/node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm. |
| static [NodeTypeToString](../../aspose.words/node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string. |
| [PrependChild](../../aspose.words/compositenode/prependchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the beginning of the list of child nodes for this node. |
| [PreviousPreOrder](../../aspose.words/node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm. |
| [Remove](../../aspose.words/node/remove/)() | Removes itself from the parent. |
| [RemoveAllChildren](../../aspose.words/compositenode/removeallchildren/)() | Removes all the child nodes of the current node. |
| [RemoveChild](../../aspose.words/compositenode/removechild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the specified child node. |
| [RemoveSmartTags](../../aspose.words/compositenode/removesmarttags/)() | Removes all [SmartTag](../../aspose.words.markup/smarttag/) descendant nodes of the current node. |
| [SelectNodes](../../aspose.words/compositenode/selectnodes/)(const System::String\&) | Selects a list of nodes matching the XPath expression. |
| [SelectSingleNode](../../aspose.words/compositenode/selectsinglenode/)(const System::String\&) | Selects the first [Node](../../aspose.words/node/) that matches the XPath expression. |
| [set_CustomNodeId](../../aspose.words/node/set_customnodeid/)(int32_t) | Setter for [Aspose::Words::Node::get_CustomNodeId](../../aspose.words/node/get_customnodeid/). |
| [set_IsAuto](./set_isauto/)(bool) | Setter for [Aspose::Words::Notes::Footnote::get_IsAuto](./get_isauto/). |
| [set_ReferenceMark](./set_referencemark/)(const System::String\&) | Setter for [Aspose::Words::Notes::Footnote::get_ReferenceMark](./get_referencemark/). |
| [SetTemplateWeakPtr](../../aspose.words/compositenode/settemplateweakptr/)(uint32_t) override |  |
| [ToString](../../aspose.words/node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format. |
| [ToString](../../aspose.words/node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options. |

The **Footnote** class is used to represent both footnotes and endnotes in a Word document.

**Footnote** is an inline-level node and can only be a child of **Paragraph**.

**Footnote** can contain **Paragraph** and **Table** child nodes.

## Examples




Shows how to insert and customize footnotes. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Add text, and reference it with a footnote. This footnote will place a small superscript reference
// mark after the text that it references and create an entry below the main body text at the bottom of the page.
// This entry will contain the footnote's reference mark and the reference text,
// which we will pass to the document builder's "InsertFootnote" method.
builder->Write(u"Main body text.");
SharedPtr<Footnote> footnote = builder->InsertFootnote(FootnoteType::Footnote, u"Footnote text.");

// If this property is set to "true", then our footnote's reference mark
// will be its index among all the section's footnotes.
// This is the first footnote, so the reference mark will be "1".
ASSERT_TRUE(footnote->get_IsAuto());

// We can move the document builder inside the footnote to edit its reference text.
builder->MoveTo(footnote->get_FirstParagraph());
builder->Write(u" More text added by a DocumentBuilder.");
builder->MoveToDocumentEnd();

ASSERT_EQ(u"\u0002 Footnote text. More text added by a DocumentBuilder.", footnote->GetText().Trim());

builder->Write(u" More main body text.");
footnote = builder->InsertFootnote(FootnoteType::Footnote, u"Footnote text.");

// We can set a custom reference mark which the footnote will use instead of its index number.
footnote->set_ReferenceMark(u"RefMark");

ASSERT_FALSE(footnote->get_IsAuto());

// A bookmark with the "IsAuto" flag set to true will still show its real index
// even if previous bookmarks display custom reference marks, so this bookmark's reference mark will be a "3".
builder->Write(u" More main body text.");
footnote = builder->InsertFootnote(FootnoteType::Footnote, u"Footnote text.");

ASSERT_TRUE(footnote->get_IsAuto());

doc->Save(ArtifactsDir + u"InlineStory.AddFootnote.docx");
```

