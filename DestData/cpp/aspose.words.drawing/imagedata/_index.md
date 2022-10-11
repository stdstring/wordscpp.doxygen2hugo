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
| bool [get_BiLevel](./get_bilevel/)() | Determines whether an image will be displayed in black and white.  |
| System::SharedPtr< Aspose::Words::BorderCollection > [get_Borders](./get_borders/)() | Gets the collection of borders of the image. Borders only have effect for inline images.  |
| double [get_Brightness](./get_brightness/)() | Gets or sets the brightness of the picture. The value for this property must be a number from 0.0 (dimmest) to 1.0 (brightest).  |
| System::Drawing::Color [get_ChromaKey](./get_chromakey/)() | Defines the color value of the image that will be treated as transparent.  |
| double [get_Contrast](./get_contrast/)() | Gets or sets the contrast for the specified picture. The value for this property must be a number from 0.0 (the least contrast) to 1.0 (the greatest contrast).  |
| double [get_CropBottom](./get_cropbottom/)() | Defines the fraction of picture removal from the bottom side.  |
| double [get_CropLeft](./get_cropleft/)() | Defines the fraction of picture removal from the left side.  |
| double [get_CropRight](./get_cropright/)() | Defines the fraction of picture removal from the right side.  |
| double [get_CropTop](./get_croptop/)() | Defines the fraction of picture removal from the top side.  |
| bool [get_GrayScale](./get_grayscale/)() | Determines whether a picture will display in grayscale mode.  |
| bool [get_HasImage](./get_hasimage/)() | Returns true if the shape has image bytes or links an image.  |
| System::ArrayPtr< uint8_t > [get_ImageBytes](./get_imagebytes/)() | Gets or sets the raw bytes of the image stored in the shape.  |
| System::SharedPtr< Aspose::Words::Drawing::ImageSize > [get_ImageSize](./get_imagesize/)() | Gets the information about image size and resolution.  |
| Aspose::Words::Drawing::ImageType [get_ImageType](./get_imagetype/)() | Gets the type of the image.  |
| bool [get_IsLink](./get_islink/)() | Returns true if the image is linked to the shape (when SourceFullName is specified).  |
| bool [get_IsLinkOnly](./get_islinkonly/)() | Returns true if the image is linked and not stored in the document.  |
| System::String [get_SourceFullName](./get_sourcefullname/)() | Gets or sets the path and name of the source file for the linked image.  |
| System::String [get_Title](./get_title/)() | Defines the title of an image.  |
| void [Save](./save/)(const System::SharedPtr< System::IO::Stream > &) | Saves the image into the specified stream.  |
| void [Save](./save/)(const System::String &) | Saves the image into a file.  |
| void [Save](./save/)(std::basic_ostream< CharType, Traits > &) |  |
| void [set_BiLevel](./set_bilevel/)(bool) | Setter for Aspose::Words::Drawing::ImageData::get_BiLevel.  |
| void [set_Brightness](./set_brightness/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_Brightness.  |
| void [set_ChromaKey](./set_chromakey/)(System::Drawing::Color) | Setter for Aspose::Words::Drawing::ImageData::get_ChromaKey.  |
| void [set_Contrast](./set_contrast/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_Contrast.  |
| void [set_CropBottom](./set_cropbottom/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropBottom.  |
| void [set_CropLeft](./set_cropleft/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropLeft.  |
| void [set_CropRight](./set_cropright/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropRight.  |
| void [set_CropTop](./set_croptop/)(double) | Setter for Aspose::Words::Drawing::ImageData::get_CropTop.  |
| void [set_GrayScale](./set_grayscale/)(bool) | Setter for Aspose::Words::Drawing::ImageData::get_GrayScale.  |
| void [set_ImageBytes](./set_imagebytes/)(const System::ArrayPtr< uint8_t > &) | Setter for Aspose::Words::Drawing::ImageData::get_ImageBytes.  |
| void [set_SourceFullName](./set_sourcefullname/)(const System::String &) | Setter for Aspose::Words::Drawing::ImageData::get_SourceFullName.  |
| void [set_Title](./set_title/)(const System::String &) | Setter for Aspose::Words::Drawing::ImageData::get_Title.  |
| void [SetImage](./setimage/)(const System::SharedPtr< System::Drawing::Image > &) | Sets the image that the shape displays.  |
| void [SetImage](./setimage/)(const System::SharedPtr< System::IO::Stream > &) | Sets the image that the shape displays.  |
| void [SetImage](./setimage/)(const System::String &) | Sets the image that the shape displays.  |
| void [SetImage](./setimage/)(std::basic_istream< CharType, Traits > &) |  |
| System::ArrayPtr< uint8_t > [ToByteArray](./tobytearray/)() | Returns image bytes for any image regardless whether the image is stored or linked.  |
| System::SharedPtr< System::Drawing::Image > [ToImage](./toimage/)() | Gets the image stored in the shape as a Image object.  |
| System::SharedPtr< System::IO::Stream > [ToStream](./tostream/)() | Creates and returns a stream that contains the image bytes.  |
