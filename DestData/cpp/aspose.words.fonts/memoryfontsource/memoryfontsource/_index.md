---
title: MemoryFontSource
second_title: Aspose.Words for C++ API Reference
description: Ctor. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/memoryfontsource/memoryfontsource/
---
## MemoryFontSource.MemoryFontSource(const System::ArrayPtr\<uint8_t\>\&) method


Ctor.

```cpp
Aspose::Words::Fonts::MemoryFontSource::MemoryFontSource(const System::ArrayPtr<uint8_t> &fontData)
```


| Parameter | Type | Description |
| --- | --- | --- |
| fontData | const System::ArrayPtr\<uint8_t\>\& | Binary font data. |

## Examples




Shows how to use a byte array with data from a font file as a font source. 
```cpp
ArrayPtr<uint8_t> fontBytes = System::IO::File::ReadAllBytes(MyDir + u"Alte DIN 1451 Mittelschrift.ttf");
auto memoryFontSource = MakeObject<MemoryFontSource>(fontBytes, 0);

auto doc = MakeObject<Document>();
doc->set_FontSettings(MakeObject<FontSettings>());
doc->get_FontSettings()->SetFontsSources(MakeArray<SharedPtr<FontSourceBase>>({memoryFontSource}));

ASSERT_EQ(FontSourceType::MemoryFont, memoryFontSource->get_Type());
ASSERT_EQ(0, memoryFontSource->get_Priority());
```

## MemoryFontSource.MemoryFontSource(const System::ArrayPtr\<uint8_t\>\&, int32_t) method


Ctor.

```cpp
Aspose::Words::Fonts::MemoryFontSource::MemoryFontSource(const System::ArrayPtr<uint8_t> &fontData, int32_t priority)
```


| Parameter | Type | Description |
| --- | --- | --- |
| fontData | const System::ArrayPtr\<uint8_t\>\& | Binary font data. |
| priority | int32_t | [Font](../../../aspose.words/font/) source priority. See the [Priority](../../fontsourcebase/get_priority/) property description for more information. |

## Examples




Shows how to use a byte array with data from a font file as a font source. 
```cpp
ArrayPtr<uint8_t> fontBytes = System::IO::File::ReadAllBytes(MyDir + u"Alte DIN 1451 Mittelschrift.ttf");
auto memoryFontSource = MakeObject<MemoryFontSource>(fontBytes, 0);

auto doc = MakeObject<Document>();
doc->set_FontSettings(MakeObject<FontSettings>());
doc->get_FontSettings()->SetFontsSources(MakeArray<SharedPtr<FontSourceBase>>({memoryFontSource}));

ASSERT_EQ(FontSourceType::MemoryFont, memoryFontSource->get_Type());
ASSERT_EQ(0, memoryFontSource->get_Priority());
```

## MemoryFontSource.MemoryFontSource(const System::ArrayPtr\<uint8_t\>\&, int32_t, const System::String\&) method


Ctor.

```cpp
Aspose::Words::Fonts::MemoryFontSource::MemoryFontSource(const System::ArrayPtr<uint8_t> &fontData, int32_t priority, const System::String &cacheKey)
```


| Parameter | Type | Description |
| --- | --- | --- |
| fontData | const System::ArrayPtr\<uint8_t\>\& | Binary font data. |
| priority | int32_t | [Font](../../../aspose.words/font/) source priority. See the [Priority](../../fontsourcebase/get_priority/) property description for more information. |
| cacheKey | const System::String\& | The key of this source in the cache. See [CacheKey](../get_cachekey/) property description for more information. |


