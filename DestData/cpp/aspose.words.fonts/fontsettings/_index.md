---
title: FontSettings
second_title: Aspose.Words for C++ API Reference
description: Specifies font settings for a document. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/fontsettings/
---
## FontSettings class


Specifies font settings for a document. 

## Methods

| Method | Description |
| --- | --- |
| static System::SharedPtr< Aspose::Words::Fonts::FontSettings > [get_DefaultInstance](./get_defaultinstance/)() | Static default font settings.  |
|  [FontSettings](./fontsettings/)() |  |
| System::SharedPtr< Aspose::Words::Fonts::FontFallbackSettings > [get_FallbackSettings](./get_fallbacksettings/)() const | Settings related to font fallback mechanism.  |
| System::SharedPtr< Aspose::Words::Fonts::FontSubstitutionSettings > [get_SubstitutionSettings](./get_substitutionsettings/)() const | Settings related to font substitution mechanism.  |
| System::ArrayPtr< System::SharedPtr< Aspose::Words::Fonts::FontSourceBase > > [GetFontsSources](./getfontssources/)() | Gets a copy of the array that contains the list of sources where Aspose.Words looks for TrueType fonts.  |
| void [ResetFontSources](./resetfontsources/)() | Resets the fonts sources to the system default.  |
| void [SaveSearchCache](./savesearchcache/)(const System::SharedPtr< System::IO::Stream > &) | Saves the font search cache to the stream.  |
| void [SetFontsFolder](./setfontsfolder/)(const System::String &, bool) | Sets the folder where Aspose.Words looks for TrueType fonts when rendering documents or embedding fonts. This is a shortcut to SetFontsFolders() for setting only one font directory.  |
| void [SetFontsFolders](./setfontsfolders/)(const System::ArrayPtr< System::String > &, bool) | Sets the folders where Aspose.Words looks for TrueType fonts when rendering documents or embedding fonts.  |
| void [SetFontsSources](./setfontssources/)(const System::ArrayPtr< System::SharedPtr< Aspose::Words::Fonts::FontSourceBase > > &) | Sets the sources where Aspose.Words looks for TrueType fonts when rendering documents or embedding fonts.  |
| void [SetFontsSources](./setfontssources/)(const System::ArrayPtr< System::SharedPtr< Aspose::Words::Fonts::FontSourceBase > > &, const System::SharedPtr< System::IO::Stream > &) | Sets the sources where Aspose.Words looks for TrueType fonts and additionally loads previously saved font search cache.  |
