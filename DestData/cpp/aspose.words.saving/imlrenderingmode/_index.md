---
title: ImlRenderingMode
second_title: Aspose.Words for C++ API Reference
description: Specifies how ink (InkML) objects are rendered to fixed page formats. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/imlrenderingmode/
---
## ImlRenderingMode enum


Specifies how ink (InkML) objects are rendered to fixed page formats.


## Examples




Shows how to render Ink object. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Ink object.docx");

// Set 'ImlRenderingMode.InkML' ignores fall-back shape of ink (InkML) object and renders InkML itself.
// If the rendering result is unsatisfactory,
// please use 'ImlRenderingMode.Fallback' to get a result similar to previous versions.
auto saveOptions = MakeObject<ImageSaveOptions>(SaveFormat::Jpeg);
saveOptions->set_ImlRenderingMode(ImlRenderingMode::InkML);

doc->Save(ArtifactsDir + u"ImageSaveOptions.RenderInkObject.jpeg", saveOptions);
```

