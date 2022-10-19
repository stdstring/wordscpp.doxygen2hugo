---
title: GetEmbeddedFontAsOpenType
second_title: Aspose.Words for C++ API Reference
description: Gets an embedded font file in OpenType format. Fonts in Embedded OpenType format are converted to OpenType. 
type: docs
weight: 105
url: /cpp/aspose.words.fonts/fontinfo/getembeddedfontasopentype/
---
## FontInfo.GetEmbeddedFontAsOpenType method


Gets an embedded font file in OpenType format. [Fonts](../../) in Embedded OpenType format are converted to OpenType.

```cpp
System::ArrayPtr<uint8_t> Aspose::Words::Fonts::FontInfo::GetEmbeddedFontAsOpenType(Aspose::Words::Fonts::EmbeddedFontStyle style)
```


| Parameter | Type | Description |
| --- | --- | --- |
| style | Aspose::Words::Fonts::EmbeddedFontStyle | Specifies the font style to retrieve. |

### ReturnValue


Returns **null** if the specified font is not embedded.

## Examples




Shows how to extract an embedded font from a document, and save it to the local file system. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Embedded font.docx");

SharedPtr<FontInfo> embeddedFont = doc->get_FontInfos()->idx_get(u"Alte DIN 1451 Mittelschrift");
ArrayPtr<uint8_t> embeddedFontBytes = embeddedFont->GetEmbeddedFont(EmbeddedFontFormat::OpenType, EmbeddedFontStyle::Regular);

System::IO::File::WriteAllBytes(ArtifactsDir + u"Alte DIN 1451 Mittelschrift.ttf", embeddedFontBytes);

// Embedded font formats may be different in other formats such as .doc.
// We need to know the correct format before we can extract the font.
doc = MakeObject<Document>(MyDir + u"Embedded font.doc");

ASSERT_TRUE(doc->get_FontInfos()->idx_get(u"Alte DIN 1451 Mittelschrift")->GetEmbeddedFont(EmbeddedFontFormat::OpenType, EmbeddedFontStyle::Regular) ==
            nullptr);
ASSERT_FALSE(
    doc->get_FontInfos()->idx_get(u"Alte DIN 1451 Mittelschrift")->GetEmbeddedFont(EmbeddedFontFormat::EmbeddedOpenType, EmbeddedFontStyle::Regular) ==
    nullptr);

// Also, we can convert embedded OpenType format, which comes from .doc documents, to OpenType.
embeddedFontBytes = doc->get_FontInfos()->idx_get(u"Alte DIN 1451 Mittelschrift")->GetEmbeddedFontAsOpenType(EmbeddedFontStyle::Regular);

System::IO::File::WriteAllBytes(ArtifactsDir + u"Alte DIN 1451 Mittelschrift.otf", embeddedFontBytes);
```

