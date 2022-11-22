---
title: FontPitch
second_title: Aspose.Words for C++ API Reference
description: Represents the font pitch.
type: docs
weight: 274
url: /cpp/aspose.words.fonts/fontpitch/
---
## FontPitch enum


Represents the font pitch.

```cpp
enum class FontPitch
```

### Values

| Name | Value | Description |
| --- | --- | --- |
| Default | 0 | Specifies that no information is available about the pitch of a font. |
| Fixed | 1 | Specifies that this is a fixed width font. |
| Variable | 2 | Specifies that this is a proportional width font. |


## Examples




Shows how to access and print details of each font in a document. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Document.docx");

SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<FontInfo>>> fontCollectionEnumerator = doc->get_FontInfos()->GetEnumerator();
while (fontCollectionEnumerator->MoveNext())
{
    SharedPtr<FontInfo> fontInfo = fontCollectionEnumerator->get_Current();
    if (fontInfo != nullptr)
    {
        std::cout << (String(u"Font name: ") + fontInfo->get_Name()) << std::endl;

        // Alt names are usually blank.
        std::cout << (String(u"Alt name: ") + fontInfo->get_AltName()) << std::endl;
        std::cout << (String(u"\t- Family: ") + System::ObjectExt::ToString(fontInfo->get_Family())) << std::endl;
        std::cout << (String(u"\t- ") + (fontInfo->get_IsTrueType() ? String(u"Is TrueType") : String(u"Is not TrueType"))) << std::endl;
        std::cout << (String(u"\t- Pitch: ") + System::ObjectExt::ToString(fontInfo->get_Pitch())) << std::endl;
        std::cout << (String(u"\t- Charset: ") + fontInfo->get_Charset()) << std::endl;
        std::cout << "\t- Panose:" << std::endl;
        std::cout << (String(u"\t\tFamily Kind: ") + fontInfo->get_Panose()[0]) << std::endl;
        std::cout << (String(u"\t\tSerif Style: ") + fontInfo->get_Panose()[1]) << std::endl;
        std::cout << (String(u"\t\tWeight: ") + fontInfo->get_Panose()[2]) << std::endl;
        std::cout << (String(u"\t\tProportion: ") + fontInfo->get_Panose()[3]) << std::endl;
        std::cout << (String(u"\t\tContrast: ") + fontInfo->get_Panose()[4]) << std::endl;
        std::cout << (String(u"\t\tStroke Variation: ") + fontInfo->get_Panose()[5]) << std::endl;
        std::cout << (String(u"\t\tArm Style: ") + fontInfo->get_Panose()[6]) << std::endl;
        std::cout << (String(u"\t\tLetterform: ") + fontInfo->get_Panose()[7]) << std::endl;
        std::cout << (String(u"\t\tMidline: ") + fontInfo->get_Panose()[8]) << std::endl;
        std::cout << (String(u"\t\tX-Height: ") + fontInfo->get_Panose()[9]) << std::endl;
    }
}
```

