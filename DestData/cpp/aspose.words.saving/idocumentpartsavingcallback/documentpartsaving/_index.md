---
title: DocumentPartSaving
second_title: Aspose.Words for C++ API Reference
description: Called when Aspose.Words is about to save a document part.
type: docs
weight: 1
url: /cpp/aspose.words.saving/idocumentpartsavingcallback/documentpartsaving/
---
## IDocumentPartSavingCallback::DocumentPartSaving method


Called when Aspose.Words is about to save a document part.

```cpp
virtual void Aspose::Words::Saving::IDocumentPartSavingCallback::DocumentPartSaving(System::SharedPtr<Aspose::Words::Saving::DocumentPartSavingArgs> args)=0
```


## Examples



Shows how to split a document into parts and save them. 
```cpp
void DocumentPartsFileNames()
{
    auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");
    String outFileName = u"SavingCallback.DocumentPartsFileNames.html";

    // Create an "HtmlFixedSaveOptions" object, which we can pass to the document's "Save" method
    // to modify how we convert the document to HTML.
    auto options = MakeObject<HtmlSaveOptions>();

    // If we save the document normally, there will be one output HTML
    // document with all the source document's contents.
    // Set the "DocumentSplitCriteria" property to "DocumentSplitCriteria.SectionBreak" to
    // save our document to multiple HTML files: one for each section.
    options->set_DocumentSplitCriteria(DocumentSplitCriteria::SectionBreak);

    // Assign a custom callback to the "DocumentPartSavingCallback" property to alter the document part saving logic.
    options->set_DocumentPartSavingCallback(MakeObject<ExSavingCallback::SavedDocumentPartRename>(outFileName, options->get_DocumentSplitCriteria()));

    // If we convert a document that contains images into html, we will end up with one html file which links to several images.
    // Each image will be in the form of a file in the local file system.
    // There is also a callback that can customize the name and file system location of each image.
    options->set_ImageSavingCallback(MakeObject<ExSavingCallback::SavedImageRename>(outFileName));

    doc->Save(ArtifactsDir + outFileName, options);
}

class SavedDocumentPartRename : public IDocumentPartSavingCallback
{
public:
    SavedDocumentPartRename(String outFileName, DocumentSplitCriteria documentSplitCriteria)
        : mCount(0), mDocumentSplitCriteria(((Aspose::Words::Saving::DocumentSplitCriteria)0))
    {
        mOutFileName = outFileName;
        mDocumentSplitCriteria = documentSplitCriteria;
    }

private:
    int mCount;
    String mOutFileName;
    DocumentSplitCriteria mDocumentSplitCriteria;

    void DocumentPartSaving(SharedPtr<DocumentPartSavingArgs> args) override
    {
        // We can access the entire source document via the "Document" property.
        ASSERT_TRUE(args->get_Document()->get_OriginalFileName().EndsWith(u"Rendering.docx"));

        String partType = String::Empty;

        switch (mDocumentSplitCriteria)
        {
        case DocumentSplitCriteria::PageBreak:
            partType = u"Page";
            break;

        case DocumentSplitCriteria::ColumnBreak:
            partType = u"Column";
            break;

        case DocumentSplitCriteria::SectionBreak:
            partType = u"Section";
            break;

        case DocumentSplitCriteria::HeadingParagraph:
            partType = u"Paragraph from heading";
            break;

        default:
            break;
        }

        String partFileName = String::Format(u"{0} part {1}, of type {2}{3}", mOutFileName, ++mCount, partType,
                                             System::IO::Path::GetExtension(args->get_DocumentPartFileName()));

        // Below are two ways of specifying where Aspose.Words will save each part of the document.
        // 1 -  Set a filename for the output part file:
        args->set_DocumentPartFileName(partFileName);

        // 2 -  Create a custom stream for the output part file:
        args->set_DocumentPartStream(MakeObject<System::IO::FileStream>(ArtifactsDir + partFileName, System::IO::FileMode::Create));

        ASSERT_TRUE(args->get_DocumentPartStream()->get_CanWrite());
        ASSERT_FALSE(args->get_KeepDocumentPartStreamOpen());
    }
};

class SavedImageRename : public IImageSavingCallback
{
public:
    SavedImageRename(String outFileName) : mCount(0)
    {
        mOutFileName = outFileName;
    }

private:
    int mCount;
    String mOutFileName;

    void ImageSaving(SharedPtr<ImageSavingArgs> args) override
    {
        String imageFileName = String::Format(u"{0} shape {1}, of type {2}{3}", mOutFileName, ++mCount, args->get_CurrentShape()->get_ShapeType(),
                                              System::IO::Path::GetExtension(args->get_ImageFileName()));

        // Below are two ways of specifying where Aspose.Words will save each part of the document.
        // 1 -  Set a filename for the output image file:
        args->set_ImageFileName(imageFileName);

        // 2 -  Create a custom stream for the output image file:
        args->set_ImageStream(MakeObject<System::IO::FileStream>(ArtifactsDir + imageFileName, System::IO::FileMode::Create));

        ASSERT_TRUE(args->get_ImageStream()->get_CanWrite());
        ASSERT_TRUE(args->get_IsImageAvailable());
        ASSERT_FALSE(args->get_KeepImageStreamOpen());
    }
};
```

