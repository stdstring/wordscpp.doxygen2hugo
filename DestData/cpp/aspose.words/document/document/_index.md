---
title: Document
second_title: Aspose.Words for C++ API Reference
description: Creates a blank Word document. 
type: docs
weight: 0
url: /cpp/aspose.words/document/document/
---
## Document.Document() method


Creates a blank Word document.

```cpp
Aspose::Words::Document::Document()
```

## Document.Document(const System::SharedPtr\<System::IO::Stream\>\&) method


Opens an existing document from a stream. Automatically detects the file format.

```cpp
Aspose::Words::Document::Document(const System::SharedPtr<System::IO::Stream> &stream)
```

## Document.Document(const System::SharedPtr\<System::IO::Stream\>\&, const System::SharedPtr\<Aspose::Words::Loading::LoadOptions\>\&) method


Opens an existing document from a stream. Allows to specify additional options such as an encryption password.

```cpp
Aspose::Words::Document::Document(const System::SharedPtr<System::IO::Stream> &stream, const System::SharedPtr<Aspose::Words::Loading::LoadOptions> &loadOptions)
```

## Document.Document(const System::String\&) method


Opens an existing document from a file. Automatically detects the file format.

```cpp
Aspose::Words::Document::Document(const System::String &fileName)
```

## Document.Document(const System::String\&, const System::SharedPtr\<Aspose::Words::Loading::LoadOptions\>\&) method


Opens an existing document from a file. Allows to specify additional options such as an encryption password.

```cpp
Aspose::Words::Document::Document(const System::String &fileName, const System::SharedPtr<Aspose::Words::Loading::LoadOptions> &loadOptions)
```

## Document.Document(std::istream\&) method




```cpp
Aspose::Words::Document::Document(std::istream &stream)
```

## Document.Document(std::istream\&, const System::SharedPtr\<Aspose::Words::Loading::LoadOptions\>\&) method




```cpp
Aspose::Words::Document::Document(std::istream &stream, const System::SharedPtr<Aspose::Words::Loading::LoadOptions> &loadOptions)
```

