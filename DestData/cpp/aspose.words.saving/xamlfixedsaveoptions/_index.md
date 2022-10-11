---
title: XamlFixedSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the XamlFixed format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/xamlfixedsaveoptions/
---
## XamlFixedSaveOptions class


Can be used to specify additional options when saving a document into the XamlFixed format. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Saving::IResourceSavingCallback > [get_ResourceSavingCallback](./get_resourcesavingcallback/)() const | Allows to control how resources (images and fonts) are saved when a document is exported to fixed page Xaml format.  |
| System::String [get_ResourcesFolder](./get_resourcesfolder/)() const | Specifies the physical folder where resources (images and fonts) are saved when exporting a document to fixed page Xaml format. Default is **null**.  |
| System::String [get_ResourcesFolderAlias](./get_resourcesfolderalias/)() const | Specifies the name of the folder used to construct image URIs written into an fixed page Xaml document. Default is **null**.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be XamlFixed.  |
| void [set_ResourceSavingCallback](./set_resourcesavingcallback/)(const System::SharedPtr< Aspose::Words::Saving::IResourceSavingCallback > &) | Setter for Aspose::Words::Saving::XamlFixedSaveOptions::get_ResourceSavingCallback.  |
| void [set_ResourcesFolder](./set_resourcesfolder/)(const System::String &) | Setter for Aspose::Words::Saving::XamlFixedSaveOptions::get_ResourcesFolder.  |
| void [set_ResourcesFolderAlias](./set_resourcesfolderalias/)(const System::String &) | Setter for Aspose::Words::Saving::XamlFixedSaveOptions::get_ResourcesFolderAlias.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::XamlFixedSaveOptions::get_SaveFormat.  |
