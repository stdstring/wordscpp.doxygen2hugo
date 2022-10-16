---
title: PdfCustomPropertiesExport
second_title: Aspose.Words for C++ API Reference
description: Specifies the way CustomDocumentProperties are exported to PDF file. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/pdfcustompropertiesexport/
---
## PdfCustomPropertiesExport enum


Specifies the way [CustomDocumentProperties](../../aspose.words/document/get_customdocumentproperties/) are exported to PDF file.


## Examples




Shows how to export custom properties while converting a document to PDF. 
```cpp
auto doc = MakeObject<Document>();

doc->get_CustomDocumentProperties()->Add(u"Company", String(u"My value"));

// Create a "PdfSaveOptions" object that we can pass to the document's "Save" method
// to modify how that method converts the document to .PDF.
auto options = MakeObject<PdfSaveOptions>();

// Set the "CustomPropertiesExport" property to "PdfCustomPropertiesExport.None" to discard
// custom document properties as we save the document to .PDF.
// Set the "CustomPropertiesExport" property to "PdfCustomPropertiesExport.Standard"
// to preserve custom properties within the output PDF document.
// Set the "CustomPropertiesExport" property to "PdfCustomPropertiesExport.Metadata"
// to preserve custom properties in an XMP packet.
options->set_CustomPropertiesExport(pdfCustomPropertiesExportMode);

doc->Save(ArtifactsDir + u"PdfSaveOptions.CustomPropertiesExport.pdf", options);
```

