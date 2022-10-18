---
title: InsertOnlineVideo
second_title: Aspose.Words for C++ API Reference
description: Inserts an online video object into the document and scales it to the specified size. 
type: docs
weight: 0
url: /cpp/aspose.words/documentbuilder/insertonlinevideo/
---
## DocumentBuilder.InsertOnlineVideo(const System::String\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method


Inserts an online video object into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertOnlineVideo(const System::String &videoUrl, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```


| Parameter | Type | Description |
| --- | --- | --- |
| videoUrl | `-` | The URL to the video. |
| horzPos | `-` | Specifies where the distance to the image is measured from. |
| left | `-` | Distance in points from the origin to the left side of the image. |
| vertPos | `-` | Specifies where the distance to the image measured from. |
| top | `-` | Distance in points from the origin to the top side of the image. |
| width | `-` | The width of the image in points. Can be a negative or zero value to request 100% scale. |
| height | `-` | The height of the image in points. Can be a negative or zero value to request 100% scale. |
| wrapType | `-` | Specifies how to wrap text around the image. |

### ReturnValue


The image node that was just inserted.

You can change the image size, location, positioning method and other settings using the [Shape](../../../aspose.words.drawing/shape/) object returned by this method.

Insertion of online video from the following resources is supported:

* [https://www.youtube.com/](https://www.youtube.com/)
* [https://vimeo.com/](https://vimeo.com/)



If your online video is not displaying correctly, use **InsertOnlineVideo()**, which accepts custom embedded html code.

The code for embedding video can vary between providers, consult your corresponding provider of choice for details.


## DocumentBuilder.InsertOnlineVideo(const System::String\&, const System::String\&, const System::ArrayPtr\<uint8_t\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method


Inserts an online video object into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertOnlineVideo(const System::String &videoUrl, const System::String &videoEmbedCode, const System::ArrayPtr<uint8_t> &thumbnailImageBytes, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```


| Parameter | Type | Description |
| --- | --- | --- |
| videoUrl | `-` | The URL to the video. |
| videoEmbedCode | `-` | The embed code for the video. |
| thumbnailImageBytes | `-` | The thumbnail image bytes. |
| horzPos | `-` | Specifies where the distance to the image is measured from. |
| left | `-` | Distance in points from the origin to the left side of the image. |
| vertPos | `-` | Specifies where the distance to the image measured from. |
| top | `-` | Distance in points from the origin to the top side of the image. |
| width | `-` | The width of the image in points. Can be a negative or zero value to request 100% scale. |
| height | `-` | The height of the image in points. Can be a negative or zero value to request 100% scale. |
| wrapType | `-` | Specifies how to wrap text around the image. |

### ReturnValue


The image node that was just inserted.

You can change the image size, location, positioning method and other settings using the [Shape](../../../aspose.words.drawing/shape/) object returned by this method.

## Examples




Shows how to insert an online video into a document with a custom thumbnail. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

String videoUrl = u"https://vimeo.com/52477838";
String videoEmbedCode = String(u"<iframe src=\"https://player.vimeo.com/video/52477838\" width=\"640\" height=\"360\" frameborder=\"0\" ") +
                        u"title=\"Aspose\" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>";

ArrayPtr<uint8_t> thumbnailImageBytes = System::IO::File::ReadAllBytes(ImageDir + u"Logo.jpg");

{
    auto stream = MakeObject<System::IO::MemoryStream>(thumbnailImageBytes);
    {
        SharedPtr<System::Drawing::Image> image = System::Drawing::Image::FromStream(stream);
        // Below are two ways of creating a shape with a custom thumbnail, which links to an online video
        // that will play when we click on the shape in Microsoft Word.
        // 1 -  Insert an inline shape at the builder's node insertion cursor:
        builder->InsertOnlineVideo(videoUrl, videoEmbedCode, thumbnailImageBytes, image->get_Width(), image->get_Height());

        builder->InsertBreak(BreakType::PageBreak);

        // 2 -  Insert a floating shape:
        double left = builder->get_PageSetup()->get_RightMargin() - image->get_Width();
        double top = builder->get_PageSetup()->get_BottomMargin() - image->get_Height();

        builder->InsertOnlineVideo(videoUrl, videoEmbedCode, thumbnailImageBytes, RelativeHorizontalPosition::RightMargin, left,
                                   RelativeVerticalPosition::BottomMargin, top, image->get_Width(), image->get_Height(), WrapType::Square);
    }
}

doc->Save(ArtifactsDir + u"DocumentBuilder.InsertOnlineVideoCustomThumbnail.docx");
```

## DocumentBuilder.InsertOnlineVideo(const System::String\&, const System::String\&, const System::ArrayPtr\<uint8_t\>\&, double, double) method


Inserts an online video object into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertOnlineVideo(const System::String &videoUrl, const System::String &videoEmbedCode, const System::ArrayPtr<uint8_t> &thumbnailImageBytes, double width, double height)
```


| Parameter | Type | Description |
| --- | --- | --- |
| videoUrl | `-` | The URL to the video. |
| videoEmbedCode | `-` | The embed code for the video. |
| thumbnailImageBytes | `-` | The thumbnail image bytes. |
| width | `-` | The width of the image in points. Can be a negative or zero value to request 100% scale. |
| height | `-` | The height of the image in points. Can be a negative or zero value to request 100% scale. |

### ReturnValue


The image node that was just inserted.

You can change the image size, location, positioning method and other settings using the [Shape](../../../aspose.words.drawing/shape/) object returned by this method.

## Examples




Shows how to insert an online video into a document with a custom thumbnail. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

String videoUrl = u"https://vimeo.com/52477838";
String videoEmbedCode = String(u"<iframe src=\"https://player.vimeo.com/video/52477838\" width=\"640\" height=\"360\" frameborder=\"0\" ") +
                        u"title=\"Aspose\" webkitallowfullscreen mozallowfullscreen allowfullscreen></iframe>";

ArrayPtr<uint8_t> thumbnailImageBytes = System::IO::File::ReadAllBytes(ImageDir + u"Logo.jpg");

{
    auto stream = MakeObject<System::IO::MemoryStream>(thumbnailImageBytes);
    {
        SharedPtr<System::Drawing::Image> image = System::Drawing::Image::FromStream(stream);
        // Below are two ways of creating a shape with a custom thumbnail, which links to an online video
        // that will play when we click on the shape in Microsoft Word.
        // 1 -  Insert an inline shape at the builder's node insertion cursor:
        builder->InsertOnlineVideo(videoUrl, videoEmbedCode, thumbnailImageBytes, image->get_Width(), image->get_Height());

        builder->InsertBreak(BreakType::PageBreak);

        // 2 -  Insert a floating shape:
        double left = builder->get_PageSetup()->get_RightMargin() - image->get_Width();
        double top = builder->get_PageSetup()->get_BottomMargin() - image->get_Height();

        builder->InsertOnlineVideo(videoUrl, videoEmbedCode, thumbnailImageBytes, RelativeHorizontalPosition::RightMargin, left,
                                   RelativeVerticalPosition::BottomMargin, top, image->get_Width(), image->get_Height(), WrapType::Square);
    }
}

doc->Save(ArtifactsDir + u"DocumentBuilder.InsertOnlineVideoCustomThumbnail.docx");
```

## DocumentBuilder.InsertOnlineVideo(const System::String\&, double, double) method


Inserts an online video object into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertOnlineVideo(const System::String &videoUrl, double width, double height)
```


| Parameter | Type | Description |
| --- | --- | --- |
| videoUrl | `-` | The URL to the video. |
| width | `-` | The width of the image in points. Can be a negative or zero value to request 100% scale. |
| height | `-` | The height of the image in points. Can be a negative or zero value to request 100% scale. |

### ReturnValue


The image node that was just inserted.

You can change the image size, location, positioning method and other settings using the [Shape](../../../aspose.words.drawing/shape/) object returned by this method.

Insertion of online video from the following resources is supported:

* [https://www.youtube.com/](https://www.youtube.com/)
* [https://vimeo.com/](https://vimeo.com/)



If your online video is not displaying correctly, use **InsertOnlineVideo()**, which accepts custom embedded html code.

The code for embedding video can vary between providers, consult your corresponding provider of choice for details.

## Examples




Shows how to insert an online video into a document using a URL. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->InsertOnlineVideo(u"https://youtu.be/t_1LYZ102RA", 360, 270);

// We can watch the video from Microsoft Word by clicking on the shape.
doc->Save(ArtifactsDir + u"DocumentBuilder.InsertVideoWithUrl.docx");
```

