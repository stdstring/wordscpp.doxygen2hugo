---
title: Aspose::Words::Saving::HtmlSaveOptions::get_ExportXhtmlTransitional method
linktitle: get_ExportXhtmlTransitional
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Saving::HtmlSaveOptions::get_ExportXhtmlTransitional method. Specifies whether to write the DOCTYPE declaration when saving to HTML or MHTML. When true, writes a DOCTYPE declaration in the document prior to the root element. Default value is false. When saving to EPUB or HTML5 (Html5) the DOCTYPE declaration is always written in C++.
type: docs
weight: 365
url: /cpp/aspose.words.saving/htmlsaveoptions/get_exportxhtmltransitional/
---
## HtmlSaveOptions::get_ExportXhtmlTransitional method


Specifies whether to write the DOCTYPE declaration when saving to HTML or MHTML. When **true**, writes a DOCTYPE declaration in the document prior to the root element. Default value is **false**. When saving to EPUB or HTML5 ([Html5](../../htmlversion/)) the DOCTYPE declaration is always written.

```cpp
bool Aspose::Words::Saving::HtmlSaveOptions::get_ExportXhtmlTransitional() const
```

## Remarks


Aspose.Words always writes well formed HTML regardless of this setting.

When **true**, the beginning of the HTML output document will look like this:


```cpp
<?xml version="1.0" encoding="utf-8" standalone="no" ?>
            <!DOCTYPE html
                  PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
            "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
            <html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en">
```


Aspose.Words aims to output XHTML according to the XHTML 1.0 Transitional specification, but the output will not always validate against the DTD. Some structures inside a Microsoft Word document are hard or impossible to map to a document that will validate against the XHTML schema. For example, XHTML does not allow nested lists (UL cannot be nested inside another UL element), but in Microsoft Word document multilevel lists occur quite often.

## Examples



Shows how to display a DOCTYPE heading when converting documents to the Xhtml 1.0 transitional standard. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->Writeln(u"Hello world!");

auto options = MakeObject<HtmlSaveOptions>(SaveFormat::Html);
options->set_HtmlVersion(HtmlVersion::Xhtml);
options->set_ExportXhtmlTransitional(showDoctypeDeclaration);
options->set_PrettyFormat(true);

doc->Save(ArtifactsDir + u"HtmlSaveOptions.ExportXhtmlTransitional.html", options);

// Our document will only contain a DOCTYPE declaration heading if we have set the "ExportXhtmlTransitional" flag to "true".
String outDocContents = System::IO::File::ReadAllText(ArtifactsDir + u"HtmlSaveOptions.ExportXhtmlTransitional.html");

if (showDoctypeDeclaration)
{
    ASSERT_TRUE(outDocContents.Contains(String(u"<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"no\"?>\r\n") +
                                        u"<!DOCTYPE html PUBLIC \"-//W3C//DTD XHTML 1.0 Transitional//EN\" "
                                        u"\"http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd\">\r\n" +
                                        u"<html xmlns=\"http://www.w3.org/1999/xhtml\">"));
}
else
{
    ASSERT_TRUE(outDocContents.Contains(u"<html>"));
}
```

## See Also

* Class [HtmlSaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
