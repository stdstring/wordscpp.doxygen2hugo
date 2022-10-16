---
title: DocumentSplitCriteria
second_title: Aspose.Words for C++ API Reference
description: Specifies how the document is split into parts when saving to Html, Epub or Azw3 format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/documentsplitcriteria/
---
## DocumentSplitCriteria enum


Specifies how the document is split into parts when saving to **Html**, **Epub** or **Azw3** format.


[DocumentSplitCriteria](./documentsplitcriteria/) is a set of flags which can be combined. For instance you can split the document at page breaks and heading paragraphs in the same export operation.

Different criteria can partially overlap. For instance, **Heading 1** style is frequently given [PageBreakBefore](../aspose.words/paragraphformat/get_pagebreakbefore/) property so it falls under two criteria: **PageBreak** and **HeadingParagraph**. Some section breaks can cause page breaks and so on. In typical cases specifying only one flag is the most practical option.

## Examples




Shows how to use a specific encoding when saving a document to .epub. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");

// Use a SaveOptions object to specify the encoding for a document that we will save.
auto saveOptions = MakeObject<HtmlSaveOptions>();
saveOptions->set_SaveFormat(SaveFormat::Epub);
saveOptions->set_Encoding(System::Text::Encoding::get_UTF8());

// By default, an output .epub document will have all its contents in one HTML part.
// A split criterion allows us to segment the document into several HTML parts.
// We will set the criteria to split the document into heading paragraphs.
// This is useful for readers who cannot read HTML files more significant than a specific size.
saveOptions->set_DocumentSplitCriteria(DocumentSplitCriteria::HeadingParagraph);

// Specify that we want to export document properties.
saveOptions->set_ExportDocumentProperties(true);

doc->Save(ArtifactsDir + u"HtmlSaveOptions.Doc2EpubSaveOptions.epub", saveOptions);
```

