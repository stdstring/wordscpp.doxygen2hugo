---
title: FontSavingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for the FontSaving() event. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/fontsavingargs/
---
## FontSavingArgs class


Provides data for the FontSaving() event. 

## Methods

| Method | Description |
| --- | --- |
| [get_Bold](./get_bold/)() const | Indicates whether the current font is bold.  |
| [get_Document](./get_document/)() const | Gets the document object that is being saved.  |
| [get_FontFamilyName](./get_fontfamilyname/)() const | Indicates the current font family name.  |
| [get_FontFileName](./get_fontfilename/)() const | Gets or sets the file name (without path) where the font will be saved to.  |
| [get_FontStream](./get_fontstream/)() const | Allows to specify the stream where the font will be saved to.  |
| [get_IsExportNeeded](./get_isexportneeded/)() const | Allows to specify whether the current font will be exported as a font resource. Default is **true**.  |
| [get_IsSubsettingNeeded](./get_issubsettingneeded/)() const | Allows to specify whether the current font will be subsetted before exporting as a font resource.  |
| [get_Italic](./get_italic/)() const | Indicates whether the current font is italic.  |
| [get_KeepFontStreamOpen](./get_keepfontstreamopen/)() const | Specifies whether Aspose.Words should keep the stream open or close it after saving a font.  |
| [get_OriginalFileName](./get_originalfilename/)() const | Gets the original font file name with an extension.  |
| [get_OriginalFileSize](./get_originalfilesize/)() const | Gets the original font file size.  |
| [set_FontFileName](./set_fontfilename/)(const System::String &) | Setter for Aspose::Words::Saving::FontSavingArgs::get_FontFileName.  |
| [set_FontStream](./set_fontstream/)(const System::SharedPtr< System::IO::Stream > &) | Setter for Aspose::Words::Saving::FontSavingArgs::get_FontStream.  |
| [set_FontStream](./set_fontstream/)(std::basic_ostream< CharType, Traits > &) |  |
| [set_IsExportNeeded](./set_isexportneeded/)(bool) | Setter for Aspose::Words::Saving::FontSavingArgs::get_IsExportNeeded.  |
| [set_IsSubsettingNeeded](./set_issubsettingneeded/)(bool) | Setter for Aspose::Words::Saving::FontSavingArgs::get_IsSubsettingNeeded.  |
| [set_KeepFontStreamOpen](./set_keepfontstreamopen/)(bool) | Setter for Aspose::Words::Saving::FontSavingArgs::get_KeepFontStreamOpen.  |