---
title: SaveOptions
second_title: Aspose.Words for C++ API Reference
description: This is an abstract base class for classes that allow the user to specify additional options when saving a document into a particular format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/saveoptions/
---
## SaveOptions class


This is an abstract base class for classes that allow the user to specify additional options when saving a document into a particular format. 

## Methods

| Method | Description |
| --- | --- |
| bool [get_AllowEmbeddingPostScriptFonts](./get_allowembeddingpostscriptfonts/)() const | Gets or sets a boolean value indicating whether to allow embedding fonts with PostScript outlines when embedding TrueType fonts in a document upon it is saved. The default value is **false**.  |
| System::SharedPtr< System::TimeZoneInfo > [get_CustomTimeZoneInfo](./get_customtimezoneinfo/)() const |  |
| System::String [get_DefaultTemplate](./get_defaulttemplate/)() const | Gets or sets path to default template (including filename). Default value for this property is **empty string**.  |
| Aspose::Words::Saving::Dml3DEffectsRenderingMode [get_Dml3DEffectsRenderingMode](./get_dml3deffectsrenderingmode/)() const | Gets a value determining how 3D effects are rendered.  |
| virtual Aspose::Words::Saving::DmlEffectsRenderingMode [get_DmlEffectsRenderingMode](./get_dmleffectsrenderingmode/)() | Gets or sets a value determining how DrawingML effects are rendered.  |
| Aspose::Words::Saving::DmlRenderingMode [get_DmlRenderingMode](./get_dmlrenderingmode/)() const | Gets or sets a value determining how DrawingML shapes are rendered.  |
| bool [get_ExportGeneratorName](./get_exportgeneratorname/)() const | When true, causes the name and version of Aspose.Words to be embedded into produced files. Default value is **true**.  |
| bool [get_FlatOpcXmlMappingOnly](./get_flatopcxmlmappingonly/)() const | Gets or sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| Aspose::Words::Saving::ImlRenderingMode [get_ImlRenderingMode](./get_imlrenderingmode/)() const | Gets or sets a value determining how ink (InkML) objects are rendered.  |
| bool [get_MemoryOptimization](./get_memoryoptimization/)() const | Gets or sets value determining if memory optimization should be performed before saving the document. Default value for this property is **false**.  |
| bool [get_PrettyFormat](./get_prettyformat/)() const | When **true**, pretty formats output where applicable. Default value is **false**.  |
| System::SharedPtr< Aspose::Words::Saving::IDocumentSavingCallback > [get_ProgressCallback](./get_progresscallback/)() const | Called during saving a document and accepts data about saving progress.  |
| virtual Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() | Specifies the format in which the document will be saved if this save options object is used.  |
| System::String [get_TempFolder](./get_tempfolder/)() const | Specifies the folder for temporary files used when saving to a DOC or DOCX file. By default this property is **null** and no temporary files are used.  |
| bool [get_UpdateCreatedTimeProperty](./get_updatecreatedtimeproperty/)() const | Gets a value determining whether the CreatedTime property is updated before saving. Default value is false;.  |
| bool [get_UpdateFields](./get_updatefields/)() const | Gets or sets a value determining if fields of certain types should be updated before saving the document to a fixed page format. Default value for this property is **true**.  |
| bool [get_UpdateLastPrintedProperty](./get_updatelastprintedproperty/)() const | Gets or sets a value determining whether the LastPrinted property is updated before saving.  |
| bool [get_UpdateLastSavedTimeProperty](./get_updatelastsavedtimeproperty/)() const | Gets or sets a value determining whether the LastSavedTime property is updated before saving.  |
| bool [get_UpdateSdtContent](./get_updatesdtcontent/)() const | Gets or sets value determining whether content of StructuredDocumentTag is updated before saving.  |
| bool [get_UseAntiAliasing](./get_useantialiasing/)() const | Gets or sets a value determining whether or not to use anti-aliasing for rendering.  |
| bool [get_UseHighQualityRendering](./get_usehighqualityrendering/)() const | Gets or sets a value determining whether or not to use high quality (i.e. slow) rendering algorithms.  |
| void [set_AllowEmbeddingPostScriptFonts](./set_allowembeddingpostscriptfonts/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_AllowEmbeddingPostScriptFonts.  |
| void [set_CustomTimeZoneInfo](./set_customtimezoneinfo/)(const System::SharedPtr< System::TimeZoneInfo > &) |  |
| void [set_DefaultTemplate](./set_defaulttemplate/)(const System::String &) | Setter for Aspose::Words::Saving::SaveOptions::get_DefaultTemplate.  |
| void [set_Dml3DEffectsRenderingMode](./set_dml3deffectsrenderingmode/)(Aspose::Words::Saving::Dml3DEffectsRenderingMode) | Sets a value determining how 3D effects are rendered.  |
| virtual void [set_DmlEffectsRenderingMode](./set_dmleffectsrenderingmode/)(Aspose::Words::Saving::DmlEffectsRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_DmlEffectsRenderingMode.  |
| void [set_DmlRenderingMode](./set_dmlrenderingmode/)(Aspose::Words::Saving::DmlRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_DmlRenderingMode.  |
| void [set_ExportGeneratorName](./set_exportgeneratorname/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_ExportGeneratorName.  |
| void [set_FlatOpcXmlMappingOnly](./set_flatopcxmlmappingonly/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_FlatOpcXmlMappingOnly.  |
| void [set_ImlRenderingMode](./set_imlrenderingmode/)(Aspose::Words::Saving::ImlRenderingMode) | Setter for Aspose::Words::Saving::SaveOptions::get_ImlRenderingMode.  |
| void [set_MemoryOptimization](./set_memoryoptimization/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_MemoryOptimization.  |
| void [set_PrettyFormat](./set_prettyformat/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_PrettyFormat.  |
| void [set_ProgressCallback](./set_progresscallback/)(const System::SharedPtr< Aspose::Words::Saving::IDocumentSavingCallback > &) | Setter for Aspose::Words::Saving::SaveOptions::get_ProgressCallback.  |
| virtual void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) | Setter for Aspose::Words::Saving::SaveOptions::get_SaveFormat.  |
| void [set_TempFolder](./set_tempfolder/)(const System::String &) | Setter for Aspose::Words::Saving::SaveOptions::get_TempFolder.  |
| void [set_UpdateCreatedTimeProperty](./set_updatecreatedtimeproperty/)(bool) | Sets a value determining whether the CreatedTime property is updated before saving. Default value is false;.  |
| void [set_UpdateFields](./set_updatefields/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateFields.  |
| void [set_UpdateLastPrintedProperty](./set_updatelastprintedproperty/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateLastPrintedProperty.  |
| void [set_UpdateLastSavedTimeProperty](./set_updatelastsavedtimeproperty/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateLastSavedTimeProperty.  |
| void [set_UpdateSdtContent](./set_updatesdtcontent/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UpdateSdtContent.  |
| void [set_UseAntiAliasing](./set_useantialiasing/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UseAntiAliasing.  |
| void [set_UseHighQualityRendering](./set_usehighqualityrendering/)(bool) | Setter for Aspose::Words::Saving::SaveOptions::get_UseHighQualityRendering.  |
| static System::SharedPtr< Aspose::Words::Saving::SaveOptions > [CreateSaveOptions](./createsaveoptions/)(Aspose::Words::SaveFormat) | Creates a save options object of a class suitable for the specified save format.  |
| static System::SharedPtr< Aspose::Words::Saving::SaveOptions > [CreateSaveOptions](./createsaveoptions/)(const System::String &) | Creates a save options object of a class suitable for the file extension specified in the given file name.  |
