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

## Methods

| Method | Description |
| --- | --- |
| [Footnote](./footnote/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, Aspose::Words::Notes::FootnoteType) | Initializes an instance of the **Footnote** class.  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [get_FootnoteType](./get_footnotetype/)() const | Returns a value that specifies whether this is a footnote or endnote.  |
| [get_IsAuto](./get_isauto/)() const | Holds a value that specifies whether this is a auto-numbered footnote or footnote with user defined custom reference mark.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Footnote**.  |
| [get_ReferenceMark](./get_referencemark/)() const | Gets/sets custom reference mark to be used for this footnote. Default value is **empty string**, meaning auto-numbered footnotes are used.  |
| [get_StoryType](./get_storytype/)() override | Returns **StoryType.Footnotes** or **StoryType.Endnotes**.  |
| [set_IsAuto](./set_isauto/)(bool) | Setter for Aspose::Words::Notes::Footnote::get_IsAuto.  |
| [set_ReferenceMark](./set_referencemark/)(const System::String &) | Setter for Aspose::Words::Notes::Footnote::get_ReferenceMark.  |
