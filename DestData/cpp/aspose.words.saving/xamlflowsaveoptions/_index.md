---
title: XamlFlowSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the XamlFlow or XamlFlowPack format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/xamlflowsaveoptions/
---
## XamlFlowSaveOptions class


Can be used to specify additional options when saving a document into the XamlFlow or XamlFlowPack format. 

## Methods

| Method | Description |
| --- | --- |
|  [XamlFlowSaveOptions](./xamlflowsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the XamlFlow format.  |
|  [XamlFlowSaveOptions](./xamlflowsaveoptions/)(Aspose::Words::SaveFormat) | Initializes a new instance of this class that can be used to save a document in the XamlFlow or XamlFlowPack format.  |
| System::SharedPtr< Aspose::Words::Saving::IImageSavingCallback > [get_ImageSavingCallback](./get_imagesavingcallback/)() const | Allows to control how images are saved when a document is saved to XAML.  |
| System::String [get_ImagesFolder](./get_imagesfolder/)() const | Specifies the physical folder where images are saved when exporting a document to XAML format. Default is an empty string.  |
| System::String [get_ImagesFolderAlias](./get_imagesfolderalias/)() const | Specifies the name of the folder used to construct image URIs written into an XAML document. Default is an empty string.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be XamlFlow.  |
| void [set_ImageSavingCallback](./set_imagesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IImageSavingCallback > &) | Setter for Aspose::Words::Saving::XamlFlowSaveOptions::get_ImageSavingCallback.  |
| void [set_ImagesFolder](./set_imagesfolder/)(const System::String &) | Setter for Aspose::Words::Saving::XamlFlowSaveOptions::get_ImagesFolder.  |
| void [set_ImagesFolderAlias](./set_imagesfolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::XamlFlowSaveOptions::get_ImagesFolderAlias.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::XamlFlowSaveOptions::get_SaveFormat.  |
