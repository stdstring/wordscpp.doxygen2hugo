---
title: get_DoNotDisplayPageBoundaries
second_title: Aspose.Words for C++ API Reference
description: Turns off display of the space between the top of the text and the top edge of the page. 
type: docs
weight: 14
url: /cpp/aspose.words.settings/viewoptions/get_donotdisplaypageboundaries/
---
## ViewOptions.get_DoNotDisplayPageBoundaries method


Turns off display of the space between the top of the text and the top edge of the page.

```cpp
bool Aspose::Words::Settings::ViewOptions::get_DoNotDisplayPageBoundaries() const
```


## Examples




Shows how to hide vertical whitespace and headers/footers in view options. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert content that spans across 3 pages.
builder->Writeln(u"Paragraph 1, Page 1.");
builder->InsertBreak(BreakType::PageBreak);
builder->Writeln(u"Paragraph 2, Page 2.");
builder->InsertBreak(BreakType::PageBreak);
builder->Writeln(u"Paragraph 3, Page 3.");

// Insert a header and a footer.
builder->MoveToHeaderFooter(HeaderFooterType::HeaderPrimary);
builder->Writeln(u"This is the header.");
builder->MoveToHeaderFooter(HeaderFooterType::FooterPrimary);
builder->Writeln(u"This is the footer.");

// This document contains a small amount of content that takes up a few full pages worth of space.
// Set the "DoNotDisplayPageBoundaries" flag to "true" to get older versions of Microsoft Word to omit headers,
// footers, and much of the vertical whitespace when displaying our document.
// Set the "DoNotDisplayPageBoundaries" flag to "false" to get older versions of Microsoft Word
// to normally display our document.
doc->get_ViewOptions()->set_DoNotDisplayPageBoundaries(doNotDisplayPageBoundaries);

doc->Save(ArtifactsDir + u"ViewOptions.DisplayPageBoundaries.doc");
```

