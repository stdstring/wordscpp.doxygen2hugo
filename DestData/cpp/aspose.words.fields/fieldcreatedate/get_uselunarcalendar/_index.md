---
title: Aspose::Words::Fields::FieldCreateDate::get_UseLunarCalendar method
linktitle: get_UseLunarCalendar
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Fields::FieldCreateDate::get_UseLunarCalendar method. Gets or sets whether to use the Hijri Lunar or Hebrew Lunar calendar in C++.
type: docs
weight: 100
url: /cpp/aspose.words.fields/fieldcreatedate/get_uselunarcalendar/
---
## FieldCreateDate::get_UseLunarCalendar method


Gets or sets whether to use the Hijri Lunar or Hebrew Lunar calendar.

```cpp
bool Aspose::Words::Fields::FieldCreateDate::get_UseLunarCalendar()
```


## Examples



Shows how to use the CREATEDATE field to display the creation date/time of the document. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Document.docx");
auto builder = MakeObject<DocumentBuilder>(doc);
builder->MoveToDocumentEnd();
builder->Writeln(u" Date this document was created:");

// We can use the CREATEDATE field to display the date and time of the creation of the document.
// Below are three different calendar types according to which the CREATEDATE field can display the date/time.
// 1 -  Islamic Lunar Calendar:
builder->Write(u"According to the Lunar Calendar - ");
auto field = System::DynamicCast<FieldCreateDate>(builder->InsertField(FieldType::FieldCreateDate, true));
field->set_UseLunarCalendar(true);

ASSERT_EQ(u" CREATEDATE  \\h", field->GetFieldCode());

// 2 -  Umm al-Qura calendar:
builder->Write(u"\nAccording to the Umm al-Qura Calendar - ");
field = System::DynamicCast<FieldCreateDate>(builder->InsertField(FieldType::FieldCreateDate, true));
field->set_UseUmAlQuraCalendar(true);

ASSERT_EQ(u" CREATEDATE  \\u", field->GetFieldCode());

// 3 -  Indian National Calendar:
builder->Write(u"\nAccording to the Indian National Calendar - ");
field = System::DynamicCast<FieldCreateDate>(builder->InsertField(FieldType::FieldCreateDate, true));
field->set_UseSakaEraCalendar(true);

ASSERT_EQ(u" CREATEDATE  \\s", field->GetFieldCode());

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.CREATEDATE.docx");
```

## See Also

* Class [FieldCreateDate](../)
* Namespace [Aspose::Words::Fields](../../)
* Library [Aspose.Words for C++](../../../)
