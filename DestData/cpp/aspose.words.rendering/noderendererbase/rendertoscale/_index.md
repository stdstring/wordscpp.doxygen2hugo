---
title: RenderToScale
second_title: Aspose.Words for C++ API Reference
description: Renders the shape into a Graphics object to a specified scale. 
type: docs
weight: 0
url: /cpp/aspose.words.rendering/noderendererbase/rendertoscale/
---
## NodeRendererBase.RenderToScale method


Renders the shape into a **Graphics** object to a specified scale.

```cpp
System::Drawing::SizeF Aspose::Words::Rendering::NodeRendererBase::RenderToScale(const System::SharedPtr<System::Drawing::Graphics> &graphics, float x, float y, float scale)
```


| Parameter | Type | Description |
| --- | --- | --- |
| graphics | `-` | The object where to render to. |
| x | `-` | The X coordinate (in world units) of the top left corner of the rendered shape. |
| y | `-` | The Y coordinate (in world units) of the top left corner of the rendered shape. |
| scale | `-` | The scale for rendering the shape (1.0 is 100%). |

### ReturnValue


The width and height (in world units) of the rendered shape.


