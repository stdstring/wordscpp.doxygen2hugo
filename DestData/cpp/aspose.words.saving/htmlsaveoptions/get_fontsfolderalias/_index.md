---
title: get_FontsFolderAlias
second_title: Aspose.Words for C++ API Reference
description: Specifies the name of the folder used to construct font URIs written into an HTML document. Default is an empty string.
type: docs
weight: 417
url: /cpp/aspose.words.saving/htmlsaveoptions/get_fontsfolderalias/
---
## HtmlSaveOptions::get_FontsFolderAlias method


Specifies the name of the folder used to construct font URIs written into an HTML document. Default is an empty string.

```cpp
System::String Aspose::Words::Saving::HtmlSaveOptions::get_FontsFolderAlias() const
```


When you save a [Document](../../../aspose.words/document/) in HTML format and [ExportFontResources](../get_exportfontresources/) is set to **true**, Aspose.Words needs to save fonts used in the document as standalone files. [FontsFolder](../get_fontsfolder/) allows you to specify where the fonts will be saved and [FontsFolderAlias](./) allows to specify how the font URIs will be constructed.

If [FontsFolderAlias](./) is not an empty string, then the font URI written to HTML will be FontsFolderAlias + <font file name>.

If [FontsFolderAlias](./) is an empty string, then the font URI written to HTML will be FontsFolder + <font file name>.

If [FontsFolderAlias](./) is set to '.' (dot), then the font file name will be written to HTML without path regardless of other options.

Alternative way to specify the name of the folder to construct font URIs is to use [ResourceFolderAlias](../get_resourcefolderalias/).

## Examples




Shows how to set folders and folder aliases for externally saved resources that Aspose.Words will create when saving a document to HTML. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");

auto options = MakeObject<HtmlSaveOptions>();
options->set_CssStyleSheetType(CssStyleSheetType::External);
options->set_ExportFontResources(true);
options->set_ImageResolution(72);
options->set_FontResourcesSubsettingSizeThreshold(0);
options->set_FontsFolder(ArtifactsDir + u"Fonts");
options->set_ImagesFolder(ArtifactsDir + u"Images");
options->set_ResourceFolder(ArtifactsDir + u"Resources");
options->set_FontsFolderAlias(u"http://example.com/fonts");
options->set_ImagesFolderAlias(u"http://example.com/images");
options->set_ResourceFolderAlias(u"http://example.com/resources");
options->set_ExportOriginalUrlForLinkedImages(true);

doc->Save(ArtifactsDir + u"HtmlSaveOptions.FolderAlias.html", options);
```

