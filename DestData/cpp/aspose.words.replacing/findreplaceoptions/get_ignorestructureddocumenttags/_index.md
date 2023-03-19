---
title: Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreStructuredDocumentTags method
linktitle: get_IgnoreStructuredDocumentTags
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreStructuredDocumentTags method. Gets or sets a boolean value indicating either to ignore content of StructuredDocumentTag. The default value is false in C++.
type: docs
weight: 1100
url: /cpp/aspose.words.replacing/findreplaceoptions/get_ignorestructureddocumenttags/
---
## FindReplaceOptions::get_IgnoreStructuredDocumentTags method


Gets or sets a boolean value indicating either to ignore content of [StructuredDocumentTag](../../../aspose.words.markup/structureddocumenttag/). The default value is **false**.

```cpp
bool Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreStructuredDocumentTags() const
```

## Remarks


When this option is set to **true**, the content of [StructuredDocumentTag](../../../aspose.words.markup/structureddocumenttag/) will be treated as a simple text.

Otherwise, [StructuredDocumentTag](../../../aspose.words.markup/structureddocumenttag/) will be processed as standalone [Story](../../../aspose.words/story/) and replacing pattern will be searched separately for each [StructuredDocumentTag](../../../aspose.words.markup/structureddocumenttag/), so that if pattern crosses a [StructuredDocumentTag](../../../aspose.words.markup/structureddocumenttag/), then replacement will not be performed for such pattern. 
## See Also

* Class [FindReplaceOptions](../)
* Namespace [Aspose::Words::Replacing](../../)
* Library [Aspose.Words for C++](../../../)
