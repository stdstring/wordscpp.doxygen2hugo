---
title: Aspose::Words::Layout::LayoutOptions::get_ShowParagraphMarks method
linktitle: get_ShowParagraphMarks
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Layout::LayoutOptions::get_ShowParagraphMarks method. Gets or sets indication of whether paragraph marks are rendered. Default is False in C++.'
type: docs
weight: 800
url: /cpp/aspose.words.layout/layoutoptions/get_showparagraphmarks/
---
## LayoutOptions::get_ShowParagraphMarks method


Gets or sets indication of whether paragraph marks are rendered. Default is False.

```cpp
bool Aspose::Words::Layout::LayoutOptions::get_ShowParagraphMarks() const
```


## Examples



Shows how to show paragraph marks in a rendered output document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Add some paragraphs, then enable paragraph marks to show the ends of paragraphs
// with a pilcrow (¶) symbol when we render the document.
builder->Writeln(u"Hello world!");
builder->Writeln(u"Hello again!");

doc->get_LayoutOptions()->set_ShowParagraphMarks(showParagraphMarks);

doc->Save(ArtifactsDir + u"Document.LayoutOptionsParagraphMarks.pdf");
```

## See Also

* Class [LayoutOptions](../)
* Namespace [Aspose::Words::Layout](../../)
* Library [Aspose.Words for C++](../../../)
