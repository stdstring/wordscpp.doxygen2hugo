---
title: Underline
second_title: Aspose.Words for C++ API Reference
description: Indicates type of the underline applied to a font. 
type: docs
weight: 1626
url: /cpp/aspose.words/underline/
---
## Underline enum


Indicates type of the underline applied to a font.

### Values

| Name | Value | Description |
| --- | --- | --- |
| None | `0` |  |
| Single | `0` |  |
| Words | `0` |  |
| Double | `0` |  |
| Dotted | `0` |  |
| Thick | `0` |  |
| Dash | `0` |  |
| DashLong | `0` |  |
| DotDash | `0` |  |
| DotDotDash | `0` |  |
| Wavy | `0` |  |
| DottedHeavy | `0` |  |
| DashHeavy | `0` |  |
| DashLongHeavy | `0` |  |
| DotDashHeavy | `0` |  |
| DotDotDashHeavy | `0` |  |
| WavyHeavy | `0` |  |
| WavyDouble | `0` |  |


## Examples




Shows how to insert a hyperlink field. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->Write(u"For more information, please visit the ");

// Insert a hyperlink and emphasize it with custom formatting.
// The hyperlink will be a clickable piece of text which will take us to the location specified in the URL.
builder->get_Font()->set_Color(System::Drawing::Color::get_Blue());
builder->get_Font()->set_Underline(Underline::Single);
builder->InsertHyperlink(u"Google website", u"https://www.google.com", false);
builder->get_Font()->ClearFormatting();
builder->Writeln(u".");

// Ctrl + left clicking the link in the text in Microsoft Word will take us to the URL via a new web browser window.
doc->Save(ArtifactsDir + u"DocumentBuilder.InsertHyperlink.docx");
```

