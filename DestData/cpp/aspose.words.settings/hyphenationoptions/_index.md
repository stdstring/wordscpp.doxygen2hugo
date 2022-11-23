---
title: HyphenationOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to configure document hyphenation options.
type: docs
weight: 14
url: /cpp/aspose.words.settings/hyphenationoptions/
---
## HyphenationOptions class


Allows to configure document hyphenation options.

```cpp
class HyphenationOptions : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| [get_AutoHyphenation](./get_autohyphenation/)() const | Gets or sets value determining whether automatic hyphenation is turned on for the document. Default value for this property is **false**. |
| [get_ConsecutiveHyphenLimit](./get_consecutivehyphenlimit/)() const | Gets or sets the maximum number of consecutive lines that can end with hyphens. Default value for this property is 0. |
| [get_HyphenateCaps](./get_hyphenatecaps/)() const | Gets or sets value determining whether words written in all capital letters are hyphenated. Default value for this property is **true**. |
| [get_HyphenationZone](./get_hyphenationzone/)() const | Gets or sets the distance in 1/20 of a point from the right margin within which you do not want to hyphenate words. Default value for this property is 360 (0.25 inch). |
| [HyphenationOptions](./hyphenationoptions/)() |  |
| [set_AutoHyphenation](./set_autohyphenation/)(bool) | Setter for [Aspose::Words::Settings::HyphenationOptions::get_AutoHyphenation](./get_autohyphenation/). |
| [set_ConsecutiveHyphenLimit](./set_consecutivehyphenlimit/)(int32_t) | Setter for [Aspose::Words::Settings::HyphenationOptions::get_ConsecutiveHyphenLimit](./get_consecutivehyphenlimit/). |
| [set_HyphenateCaps](./set_hyphenatecaps/)(bool) | Setter for [Aspose::Words::Settings::HyphenationOptions::get_HyphenateCaps](./get_hyphenatecaps/). |
| [set_HyphenationZone](./set_hyphenationzone/)(int32_t) | Setter for [Aspose::Words::Settings::HyphenationOptions::get_HyphenationZone](./get_hyphenationzone/). |

## Examples



Shows how to configure automatic hyphenation. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_Font()->set_Size(24);
builder->Writeln(String(u"Lorem ipsum dolor sit amet, consectetur adipiscing elit, ") +
                 u"sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.");

doc->get_HyphenationOptions()->set_AutoHyphenation(true);
doc->get_HyphenationOptions()->set_ConsecutiveHyphenLimit(2);
doc->get_HyphenationOptions()->set_HyphenationZone(720);
doc->get_HyphenationOptions()->set_HyphenateCaps(true);

doc->Save(ArtifactsDir + u"Document.HyphenationOptions.docx");
```

