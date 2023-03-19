---
title: Aspose::Words::Saving::ImageSaveOptions::get_ImageContrast method
linktitle: get_ImageContrast
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Saving::ImageSaveOptions::get_ImageContrast method. Gets or sets the contrast for the generated images in C++.
type: docs
weight: 600
url: /cpp/aspose.words.saving/imagesaveoptions/get_imagecontrast/
---
## ImageSaveOptions::get_ImageContrast method


Gets or sets the contrast for the generated images.

```cpp
float Aspose::Words::Saving::ImageSaveOptions::get_ImageContrast() const
```

## Remarks


This property has effect only when saving to raster image formats.

The default value is 0.5. The value must be in the range between 0 and 1.

## Examples



Shows how to edit the image while Aspose.Words converts a document to one. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_ParagraphFormat()->set_Style(doc->get_Styles()->idx_get(u"Heading 1"));
builder->Writeln(u"Hello world!");
builder->InsertImage(ImageDir + u"Logo.jpg");

// When we save the document as an image, we can pass a SaveOptions object to
// edit the image while the saving operation renders it.
auto options = MakeObject<ImageSaveOptions>(SaveFormat::Png);
options->set_ImageBrightness(0.3f);
options->set_ImageContrast(0.7f);
options->set_HorizontalResolution(72.f);
options->set_VerticalResolution(72.f);
options->set_Scale(96.f / 72.f);

doc->Save(ArtifactsDir + u"ImageSaveOptions.EditImage.png", options);
```

## See Also

* Class [ImageSaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
