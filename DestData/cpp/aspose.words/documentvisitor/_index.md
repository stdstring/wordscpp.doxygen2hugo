---
title: DocumentVisitor
second_title: Aspose.Words for C++ API Reference
description: Base class for custom document visitors. 
type: docs
weight: 0
url: /cpp/aspose.words/documentvisitor/
---
## DocumentVisitor class


Base class for custom document visitors. 

## Methods

| Method | Description |
| --- | --- |
| virtual Aspose::Words::VisitorAction [VisitAbsolutePositionTab](./visitabsolutepositiontab/)(System::SharedPtr< Aspose::Words::AbsolutePositionTab >) | Called when a AbsolutePositionTab node is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitBodyEnd](./visitbodyend/)(System::SharedPtr< Aspose::Words::Body >) | Called when enumeration of the main text story in a section has ended.  |
| virtual Aspose::Words::VisitorAction [VisitBodyStart](./visitbodystart/)(System::SharedPtr< Aspose::Words::Body >) | Called when enumeration of the main text story in a section has started.  |
| virtual Aspose::Words::VisitorAction [VisitBookmarkEnd](./visitbookmarkend/)(System::SharedPtr< Aspose::Words::BookmarkEnd >) | Called when an end of a bookmark is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitBookmarkStart](./visitbookmarkstart/)(System::SharedPtr< Aspose::Words::BookmarkStart >) | Called when a start of a bookmark is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitBuildingBlockEnd](./visitbuildingblockend/)(System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock >) | Called when enumeration of a building block has ended.  |
| virtual Aspose::Words::VisitorAction [VisitBuildingBlockStart](./visitbuildingblockstart/)(System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock >) | Called when enumeration of a building block has started.  |
| virtual Aspose::Words::VisitorAction [VisitCellEnd](./visitcellend/)(System::SharedPtr< Aspose::Words::Tables::Cell >) | Called when enumeration of a table cell has ended.  |
| virtual Aspose::Words::VisitorAction [VisitCellStart](./visitcellstart/)(System::SharedPtr< Aspose::Words::Tables::Cell >) | Called when enumeration of a table cell has started.  |
| virtual Aspose::Words::VisitorAction [VisitCommentEnd](./visitcommentend/)(System::SharedPtr< Aspose::Words::Comment >) | Called when enumeration of a comment text has ended.  |
| virtual Aspose::Words::VisitorAction [VisitCommentRangeEnd](./visitcommentrangeend/)(System::SharedPtr< Aspose::Words::CommentRangeEnd >) | Called when the end of a commented range of text is encountered.  |
| virtual Aspose::Words::VisitorAction [VisitCommentRangeStart](./visitcommentrangestart/)(System::SharedPtr< Aspose::Words::CommentRangeStart >) | Called when the start of a commented range of text is encountered.  |
| virtual Aspose::Words::VisitorAction [VisitCommentStart](./visitcommentstart/)(System::SharedPtr< Aspose::Words::Comment >) | Called when enumeration of a comment text has started.  |
| virtual Aspose::Words::VisitorAction [VisitDocumentEnd](./visitdocumentend/)(System::SharedPtr< Aspose::Words::Document >) | Called when enumeration of the document has finished.  |
| virtual Aspose::Words::VisitorAction [VisitDocumentStart](./visitdocumentstart/)(System::SharedPtr< Aspose::Words::Document >) | Called when enumeration of the document has started.  |
| virtual Aspose::Words::VisitorAction [VisitEditableRangeEnd](./visiteditablerangeend/)(System::SharedPtr< Aspose::Words::EditableRangeEnd >) | Called when an end of an editable range is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitEditableRangeStart](./visiteditablerangestart/)(System::SharedPtr< Aspose::Words::EditableRangeStart >) | Called when a start of an editable range is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitFieldEnd](./visitfieldend/)(System::SharedPtr< Aspose::Words::Fields::FieldEnd >) | Called when a field ends in the document.  |
| virtual Aspose::Words::VisitorAction [VisitFieldSeparator](./visitfieldseparator/)(System::SharedPtr< Aspose::Words::Fields::FieldSeparator >) | Called when a field separator is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitFieldStart](./visitfieldstart/)(System::SharedPtr< Aspose::Words::Fields::FieldStart >) | Called when a field starts in the document.  |
| virtual Aspose::Words::VisitorAction [VisitFootnoteEnd](./visitfootnoteend/)(System::SharedPtr< Aspose::Words::Notes::Footnote >) | Called when enumeration of a footnote or endnote text has ended.  |
| virtual Aspose::Words::VisitorAction [VisitFootnoteStart](./visitfootnotestart/)(System::SharedPtr< Aspose::Words::Notes::Footnote >) | Called when enumeration of a footnote or endnote text has started.  |
| virtual Aspose::Words::VisitorAction [VisitFormField](./visitformfield/)(System::SharedPtr< Aspose::Words::Fields::FormField >) | Called when a form field is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitGlossaryDocumentEnd](./visitglossarydocumentend/)(System::SharedPtr< Aspose::Words::BuildingBlocks::GlossaryDocument >) | Called when enumeration of a glossary document has ended.  |
| virtual Aspose::Words::VisitorAction [VisitGlossaryDocumentStart](./visitglossarydocumentstart/)(System::SharedPtr< Aspose::Words::BuildingBlocks::GlossaryDocument >) | Called when enumeration of a glossary document has started.  |
| virtual Aspose::Words::VisitorAction [VisitGroupShapeEnd](./visitgroupshapeend/)(System::SharedPtr< Aspose::Words::Drawing::GroupShape >) | Called when enumeration of a group shape has ended.  |
| virtual Aspose::Words::VisitorAction [VisitGroupShapeStart](./visitgroupshapestart/)(System::SharedPtr< Aspose::Words::Drawing::GroupShape >) | Called when enumeration of a group shape has started.  |
| virtual Aspose::Words::VisitorAction [VisitHeaderFooterEnd](./visitheaderfooterend/)(System::SharedPtr< Aspose::Words::HeaderFooter >) | Called when enumeration of a header or footer in a section has ended.  |
| virtual Aspose::Words::VisitorAction [VisitHeaderFooterStart](./visitheaderfooterstart/)(System::SharedPtr< Aspose::Words::HeaderFooter >) | Called when enumeration of a header or footer in a section has started.  |
| virtual Aspose::Words::VisitorAction [VisitOfficeMathEnd](./visitofficemathend/)(System::SharedPtr< Aspose::Words::Math::OfficeMath >) | Called when enumeration of a Office Math object has ended.  |
| virtual Aspose::Words::VisitorAction [VisitOfficeMathStart](./visitofficemathstart/)(System::SharedPtr< Aspose::Words::Math::OfficeMath >) | Called when enumeration of a Office Math object has started.  |
| virtual Aspose::Words::VisitorAction [VisitParagraphEnd](./visitparagraphend/)(System::SharedPtr< Aspose::Words::Paragraph >) | Called when enumeration of a paragraph has ended.  |
| virtual Aspose::Words::VisitorAction [VisitParagraphStart](./visitparagraphstart/)(System::SharedPtr< Aspose::Words::Paragraph >) | Called when enumeration of a paragraph has started.  |
| virtual Aspose::Words::VisitorAction [VisitRowEnd](./visitrowend/)(System::SharedPtr< Aspose::Words::Tables::Row >) | Called when enumeration of a table row has ended.  |
| virtual Aspose::Words::VisitorAction [VisitRowStart](./visitrowstart/)(System::SharedPtr< Aspose::Words::Tables::Row >) | Called when enumeration of a table row has started.  |
| virtual Aspose::Words::VisitorAction [VisitRun](./visitrun/)(System::SharedPtr< Aspose::Words::Run >) | Called when a run of text in the is encountered.  |
| virtual Aspose::Words::VisitorAction [VisitSectionEnd](./visitsectionend/)(System::SharedPtr< Aspose::Words::Section >) | Called when enumeration of a section has ended.  |
| virtual Aspose::Words::VisitorAction [VisitSectionStart](./visitsectionstart/)(System::SharedPtr< Aspose::Words::Section >) | Called when enumeration of a section has started.  |
| virtual Aspose::Words::VisitorAction [VisitShapeEnd](./visitshapeend/)(System::SharedPtr< Aspose::Words::Drawing::Shape >) | Called when enumeration of a shape has ended.  |
| virtual Aspose::Words::VisitorAction [VisitShapeStart](./visitshapestart/)(System::SharedPtr< Aspose::Words::Drawing::Shape >) | Called when enumeration of a shape has started.  |
| virtual Aspose::Words::VisitorAction [VisitSmartTagEnd](./visitsmarttagend/)(System::SharedPtr< Aspose::Words::Markup::SmartTag >) | Called when enumeration of a smart tag has ended.  |
| virtual Aspose::Words::VisitorAction [VisitSmartTagStart](./visitsmarttagstart/)(System::SharedPtr< Aspose::Words::Markup::SmartTag >) | Called when enumeration of a smart tag has started.  |
| virtual Aspose::Words::VisitorAction [VisitSpecialChar](./visitspecialchar/)(System::SharedPtr< Aspose::Words::SpecialChar >) | Called when a SpecialChar node is encountered in the document.  |
| virtual Aspose::Words::VisitorAction [VisitStructuredDocumentTagEnd](./visitstructureddocumenttagend/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTag >) | Called when enumeration of a structured document tag has ended.  |
| virtual Aspose::Words::VisitorAction [VisitStructuredDocumentTagRangeEnd](./visitstructureddocumenttagrangeend/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTagRangeEnd >) |  |
| virtual Aspose::Words::VisitorAction [VisitStructuredDocumentTagRangeStart](./visitstructureddocumenttagrangestart/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTagRangeStart >) |  |
| virtual Aspose::Words::VisitorAction [VisitStructuredDocumentTagStart](./visitstructureddocumenttagstart/)(System::SharedPtr< Aspose::Words::Markup::StructuredDocumentTag >) | Called when enumeration of a structured document tag has started.  |
| virtual Aspose::Words::VisitorAction [VisitSubDocument](./visitsubdocument/)(System::SharedPtr< Aspose::Words::SubDocument >) | Called when a subDocument is encountered.  |
| virtual Aspose::Words::VisitorAction [VisitTableEnd](./visittableend/)(System::SharedPtr< Aspose::Words::Tables::Table >) | Called when enumeration of a table has ended.  |
| virtual Aspose::Words::VisitorAction [VisitTableStart](./visittablestart/)(System::SharedPtr< Aspose::Words::Tables::Table >) | Called when enumeration of a table has started.  |
