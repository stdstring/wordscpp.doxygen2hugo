---
title: Aspose::Words::Saving::IPageSavingCallback::PageSaving method
linktitle: PageSaving
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Saving::IPageSavingCallback::PageSaving method. Called when Aspose.Words saves a separate page to fixed page formats in C++.'
type: docs
weight: 100
url: /cpp/aspose.words.saving/ipagesavingcallback/pagesaving/
---
## IPageSavingCallback::PageSaving method


Called when Aspose.Words saves a separate page to fixed page formats.

```cpp
virtual void Aspose::Words::Saving::IPageSavingCallback::PageSaving(System::SharedPtr<Aspose::Words::Saving::PageSavingArgs> args)=0
```


## Examples



Shows how to use a callback to save a document to HTML page by page. 
```cpp
void PageFileNames()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    builder->Writeln(u"Page 1.");
    builder->InsertBreak(BreakType::PageBreak);
    builder->Writeln(u"Page 2.");
    builder->InsertImage(ImageDir + u"Logo.jpg");
    builder->InsertBreak(BreakType::PageBreak);
    builder->Writeln(u"Page 3.");

    // Create an "HtmlFixedSaveOptions" object, which we can pass to the document's "Save" method
    // to modify how we convert the document to HTML.
    auto htmlFixedSaveOptions = MakeObject<HtmlFixedSaveOptions>();

    // We will save each page in this document to a separate HTML file in the local file system.
    // Set a callback that allows us to name each output HTML document.
    htmlFixedSaveOptions->set_PageSavingCallback(MakeObject<ExSavingCallback::CustomFileNamePageSavingCallback>());

    doc->Save(ArtifactsDir + u"SavingCallback.PageFileNames.html", htmlFixedSaveOptions);

    ArrayPtr<String> filePaths = System::IO::Directory::GetFiles(ArtifactsDir)
                                     ->LINQ_Where([](String s) { return s.StartsWith(ArtifactsDir + u"SavingCallback.PageFileNames.Page_"); })
                                     ->LINQ_ToArray();

    ASSERT_EQ(3, filePaths->get_Length());
}

class CustomFileNamePageSavingCallback : public IPageSavingCallback
{
public:
    void PageSaving(SharedPtr<PageSavingArgs> args) override
    {
        String outFileName = String::Format(u"{0}SavingCallback.PageFileNames.Page_{1}.html", ArtifactsDir, args->get_PageIndex());

        // Below are two ways of specifying where Aspose.Words will save each page of the document.
        // 1 -  Set a filename for the output page file:
        args->set_PageFileName(outFileName);

        // 2 -  Create a custom stream for the output page file:
        args->set_PageStream(MakeObject<System::IO::FileStream>(outFileName, System::IO::FileMode::Create));

        ASSERT_FALSE(args->get_KeepPageStreamOpen());
    }
};
```

## See Also

* Class [PageSavingArgs](../../pagesavingargs/)
* Interface [IPageSavingCallback](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
