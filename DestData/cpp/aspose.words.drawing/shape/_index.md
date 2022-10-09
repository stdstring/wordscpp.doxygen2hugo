---
title: Shape
second_title: Aspose.Words for C++ API Reference
description: Represents an object in the drawing layer, such as an AutoShape, textbox, freeform, OLE object, ActiveX control, or picture. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/shape/
---

Represents an object in the drawing layer, such as an AutoShape, textbox, freeform, OLE object, ActiveX control, or picture. 

## Methods

| Method | Description |
| --- | --- |
| [Shape](./shape/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, Aspose::Words::Drawing::ShapeType) | Creates a new shape object.  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [get_Chart](./get_chart/)() | Provides access to the chart properties if this shape has a Chart.  |
| [get_ExtrusionEnabled](./get_extrusionenabled/)() | Returns true if an extrusion effect is enabled.  |
| [get_FillColor](./get_fillcolor/)() | Defines the brush color that fills the closed path of the shape.  |
| [get_Filled](./get_filled/)() | Determines whether the closed path of the shape will be filled.  |
| [get_FirstParagraph](./get_firstparagraph/)() | Gets the first paragraph in the shape.  |
| [get_HasChart](./get_haschart/)() | Returns true if this Shape has a Chart.  |
| [get_HasImage](./get_hasimage/)() | Returns true if the shape has image bytes or links an image.  |
| [get_HasSmartArt](./get_hassmartart/)() | Returns true if this Shape has a SmartArt object.  |
| [get_HorizontalRuleFormat](./get_horizontalruleformat/)() | Provides access to the properties of the horizontal rule shape. For a shape that is not a horizontal rule, returns null.  |
| [get_ImageData](./get_imagedata/)() | Provides access to the image of the shape. Returns null if the shape cannot have an image.  |
| [get_LastParagraph](./get_lastparagraph/)() | Gets the last paragraph in the shape.  |
| [get_NodeType](./get_nodetype/)() const override | Returns Shape.  |
| [get_OleFormat](./get_oleformat/)() | Provides access to the OLE data of a shape. For a shape that is not an OLE object or ActiveX control, returns null.  |
| [get_ShadowEnabled](./get_shadowenabled/)() | Returns true if a shadow effect is enabled.  |
| [get_SignatureLine](./get_signatureline/)() | Gets SignatureLine object if the shape is a signature line. Returns **null** otherwise.  |
| [get_StoryType](./get_storytype/)() | Returns Textbox.  |
| [get_Stroke](./get_stroke/)() | Defines a stroke for a shape.  |
| [get_StrokeColor](./get_strokecolor/)() | Defines the color of a stroke.  |
| [get_Stroked](./get_stroked/)() | Defines whether the path will be stroked.  |
| [get_StrokeWeight](./get_strokeweight/)() | Defines the brush thickness that strokes the path of a shape in points.  |
| [get_TextBox](./get_textbox/)() | Defines attributes that specify how text is displayed in a shape.  |
| [get_TextPath](./get_textpath/)() | Defines the text of the text path (of a WordArt object).  |
| [set_FillColor](./set_fillcolor/)(System::Drawing::Color) | Setter for Aspose::Words::Drawing::Shape::get_FillColor.  |
| [set_Filled](./set_filled/)(bool) | Setter for Aspose::Words::Drawing::Shape::get_Filled.  |
| [set_StrokeColor](./set_strokecolor/)(System::Drawing::Color) | Setter for Aspose::Words::Drawing::Shape::get_StrokeColor.  |
| [set_Stroked](./set_stroked/)(bool) | Setter for Aspose::Words::Drawing::Shape::get_Stroked.  |
| [set_StrokeWeight](./set_strokeweight/)(double) | Setter for Aspose::Words::Drawing::Shape::get_StrokeWeight.  |
| [UpdateSmartArtDrawing](./updatesmartartdrawing/)() | Updates SmartArt pre-rendered drawing by using Aspose.Words's SmartArt cold rendering engine.  |
