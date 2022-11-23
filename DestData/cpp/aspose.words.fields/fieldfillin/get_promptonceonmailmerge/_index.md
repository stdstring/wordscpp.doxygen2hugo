---
title: get_PromptOnceOnMailMerge
second_title: Aspose.Words for C++ API Reference
description: Gets or sets whether the user response should be recieved once per a mail merge operation.
type: docs
weight: 14
url: /cpp/aspose.words.fields/fieldfillin/get_promptonceonmailmerge/
---
## FieldFillIn::get_PromptOnceOnMailMerge method


Gets or sets whether the user response should be recieved once per a mail merge operation.

```cpp
bool Aspose::Words::Fields::FieldFillIn::get_PromptOnceOnMailMerge()
```


## Examples



Shows how to use the FILLIN field to prompt the user for a response. 
```cpp
void FieldFillIn_()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    // Insert a FILLIN field. When we manually update this field in Microsoft Word,
    // it will prompt us to enter a response. The field will then display the response as text.
    auto field = System::DynamicCast<FieldFillIn>(builder->InsertField(FieldType::FieldFillIn, true));
    field->set_PromptText(u"Please enter a response:");
    field->set_DefaultResponse(u"A default response.");

    // We can also use these fields to ask the user for a unique response for each page
    // created during a mail merge done using Microsoft Word.
    field->set_PromptOnceOnMailMerge(true);

    ASSERT_EQ(u" FILLIN  \"Please enter a response:\" \\d \"A default response.\" \\o", field->GetFieldCode());

    auto mergeField = System::DynamicCast<FieldMergeField>(builder->InsertField(FieldType::FieldMergeField, true));
    mergeField->set_FieldName(u"MergeField");

    // If we perform a mail merge programmatically, we can use a custom prompt respondent
    // to automatically edit responses for FILLIN fields that the mail merge encounters.
    doc->get_FieldOptions()->set_UserPromptRespondent(MakeObject<ExField::PromptRespondent>());
    doc->get_MailMerge()->Execute(MakeArray<String>({u"MergeField"}), MakeArray<SharedPtr<System::Object>>({System::ObjectExt::Box<String>(u"")}));

    doc->UpdateFields();
    doc->Save(ArtifactsDir + u"Field.FILLIN.docx");
}

class PromptRespondent : public IFieldUserPromptRespondent
{
public:
    String Respond(String promptText, String defaultResponse) override
    {
        return String(u"Response modified by PromptRespondent. ") + defaultResponse;
    }
};
```

