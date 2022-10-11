---
title: HtmlSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Html, Mhtml, Epub or Azw3 format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/htmlsaveoptions/
---
## HtmlSaveOptions class


Can be used to specify additional options when saving a document into the Html, Mhtml, Epub or Azw3 format. 

## Methods

| Method | Description |
| --- | --- |
|  [HtmlSaveOptions](./htmlsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the Html format.  |
|  [HtmlSaveOptions](./htmlsaveoptions/)(Aspose::Words::SaveFormat) | Initializes a new instance of this class that can be used to save a document in the Html, Mhtml, Epub or Azw3 format.  |
| bool [get_AllowNegativeIndent](./get_allownegativeindent/)() const | Specifies whether negative left and right indents of paragraphs are normalized when saving to HTML, MHTML or EPUB. Default value is **false**.  |
| System::String [get_CssClassNamePrefix](./get_cssclassnameprefix/)() const | Specifies a prefix which is added to all CSS class names. Default value is an empty string and generated CSS class names have no common prefix.  |
| System::SharedPtr< Aspose::Words::Saving::ICssSavingCallback > [get_CssSavingCallback](./get_csssavingcallback/)() const | Allows to control how CSS styles are saved when a document is saved to HTML, MHTML or EPUB.  |
| System::String [get_CssStyleSheetFileName](./get_cssstylesheetfilename/)() const | Specifies the path and the name of the Cascading Style Sheet (CSS) file written when a document is exported to HTML. Default is an empty string.  |
| Aspose::Words::Saving::CssStyleSheetType [get_CssStyleSheetType](./get_cssstylesheettype/)() const | Specifies how CSS (Cascading Style Sheet) styles are exported to HTML, MHTML or EPUB. Default value is Inline for HTML/MHTML and External for EPUB.  |
| System::SharedPtr< Aspose::Words::Saving::IDocumentPartSavingCallback > [get_DocumentPartSavingCallback](./get_documentpartsavingcallback/)() const | Allows to control how document parts are saved when a document is saved to HTML or EPUB.  |
| Aspose::Words::Saving::DocumentSplitCriteria [get_DocumentSplitCriteria](./get_documentsplitcriteria/)() const | Specifies how the document should be split when saving to Html, Epub or Azw3 format. Default is None for HTML and HeadingParagraph for EPUB and AZW3.  |
| int32_t [get_DocumentSplitHeadingLevel](./get_documentsplitheadinglevel/)() const | Specifies the maximum level of headings at which to split the document. Default value is **%2**.  |
| System::SharedPtr< System::Text::Encoding > [get_Encoding](./get_encoding/)() const | Specifies the encoding to use when exporting to HTML, MHTML or EPUB. Default value is **new UTF8Encoding(false)** (UTF-8 without BOM).  |
| int32_t [get_EpubNavigationMapLevel](./get_epubnavigationmaplevel/)() const | Specifies the maximum level of headings populated to the navigation map when exporting to IDPF EPUB format. Default value is **%3**.  |
| bool [get_ExportCidUrlsForMhtmlResources](./get_exportcidurlsformhtmlresources/)() const | Specifies whether to use CID (Content-ID) URLs to reference resources (images, fonts, CSS) included in MHTML documents. Default value is **false**.  |
| bool [get_ExportDocumentProperties](./get_exportdocumentproperties/)() const | Specifies whether to export built-in and custom document properties to HTML, MHTML or EPUB. Default value is **false**.  |
| bool [get_ExportDropDownFormFieldAsText](./get_exportdropdownformfieldastext/)() const | Controls how drop-down form fields are saved to HTML or MHTML. Default value is **false**.  |
| bool [get_ExportFontResources](./get_exportfontresources/)() const | Specifies whether font resources should be exported to HTML, MHTML or EPUB. Default is **false**.  |
| bool [get_ExportFontsAsBase64](./get_exportfontsasbase64/)() const | Specifies whether fonts resources should be embedded to HTML in Base64 encoding. Default is **false**.  |
| Aspose::Words::Saving::ExportHeadersFootersMode [get_ExportHeadersFootersMode](./get_exportheadersfootersmode/)() const | Specifies how headers and footers are output to HTML, MHTML or EPUB. Default value is PerSection for HTML/MHTML and None for EPUB.  |
| bool [get_ExportImagesAsBase64](./get_exportimagesasbase64/)() const | Specifies whether images are saved in Base64 format to the output HTML, MHTML or EPUB. Default is **false**.  |
| bool [get_ExportLanguageInformation](./get_exportlanguageinformation/)() const | Specifies whether language information is exported to HTML, MHTML or EPUB. Default is **false**.  |
| Aspose::Words::Saving::ExportListLabels [get_ExportListLabels](./get_exportlistlabels/)() const | Controls how list labels are output to HTML, MHTML or EPUB. Default value is Auto.  |
| bool [get_ExportOriginalUrlForLinkedImages](./get_exportoriginalurlforlinkedimages/)() const | Specifies whether original URL should be used as the URL of the linked images. Default value is **false**.  |
| bool [get_ExportPageMargins](./get_exportpagemargins/)() const | Specifies whether page margins is exported to HTML, MHTML or EPUB. Default is **false**.  |
| bool [get_ExportPageSetup](./get_exportpagesetup/)() const | Specifies whether page setup is exported to HTML, MHTML or EPUB. Default is **false**.  |
| bool [get_ExportRelativeFontSize](./get_exportrelativefontsize/)() const | Specifies whether font sizes should be output in relative units when saving to HTML, MHTML or EPUB. Default is **false**.  |
| bool [get_ExportRoundtripInformation](./get_exportroundtripinformation/)() const | Specifies whether to write the roundtrip information when saving to HTML, MHTML or EPUB. Default value is **true** for HTML and **false** for MHTML and EPUB.  |
| bool [get_ExportShapesAsSvg](./get_exportshapesassvg/)() const | Controls whether Shape nodes are converted to SVG images when saving to HTML, MHTML, EPUB or AZW3. Default value is **false**.  |
| bool [get_ExportTextInputFormFieldAsText](./get_exporttextinputformfieldastext/)() const | Controls how text input form fields are saved to HTML or MHTML. Default value is **false**.  |
| bool [get_ExportTocPageNumbers](./get_exporttocpagenumbers/)() const | Specifies whether to write page numbers to table of contents when saving HTML, MHTML and EPUB. Default value is **false**.  |
| bool [get_ExportXhtmlTransitional](./get_exportxhtmltransitional/)() const | Specifies whether to write the DOCTYPE declaration when saving to HTML or MHTML. When **true**, writes a DOCTYPE declaration in the document prior to the root element. Default value is **false**. When saving to EPUB or HTML5 (Html5) the DOCTYPE declaration is always written.  |
| int32_t [get_FontResourcesSubsettingSizeThreshold](./get_fontresourcessubsettingsizethreshold/)() const | Controls which font resources need subsetting when saving to HTML, MHTML or EPUB. Default is **%0**.  |
| System::SharedPtr< Aspose::Words::Saving::IFontSavingCallback > [get_FontSavingCallback](./get_fontsavingcallback/)() const | Allows to control how fonts are saved when a document is saved to HTML, MHTML or EPUB.  |
| System::String [get_FontsFolder](./get_fontsfolder/)() const | Specifies the physical folder where fonts are saved when exporting a document to HTML. Default is an empty string.  |
| System::String [get_FontsFolderAlias](./get_fontsfolderalias/)() const | Specifies the name of the folder used to construct font URIs written into an HTML document. Default is an empty string.  |
| Aspose::Words::Saving::HtmlVersion [get_HtmlVersion](./get_htmlversion/)() const | Specifies version of HTML standard that should be used when saving the document to HTML or MHTML. Default value is Xhtml.  |
| int32_t [get_ImageResolution](./get_imageresolution/)() const | Specifies the output resolution for images when exporting to HTML, MHTML or EPUB. Default is **%96 dpi**.  |
| System::SharedPtr< Aspose::Words::Saving::IImageSavingCallback > [get_ImageSavingCallback](./get_imagesavingcallback/)() const | Allows to control how images are saved when a document is saved to HTML, MHTML or EPUB.  |
| System::String [get_ImagesFolder](./get_imagesfolder/)() const | Specifies the physical folder where images are saved when exporting a document to HTML format. Default is an empty string.  |
| System::String [get_ImagesFolderAlias](./get_imagesfolderalias/)() const | Specifies the name of the folder used to construct image URIs written into an HTML document. Default is an empty string.  |
| Aspose::Words::Saving::HtmlMetafileFormat [get_MetafileFormat](./get_metafileformat/)() const | Specifies in what format metafiles are saved when exporting to HTML, MHTML, or EPUB. Default value is Png, meaning that metafiles are rendered to raster PNG images.  |
| Aspose::Words::Saving::HtmlOfficeMathOutputMode [get_OfficeMathOutputMode](./get_officemathoutputmode/)() const | Controls how OfficeMath objects are exported to HTML, MHTML or EPUB. Default value is **HtmlOfficeMathOutputMode.Image**.  |
| bool [get_ResolveFontNames](./get_resolvefontnames/)() const | Specifies whether font family names used in the document are resolved and substituted according to FontSettings when being written into HTML-based formats.  |
| System::String [get_ResourceFolder](./get_resourcefolder/)() const | Specifies a physical folder where all resources like images, fonts, and external CSS are saved when a document is exported to HTML. Default is an empty string.  |
| System::String [get_ResourceFolderAlias](./get_resourcefolderalias/)() const | Specifies the name of the folder used to construct URIs of all resources written into an HTML document. Default is an empty string.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can be Html, Mhtml, Epub or Azw3.  |
| bool [get_ScaleImageToShapeSize](./get_scaleimagetoshapesize/)() const | Specifies whether images are scaled by Aspose.Words to the bounding shape size when exporting to HTML, MHTML or EPUB. Default value is **true**.  |
| Aspose::Words::Saving::HtmlElementSizeOutputMode [get_TableWidthOutputMode](./get_tablewidthoutputmode/)() const | Controls how table, row and cell widths are exported to HTML, MHTML or EPUB. Default value is All.  |
| void [set_AllowNegativeIndent](./set_allownegativeindent/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_AllowNegativeIndent.  |
| void [set_CssClassNamePrefix](./set_cssclassnameprefix/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_CssClassNamePrefix.  |
| void [set_CssSavingCallback](./set_csssavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::ICssSavingCallback > &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_CssSavingCallback.  |
| void [set_CssStyleSheetFileName](./set_cssstylesheetfilename/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_CssStyleSheetFileName.  |
| void [set_CssStyleSheetType](./set_cssstylesheettype/)(Aspose::Words::Saving::CssStyleSheetType) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_CssStyleSheetType.  |
| void [set_DocumentPartSavingCallback](./set_documentpartsavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IDocumentPartSavingCallback > &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_DocumentPartSavingCallback.  |
| void [set_DocumentSplitCriteria](./set_documentsplitcriteria/)(Aspose::Words::Saving::DocumentSplitCriteria) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_DocumentSplitCriteria.  |
| void [set_DocumentSplitHeadingLevel](./set_documentsplitheadinglevel/)(int32_t) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_DocumentSplitHeadingLevel.  |
| void [set_Encoding](./set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_Encoding.  |
| void [set_EpubNavigationMapLevel](./set_epubnavigationmaplevel/)(int32_t) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_EpubNavigationMapLevel.  |
| void [set_ExportCidUrlsForMhtmlResources](./set_exportcidurlsformhtmlresources/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportCidUrlsForMhtmlResources.  |
| void [set_ExportDocumentProperties](./set_exportdocumentproperties/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportDocumentProperties.  |
| void [set_ExportDropDownFormFieldAsText](./set_exportdropdownformfieldastext/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportDropDownFormFieldAsText.  |
| void [set_ExportFontResources](./set_exportfontresources/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportFontResources.  |
| void [set_ExportFontsAsBase64](./set_exportfontsasbase64/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportFontsAsBase64.  |
| void [set_ExportHeadersFootersMode](./set_exportheadersfootersmode/)(Aspose::Words::Saving::ExportHeadersFootersMode) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportHeadersFootersMode.  |
| void [set_ExportImagesAsBase64](./set_exportimagesasbase64/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportImagesAsBase64.  |
| void [set_ExportLanguageInformation](./set_exportlanguageinformation/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportLanguageInformation.  |
| void [set_ExportListLabels](./set_exportlistlabels/)(Aspose::Words::Saving::ExportListLabels) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportListLabels.  |
| void [set_ExportOriginalUrlForLinkedImages](./set_exportoriginalurlforlinkedimages/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportOriginalUrlForLinkedImages.  |
| void [set_ExportPageMargins](./set_exportpagemargins/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportPageMargins.  |
| void [set_ExportPageSetup](./set_exportpagesetup/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportPageSetup.  |
| void [set_ExportRelativeFontSize](./set_exportrelativefontsize/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportRelativeFontSize.  |
| void [set_ExportRoundtripInformation](./set_exportroundtripinformation/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportRoundtripInformation.  |
| void [set_ExportShapesAsSvg](./set_exportshapesassvg/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportShapesAsSvg.  |
| void [set_ExportTextInputFormFieldAsText](./set_exporttextinputformfieldastext/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportTextInputFormFieldAsText.  |
| void [set_ExportTocPageNumbers](./set_exporttocpagenumbers/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportTocPageNumbers.  |
| void [set_ExportXhtmlTransitional](./set_exportxhtmltransitional/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ExportXhtmlTransitional.  |
| void [set_FontResourcesSubsettingSizeThreshold](./set_fontresourcessubsettingsizethreshold/)(int32_t) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_FontResourcesSubsettingSizeThreshold.  |
| void [set_FontSavingCallback](./set_fontsavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IFontSavingCallback > &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_FontSavingCallback.  |
| void [set_FontsFolder](./set_fontsfolder/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_FontsFolder.  |
| void [set_FontsFolderAlias](./set_fontsfolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_FontsFolderAlias.  |
| void [set_HtmlVersion](./set_htmlversion/)(Aspose::Words::Saving::HtmlVersion) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_HtmlVersion.  |
| void [set_ImageResolution](./set_imageresolution/)(int32_t) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ImageResolution.  |
| void [set_ImageSavingCallback](./set_imagesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IImageSavingCallback > &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ImageSavingCallback.  |
| void [set_ImagesFolder](./set_imagesfolder/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ImagesFolder.  |
| void [set_ImagesFolderAlias](./set_imagesfolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ImagesFolderAlias.  |
| void [set_MetafileFormat](./set_metafileformat/)(Aspose::Words::Saving::HtmlMetafileFormat) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_MetafileFormat.  |
| void [set_OfficeMathOutputMode](./set_officemathoutputmode/)(Aspose::Words::Saving::HtmlOfficeMathOutputMode) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_OfficeMathOutputMode.  |
| void [set_ResolveFontNames](./set_resolvefontnames/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ResolveFontNames.  |
| void [set_ResourceFolder](./set_resourcefolder/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ResourceFolder.  |
| void [set_ResourceFolderAlias](./set_resourcefolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ResourceFolderAlias.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_SaveFormat.  |
| void [set_ScaleImageToShapeSize](./set_scaleimagetoshapesize/)(bool) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_ScaleImageToShapeSize.  |
| void [set_TableWidthOutputMode](./set_tablewidthoutputmode/)(Aspose::Words::Saving::HtmlElementSizeOutputMode) | Setter for Aspose::Words::Saving::HtmlSaveOptions::get_TableWidthOutputMode.  |
