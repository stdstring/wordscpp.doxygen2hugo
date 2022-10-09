---
title: SvgSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Svg format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/svgsaveoptions/
---

Can be used to specify additional options when saving a document into the Svg format. 

## Methods

| Method | Description |
| --- | --- |
| [SvgSaveOptions](./svgsaveoptions/)() |  |
| [get_ExportEmbeddedImages](./get_exportembeddedimages/)() const | Specified whether images should be embedded into SVG document as base64. Note setting this flag can significantly increase size of output SVG file.  |
| [get_FitToViewPort](./get_fittoviewport/)() const | Specifies if the output SVG should fill the available viewport area (browser window or container). When set to true width and height of output SVG are set to 100%. The default value is false.  |
| [get_ResourceSavingCallback](./get_resourcesavingcallback/)() const | Allows to control how resources (images) are saved when a document is exported to SVG format.  |
| [get_ResourcesFolder](./get_resourcesfolder/)() const | Specifies the physical folder where resources (images) are saved when exporting a document to Svg format. Default is **null**.  |
| [get_ResourcesFolderAlias](./get_resourcesfolderalias/)() const | Specifies the name of the folder used to construct image URIs written into an SVG document. Default is **null**.  |
| [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be Svg.  |
| [get_ShowPageBorder](./get_showpageborder/)() const | Controls whether a border is added to the outline of the page. Default is **true**.  |
| [get_TextOutputMode](./get_textoutputmode/)() const | Gets or sets a value determining how text should be rendered in SVG.  |
| [set_ExportEmbeddedImages](./set_exportembeddedimages/)(bool) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_ExportEmbeddedImages.  |
| [set_FitToViewPort](./set_fittoviewport/)(bool) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_FitToViewPort.  |
| [set_ResourceSavingCallback](./set_resourcesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IResourceSavingCallback > &) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_ResourceSavingCallback.  |
| [set_ResourcesFolder](./set_resourcesfolder/)(const System::String &) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_ResourcesFolder.  |
| [set_ResourcesFolderAlias](./set_resourcesfolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_ResourcesFolderAlias.  |
| [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::SvgSaveOptions::get_SaveFormat.  |
| [set_ShowPageBorder](./set_showpageborder/)(bool) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_ShowPageBorder.  |
| [set_TextOutputMode](./set_textoutputmode/)(Aspose::Words::Saving::SvgTextOutputMode) | Setter for Aspose::Words::Saving::SvgSaveOptions::get_TextOutputMode.  |
