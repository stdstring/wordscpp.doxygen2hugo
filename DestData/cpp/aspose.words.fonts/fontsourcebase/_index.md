---
title: FontSourceBase
second_title: Aspose.Words for C++ API Reference
description: This is an abstract base class for the classes that allow the user to specify various font sources. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/fontsourcebase/
---
## FontSourceBase class


This is an abstract base class for the classes that allow the user to specify various font sources. 

## Methods

| Method | Description |
| --- | --- |
| int32_t [get_Priority](./get_priority/)() const | Returns the font source priority.  |
| virtual Aspose::Words::Fonts::FontSourceType [get_Type](./get_type/)() | Returns the type of the font source.  |
| System::SharedPtr< Aspose::Words::IWarningCallback > [get_WarningCallback](./get_warningcallback/)() const | Called during processing of font source when an issue is detected that might result in formatting fidelity loss.  |
| System::SharedPtr< System::Collections::Generic::IList< System::SharedPtr< Aspose::Words::Fonts::PhysicalFontInfo > > > [GetAvailableFonts](./getavailablefonts/)() | Returns list of fonts available via this source.  |
| void [set_WarningCallback](./set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::Fonts::FontSourceBase::get_WarningCallback.  |
