---
title: ImageType
second_title: Aspose.Words for C++ API Reference
description: Specifies the type (format) of an image in a Microsoft Word document. 
type: docs
weight: 352
url: /cpp/aspose.words.drawing/imagetype/
---
## ImageType enum


Specifies the type (format) of an image in a Microsoft Word document.

### Values

| Name | Value | Description |
| --- | --- | --- |
| NoImage | `0` | The is no image data. |
| Unknown | `0` | An unknown image type or image type that cannot be directly stored inside a Microsoft Word document. |
| Emf | `0` | Windows Enhanced Metafile. |
| Wmf | `0` | Windows Metafile. |
| Pict | `0` | Macintosh PICT. An existing image will be preserved in a document, but inserting new PICT images into a document is not supported. |
| Jpeg | `0` | JPEG JFIF. |
| Png | `0` | Portable Network Graphics. |
| Bmp | `0` | Windows Bitmap. |


## Examples




Shows how to add an image to a shape and check its type. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

ArrayPtr<uint8_t> imageBytes = System::IO::File::ReadAllBytes(ImageDir + u"Logo.jpg");

{
    auto stream = MakeObject<System::IO::MemoryStream>(imageBytes);
    SharedPtr<System::Drawing::Image> image = System::Drawing::Image::FromStream(stream);

    // The image in the URL is a .gif. Inserting it into a document converts it into a .png.
    SharedPtr<Shape> imgShape = builder->InsertImage(image);
    ASSERT_EQ(ImageType::Jpeg, imgShape->get_ImageData()->get_ImageType());
}
```

