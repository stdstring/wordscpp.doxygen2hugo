---
title: FontFallbackSettings
second_title: Aspose.Words for C++ API Reference
description: Specifies font fallback mechanism settings. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/fontfallbacksettings/
---
## FontFallbackSettings class


Specifies font fallback mechanism settings. 

## Methods

| Method | Description |
| --- | --- |
| void [BuildAutomatic](./buildautomatic/)() | Automatically builds the fallback settings by scanning available fonts.  |
| void [Load](./load/)(const System::SharedPtr< System::IO::Stream > &) | Loads fallback settings from XML stream.  |
| void [Load](./load/)(const System::String &) | Loads font fallback settings from XML file.  |
| void [Load](./load/)(std::basic_istream< CharType, Traits > &) |  |
| void [LoadMsOfficeFallbackSettings](./loadmsofficefallbacksettings/)() | Loads predefined fallback settings which mimics the Microsoft Word fallback and uses Microsoft office fonts.  |
| void [LoadNotoFallbackSettings](./loadnotofallbacksettings/)() | Loads predefined fallback settings which uses Google Noto fonts.  |
| void [Save](./save/)(const System::SharedPtr< System::IO::Stream > &) | Saves the current fallback settings to stream.  |
| void [Save](./save/)(const System::String &) | Saves the current fallback settings to file.  |
| void [Save](./save/)(std::basic_ostream< CharType, Traits > &) |  |
