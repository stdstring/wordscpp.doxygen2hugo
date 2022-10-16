---
title: PdfImageCompression
second_title: Aspose.Words for C++ API Reference
description: Specifies the type of compression applied to images in the PDF file. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/pdfimagecompression/
---
## PdfImageCompression enum


Specifies the type of compression applied to images in the PDF file.


## Examples




Shows how to specify a compression type for all images in a document that we are converting to PDF. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->Writeln(u"Jpeg image:");
builder->InsertImage(ImageDir + u"Logo.jpg");
builder->InsertParagraph();
builder->Writeln(u"Png image:");
builder->InsertImage(ImageDir + u"Transparent background logo.png");

// Create a "PdfSaveOptions" object that we can pass to the document's "Save" method
// to modify how that method converts the document to .PDF.
auto pdfSaveOptions = MakeObject<PdfSaveOptions>();

// Set the "ImageCompression" property to "PdfImageCompression.Auto" to use the
// "ImageCompression" property to control the quality of the Jpeg images that end up in the output PDF.
// Set the "ImageCompression" property to "PdfImageCompression.Jpeg" to use the
// "ImageCompression" property to control the quality of all images that end up in the output PDF.
pdfSaveOptions->set_ImageCompression(pdfImageCompression);

// Set the "JpegQuality" property to "10" to strengthen compression at the cost of image quality.
pdfSaveOptions->set_JpegQuality(10);

doc->Save(ArtifactsDir + u"PdfSaveOptions.ImageCompression.pdf", pdfSaveOptions);
```

