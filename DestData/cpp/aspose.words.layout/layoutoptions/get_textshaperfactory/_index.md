---
title: get_TextShaperFactory
second_title: Aspose.Words for C++ API Reference
description: Gets or sets ITextShaperFactory implementation used for Advanced Typography rendering features. 
type: docs
weight: 105
url: /cpp/aspose.words.layout/layoutoptions/get_textshaperfactory/
---
## LayoutOptions.get_TextShaperFactory method


Gets or sets **ITextShaperFactory** implementation used for Advanced Typography rendering features.

```cpp
System::SharedPtr<Aspose::Words::Shaping::ITextShaperFactory> Aspose::Words::Layout::LayoutOptions::get_TextShaperFactory() const
```


## Examples




Shows how to support OpenType features using the HarfBuzz text shaping engine. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"OpenType text shaping.docx");

// Aspose.Words can use externally provided text shaper objects,
// which represent fonts and compute shaping information for text.
// A text shaper factory is necessary for documents that use multiple fonts.
// When the text shaper factory set, the layout uses OpenType features.
// An Instance property returns a static BasicTextShaperCache object wrapping HarfBuzzTextShaperFactory.
doc->get_LayoutOptions()->set_TextShaperFactory(Shaping::HarfBuzz::HarfBuzzTextShaperFactory::get_Instance());

// Currently, text shaping is performing when exporting to PDF or XPS formats.
doc->Save(ArtifactsDir + u"Document.OpenType.pdf");
```

