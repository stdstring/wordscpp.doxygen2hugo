---
title: ImageFieldMergingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for the ImageFieldMerging() event. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/imagefieldmergingargs/
---
## ImageFieldMergingArgs class


Provides data for the ImageFieldMerging() event. 

## Methods

| Method | Description |
| --- | --- |
| const System::SharedPtr< System::Drawing::Image > & [get_Image](./get_image/)() const | Specifies the image that the mail merge engine must insert into the document.  |
| System::String [get_ImageFileName](./get_imagefilename/)() const | Sets the file name of the image that the mail merge engine must insert into the document.  |
| const System::SharedPtr< Aspose::Words::Fields::MergeFieldImageDimension > & [get_ImageHeight](./get_imageheight/)() const | Specifies the image height for the image to insert into the document.  |
| const System::SharedPtr< System::IO::Stream > & [get_ImageStream](./get_imagestream/)() const | Specifies the stream for the mail merge engine to read an image from.  |
| const System::SharedPtr< Aspose::Words::Fields::MergeFieldImageDimension > & [get_ImageWidth](./get_imagewidth/)() const | Specifies the image width for the image to insert into the document.  |
| const System::SharedPtr< Aspose::Words::Drawing::Shape > & [get_Shape](./get_shape/)() const | Specifies the shape that the mail merge engine must insert into the document.  |
| void [set_Image](./set_image/)(const System::SharedPtr< System::Drawing::Image > &) | Specifies the image that the mail merge engine must insert into the document.  |
| void [set_ImageFileName](./set_imagefilename/)(const System::String &) | Sets the file name of the image that the mail merge engine must insert into the document.  |
| void [set_ImageHeight](./set_imageheight/)(const System::SharedPtr< Aspose::Words::Fields::MergeFieldImageDimension > &) | Setter for Aspose::Words::MailMerging::ImageFieldMergingArgs::get_ImageHeight.  |
| void [set_ImageStream](./set_imagestream/)(const System::SharedPtr< System::IO::Stream > &) | Specifies the stream for the mail merge engine to read an image from.  |
| void [set_ImageStream](./set_imagestream/)(std::basic_istream< CharType, Traits > &) |  |
| void [set_ImageWidth](./set_imagewidth/)(const System::SharedPtr< Aspose::Words::Fields::MergeFieldImageDimension > &) | Setter for Aspose::Words::MailMerging::ImageFieldMergingArgs::get_ImageWidth.  |
| void [set_Shape](./set_shape/)(const System::SharedPtr< Aspose::Words::Drawing::Shape > &) | Setter for Aspose::Words::MailMerging::ImageFieldMergingArgs::get_Shape.  |
