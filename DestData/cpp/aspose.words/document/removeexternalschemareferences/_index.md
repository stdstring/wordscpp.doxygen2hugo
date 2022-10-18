---
title: RemoveExternalSchemaReferences
second_title: Aspose.Words for C++ API Reference
description: Removes external XML schema references from this document. 
type: docs
weight: 0
url: /cpp/aspose.words/document/removeexternalschemareferences/
---
## Document.RemoveExternalSchemaReferences method


Removes external XML schema references from this document.

```cpp
void Aspose::Words::Document::RemoveExternalSchemaReferences()
```


## Examples




Shows how to remove all external XML schema references from a document. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"External XML schema.docx");

doc->RemoveExternalSchemaReferences();
```

