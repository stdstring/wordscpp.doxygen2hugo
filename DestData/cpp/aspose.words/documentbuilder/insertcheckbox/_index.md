---
title: InsertCheckBox
second_title: Aspose.Words for C++ API Reference
description: Inserts a checkbox form field at the current position. 
type: docs
weight: 0
url: /cpp/aspose.words/documentbuilder/insertcheckbox/
---
## DocumentBuilder.InsertCheckBox(const System::String\&, bool, int32_t) method


Inserts a checkbox form field at the current position.

```cpp
System::SharedPtr<Aspose::Words::Fields::FormField> Aspose::Words::DocumentBuilder::InsertCheckBox(const System::String &name, bool checkedValue, int32_t size)
```


| Parameter | Type | Description |
| --- | --- | --- |
| name | `-` | The name of the form field. Can be an empty string. The value longer than 20 characters will be truncated. |
| checkedValue | `-` | Checked status of the checkbox form field. |
| size | `-` | Specifies the size of the checkbox in points. Specify 0 for MS Word to calculate the size of the checkbox automatically. |

### ReturnValue


The form field node that was just inserted.

If you specify a name for the form field, then a bookmark is automatically created with the same name.

## Examples




Shows how to insert checkboxes into the document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert checkboxes of varying sizes and default checked statuses.
builder->Write(u"Unchecked check box of a default size: ");
builder->InsertCheckBox(String::Empty, false, false, 0);
builder->InsertParagraph();

builder->Write(u"Large checked check box: ");
builder->InsertCheckBox(u"CheckBox_Default", true, true, 50);
builder->InsertParagraph();

// Form fields have a name length limit of 20 characters.
builder->Write(u"Very large checked check box: ");
builder->InsertCheckBox(u"CheckBox_OnlyCheckedValue", true, 100);

ASSERT_EQ(u"CheckBox_OnlyChecked", doc->get_Range()->get_FormFields()->idx_get(2)->get_Name());

// We can interact with these check boxes in Microsoft Word by double clicking them.
doc->Save(ArtifactsDir + u"DocumentBuilder.InsertCheckBox.docx");
```

## DocumentBuilder.InsertCheckBox(const System::String\&, bool, bool, int32_t) method


Inserts a checkbox form field at the current position.

```cpp
System::SharedPtr<Aspose::Words::Fields::FormField> Aspose::Words::DocumentBuilder::InsertCheckBox(const System::String &name, bool defaultValue, bool checkedValue, int32_t size)
```


| Parameter | Type | Description |
| --- | --- | --- |
| name | `-` | The name of the form field. Can be an empty string. The value longer than 20 characters will be truncated. |
| defaultValue | `-` | Default value of the checkbox form field. |
| checkedValue | `-` | Current checked status of the checkbox form field. |
| size | `-` | Specifies the size of the checkbox in points. Specify 0 for MS Word to calculate the size of the checkbox automatically. |

### ReturnValue


The form field node that was just inserted.

If you specify a name for the form field, then a bookmark is automatically created with the same name.

## Examples




Shows how to insert checkboxes into the document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert checkboxes of varying sizes and default checked statuses.
builder->Write(u"Unchecked check box of a default size: ");
builder->InsertCheckBox(String::Empty, false, false, 0);
builder->InsertParagraph();

builder->Write(u"Large checked check box: ");
builder->InsertCheckBox(u"CheckBox_Default", true, true, 50);
builder->InsertParagraph();

// Form fields have a name length limit of 20 characters.
builder->Write(u"Very large checked check box: ");
builder->InsertCheckBox(u"CheckBox_OnlyCheckedValue", true, 100);

ASSERT_EQ(u"CheckBox_OnlyChecked", doc->get_Range()->get_FormFields()->idx_get(2)->get_Name());

// We can interact with these check boxes in Microsoft Word by double clicking them.
doc->Save(ArtifactsDir + u"DocumentBuilder.InsertCheckBox.docx");
```

