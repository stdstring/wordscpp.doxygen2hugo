---
title: Aspose::Words::TextColumnCollection::get_LineBetween method
linktitle: get_LineBetween
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::TextColumnCollection::get_LineBetween method. When true, adds a vertical line between columns in C++.
type: docs
weight: 27
url: /cpp/aspose.words/textcolumncollection/get_linebetween/
---
## TextColumnCollection::get_LineBetween method


When **true**, adds a vertical line between columns.

```cpp
bool Aspose::Words::TextColumnCollection::get_LineBetween()
```


## Examples



Shows how to separate columns with a vertical line. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Configure the current section's PageSetup object to divide the text into several columns.
// Set the "LineBetween" property to "true" to put a dividing line between columns.
// Set the "LineBetween" property to "false" to leave the space between columns blank.
SharedPtr<TextColumnCollection> columns = builder->get_PageSetup()->get_TextColumns();
columns->set_LineBetween(lineBetween);
columns->SetCount(3);

builder->Writeln(u"Column 1.");
builder->InsertBreak(BreakType::ColumnBreak);
builder->Writeln(u"Column 2.");
builder->InsertBreak(BreakType::ColumnBreak);
builder->Writeln(u"Column 3.");

doc->Save(ArtifactsDir + u"PageSetup.VerticalLineBetweenColumns.docx");
```

## See Also

* Class [TextColumnCollection](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
