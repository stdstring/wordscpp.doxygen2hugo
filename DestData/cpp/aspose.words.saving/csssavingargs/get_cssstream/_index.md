---
title: Aspose::Words::Saving::CssSavingArgs::get_CssStream method
linktitle: get_CssStream
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Saving::CssSavingArgs::get_CssStream method. Allows to specify the stream where the CSS information will be saved to in C++.
type: docs
weight: 100
url: /cpp/aspose.words.saving/csssavingargs/get_cssstream/
---
## CssSavingArgs::get_CssStream method


Allows to specify the stream where the CSS information will be saved to.

```cpp
System::SharedPtr<System::IO::Stream> Aspose::Words::Saving::CssSavingArgs::get_CssStream() const
```

## Remarks


This property allows you to save CSS information to a stream.

The default value is **null**. This property doesn't suppress saving CSS information to a file or embedding to HTML document. To suppress exporting CSS use the [IsExportNeeded](../get_isexportneeded/) property.

Using [ICssSavingCallback](../../icsssavingcallback/) you cannot substitute CSS with another. It is intended only for saving CSS to a stream.

## Examples



Shows how to work with CSS stylesheets that an HTML conversion creates. 
```cpp
void ExternalCssFilenames()
{
    auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");

    // Create an "HtmlFixedSaveOptions" object, which we can pass to the document's "Save" method
    // to modify how we convert the document to HTML.
    auto options = MakeObject<HtmlSaveOptions>();

    // Set the "CssStylesheetType" property to "CssStyleSheetType.External" to
    // accompany a saved HTML document with an external CSS stylesheet file.
    options->set_CssStyleSheetType(CssStyleSheetType::External);

    // Below are two ways of specifying directories and filenames for output CSS stylesheets.
    // 1 -  Use the "CssStyleSheetFileName" property to assign a filename to our stylesheet:
    options->set_CssStyleSheetFileName(ArtifactsDir + u"SavingCallback.ExternalCssFilenames.css");

    // 2 -  Use a custom callback to name our stylesheet:
    options->set_CssSavingCallback(
        MakeObject<ExSavingCallback::CustomCssSavingCallback>(ArtifactsDir + u"SavingCallback.ExternalCssFilenames.css", true, false));

    doc->Save(ArtifactsDir + u"SavingCallback.ExternalCssFilenames.html", options);
}

class CustomCssSavingCallback : public ICssSavingCallback
{
public:
    CustomCssSavingCallback(String cssDocFilename, bool isExportNeeded, bool keepCssStreamOpen) : mIsExportNeeded(false), mKeepCssStreamOpen(false)
    {
        mCssTextFileName = cssDocFilename;
        mIsExportNeeded = isExportNeeded;
        mKeepCssStreamOpen = keepCssStreamOpen;
    }

    void CssSaving(SharedPtr<CssSavingArgs> args) override
    {
        // We can access the entire source document via the "Document" property.
        ASSERT_TRUE(args->get_Document()->get_OriginalFileName().EndsWith(u"Rendering.docx"));

        args->set_CssStream(MakeObject<System::IO::FileStream>(mCssTextFileName, System::IO::FileMode::Create));
        args->set_IsExportNeeded(mIsExportNeeded);
        args->set_KeepCssStreamOpen(mKeepCssStreamOpen);

        ASSERT_TRUE(args->get_CssStream()->get_CanWrite());
    }

private:
    String mCssTextFileName;
    bool mIsExportNeeded;
    bool mKeepCssStreamOpen;
};
```

## See Also

* Class [CssSavingArgs](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
