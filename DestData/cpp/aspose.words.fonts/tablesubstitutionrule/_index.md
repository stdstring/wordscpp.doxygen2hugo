---
title: TableSubstitutionRule
second_title: Aspose.Words for C++ API Reference
description: Table font substitution rule. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/tablesubstitutionrule/
---
## TableSubstitutionRule class


Table font substitution rule. 

## Methods

| Method | Description |
| --- | --- |
| void [AddSubstitutes](./addsubstitutes/)(const System::String &, const System::ArrayPtr< System::String > &) | Adds substitute font names for given original font name.  |
| System::SharedPtr< System::Collections::Generic::IEnumerable< System::String > > [GetSubstitutes](./getsubstitutes/)(const System::String &) | Returns array containing substitute font names for the specified original font name.  |
| void [Load](./load/)(const System::SharedPtr< System::IO::Stream > &) | Loads table substitution settings from XML stream.  |
| void [Load](./load/)(const System::String &) | Loads table substitution settings from XML file.  |
| void [LoadAndroidSettings](./loadandroidsettings/)() | Loads predefined table substitution settings for Linux platform.  |
| void [LoadLinuxSettings](./loadlinuxsettings/)() | Loads predefined table substitution settings for Linux platform.  |
| void [LoadWindowsSettings](./loadwindowssettings/)() | Loads predefined table substitution settings for Windows platform.  |
| void [Save](./save/)(const System::SharedPtr< System::IO::Stream > &) | Saves the current table substitution settings to stream.  |
| void [Save](./save/)(const System::String &) | Saves the current table substitution settings to file.  |
| void [SetSubstitutes](./setsubstitutes/)(const System::String &, const System::ArrayPtr< System::String > &) | Override substitute font names for given original font name.  |
