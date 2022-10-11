---
title: PdfSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Pdf format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/pdfsaveoptions/
---
## PdfSaveOptions class


Can be used to specify additional options when saving a document into the Pdf format. 

## Methods

| Method | Description |
| --- | --- |
| [PdfSaveOptions](./pdfsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the Pdf format.  |
| [Clone](./clone/)() | Creates a deep clone of this object.  |
| [get_AdditionalTextPositioning](./get_additionaltextpositioning/)() const | A flag specifying whether to write additional text positioning operators or not.  |
| [get_Compliance](./get_compliance/)() | Specifies the PDF standards compliance level for output documents.  |
| [get_CreateNoteHyperlinks](./get_createnotehyperlinks/)() const | Specifies whether to convert footnote/endnote references in main text story into active hyperlinks. When clicked the hyperlink will lead to the corresponding footnote/endnote. Default is **false**.  |
| [get_CustomPropertiesExport](./get_custompropertiesexport/)() const | Gets or sets a value determining the way CustomDocumentProperties are exported to PDF file.  |
| [get_DigitalSignatureDetails](./get_digitalsignaturedetails/)() const | Gets or sets the details for signing the output PDF document.  |
| [get_DisplayDocTitle](./get_displaydoctitle/)() const | A flag specifying whether the window’s title bar should display the document title taken from the Title entry of the document information dictionary.  |
| [get_DmlEffectsRenderingMode](./get_dmleffectsrenderingmode/)() override | Gets or sets a value determining how DrawingML effects are rendered.  |
| [get_DownsampleOptions](./get_downsampleoptions/)() const | Allows to specify downsample options.  |
| [get_EmbedFullFonts](./get_embedfullfonts/)() const | Controls how fonts are embedded into the resulting PDF documents.  |
| [get_EncryptionDetails](./get_encryptiondetails/)() const | Gets or sets the details for encrypting the output PDF document.  |
| [get_ExportDocumentStructure](./get_exportdocumentstructure/)() const | Gets or sets a value determining whether or not to export document structure.  |
| [get_ExportLanguageToSpanTag](./get_exportlanguagetospantag/)() const | Gets or sets a value determining whether or not to create a "Span" tag in the document structure to export the text language.  |
| [get_FontEmbeddingMode](./get_fontembeddingmode/)() const | Specifies the font embedding mode.  |
| [get_HeaderFooterBookmarksExportMode](./get_headerfooterbookmarksexportmode/)() const | Determines how bookmarks in headers/footers are exported.  |
| [get_ImageColorSpaceExportMode](./get_imagecolorspaceexportmode/)() const | Specifies how the color space will be selected for the images in PDF document.  |
| [get_ImageCompression](./get_imagecompression/)() const | Specifies compression type to be used for all images in the document.  |
| [get_InterpolateImages](./get_interpolateimages/)() const | A flag indicating whether image interpolation shall be performed by a conforming reader. When **false** is specified, the flag is not written to the output document and the default behaviour of reader is used instead.  |
| [get_JpegQuality](./get_jpegquality/)() | Gets or sets a value determining the quality of the JPEG images inside PDF document.  |
| [get_OpenHyperlinksInNewWindow](./get_openhyperlinksinnewwindow/)() const | Gets or sets a value determining whether hyperlinks in the output Pdf document are forced to be opened in a new window (or tab) of a browser.  |
| [get_OutlineOptions](./get_outlineoptions/)() const | Allows to specify outline options.  |
| [get_PageMode](./get_pagemode/)() const | Specifies how the PDF document should be displayed when opened in the PDF reader.  |
| [get_PreblendImages](./get_preblendimages/)() const | Gets or sets a value determining whether or not to preblend transparent images with black background color.  |
| [get_PreserveFormFields](./get_preserveformfields/)() const | Specifies whether to preserve Microsoft Word form fields as form fields in PDF or convert them to text. Default is **false**.  |
| [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be Pdf.  |
| [get_TextCompression](./get_textcompression/)() const | Specifies compression type to be used for all textual content in the document.  |
| [get_UseBookFoldPrintingSettings](./get_usebookfoldprintingsettings/)() const | Gets or sets a boolean value indicating whether the document should be saved using a booklet printing layout, if it is specified via MultiplePages.  |
| [get_UseCoreFonts](./get_usecorefonts/)() const | Gets or sets a value determining whether or not to substitute TrueType fonts Arial, Times New Roman, Courier New and Symbol with core PDF Type 1 fonts.  |
| [get_ZoomBehavior](./get_zoombehavior/)() const | Gets or sets a value determining what type of zoom should be applied when a document is opened with a PDF viewer.  |
| [get_ZoomFactor](./get_zoomfactor/)() const | Gets or sets a value determining zoom factor (in percentages) for a document.  |
| [set_AdditionalTextPositioning](./set_additionaltextpositioning/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_AdditionalTextPositioning.  |
| [set_Compliance](./set_compliance/)(Aspose::Words::Saving::PdfCompliance) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_Compliance.  |
| [set_CreateNoteHyperlinks](./set_createnotehyperlinks/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_CreateNoteHyperlinks.  |
| [set_CustomPropertiesExport](./set_custompropertiesexport/)(Aspose::Words::Saving::PdfCustomPropertiesExport) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_CustomPropertiesExport.  |
| [set_DigitalSignatureDetails](./set_digitalsignaturedetails/)(const System::SharedPtr< Aspose::Words::Saving::PdfDigitalSignatureDetails > &) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_DigitalSignatureDetails.  |
| [set_DisplayDocTitle](./set_displaydoctitle/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_DisplayDocTitle.  |
| [set_DmlEffectsRenderingMode](./set_dmleffectsrenderingmode/)(Aspose::Words::Saving::DmlEffectsRenderingMode) override | Setter for Aspose::Words::Saving::PdfSaveOptions::get_DmlEffectsRenderingMode.  |
| [set_DownsampleOptions](./set_downsampleoptions/)(const System::SharedPtr< Aspose::Words::Saving::DownsampleOptions > &) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_DownsampleOptions.  |
| [set_EmbedFullFonts](./set_embedfullfonts/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_EmbedFullFonts.  |
| [set_EncryptionDetails](./set_encryptiondetails/)(const System::SharedPtr< Aspose::Words::Saving::PdfEncryptionDetails > &) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_EncryptionDetails.  |
| [set_ExportDocumentStructure](./set_exportdocumentstructure/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_ExportDocumentStructure.  |
| [set_ExportLanguageToSpanTag](./set_exportlanguagetospantag/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_ExportLanguageToSpanTag.  |
| [set_FontEmbeddingMode](./set_fontembeddingmode/)(Aspose::Words::Saving::PdfFontEmbeddingMode) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_FontEmbeddingMode.  |
| [set_HeaderFooterBookmarksExportMode](./set_headerfooterbookmarksexportmode/)(Aspose::Words::Saving::HeaderFooterBookmarksExportMode) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_HeaderFooterBookmarksExportMode.  |
| [set_ImageColorSpaceExportMode](./set_imagecolorspaceexportmode/)(Aspose::Words::Saving::PdfImageColorSpaceExportMode) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_ImageColorSpaceExportMode.  |
| [set_ImageCompression](./set_imagecompression/)(Aspose::Words::Saving::PdfImageCompression) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_ImageCompression.  |
| [set_InterpolateImages](./set_interpolateimages/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_InterpolateImages.  |
| [set_JpegQuality](./set_jpegquality/)(int32_t) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_JpegQuality.  |
| [set_OpenHyperlinksInNewWindow](./set_openhyperlinksinnewwindow/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_OpenHyperlinksInNewWindow.  |
| [set_PageMode](./set_pagemode/)(Aspose::Words::Saving::PdfPageMode) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_PageMode.  |
| [set_PreblendImages](./set_preblendimages/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_PreblendImages.  |
| [set_PreserveFormFields](./set_preserveformfields/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_PreserveFormFields.  |
| [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::PdfSaveOptions::get_SaveFormat.  |
| [set_TextCompression](./set_textcompression/)(Aspose::Words::Saving::PdfTextCompression) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_TextCompression.  |
| [set_UseBookFoldPrintingSettings](./set_usebookfoldprintingsettings/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_UseBookFoldPrintingSettings.  |
| [set_UseCoreFonts](./set_usecorefonts/)(bool) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_UseCoreFonts.  |
| [set_ZoomBehavior](./set_zoombehavior/)(Aspose::Words::Saving::PdfZoomBehavior) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_ZoomBehavior.  |
| [set_ZoomFactor](./set_zoomfactor/)(int32_t) | Setter for Aspose::Words::Saving::PdfSaveOptions::get_ZoomFactor.  |
