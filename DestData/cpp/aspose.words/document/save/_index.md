---
title: Save
second_title: Aspose.Words for C++ API Reference
description: Saves the document to a stream using the specified format. 
type: docs
weight: 0
url: /cpp/aspose.words/document/save/
---
## Document.Save(const System::SharedPtr\<System::IO::Stream\>\&, Aspose::Words::SaveFormat) method


Saves the document to a stream using the specified format.

```cpp
System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(const System::SharedPtr<System::IO::Stream> &stream, Aspose::Words::SaveFormat saveFormat)
```

## Document.Save(const System::SharedPtr\<System::IO::Stream\>\&, const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) method


Saves the document to a stream using the specified save options.

```cpp
System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(const System::SharedPtr<System::IO::Stream> &stream, const System::SharedPtr<Aspose::Words::Saving::SaveOptions> &saveOptions)
```

## Document.Save(const System::String\&) method


Saves the document to a file. Automatically determines the save format from the extension.

```cpp
System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(const System::String &fileName)
```

## Document.Save(const System::String\&, Aspose::Words::SaveFormat) method


Saves the document to a file in the specified format.

```cpp
System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(const System::String &fileName, Aspose::Words::SaveFormat saveFormat)
```

## Document.Save(const System::String\&, const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) method


Saves the document to a file using the specified save options.

```cpp
System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(const System::String &fileName, const System::SharedPtr<Aspose::Words::Saving::SaveOptions> &saveOptions)
```

## Document.Save(std::basic_ostream\<CharType, Traits\>\&, Aspose::Words::SaveFormat) method




```cpp
template<typename CharType,typename Traits> System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(std::basic_ostream<CharType, Traits> &stream, Aspose::Words::SaveFormat saveFormat)
```

## Document.Save(std::basic_ostream\<CharType, Traits\>\&, System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>) method




```cpp
template<typename CharType,typename Traits> System::SharedPtr<Aspose::Words::Saving::SaveOutputParameters> Aspose::Words::Document::Save(std::basic_ostream<CharType, Traits> &stream, System::SharedPtr<Aspose::Words::Saving::SaveOptions> saveOptions)
```

