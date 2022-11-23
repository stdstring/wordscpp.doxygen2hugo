---
title: get_HeightPixels
second_title: Aspose.Words for C++ API Reference
description: Gets the height of the image in pixels.
type: docs
weight: 14
url: /cpp/aspose.words.drawing/imagesize/get_heightpixels/
---
## ImageSize::get_HeightPixels method


Gets the height of the image in pixels.

```cpp
int32_t Aspose::Words::Drawing::ImageSize::get_HeightPixels() const
```


## Examples



Shows how to read the properties of an image in a shape. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a shape into the document which contains an image taken from our local file system.
SharedPtr<Shape> shape = builder->InsertImage(ImageDir + u"Logo.jpg");

// If the shape contains an image, its ImageData property will be valid,
// and it will contain an ImageSize object.
SharedPtr<ImageSize> imageSize = shape->get_ImageData()->get_ImageSize();

// The ImageSize object contains read-only information about the image within the shape.
ASSERT_EQ(400, imageSize->get_HeightPixels());
ASSERT_EQ(400, imageSize->get_WidthPixels());

const double delta = 0.05;
ASSERT_NEAR(95.98, imageSize->get_HorizontalResolution(), delta);
ASSERT_NEAR(95.98, imageSize->get_VerticalResolution(), delta);

// We can base the size of the shape on the size of its image to avoid stretching the image.
shape->set_Width(imageSize->get_WidthPoints() * 2);
shape->set_Height(imageSize->get_HeightPoints() * 2);

doc->Save(ArtifactsDir + u"Drawing.ImageSize.docx");
```

