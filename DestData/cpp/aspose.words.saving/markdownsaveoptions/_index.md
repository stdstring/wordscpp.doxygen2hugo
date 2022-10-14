---
title: MarkdownSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Class to specify additional options when saving a document into the Markdown format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/markdownsaveoptions/
---
## MarkdownSaveOptions class


Class to specify additional options when saving a document into the Markdown format. 

## Methods

| Method | Description |
| --- | --- |
| static [CreateSaveOptions](../saveoptions/createsaveoptions/)(Aspose::Words::SaveFormat) | Creates a save options object of a class suitable for the specified save format.  |
| static [CreateSaveOptions](../saveoptions/createsaveoptions/)(const System::String &) | Creates a save options object of a class suitable for the file extension specified in the given file name.  |
| [get_AllowEmbeddingPostScriptFonts](../saveoptions/get_allowembeddingpostscriptfonts/)() const | Gets or sets a boolean value indicating whether to allow embedding fonts with PostScript outlines when embedding TrueType fonts in a document upon it is saved. The default value is **false**.  |
| [get_CustomTimeZoneInfo](../saveoptions/get_customtimezoneinfo/)() const |  |
| [get_DefaultTemplate](../saveoptions/get_defaulttemplate/)() const | Gets or sets path to default template (including filename). Default value for this property is **empty string**.  |
| [get_Dml3DEffectsRenderingMode](../saveoptions/get_dml3deffectsrenderingmode/)() const | Gets a value determining how 3D effects are rendered.  |
| virtual [get_DmlEffectsRenderingMode](../saveoptions/get_dmleffectsrenderingmode/)() | Gets or sets a value determining how DrawingML effects are rendered.  |
| [get_DmlRenderingMode](../saveoptions/get_dmlrenderingmode/)() const | Gets or sets a value determining how DrawingML shapes are rendered.  |
| [get_Encoding](../txtsaveoptionsbase/get_encoding/)() const | Specifies the encoding to use when exporting in text formats. Default value is **Encoding.UTF8**.  |
| [get_ExportGeneratorName](../saveoptions/get_exportgeneratorname/)() const | When true, causes the name and version of Aspose.Words to be embedded into produced files. Default value is **true**.  |
| [get_ExportHeadersFootersMode](../txtsaveoptionsbase/get_exportheadersfootersmode/)() const | Specifies the way headers and footers are exported to the text formats. Default value is PrimaryOnly.  |
| [get_ExportImagesAsBase64](./get_exportimagesasbase64/)() const | Specifies whether images are saved in Base64 format to the output file. Default is **false**.  |
| [get_FlatOpcXmlMappingOnly](../saveoptions/get_flatopcxmlmappingonly/)() const | Gets or sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| [get_ForcePageBreaks](../txtsaveoptionsbase/get_forcepagebreaks/)() const | Allows to specify whether the page breaks should be preserved during export. The default value is **false**.  |
| [get_ImageSavingCallback](./get_imagesavingcallback/)() const | Allows to control how images are saved when a document is saved to Markdown format.  |
| [get_ImagesFolder](./get_imagesfolder/)() const | Specifies the physical folder where images are saved when exporting a document to the Markdown format. Default is an empty string.  |
| [get_ImlRenderingMode](../saveoptions/get_imlrenderingmode/)() const | Gets or sets a value determining how ink (InkML) objects are rendered.  |
| [get_MemoryOptimization](../saveoptions/get_memoryoptimization/)() const | Gets or sets value determining if memory optimization should be performed before saving the document. Default value for this property is **false**.  |
| [get_ParagraphBreak](../txtsaveoptionsbase/get_paragraphbreak/)() const | Specifies the string to use as a paragraph break when exporting in text formats.  |
| [get_PrettyFormat](../saveoptions/get_prettyformat/)() const | When **true**, pretty formats output where applicable. Default value is **false**.  |
| [get_ProgressCallback](../saveoptions/get_progresscallback/)() const | Called during saving a document and accepts data about saving progress.  |
| [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be Markdown.  |
| [get_TableContentAlignment](./get_tablecontentalignment/)() const | Gets a value that specifies how to align contents in tables when exporting into the Markdown format. The default value is Auto.  |
| [get_TempFolder](../saveoptions/get_tempfolder/)() const | Specifies the folder for temporary files used when saving to a DOC or DOCX file. By default this property is **null** and no temporary files are used.  |
| [get_UpdateCreatedTimeProperty](../saveoptions/get_updatecreatedtimeproperty/)() const | Gets a value determining whether the CreatedTime property is updated before saving. Default value is false;.  |
| [get_UpdateFields](../saveoptions/get_updatefields/)() const | Gets or sets a value determining if fields of certain types should be updated before saving the document to a fixed page format. Default value for this property is **true**.  |
| [get_UpdateLastPrintedProperty](../saveoptions/get_updatelastprintedproperty/)() const | Gets or sets a value determining whether the LastPrinted property is updated before saving.  |
| [get_UpdateLastSavedTimeProperty](../saveoptions/get_updatelastsavedtimeproperty/)() const | Gets or sets a value determining whether the LastSavedTime property is updated before saving.  |
| [get_UpdateSdtContent](../saveoptions/get_updatesdtcontent/)() const | Gets or sets value determining whether content of StructuredDocumentTag is updated before saving.  |
| [get_UseAntiAliasing](../saveoptions/get_useantialiasing/)() const | Gets or sets a value determining whether or not to use anti-aliasing for rendering.  |
| [get_UseHighQualityRendering](../saveoptions/get_usehighqualityrendering/)() const | Gets or sets a value determining whether or not to use high quality (i.e. slow) rendering algorithms.  |
| [MarkdownSaveOptions](./markdownsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the Markdown format.  |
| [set_AllowEmbeddingPostScriptFonts](../saveoptions/set_allowembeddingpostscriptfonts/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_AllowEmbeddingPostScriptFonts.  |
| [set_CustomTimeZoneInfo](../saveoptions/set_customtimezoneinfo/)(const System::SharedPtr< System::TimeZoneInfo > &) |  |
| [set_DefaultTemplate](../saveoptions/set_defaulttemplate/)(const System::String &) | Setter for Aspose::Words::Saving::SaveOptions::get_DefaultTemplate.  |
| [set_Dml3DEffectsRenderingMode](../saveoptions/set_dml3deffectsrenderingmode/)(Aspose::Words::Saving::Dml3DEffectsRenderingMode) | Sets a value determining how 3D effects are rendered.  |
| virtual [set_DmlEffectsRenderingMode](../saveoptions/set_dmleffectsrenderingmode/)(Aspose::Words::Saving::DmlEffectsRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_DmlEffectsRenderingMode.  |
| [set_DmlRenderingMode](../saveoptions/set_dmlrenderingmode/)(Aspose::Words::Saving::DmlRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_DmlRenderingMode.  |
| [set_Encoding](../txtsaveoptionsbase/set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_Encoding.  |
| [set_ExportGeneratorName](../saveoptions/set_exportgeneratorname/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_ExportGeneratorName.  |
| [set_ExportHeadersFootersMode](../txtsaveoptionsbase/set_exportheadersfootersmode/)(Aspose::Words::Saving::TxtExportHeadersFootersMode) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_ExportHeadersFootersMode.  |
| [set_ExportImagesAsBase64](./set_exportimagesasbase64/)(bool) | Setter for Aspose::Words::Saving::MarkdownSaveOptions::get_ExportImagesAsBase64.  |
| [set_FlatOpcXmlMappingOnly](../saveoptions/set_flatopcxmlmappingonly/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_FlatOpcXmlMappingOnly.  |
| [set_ForcePageBreaks](../txtsaveoptionsbase/set_forcepagebreaks/)(bool) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_ForcePageBreaks.  |
| [set_ImageSavingCallback](./set_imagesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IImageSavingCallback > &) | Setter for Aspose::Words::Saving::MarkdownSaveOptions::get_ImageSavingCallback.  |
| [set_ImagesFolder](./set_imagesfolder/)(const System::String &) | Setter for Aspose::Words::Saving::MarkdownSaveOptions::get_ImagesFolder.  |
| [set_ImlRenderingMode](../saveoptions/set_imlrenderingmode/)(Aspose::Words::Saving::ImlRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_ImlRenderingMode.  |
| [set_MemoryOptimization](../saveoptions/set_memoryoptimization/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_MemoryOptimization.  |
| [set_ParagraphBreak](../txtsaveoptionsbase/set_paragraphbreak/)(const System::String &) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_ParagraphBreak.  |
| [set_PrettyFormat](../saveoptions/set_prettyformat/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_PrettyFormat.  |
| [set_ProgressCallback](../saveoptions/set_progresscallback/)(const System::SharedPtr< Aspose::Words::Saving::IDocumentSavingCallback > &) | Setter for Aspose::Words::Saving::SaveOptions::get_ProgressCallback.  |
| [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Specifies the format in which the document will be saved if this save options object is used. Can only be Markdown.  |
| [set_TableContentAlignment](./set_tablecontentalignment/)(Aspose::Words::Saving::TableContentAlignment) | Sets a value that specifies how to align contents in tables when exporting into the Markdown format. The default value is Auto.  |
| [set_TempFolder](../saveoptions/set_tempfolder/)(const System::String &) | Setter for Aspose::Words::Saving::SaveOptions::get_TempFolder.  |
| [set_UpdateCreatedTimeProperty](../saveoptions/set_updatecreatedtimeproperty/)(bool) | Sets a value determining whether the CreatedTime property is updated before saving. Default value is false;.  |
| [set_UpdateFields](../saveoptions/set_updatefields/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateFields.  |
| [set_UpdateLastPrintedProperty](../saveoptions/set_updatelastprintedproperty/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateLastPrintedProperty.  |
| [set_UpdateLastSavedTimeProperty](../saveoptions/set_updatelastsavedtimeproperty/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateLastSavedTimeProperty.  |
| [set_UpdateSdtContent](../saveoptions/set_updatesdtcontent/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateSdtContent.  |
| [set_UseAntiAliasing](../saveoptions/set_useantialiasing/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UseAntiAliasing.  |
| [set_UseHighQualityRendering](../saveoptions/set_usehighqualityrendering/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UseHighQualityRendering.  |
| [TxtSaveOptionsBase](../txtsaveoptionsbase/txtsaveoptionsbase/)() |  |
