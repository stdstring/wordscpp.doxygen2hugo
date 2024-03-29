---
title: Aspose::Words::Markup::StructuredDocumentTag::get_LockContentControl method
linktitle: get_LockContentControl
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Markup::StructuredDocumentTag::get_LockContentControl method. When set to true, this property will prohibit a user from deleting this SDT in C++.'
type: docs
weight: 2100
url: /cpp/aspose.words.markup/structureddocumenttag/get_lockcontentcontrol/
---
## StructuredDocumentTag::get_LockContentControl method


When set to true, this property will prohibit a user from deleting this **SDT**.

```cpp
bool Aspose::Words::Markup::StructuredDocumentTag::get_LockContentControl() override
```


## Examples



Shows how to apply editing restrictions to structured document tags. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a plain text structured document tag, which acts as a text box that prompts the user to fill it in.
auto tag = MakeObject<StructuredDocumentTag>(doc, SdtType::PlainText, MarkupLevel::Inline);

// Set the "LockContents" property to "true" to prohibit the user from editing this text box's contents.
tag->set_LockContents(true);
builder->Write(u"The contents of this structured document tag cannot be edited: ");
builder->InsertNode(tag);

tag = MakeObject<StructuredDocumentTag>(doc, SdtType::PlainText, MarkupLevel::Inline);

// Set the "LockContentControl" property to "true" to prohibit the user from
// deleting this structured document tag manually in Microsoft Word.
tag->set_LockContentControl(true);

builder->InsertParagraph();
builder->Write(u"This structured document tag cannot be deleted but its contents can be edited: ");
builder->InsertNode(tag);

doc->Save(ArtifactsDir + u"StructuredDocumentTag.Lock.docx");
```

## See Also

* Class [StructuredDocumentTag](../)
* Namespace [Aspose::Words::Markup](../../)
* Library [Aspose.Words for C++](../../../)
