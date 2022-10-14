---
title: DocumentBuilder
second_title: Aspose.Words for C++ API Reference
description: Provides methods to insert text, images and other content, specify font, paragraph and section formatting. 
type: docs
weight: 0
url: /cpp/aspose.words/documentbuilder/
---
## DocumentBuilder class


Provides methods to insert text, images and other content, specify font, paragraph and section formatting. 

## Methods

| Method | Description |
| --- | --- |
| [DeleteRow](./deleterow/)(int32_t, int32_t) | Deletes a row from a table.  |
| [DocumentBuilder](./documentbuilder/)() | Initializes a new instance of this class.  |
| [DocumentBuilder](./documentbuilder/)(const System::SharedPtr\<Aspose::Words::Document\>\&) | Initializes a new instance of this class.  |
| [EndBookmark](./endbookmark/)(const System::String\&) | Marks the current position in the document as a bookmark end.  |
| [EndColumnBookmark](./endcolumnbookmark/)(const System::String\&) | Marks the current position in the document as a column bookmark end. The position must be in a table cell.  |
| [EndEditableRange](./endeditablerange/)() | Marks the current position in the document as an editable range end.  |
| [EndEditableRange](./endeditablerange/)(const System::SharedPtr\<Aspose::Words::EditableRangeStart\>\&) | Marks the current position in the document as an editable range end.  |
| [EndRow](./endrow/)() | Ends a table row in the document.  |
| [EndTable](./endtable/)() | Ends a table in the document.  |
| [get_Bold](./get_bold/)() | True if the font is formatted as bold.  |
| [get_CellFormat](./get_cellformat/)() | Returns an object that represents current table cell formatting properties.  |
| [get_CurrentNode](./get_currentnode/)() | Gets the node that is currently selected in this DocumentBuilder.  |
| [get_CurrentParagraph](./get_currentparagraph/)() | Gets the paragraph that is currently selected in this DocumentBuilder.  |
| [get_CurrentSection](./get_currentsection/)() | Gets the section that is currently selected in this DocumentBuilder.  |
| [get_CurrentStory](./get_currentstory/)() | Gets the story that is currently selected in this DocumentBuilder.  |
| [get_Document](./get_document/)() const | Gets or sets the Document object that this object is attached to.  |
| [get_Font](./get_font/)() | Returns an object that represents current font formatting properties.  |
| [get_IsAtEndOfParagraph](./get_isatendofparagraph/)() | Returns true if the cursor is at the end of the current paragraph.  |
| [get_IsAtStartOfParagraph](./get_isatstartofparagraph/)() | Returns true if the cursor is at the beginning of the current paragraph (no text before the cursor).  |
| [get_Italic](./get_italic/)() | True if the font is formatted as italic.  |
| [get_ListFormat](./get_listformat/)() | Returns an object that represents current list formatting properties.  |
| [get_PageSetup](./get_pagesetup/)() | Returns an object that represents current page setup and section properties.  |
| [get_ParagraphFormat](./get_paragraphformat/)() | Returns an object that represents current paragraph formatting properties.  |
| [get_RowFormat](./get_rowformat/)() | Returns an object that represents current table row formatting properties.  |
| [get_Underline](./get_underline/)() | Gets/sets underline type for the current font.  |
| [InsertBreak](./insertbreak/)(Aspose::Words::BreakType) | Inserts a break of the specified type into the document.  |
| [InsertCell](./insertcell/)() | Inserts a table cell into the document.  |
| [InsertChart](./insertchart/)(Aspose::Words::Drawing::Charts::ChartType, double, double) | Inserts an chart object into the document and scales it to the specified size.  |
| [InsertChart](./insertchart/)(Aspose::Words::Drawing::Charts::ChartType, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an chart object into the document and scales it to the specified size.  |
| [InsertCheckBox](./insertcheckbox/)(const System::String\&, bool, int32_t) | Inserts a checkbox form field at the current position.  |
| [InsertCheckBox](./insertcheckbox/)(const System::String\&, bool, bool, int32_t) | Inserts a checkbox form field at the current position.  |
| [InsertComboBox](./insertcombobox/)(const System::String\&, const System::ArrayPtr\<System::String\>\&, int32_t) | Inserts a combobox form field at the current position.  |
| [InsertDocument](./insertdocument/)(const System::SharedPtr\<Aspose::Words::Document\>\&, Aspose::Words::ImportFormatMode) | Inserts a document at the cursor position.  |
| [InsertDocument](./insertdocument/)(const System::SharedPtr\<Aspose::Words::Document\>\&, Aspose::Words::ImportFormatMode, const System::SharedPtr\<Aspose::Words::ImportFormatOptions\>\&) | Inserts a document at the cursor position.  |
| [InsertField](./insertfield/)(Aspose::Words::Fields::FieldType, bool) | Inserts a Word field into a document and optionally updates the field result.  |
| [InsertField](./insertfield/)(const System::String\&) | Inserts a Word field into a document and updates the field result.  |
| [InsertField](./insertfield/)(const System::String\&, const System::String\&) | Inserts a Word field into a document without updating the field result.  |
| [InsertFootnote](./insertfootnote/)(Aspose::Words::Notes::FootnoteType, const System::String\&) | Inserts a footnote or endnote into the document.  |
| [InsertFootnote](./insertfootnote/)(Aspose::Words::Notes::FootnoteType, const System::String\&, const System::String\&) | Inserts a footnote or endnote into the document.  |
| [InsertHorizontalRule](./inserthorizontalrule/)() | Inserts a horizontal rule shape into the document.  |
| [InsertHtml](./inserthtml/)(const System::String\&) | Inserts an HTML string into the document.  |
| [InsertHtml](./inserthtml/)(const System::String\&, bool) | Inserts an HTML string into the document.  |
| [InsertHtml](./inserthtml/)(const System::String\&, Aspose::Words::HtmlInsertOptions) | Inserts an HTML string into the document. Allows to specify additional options.  |
| [InsertHyperlink](./inserthyperlink/)(const System::String\&, const System::String\&, bool) | Inserts a hyperlink into the document.  |
| [InsertImage](./insertimage/)(const System::SharedPtr\<System::Drawing::Image\>\&) | Inserts an image from a Image object into the document. The image is inserted inline and at 100% scale.  |
| [InsertImage](./insertimage/)(const System::String\&) | Inserts an image from a file or URL into the document. The image is inserted inline and at 100% scale.  |
| [InsertImage](./insertimage/)(const System::SharedPtr\<System::IO::Stream\>\&) | Inserts an image from a stream into the document. The image is inserted inline and at 100% scale.  |
| [InsertImage](./insertimage/)(const System::ArrayPtr\<uint8_t\>\&) | Inserts an image from a byte array into the document. The image is inserted inline and at 100% scale.  |
| [InsertImage](./insertimage/)(const System::SharedPtr\<System::Drawing::Image\>\&, double, double) | Inserts an inline image from a Image object into the document and scales it to the specified size.  |
| [InsertImage](./insertimage/)(const System::String\&, double, double) | Inserts an inline image from a file or URL into the document and scales it to the specified size.  |
| [InsertImage](./insertimage/)(const System::SharedPtr\<System::IO::Stream\>\&, double, double) | Inserts an inline image from a stream into the document and scales it to the specified size.  |
| [InsertImage](./insertimage/)(const System::ArrayPtr\<uint8_t\>\&, double, double) | Inserts an inline image from a byte array into the document and scales it to the specified size.  |
| [InsertImage](./insertimage/)(const System::SharedPtr\<System::Drawing::Image\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a Image object at the specified position and size.  |
| [InsertImage](./insertimage/)(const System::String\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a file or URL at the specified position and size.  |
| [InsertImage](./insertimage/)(const System::SharedPtr\<System::IO::Stream\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a stream at the specified position and size.  |
| [InsertImage](./insertimage/)(const System::ArrayPtr\<uint8_t\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a byte array at the specified position and size.  |
| [InsertImage](./insertimage/)(std::basic_istream\<CharType, Traits\>\&) |  |
| [InsertImage](./insertimage/)(std::basic_istream\<CharType, Traits\>\&, double, double) |  |
| [InsertImage](./insertimage/)(std::basic_istream\<CharType, Traits\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) |  |
| [InsertNode](./insertnode/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts a text level node inside the current paragraph before the cursor.  |
| [InsertOleObject](./insertoleobject/)(const System::SharedPtr\<System::IO::Stream\>\&, const System::String\&, bool, const System::SharedPtr\<System::IO::Stream\>\&) | Inserts an embedded OLE object from a stream into the document.  |
| [InsertOleObject](./insertoleobject/)(const System::String\&, bool, bool, const System::SharedPtr\<System::IO::Stream\>\&) | Inserts an embedded or linked OLE object from a file into the document. Detects OLE object type using file extension.  |
| [InsertOleObject](./insertoleobject/)(const System::String\&, const System::String\&, bool, bool, const System::SharedPtr\<System::IO::Stream\>\&) | Inserts an embedded or linked OLE object from a file into the document. Detects OLE object type using given progID parameter.  |
| [InsertOleObject](./insertoleobject/)(std::basic_istream\<CharType, Traits\>\&, System::String, bool, std::basic_istream\<CharType, Traits\>\&) |  |
| [InsertOleObject](./insertoleobject/)(System::String, bool, bool, std::basic_istream\<CharType, Traits\>\&) |  |
| [InsertOleObject](./insertoleobject/)(System::String, System::String, bool, bool, std::basic_istream\<CharType, Traits\>\&) |  |
| [InsertOleObjectAsIcon](./insertoleobjectasicon/)(const System::String\&, bool, const System::String\&, const System::String\&) | Inserts an embedded or linked OLE object as icon into the document. Allows to specify icon file and caption. Detects OLE object type using file extension.  |
| [InsertOleObjectAsIcon](./insertoleobjectasicon/)(const System::String\&, const System::String\&, bool, const System::String\&, const System::String\&) | Inserts an embedded or linked OLE object as icon into the document. Allows to specify icon file and caption. Detects OLE object type using given progID parameter.  |
| [InsertOleObjectAsIcon](./insertoleobjectasicon/)(const System::SharedPtr\<System::IO::Stream\>\&, const System::String\&, const System::String\&, const System::String\&) | Inserts an embedded OLE object as icon from a stream into the document. Allows to specify icon file and caption. Detects OLE object type using given progID parameter.  |
| [InsertOleObjectAsIcon](./insertoleobjectasicon/)(std::basic_istream\<CharType, Traits\>\&, System::String, System::String, System::String) |  |
| [InsertOnlineVideo](./insertonlinevideo/)(const System::String\&, double, double) | Inserts an online video object into the document and scales it to the specified size.  |
| [InsertOnlineVideo](./insertonlinevideo/)(const System::String\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an online video object into the document and scales it to the specified size.  |
| [InsertOnlineVideo](./insertonlinevideo/)(const System::String\&, const System::String\&, const System::ArrayPtr\<uint8_t\>\&, double, double) | Inserts an online video object into the document and scales it to the specified size.  |
| [InsertOnlineVideo](./insertonlinevideo/)(const System::String\&, const System::String\&, const System::ArrayPtr\<uint8_t\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an online video object into the document and scales it to the specified size.  |
| [InsertParagraph](./insertparagraph/)() | Inserts a paragraph break into the document.  |
| [InsertShape](./insertshape/)(Aspose::Words::Drawing::ShapeType, double, double) | Inserts inline shape with specified type and size.  |
| [InsertShape](./insertshape/)(Aspose::Words::Drawing::ShapeType, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts free-floating shape with specified position, size and text wrap type.  |
| [InsertSignatureLine](./insertsignatureline/)(const System::SharedPtr\<Aspose::Words::SignatureLineOptions\>\&) | Inserts a signature line at the current position.  |
| [InsertSignatureLine](./insertsignatureline/)(const System::SharedPtr\<Aspose::Words::SignatureLineOptions\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, Aspose::Words::Drawing::WrapType) | Inserts a signature line at the specified position.  |
| [InsertStyleSeparator](./insertstyleseparator/)() | Inserts style separator into the document.  |
| [InsertTableOfContents](./inserttableofcontents/)(const System::String\&) | Inserts a TOC (table of contents) field into the document.  |
| [InsertTextInput](./inserttextinput/)(const System::String\&, Aspose::Words::Fields::TextFormFieldType, const System::String\&, const System::String\&, int32_t) | Inserts a text form field at the current position.  |
| [MoveTo](./moveto/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Moves the cursor to an inline node or to the end of a paragraph.  |
| [MoveToBookmark](./movetobookmark/)(const System::String\&) | Moves the cursor to a bookmark.  |
| [MoveToBookmark](./movetobookmark/)(const System::String\&, bool, bool) | Moves the cursor to a bookmark with greater precision.  |
| [MoveToCell](./movetocell/)(int32_t, int32_t, int32_t, int32_t) | Moves the cursor to a table cell in the current section.  |
| [MoveToDocumentEnd](./movetodocumentend/)() | Moves the cursor to the end of the document.  |
| [MoveToDocumentStart](./movetodocumentstart/)() | Moves the cursor to the beginning of the document.  |
| [MoveToField](./movetofield/)(const System::SharedPtr\<Aspose::Words::Fields::Field\>\&, bool) | Moves the cursor to a field in the document.  |
| [MoveToHeaderFooter](./movetoheaderfooter/)(Aspose::Words::HeaderFooterType) | Moves the cursor to the beginning of a header or footer in the current section.  |
| [MoveToMergeField](./movetomergefield/)(const System::String\&) | Moves the cursor to a position just beyond the specified merge field and removes the merge field.  |
| [MoveToMergeField](./movetomergefield/)(const System::String\&, bool, bool) | Moves the merge field to the specified merge field.  |
| [MoveToParagraph](./movetoparagraph/)(int32_t, int32_t) | Moves the cursor to a paragraph in the current section.  |
| [MoveToSection](./movetosection/)(int32_t) | Moves the cursor to the beginning of the body in a specified section.  |
| [PopFont](./popfont/)() | Retrieves character formatting previously saved on the stack.  |
| [PushFont](./pushfont/)() | Saves current character formatting onto the stack.  |
| [set_Bold](./set_bold/)(bool) | Setter for Aspose::Words::DocumentBuilder::get_Bold.  |
| [set_Document](./set_document/)(const System::SharedPtr\<Aspose::Words::Document\>\&) | Setter for Aspose::Words::DocumentBuilder::get_Document.  |
| [set_Italic](./set_italic/)(bool) | Setter for Aspose::Words::DocumentBuilder::get_Italic.  |
| [set_Underline](./set_underline/)(Aspose::Words::Underline) | Setter for Aspose::Words::DocumentBuilder::get_Underline.  |
| [StartBookmark](./startbookmark/)(const System::String\&) | Marks the current position in the document as a bookmark start.  |
| [StartColumnBookmark](./startcolumnbookmark/)(const System::String\&) | Marks the current position in the document as a column bookmark start. The position must be in a table cell.  |
| [StartEditableRange](./starteditablerange/)() | Marks the current position in the document as an editable range start.  |
| [StartTable](./starttable/)() | Starts a table in the document.  |
| [Write](./write/)(const System::String\&) | Inserts a string into the document at the current insert position.  |
| [Writeln](./writeln/)(const System::String\&) | Inserts a string and a paragraph break into the document.  |
| [Writeln](./writeln/)() | Inserts a paragraph break into the document.  |
