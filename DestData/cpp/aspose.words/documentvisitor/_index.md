---
title: DocumentVisitor
second_title: Aspose.Words for C++ API Reference
description: Base class for custom document visitors. 
type: docs
weight: 0
url: /cpp/aspose.words/documentvisitor/
---

Base class for custom document visitors. 

## Methods

| Method | Description |
| --- | --- |
| virtual [VisitAbsolutePositionTab](./visitabsolutepositiontab/)(System::SharedPtr< Aspose::Words::AbsolutePositionTab >) | Called when a AbsolutePositionTab node is encountered in the document.  |
| virtual [VisitBodyEnd](./visitbodyend/)(System::SharedPtr< Aspose::Words::Body >) | Called when enumeration of the main text story in a section has ended.  |
| virtual [VisitBodyStart](./visitbodystart/)(System::SharedPtr< Aspose::Words::Body >) | Called when enumeration of the main text story in a section has started.  |
| virtual [VisitBookmarkEnd](./visitbookmarkend/)(System::SharedPtr< Aspose::Words::BookmarkEnd >) | Called when an end of a bookmark is encountered in the document.  |
| virtual [VisitBookmarkStart](./visitbookmarkstart/)(System::SharedPtr< Aspose::Words::BookmarkStart >) | Called when a start of a bookmark is encountered in the document.  |
| virtual [VisitBuildingBlockEnd](./visitbuildingblockend/)(System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock >) | Called when enumeration of a building block has ended.  |
| virtual [VisitBuildingBlockStart](./visitbuildingblockstart/)(System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock >) | Called when enumeration of a building block has started.  |
| virtual [VisitCellEnd](./visitcellend/)(System::SharedPtr< Aspose::Words::Tables::Cell >) | Called when enumeration of a table cell has ended.  |
| virtual [VisitCellStart](./visitcellstart/)(System::SharedPtr< Aspose::Words::Tables::Cell >) | Called when enumeration of a table cell has started.  |
| virtual [VisitCommentEnd](./visitcommentend/)(System::SharedPtr< Aspose::Words::Comment >) | Called when enumeration of a comment text has ended.  |
| virtual [VisitCommentRangeEnd](./visitcommentrangeend/)(System::SharedPtr< Aspose::Words::CommentRangeEnd >) | Called when the end of a commented range of text is encountered.  |
| virtual [VisitCommentRangeStart](./visitcommentrangestart/)(System::SharedPtr< Aspose::Words::CommentRangeStart >) | Called when the start of a commented range of text is encountered.  |
| virtual [VisitCommentStart](./visitcommentstart/)(System::SharedPtr< Aspose::Words::Comment >) | Called when enumeration of a comment text has started.  |
| virtual [VisitDocumentEnd](./visitdocumentend/)(System::SharedPtr< Aspose::Words::Document >) | Called when enumeration of the document has finished.  |
| virtual [VisitDocumentStart](./visitdocumentstart/)(System::SharedPtr< Aspose::Words::Document >) | Called when enumeration of the document has started.  |
| virtual [VisitEditableRangeEnd](./visiteditablerangeend/)(System::SharedPtr< Aspose::Words::EditableRangeEnd >) | Called when an end of an editable range is encountered in the document.  |
| virtual [VisitEditableRangeStart](./visiteditablerangestart/)(System::SharedPtr< Aspose::Words::EditableRangeStart >) | Called when a start of an editable range is encountered in the document.  |
| virtual [VisitFieldEnd](./visitfieldend/)(System::SharedPtr< Aspose::Words::Fields::FieldEnd >) | Called when a field ends in the document.  |
| virtual [VisitFieldSeparator](./visitfieldseparator/)(System::SharedPtr< Aspose::Words::Fields::FieldSeparator >) | Called when a field separator is encountered in the document.  |
| virtual [VisitFieldStart](./visitfieldstart/)(System::SharedPtr< Aspose::Words::Fields::FieldStart >) | Called when a field starts in the document.  |
| virtual [VisitFootnoteEnd](./visitfootnoteend/)(System::SharedPtr< Aspose::Words::Notes::Footnote >) | Called when enumeration of a footnote or endnote text has ended.  |
| virtual [VisitFootnoteStart](./visitfootnotestart/)(System::SharedPtr< Aspose::Words::Notes::Footnote >) | Called when enumeration of a footnote or endnote text has started.  |
| virtual [VisitFormField](./visitformfield/)(System::SharedPtr< Aspose::Words::Fields::FormField >) | Called when a form field is encountered in the document.  |
| virtual [VisitGlossaryDocumentEnd](./visitglossarydocumentend/)(System::SharedPtr< Aspose::Words::BuildingBlocks::GlossaryDocument >) | Called when enumeration of a glossary document has ended.  |
| virtual [VisitGlossaryDocumentStart](./visitglossarydocumentstart/)(System::SharedPtr< Aspose::Words::BuildingBlocks::GlossaryDocument >) | Called when enumeration of a glossary document has started.  |
| virtual [VisitGroupShapeEnd](./visitgroupshapeend/)(System::SharedPtr< Aspose::Words::Drawing::GroupShape >) | Called when enumeration of a group shape has ended.  |
| virtual [VisitGroupShapeStart](./visitgroupshapestart/)(System::SharedPtr< Aspose::Words::Drawing::GroupShape >) | Called when enumeration of a group shape has started.  |
| virtual [VisitHeaderFooterEnd](./visitheaderfooterend/)(System::SharedPtr< Aspose::Words::HeaderFooter >) | Called when enumeration of a header or footer in a section has ended.  |
| virtual [VisitHeaderFooterStart](./visitheaderfooterstart/)(System::SharedPtr< Aspose::Words::HeaderFooter >) | Called when enumeration of a header or footer in a section has started.  |
| virtual [VisitOfficeMathEnd](./visitofficemathend/)(System::SharedPtr< Aspose::Words::Math::OfficeMath >) | Called when enumeration of a Office Math object has ended.  |
| virtual [VisitOfficeMathStart](./visitofficemathstart/)(System::SharedPtr< Aspose::Words::Math::OfficeMath >) | Called when enumeration of a Office Math object has started.  |
| virtual [VisitParagraphEnd](./visitparagraphend/)(System::SharedPtr< Aspose::Words::Paragraph >) | Called when enumeration of a paragraph has ended.  |
| virtual [VisitParagraphStart](./visitparagraphstart/)(System::SharedPtr< Aspose::Words::Paragraph >) | Called when enumeration of a paragraph has started.  |
| virtual [VisitRowEnd](./visitrowend/)(System::SharedPtr< Aspose::Words::Tables::Row >) | Called when enumeration of a table row has ended.  |
| virtual [VisitRowStart](./visitrowstart/)(System::SharedPtr< Aspose::Words::Tables::Row >) | Called when enumeration of a table row has started.  |
| virtual [VisitRun](./visitrun/)(System::SharedPtr< Aspose::Words::Run >) | Called when a run of text in the is encountered.  |
| virtual [VisitSectionEnd](./visitsectionend/)(System::SharedPtr< Aspose::Words::Section >) | Called when enumeration of a section has ended.  |
| virtual [VisitSectionStart](./visitsectionstart/)(System::SharedPtr< Aspose::Words::Section >) | Called when enumeration of a section has started.  |
| virtual [VisitShapeEnd](./visitshapeend/)(System::SharedPtr< Aspose::Words::Drawing::Shape >) | Called when enumeration of a shape has ended.  |
| virtual [VisitShapeStart](./visitshapestart/)(System::SharedPtr< Aspose::Words::Drawing::Shape >) | Called when enumeration of a shape has started.  |
| virtual [VisitSmartTagEnd](./visitsmarttagend/)(System::SharedPtr< Aspose::Words::Markup::SmartTag >) | Called when enumeration of a smart tag has ended.  |
| virtual [VisitSmartTagStart](./visitsmarttagstart/)(System::SharedPtr< Aspose::Words::Markup::SmartTag >) | Called when enumeration of a smart tag has started.  |
| virtual [VisitSpecialChar](./visitspecialchar/)(System::SharedPtr< Aspose::Words::SpecialChar >) | Called when a SpecialChar node is encountered in the document.  |
| virtual [VisitStructuredDocumentTagEnd](./visitstructureddocumenttagend/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTag >) | Called when enumeration of a structured document tag has ended.  |
| virtual [VisitStructuredDocumentTagRangeEnd](./visitstructureddocumenttagrangeend/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTagRangeEnd >) |  |
| virtual [VisitStructuredDocumentTagRangeStart](./visitstructureddocumenttagrangestart/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTagRangeStart >) |  |
| virtual [VisitStructuredDocumentTagStart](./visitstructureddocumenttagstart/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTag >) | Called when enumeration of a structured document tag has started.  |
| virtual [VisitSubDocument](./visitsubdocument/)(System::SharedPtr< Aspose::Words::SubDocument >) | Called when a subDocument is encountered.  |
| virtual [VisitTableEnd](./visittableend/)(System::SharedPtr< Aspose::Words::Tables::Table >) | Called when enumeration of a table has ended.  |
| virtual [VisitTableStart](./visittablestart/)(System::SharedPtr< Aspose::Words::Tables::Table >) | Called when enumeration of a table has started.  |
