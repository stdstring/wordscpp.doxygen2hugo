---
title: PdfCompliance
second_title: Aspose.Words for C++ API Reference
description: Specifies the PDF standards compliance level. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/pdfcompliance/
---
## PdfCompliance enum


Specifies the PDF standards compliance level.


## Examples




Shows how to set the PDF standards compliance level of saved PDF documents. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Images.docx");

// Create a "PdfSaveOptions" object that we can pass to the document's "Save" method
// to modify how that method converts the document to .PDF.
auto saveOptions = MakeObject<PdfSaveOptions>();

// Set the "Compliance" property to "PdfCompliance.PdfA1b" to comply with the "PDF/A-1b" standard,
// which aims to preserve the visual appearance of the document as Aspose.Words convert it to PDF.
// Set the "Compliance" property to "PdfCompliance.Pdf17" to comply with the "1.7" standard.
// Set the "Compliance" property to "PdfCompliance.PdfA1a" to comply with the "PDF/A-1a" standard,
// which complies with "PDF/A-1b" as well as preserving the document structure of the original document.
// This helps with making documents searchable but may significantly increase the size of already large documents.
saveOptions->set_Compliance(pdfCompliance);

doc->Save(ArtifactsDir + u"PdfSaveOptions.Compliance.pdf", saveOptions);
```

