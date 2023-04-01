---
title: Aspose::Words::TextureIndex enum
linktitle: TextureIndex
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::TextureIndex enum. Specifies shading texture in C++.'
type: docs
weight: 12500
url: /cpp/aspose.words/textureindex/
---
## TextureIndex enum


Specifies shading texture.

```cpp
enum class TextureIndex
```

### Values

| Name | Value | Description |
| --- | --- | --- |
| Texture10Percent | 3 |  |
| Texture12Pt5Percent | 37 |  |
| Texture15Percent | 38 |  |
| Texture17Pt5Percent | 39 |  |
| Texture20Percent | 4 |  |
| Texture22Pt5Percent | 40 |  |
| Texture25Percent | 5 |  |
| Texture27Pt5Percent | 41 |  |
| Texture2Pt5Percent | 35 |  |
| Texture30Percent | 6 |  |
| Texture32Pt5Percent | 42 |  |
| Texture35Percent | 43 |  |
| Texture37Pt5Percent | 44 |  |
| Texture40Percent | 7 |  |
| Texture42Pt5Percent | 45 |  |
| Texture45Percent | 46 |  |
| Texture47Pt5Percent | 47 |  |
| Texture50Percent | 8 |  |
| Texture52Pt5Percent | 48 |  |
| Texture55Percent | 49 |  |
| Texture57Pt5Percent | 50 |  |
| Texture5Percent | 2 |  |
| Texture60Percent | 9 |  |
| Texture62Pt5Percent | 51 |  |
| Texture65Percent | 52 |  |
| Texture67Pt5Percent | 53 |  |
| Texture70Percent | 10 |  |
| Texture72Pt5Percent | 54 |  |
| Texture75Percent | 11 |  |
| Texture77Pt5Percent | 55 |  |
| Texture7Pt5Percent | 36 |  |
| Texture80Percent | 12 |  |
| Texture82Pt5Percent | 56 |  |
| Texture85Percent | 57 |  |
| Texture87Pt5Percent | 58 |  |
| Texture90Percent | 13 |  |
| Texture92Pt5Percent | 59 |  |
| Texture95Percent | 60 |  |
| Texture97Pt5Percent | 61 |  |
| TextureCross | 24 |  |
| TextureDarkCross | 18 |  |
| TextureDarkDiagonalCross | 19 |  |
| TextureDarkDiagonalDown | 16 |  |
| TextureDarkDiagonalUp | 17 |  |
| TextureDarkHorizontal | 14 |  |
| TextureDarkVertical | 15 |  |
| TextureDiagonalCross | 25 |  |
| TextureDiagonalDown | 22 |  |
| TextureDiagonalUp | 23 |  |
| TextureHorizontal | 20 |  |
| TextureNone | 0 |  |
| TextureSolid | 1 |  |
| TextureVertical | 21 |  |
| TextureNil | 65535 | Specifies that there shall be no pattern used on the current shaded region (i.e. the pattern shall be a complete fill with the background color). |


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

## See Also

* Namespace [Aspose::Words](../)
* Library [Aspose.Words for C++](../../)
