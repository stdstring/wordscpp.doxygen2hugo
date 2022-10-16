---
title: SaveFormat
second_title: Aspose.Words for C++ API Reference
description: Indicates the format in which the document is saved. 
type: docs
weight: 0
url: /cpp/aspose.words/saveformat/
---
## SaveFormat enum


Indicates the format in which the document is saved.


## Examples




Shows how to convert from DOCX to HTML format. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Document.docx");

doc->Save(ArtifactsDir + u"Document.ConvertToHtml.html", SaveFormat::Html);
```

