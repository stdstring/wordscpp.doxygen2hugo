---
title: HeaderFooter
second_title: Aspose.Words for C++ API Reference
description: Represents a container for the header or footer text of a section. 
type: docs
weight: 0
url: /cpp/aspose.words/headerfooter/
---
## HeaderFooter class


Represents a container for the header or footer text of a section. 

## Methods

| Method | Description |
| --- | --- |
|  [HeaderFooter](./headerfooter/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, Aspose::Words::HeaderFooterType) | Creates a new header or footer of the specified type.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| Aspose::Words::HeaderFooterType [get_HeaderFooterType](./get_headerfootertype/)() | Gets the type of this header/footer.  |
| bool [get_IsHeader](./get_isheader/)() | True if this **HeaderFooter** object is a header.  |
| bool [get_IsLinkedToPrevious](./get_islinkedtoprevious/)() | True if this header or footer is linked to the corresponding header or footer in the previous section.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.HeaderFooter**.  |
| System::SharedPtr< Aspose::Words::Section > [get_ParentSection](./get_parentsection/)() | Gets the parent section of this story.  |
| void [set_IsLinkedToPrevious](./set_islinkedtoprevious/)(bool) | Setter for Aspose::Words::HeaderFooter::get_IsLinkedToPrevious.  |
