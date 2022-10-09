---
title: CssSavingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for the CssSaving() event. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/csssavingargs/
---

Provides data for the CssSaving() event. 

## Methods

| Method | Description |
| --- | --- |
| [get_CssStream](./get_cssstream/)() const | Allows to specify the stream where the CSS information will be saved to.  |
| [get_Document](./get_document/)() const | Gets the document object that is currently being saved.  |
| [get_IsExportNeeded](./get_isexportneeded/)() const | Allows to specify whether the CSS will be exported to file and embedded to HTML document. Default is **true**. When this property is **false**, the CSS information will not be saved to a CSS file and will not be embedded to HTML document.  |
| [get_KeepCssStreamOpen](./get_keepcssstreamopen/)() const | Specifies whether Aspose.Words should keep the stream open or close it after saving an CSS information.  |
| [set_CssStream](./set_cssstream/)(const System::SharedPtr< System::IO::Stream > &) | Setter for Aspose::Words::Saving::CssSavingArgs::get_CssStream.  |
| [set_CssStream](./set_cssstream/)(std::basic_ostream< CharType, Traits > &) |  |
| [set_IsExportNeeded](./set_isexportneeded/)(bool) | Setter for Aspose::Words::Saving::CssSavingArgs::get_IsExportNeeded.  |
| [set_KeepCssStreamOpen](./set_keepcssstreamopen/)(bool) | Setter for Aspose::Words::Saving::CssSavingArgs::get_KeepCssStreamOpen.  |
