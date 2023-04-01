---
title: Aspose::Words::Document::get_HyphenationOptions method
linktitle: get_HyphenationOptions
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Document::get_HyphenationOptions method. Provides access to document hyphenation options in C++.'
type: docs
weight: 3100
url: /cpp/aspose.words/document/get_hyphenationoptions/
---
## Document::get_HyphenationOptions method


Provides access to document hyphenation options.

```cpp
System::SharedPtr<Aspose::Words::Settings::HyphenationOptions> Aspose::Words::Document::get_HyphenationOptions()
```


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

## See Also

* Class [HyphenationOptions](../../../aspose.words.settings/hyphenationoptions/)
* Class [Document](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
