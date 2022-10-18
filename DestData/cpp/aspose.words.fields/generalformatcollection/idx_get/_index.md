---
title: idx_get
second_title: Aspose.Words for C++ API Reference
description: Gets a general format at the specified index. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/generalformatcollection/idx_get/
---
## GeneralFormatCollection.idx_get method


Gets a general format at the specified index.

```cpp
Aspose::Words::Fields::GeneralFormat Aspose::Words::Fields::GeneralFormatCollection::idx_get(int32_t index)
```


| Parameter | Type | Description |
| --- | --- | --- |
| index | int32_t | The index of a general format. |

### ReturnValue


A general format.

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

