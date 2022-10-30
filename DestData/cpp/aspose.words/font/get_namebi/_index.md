---
title: get_NameBi
second_title: Aspose.Words for C++ API Reference
description: Returns or sets the name of the font in a right-to-left language document.
type: docs
weight: 326
url: /cpp/aspose.words/font/get_namebi/
---
## Font::get_NameBi method


Returns or sets the name of the font in a right-to-left language document.

```cpp
System::String Aspose::Words::Font::get_NameBi()
```


## Examples




Shows how to define separate sets of font settings for right-to-left, and right-to-left text. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Define a set of font settings for left-to-right text.
builder->get_Font()->set_Name(u"Courier New");
builder->get_Font()->set_Size(16);
builder->get_Font()->set_Italic(false);
builder->get_Font()->set_Bold(false);
builder->get_Font()->set_LocaleId(MakeObject<System::Globalization::CultureInfo>(u"en-US", false)->get_LCID());

// Define another set of font settings for right-to-left text.
builder->get_Font()->set_NameBi(u"Andalus");
builder->get_Font()->set_SizeBi(24);
builder->get_Font()->set_ItalicBi(true);
builder->get_Font()->set_BoldBi(true);
builder->get_Font()->set_LocaleIdBi(MakeObject<System::Globalization::CultureInfo>(u"ar-AR", false)->get_LCID());

// We can use the Bidi flag to indicate whether the text we are about to add
// with the document builder is right-to-left. When we add text with this flag set to true,
// it will be formatted using the right-to-left set of font settings.
builder->get_Font()->set_Bidi(true);
builder->Write(u"مرحبًا");

// Set the flag to false, and then add left-to-right text.
// The document builder will format these using the left-to-right set of font settings.
builder->get_Font()->set_Bidi(false);
builder->Write(u" Hello world!");

doc->Save(ArtifactsDir + u"Font.Bidi.docx");
```

