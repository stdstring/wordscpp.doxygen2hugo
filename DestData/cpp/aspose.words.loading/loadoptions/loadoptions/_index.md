---
title: LoadOptions
second_title: Aspose.Words for C++ API Reference
description: Initializes a new instance of this class with default values. 
type: docs
weight: 0
url: /cpp/aspose.words.loading/loadoptions/loadoptions/
---
## LoadOptions.LoadOptions() method


Initializes a new instance of this class with default values.

```cpp
Aspose::Words::Loading::LoadOptions::LoadOptions()
```


## Examples




Shows how to open an HTML document with images from a stream using a base URI. 
```cpp
{
    SharedPtr<System::IO::Stream> stream = System::IO::File::OpenRead(MyDir + u"Document.html");
    // Pass the URI of the base folder while loading it
    // so that any images with relative URIs in the HTML document can be found.
    auto loadOptions = MakeObject<LoadOptions>();
    loadOptions->set_BaseUri(ImageDir);

    auto doc = MakeObject<Document>(stream, loadOptions);

    // Verify that the first shape of the document contains a valid image.
    auto shape = System::DynamicCast<Shape>(doc->GetChild(NodeType::Shape, 0, true));

    ASSERT_TRUE(shape->get_IsImage());
    ASSERT_FALSE(shape->get_ImageData()->get_ImageBytes() == nullptr);
    ASSERT_NEAR(32.0, ConvertUtil::PointToPixel(shape->get_Width()), 0.01);
    ASSERT_NEAR(32.0, ConvertUtil::PointToPixel(shape->get_Height()), 0.01);
}
```

## LoadOptions.LoadOptions(Aspose::Words::LoadFormat, const System::String\&, const System::String\&) method


A shortcut to initialize a new instance of this class with properties set to the specified values.

```cpp
Aspose::Words::Loading::LoadOptions::LoadOptions(Aspose::Words::LoadFormat loadFormat, const System::String &password, const System::String &baseUri)
```


| Parameter | Type | Description |
| --- | --- | --- |
| loadFormat | Aspose::Words::LoadFormat | The format of the document to be loaded. |
| password | const System::String\& | The password to open an encrypted document. Can be null or empty string. |
| baseUri | const System::String\& | The string that will be used to resolve relative URIs to absolute. Can be null or empty string. |

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

## LoadOptions.LoadOptions(const System::String\&) method


A shortcut to initialize a new instance of this class with the specified password to load an encrypted document.

```cpp
Aspose::Words::Loading::LoadOptions::LoadOptions(const System::String &password)
```


| Parameter | Type | Description |
| --- | --- | --- |
| password | const System::String\& | The password to open an encrypted document. Can be null or empty string. |

## Examples




Shows how to load an encrypted Microsoft Word document. 
```cpp
SharedPtr<Document> doc;

// Aspose.Words throw an exception if we try to open an encrypted document without its password.
ASSERT_THROW(doc = MakeObject<Document>(MyDir + u"Encrypted.docx"), IncorrectPasswordException);

// When loading such a document, the password is passed to the document's constructor using a LoadOptions object.
auto options = MakeObject<LoadOptions>(u"docPassword");

// There are two ways of loading an encrypted document with a LoadOptions object.
// 1 -  Load the document from the local file system by filename:
doc = MakeObject<Document>(MyDir + u"Encrypted.docx", options);

// 2 -  Load the document from a stream:
{
    SharedPtr<System::IO::Stream> stream = System::IO::File::OpenRead(MyDir + u"Encrypted.docx");
    doc = MakeObject<Document>(stream, options);
}
```

