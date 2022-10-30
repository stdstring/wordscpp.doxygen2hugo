---
title: get_BuiltInDocumentProperties
second_title: Aspose.Words for C++ API Reference
description: Gets BuiltInDocumentProperties of the document.
type: docs
weight: 14
url: /cpp/aspose.words/plaintextdocument/get_builtindocumentproperties/
---
## PlainTextDocument::get_BuiltInDocumentProperties method


Gets [BuiltInDocumentProperties](./) of the document.

```cpp
System::SharedPtr<Aspose::Words::Properties::BuiltInDocumentProperties> Aspose::Words::PlainTextDocument::get_BuiltInDocumentProperties() const
```


## Examples




Shows how to load the contents of a Microsoft Word document in plaintext and then access the original document's built-in properties. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->Writeln(u"Hello world!");
doc->get_BuiltInDocumentProperties()->set_Author(u"John Doe");

doc->Save(ArtifactsDir + u"PlainTextDocument.BuiltInProperties.docx");

auto plaintext = MakeObject<PlainTextDocument>(ArtifactsDir + u"PlainTextDocument.BuiltInProperties.docx");

ASSERT_EQ(u"Hello world!", plaintext->get_Text().Trim());
ASSERT_EQ(u"John Doe", plaintext->get_BuiltInDocumentProperties()->get_Author());
```

