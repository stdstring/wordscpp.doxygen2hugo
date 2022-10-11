---
title: FontInfo
second_title: Aspose.Words for C++ API Reference
description: Specifies information about a font used in the document. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/fontinfo/
---
## FontInfo class


Specifies information about a font used in the document. 

## Methods

| Method | Description |
| --- | --- |
| System::String [get_AltName](./get_altname/)() const | Gets or sets the alternate name for the font.  |
| int32_t [get_Charset](./get_charset/)() | Gets or sets the character set for the font.  |
| Aspose::Words::Fonts::FontFamily [get_Family](./get_family/)() const | Gets or sets the font family this font belongs to.  |
| bool [get_IsTrueType](./get_istruetype/)() const | Indicates that this font is a TrueType or OpenType font as opposed to a raster or vector font. Default is true.  |
| System::String [get_Name](./get_name/)() const | Gets the name of the font.  |
| System::ArrayPtr< uint8_t > [get_Panose](./get_panose/)() const | Gets or sets the PANOSE typeface classification number.  |
| Aspose::Words::Fonts::FontPitch [get_Pitch](./get_pitch/)() const | The pitch indicates if the font is fixed pitch, proportionally spaced, or relies on a default setting.  |
| System::ArrayPtr< uint8_t > [GetEmbeddedFont](./getembeddedfont/)(Aspose::Words::Fonts::EmbeddedFontFormat, Aspose::Words::Fonts::EmbeddedFontStyle) | Gets a specific embedded font file.  |
| System::ArrayPtr< uint8_t > [GetEmbeddedFontAsOpenType](./getembeddedfontasopentype/)(Aspose::Words::Fonts::EmbeddedFontStyle) | Gets an embedded font file in OpenType format. Fonts in Embedded OpenType format are converted to OpenType.  |
| void [set_AltName](./set_altname/)(const System::String &) | Setter for Aspose::Words::Fonts::FontInfo::get_AltName.  |
| void [set_Charset](./set_charset/)(int32_t) | Setter for Aspose::Words::Fonts::FontInfo::get_Charset.  |
| void [set_Family](./set_family/)(Aspose::Words::Fonts::FontFamily) | Setter for Aspose::Words::Fonts::FontInfo::get_Family.  |
| void [set_IsTrueType](./set_istruetype/)(bool) | Setter for Aspose::Words::Fonts::FontInfo::get_IsTrueType.  |
| void [set_Panose](./set_panose/)(const System::ArrayPtr< uint8_t > &) | Setter for Aspose::Words::Fonts::FontInfo::get_Panose.  |
| void [set_Pitch](./set_pitch/)(Aspose::Words::Fonts::FontPitch) | Setter for Aspose::Words::Fonts::FontInfo::get_Pitch.  |
