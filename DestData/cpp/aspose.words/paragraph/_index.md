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
| [Paragraph](./paragraph/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Paragraph** class.  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [AppendField](./appendfield/)(Aspose::Words::Fields::FieldType, bool) | Appends a field to this paragraph.  |
| [AppendField](./appendfield/)(const System::String &) | Appends a field to this paragraph.  |
| [AppendField](./appendfield/)(const System::String &, const System::String &) | Appends a field to this paragraph.  |
| [get_BreakIsStyleSeparator](./get_breakisstyleseparator/)() | True if this paragraph break is a Style Separator. A style separator allows one paragraph to consist of parts that have different paragraph styles.  |
| [get_FrameFormat](./get_frameformat/)() | Provides access to the paragraph formatting properties.  |
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
| [get_ListFormat](./get_listformat/)() | Provides access to the list formatting properties of the paragraph.  |
| [get_ListLabel](./get_listlabel/)() | Gets a ListLabel object that provides access to list numbering value and formatting for this paragraph.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Paragraph**.  |
| [get_ParagraphBreakFont](./get_paragraphbreakfont/)() | Provides access to the font formatting of the paragraph break character.  |
| [get_ParagraphFormat](./get_paragraphformat/)() | Provides access to the paragraph formatting properties.  |
| [get_ParentSection](./get_parentsection/)() | Retrieves the parent Section of the paragraph.  |
| [get_ParentStory](./get_parentstory/)() | Retrieves the parent section-level story that can be Body or HeaderFooter.  |
| [get_Runs](./get_runs/)() | Provides access to the typed collection of pieces of text inside the paragraph.  |
| [GetEffectiveTabStops](./geteffectivetabstops/)() | Returns array of all tab stops applied to this paragraph, including applied indirectly by styles or lists.  |
| [GetText](./gettext/)() override | Gets the text of this paragraph including the end of paragraph character.  |
| [InsertField](./insertfield/)(Aspose::Words::Fields::FieldType, bool, const System::SharedPtr< Aspose::Words::Node > &, bool) | Inserts a field into this paragraph.  |
| [InsertField](./insertfield/)(const System::String &, const System::SharedPtr< Aspose::Words::Node > &, bool) | Inserts a field into this paragraph.  |
| [InsertField](./insertfield/)(const System::String &, const System::String &, const System::SharedPtr< Aspose::Words::Node > &, bool) | Inserts a field into this paragraph.  |
| [JoinRunsWithSameFormatting](./joinrunswithsameformatting/)() | Joins runs with the same formatting in the paragraph.  |
