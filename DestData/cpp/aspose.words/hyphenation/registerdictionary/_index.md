---
title: RegisterDictionary
second_title: Aspose.Words for C++ API Reference
description: Registers and loads a hyphenation dictionary for the specified language from a stream. Throws if dictionary cannot be read or has invalid format. 
type: docs
weight: 0
url: /cpp/aspose.words/hyphenation/registerdictionary/
---
## Hyphenation.RegisterDictionary(const System::String\&, const System::SharedPtr\<System::IO::Stream\>\&) method


Registers and loads a hyphenation dictionary for the specified language from a stream. Throws if dictionary cannot be read or has invalid format.

```cpp
static void Aspose::Words::Hyphenation::RegisterDictionary(const System::String &language, const System::SharedPtr<System::IO::Stream> &stream)
```

## Hyphenation.RegisterDictionary(const System::String\&, const System::String\&) method


Registers and loads a hyphenation dictionary for the specified language from file. Throws if dictionary cannot be read or has invalid format. This method can also be used to register Null dictionary to prevent [Callback](./get_callback/) from being called repeatedly for the same language.

```cpp
static void Aspose::Words::Hyphenation::RegisterDictionary(const System::String &language, const System::String &fileName)
```

## Hyphenation.RegisterDictionary(System::String, std::basic_istream\<CharType, Traits\>\&) method




```cpp
template<typename CharType,typename Traits> static void Aspose::Words::Hyphenation::RegisterDictionary(System::String language, std::basic_istream<CharType, Traits> &stream)
```

