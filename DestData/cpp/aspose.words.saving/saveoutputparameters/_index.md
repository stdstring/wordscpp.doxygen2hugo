---
title: Aspose::Words::Saving::SaveOutputParameters class
linktitle: SaveOutputParameters
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Saving::SaveOutputParameters class. This object is returned to the caller after a document is saved and contains additional information that has been generated or calculated during the save operation. The caller can use or ignore this object in C++.'
type: docs
weight: 3000
url: /cpp/aspose.words.saving/saveoutputparameters/
---
## SaveOutputParameters class


This object is returned to the caller after a document is saved and contains additional information that has been generated or calculated during the save operation. The caller can use or ignore this object.

```cpp
class SaveOutputParameters : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| [get_ContentType](./get_contenttype/)() const | Returns the Content-Type string (Internet Media Type) that identifies the type of the saved document. |

## Examples



Shows how to access output parameters of a document's save operation. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);
builder->Writeln(u"Hello world!");

// After we save a document, we can access the Internet Media Type (MIME type) of the newly created output document.
SharedPtr<SaveOutputParameters> parameters = doc->Save(ArtifactsDir + u"Document.SaveOutputParameters.doc");

ASSERT_EQ(u"application/msword", parameters->get_ContentType());

// This property changes depending on the save format.
parameters = doc->Save(ArtifactsDir + u"Document.SaveOutputParameters.pdf");

ASSERT_EQ(u"application/pdf", parameters->get_ContentType());
```

## See Also

* Namespace [Aspose::Words::Saving](../)
* Library [Aspose.Words for C++](../../)
