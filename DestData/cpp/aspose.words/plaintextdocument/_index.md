---
title: PlainTextDocument
second_title: Aspose.Words for C++ API Reference
description: Allows to extract plain-text representation of the document's content. 
type: docs
weight: 0
url: /cpp/aspose.words/plaintextdocument/
---
## PlainTextDocument class


Allows to extract plain-text representation of the document's content. 

## Methods

| Method | Description |
| --- | --- |
|  [PlainTextDocument](./plaintextdocument/)(const System::SharedPtr< System::IO::Stream > &) | Creates a plain text document from a stream. Automatically detects the file format.  |
|  [PlainTextDocument](./plaintextdocument/)(const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< Aspose::Words::Loading::LoadOptions > &) | Creates a plain text document from a stream. Allows to specify additional options such as an encryption password.  |
|  [PlainTextDocument](./plaintextdocument/)(const System::String &) | Creates a plain text document from a file. Automatically detects the file format.  |
|  [PlainTextDocument](./plaintextdocument/)(const System::String &, const System::SharedPtr< Aspose::Words::Loading::LoadOptions > &) | Creates a plain text document from a file. Allows to specify additional options such as an encryption password.  |
|  [PlainTextDocument](./plaintextdocument/)(std::istream &) |  |
|  [PlainTextDocument](./plaintextdocument/)(std::istream &, const System::SharedPtr< Aspose::Words::Loading::LoadOptions > &) |  |
| System::SharedPtr< Aspose::Words::Properties::BuiltInDocumentProperties > [get_BuiltInDocumentProperties](./get_builtindocumentproperties/)() const | Gets BuiltInDocumentProperties of the document.  |
| System::SharedPtr< Aspose::Words::Properties::CustomDocumentProperties > [get_CustomDocumentProperties](./get_customdocumentproperties/)() const | Gets CustomDocumentProperties of the document.  |
| System::String [get_Text](./get_text/)() const | Gets textual content of the document concatenated as a string.  |
