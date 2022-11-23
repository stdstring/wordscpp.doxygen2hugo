---
title: InsertTableOfContents
second_title: Aspose.Words for C++ API Reference
description: Inserts a TOC (table of contents) field into the document.
type: docs
weight: 586
url: /cpp/aspose.words/documentbuilder/inserttableofcontents/
---
## DocumentBuilder::InsertTableOfContents method


Inserts a TOC (table of contents) field into the document.

```cpp
System::SharedPtr<Aspose::Words::Fields::Field> Aspose::Words::DocumentBuilder::InsertTableOfContents(const System::String &switches)
```


| Parameter | Type | Description |
| --- | --- | --- |
| switches | const System::String\& | The TOC field switches. |

This method inserts a TOC (table of contents) field into the document at the current position.

A table of contents in a Word document can be built in a number of ways and formatted using a variety of options. The way the table is built and displayed by Microsoft Word is controlled by the field switches.

The easiest way to specify the switches is to insert and configure a table of contents into a Word document using the Insert->Reference->Index and [Tables](../../../aspose.words.tables/) menu, then switch display of field codes on to see the switches. You can press Alt+F9 in Microsoft Word to toggle display of field codes on or off.

For example, after creating a table of contents, the following field is inserted into the document: **%{ TOC \o "1-3" \h \z }**. You can copy **%\o "1-3" \h \z** and use it as the switches parameter.

Note that **InsertTableOfContents** will only insert a TOC field, but will not actually build the table of contents. The table of contents is built by Microsoft Word when the field is updated.

If you insert a table of contents using this method and then open the file in Microsoft Word, you will not see the table of contents because the TOC field has not yet been updated.

In Microsoft Word, fields are not automatically updated when a document is opened, but you can update fields in a document at any time by pressing F9.

## Examples



Shows how to insert a Table of contents (TOC) into a document using heading styles as entries. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a table of contents for the first page of the document.
// Configure the table to pick up paragraphs with headings of levels 1 to 3.
// Also, set its entries to be hyperlinks that will take us
// to the location of the heading when left-clicked in Microsoft Word.
builder->InsertTableOfContents(u"\\o \"1-3\" \\h \\z \\u");
builder->InsertBreak(BreakType::PageBreak);

// Populate the table of contents by adding paragraphs with heading styles.
// Each such heading with a level between 1 and 3 will create an entry in the table.
builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading1);
builder->Writeln(u"Heading 1");

builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading2);
builder->Writeln(u"Heading 1.1");
builder->Writeln(u"Heading 1.2");

builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading1);
builder->Writeln(u"Heading 2");
builder->Writeln(u"Heading 3");

builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading2);
builder->Writeln(u"Heading 3.1");

builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading3);
builder->Writeln(u"Heading 3.1.1");
builder->Writeln(u"Heading 3.1.2");
builder->Writeln(u"Heading 3.1.3");

builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading4);
builder->Writeln(u"Heading 3.1.3.1");
builder->Writeln(u"Heading 3.1.3.2");

builder->get_ParagraphFormat()->set_StyleIdentifier(StyleIdentifier::Heading2);
builder->Writeln(u"Heading 3.2");
builder->Writeln(u"Heading 3.3");

// A table of contents is a field of a type that needs to be updated to show an up-to-date result.
doc->UpdateFields();
doc->Save(ArtifactsDir + u"DocumentBuilder.InsertToc.docx");
```

