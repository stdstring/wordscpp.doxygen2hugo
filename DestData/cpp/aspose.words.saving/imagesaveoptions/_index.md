---
title: ImageSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify additional options when rendering document pages or shapes to images. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/imagesaveoptions/
---
## ImageSaveOptions class


Allows to specify additional options when rendering document pages or shapes to images. 

## Methods

| Method | Description |
| --- | --- |
| [ImageSaveOptions](./imagesaveoptions/)(Aspose::Words::SaveFormat) | Initializes a new instance of this class that can be used to save rendered images in the Tiff, Png, Bmp, Emf, Jpeg or Svg format. Png, Bmp, Jpeg or Svg format.  |
| [Clone](./clone/)() | Creates a deep clone of this object.  |
| [get_HorizontalResolution](./get_horizontalresolution/)() const | Gets or sets the horizontal resolution for the generated images, in dots per inch.  |
| [get_ImageBrightness](./get_imagebrightness/)() const | Gets or sets the brightness for the generated images.  |
| [get_ImageColorMode](./get_imagecolormode/)() const | Gets or sets the color mode for the generated images.  |
| [get_ImageContrast](./get_imagecontrast/)() const | Gets or sets the contrast for the generated images.  |
| [get_JpegQuality](./get_jpegquality/)() | Gets or sets a value determining the quality of the generated JPEG images.  |
| [get_MetafileRenderingOptions](./get_metafilerenderingoptions/)() | Allows to specify how metafiles are treated in the rendered output.  |
| [get_PageSet](./get_pageset/)() | Gets or sets the pages to render. Default is all the pages in the document.  |
| [get_PaperColor](./get_papercolor/)() | Gets or sets the background (paper) color for the generated images. The default value is White.  |
| [get_PixelFormat](./get_pixelformat/)() const | Gets or sets the pixel format for the generated images.  |
| [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the rendered document pages or shapes will be saved if this save options object is used. Can be a raster Tiff, Png, Bmp, Jpeg or vector Emf, Svg.  |
| [get_Scale](./get_scale/)() const | Gets or sets the zoom factor for the generated images.  |
| [get_ThresholdForFloydSteinbergDithering](./get_thresholdforfloydsteinbergdithering/)() const | Gets or sets the threshold that determines the value of the binarization error in the Floyd-Steinberg method. when ImageBinarizationMethod is ImageBinarizationMethod.FloydSteinbergDithering.  |
| [get_TiffBinarizationMethod](./get_tiffbinarizationmethod/)() const | Gets or sets method used while converting images to 1 bpp format when SaveFormat is SaveFormat.Tiff and TiffCompression is equal to TiffCompression.Ccitt3 or TiffCompression.Ccitt4.  |
| [get_TiffCompression](./get_tiffcompression/)() const | Gets or sets the type of compression to apply when saving generated images to the TIFF format.  |
| [get_UseGdiEmfRenderer](./get_usegdiemfrenderer/)() const | Gets or sets a value determining whether to use GDI+ or Aspose.Words metafile renderer when saving to EMF.  |
| [get_VerticalResolution](./get_verticalresolution/)() const | Gets or sets the vertical resolution for the generated images, in dots per inch.  |
| [set_HorizontalResolution](./set_horizontalresolution/)(float) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_HorizontalResolution.  |
| [set_ImageBrightness](./set_imagebrightness/)(float) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_ImageBrightness.  |
| [set_ImageColorMode](./set_imagecolormode/)(Aspose::Words::Saving::ImageColorMode) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_ImageColorMode.  |
| [set_ImageContrast](./set_imagecontrast/)(float) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_ImageContrast.  |
| [set_JpegQuality](./set_jpegquality/)(int32_t) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_JpegQuality.  |
| [set_PageSet](./set_pageset/)(const System::SharedPtr< Aspose::Words::Saving::PageSet > &) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_PageSet.  |
| [set_PaperColor](./set_papercolor/)(System::Drawing::Color) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_PaperColor.  |
| [set_PixelFormat](./set_pixelformat/)(Aspose::Words::Saving::ImagePixelFormat) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_PixelFormat.  |
| [set_Resolution](./set_resolution/)(float) | Sets both horizontal and vertical resolution for the generated images, in dots per inch.  |
| [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::ImageSaveOptions::get_SaveFormat.  |
| [set_Scale](./set_scale/)(float) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_Scale.  |
| [set_ThresholdForFloydSteinbergDithering](./set_thresholdforfloydsteinbergdithering/)(uint8_t) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_ThresholdForFloydSteinbergDithering.  |
| [set_TiffBinarizationMethod](./set_tiffbinarizationmethod/)(Aspose::Words::Saving::ImageBinarizationMethod) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_TiffBinarizationMethod.  |
| [set_TiffCompression](./set_tiffcompression/)(Aspose::Words::Saving::TiffCompression) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_TiffCompression.  |
| [set_UseGdiEmfRenderer](./set_usegdiemfrenderer/)(bool) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_UseGdiEmfRenderer.  |
| [set_VerticalResolution](./set_verticalresolution/)(float) | Setter for Aspose::Words::Saving::ImageSaveOptions::get_VerticalResolution.  |
