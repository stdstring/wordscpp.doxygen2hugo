---
title: ImageData
second_title: Aspose.Words for C++ API Reference
description: Defines an image for a shape. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/imagedata/
---
## ImageData class


Defines an image for a shape. 

## Methods

| Method | Description |
| --- | --- |
| [get_BiLevel](./get_bilevel/)() | Determines whether an image will be displayed in black and white.  |
| [get_Borders](./get_borders/)() | Gets the collection of borders of the image. Borders only have effect for inline images.  |
| [get_Brightness](./get_brightness/)() | Gets or sets the brightness of the picture. The value for this property must be a number from 0.0 (dimmest) to 1.0 (brightest).  |
| [get_ChromaKey](./get_chromakey/)() | Defines the color value of the image that will be treated as transparent.  |
| [get_Contrast](./get_contrast/)() | Gets or sets the contrast for the specified picture. The value for this property must be a number from 0.0 (the least contrast) to 1.0 (the greatest contrast).  |
| [get_CropBottom](./get_cropbottom/)() | Defines the fraction of picture removal from the bottom side.  |
| [get_CropLeft](./get_cropleft/)() | Defines the fraction of picture removal from the left side.  |
| [get_CropRight](./get_cropright/)() | Defines the fraction of picture removal from the right side.  |
| [get_CropTop](./get_croptop/)() | Defines the fraction of picture removal from the top side.  |
| [get_GrayScale](./get_grayscale/)() | Determines whether a picture will display in grayscale mode.  |
| [get_HasImage](./get_hasimage/)() | Returns true if the shape has image bytes or links an image.  |
| [get_ImageBytes](./get_imagebytes/)() | Gets or sets the raw bytes of the image stored in the shape.  |
| [get_ImageSize](./get_imagesize/)() | Gets the information about image size and resolution.  |
| [get_ImageType](./get_imagetype/)() | Gets the type of the image.  |
| [get_IsLink](./get_islink/)() | Returns true if the image is linked to the shape (when SourceFullName is specified).  |
| [get_IsLinkOnly](./get_islinkonly/)() | Returns true if the image is linked and not stored in the document.  |
| [get_SourceFullName](./get_sourcefullname/)() | Gets or sets the path and name of the source file for the linked image.  |
| [get_Title](./get_title/)() | Defines the title of an image.  |
| [Save](./save/)(const System::SharedPtr\<System::IO::Stream\>\&) | Saves the image into the specified stream.  |
| [Save](./save/)(const System::String\&) | Saves the image into a file.  |
| [Save](./save/)(std::basic_ostream\<CharType, Traits\>\&) |  |
| [set_BiLevel](./set_bilevel/)(bool) | Setter for Aspose::Words::Drawing::ImageData::get_BiLevel.  |
| [set_Brightness](./set_brightness/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_Brightness.  |
| [set_ChromaKey](./set_chromakey/)(System::Drawing::Color) | Setter for Aspose::Words::Drawing::ImageData::get_ChromaKey.  |
| [set_Contrast](./set_contrast/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_Contrast.  |
| [set_CropBottom](./set_cropbottom/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropBottom.  |
| [set_CropLeft](./set_cropleft/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropLeft.  |
| [set_CropRight](./set_cropright/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropRight.  |
| [set_CropTop](./set_croptop/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropTop.  |
| [set_GrayScale](./set_grayscale/)(bool) | Setter for Aspose::Words::Drawing::ImageData::get_GrayScale.  |
| [set_ImageBytes](./set_imagebytes/)(const System::ArrayPtr\<uint8_t\>\&) | Setter for Aspose::Words::Drawing::ImageData::get_ImageBytes.  |
| [set_SourceFullName](./set_sourcefullname/)(const System::String\&) | Setter for Aspose::Words::Drawing::ImageData::get_SourceFullName.  |
| [set_Title](./set_title/)(const System::String\&) | Setter for Aspose::Words::Drawing::ImageData::get_Title.  |
| [SetImage](./setimage/)(const System::SharedPtr\<System::Drawing::Image\>\&) | Sets the image that the shape displays.  |
| [SetImage](./setimage/)(const System::SharedPtr\<System::IO::Stream\>\&) | Sets the image that the shape displays.  |
| [SetImage](./setimage/)(const System::String\&) | Sets the image that the shape displays.  |
| [SetImage](./setimage/)(std::basic_istream\<CharType, Traits\>\&) |  |
| [ToByteArray](./tobytearray/)() | Returns image bytes for any image regardless whether the image is stored or linked.  |
| [ToImage](./toimage/)() | Gets the image stored in the shape as a Image object.  |
| [ToStream](./tostream/)() | Creates and returns a stream that contains the image bytes.  |
