---
title: LoadFormat
second_title: Aspose.Words for C++ API Reference
description: Indicates the format of the document that is to be loaded. 
type: docs
weight: 0
url: /cpp/aspose.words/loadformat/
---
## LoadFormat enum


Indicates the format of the document that is to be loaded.


## Examples




Shows how save a web page as a .docx file. 
```cpp
const String url = u"https://www.aspose.com/";

{
    auto client = MakeObject<System::Net::WebClient>();
    {
        auto stream = MakeObject<System::IO::MemoryStream>(client->DownloadData(url));
        // The URL is used again as a baseUri to ensure that any relative image paths are retrieved correctly.
        auto options = MakeObject<LoadOptions>(LoadFormat::Html, u"", url);

        // Load the HTML document from stream and pass the LoadOptions object.
        auto doc = MakeObject<Document>(stream, options);

        // At this stage, we can read and edit the document's contents and then save it to the local file system.

        doc->Save(ArtifactsDir + u"Document.InsertHtmlFromWebPage.docx");
    }
}
```


Shows how to use the [FileFormatUtil](../fileformatutil/) methods to detect the format of a document. 
```cpp
// Load a document from a file that is missing a file extension, and then detect its file format.
{
    SharedPtr<System::IO::FileStream> docStream = System::IO::File::OpenRead(MyDir + u"Word document with missing file extension");
    SharedPtr<FileFormatInfo> info = FileFormatUtil::DetectFileFormat(docStream);
    LoadFormat loadFormat = info->get_LoadFormat();

    ASSERT_EQ(LoadFormat::Doc, loadFormat);

    // Below are two methods of converting a LoadFormat to its corresponding SaveFormat.
    // 1 -  Get the file extension string for the LoadFormat, then get the corresponding SaveFormat from that string:
    String fileExtension = FileFormatUtil::LoadFormatToExtension(loadFormat);
    SaveFormat saveFormat = FileFormatUtil::ExtensionToSaveFormat(fileExtension);

    // 2 -  Convert the LoadFormat directly to its SaveFormat:
    saveFormat = FileFormatUtil::LoadFormatToSaveFormat(loadFormat);

    // Load a document from the stream, and then save it to the automatically detected file extension.
    auto doc = MakeObject<Document>(docStream);

    ASSERT_EQ(u".doc", FileFormatUtil::SaveFormatToExtension(saveFormat));

    doc->Save(ArtifactsDir + u"File.SaveToDetectedFileFormat" + FileFormatUtil::SaveFormatToExtension(saveFormat));
}
```


Shows how to specify a base URI when opening an html document. 
```cpp
// Suppose we want to load an .html document that contains an image linked by a relative URI
// while the image is in a different location. In that case, we will need to resolve the relative URI into an absolute one.
// We can provide a base URI using an HtmlLoadOptions object.
auto loadOptions = MakeObject<HtmlLoadOptions>(LoadFormat::Html, u"", ImageDir);

ASSERT_EQ(LoadFormat::Html, loadOptions->get_LoadFormat());

auto doc = MakeObject<Document>(MyDir + u"Missing image.html", loadOptions);

// While the image was broken in the input .html, our custom base URI helped us repair the link.
auto imageShape = System::DynamicCast<Shape>(doc->GetChildNodes(NodeType::Shape, true)->idx_get(0));
ASSERT_TRUE(imageShape->get_IsImage());

// This output document will display the image that was missing.
doc->Save(ArtifactsDir + u"HtmlLoadOptions.BaseUri.docx");
```

