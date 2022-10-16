---
title: BorderType
second_title: Aspose.Words for C++ API Reference
description: Specifies sides of a border. 
type: docs
weight: 0
url: /cpp/aspose.words/bordertype/
---
## BorderType enum


Specifies sides of a border.

### Values

| Name | Value | Description |
| --- | --- | --- |
| None | `0` | Default value. |
| Bottom | `0` | Specifies the bottom border of a paragraph or a table cell. |
| Left | `0` | Specifies the left border of a paragraph or a table cell. |
| Right | `0` | Specifies the right border of a paragraph or a table cell. |
| Top | `0` | Specifies the top border of a paragraph or a table cell. |
| Horizontal | `0` | Specifies the horizontal border between cells in a table or between conforming paragraphs. |
| Vertical | `0` | Specifies the vertical border between cells in a table. |
| DiagonalDown | `0` | Specifies the diagonal border in a table cell. |
| DiagonalUp | `0` | Specifies the diagonal border in a table cell. |


## Examples




Shows how to insert a paragraph with a top border. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Border> topBorder = builder->get_ParagraphFormat()->get_Borders()->idx_get(BorderType::Top);
topBorder->set_Color(System::Drawing::Color::get_Red());
topBorder->set_LineWidth(4.0);
topBorder->set_LineStyle(LineStyle::DashSmallGap);

builder->Writeln(u"Text with a red top border.");

doc->Save(ArtifactsDir + u"Border.ParagraphTopBorder.docx");
```

