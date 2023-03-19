---
title: Aspose::Words::Fields::FieldFormat class
linktitle: FieldFormat
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Fields::FieldFormat class. Provides typed access to field's numeric, date and time, and general formatting in C++.
type: docs
weight: 4500
url: /cpp/aspose.words.fields/fieldformat/
---
## FieldFormat class


Provides typed access to field's numeric, date and time, and general formatting.

```cpp
class FieldFormat : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| [get_DateTimeFormat](./get_datetimeformat/)() | Gets or sets a formatting that is applied to a date and time field result. Corresponds to the \@ switch. |
| [get_GeneralFormats](./get_generalformats/)() | Gets a collection of general formats that are applied to a numeric, text or any field result. Corresponds to the \* switches. |
| [get_NumericFormat](./get_numericformat/)() | Gets or sets a formatting that is applied to a numeric field result. Corresponds to the \# switch. |
| [set_DateTimeFormat](./set_datetimeformat/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldFormat::get_DateTimeFormat](./get_datetimeformat/). |
| [set_NumericFormat](./set_numericformat/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldFormat::get_NumericFormat](./get_numericformat/). |

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

## See Also

* Namespace [Aspose::Words::Fields](../)
* Library [Aspose.Words for C++](../../)
