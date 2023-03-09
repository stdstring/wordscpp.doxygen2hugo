---
title: Aspose::Words::Fields::FieldIndex::get_CrossReferenceSeparator method
linktitle: get_CrossReferenceSeparator
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Fields::FieldIndex::get_CrossReferenceSeparator method. Gets or sets the character sequence that is used to separate cross references and other entries in C++.
type: docs
weight: 14
url: /cpp/aspose.words.fields/fieldindex/get_crossreferenceseparator/
---
## FieldIndex::get_CrossReferenceSeparator method


Gets or sets the character sequence that is used to separate cross references and other entries.

```cpp
System::String Aspose::Words::Fields::FieldIndex::get_CrossReferenceSeparator()
```


## Examples



Shows how to define cross references in an INDEX field. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Create an INDEX field which will display an entry for each XE field found in the document.
// Each entry will display the XE field's Text property value on the left side,
// and the number of the page that contains the XE field on the right.
// The INDEX entry will collect all XE fields with matching values in the "Text" property
// into one entry as opposed to making an entry for each XE field.
auto index = System::DynamicCast<FieldIndex>(builder->InsertField(FieldType::FieldIndex, true));

// We can configure an XE field to get its INDEX entry to display a string instead of a page number.
// First, for entries that substitute a page number with a string,
// specify a custom separator between the XE field's Text property value and the string.
index->set_CrossReferenceSeparator(u", see: ");

ASSERT_EQ(u" INDEX  \\k \", see: \"", index->GetFieldCode());

// Insert an XE field, which creates a regular INDEX entry which displays this field's page number,
// and does not invoke the CrossReferenceSeparator value.
// The entry for this XE field will display "Apple, 2".
builder->InsertBreak(BreakType::PageBreak);
auto indexEntry = System::DynamicCast<FieldXE>(builder->InsertField(FieldType::FieldIndexEntry, true));
indexEntry->set_Text(u"Apple");

ASSERT_EQ(u" XE  Apple", indexEntry->GetFieldCode());

// Insert another XE field on page 3 and set a value for the PageNumberReplacement property.
// This value will show up instead of the number of the page that this field is on,
// and the INDEX field's CrossReferenceSeparator value will appear in front of it.
// The entry for this XE field will display "Banana, see: Tropical fruit".
builder->InsertBreak(BreakType::PageBreak);
indexEntry = System::DynamicCast<FieldXE>(builder->InsertField(FieldType::FieldIndexEntry, true));
indexEntry->set_Text(u"Banana");
indexEntry->set_PageNumberReplacement(u"Tropical fruit");

ASSERT_EQ(u" XE  Banana \\t \"Tropical fruit\"", indexEntry->GetFieldCode());

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.INDEX.XE.CrossReferenceSeparator.docx");
```

## See Also

* Class [FieldIndex](../)
* Namespace [Aspose::Words::Fields](../../)
* Library [Aspose.Words for C++](../../../)
