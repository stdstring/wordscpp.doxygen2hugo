---
title: Fill
second_title: Aspose.Words for C++ API Reference
description: Represents fill formatting for an object. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/fill/
---
## Fill class


Represents fill formatting for an object. 

## Methods

| Method | Description |
| --- | --- |
| System::Drawing::Color [get_BackColor](./get_backcolor/)() | Gets a Color object that represents the background color for the fill.  |
| System::Drawing::Color [get_Color](./get_color/)() |  |
| Aspose::Words::Drawing::FillType [get_FillType](./get_filltype/)() | Gets a fill type.  |
| System::Drawing::Color [get_ForeColor](./get_forecolor/)() | Gets or sets a Color object that represents the foreground color for the fill.  |
| double [get_GradientAngle](./get_gradientangle/)() | Gets or sets the angle of the gradient fill.  |
| System::SharedPtr< Aspose::Words::Drawing::GradientStopCollection > [get_GradientStops](./get_gradientstops/)() | Gets a collection of GradientStop objects for the fill.  |
| Aspose::Words::Drawing::GradientStyle [get_GradientStyle](./get_gradientstyle/)() | Gets the gradient style GradientStyle for the fill.  |
| Aspose::Words::Drawing::GradientVariant [get_GradientVariant](./get_gradientvariant/)() | Gets the gradient variant GradientVariant for the fill.  |
| System::ArrayPtr< uint8_t > [get_ImageBytes](./get_imagebytes/)() | Gets the raw bytes of the fill texture or pattern.  |
| bool [get_On](./get_on/)() |  |
| double [get_Opacity](./get_opacity/)() | Gets or sets the degree of opacity of the specified fill as a value between 0.0 (clear) and 1.0 (opaque).  |
| Aspose::Words::Drawing::PatternType [get_Pattern](./get_pattern/)() | Gets a PatternType for the fill.  |
| Aspose::Words::Drawing::PresetTexture [get_PresetTexture](./get_presettexture/)() | Gets a PresetTexture for the fill.  |
| bool [get_RotateWithObject](./get_rotatewithobject/)() | Gets whether the fill rotates with the specified object.  |
| Aspose::Words::Drawing::TextureAlignment [get_TextureAlignment](./get_texturealignment/)() | Gets or sets the alignment for tile texture fill.  |
| double [get_Transparency](./get_transparency/)() | Gets the degree of transparency of the specified fill as a value between 0.0 (opaque) and 1.0 (clear).  |
| bool [get_Visible](./get_visible/)() | Gets or sets value that is **true** if the formatting applied to this instance, is visible.  |
| void [OneColorGradient](./onecolorgradient/)(Aspose::Words::Drawing::GradientStyle, Aspose::Words::Drawing::GradientVariant, double) | Sets the specified fill to a one-color gradient.  |
| void [OneColorGradient](./onecolorgradient/)(System::Drawing::Color, Aspose::Words::Drawing::GradientStyle, Aspose::Words::Drawing::GradientVariant, double) | Sets the specified fill to a one-color gradient using the specified color.  |
| void [Patterned](./patterned/)(Aspose::Words::Drawing::PatternType) | Sets the specified fill to a pattern.  |
| void [Patterned](./patterned/)(Aspose::Words::Drawing::PatternType, System::Drawing::Color, System::Drawing::Color) | Sets the specified fill to a pattern.  |
| void [PresetTextured](./presettextured/)(Aspose::Words::Drawing::PresetTexture) | Sets the fill to a preset texture.  |
| void [set_BackColor](./set_backcolor/)(System::Drawing::Color) | Sets a Color object that represents the background color for the fill.  |
| void [set_Color](./set_color/)(System::Drawing::Color) |  |
| void [set_ForeColor](./set_forecolor/)(System::Drawing::Color) | Setter for Aspose::Words::Drawing::Fill::get_ForeColor.  |
| void [set_GradientAngle](./set_gradientangle/)(double) | Setter for Aspose::Words::Drawing::Fill::get_GradientAngle.  |
| void [set_On](./set_on/)(bool) |  |
| void [set_Opacity](./set_opacity/)(double) | Setter for Aspose::Words::Drawing::Fill::get_Opacity.  |
| void [set_RotateWithObject](./set_rotatewithobject/)(bool) | Sets whether the fill rotates with the specified object.  |
| void [set_TextureAlignment](./set_texturealignment/)(Aspose::Words::Drawing::TextureAlignment) | Setter for Aspose::Words::Drawing::Fill::get_TextureAlignment.  |
| void [set_Transparency](./set_transparency/)(double) | Sets the degree of transparency of the specified fill as a value between 0.0 (opaque) and 1.0 (clear).  |
| void [set_Visible](./set_visible/)(bool) | Setter for Aspose::Words::Drawing::Fill::get_Visible.  |
| void [SetImage](./setimage/)(const System::ArrayPtr< uint8_t > &) | Changes the fill type to single image.  |
| void [SetImage](./setimage/)(const System::SharedPtr< System::IO::Stream > &) | Changes the fill type to single image.  |
| void [SetImage](./setimage/)(const System::String &) | Changes the fill type to single image.  |
| void [Solid](./solid/)() | Sets the fill to a uniform color.  |
| void [Solid](./solid/)(System::Drawing::Color) | Sets the fill to a specified uniform color.  |
| void [TwoColorGradient](./twocolorgradient/)(Aspose::Words::Drawing::GradientStyle, Aspose::Words::Drawing::GradientVariant) | Sets the specified fill to a two-color gradient.  |
| void [TwoColorGradient](./twocolorgradient/)(System::Drawing::Color, System::Drawing::Color, Aspose::Words::Drawing::GradientStyle, Aspose::Words::Drawing::GradientVariant) | Sets the specified fill to a two-color gradient.  |
