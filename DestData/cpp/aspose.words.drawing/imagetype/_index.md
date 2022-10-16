---
title: ImageType
second_title: Aspose.Words for C++ API Reference
description: Specifies the type (format) of an image in a Microsoft Word document. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/imagetype/
---
## ImageType enum


Specifies the type (format) of an image in a Microsoft Word document.


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

