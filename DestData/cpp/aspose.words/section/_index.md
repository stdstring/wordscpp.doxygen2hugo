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
|  [Section](./section/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the Section class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| void [AppendContent](./appendcontent/)(const System::SharedPtr< Aspose::Words::Section > &) | Inserts a copy of content of the source section at the end of this section.  |
| void [ClearContent](./clearcontent/)() | Clears the section.  |
| void [ClearHeadersFooters](./clearheadersfooters/)() | Clears the headers and footers of this section.  |
| System::SharedPtr< Aspose::Words::Section > [Clone](./clone/)() | Creates a duplicate of this section.  |
| void [DeleteHeaderFooterShapes](./deleteheaderfootershapes/)() | Deletes all shapes (drawing objects) from the headers and footers of this section.  |
| void [EnsureMinimum](./ensureminimum/)() | Ensures that the section has Body with one Paragraph.  |
| System::SharedPtr< Aspose::Words::Body > [get_Body](./get_body/)() | Returns the **Body** child node of the section.  |
| System::SharedPtr< Aspose::Words::HeaderFooterCollection > [get_HeadersFooters](./get_headersfooters/)() | Provides access to the headers and footers nodes of the section.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Section**.  |
| System::SharedPtr< Aspose::Words::PageSetup > [get_PageSetup](./get_pagesetup/)() | Returns an object that represents page setup and section properties.  |
| bool [get_ProtectedForForms](./get_protectedforforms/)() | True if the section is protected for forms. When a section is protected for forms, users can select and modify text only in form fields in Microsoft Word.  |
| void [PrependContent](./prependcontent/)(const System::SharedPtr< Aspose::Words::Section > &) | Inserts a copy of content of the source section at the beginning of this section.  |
| void [set_ProtectedForForms](./set_protectedforforms/)(bool) | Setter for Aspose::Words::Section::get_ProtectedForForms.  |
