---
title: AutoFit
second_title: Aspose.Words for C++ API Reference
description: Resizes the table and cells according to the specified auto fit behavior.
type: docs
weight: 27
url: /cpp/aspose.words.tables/table/autofit/
---
## Table::AutoFit method


Resizes the table and cells according to the specified auto fit behavior.

```cpp
void Aspose::Words::Tables::Table::AutoFit(Aspose::Words::Tables::AutoFitBehavior behavior)
```


| Parameter | Type | Description |
| --- | --- | --- |
| behavior | Aspose::Words::Tables::AutoFitBehavior | Specifies how to auto fit the table. |
## Remarks


This method mimics the commands available in the Auto Fit menu for a table in Microsoft Word. The commands available are "Auto Fit to Contents", "Auto Fit to Window" and "Fixed Column Width". In Microsoft Word these commands set relevant table properties and then update the table layout and Aspose.Words does the same for you.

## Examples



Shows how to build a new table while applying a style. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);
SharedPtr<Table> table = builder->StartTable();

// We must insert at least one row before setting any table formatting.
builder->InsertCell();

// Set the table style used based on the style identifier.
// Note that not all table styles are available when saving to .doc format.
table->set_StyleIdentifier(StyleIdentifier::MediumShading1Accent1);

// Partially apply the style to features of the table based on predicates, then build the table.
table->set_StyleOptions(TableStyleOptions::FirstColumn | TableStyleOptions::RowBands | TableStyleOptions::FirstRow);
table->AutoFit(AutoFitBehavior::AutoFitToContents);

builder->Writeln(u"Item");
builder->get_CellFormat()->set_RightPadding(40);
builder->InsertCell();
builder->Writeln(u"Quantity (kg)");
builder->EndRow();

builder->InsertCell();
builder->Writeln(u"Apples");
builder->InsertCell();
builder->Writeln(u"20");
builder->EndRow();

builder->InsertCell();
builder->Writeln(u"Bananas");
builder->InsertCell();
builder->Writeln(u"40");
builder->EndRow();

builder->InsertCell();
builder->Writeln(u"Carrots");
builder->InsertCell();
builder->Writeln(u"50");
builder->EndRow();

doc->Save(ArtifactsDir + u"DocumentBuilder.InsertTableWithStyle.docx");
```

## See Also

* Enum [AutoFitBehavior](../../autofitbehavior/)
* Class [Table](../)
* Namespace [Aspose::Words::Tables](../../)
* Library [Aspose.Words](../../../)
