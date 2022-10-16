---
title: TextureAlignment
second_title: Aspose.Words for C++ API Reference
description: Specifies the alignment for the tiling of the texture fill. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/texturealignment/
---
## TextureAlignment enum


Specifies the alignment for the tiling of the texture fill.

### Values

| Name | Value | Description |
| --- | --- | --- |
| TopLeft | `0` | Top left texture alignment. |
| Top | `0` | Top texture alignment. |
| TopRight | `0` | Top right texture alignment. |
| Left | `0` | Left texture alignment. |
| Center | `0` | Center texture alignment. |
| Right | `0` | Right texture alignment. |
| BottomLeft | `0` | Bottom left texture alignment. |
| Bottom | `0` | Bottom texture alignment. |
| BottomRight | `0` | Bottom right texture alignment. |
| None | `0` | None texture alignment. |


## Examples




Shows how to fill and tiling the texture inside the shape. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> shape = builder->InsertShape(ShapeType::Rectangle, 80, 80);

// Apply texture alignment to the shape fill.
shape->get_Fill()->PresetTextured(PresetTexture::Canvas);
shape->get_Fill()->set_TextureAlignment(TextureAlignment::TopRight);

// Use the compliance option to define the shape using DML if you want to get "TextureAlignment"
// property after the document saves.
auto saveOptions = MakeObject<OoxmlSaveOptions>();
saveOptions->set_Compliance(OoxmlCompliance::Iso29500_2008_Strict);

doc->Save(ArtifactsDir + u"Shape.TextureFill.docx", saveOptions);
```

