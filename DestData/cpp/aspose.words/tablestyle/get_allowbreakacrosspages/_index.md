---
title: Aspose::Words::TableStyle::get_AllowBreakAcrossPages method
linktitle: get_AllowBreakAcrossPages
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::TableStyle::get_AllowBreakAcrossPages method. Gets or sets a flag indicating whether text in a table row is allowed to split across a page break in C++.'
type: docs
weight: 200
url: /cpp/aspose.words/tablestyle/get_allowbreakacrosspages/
---
## TableStyle::get_AllowBreakAcrossPages method


Gets or sets a flag indicating whether text in a table row is allowed to split across a page break.

```cpp
bool Aspose::Words::TableStyle::get_AllowBreakAcrossPages()
```


## Examples



Shows how to create custom style settings for the table. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Table> table = builder->StartTable();
builder->InsertCell();
builder->Write(u"Name");
builder->InsertCell();
builder->Write(u"مرحبًا");
builder->EndRow();
builder->InsertCell();
builder->InsertCell();
builder->EndTable();

auto tableStyle = System::DynamicCast<TableStyle>(doc->get_Styles()->Add(StyleType::Table, u"MyTableStyle1"));
tableStyle->set_AllowBreakAcrossPages(true);
tableStyle->set_Bidi(true);
tableStyle->set_CellSpacing(5);
tableStyle->set_BottomPadding(20);
tableStyle->set_LeftPadding(5);
tableStyle->set_RightPadding(10);
tableStyle->set_TopPadding(20);
tableStyle->get_Shading()->set_BackgroundPatternColor(System::Drawing::Color::get_AntiqueWhite());
tableStyle->get_Borders()->set_Color(System::Drawing::Color::get_Blue());
tableStyle->get_Borders()->set_LineStyle(LineStyle::DotDash);
tableStyle->set_VerticalAlignment(CellVerticalAlignment::Center);

table->set_Style(tableStyle);

// Setting the style properties of a table may affect the properties of the table itself.
ASSERT_TRUE(table->get_Bidi());
ASPOSE_ASSERT_EQ(5.0, table->get_CellSpacing());
ASSERT_EQ(u"MyTableStyle1", table->get_StyleName());

doc->Save(ArtifactsDir + u"Table.TableStyleCreation.docx");
```

## See Also

* Class [TableStyle](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
