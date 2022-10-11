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
| [Equals](./equals/)(System::SharedPtr< System::Object >) override | Determines whether the specified object is equal in value to the current object.  |
| [get_ColorMode](./get_colormode/)() const | Gets or sets a value determining how colors are rendered.  |
| [get_JpegQuality](./get_jpegquality/)() const | Gets or sets a value determining the quality of the JPEG images inside Html document.  |
| [get_MetafileRenderingOptions](./get_metafilerenderingoptions/)() const | Allows to specify metafile rendering options.  |
| [get_NumeralFormat](./get_numeralformat/)() const | Gets or sets NumeralFormat used for rendering of numerals. European numerals are used by default.  |
| virtual [get_OptimizeOutput](./get_optimizeoutput/)() | Flag indicates whether it is required to optimize output. If this flag is set redundant nested canvases and empty canvases are removed, also neighbor glyphs with the same formatting are concatenated. Note: The accuracy of the content display may be affected if this property is set to true. Default is false.  |
| [get_PageSavingCallback](./get_pagesavingcallback/)() const | Allows to control how separate pages are saved when a document is exported to fixed page format.  |
| [get_PageSet](./get_pageset/)() const | Gets or sets the pages to render. Default is all the pages in the document.  |
| [set_ColorMode](./set_colormode/)(Aspose::Words::Saving::ColorMode) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_ColorMode.  |
| [set_JpegQuality](./set_jpegquality/)(int32_t) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_JpegQuality.  |
| [set_MetafileRenderingOptions](./set_metafilerenderingoptions/)(const System::SharedPtr< Aspose::Words::Saving::MetafileRenderingOptions > &) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_MetafileRenderingOptions.  |
| [set_NumeralFormat](./set_numeralformat/)(Aspose::Words::Saving::NumeralFormat) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_NumeralFormat.  |
| virtual [set_OptimizeOutput](./set_optimizeoutput/)(bool) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_OptimizeOutput.  |
| [set_PageSavingCallback](./set_pagesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IPageSavingCallback > &) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_PageSavingCallback.  |
| [set_PageSet](./set_pageset/)(const System::SharedPtr< Aspose::Words::Saving::PageSet > &) | Setter for Aspose::Words::Saving::FixedPageSaveOptions::get_PageSet.  |
