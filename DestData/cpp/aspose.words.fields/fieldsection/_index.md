---
title: Aspose::Words::Fields::FieldSection class
linktitle: FieldSection
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Fields::FieldSection class. Implements the SECTION field in C++.
type: docs
weight: 8800
url: /cpp/aspose.words.fields/fieldsection/
---
## FieldSection class


Implements the SECTION field.

```cpp
class FieldSection : public Aspose::Words::Fields::Field
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
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type. |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included. |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator). |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**. |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsDirty](../field/get_isdirty/). |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for [Aspose::Words::Fields::Field::get_IsLocked](../field/get_islocked/). |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for [Aspose::Words::Fields::Field::get_LocaleId](../field/get_localeid/). |
| [set_Result](../field/set_result/)(const System::String\&) | Setter for [Aspose::Words::Fields::Field::get_Result](../field/get_result/). |
| [Unlink](../field/unlink/)() | Performs the field unlink. |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already. |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already. |

## Examples



Shows how to use SECTION and SECTIONPAGES fields to number pages by sections. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->MoveToHeaderFooter(HeaderFooterType::HeaderPrimary);
builder->get_ParagraphFormat()->set_Alignment(ParagraphAlignment::Right);

// A SECTION field displays the number of the section it is in.
builder->Write(u"Section ");
auto fieldSection = System::DynamicCast<FieldSection>(builder->InsertField(FieldType::FieldSection, true));

ASSERT_EQ(u" SECTION ", fieldSection->GetFieldCode());

// A PAGE field displays the number of the page it is in.
builder->Write(u"\nPage ");
auto fieldPage = System::DynamicCast<FieldPage>(builder->InsertField(FieldType::FieldPage, true));

ASSERT_EQ(u" PAGE ", fieldPage->GetFieldCode());

// A SECTIONPAGES field displays the number of pages that the section it is in spans across.
builder->Write(u" of ");
auto fieldSectionPages = System::DynamicCast<FieldSectionPages>(builder->InsertField(FieldType::FieldSectionPages, true));

ASSERT_EQ(u" SECTIONPAGES ", fieldSectionPages->GetFieldCode());

// Move out of the header back into the main document and insert two pages.
// All these pages will be in the first section. Our fields, which appear once every header,
// will number the current/total pages of this section.
builder->MoveToDocumentEnd();
builder->InsertBreak(BreakType::PageBreak);
builder->InsertBreak(BreakType::PageBreak);

// We can insert a new section with the document builder like this.
// This will affect the values displayed in the SECTION and SECTIONPAGES fields in all upcoming headers.
builder->InsertBreak(BreakType::SectionBreakNewPage);

// The PAGE field will keep counting pages across the whole document.
// We can manually reset its count at each section to keep track of pages section-by-section.
builder->get_CurrentSection()->get_PageSetup()->set_RestartPageNumbering(true);
builder->InsertBreak(BreakType::PageBreak);

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.SECTION.SECTIONPAGES.docx");
```

## See Also

* Class [Field](../field/)
* Namespace [Aspose::Words::Fields](../)
* Library [Aspose.Words for C++](../../)
