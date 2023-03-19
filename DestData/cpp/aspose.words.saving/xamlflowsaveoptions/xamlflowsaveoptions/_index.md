---
title: Aspose::Words::Saving::XamlFlowSaveOptions::XamlFlowSaveOptions constructor
linktitle: XamlFlowSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Saving::XamlFlowSaveOptions::XamlFlowSaveOptions constructor. Initializes a new instance of this class that can be used to save a document in the XamlFlow format in C++.
type: docs
weight: 100
url: /cpp/aspose.words.saving/xamlflowsaveoptions/xamlflowsaveoptions/
---
## XamlFlowSaveOptions::XamlFlowSaveOptions() constructor


Initializes a new instance of this class that can be used to save a document in the [XamlFlow](../../../aspose.words/saveformat/) format.

```cpp
Aspose::Words::Saving::XamlFlowSaveOptions::XamlFlowSaveOptions()
```


## Examples



Shows how to print the filenames of linked images created while converting a document to flow-form .xaml. 
```cpp
void ImageFolder()
{
    auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");

    auto callback = MakeObject<ExXamlFlowSaveOptions::ImageUriPrinter>(ArtifactsDir + u"XamlFlowImageFolderAlias");

    // Create a "XamlFlowSaveOptions" object, which we can pass to the document's "Save" method
    // to modify how we save the document to the XAML save format.
    auto options = MakeObject<XamlFlowSaveOptions>();

    ASSERT_EQ(SaveFormat::XamlFlow, options->get_SaveFormat());

    // Use the "ImagesFolder" property to assign a folder in the local file system into which
    // Aspose.Words will save all the document's linked images.
    options->set_ImagesFolder(ArtifactsDir + u"XamlFlowImageFolder");

    // Use the "ImagesFolderAlias" property to use this folder
    // when constructing image URIs instead of the images folder's name.
    options->set_ImagesFolderAlias(ArtifactsDir + u"XamlFlowImageFolderAlias");

    options->set_ImageSavingCallback(callback);

    // A folder specified by "ImagesFolderAlias" will need to contain the resources instead of "ImagesFolder".
    // We must ensure the folder exists before the callback's streams can put their resources into it.
    System::IO::Directory::CreateDirectory_(options->get_ImagesFolderAlias());

    doc->Save(ArtifactsDir + u"XamlFlowSaveOptions.ImageFolder.xaml", options);

    for (const auto& resource : callback->get_Resources())
    {
        std::cout << callback->get_ImagesFolderAlias() << "/" << resource << std::endl;
    }
}

class ImageUriPrinter : public IImageSavingCallback
{
public:
    String get_ImagesFolderAlias()
    {
        return pr_ImagesFolderAlias;
    }

    SharedPtr<System::Collections::Generic::List<String>> get_Resources()
    {
        return pr_Resources;
    }

    ImageUriPrinter(String imagesFolderAlias)
    {
        pr_ImagesFolderAlias = imagesFolderAlias;
        pr_Resources = MakeObject<System::Collections::Generic::List<String>>();
    }

private:
    String pr_ImagesFolderAlias;
    SharedPtr<System::Collections::Generic::List<String>> pr_Resources;

    void ImageSaving(SharedPtr<ImageSavingArgs> args) override
    {
        get_Resources()->Add(args->get_ImageFileName());

        // If we specified an image folder alias, we would also need
        // to redirect each stream to put its image in the alias folder.
        args->set_ImageStream(MakeObject<System::IO::FileStream>(String::Format(u"{0}/{1}", get_ImagesFolderAlias(), args->get_ImageFileName()),
                                                                 System::IO::FileMode::Create));
        args->set_KeepImageStreamOpen(false);
    }
};
```

## See Also

* Class [XamlFlowSaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
## XamlFlowSaveOptions::XamlFlowSaveOptions(Aspose::Words::SaveFormat) constructor


Initializes a new instance of this class that can be used to save a document in the [XamlFlow](../../../aspose.words/saveformat/) or [XamlFlowPack](../../../aspose.words/saveformat/) format.

```cpp
Aspose::Words::Saving::XamlFlowSaveOptions::XamlFlowSaveOptions(Aspose::Words::SaveFormat saveFormat)
```


| Parameter | Type | Description |
| --- | --- | --- |
| saveFormat | Aspose::Words::SaveFormat | Can be [XamlFlow](../../../aspose.words/saveformat/) or [XamlFlowPack](../../../aspose.words/saveformat/). |

## Examples



Shows how to print the filenames of linked images created while converting a document to flow-form .xaml. 
```cpp
void ImageFolder()
{
    auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");

    auto callback = MakeObject<ExXamlFlowSaveOptions::ImageUriPrinter>(ArtifactsDir + u"XamlFlowImageFolderAlias");

    // Create a "XamlFlowSaveOptions" object, which we can pass to the document's "Save" method
    // to modify how we save the document to the XAML save format.
    auto options = MakeObject<XamlFlowSaveOptions>();

    ASSERT_EQ(SaveFormat::XamlFlow, options->get_SaveFormat());

    // Use the "ImagesFolder" property to assign a folder in the local file system into which
    // Aspose.Words will save all the document's linked images.
    options->set_ImagesFolder(ArtifactsDir + u"XamlFlowImageFolder");

    // Use the "ImagesFolderAlias" property to use this folder
    // when constructing image URIs instead of the images folder's name.
    options->set_ImagesFolderAlias(ArtifactsDir + u"XamlFlowImageFolderAlias");

    options->set_ImageSavingCallback(callback);

    // A folder specified by "ImagesFolderAlias" will need to contain the resources instead of "ImagesFolder".
    // We must ensure the folder exists before the callback's streams can put their resources into it.
    System::IO::Directory::CreateDirectory_(options->get_ImagesFolderAlias());

    doc->Save(ArtifactsDir + u"XamlFlowSaveOptions.ImageFolder.xaml", options);

    for (const auto& resource : callback->get_Resources())
    {
        std::cout << callback->get_ImagesFolderAlias() << "/" << resource << std::endl;
    }
}

class ImageUriPrinter : public IImageSavingCallback
{
public:
    String get_ImagesFolderAlias()
    {
        return pr_ImagesFolderAlias;
    }

    SharedPtr<System::Collections::Generic::List<String>> get_Resources()
    {
        return pr_Resources;
    }

    ImageUriPrinter(String imagesFolderAlias)
    {
        pr_ImagesFolderAlias = imagesFolderAlias;
        pr_Resources = MakeObject<System::Collections::Generic::List<String>>();
    }

private:
    String pr_ImagesFolderAlias;
    SharedPtr<System::Collections::Generic::List<String>> pr_Resources;

    void ImageSaving(SharedPtr<ImageSavingArgs> args) override
    {
        get_Resources()->Add(args->get_ImageFileName());

        // If we specified an image folder alias, we would also need
        // to redirect each stream to put its image in the alias folder.
        args->set_ImageStream(MakeObject<System::IO::FileStream>(String::Format(u"{0}/{1}", get_ImagesFolderAlias(), args->get_ImageFileName()),
                                                                 System::IO::FileMode::Create));
        args->set_KeepImageStreamOpen(false);
    }
};
```

## See Also

* Enum [SaveFormat](../../../aspose.words/saveformat/)
* Class [XamlFlowSaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
