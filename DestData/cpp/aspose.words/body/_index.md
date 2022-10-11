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
|  [Body](./body/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Body** class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| void [EnsureMinimum](./ensureminimum/)() | If the last child is not a paragraph, creates and appends one empty paragraph.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Body**.  |
| System::SharedPtr< Aspose::Words::Section > [get_ParentSection](./get_parentsection/)() | Gets the parent section of this story.  |
