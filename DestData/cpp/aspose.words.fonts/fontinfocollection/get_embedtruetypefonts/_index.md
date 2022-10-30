---
title: get_EmbedTrueTypeFonts
second_title: Aspose.Words for C++ API Reference
description: Specifies whether or not to embed TrueType fonts in a document when it is saved. Default value for this property is false.
type: docs
weight: 92
url: /cpp/aspose.words.fonts/fontinfocollection/get_embedtruetypefonts/
---
## FontInfoCollection::get_EmbedTrueTypeFonts method


Specifies whether or not to embed TrueType fonts in a document when it is saved. Default value for this property is **false**.

```cpp
bool Aspose::Words::Fonts::FontInfoCollection::get_EmbedTrueTypeFonts() const
```


Embedding TrueType fonts allows others to view the document with the same fonts that were used to create it, but may substantially increase the document size.

This option works for DOC, DOCX and RTF formats only.

## Examples




Shows how to save a document with embedded TrueType fonts. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Document.docx");

SharedPtr<Aspose::Words::Fonts::FontInfoCollection> fontInfos = doc->get_FontInfos();
fontInfos->set_EmbedTrueTypeFonts(embedAllFonts);
fontInfos->set_EmbedSystemFonts(embedAllFonts);
fontInfos->set_SaveSubsetFonts(embedAllFonts);

doc->Save(ArtifactsDir + u"Font.FontInfoCollection.docx");

if (embedAllFonts)
{
    ASSERT_LT(25000, MakeObject<System::IO::FileInfo>(ArtifactsDir + u"Font.FontInfoCollection.docx")->get_Length());
}
else
{
    ASSERT_GE(15000, MakeObject<System::IO::FileInfo>(ArtifactsDir + u"Font.FontInfoCollection.docx")->get_Length());
}
```

