---
title: NodeRendererBase
second_title: Aspose.Words for C++ API Reference
description: Base class for ShapeRenderer and OfficeMathRenderer. 
type: docs
weight: 0
url: /cpp/aspose.words.rendering/noderendererbase/
---
## NodeRendererBase class


Base class for ShapeRenderer and OfficeMathRenderer. 

## Methods

| Method | Description |
| --- | --- |
|  [NodeRendererBase](./noderendererbase/)() |  |
| System::Drawing::RectangleF [get_BoundsInPoints](./get_boundsinpoints/)() const | Gets the actual bounds of the shape in points.  |
| System::Drawing::RectangleF [get_OpaqueBoundsInPoints](./get_opaqueboundsinpoints/)() | Gets the opaque bounds of the shape in points.  |
| System::Drawing::SizeF [get_SizeInPoints](./get_sizeinpoints/)() | Gets the actual size of the shape in points.  |
| System::Drawing::Rectangle [GetBoundsInPixels](./getboundsinpixels/)(float, float) | Calculates the bounds of the shape in pixels for a specified zoom factor and resolution.  |
| System::Drawing::Rectangle [GetBoundsInPixels](./getboundsinpixels/)(float, float, float) | Calculates the bounds of the shape in pixels for a specified zoom factor and resolution.  |
| System::Drawing::Rectangle [GetOpaqueBoundsInPixels](./getopaqueboundsinpixels/)(float, float) | Calculates the opaque bounds of the shape in pixels for a specified zoom factor and resolution.  |
| System::Drawing::Rectangle [GetOpaqueBoundsInPixels](./getopaqueboundsinpixels/)(float, float, float) | Calculates the opaque bounds of the shape in pixels for a specified zoom factor and resolution.  |
| System::Drawing::Size [GetSizeInPixels](./getsizeinpixels/)(float, float) | Calculates the size of the shape in pixels for a specified zoom factor and resolution.  |
| System::Drawing::Size [GetSizeInPixels](./getsizeinpixels/)(float, float, float) | Calculates the size of the shape in pixels for a specified zoom factor and resolution.  |
| System::Drawing::SizeF [RenderToScale](./rendertoscale/)(const System::SharedPtr< System::Drawing::Graphics > &, float, float, float) | Renders the shape into a Graphics object to a specified scale.  |
| float [RenderToSize](./rendertosize/)(const System::SharedPtr< System::Drawing::Graphics > &, float, float, float, float) | Renders the shape into a Graphics object to a specified size.  |
| void [Save](./save/)(const System::SharedPtr< System::IO::Stream > &, System::SharedPtr< Aspose::Words::Saving::ImageSaveOptions >) | Renders the shape into an image and saves into a stream.  |
| void [Save](./save/)(const System::String &, System::SharedPtr< Aspose::Words::Saving::ImageSaveOptions >) | Renders the shape into an image and saves into a file.  |
| void [Save](./save/)(std::basic_ostream< CharType, Traits > &, System::SharedPtr< Aspose::Words::Saving::ImageSaveOptions >) |  |
