---
title: HtmlFixedSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the HtmlFixed format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/htmlfixedsaveoptions/
---
## HtmlFixedSaveOptions class


Can be used to specify additional options when saving a document into the HtmlFixed format. 

## Methods

| Method | Description |
| --- | --- |
|  [HtmlFixedSaveOptions](./htmlfixedsaveoptions/)() |  |
| System::String [get_CssClassNamesPrefix](./get_cssclassnamesprefix/)() const | Specifies prefix which is added to all class names in style.css file. Default value is **%"aw"**.  |
| System::SharedPtr< System::Text::Encoding > [get_Encoding](./get_encoding/)() const | Specifies the encoding to use when exporting to HTML. Default value is **new UTF8Encoding(true)** (UTF-8 with BOM).  |
| bool [get_ExportEmbeddedCss](./get_exportembeddedcss/)() const | Specifies whether the CSS (Cascading Style Sheet) should be embedded into Html document.  |
| bool [get_ExportEmbeddedFonts](./get_exportembeddedfonts/)() const | Specifies whether fonts should be embedded into Html document in Base64 format. Note setting this flag can significantly increase size of output Html file.  |
| bool [get_ExportEmbeddedImages](./get_exportembeddedimages/)() const | Specifies whether images should be embedded into Html document in Base64 format. Note setting this flag can significantly increase size of output Html file.  |
| bool [get_ExportEmbeddedSvg](./get_exportembeddedsvg/)() const | Specifies whether SVG resources should be embedded into Html document. Default value is **true**.  |
| bool [get_ExportFormFields](./get_exportformfields/)() const | Gets or sets indication of whether form fields are exported as interactive items (as 'input' tag) rather than converted to text or graphics.  |
| Aspose::Words::Saving::ExportFontFormat [get_FontFormat](./get_fontformat/)() const | Gets or sets ExportFontFormat used for font exporting. Default value is Woff.  |
| bool [get_OptimizeOutput](./get_optimizeoutput/)() override | Flag indicates whether it is required to optimize output. If this flag is set redundant nested canvases and empty canvases are removed, also neighbor glyphs with the same formating are concatenated. Note: The accuracy of the content display may be affected if this property is set to true. Default is true.  |
| Aspose::Words::Saving::HtmlFixedPageHorizontalAlignment [get_PageHorizontalAlignment](./get_pagehorizontalalignment/)() const | Specifies the horizontal alignment of pages in an HTML document. Default value is **HtmlFixedHorizontalPageAlignment.Center**.  |
| double [get_PageMargins](./get_pagemargins/)() const | Specifies the margins around pages in an HTML document. The margins value is measured in points and should be equal to or greater than 0. Default value is 10 points.  |
| System::SharedPtr< Aspose::Words::Saving::IResourceSavingCallback > [get_ResourceSavingCallback](./get_resourcesavingcallback/)() const | Allows to control how resources (images, fonts and css) are saved when a document is exported to fixed page Html format.  |
| System::String [get_ResourcesFolder](./get_resourcesfolder/)() const | Specifies the physical folder where resources (images, fonts, css) are saved when exporting a document to Html format. Default is **null**.  |
| System::String [get_ResourcesFolderAlias](./get_resourcesfolderalias/)() const | Specifies the name of the folder used to construct image URIs written into an Html document. Default is **null**.  |
| bool [get_SaveFontFaceCssSeparately](./get_savefontfacecssseparately/)() const | Flag indicates whether "@font-face" CSS rules should be placed into a separate file "fontFaces.css" when a document is being saved with external stylesheet (that is, when ExportEmbeddedCss is **false**). Default value is **false**, all CSS rules are written into single file "styles.css".  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be HtmlFixed.  |
| bool [get_ShowPageBorder](./get_showpageborder/)() const | Specifies whether border around pages should be shown. Default is **true**.  |
| bool [get_UseTargetMachineFonts](./get_usetargetmachinefonts/)() const | Flag indicates whether fonts from target machine must be used to display the document. If this flag is set to true, FontFormat and ExportEmbeddedFonts properties do not have effect, also ResourceSavingCallback is not fired for fonts. Default is false.  |
| void [set_CssClassNamesPrefix](./set_cssclassnamesprefix/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_CssClassNamesPrefix.  |
| void [set_Encoding](./set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_Encoding.  |
| void [set_ExportEmbeddedCss](./set_exportembeddedcss/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ExportEmbeddedCss.  |
| void [set_ExportEmbeddedFonts](./set_exportembeddedfonts/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ExportEmbeddedFonts.  |
| void [set_ExportEmbeddedImages](./set_exportembeddedimages/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ExportEmbeddedImages.  |
| void [set_ExportEmbeddedSvg](./set_exportembeddedsvg/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ExportEmbeddedSvg.  |
| void [set_ExportFormFields](./set_exportformfields/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ExportFormFields.  |
| void [set_FontFormat](./set_fontformat/)(Aspose::Words::Saving::ExportFontFormat) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_FontFormat.  |
| void [set_OptimizeOutput](./set_optimizeoutput/)(bool) override | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_OptimizeOutput.  |
| void [set_PageHorizontalAlignment](./set_pagehorizontalalignment/)(Aspose::Words::Saving::HtmlFixedPageHorizontalAlignment) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_PageHorizontalAlignment.  |
| void [set_PageMargins](./set_pagemargins/)(double) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_PageMargins.  |
| void [set_ResourceSavingCallback](./set_resourcesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IResourceSavingCallback > &) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ResourceSavingCallback.  |
| void [set_ResourcesFolder](./set_resourcesfolder/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ResourcesFolder.  |
| void [set_ResourcesFolderAlias](./set_resourcesfolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ResourcesFolderAlias.  |
| void [set_SaveFontFaceCssSeparately](./set_savefontfacecssseparately/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_SaveFontFaceCssSeparately.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_SaveFormat.  |
| void [set_ShowPageBorder](./set_showpageborder/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_ShowPageBorder.  |
| void [set_UseTargetMachineFonts](./set_usetargetmachinefonts/)(bool) | Setter for Aspose::Words::Saving::HtmlFixedSaveOptions::get_UseTargetMachineFonts.  |
