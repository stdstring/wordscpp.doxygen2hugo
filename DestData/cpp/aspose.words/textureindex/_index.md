---
title: TextureIndex
second_title: Aspose.Words for C++ API Reference
description: Specifies shading texture. 
type: docs
weight: 1613
url: /cpp/aspose.words/textureindex/
---
## TextureIndex enum


Specifies shading texture.

### Values

| Name | Value | Description |
| --- | --- | --- |
| Texture10Percent | `0` |  |
| Texture12Pt5Percent | `0` |  |
| Texture15Percent | `0` |  |
| Texture17Pt5Percent | `0` |  |
| Texture20Percent | `0` |  |
| Texture22Pt5Percent | `0` |  |
| Texture25Percent | `0` |  |
| Texture27Pt5Percent | `0` |  |
| Texture2Pt5Percent | `0` |  |
| Texture30Percent | `0` |  |
| Texture32Pt5Percent | `0` |  |
| Texture35Percent | `0` |  |
| Texture37Pt5Percent | `0` |  |
| Texture40Percent | `0` |  |
| Texture42Pt5Percent | `0` |  |
| Texture45Percent | `0` |  |
| Texture47Pt5Percent | `0` |  |
| Texture50Percent | `0` |  |
| Texture52Pt5Percent | `0` |  |
| Texture55Percent | `0` |  |
| Texture57Pt5Percent | `0` |  |
| Texture5Percent | `0` |  |
| Texture60Percent | `0` |  |
| Texture62Pt5Percent | `0` |  |
| Texture65Percent | `0` |  |
| Texture67Pt5Percent | `0` |  |
| Texture70Percent | `0` |  |
| Texture72Pt5Percent | `0` |  |
| Texture75Percent | `0` |  |
| Texture77Pt5Percent | `0` |  |
| Texture7Pt5Percent | `0` |  |
| Texture80Percent | `0` |  |
| Texture82Pt5Percent | `0` |  |
| Texture85Percent | `0` |  |
| Texture87Pt5Percent | `0` |  |
| Texture90Percent | `0` |  |
| Texture92Pt5Percent | `0` |  |
| Texture95Percent | `0` |  |
| Texture97Pt5Percent | `0` |  |
| TextureCross | `0` |  |
| TextureDarkCross | `0` |  |
| TextureDarkDiagonalCross | `0` |  |
| TextureDarkDiagonalDown | `0` |  |
| TextureDarkDiagonalUp | `0` |  |
| TextureDarkHorizontal | `0` |  |
| TextureDarkVertical | `0` |  |
| TextureDiagonalCross | `0` |  |
| TextureDiagonalDown | `0` |  |
| TextureDiagonalUp | `0` |  |
| TextureHorizontal | `0` |  |
| TextureNone | `0` |  |
| TextureSolid | `0` |  |
| TextureVertical | `0` |  |
| TextureNil | `0` | Specifies that there shall be no pattern used on the current shaded region (i.e. the pattern shall be a complete fill with the background color). |


## Examples




Shows how to decorate text with borders and shading. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<BorderCollection> borders = builder->get_ParagraphFormat()->get_Borders();
borders->set_DistanceFromText(20);
borders->idx_get(BorderType::Left)->set_LineStyle(LineStyle::Double);
borders->idx_get(BorderType::Right)->set_LineStyle(LineStyle::Double);
borders->idx_get(BorderType::Top)->set_LineStyle(LineStyle::Double);
borders->idx_get(BorderType::Bottom)->set_LineStyle(LineStyle::Double);

SharedPtr<Shading> shading = builder->get_ParagraphFormat()->get_Shading();
shading->set_Texture(TextureIndex::TextureDiagonalCross);
shading->set_BackgroundPatternColor(System::Drawing::Color::get_LightCoral());
shading->set_ForegroundPatternColor(System::Drawing::Color::get_LightSalmon());

builder->Write(u"This paragraph is formatted with a double border and shading.");
doc->Save(ArtifactsDir + u"DocumentBuilder.ApplyBordersAndShading.docx");
```


Shows how to apply an outline border to a table. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Tables.docx");
SharedPtr<Table> table = doc->get_FirstSection()->get_Body()->get_Tables()->idx_get(0);

// Align the table to the center of the page.
table->set_Alignment(TableAlignment::Center);

// Clear any existing borders and shading from the table.
table->ClearBorders();
table->ClearShading();

// Add green borders to the outline of the table.
table->SetBorder(BorderType::Left, LineStyle::Single, 1.5, System::Drawing::Color::get_Green(), true);
table->SetBorder(BorderType::Right, LineStyle::Single, 1.5, System::Drawing::Color::get_Green(), true);
table->SetBorder(BorderType::Top, LineStyle::Single, 1.5, System::Drawing::Color::get_Green(), true);
table->SetBorder(BorderType::Bottom, LineStyle::Single, 1.5, System::Drawing::Color::get_Green(), true);

// Fill the cells with a light green solid color.
table->SetShading(TextureIndex::TextureSolid, System::Drawing::Color::get_LightGreen(), System::Drawing::Color::Empty);

doc->Save(ArtifactsDir + u"Table.SetOutlineBorders.docx");
```

