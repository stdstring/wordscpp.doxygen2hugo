---
title: SvgTextOutputMode
second_title: Aspose.Words for C++ API Reference
description: 
type: docs
weight: 0
url: /cpp/aspose.words.saving/svgtextoutputmode/
---
## SvgTextOutputMode enum





## Examples




Shows how to mimic the properties of images when converting a .docx document to .svg. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Document.docx");

// Configure the SvgSaveOptions object to save with no page borders or selectable text.
auto options = MakeObject<SvgSaveOptions>();
options->set_FitToViewPort(true);
options->set_ShowPageBorder(false);
options->set_TextOutputMode(SvgTextOutputMode::UsePlacedGlyphs);

doc->Save(ArtifactsDir + u"SvgSaveOptions.SaveLikeImage.svg", options);
```

