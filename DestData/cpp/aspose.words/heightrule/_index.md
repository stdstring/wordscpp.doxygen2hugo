---
title: HeightRule
second_title: Aspose.Words for C++ API Reference
description: Specifies the rule for determining the height of an object. 
type: docs
weight: 0
url: /cpp/aspose.words/heightrule/
---
## HeightRule enum


Specifies the rule for determining the height of an object.


## Examples




Shows how to format rows with a document builder. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Table> table = builder->StartTable();
builder->InsertCell();
builder->Write(u"Row 1, cell 1.");

// Start a second row, and then configure its height. The builder will apply these settings to
// its current row, as well as any new rows it creates afterwards.
builder->EndRow();

SharedPtr<RowFormat> rowFormat = builder->get_RowFormat();
rowFormat->set_Height(100);
rowFormat->set_HeightRule(HeightRule::Exactly);

builder->InsertCell();
builder->Write(u"Row 2, cell 1.");
builder->EndTable();

// The first row was unaffected by the padding reconfiguration and still holds the default values.
ASPOSE_ASSERT_EQ(0.0, table->get_Rows()->idx_get(0)->get_RowFormat()->get_Height());
ASSERT_EQ(HeightRule::Auto, table->get_Rows()->idx_get(0)->get_RowFormat()->get_HeightRule());

ASPOSE_ASSERT_EQ(100.0, table->get_Rows()->idx_get(1)->get_RowFormat()->get_Height());
ASSERT_EQ(HeightRule::Exactly, table->get_Rows()->idx_get(1)->get_RowFormat()->get_HeightRule());

doc->Save(ArtifactsDir + u"DocumentBuilder.SetRowFormatting.docx");
```

