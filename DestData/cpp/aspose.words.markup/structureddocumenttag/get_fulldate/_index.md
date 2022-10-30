---
title: get_FullDate
second_title: Aspose.Words for C++ API Reference
description: Specifies the full date and time last entered into this SDT.
type: docs
weight: 183
url: /cpp/aspose.words.markup/structureddocumenttag/get_fulldate/
---
## StructuredDocumentTag::get_FullDate method


Specifies the full date and time last entered into this **SDT**.

```cpp
System::DateTime Aspose::Words::Markup::StructuredDocumentTag::get_FullDate()
```


Accessing this property will only work for **Date** SDT type.

For all other SDT types exception will occur.

## Examples




Shows how to prompt the user to enter a date with a structured document tag. 
```cpp
auto doc = MakeObject<Document>();

// Insert a structured document tag that prompts the user to enter a date.
// In Microsoft Word, this element is known as a "Date picker content control".
// When we click on the arrow on the right end of this tag in Microsoft Word,
// we will see a pop up in the form of a clickable calendar.
// We can use that popup to select a date that the tag will display.
auto sdtDate = MakeObject<StructuredDocumentTag>(doc, SdtType::Date, MarkupLevel::Inline);

// Display the date, according to the Saudi Arabian Arabic locale.
sdtDate->set_DateDisplayLocale(System::Globalization::CultureInfo::GetCultureInfo(u"ar-SA")->get_LCID());

// Set the format with which to display the date.
sdtDate->set_DateDisplayFormat(u"dd MMMM, yyyy");
sdtDate->set_DateStorageFormat(SdtDateStorageFormat::DateTime);

// Display the date according to the Hijri calendar.
sdtDate->set_CalendarType(SdtCalendarType::Hijri);

// Before the user chooses a date in Microsoft Word, the tag will display the text "Click here to enter a date.".
// According to the tag's calendar, set the "FullDate" property to get the tag to display a default date.
sdtDate->set_FullDate(System::DateTime(1440, 10, 20));

auto builder = MakeObject<DocumentBuilder>(doc);
builder->InsertNode(sdtDate);

doc->Save(ArtifactsDir + u"StructuredDocumentTag.Date.docx");
```

