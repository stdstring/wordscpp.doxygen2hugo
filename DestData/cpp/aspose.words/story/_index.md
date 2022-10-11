---
title: Story
second_title: Aspose.Words for C++ API Reference
description: Base class for elements that contain block-level nodes Paragraph and Table. 
type: docs
weight: 0
url: /cpp/aspose.words/story/
---
## Story class


Base class for elements that contain block-level nodes Paragraph and Table. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Paragraph > [AppendParagraph](./appendparagraph/)(const System::String &) | A shortcut method that creates a Paragraph object with optional text and appends it to the end of this object.  |
| void [DeleteShapes](./deleteshapes/)() | Deletes all shapes from the text of this story.  |
| System::SharedPtr< Aspose::Words::Paragraph > [get_FirstParagraph](./get_firstparagraph/)() | Gets the first paragraph in the story.  |
| System::SharedPtr< Aspose::Words::Paragraph > [get_LastParagraph](./get_lastparagraph/)() | Gets the last paragraph in the story.  |
| System::SharedPtr< Aspose::Words::ParagraphCollection > [get_Paragraphs](./get_paragraphs/)() | Gets a collection of paragraphs that are immediate children of the story.  |
| Aspose::Words::StoryType [get_StoryType](./get_storytype/)() const | Gets the type of this story.  |
| System::SharedPtr< Aspose::Words::Tables::TableCollection > [get_Tables](./get_tables/)() | Gets a collection of tables that are immediate children of the story.  |
