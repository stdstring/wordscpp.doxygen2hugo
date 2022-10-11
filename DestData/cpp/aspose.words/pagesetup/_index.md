---
title: PageSetup
second_title: Aspose.Words for C++ API Reference
description: Represents the page setup properties of a section. 
type: docs
weight: 0
url: /cpp/aspose.words/pagesetup/
---
## PageSetup class


Represents the page setup properties of a section. 

## Methods

| Method | Description |
| --- | --- |
| void [ClearFormatting](./clearformatting/)() | Resets page setup to default paper size, margins and orientation.  |
| bool [get_Bidi](./get_bidi/)() | Specifies that this section contains bidirectional (complex scripts) text.  |
| bool [get_BorderAlwaysInFront](./get_borderalwaysinfront/)() | Specifies where the page border is positioned relative to intersecting texts and objects.  |
| Aspose::Words::PageBorderAppliesTo [get_BorderAppliesTo](./get_borderappliesto/)() | Specifies which pages the page border is printed on.  |
| Aspose::Words::PageBorderDistanceFrom [get_BorderDistanceFrom](./get_borderdistancefrom/)() | Gets or sets a value that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds.  |
| System::SharedPtr< Aspose::Words::BorderCollection > [get_Borders](./get_borders/)() | Gets a collection of the page borders.  |
| bool [get_BorderSurroundsFooter](./get_bordersurroundsfooter/)() | Specifies whether the page border includes or excludes the footer.  |
| bool [get_BorderSurroundsHeader](./get_bordersurroundsheader/)() | Specifies whether the page border includes or excludes the header.  |
| double [get_BottomMargin](./get_bottommargin/)() | Returns or sets the distance (in points) between the bottom edge of the page and the bottom boundary of the body text.  |
| Aspose::Words::ChapterPageSeparator [get_ChapterPageSeparator](./get_chapterpageseparator/)() | Gets the separator character that appears between the chapter number and the page number.  |
| int32_t [get_CharactersPerLine](./get_charactersperline/)() | Gets or sets the number of characters per line in the document grid.  |
| bool [get_DifferentFirstPageHeaderFooter](./get_differentfirstpageheaderfooter/)() | **True** if a different header or footer is used on the first page.  |
| System::SharedPtr< Aspose::Words::Notes::EndnoteOptions > [get_EndnoteOptions](./get_endnoteoptions/)() | Provides options that control numbering and positioning of endnotes in this section.  |
| int32_t [get_FirstPageTray](./get_firstpagetray/)() | Gets the paper tray (bin) to use for the first page of a section. The value is implementation (printer) specific.  |
| double [get_FooterDistance](./get_footerdistance/)() | Returns or sets the distance (in points) between the footer and the bottom of the page.  |
| System::SharedPtr< Aspose::Words::Notes::FootnoteOptions > [get_FootnoteOptions](./get_footnoteoptions/)() | Provides options that control numbering and positioning of footnotes in this section.  |
| double [get_Gutter](./get_gutter/)() | Gets or sets the amount of extra space added to the margin for document binding.  |
| double [get_HeaderDistance](./get_headerdistance/)() | Returns or sets the distance (in points) between the header and the top of the page.  |
| int32_t [get_HeadingLevelForChapter](./get_headinglevelforchapter/)() | Gets or sets the heading level style that is applied to the chapter titles in the document.  |
| Aspose::Words::SectionLayoutMode [get_LayoutMode](./get_layoutmode/)() | Gets or sets the layout mode of this section.  |
| double [get_LeftMargin](./get_leftmargin/)() | Returns or sets the distance (in points) between the left edge of the page and the left boundary of the body text.  |
| int32_t [get_LineNumberCountBy](./get_linenumbercountby/)() | Returns or sets the numeric increment for line numbers.  |
| double [get_LineNumberDistanceFromText](./get_linenumberdistancefromtext/)() | Gets or sets distance between the right edge of line numbers and the left edge of the document.  |
| Aspose::Words::LineNumberRestartMode [get_LineNumberRestartMode](./get_linenumberrestartmode/)() | Gets or sets the way line numbering runs that is, whether it starts over at the beginning of a new page or section or runs continuously.  |
| int32_t [get_LinesPerPage](./get_linesperpage/)() | Gets or sets the number of lines per page in the document grid.  |
| int32_t [get_LineStartingNumber](./get_linestartingnumber/)() | Gets or sets the starting line number.  |
| Aspose::Words::Settings::MultiplePagesType [get_MultiplePages](./get_multiplepages/)() const | For multiple page documents, gets or sets how a document is printed or rendered so that it can be bound as a booklet.  |
| bool [get_OddAndEvenPagesHeaderFooter](./get_oddandevenpagesheaderfooter/)() const | **True** if the document has different headers and footers for odd-numbered and even-numbered pages.  |
| Aspose::Words::Orientation [get_Orientation](./get_orientation/)() | Returns or sets the orientation of the page.  |
| int32_t [get_OtherPagesTray](./get_otherpagestray/)() | Gets the paper tray (bin) to be used for all but the first page of a section. The value is implementation (printer) specific.  |
| double [get_PageHeight](./get_pageheight/)() | Returns or sets the height of the page in points.  |
| Aspose::Words::NumberStyle [get_PageNumberStyle](./get_pagenumberstyle/)() | Gets or sets the page number format.  |
| int32_t [get_PageStartingNumber](./get_pagestartingnumber/)() | Gets or sets the starting page number of the section.  |
| double [get_PageWidth](./get_pagewidth/)() | Returns or sets the width of the page in points.  |
| Aspose::Words::PaperSize [get_PaperSize](./get_papersize/)() | Returns or sets the paper size.  |
| bool [get_RestartPageNumbering](./get_restartpagenumbering/)() | **True** if page numbering restarts at the beginning of the section.  |
| double [get_RightMargin](./get_rightmargin/)() | Returns or sets the distance (in points) between the right edge of the page and the right boundary of the body text.  |
| bool [get_RtlGutter](./get_rtlgutter/)() | Gets or sets whether Microsoft Word uses gutters for the section based on a right-to-left language or a left-to-right language.  |
| Aspose::Words::SectionStart [get_SectionStart](./get_sectionstart/)() | Returns or sets the type of section break for the specified object.  |
| int32_t [get_SheetsPerBooklet](./get_sheetsperbooklet/)() const | Returns or sets the number of pages to be included in each booklet.  |
| bool [get_SuppressEndnotes](./get_suppressendnotes/)() | **True** if endnotes are printed at the end of the next section that doesn't suppress endnotes. Suppressed endnotes are printed before the endnotes in that section.  |
| System::SharedPtr< Aspose::Words::TextColumnCollection > [get_TextColumns](./get_textcolumns/)() | Returns a collection that represents the set of text columns.  |
| Aspose::Words::TextOrientation [get_TextOrientation](./get_textorientation/)() | Allows to specify TextOrientation for the whole page. Default value is Horizontal |
| double [get_TopMargin](./get_topmargin/)() | Returns or sets the distance (in points) between the top edge of the page and the top boundary of the body text.  |
| Aspose::Words::PageVerticalAlignment [get_VerticalAlignment](./get_verticalalignment/)() | Returns or sets the vertical alignment of text on each page in a document or section.  |
| void [set_Bidi](./set_bidi/)(bool) | Setter for Aspose::Words::PageSetup::get_Bidi.  |
| void [set_BorderAlwaysInFront](./set_borderalwaysinfront/)(bool) | Setter for Aspose::Words::PageSetup::get_BorderAlwaysInFront.  |
| void [set_BorderAppliesTo](./set_borderappliesto/)(Aspose::Words::PageBorderAppliesTo) | Setter for Aspose::Words::PageSetup::get_BorderAppliesTo.  |
| void [set_BorderDistanceFrom](./set_borderdistancefrom/)(Aspose::Words::PageBorderDistanceFrom) | Setter for Aspose::Words::PageSetup::get_BorderDistanceFrom.  |
| void [set_BorderSurroundsFooter](./set_bordersurroundsfooter/)(bool) | Setter for Aspose::Words::PageSetup::get_BorderSurroundsFooter.  |
| void [set_BorderSurroundsHeader](./set_bordersurroundsheader/)(bool) | Setter for Aspose::Words::PageSetup::get_BorderSurroundsHeader.  |
| void [set_BottomMargin](./set_bottommargin/)(double) | Setter for Aspose::Words::PageSetup::get_BottomMargin.  |
| void [set_ChapterPageSeparator](./set_chapterpageseparator/)(Aspose::Words::ChapterPageSeparator) | Sets the separator character that appears between the chapter number and the page number.  |
| void [set_CharactersPerLine](./set_charactersperline/)(int32_t) | Setter for Aspose::Words::PageSetup::get_CharactersPerLine.  |
| void [set_DifferentFirstPageHeaderFooter](./set_differentfirstpageheaderfooter/)(bool) | Setter for Aspose::Words::PageSetup::get_DifferentFirstPageHeaderFooter.  |
| void [set_FirstPageTray](./set_firstpagetray/)(int32_t) | Sets the paper tray (bin) to use for the first page of a section. The value is implementation (printer) specific.  |
| void [set_FooterDistance](./set_footerdistance/)(double) | Setter for Aspose::Words::PageSetup::get_FooterDistance.  |
| void [set_Gutter](./set_gutter/)(double) | Setter for Aspose::Words::PageSetup::get_Gutter.  |
| void [set_HeaderDistance](./set_headerdistance/)(double) | Setter for Aspose::Words::PageSetup::get_HeaderDistance.  |
| void [set_HeadingLevelForChapter](./set_headinglevelforchapter/)(int32_t) | Setter for Aspose::Words::PageSetup::get_HeadingLevelForChapter.  |
| void [set_LayoutMode](./set_layoutmode/)(Aspose::Words::SectionLayoutMode) | Setter for Aspose::Words::PageSetup::get_LayoutMode.  |
| void [set_LeftMargin](./set_leftmargin/)(double) | Setter for Aspose::Words::PageSetup::get_LeftMargin.  |
| void [set_LineNumberCountBy](./set_linenumbercountby/)(int32_t) | Setter for Aspose::Words::PageSetup::get_LineNumberCountBy.  |
| void [set_LineNumberDistanceFromText](./set_linenumberdistancefromtext/)(double) | Setter for Aspose::Words::PageSetup::get_LineNumberDistanceFromText.  |
| void [set_LineNumberRestartMode](./set_linenumberrestartmode/)(Aspose::Words::LineNumberRestartMode) | Setter for Aspose::Words::PageSetup::get_LineNumberRestartMode.  |
| void [set_LinesPerPage](./set_linesperpage/)(int32_t) | Setter for Aspose::Words::PageSetup::get_LinesPerPage.  |
| void [set_LineStartingNumber](./set_linestartingnumber/)(int32_t) | Setter for Aspose::Words::PageSetup::get_LineStartingNumber.  |
| void [set_MultiplePages](./set_multiplepages/)(Aspose::Words::Settings::MultiplePagesType) | Setter for Aspose::Words::PageSetup::get_MultiplePages.  |
| void [set_OddAndEvenPagesHeaderFooter](./set_oddandevenpagesheaderfooter/)(bool) | Setter for Aspose::Words::PageSetup::get_OddAndEvenPagesHeaderFooter.  |
| void [set_Orientation](./set_orientation/)(Aspose::Words::Orientation) | Setter for Aspose::Words::PageSetup::get_Orientation.  |
| void [set_OtherPagesTray](./set_otherpagestray/)(int32_t) | Sets the paper tray (bin) to be used for all but the first page of a section. The value is implementation (printer) specific.  |
| void [set_PageHeight](./set_pageheight/)(double) | Setter for Aspose::Words::PageSetup::get_PageHeight.  |
| void [set_PageNumberStyle](./set_pagenumberstyle/)(Aspose::Words::NumberStyle) | Setter for Aspose::Words::PageSetup::get_PageNumberStyle.  |
| void [set_PageStartingNumber](./set_pagestartingnumber/)(int32_t) | Setter for Aspose::Words::PageSetup::get_PageStartingNumber.  |
| void [set_PageWidth](./set_pagewidth/)(double) | Setter for Aspose::Words::PageSetup::get_PageWidth.  |
| void [set_PaperSize](./set_papersize/)(Aspose::Words::PaperSize) | Setter for Aspose::Words::PageSetup::get_PaperSize.  |
| void [set_RestartPageNumbering](./set_restartpagenumbering/)(bool) | Setter for Aspose::Words::PageSetup::get_RestartPageNumbering.  |
| void [set_RightMargin](./set_rightmargin/)(double) | Setter for Aspose::Words::PageSetup::get_RightMargin.  |
| void [set_RtlGutter](./set_rtlgutter/)(bool) | Setter for Aspose::Words::PageSetup::get_RtlGutter.  |
| void [set_SectionStart](./set_sectionstart/)(Aspose::Words::SectionStart) | Setter for Aspose::Words::PageSetup::get_SectionStart.  |
| void [set_SheetsPerBooklet](./set_sheetsperbooklet/)(int32_t) | Setter for Aspose::Words::PageSetup::get_SheetsPerBooklet.  |
| void [set_SuppressEndnotes](./set_suppressendnotes/)(bool) | Setter for Aspose::Words::PageSetup::get_SuppressEndnotes.  |
| void [set_TextOrientation](./set_textorientation/)(Aspose::Words::TextOrientation) | Setter for Aspose::Words::PageSetup::get_TextOrientation.  |
| void [set_TopMargin](./set_topmargin/)(double) | Setter for Aspose::Words::PageSetup::get_TopMargin.  |
| void [set_VerticalAlignment](./set_verticalalignment/)(Aspose::Words::PageVerticalAlignment) | Setter for Aspose::Words::PageSetup::get_VerticalAlignment.  |
