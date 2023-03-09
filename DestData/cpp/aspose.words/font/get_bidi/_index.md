---
title: Aspose::Words::Font::get_Bidi method
linktitle: get_Bidi
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Font::get_Bidi method. Specifies whether the contents of this run shall have right-to-left characteristics in C++.
type: docs
weight: 40
url: /cpp/aspose.words/font/get_bidi/
---
## Font::get_Bidi method


Specifies whether the contents of this run shall have right-to-left characteristics.

```cpp
bool Aspose::Words::Font::get_Bidi()
```

## Remarks


This property, when on, shall not be used with strongly left-to-right text. Any behavior under that condition is unspecified. This property, when off, shall not be used with strong right-to-left text. Any behavior under that condition is unspecified.

When the contents of this run are displayed, all characters shall be treated as complex script characters for formatting purposes. This means that [BoldBi](../get_boldbi/), [ItalicBi](../get_italicbi/), [SizeBi](../get_sizebi/) and a corresponding font name will be used when rendering this run.

Also, when the contents of this run are displayed, this property acts as a right-to-left override for characters which are classified as "weak types" and "neutral types".

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

## See Also

* Class [Font](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
