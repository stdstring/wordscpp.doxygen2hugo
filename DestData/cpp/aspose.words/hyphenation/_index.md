---
title: Hyphenation
second_title: Aspose.Words for C++ API Reference
description: Provides methods for working with hyphenation dictionaries. These dictionaries prescribe where words of a specific language can be hyphenated. 
type: docs
weight: 0
url: /cpp/aspose.words/hyphenation/
---
## Hyphenation class


Provides methods for working with hyphenation dictionaries. These dictionaries prescribe where words of a specific language can be hyphenated. 

## Methods

| Method | Description |
| --- | --- |
| static [get_Callback](./get_callback/)() | Gets or sets callback interface used to request dictionaries when page layout of the document is built. This allows delay loading of dictionaries which may be useful when processing documents in many languages.  |
| static [get_WarningCallback](./get_warningcallback/)() | Called during a load hyphenation patterns, when an issue is detected that might result in formatting fidelity loss.  |
| [Hyphenation](./hyphenation/)() |  |
| static [IsDictionaryRegistered](./isdictionaryregistered/)(const System::String &) | Returns False if for the specified language there is no dictionary registered or if registered is Null dictionary, True otherwise.  |
| static [RegisterDictionary](./registerdictionary/)(const System::String &, const System::SharedPtr< System::IO::Stream > &) | Registers and loads a hyphenation dictionary for the specified language from a stream. Throws if dictionary cannot be read or has invalid format.  |
| static [RegisterDictionary](./registerdictionary/)(const System::String &, const System::String &) | Registers and loads a hyphenation dictionary for the specified language from file. Throws if dictionary cannot be read or has invalid format. This method can also be used to register Null dictionary to prevent Callback from being called repeatedly for the same language.  |
| static [RegisterDictionary](./registerdictionary/)(System::String, std::basic_istream< CharType, Traits > &) |  |
| static [set_Callback](./set_callback/)(const System::SharedPtr< Aspose::Words::IHyphenationCallback > &) | Setter for Aspose::Words::Hyphenation::get_Callback.  |
| static [set_WarningCallback](./set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::Hyphenation::get_WarningCallback.  |
| static [UnregisterDictionary](./unregisterdictionary/)(const System::String &) | Unregisters a hyphenation dictionary for the specified language. This is different from registering Null dictionary. Unregistering a dictionary enables callback for the specified language.  |
