---
title: FieldType
second_title: Aspose.Words for C++ API Reference
description: Specifies Microsoft Word field types. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldtype/
---
## FieldType enum


Specifies Microsoft Word field types.


## Examples




Shows how to insert a field into a document using a field code. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Field> field = builder->InsertField(u"DATE \\@ \"dddd, MMMM dd, yyyy\"");

ASSERT_EQ(FieldType::FieldDate, field->get_Type());
ASSERT_EQ(u"DATE \\@ \"dddd, MMMM dd, yyyy\"", field->GetFieldCode());

// This overload of the InsertField method automatically updates inserted fields.
ASSERT_LE(System::Math::Abs((System::DateTime::Parse(field->get_Result()) - System::DateTime::get_Today()).get_Hours()), 24);
```


Shows how to work with a [FieldStart](../fieldstart/) node. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

auto field = System::DynamicCast<FieldDate>(builder->InsertField(FieldType::FieldDate, true));
field->get_Format()->set_DateTimeFormat(u"dddd, MMMM dd, yyyy");
field->Update();

SharedPtr<FieldChar> fieldStart = field->get_Start();

ASSERT_EQ(FieldType::FieldDate, fieldStart->get_FieldType());
ASPOSE_ASSERT_EQ(false, fieldStart->get_IsDirty());
ASPOSE_ASSERT_EQ(false, fieldStart->get_IsLocked());

// Retrieve the facade object which represents the field in the document.
field = System::DynamicCast<FieldDate>(fieldStart->GetField());

ASPOSE_ASSERT_EQ(false, field->get_IsLocked());
ASSERT_EQ(u" DATE  \\@ \"dddd, MMMM dd, yyyy\"", field->GetFieldCode());

// Update the field to show the current date.
field->Update();
```

