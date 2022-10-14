---
title: FixedPageSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Contains common options that can be specified when saving a document into fixed page formats (PDF, XPS, images etc). 
type: docs
weight: 0
url: /cpp/aspose.words.saving/fixedpagesaveoptions/
---
## FixedPageSaveOptions class


Contains common options that can be specified when saving a document into fixed page formats (PDF, XPS, images etc). 

## Methods

| Method | Description |
| --- | --- |
| static [CreateSaveOptions](../saveoptions/createsaveoptions/)(Aspose::Words::SaveFormat) | Creates a save options object of a class suitable for the specified save format.  |
| static [CreateSaveOptions](../saveoptions/createsaveoptions/)(const System::String &) | Creates a save options object of a class suitable for the file extension specified in the given file name.  |
| [Equals](./equals/)(System::SharedPtr< System::Object >) override | Determines whether the specified object is equal in value to the current object.  |
| [get_AllowEmbeddingPostScriptFonts](../saveoptions/get_allowembeddingpostscriptfonts/)() const | Gets or sets a boolean value indicating whether to allow embedding fonts with PostScript outlines when embedding TrueType fonts in a document upon it is saved. The default value is **false**.  |
| [get_ColorMode](./get_colormode/)() const | Gets or sets a value determining how colors are rendered.  |
| [get_CustomTimeZoneInfo](../saveoptions/get_customtimezoneinfo/)() const |  |
| [get_DefaultTemplate](../saveoptions/get_defaulttemplate/)() const | Gets or sets path to default template (including filename). Default value for this property is **empty string**.  |
| [get_Dml3DEffectsRenderingMode](../saveoptions/get_dml3deffectsrenderingmode/)() const | Gets a value determining how 3D effects are rendered.  |
| virtual [get_DmlEffectsRenderingMode](../saveoptions/get_dmleffectsrenderingmode/)() | Gets or sets a value determining how DrawingML effects are rendered.  |
| [get_DmlRenderingMode](../saveoptions/get_dmlrenderingmode/)() const | Gets or sets a value determining how DrawingML shapes are rendered.  |
| [get_ExportGeneratorName](../saveoptions/get_exportgeneratorname/)() const | When true, causes the name and version of Aspose.Words to be embedded into produced files. Default value is **true**.  |
| [get_FlatOpcXmlMappingOnly](../saveoptions/get_flatopcxmlmappingonly/)() const | Gets or sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| [get_ImlRenderingMode](../saveoptions/get_imlrenderingmode/)() const | Gets or sets a value determining how ink (InkML) objects are rendered.  |
| [get_JpegQuality](./get_jpegquality/)() const | Gets or sets a value determining the quality of the JPEG images inside Html document.  |
| [get_MemoryOptimization](../saveoptions/get_memoryoptimization/)() const | Gets or sets value determining if memory optimization should be performed before saving the document. Default value for this property is **false**.  |
| [get_MetafileRenderingOptions](./get_metafilerenderingoptions/)() const | Allows to specify metafile rendering options.  |
| [get_NumeralFormat](./get_numeralformat/)() const | Gets or sets NumeralFormat used for rendering of numerals. European numerals are used by default.  |
| virtual [get_OptimizeOutput](./get_optimizeoutput/)() | Flag indicates whether it is required to optimize output. If this flag is set redundant nested canvases and empty canvases are removed, also neighbor glyphs with the same formatting are concatenated. Note: The accuracy of the content display may be affected if this property is set to true. Default is false.  |
| [get_PageSavingCallback](./get_pagesavingcallback/)() const | Allows to control how separate pages are saved when a document is exported to fixed page format.  |
| [get_PageSet](./get_pageset/)() const | Gets or sets the pages to render. Default is all the pages in the document.  |
| [get_PrettyFormat](../saveoptions/get_prettyformat/)() const | When **true**, pretty formats output where applicable. Default value is **false**.  |
| [get_ProgressCallback](../saveoptions/get_progresscallback/)() const | Called during saving a document and accepts data about saving progress.  |
| virtual [get_SaveFormat](../saveoptions/get_saveformat/)() | Specifies the format in which the document will be saved if this save options object is used.  |
| [get_TempFolder](../saveoptions/get_tempfolder/)() const | Specifies the folder for temporary files used when saving to a DOC or DOCX file. By default this property is **null** and no temporary files are used.  |
| [get_UpdateCreatedTimeProperty](../saveoptions/get_updatecreatedtimeproperty/)() const | Gets a value determining whether the CreatedTime property is updated before saving. Default value is false;.  |
| [get_UpdateFields](../saveoptions/get_updatefields/)() const | Gets or sets a value determining if fields of certain types should be updated before saving the document to a fixed page format. Default value for this property is **true**.  |
| [get_UpdateLastPrintedProperty](../saveoptions/get_updatelastprintedproperty/)() const | Gets or sets a value determining whether the LastPrinted property is updated before saving.  |
| [get_UpdateLastSavedTimeProperty](../saveoptions/get_updatelastsavedtimeproperty/)() const | Gets or sets a value determining whether the LastSavedTime property is updated before saving.  |
| [get_UpdateSdtContent](../saveoptions/get_updatesdtcontent/)() const | Gets or sets value determining whether content of StructuredDocumentTag is updated before saving.  |
| [get_UseAntiAliasing](../saveoptions/get_useantialiasing/)() const | Gets or sets a value determining whether or not to use anti-aliasing for rendering.  |
| [get_UseHighQualityRendering](../saveoptions/get_usehighqualityrendering/)() const | Gets or sets a value determining whether or not to use high quality (i.e. slow) rendering algorithms.  |
| [set_AllowEmbeddingPostScriptFonts](../saveoptions/set_allowembeddingpostscriptfonts/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_AllowEmbeddingPostScriptFonts.  |
| [set_ColorMode](./set_colormode/)(Aspose::Words::Saving::ColorMode) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_ColorMode.  |
| [set_CustomTimeZoneInfo](../saveoptions/set_customtimezoneinfo/)(const System::SharedPtr< System::TimeZoneInfo > &) |  |
| [set_DefaultTemplate](../saveoptions/set_defaulttemplate/)(const System::String &) | Setter for Aspose::Words::Saving::SaveOptions::get_DefaultTemplate.  |
| [set_Dml3DEffectsRenderingMode](../saveoptions/set_dml3deffectsrenderingmode/)(Aspose::Words::Saving::Dml3DEffectsRenderingMode) | Sets a value determining how 3D effects are rendered.  |
| virtual [set_DmlEffectsRenderingMode](../saveoptions/set_dmleffectsrenderingmode/)(Aspose::Words::Saving::DmlEffectsRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_DmlEffectsRenderingMode.  |
| [set_DmlRenderingMode](../saveoptions/set_dmlrenderingmode/)(Aspose::Words::Saving::DmlRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_DmlRenderingMode.  |
| [set_ExportGeneratorName](../saveoptions/set_exportgeneratorname/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_ExportGeneratorName.  |
| [set_FlatOpcXmlMappingOnly](../saveoptions/set_flatopcxmlmappingonly/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_FlatOpcXmlMappingOnly.  |
| [set_ImlRenderingMode](../saveoptions/set_imlrenderingmode/)(Aspose::Words::Saving::ImlRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_ImlRenderingMode.  |
| [set_JpegQuality](./set_jpegquality/)(int32_t) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_JpegQuality.  |
| [set_MemoryOptimization](../saveoptions/set_memoryoptimization/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_MemoryOptimization.  |
| [set_MetafileRenderingOptions](./set_metafilerenderingoptions/)(const System::SharedPtr< Aspose::Words::Saving::MetafileRenderingOptions > &) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_MetafileRenderingOptions.  |
| [set_NumeralFormat](./set_numeralformat/)(Aspose::Words::Saving::NumeralFormat) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_NumeralFormat.  |
| virtual [set_OptimizeOutput](./set_optimizeoutput/)(bool) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_OptimizeOutput.  |
| [set_PageSavingCallback](./set_pagesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IPageSavingCallback > &) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_PageSavingCallback.  |
| [set_PageSet](./set_pageset/)(const System::SharedPtr< Aspose::Words::Saving::PageSet > &) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_PageSet.  |
| [set_PrettyFormat](../saveoptions/set_prettyformat/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_PrettyFormat.  |
| [set_ProgressCallback](../saveoptions/set_progresscallback/)(const System::SharedPtr< Aspose::Words::Saving::IDocumentSavingCallback > &) | Setter for Aspose::Words::Saving::SaveOptions::get_ProgressCallback.  |
| virtual [set_SaveFormat](../saveoptions/set_saveformat/)(Aspose::Words::SaveFormat) | Setter for Aspose::Words::Saving::SaveOptions::get_SaveFormat.  |
| [set_TempFolder](../saveoptions/set_tempfolder/)(const System::String &) | Setter for Aspose::Words::Saving::SaveOptions::get_TempFolder.  |
| [set_UpdateCreatedTimeProperty](../saveoptions/set_updatecreatedtimeproperty/)(bool) | Sets a value determining whether the CreatedTime property is updated before saving. Default value is false;.  |
| [set_UpdateFields](../saveoptions/set_updatefields/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateFields.  |
| [set_UpdateLastPrintedProperty](../saveoptions/set_updatelastprintedproperty/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateLastPrintedProperty.  |
| [set_UpdateLastSavedTimeProperty](../saveoptions/set_updatelastsavedtimeproperty/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateLastSavedTimeProperty.  |
| [set_UpdateSdtContent](../saveoptions/set_updatesdtcontent/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateSdtContent.  |
| [set_UseAntiAliasing](../saveoptions/set_useantialiasing/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UseAntiAliasing.  |
| [set_UseHighQualityRendering](../saveoptions/set_usehighqualityrendering/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UseHighQualityRendering.  |
