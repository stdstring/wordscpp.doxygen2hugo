---
title: get_EntryIdentifier
second_title: Aspose.Words for C++ API Reference
description: Gets or sets a string that should match type identifiers of TC fields being included.
type: docs
weight: 66
url: /cpp/aspose.words.fields/fieldtoc/get_entryidentifier/
---
## FieldToc::get_EntryIdentifier method


Gets or sets a string that should match type identifiers of TC fields being included.

```cpp
System::String Aspose::Words::Fields::FieldToc::get_EntryIdentifier()
```


## Examples



Shows how to insert a TOC field, and filter which TC fields end up as entries. 
```cpp
void FieldTocEntryIdentifier()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    // Insert a TOC field, which will compile all TC fields into a table of contents.
    auto fieldToc = System::DynamicCast<FieldToc>(builder->InsertField(FieldType::FieldTOC, true));

    // Configure the field only to pick up TC entries of the "A" type, and an entry-level between 1 and 3.
    fieldToc->set_EntryIdentifier(u"A");
    fieldToc->set_EntryLevelRange(u"1-3");

    ASSERT_EQ(u" TOC  \\f A \\l 1-3", fieldToc->GetFieldCode());

    // These two entries will appear in the table.
    builder->InsertBreak(BreakType::PageBreak);
    InsertTocEntry(builder, u"TC field 1", u"A", u"1");
    InsertTocEntry(builder, u"TC field 2", u"A", u"2");

    ASSERT_EQ(u" TC  \"TC field 1\" \\n \\f A \\l 1", doc->get_Range()->get_Fields()->idx_get(1)->GetFieldCode());

    // This entry will be omitted from the table because it has a different type from "A".
    InsertTocEntry(builder, u"TC field 3", u"B", u"1");

    // This entry will be omitted from the table because it has an entry-level outside of the 1-3 range.
    InsertTocEntry(builder, u"TC field 4", u"A", u"5");

    doc->UpdateFields();
    doc->Save(ArtifactsDir + u"Field.TC.docx");
}

void InsertTocEntry(SharedPtr<DocumentBuilder> builder, String text, String typeIdentifier, String entryLevel)
{
    auto fieldTc = System::DynamicCast<FieldTC>(builder->InsertField(FieldType::FieldTOCEntry, true));
    fieldTc->set_OmitPageNumber(true);
    fieldTc->set_Text(text);
    fieldTc->set_TypeIdentifier(typeIdentifier);
    fieldTc->set_EntryLevel(entryLevel);
}
```

