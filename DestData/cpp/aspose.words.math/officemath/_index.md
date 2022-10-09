---
title: OfficeMath
second_title: Aspose.Words for C++ API Reference
description: Represents an Office Math object such as function, equation, matrix or alike. Can contain child elements including runs of mathematical text, bookmarks, comments, other OfficeMath instances and some other nodes. 
type: docs
weight: 0
url: /cpp/aspose.words.math/officemath/
---

Represents an Office Math object such as function, equation, matrix or alike. Can contain child elements including runs of mathematical text, bookmarks, comments, other OfficeMath instances and some other nodes. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [get_DisplayType](./get_displaytype/)() | Gets/sets Office Math display format type which represents whether an equation is displayed inline with the text or displayed on its own line.  |
| [get_EquationXmlEncoding](./get_equationxmlencoding/)() const | Gets/sets an encoding that was used to encode equation XML, if this office math object is read from equation XML. We use the encoding on saving a document to write in same encoding that it was read.  |
| [get_Justification](./get_justification/)() | Gets/sets Office Math justification.  |
| [get_MathObjectType](./get_mathobjecttype/)() const | Gets type MathObjectType of this Office Math object.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.OfficeMath**.  |
| [get_ParentParagraph](./get_parentparagraph/)() | Retrieves the parent Paragraph of this node.  |
| [GetMathRenderer](./getmathrenderer/)() | Creates and returns an object that can be used to render this equation into an image.  |
| [set_DisplayType](./set_displaytype/)(Aspose::Words::Math::OfficeMathDisplayType) | Setter for Aspose::Words::Math::OfficeMath::get_DisplayType.  |
| [set_EquationXmlEncoding](./set_equationxmlencoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Math::OfficeMath::get_EquationXmlEncoding.  |
| [set_Justification](./set_justification/)(Aspose::Words::Math::OfficeMathJustification) | Setter for Aspose::Words::Math::OfficeMath::get_Justification.  |
