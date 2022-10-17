---
title: ControlChar
second_title: Aspose.Words for C++ API Reference
description: Control characters often encountered in documents. 
type: docs
weight: 0
url: /cpp/aspose.words/controlchar/
---
## ControlChar class


Control characters often encountered in documents.

```cpp
class ControlChar
```


## Methods

| Method | Description |
| --- | --- |
| static [Cell](./cell/)() | End of a table cell or end of a table row character: "\x0007" or "\a". |
| static [ColumnBreak](./columnbreak/)() | End of column character: "\x000e". |
| [ControlChar](./controlchar/)() |  |
| static [Cr](./cr/)() | Carriage return character: "\x000d" or "\r". Same as [ParagraphBreak](./paragraphbreak/). |
| static [CrLf](./crlf/)() | Carriage return followed by line feed character: "\x000d\x000a" or "\r\n". Not used as such in Microsoft Word documents, but commonly used in text files for paragraph breaks. |
| static [Lf](./lf/)() | Line feed character: "\x000a" or "\n". Same as [LineFeed](./linefeed/). |
| static [LineBreak](./linebreak/)() | Line break character: "\x000b" or "\v". |
| static [LineFeed](./linefeed/)() | Line feed character: "\x000a" or "\n". Same as [Lf](./lf/). |
| static [NonBreakingSpace](./nonbreakingspace/)() | Non-breaking space character: "\x00a0". |
| static [PageBreak](./pagebreak/)() | Page break character: "\x000c" or "\f". Note it has the same value as [SectionBreak](./sectionbreak/). |
| static [ParagraphBreak](./paragraphbreak/)() | End of paragraph character: "\x000d" or "\r". Same as [Cr](./cr/) |
| static [SectionBreak](./sectionbreak/)() | End of section character: "\x000c" or "\f". Note it has the same value as [PageBreak](./pagebreak/). |
| static [Tab](./tab/)() | Tab character: "\x0009" or "\t". |

## Examples




Shows how to use control characters. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert paragraphs with text with DocumentBuilder.
builder->Writeln(u"Hello world!");
builder->Writeln(u"Hello again!");

// Converting the document to text form reveals that control characters
// represent some of the document's structural elements, such as page breaks.
ASSERT_EQ(String::Format(u"Hello world!{0}", ControlChar::Cr()) + String::Format(u"Hello again!{0}", ControlChar::Cr()) + ControlChar::PageBreak(),
          doc->GetText());

// When converting a document to string form,
// we can omit some of the control characters with the Trim method.
ASSERT_EQ(String::Format(u"Hello world!{0}", ControlChar::Cr()) + u"Hello again!", doc->GetText().Trim());
```

