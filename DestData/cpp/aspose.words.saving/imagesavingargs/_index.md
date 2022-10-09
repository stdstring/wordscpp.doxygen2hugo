---
title: ImageSavingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for the ImageSaving() event. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/imagesavingargs/
---

Provides data for the ImageSaving() event. 

## Methods

| Method | Description |
| --- | --- |
| [get_CurrentShape](./get_currentshape/)() const | Gets the ShapeBase object corresponding to the shape or group shape that is about to be saved.  |
| [get_Document](./get_document/)() | Gets the document object that is currently being saved.  |
| [get_ImageFileName](./get_imagefilename/)() const | Gets or sets the file name (without path) where the image will be saved to.  |
| [get_ImageStream](./get_imagestream/)() const | Allows to specify the stream where the image will be saved to.  |
| [get_IsImageAvailable](./get_isimageavailable/)() const | Returns **true** if the current image is available for export.  |
| [get_KeepImageStreamOpen](./get_keepimagestreamopen/)() const | Specifies whether Aspose.Words should keep the stream open or close it after saving an image.  |
| [set_ImageFileName](./set_imagefilename/)(const System::String &) | Setter for Aspose::Words::Saving::ImageSavingArgs::get_ImageFileName.  |
| [set_ImageStream](./set_imagestream/)(const System::SharedPtr< System::IO::Stream > &) | Setter for Aspose::Words::Saving::ImageSavingArgs::get_ImageStream.  |
| [set_ImageStream](./set_imagestream/)(std::basic_ostream< CharType, Traits > &) |  |
| [set_KeepImageStreamOpen](./set_keepimagestreamopen/)(bool) | Setter for Aspose::Words::Saving::ImageSavingArgs::get_KeepImageStreamOpen.  |
