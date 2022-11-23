---
title: GetCulture
second_title: Aspose.Words for C++ API Reference
description: Returns a CultureInfo object to be used during the field's update.
type: docs
weight: 1
url: /cpp/aspose.words.fields/ifieldupdatecultureprovider/getculture/
---
## IFieldUpdateCultureProvider::GetCulture method


Returns a **CultureInfo** object to be used during the field's update.

```cpp
virtual System::SharedPtr<System::Globalization::CultureInfo> Aspose::Words::Fields::IFieldUpdateCultureProvider::GetCulture(System::String culture, System::SharedPtr<Aspose::Words::Fields::Field> field)=0
```


| Parameter | Type | Description |
| --- | --- | --- |
| culture | System::String | The name of the culture requested for the field being updated. |
| field | System::SharedPtr\<Aspose::Words::Fields::Field\> | The field being updated. |

### ReturnValue

The culture object that should be used for the field's update.

## Examples



Shows how to specify a culture which parses date/time formatting for each field. 
```cpp
void DefineDateTimeFormatting()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    builder->InsertField(FieldType::FieldTime, true);

    doc->get_FieldOptions()->set_FieldUpdateCultureSource(FieldUpdateCultureSource::FieldCode);

    // Set a provider that returns a culture object specific to each field.
    doc->get_FieldOptions()->set_FieldUpdateCultureProvider(MakeObject<ExFieldOptions::FieldUpdateCultureProvider>());

    auto fieldDate = System::DynamicCast<FieldTime>(doc->get_Range()->get_Fields()->idx_get(0));
    if (fieldDate->get_LocaleId() != (int)EditingLanguage::Russian)
    {
        fieldDate->set_LocaleId((int)EditingLanguage::Russian);
    }

    doc->Save(ArtifactsDir + u"FieldOptions.UpdateDateTimeFormatting.pdf");
}

class FieldUpdateCultureProvider : public IFieldUpdateCultureProvider
{
public:
    SharedPtr<System::Globalization::CultureInfo> GetCulture(String name, SharedPtr<Field> field) override
    {
        if (name == u"ru-RU")
        {
            auto culture = MakeObject<System::Globalization::CultureInfo>(name, false);
            SharedPtr<System::Globalization::DateTimeFormatInfo> format = culture->get_DateTimeFormat();
            format->set_MonthNames(MakeArray<String>({u"месяц 1", u"месяц 2", u"месяц 3", u"месяц 4", u"месяц 5", u"месяц 6", u"месяц 7", u"месяц 8",
                                                      u"месяц 9", u"месяц 10", u"месяц 11", u"месяц 12", u""}));
            format->set_MonthGenitiveNames(format->get_MonthNames());
            format->set_AbbreviatedMonthNames(MakeArray<String>(
                {u"мес 1", u"мес 2", u"мес 3", u"мес 4", u"мес 5", u"мес 6", u"мес 7", u"мес 8", u"мес 9", u"мес 10", u"мес 11", u"мес 12", u""}));
            format->set_AbbreviatedMonthGenitiveNames(format->get_AbbreviatedMonthNames());
            format->set_DayNames(MakeArray<String>(
                {u"день недели 7", u"день недели 1", u"день недели 2", u"день недели 3", u"день недели 4", u"день недели 5", u"день недели 6"}));
            format->set_AbbreviatedDayNames(MakeArray<String>({u"день 7", u"день 1", u"день 2", u"день 3", u"день 4", u"день 5", u"день 6"}));
            format->set_ShortestDayNames(MakeArray<String>({u"д7", u"д1", u"д2", u"д3", u"д4", u"д5", u"д6"}));
            format->set_AMDesignator(u"До полудня");
            format->set_PMDesignator(u"После полудня");
            const String pattern = u"yyyy MM (MMMM) dd (dddd) hh:mm:ss tt";
            format->set_LongDatePattern(pattern);
            format->set_LongTimePattern(pattern);
            format->set_ShortDatePattern(pattern);
            format->set_ShortTimePattern(pattern);
            return culture;
        }
        else if (name == u"en-US")
        {
            return MakeObject<System::Globalization::CultureInfo>(name, false);
        }
        else
        {
            return nullptr;
        }
    }
};
```

