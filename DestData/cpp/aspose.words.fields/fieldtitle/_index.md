---
title: FieldTitle
second_title: Aspose.Words for C++ API Reference
description: Implements the TITLE field.
type: docs
weight: 1327
url: /cpp/aspose.words.fields/fieldtitle/
---
## FieldTitle class


Implements the TITLE field.

```cpp
class FieldTitle : public Aspose::Words::Fields::Field
```

## Methods

| Method | Description |
| --- | --- |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result. |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end. |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end. |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field. |
| [get_Format](../field/get_format/)() | Gets a [FieldFormat](../fieldformat/) object that provides typed access to field's formatting. |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document. |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result). |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field. |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end. |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null. |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field. |
| [get_Text](./get_text/)() | Gets or sets the text of the title. |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type. |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included. |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator). |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**. |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsDirty](../field/get_isdirty/). |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsLocked](../field/get_islocked/). |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for [Aspose::Words::Fields::Field::get_LocaleId](../field/get_localeid/). |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for [Aspose::Words::Fields::Field::get_Result](../field/get_result/). |
| [set_Text](./set_text/)(const System::String\&) | Setter for [Aspose::Words::Fields::FieldTitle::get_Text](./get_text/). |
| [Unlink](../field/unlink/)() | Performs the field unlink. |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already. |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already. |

## Examples



Shows how to use the TITLE field. 
```cpp
auto doc = MakeObject<Document>();

// Set a value for the "Title" built-in document property.
doc->get_BuiltInDocumentProperties()->set_Title(u"My Title");

// We can use the TITLE field to display the value of this property in the document.
auto builder = MakeObject<DocumentBuilder>(doc);
auto field = System::DynamicCast<FieldTitle>(builder->InsertField(FieldType::FieldTitle, false));
field->Update();

ASSERT_EQ(u" TITLE ", field->GetFieldCode());
ASSERT_EQ(u"My Title", field->get_Result());

// Setting a value for the field's Text property,
// and then updating the field will also overwrite the corresponding built-in property with the new value.
builder->Writeln();
field = System::DynamicCast<FieldTitle>(builder->InsertField(FieldType::FieldTitle, false));
field->set_Text(u"My New Title");
field->Update();

ASSERT_EQ(u" TITLE  \"My New Title\"", field->GetFieldCode());
ASSERT_EQ(u"My New Title", field->get_Result());
ASSERT_EQ(u"My New Title", doc->get_BuiltInDocumentProperties()->get_Title());

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.TITLE.docx");
```

