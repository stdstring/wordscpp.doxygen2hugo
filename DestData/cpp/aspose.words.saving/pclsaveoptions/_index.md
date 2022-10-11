---
title: PclSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Pcl format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/pclsaveoptions/
---
## PclSaveOptions class


Can be used to specify additional options when saving a document into the Pcl format. 

## Methods

| Method | Description |
| --- | --- |
| [PclSaveOptions](./pclsaveoptions/)() |  |
| [AddPrinterFont](./addprinterfont/)(const System::String &, const System::String &) | Adds information about font that is uploaded to the printer by manufacturer.  |
| [get_FallbackFontName](./get_fallbackfontname/)() const | Name of the font that will be used if no expected font is found in printer and built-in fonts collections.  |
| [get_RasterizeTransformedElements](./get_rasterizetransformedelements/)() const | Gets or sets a value determining whether or not complex transformed elements should be rasterized before saving to PCL document. Default is **true**.  |
| [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be Pcl.  |
| [set_FallbackFontName](./set_fallbackfontname/)(const System::String &) | Setter for Aspose::Words::Saving::PclSaveOptions::get_FallbackFontName.  |
| [set_RasterizeTransformedElements](./set_rasterizetransformedelements/)(bool) | Setter for Aspose::Words::Saving::PclSaveOptions::get_RasterizeTransformedElements.  |
| [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::PclSaveOptions::get_SaveFormat.  |
