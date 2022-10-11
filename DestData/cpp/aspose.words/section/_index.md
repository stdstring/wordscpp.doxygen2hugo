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
| [Section](./section/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the Section class.  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [AppendContent](./appendcontent/)(const System::SharedPtr< Aspose::Words::Section > &) | Inserts a copy of content of the source section at the end of this section.  |
| [ClearContent](./clearcontent/)() | Clears the section.  |
| [ClearHeadersFooters](./clearheadersfooters/)() | Clears the headers and footers of this section.  |
| [Clone](./clone/)() | Creates a duplicate of this section.  |
| [DeleteHeaderFooterShapes](./deleteheaderfootershapes/)() | Deletes all shapes (drawing objects) from the headers and footers of this section.  |
| [EnsureMinimum](./ensureminimum/)() | Ensures that the section has Body with one Paragraph.  |
| [get_Body](./get_body/)() | Returns the **Body** child node of the section.  |
| [get_HeadersFooters](./get_headersfooters/)() | Provides access to the headers and footers nodes of the section.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Section**.  |
| [get_PageSetup](./get_pagesetup/)() | Returns an object that represents page setup and section properties.  |
| [get_ProtectedForForms](./get_protectedforforms/)() | True if the section is protected for forms. When a section is protected for forms, users can select and modify text only in form fields in Microsoft Word.  |
| [PrependContent](./prependcontent/)(const System::SharedPtr< Aspose::Words::Section > &) | Inserts a copy of content of the source section at the beginning of this section.  |
| [set_ProtectedForForms](./set_protectedforforms/)(bool) | Setter for Aspose::Words::Section::get_ProtectedForForms.  |
