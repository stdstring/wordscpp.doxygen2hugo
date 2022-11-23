---
title: FileFontSource
second_title: Aspose.Words for C++ API Reference
description: Represents the single TrueType font file stored in the file system.
type: docs
weight: 14
url: /cpp/aspose.words.fonts/filefontsource/
---
## FileFontSource class


Represents the single TrueType font file stored in the file system.

```cpp
class FileFontSource : public Aspose::Words::Fonts::FontSourceBase
```

## Methods

| Method | Description |
| --- | --- |
| [FileFontSource](./filefontsource/)(const System::String\&) | Ctor. |
| [FileFontSource](./filefontsource/)(const System::String\&, int32_t) | Ctor. |
| [FileFontSource](./filefontsource/)(const System::String\&, int32_t, const System::String\&) | Ctor. |
| [get_CacheKey](./get_cachekey/)() const | The key of this source in the cache. |
| [get_FilePath](./get_filepath/)() const | Path to the font file. |
| [get_Priority](../fontsourcebase/get_priority/)() const | Returns the font source priority. |
| [get_Type](./get_type/)() override | Returns the type of the font source. |
| [get_WarningCallback](../fontsourcebase/get_warningcallback/)() const | Called during processing of font source when an issue is detected that might result in formatting fidelity loss. |
| [GetAvailableFonts](../fontsourcebase/getavailablefonts/)() | Returns list of fonts available via this source. |
| [set_WarningCallback](../fontsourcebase/set_warningcallback/)(const System::SharedPtr\<Aspose::Words::IWarningCallback\>\&) | Setter for [Aspose::Words::Fonts::FontSourceBase::get_WarningCallback](../fontsourcebase/get_warningcallback/). |

## Examples



Shows how to use a font file in the local file system as a font source. 
```cpp
auto fileFontSource = MakeObject<FileFontSource>(MyDir + u"Alte DIN 1451 Mittelschrift.ttf", 0);

auto doc = MakeObject<Document>();
doc->set_FontSettings(MakeObject<FontSettings>());
doc->get_FontSettings()->SetFontsSources(MakeArray<SharedPtr<FontSourceBase>>({fileFontSource}));

ASSERT_EQ(MyDir + u"Alte DIN 1451 Mittelschrift.ttf", fileFontSource->get_FilePath());
ASSERT_EQ(FontSourceType::FontFile, fileFontSource->get_Type());
ASSERT_EQ(0, fileFontSource->get_Priority());
```

