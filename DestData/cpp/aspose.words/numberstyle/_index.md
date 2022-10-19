---
title: NumberStyle
second_title: Aspose.Words for C++ API Reference
description: Specifies the number style for a list, footnotes and endnotes, page numbers. 
type: docs
weight: 1327
url: /cpp/aspose.words/numberstyle/
---
## NumberStyle enum


Specifies the number style for a list, footnotes and endnotes, page numbers.

### Values

| Name | Value | Description |
| --- | --- | --- |
| Arabic | `0` | Arabic numbering (1, 2, 3, ...) |
| UppercaseRoman | `0` | Upper case Roman (I, II, III, ...) |
| LowercaseRoman | `0` | Lower case Roman (i, ii, iii, ...) |
| UppercaseLetter | `0` | Upper case Letter (A, B, C, ...) |
| LowercaseLetter | `0` | Lower case letter (a, b, c, ...) |
| Ordinal | `0` | Ordinal (1st, 2nd, 3rd, ...) |
| Number | `0` | Numbered (One, Two, Three, ...) |
| OrdinalText | `0` | Ordinal (text) (First, Second, Third, ...) |
| Hex | `0` | Hexadecimal: 8, 9, A, B, C, D, E, F, 10, 11, 12. |
| ChicagoManual | `0` | Chicago Manual of [Style](../style/): *, †, † |
| Kanji | `0` | Ideograph-digital. |
| KanjiDigit | `0` | Japanese counting. |
| AiueoHalfWidth | `0` | Aiueo. |
| IrohaHalfWidth | `0` | Iroha. |
| ArabicFullWidth | `0` | Full-width Arabic: 1, 2, 3, 4. |
| ArabicHalfWidth | `0` | Half-width Arabic: 1, 2, 3, 4. |
| KanjiTraditional | `0` | Japanese legal. |
| KanjiTraditional2 | `0` | Japanese digital ten thousand. |
| NumberInCircle | `0` | Enclosed circles. |
| DecimalFullWidth | `0` | Decimal full width: 1, 2, 3, 4. |
| Aiueo | `0` | Aiueo full width. |
| Iroha | `0` | Iroha full width. |
| LeadingZero | `0` | Leading Zero (01, 02,..., 09, 10, 11,..., 99, 100, 101,...) |
| Bullet | `0` | Bullet (check the character code in the text) |
| Ganada | `0` | Korean Ganada. |
| Chosung | `0` | Korea Chosung. |
| GB1 | `0` | Enclosed full stop. |
| GB2 | `0` | Enclosed parenthesis. |
| GB3 | `0` | Enclosed circle Chinese. |
| GB4 | `0` | Ideograph enclosed circle. |
| Zodiac1 | `0` | Ideograph traditional. |
| Zodiac2 | `0` | Ideograph Zodiac. |
| Zodiac3 | `0` | Ideograph Zodiac traditional. |
| TradChinNum1 | `0` | Taiwanese counting. |
| TradChinNum2 | `0` | Ideograph legal traditional. |
| TradChinNum3 | `0` | Taiwanese counting thousand. |
| TradChinNum4 | `0` | Taiwanese digital. |
| SimpChinNum1 | `0` | Chinese counting. |
| SimpChinNum2 | `0` | Chinese legal simplified. |
| SimpChinNum3 | `0` | Chinese counting thousand. |
| SimpChinNum4 | `0` | Chinese (not implemented) |
| HanjaRead | `0` | Korean digital. |
| HanjaReadDigit | `0` | Korean counting. |
| Hangul | `0` | Korea legal. |
| Hanja | `0` | Korea digital2. |
| Hebrew1 | `0` | Hebrew-1. |
| Arabic1 | `0` | Arabic alpha. |
| Hebrew2 | `0` | Hebrew-2. |
| Arabic2 | `0` | Arabic abjad. |
| HindiLetter1 | `0` | Hindi vowels. |
| HindiLetter2 | `0` | Hindi consonants. |
| HindiArabic | `0` | Hindi numbers. |
| HindiCardinalText | `0` | Hindi descriptive (cardinals) |
| ThaiLetter | `0` | Thai letters. |
| ThaiArabic | `0` | Thai numbers. |
| ThaiCardinalText | `0` | Thai descriptive (cardinals) |
| VietCardinalText | `0` | Vietnamese descriptive (cardinals) |
| NumberInDash | `0` | Page number format: - 1 -, - 2 -, - 3 -, - 4 -. |
| LowercaseRussian | `0` | Lowercase Russian alphabet. |
| UppercaseRussian | `0` | Uppercase Russian alphabet. |
| None | `0` | No bullet or number. |
| Custom | `0` | Custom number format. It is supported by DOCX format only. |


## Examples




Shows how to apply custom list formatting to paragraphs when using [DocumentBuilder](../documentbuilder/). 
```cpp
auto doc = MakeObject<Document>();

// A list allows us to organize and decorate sets of paragraphs with prefix symbols and indents.
// We can create nested lists by increasing the indent level.
// We can begin and end a list by using a document builder's "ListFormat" property.
// Each paragraph that we add between a list's start and the end will become an item in the list.
// Create a list from a Microsoft Word template, and customize the first two of its list levels.
SharedPtr<List> list = doc->get_Lists()->Add(ListTemplate::NumberDefault);

SharedPtr<ListLevel> listLevel = list->get_ListLevels()->idx_get(0);
listLevel->get_Font()->set_Color(System::Drawing::Color::get_Red());
listLevel->get_Font()->set_Size(24);
listLevel->set_NumberStyle(NumberStyle::OrdinalText);
listLevel->set_StartAt(21);
listLevel->set_NumberFormat(u"\x0000");

listLevel->set_NumberPosition(-36);
listLevel->set_TextPosition(144);
listLevel->set_TabPosition(144);

listLevel = list->get_ListLevels()->idx_get(1);
listLevel->set_Alignment(ListLevelAlignment::Right);
listLevel->set_NumberStyle(NumberStyle::Bullet);
listLevel->get_Font()->set_Name(u"Wingdings");
listLevel->get_Font()->set_Color(System::Drawing::Color::get_Blue());
listLevel->get_Font()->set_Size(24);

// This NumberFormat value will create star-shaped bullet list symbols.
listLevel->set_NumberFormat(u"\xf0af");
listLevel->set_TrailingCharacter(ListTrailingCharacter::Space);
listLevel->set_NumberPosition(144);

// Create paragraphs and apply both list levels of our custom list formatting to them.
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_ListFormat()->set_List(list);
builder->Writeln(u"The quick brown fox...");
builder->Writeln(u"The quick brown fox...");

builder->get_ListFormat()->ListIndent();
builder->Writeln(u"jumped over the lazy dog.");
builder->Writeln(u"jumped over the lazy dog.");

builder->get_ListFormat()->ListOutdent();
builder->Writeln(u"The quick brown fox...");

builder->get_ListFormat()->RemoveNumbers();

builder->get_Document()->Save(ArtifactsDir + u"Lists.CreateCustomList.docx");
```

