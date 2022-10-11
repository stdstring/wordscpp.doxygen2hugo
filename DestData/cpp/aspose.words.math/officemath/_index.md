---
title: OfficeMath
second_title: Aspose.Words for C++ API Reference
description: Represents an Office Math object such as function, equation, matrix or alike. Can contain child elements including runs of mathematical text, bookmarks, comments, other OfficeMath instances and some other nodes. 
type: docs
weight: 0
url: /cpp/aspose.words.math/officemath/
---
## OfficeMath class


Represents an Office Math object such as function, equation, matrix or alike. Can contain child elements including runs of mathematical text, bookmarks, comments, other OfficeMath instances and some other nodes. 

## Methods

| Method | Description |
| --- | --- |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| Aspose::Words::Math::OfficeMathDisplayType [get_DisplayType](./get_displaytype/)() | Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.  |
| System::SharedPtr< System::Text::Encoding > [get_EquationXmlEncoding](./get_equationxmlencoding/)() const | Gets/sets an encoding that was used to encode equation XML, if this office math object is read from equation XML. We use the encoding on saving a document to write in same encoding that it was read.  |
| Aspose::Words::Math::OfficeMathJustification [get_Justification](./get_justification/)() | Gets/sets Office Math justification.  |
| Aspose::Words::Math::MathObjectType [get_MathObjectType](./get_mathobjecttype/)() const | Gets type MathObjectType of this Office Math object.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.OfficeMath**.  |
| System::SharedPtr< Aspose::Words::Paragraph > [get_ParentParagraph](./get_parentparagraph/)() | Retrieves the parent Paragraph of this node.  |
| System::SharedPtr< Aspose::Words::Rendering::OfficeMathRenderer > [GetMathRenderer](./getmathrenderer/)() | Creates and returns an object that can be used to render this equation into an image.  |
| void [set_DisplayType](./set_displaytype/)(Aspose::Words::Math::OfficeMathDisplayType) | Setter for Aspose::Words::Math::OfficeMath::get_DisplayType.  |
| void [set_EquationXmlEncoding](./set_equationxmlencoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Math::OfficeMath::get_EquationXmlEncoding.  |
| void [set_Justification](./set_justification/)(Aspose::Words::Math::OfficeMathJustification) | Setter for Aspose::Words::Math::OfficeMath::get_Justification.  |
