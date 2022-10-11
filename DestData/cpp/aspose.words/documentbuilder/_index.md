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
|  [DocumentBuilder](./documentbuilder/)() | Initializes a new instance of this class.  |
|  [DocumentBuilder](./documentbuilder/)(const System::SharedPtr< Aspose::Words::Document > &) | Initializes a new instance of this class.  |
| System::SharedPtr< Aspose::Words::Tables::Row > [DeleteRow](./deleterow/)(int32_t, int32_t) | Deletes a row from a table.  |
| System::SharedPtr< Aspose::Words::BookmarkEnd > [EndBookmark](./endbookmark/)(const System::String &) | Marks the current position in the document as a bookmark end.  |
| System::SharedPtr< Aspose::Words::BookmarkEnd > [EndColumnBookmark](./endcolumnbookmark/)(const System::String &) | Marks the current position in the document as a column bookmark end. The position must be in a table cell.  |
| System::SharedPtr< Aspose::Words::EditableRangeEnd > [EndEditableRange](./endeditablerange/)() | Marks the current position in the document as an editable range end.  |
| System::SharedPtr< Aspose::Words::EditableRangeEnd > [EndEditableRange](./endeditablerange/)(const System::SharedPtr< Aspose::Words::EditableRangeStart > &) | Marks the current position in the document as an editable range end.  |
| System::SharedPtr< Aspose::Words::Tables::Row > [EndRow](./endrow/)() | Ends a table row in the document.  |
| System::SharedPtr< Aspose::Words::Tables::Table > [EndTable](./endtable/)() | Ends a table in the document.  |
| bool [get_Bold](./get_bold/)() | True if the font is formatted as bold.  |
| System::SharedPtr< Aspose::Words::Tables::CellFormat > [get_CellFormat](./get_cellformat/)() | Returns an object that represents current table cell formatting properties.  |
| System::SharedPtr< Aspose::Words::Node > [get_CurrentNode](./get_currentnode/)() | Gets the node that is currently selected in this DocumentBuilder.  |
| System::SharedPtr< Aspose::Words::Paragraph > [get_CurrentParagraph](./get_currentparagraph/)() | Gets the paragraph that is currently selected in this DocumentBuilder.  |
| System::SharedPtr< Aspose::Words::Section > [get_CurrentSection](./get_currentsection/)() | Gets the section that is currently selected in this DocumentBuilder.  |
| System::SharedPtr< Aspose::Words::Story > [get_CurrentStory](./get_currentstory/)() | Gets the story that is currently selected in this DocumentBuilder.  |
| System::SharedPtr< Aspose::Words::Document > [get_Document](./get_document/)() const | Gets or sets the Document object that this object is attached to.  |
| System::SharedPtr< Aspose::Words::Font > [get_Font](./get_font/)() | Returns an object that represents current font formatting properties.  |
| bool [get_IsAtEndOfParagraph](./get_isatendofparagraph/)() | Returns true if the cursor is at the end of the current paragraph.  |
| bool [get_IsAtStartOfParagraph](./get_isatstartofparagraph/)() | Returns true if the cursor is at the beginning of the current paragraph (no text before the cursor).  |
| bool [get_Italic](./get_italic/)() | True if the font is formatted as italic.  |
| System::SharedPtr< Aspose::Words::Lists::ListFormat > [get_ListFormat](./get_listformat/)() | Returns an object that represents current list formatting properties.  |
| System::SharedPtr< Aspose::Words::PageSetup > [get_PageSetup](./get_pagesetup/)() | Returns an object that represents current page setup and section properties.  |
| System::SharedPtr< Aspose::Words::ParagraphFormat > [get_ParagraphFormat](./get_paragraphformat/)() | Returns an object that represents current paragraph formatting properties.  |
| System::SharedPtr< Aspose::Words::Tables::RowFormat > [get_RowFormat](./get_rowformat/)() | Returns an object that represents current table row formatting properties.  |
| Aspose::Words::Underline [get_Underline](./get_underline/)() | Gets/sets underline type for the current font.  |
| void [InsertBreak](./insertbreak/)(Aspose::Words::BreakType) | Inserts a break of the specified type into the document.  |
| System::SharedPtr< Aspose::Words::Tables::Cell > [InsertCell](./insertcell/)() | Inserts a table cell into the document.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertChart](./insertchart/)(Aspose::Words::Drawing::Charts::ChartType, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an chart object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertChart](./insertchart/)(Aspose::Words::Drawing::Charts::ChartType, double, double) | Inserts an chart object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Fields::FormField > [InsertCheckBox](./insertcheckbox/)(const System::String &, bool, int32_t) | Inserts a checkbox form field at the current position.  |
| System::SharedPtr< Aspose::Words::Fields::FormField > [InsertCheckBox](./insertcheckbox/)(const System::String &, bool, bool, int32_t) | Inserts a checkbox form field at the current position.  |
| System::SharedPtr< Aspose::Words::Fields::FormField > [InsertComboBox](./insertcombobox/)(const System::String &, const System::ArrayPtr< System::String > &, int32_t) | Inserts a combobox form field at the current position.  |
| System::SharedPtr< Aspose::Words::Node > [InsertDocument](./insertdocument/)(const System::SharedPtr< Aspose::Words::Document > &, Aspose::Words::ImportFormatMode) | Inserts a document at the cursor position.  |
| System::SharedPtr< Aspose::Words::Node > [InsertDocument](./insertdocument/)(const System::SharedPtr< Aspose::Words::Document > &, Aspose::Words::ImportFormatMode, const System::SharedPtr< Aspose::Words::ImportFormatOptions > &) | Inserts a document at the cursor position.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [InsertField](./insertfield/)(Aspose::Words::Fields::FieldType, bool) | Inserts a Word field into a document and optionally updates the field result.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [InsertField](./insertfield/)(const System::String &) | Inserts a Word field into a document and updates the field result.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [InsertField](./insertfield/)(const System::String &, const System::String &) | Inserts a Word field into a document without updating the field result.  |
| System::SharedPtr< Aspose::Words::Notes::Footnote > [InsertFootnote](./insertfootnote/)(Aspose::Words::Notes::FootnoteType, const System::String &) | Inserts a footnote or endnote into the document.  |
| System::SharedPtr< Aspose::Words::Notes::Footnote > [InsertFootnote](./insertfootnote/)(Aspose::Words::Notes::FootnoteType, const System::String &, const System::String &) | Inserts a footnote or endnote into the document.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertHorizontalRule](./inserthorizontalrule/)() | Inserts a horizontal rule shape into the document.  |
| void [InsertHtml](./inserthtml/)(const System::String &) | Inserts an HTML string into the document.  |
| void [InsertHtml](./inserthtml/)(const System::String &, Aspose::Words::HtmlInsertOptions) | Inserts an HTML string into the document. Allows to specify additional options.  |
| void [InsertHtml](./inserthtml/)(const System::String &, bool) | Inserts an HTML string into the document.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [InsertHyperlink](./inserthyperlink/)(const System::String &, const System::String &, bool) | Inserts a hyperlink into the document.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::ArrayPtr< uint8_t > &) | Inserts an image from a byte array into the document. The image is inserted inline and at 100% scale.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::ArrayPtr< uint8_t > &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a byte array at the specified position and size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::ArrayPtr< uint8_t > &, double, double) | Inserts an inline image from a byte array into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::SharedPtr< System::Drawing::Image > &) | Inserts an image from a Image object into the document. The image is inserted inline and at 100% scale.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::SharedPtr< System::Drawing::Image > &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a Image object at the specified position and size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::SharedPtr< System::Drawing::Image > &, double, double) | Inserts an inline image from a Image object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::SharedPtr< System::IO::Stream > &) | Inserts an image from a stream into the document. The image is inserted inline and at 100% scale.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::SharedPtr< System::IO::Stream > &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a stream at the specified position and size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::SharedPtr< System::IO::Stream > &, double, double) | Inserts an inline image from a stream into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::String &) | Inserts an image from a file or URL into the document. The image is inserted inline and at 100% scale.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::String &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an image from a file or URL at the specified position and size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(const System::String &, double, double) | Inserts an inline image from a file or URL into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(std::basic_istream< CharType, Traits > &) |  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(std::basic_istream< CharType, Traits > &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) |  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertImage](./insertimage/)(std::basic_istream< CharType, Traits > &, double, double) |  |
| void [InsertNode](./insertnode/)(const System::SharedPtr< Aspose::Words::Node > &) | Inserts a text level node inside the current paragraph before the cursor.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObject](./insertoleobject/)(const System::SharedPtr< System::IO::Stream > &, const System::String &, bool, const System::SharedPtr< System::IO::Stream > &) | Inserts an embedded OLE object from a stream into the document.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObject](./insertoleobject/)(const System::String &, bool, bool, const System::SharedPtr< System::IO::Stream > &) | Inserts an embedded or linked OLE object from a file into the document. Detects OLE object type using file extension.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObject](./insertoleobject/)(const System::String &, const System::String &, bool, bool, const System::SharedPtr< System::IO::Stream > &) | Inserts an embedded or linked OLE object from a file into the document. Detects OLE object type using given progID parameter.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObject](./insertoleobject/)(std::basic_istream< CharType, Traits > &, System::String, bool, std::basic_istream< CharType, Traits > &) |  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObject](./insertoleobject/)(System::String, bool, bool, std::basic_istream< CharType, Traits > &) |  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObject](./insertoleobject/)(System::String, System::String, bool, bool, std::basic_istream< CharType, Traits > &) |  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObjectAsIcon](./insertoleobjectasicon/)(const System::SharedPtr< System::IO::Stream > &, const System::String &, const System::String &, const System::String &) | Inserts an embedded OLE object as icon from a stream into the document. Allows to specify icon file and caption. Detects OLE object type using given progID parameter.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObjectAsIcon](./insertoleobjectasicon/)(const System::String &, bool, const System::String &, const System::String &) | Inserts an embedded or linked OLE object as icon into the document. Allows to specify icon file and caption. Detects OLE object type using file extension.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObjectAsIcon](./insertoleobjectasicon/)(const System::String &, const System::String &, bool, const System::String &, const System::String &) | Inserts an embedded or linked OLE object as icon into the document. Allows to specify icon file and caption. Detects OLE object type using given progID parameter.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOleObjectAsIcon](./insertoleobjectasicon/)(std::basic_istream< CharType, Traits > &, System::String, System::String, System::String) |  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOnlineVideo](./insertonlinevideo/)(const System::String &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an online video object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOnlineVideo](./insertonlinevideo/)(const System::String &, const System::String &, const System::ArrayPtr< uint8_t > &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts an online video object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOnlineVideo](./insertonlinevideo/)(const System::String &, const System::String &, const System::ArrayPtr< uint8_t > &, double, double) | Inserts an online video object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertOnlineVideo](./insertonlinevideo/)(const System::String &, double, double) | Inserts an online video object into the document and scales it to the specified size.  |
| System::SharedPtr< Aspose::Words::Paragraph > [InsertParagraph](./insertparagraph/)() | Inserts a paragraph break into the document.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertShape](./insertshape/)(Aspose::Words::Drawing::ShapeType, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) | Inserts free-floating shape with specified position, size and text wrap type.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertShape](./insertshape/)(Aspose::Words::Drawing::ShapeType, double, double) | Inserts inline shape with specified type and size.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertSignatureLine](./insertsignatureline/)(const System::SharedPtr< Aspose::Words::SignatureLineOptions > &) | Inserts a signature line at the current position.  |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [InsertSignatureLine](./insertsignatureline/)(const System::SharedPtr< Aspose::Words::SignatureLineOptions > &, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, Aspose::Words::Drawing::WrapType) | Inserts a signature line at the specified position.  |
| void [InsertStyleSeparator](./insertstyleseparator/)() | Inserts style separator into the document.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [InsertTableOfContents](./inserttableofcontents/)(const System::String &) | Inserts a TOC (table of contents) field into the document.  |
| System::SharedPtr< Aspose::Words::Fields::FormField > [InsertTextInput](./inserttextinput/)(const System::String &, Aspose::Words::Fields::TextFormFieldType, const System::String &, const System::String &, int32_t) | Inserts a text form field at the current position.  |
| void [MoveTo](./moveto/)(const System::SharedPtr< Aspose::Words::Node > &) | Moves the cursor to an inline node or to the end of a paragraph.  |
| bool [MoveToBookmark](./movetobookmark/)(const System::String &) | Moves the cursor to a bookmark.  |
| bool [MoveToBookmark](./movetobookmark/)(const System::String &, bool, bool) | Moves the cursor to a bookmark with greater precision.  |
| void [MoveToCell](./movetocell/)(int32_t, int32_t, int32_t, int32_t) | Moves the cursor to a table cell in the current section.  |
| void [MoveToDocumentEnd](./movetodocumentend/)() | Moves the cursor to the end of the document.  |
| void [MoveToDocumentStart](./movetodocumentstart/)() | Moves the cursor to the beginning of the document.  |
| void [MoveToField](./movetofield/)(const System::SharedPtr< Aspose::Words::Fields::Field > &, bool) | Moves the cursor to a field in the document.  |
| void [MoveToHeaderFooter](./movetoheaderfooter/)(Aspose::Words::HeaderFooterType) | Moves the cursor to the beginning of a header or footer in the current section.  |
| bool [MoveToMergeField](./movetomergefield/)(const System::String &) | Moves the cursor to a position just beyond the specified merge field and removes the merge field.  |
| bool [MoveToMergeField](./movetomergefield/)(const System::String &, bool, bool) | Moves the merge field to the specified merge field.  |
| void [MoveToParagraph](./movetoparagraph/)(int32_t, int32_t) | Moves the cursor to a paragraph in the current section.  |
| void [MoveToSection](./movetosection/)(int32_t) | Moves the cursor to the beginning of the body in a specified section.  |
| void [PopFont](./popfont/)() | Retrieves character formatting previously saved on the stack.  |
| void [PushFont](./pushfont/)() | Saves current character formatting onto the stack.  |
| void [set_Bold](./set_bold/)(bool) | Setter for Aspose::Words::DocumentBuilder::get_Bold.  |
| void [set_Document](./set_document/)(const System::SharedPtr< Aspose::Words::Document > &) | Setter for Aspose::Words::DocumentBuilder::get_Document.  |
| void [set_Italic](./set_italic/)(bool) | Setter for Aspose::Words::DocumentBuilder::get_Italic.  |
| void [set_Underline](./set_underline/)(Aspose::Words::Underline) | Setter for Aspose::Words::DocumentBuilder::get_Underline.  |
| System::SharedPtr< Aspose::Words::BookmarkStart > [StartBookmark](./startbookmark/)(const System::String &) | Marks the current position in the document as a bookmark start.  |
| System::SharedPtr< Aspose::Words::BookmarkStart > [StartColumnBookmark](./startcolumnbookmark/)(const System::String &) | Marks the current position in the document as a column bookmark start. The position must be in a table cell.  |
| System::SharedPtr< Aspose::Words::EditableRangeStart > [StartEditableRange](./starteditablerange/)() | Marks the current position in the document as an editable range start.  |
| System::SharedPtr< Aspose::Words::Tables::Table > [StartTable](./starttable/)() | Starts a table in the document.  |
| void [Write](./write/)(const System::String &) | Inserts a string into the document at the current insert position.  |
| void [Writeln](./writeln/)() | Inserts a paragraph break into the document.  |
| void [Writeln](./writeln/)(const System::String &) | Inserts a string and a paragraph break into the document.  |
