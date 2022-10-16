---
title: GeneralFormat
second_title: Aspose.Words for C++ API Reference
description: Specifies a general format that is applied to a numeric, text, or any field result. A field may have a combination of general formats. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/generalformat/
---
## GeneralFormat enum


Specifies a general format that is applied to a numeric, text, or any field result. A field may have a combination of general formats.

### Values

| Name | Value | Description |
| --- | --- | --- |
| None | `0` | Used to specify a missing general format. |
| Aiueo | `0` | Numeric formatting. Formats a numeric result using hiragana characters in the traditional a-i-u-e-o order. |
| UppercaseAlphabetic | `0` | Numeric formatting. Formats a numeric result as one or more occurrences of an uppercase alphabetic Latin character. |
| LowercaseAlphabetic | `0` | Numeric formatting. Formats a numeric result as one or more occurrences of an lowercase alphabetic Latin character. |
| Arabic | `0` | Numeric formatting. Formats a numeric result using Arabic cardinal numerals. |
| ArabicAbjad | `0` | Numeric formatting. Formats a numeric result using ascending Abjad numerals. |
| ArabicAlpha | `0` | Numeric formatting. Formats a numeric result using characters in the Arabic alphabet. |
| ArabicDash | `0` | Numeric formatting. Formats a numeric result using Arabic cardinal numerals, with a prefix of "- " and a suffix of " -". |
| BahtText | `0` | Numeric formatting. Formats a numeric result in the Thai counting system. |
| CardText | `0` | Numeric formatting. Cardinal text (One, Two, Three, ...). |
| ChineseNum1 | `0` | Numeric formatting. Formats a numeric result using ascending numbers from the appropriate counting system. |
| ChineseNum2 | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the appropriate legal format. |
| ChineseNum3 | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the appropriate counting thousand system. |
| Chosung | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the Korean Chosung format. |
| CircleNum | `0` | Numeric formatting. Formats a numeric result using decimal numbering enclosed in a circle, using the enclosed alphanumeric glyph character for numbers in the range 1–20. |
| DBChar | `0` | Numeric formatting. Formats a numeric result using double-byte Arabic numbering. |
| DBNum1 | `0` | Numeric formatting. Formats a numeric result using sequential digital ideographs, using the appropriate character. |
| DBNum2 | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the appropriate counting system. |
| DBNum3 | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the appropriate legal counting system. |
| DBNum4 | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the appropriate digital counting system. |
| DollarText | `0` | Numeric formatting. Dollar text (One, Two, Three, ... + AND 55/100). |
| Ganada | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the Korean Ganada format. |
| GB1 | `0` | Numeric formatting. Formats a numeric result using decimal numbering followed by a period, using the enclosed alphanumeric glyph character. |
| GB2 | `0` | Numeric formatting. Formats a numeric result using decimal numbering enclosed in parenthesis, using the enclosed alphanumeric glyph character. |
| GB3 | `0` | Numeric formatting. Formats a numeric result using decimal numbering enclosed in a circle, using the enclosed alphanumeric glyph character. |
| GB4 | `0` | Numeric formatting. Formats a numeric result using decimal numbering enclosed in a circle, using the enclosed alphanumeric glyph character. |
| Hebrew1 | `0` | Numeric formatting. Formats a numeric result using Hebrew numerals. |
| Hebrew2 | `0` | Numeric formatting. Formats a numeric result using the Hebrew alphabet. |
| Hex | `0` | Numeric formatting. Formats the numeric result using uppercase hexadecimal digits. |
| HindiArabic | `0` | Numeric formatting. Formats a numeric result using Hindi numbers. |
| HindiCardText | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the Hindi counting system. |
| HindiLetter1 | `0` | Numeric formatting. Formats a numeric result using Hindi vowels. |
| HindiLetter2 | `0` | Numeric formatting. Formats a numeric result using Hindi consonants. |
| Iroha | `0` | Numeric formatting. Formats a numeric result using the Japanese iroha. |
| KanjiNum1 | `0` | Numeric formatting. Formats a numeric result using a Japanese style using the appropriate counting system. |
| KanjiNum2 | `0` | Numeric formatting. Formats a numeric result using the appropriate counting system. |
| KanjiNum3 | `0` | Numeric formatting. Formats a numeric result using the appropriate counting system. |
| Ordinal | `0` | Numeric formatting. Ordinal (1st, 2nd, 3rd, ...). |
| OrdText | `0` | Numeric formatting. Ordinal text (First, Second, Third, ...). |
| UppercaseRoman | `0` | Numeric formatting. Uppercase Roman (I, II, III, ...). |
| LowercaseRoman | `0` | Numeric formatting. Lowercase Roman (i, ii, iii, ...). |
| SBChar | `0` | Numeric formatting. Formats a numeric result using single-byte Arabic numbering. |
| ThaiArabic | `0` | Numeric formatting. Formats a numeric result using Thai numbers. |
| ThaiCardText | `0` | Numeric formatting. Formats a numeric result using sequential numbers from the Thai counting system. |
| ThaiLetter | `0` | Numeric formatting. Formats a numeric result using Thai letters. |
| VietCardText | `0` | Numeric formatting. Formats a numeric result using Vietnamese numerals. |
| Zodiac1 | `0` | Numeric formatting. Formats a numeric result using sequential numerical traditional ideographs. |
| Zodiac2 | `0` | Numeric formatting. Formats a numeric result using sequential zodiac ideographs. |
| Zodiac3 | `0` | Numeric formatting. Formats a numeric result using sequential traditional zodiac ideographs. |
| Caps | `0` | Text formatting. Capitalizes the first letter of each word. |
| FirstCap | `0` | Text formatting. Capitalizes the first letter of the first word. |
| Lower | `0` | Text formatting. All letters are lowercase. |
| Upper | `0` | Text formatting. All letters are uppercase. |
| CharFormat | `0` | [Field](../field/) result formatting. The CHARFORMAT instruction. |
| MergeFormat | `0` | [Field](../field/) result formatting. The MERGEFORMAT instruction. |
| MergeFormatInet | `0` | [Field](../field/) result formatting. The MERGEFORMATINET instruction. |


## Examples




Shows how to format field results. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Use a document builder to insert a field that displays a result with no format applied.
SharedPtr<Field> field = builder->InsertField(u"= 2 + 3");

ASSERT_EQ(u"= 2 + 3", field->GetFieldCode());
ASSERT_EQ(u"5", field->get_Result());

// We can apply a format to a field's result using the field's properties.
// Below are three types of formats that we can apply to a field's result.
// 1 -  Numeric format:
SharedPtr<FieldFormat> format = field->get_Format();
format->set_NumericFormat(u"$###.00");
field->Update();

ASSERT_EQ(u"= 2 + 3 \\# $###.00", field->GetFieldCode());
ASSERT_EQ(u"$  5.00", field->get_Result());

// 2 -  Date/time format:
field = builder->InsertField(u"DATE");
format = field->get_Format();
format->set_DateTimeFormat(u"dddd, MMMM dd, yyyy");
field->Update();

ASSERT_EQ(u"DATE \\@ \"dddd, MMMM dd, yyyy\"", field->GetFieldCode());
std::cout << "Today's date, in " << format->get_DateTimeFormat() << " format:\n\t" << field->get_Result() << std::endl;

// 3 -  General format:
field = builder->InsertField(u"= 25 + 33");
format = field->get_Format();
format->get_GeneralFormats()->Add(GeneralFormat::LowercaseRoman);
format->get_GeneralFormats()->Add(GeneralFormat::Upper);
field->Update();

int index = 0;
{
    SharedPtr<System::Collections::Generic::IEnumerator<GeneralFormat>> generalFormatEnumerator = format->get_GeneralFormats()->GetEnumerator();
    while (generalFormatEnumerator->MoveNext())
    {
        std::cout << String::Format(u"General format index {0}: {1}", index++, generalFormatEnumerator->get_Current()) << std::endl;
    }
}

ASSERT_EQ(u"= 25 + 33 \\* roman \\* Upper", field->GetFieldCode());
ASSERT_EQ(u"LVIII", field->get_Result());
ASSERT_EQ(2, format->get_GeneralFormats()->get_Count());
ASSERT_EQ(GeneralFormat::LowercaseRoman, format->get_GeneralFormats()->idx_get(0));

// We can remove our formats to revert the field's result to its original form.
format->get_GeneralFormats()->Remove(GeneralFormat::LowercaseRoman);
format->get_GeneralFormats()->RemoveAt(0);
ASSERT_EQ(0, format->get_GeneralFormats()->get_Count());
field->Update();

ASSERT_EQ(u"= 25 + 33  ", field->GetFieldCode());
ASSERT_EQ(u"58", field->get_Result());
ASSERT_EQ(0, format->get_GeneralFormats()->get_Count());
```

