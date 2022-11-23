---
title: FontInfo
second_title: Aspose.Words for C++ API Reference
description: Specifies information about a font used in the document.
type: docs
weight: 66
url: /cpp/aspose.words.fonts/fontinfo/
---
## FontInfo class


Specifies information about a font used in the document.

```cpp
class FontInfo : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| [get_AltName](./get_altname/)() const | Gets or sets the alternate name for the font. |
| [get_Charset](./get_charset/)() | Gets or sets the character set for the font. |
| [get_Family](./get_family/)() const | Gets or sets the font family this font belongs to. |
| [get_IsTrueType](./get_istruetype/)() const | Indicates that this font is a TrueType or OpenType font as opposed to a raster or vector font. Default is true. |
| [get_Name](./get_name/)() const | Gets the name of the font. |
| [get_Panose](./get_panose/)() const | Gets or sets the PANOSE typeface classification number. |
| [get_Pitch](./get_pitch/)() const | The pitch indicates if the font is fixed pitch, proportionally spaced, or relies on a default setting. |
| [GetEmbeddedFont](./getembeddedfont/)(Aspose::Words::Fonts::EmbeddedFontFormat, Aspose::Words::Fonts::EmbeddedFontStyle) | Gets a specific embedded font file. |
| [GetEmbeddedFontAsOpenType](./getembeddedfontasopentype/)(Aspose::Words::Fonts::EmbeddedFontStyle) | Gets an embedded font file in OpenType format. [Fonts](../) in Embedded OpenType format are converted to OpenType. |
| [set_AltName](./set_altname/)(const System::String\&) | Setter for [Aspose::Words::Fonts::FontInfo::get_AltName](./get_altname/). |
| [set_Charset](./set_charset/)(int32_t) | Setter for [Aspose::Words::Fonts::FontInfo::get_Charset](./get_charset/). |
| [set_Family](./set_family/)(Aspose::Words::Fonts::FontFamily) | Setter for [Aspose::Words::Fonts::FontInfo::get_Family](./get_family/). |
| [set_IsTrueType](./set_istruetype/)(bool) | Setter for [Aspose::Words::Fonts::FontInfo::get_IsTrueType](./get_istruetype/). |
| [set_Panose](./set_panose/)(const System::ArrayPtr\<uint8_t\>\&) | Setter for [Aspose::Words::Fonts::FontInfo::get_Panose](./get_panose/). |
| [set_Pitch](./set_pitch/)(Aspose::Words::Fonts::FontPitch) | Setter for [Aspose::Words::Fonts::FontInfo::get_Pitch](./get_pitch/). |

You do not create instances of this class directly. Use the [FontInfos](../../aspose.words/documentbase/get_fontinfos/) property to access the collection of fonts defined in a document.

## Examples



Shows how to print the details of what fonts are present in a document. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Embedded font.docx");

SharedPtr<Aspose::Words::Fonts::FontInfoCollection> allFonts = doc->get_FontInfos();

// Print all the used and unused fonts in the document.
for (int i = 0; i < allFonts->get_Count(); i++)
{
    std::cout << "Font index #" << i << std::endl;
    std::cout << "\tName: " << allFonts->idx_get(i)->get_Name() << std::endl;
    std::cout << "\tIs " << (allFonts->idx_get(i)->get_IsTrueType() ? String(u"") : String(u"not ")) << "a trueType font" << std::endl;
}
```

