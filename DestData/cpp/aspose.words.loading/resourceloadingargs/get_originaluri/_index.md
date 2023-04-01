---
title: Aspose::Words::Loading::ResourceLoadingArgs::get_OriginalUri method
linktitle: get_OriginalUri
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Loading::ResourceLoadingArgs::get_OriginalUri method. Original URI of the resource as specified in imported document in C++.'
type: docs
weight: 100
url: /cpp/aspose.words.loading/resourceloadingargs/get_originaluri/
---
## ResourceLoadingArgs::get_OriginalUri method


Original URI of the resource as specified in imported document.

```cpp
System::String Aspose::Words::Loading::ResourceLoadingArgs::get_OriginalUri() const
```


## Examples



Shows how to customize the process of loading external resources into a document. 
```cpp
void ResourceLoadingCallback()
{
    auto doc = MakeObject<Document>();
    doc->set_ResourceLoadingCallback(MakeObject<ExDocumentBase::ImageNameHandler>());

    auto builder = MakeObject<DocumentBuilder>(doc);

    // Images usually are inserted using a URI, or a byte array.
    // Every instance of a resource load will call our callback's ResourceLoading method.
    builder->InsertImage(u"Google logo");
    builder->InsertImage(u"Aspose logo");
    builder->InsertImage(u"Watermark");

    ASSERT_EQ(3, doc->GetChildNodes(NodeType::Shape, true)->get_Count());

    doc->Save(ArtifactsDir + u"DocumentBase.ResourceLoadingCallback.docx");
}

class ImageNameHandler : public IResourceLoadingCallback
{
public:
    ResourceLoadingAction ResourceLoading(SharedPtr<ResourceLoadingArgs> args) override
    {
        // If this callback encounters one of the image shorthands while loading an image,
        // it will apply unique logic for each defined shorthand instead of treating it as a URI.
        if (args->get_ResourceType() == ResourceType::Image)
        {
            String imageUri = args->get_OriginalUri();
            if (imageUri == u"Google logo")
            {
                {
                    auto webClient = MakeObject<System::Net::WebClient>();
                    args->SetData(webClient->DownloadData(u"http://www.google.com/images/logos/ps_logo2.png"));
                }
                return ResourceLoadingAction::UserProvided;
            }
            else if (imageUri == u"Aspose logo")
            {
                args->SetData(System::IO::File::ReadAllBytes(ImageDir + u"Logo.jpg"));
                return ResourceLoadingAction::UserProvided;
            }
            else if (imageUri == u"Watermark")
            {
                args->SetData(System::IO::File::ReadAllBytes(ImageDir + u"Transparent background logo.png"));
                return ResourceLoadingAction::UserProvided;
            }
        }
        return ResourceLoadingAction::Default;
    }
};
```

## See Also

* Class [ResourceLoadingArgs](../)
* Namespace [Aspose::Words::Loading](../../)
* Library [Aspose.Words for C++](../../../)
