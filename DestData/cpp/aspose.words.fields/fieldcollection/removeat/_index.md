---
title: RemoveAt
second_title: Aspose.Words for C++ API Reference
description: Removes a field at the specified index from this collection and from the document.
type: docs
weight: 66
url: /cpp/aspose.words.fields/fieldcollection/removeat/
---
## FieldCollection::RemoveAt method


Removes a field at the specified index from this collection and from the document.

```cpp
void Aspose::Words::Fields::FieldCollection::RemoveAt(int32_t index)
```


| Parameter | Type | Description |
| --- | --- | --- |
| index | int32_t | An index into the collection. |

## Examples




Shows how to remove fields from a field collection. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->InsertField(u" DATE \\@ \"dddd, d MMMM yyyy\" ");
builder->InsertField(u" TIME ");
builder->InsertField(u" REVNUM ");
builder->InsertField(u" AUTHOR  \"John Doe\" ");
builder->InsertField(u" SUBJECT \"My Subject\" ");
builder->InsertField(u" QUOTE \"Hello world!\" ");
doc->UpdateFields();

SharedPtr<FieldCollection> fields = doc->get_Range()->get_Fields();

ASSERT_EQ(6, fields->get_Count());

// Below are four ways of removing fields from a field collection.
// 1 -  Get a field to remove itself:
fields->idx_get(0)->Remove();
ASSERT_EQ(5, fields->get_Count());

// 2 -  Get the collection to remove a field that we pass to its removal method:
SharedPtr<Field> lastField = fields->idx_get(3);
fields->Remove(lastField);
ASSERT_EQ(4, fields->get_Count());

// 3 -  Remove a field from a collection at an index:
fields->RemoveAt(2);
ASSERT_EQ(3, fields->get_Count());

// 4 -  Remove all the fields from the collection at once:
fields->Clear();
ASSERT_EQ(0, fields->get_Count());
```

