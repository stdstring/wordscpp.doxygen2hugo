---
title: Font
second_title: Aspose.Words for C++ API Reference
description: Contains font attributes (font name, font size, color, and so on) for an object. 
type: docs
weight: 0
url: /cpp/aspose.words/font/
---
## Font class


Contains font attributes (font name, font size, color, and so on) for an object. 

## Methods

| Method | Description |
| --- | --- |
| void [ClearFormatting](./clearformatting/)() | Resets to default font formatting.  |
| bool [get_AllCaps](./get_allcaps/)() | True if the font is formatted as all capital letters.  |
| System::Drawing::Color [get_AutoColor](./get_autocolor/)() | Returns the present calculated color of the text (black or white) to be used for 'auto color'. If the color is not 'auto' then returns Color.  |
| bool [get_Bidi](./get_bidi/)() | Specifies whether the contents of this run shall have right-to-left characteristics.  |
| bool [get_Bold](./get_bold/)() | True if the font is formatted as bold.  |
| bool [get_BoldBi](./get_boldbi/)() | True if the right-to-left text is formatted as bold.  |
| System::SharedPtr< Aspose::Words::Border > [get_Border](./get_border/)() | Returns a Border object that specifies border for the font.  |
| System::Drawing::Color [get_Color](./get_color/)() | Gets or sets the color of the font.  |
| bool [get_ComplexScript](./get_complexscript/)() | Specifies whether the contents of this run shall be treated as complex script text regardless of their Unicode character values when determining the formatting for this run.  |
| bool [get_DoubleStrikeThrough](./get_doublestrikethrough/)() | True if the font is formatted as double strikethrough text.  |
| bool [get_Emboss](./get_emboss/)() | True if the font is formatted as embossed.  |
| Aspose::Words::EmphasisMark [get_EmphasisMark](./get_emphasismark/)() | Gets or sets the emphasis mark applied to this formatting.  |
| bool [get_Engrave](./get_engrave/)() | True if the font is formatted as engraved.  |
| System::SharedPtr< Aspose::Words::Drawing::Fill > [get_Fill](./get_fill/)() | Gets fill formatting for the Font.  |
| bool [get_Hidden](./get_hidden/)() | True if the font is formatted as hidden text.  |
| System::Drawing::Color [get_HighlightColor](./get_highlightcolor/)() | Gets or sets the highlight (marker) color.  |
| bool [get_Italic](./get_italic/)() | True if the font is formatted as italic.  |
| bool [get_ItalicBi](./get_italicbi/)() | True if the right-to-left text is formatted as italic.  |
| double [get_Kerning](./get_kerning/)() | Gets or sets the font size at which kerning starts.  |
| double [get_LineSpacing](./get_linespacing/)() | Returns line spacing of this font (in points).  |
| int32_t [get_LocaleId](./get_localeid/)() | Gets or sets the locale identifier (language) of the formatted characters.  |
| int32_t [get_LocaleIdBi](./get_localeidbi/)() | Gets or sets the locale identifier (language) of the formatted right-to-left characters.  |
| int32_t [get_LocaleIdFarEast](./get_localeidfareast/)() | Gets or sets the locale identifier (language) of the formatted Asian characters.  |
| System::String [get_Name](./get_name/)() | Gets or sets the name of the font.  |
| System::String [get_NameAscii](./get_nameascii/)() | Returns or sets the font used for Latin text (characters with character codes from 0 (zero) through 127).  |
| System::String [get_NameBi](./get_namebi/)() | Returns or sets the name of the font in a right-to-left language document.  |
| System::String [get_NameFarEast](./get_namefareast/)() | Returns or sets an East Asian font name.  |
| System::String [get_NameOther](./get_nameother/)() | Returns or sets the font used for characters with character codes from 128 through 255.  |
| bool [get_NoProofing](./get_noproofing/)() | True when the formatted characters are not to be spell checked.  |
| bool [get_Outline](./get_outline/)() | True if the font is formatted as outline.  |
| double [get_Position](./get_position/)() | Gets or sets the position of text (in points) relative to the base line. A positive number raises the text, and a negative number lowers it.  |
| int32_t [get_Scaling](./get_scaling/)() | Gets or sets character width scaling in percent.  |
| System::SharedPtr< Aspose::Words::Shading > [get_Shading](./get_shading/)() | Returns a Shading object that refers to the shading formatting for the font.  |
| bool [get_Shadow](./get_shadow/)() | True if the font is formatted as shadowed.  |
| double [get_Size](./get_size/)() | Gets or sets the font size in points.  |
| double [get_SizeBi](./get_sizebi/)() | Gets or sets the font size in points used in a right-to-left document.  |
| bool [get_SmallCaps](./get_smallcaps/)() | True if the font is formatted as small capital letters.  |
| bool [get_SnapToGrid](./get_snaptogrid/)() | Specifies whether the current font should use the document grid characters per line settings when laying out.  |
| double [get_Spacing](./get_spacing/)() | Returns or sets the spacing (in points) between characters .  |
| bool [get_StrikeThrough](./get_strikethrough/)() | True if the font is formatted as strikethrough text.  |
| System::SharedPtr< Aspose::Words::Style > [get_Style](./get_style/)() | Gets or sets the character style applied to this formatting.  |
| Aspose::Words::StyleIdentifier [get_StyleIdentifier](./get_styleidentifier/)() | Gets or sets the locale independent style identifier of the character style applied to this formatting.  |
| System::String [get_StyleName](./get_stylename/)() | Gets or sets the name of the character style applied to this formatting.  |
| bool [get_Subscript](./get_subscript/)() | True if the font is formatted as subscript.  |
| bool [get_Superscript](./get_superscript/)() | True if the font is formatted as superscript.  |
| Aspose::Words::TextEffect [get_TextEffect](./get_texteffect/)() | Gets or sets the font animation effect.  |
| Aspose::Words::Themes::ThemeColor [get_ThemeColor](./get_themecolor/)() | Gets or sets the theme color in the applied color scheme that is associated with this Font object.  |
| Aspose::Words::Themes::ThemeFont [get_ThemeFont](./get_themefont/)() | Gets or sets the theme font in the applied font scheme that is associated with this Font object.  |
| Aspose::Words::Themes::ThemeFont [get_ThemeFontAscii](./get_themefontascii/)() | Gets or sets the theme font used for Latin text (characters with character codes from 0 (zero) through 127) in the applied font scheme that is associated with this Font object.  |
| Aspose::Words::Themes::ThemeFont [get_ThemeFontBi](./get_themefontbi/)() | Gets or sets the theme font in the applied font scheme that is associated with this Font object in a right-to-left language document.  |
| Aspose::Words::Themes::ThemeFont [get_ThemeFontFarEast](./get_themefontfareast/)() | Gets or sets the East Asian theme font in the applied font scheme that is associated with this Font object.  |
| Aspose::Words::Themes::ThemeFont [get_ThemeFontOther](./get_themefontother/)() | Gets or sets the theme font used for characters with character codes from 128 through 255 in the applied font scheme that is associated with this Font object.  |
| double [get_TintAndShade](./get_tintandshade/)() | Gets or sets a double value that lightens or darkens a color.  |
| Aspose::Words::Underline [get_Underline](./get_underline/)() | Gets or sets the type of underline applied to the font.  |
| System::Drawing::Color [get_UnderlineColor](./get_underlinecolor/)() | Gets or sets the color of the underline applied to the font.  |
| bool [HasDmlEffect](./hasdmleffect/)(Aspose::Words::TextDmlEffect) | Checks if particular DrawingML text effect is applied.  |
| void [set_AllCaps](./set_allcaps/)(bool) | Setter for Aspose::Words::Font::get_AllCaps.  |
| void [set_Bidi](./set_bidi/)(bool) | Setter for Aspose::Words::Font::get_Bidi.  |
| void [set_Bold](./set_bold/)(bool) | Setter for Aspose::Words::Font::get_Bold.  |
| void [set_BoldBi](./set_boldbi/)(bool) | Setter for Aspose::Words::Font::get_BoldBi.  |
| void [set_Color](./set_color/)(System::Drawing::Color) | Setter for Aspose::Words::Font::get_Color.  |
| void [set_ComplexScript](./set_complexscript/)(bool) | Setter for Aspose::Words::Font::get_ComplexScript.  |
| void [set_DoubleStrikeThrough](./set_doublestrikethrough/)(bool) | Setter for Aspose::Words::Font::get_DoubleStrikeThrough.  |
| void [set_Emboss](./set_emboss/)(bool) | Setter for Aspose::Words::Font::get_Emboss.  |
| void [set_EmphasisMark](./set_emphasismark/)(Aspose::Words::EmphasisMark) | Setter for Aspose::Words::Font::get_EmphasisMark.  |
| void [set_Engrave](./set_engrave/)(bool) | Setter for Aspose::Words::Font::get_Engrave.  |
| void [set_Hidden](./set_hidden/)(bool) | Setter for Aspose::Words::Font::get_Hidden.  |
| void [set_HighlightColor](./set_highlightcolor/)(System::Drawing::Color) | Setter for Aspose::Words::Font::get_HighlightColor.  |
| void [set_Italic](./set_italic/)(bool) | Setter for Aspose::Words::Font::get_Italic.  |
| void [set_ItalicBi](./set_italicbi/)(bool) | Setter for Aspose::Words::Font::get_ItalicBi.  |
| void [set_Kerning](./set_kerning/)(double) | Setter for Aspose::Words::Font::get_Kerning.  |
| void [set_LocaleId](./set_localeid/)(int32_t) | Setter for Aspose::Words::Font::get_LocaleId.  |
| void [set_LocaleIdBi](./set_localeidbi/)(int32_t) | Setter for Aspose::Words::Font::get_LocaleIdBi.  |
| void [set_LocaleIdFarEast](./set_localeidfareast/)(int32_t) | Setter for Aspose::Words::Font::get_LocaleIdFarEast.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Font::get_Name.  |
| void [set_NameAscii](./set_nameascii/)(const System::String &) | Setter for Aspose::Words::Font::get_NameAscii.  |
| void [set_NameBi](./set_namebi/)(const System::String &) | Setter for Aspose::Words::Font::get_NameBi.  |
| void [set_NameFarEast](./set_namefareast/)(const System::String &) | Setter for Aspose::Words::Font::get_NameFarEast.  |
| void [set_NameOther](./set_nameother/)(const System::String &) | Setter for Aspose::Words::Font::get_NameOther.  |
| void [set_NoProofing](./set_noproofing/)(bool) | Setter for Aspose::Words::Font::get_NoProofing.  |
| void [set_Outline](./set_outline/)(bool) | Setter for Aspose::Words::Font::get_Outline.  |
| void [set_Position](./set_position/)(double) | Setter for Aspose::Words::Font::get_Position.  |
| void [set_Scaling](./set_scaling/)(int32_t) | Setter for Aspose::Words::Font::get_Scaling.  |
| void [set_Shadow](./set_shadow/)(bool) | Setter for Aspose::Words::Font::get_Shadow.  |
| void [set_Size](./set_size/)(double) | Setter for Aspose::Words::Font::get_Size.  |
| void [set_SizeBi](./set_sizebi/)(double) | Setter for Aspose::Words::Font::get_SizeBi.  |
| void [set_SmallCaps](./set_smallcaps/)(bool) | Setter for Aspose::Words::Font::get_SmallCaps.  |
| void [set_SnapToGrid](./set_snaptogrid/)(bool) | Specifies whether the current font should use the document grid characters per line settings when laying out.  |
| void [set_Spacing](./set_spacing/)(double) | Setter for Aspose::Words::Font::get_Spacing.  |
| void [set_StrikeThrough](./set_strikethrough/)(bool) | Setter for Aspose::Words::Font::get_StrikeThrough.  |
| void [set_Style](./set_style/)(const System::SharedPtr< Aspose::Words::Style > &) | Setter for Aspose::Words::Font::get_Style.  |
| void [set_StyleIdentifier](./set_styleidentifier/)(Aspose::Words::StyleIdentifier) | Setter for Aspose::Words::Font::get_StyleIdentifier.  |
| void [set_StyleName](./set_stylename/)(const System::String &) | Setter for Aspose::Words::Font::get_StyleName.  |
| void [set_Subscript](./set_subscript/)(bool) | Setter for Aspose::Words::Font::get_Subscript.  |
| void [set_Superscript](./set_superscript/)(bool) | Setter for Aspose::Words::Font::get_Superscript.  |
| void [set_TextEffect](./set_texteffect/)(Aspose::Words::TextEffect) | Setter for Aspose::Words::Font::get_TextEffect.  |
| void [set_ThemeColor](./set_themecolor/)(Aspose::Words::Themes::ThemeColor) | Setter for Aspose::Words::Font::get_ThemeColor.  |
| void [set_ThemeFont](./set_themefont/)(Aspose::Words::Themes::ThemeFont) | Setter for Aspose::Words::Font::get_ThemeFont.  |
| void [set_ThemeFontAscii](./set_themefontascii/)(Aspose::Words::Themes::ThemeFont) | Setter for Aspose::Words::Font::get_ThemeFontAscii.  |
| void [set_ThemeFontBi](./set_themefontbi/)(Aspose::Words::Themes::ThemeFont) | Setter for Aspose::Words::Font::get_ThemeFontBi.  |
| void [set_ThemeFontFarEast](./set_themefontfareast/)(Aspose::Words::Themes::ThemeFont) | Setter for Aspose::Words::Font::get_ThemeFontFarEast.  |
| void [set_ThemeFontOther](./set_themefontother/)(Aspose::Words::Themes::ThemeFont) | Setter for Aspose::Words::Font::get_ThemeFontOther.  |
| void [set_TintAndShade](./set_tintandshade/)(double) | Setter for Aspose::Words::Font::get_TintAndShade.  |
| void [set_Underline](./set_underline/)(Aspose::Words::Underline) | Setter for Aspose::Words::Font::get_Underline.  |
| void [set_UnderlineColor](./set_underlinecolor/)(System::Drawing::Color) | Setter for Aspose::Words::Font::get_UnderlineColor.  |
