---
title: FontInfoSubstitutionRule
second_title: Aspose.Words for C++ API Reference
description: Font info substitution rule. 
type: docs
weight: 92
url: /cpp/aspose.words.fonts/fontinfosubstitutionrule/
---
## FontInfoSubstitutionRule class


[Font](../aspose.words/font/) info substitution rule.

```cpp
class FontInfoSubstitutionRule : public Aspose::Words::Fonts::FontSubstitutionRule
```

## Methods

| Method | Description |
| --- | --- |
| virtual [get_Enabled](../fontsubstitutionrule/get_enabled/)() | Specifies whether the rule is enabled or not. |
| virtual [set_Enabled](../fontsubstitutionrule/set_enabled/)(bool) | Setter for [Aspose::Words::Fonts::FontSubstitutionRule::get_Enabled](../fontsubstitutionrule/get_enabled/). |

## Examples




Shows how to set the property for finding the closest match for a missing font from the available font sources. 
```cpp
void EnableFontSubstitution()
{
    // Open a document that contains text formatted with a font that does not exist in any of our font sources.
    auto doc = MakeObject<Document>(MyDir + u"Missing font.docx");

    // Assign a callback for handling font substitution warnings.
    auto substitutionWarningHandler = MakeObject<ExFontSettings::HandleDocumentSubstitutionWarnings>();
    doc->set_WarningCallback(substitutionWarningHandler);

    // Set a default font name and enable font substitution.
    auto fontSettings = MakeObject<FontSettings>();
    fontSettings->get_SubstitutionSettings()->get_DefaultFontSubstitution()->set_DefaultFontName(u"Arial");
    ;
    fontSettings->get_SubstitutionSettings()->get_FontInfoSubstitution()->set_Enabled(true);

    // We will get a font substitution warning if we save a document with a missing font.
    doc->set_FontSettings(fontSettings);
    doc->Save(ArtifactsDir + u"FontSettings.EnableFontSubstitution.pdf");

    {
        SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<WarningInfo>>> warnings = substitutionWarningHandler->FontWarnings->GetEnumerator();
        while (warnings->MoveNext())
        {
            std::cout << warnings->get_Current()->get_Description() << std::endl;
        }
    }

    // We can also verify warnings in the collection and clear them.
    ASSERT_EQ(WarningSource::Layout, substitutionWarningHandler->FontWarnings->idx_get(0)->get_Source());
    ASSERT_EQ(u"Font '28 Days Later' has not been found. Using 'Calibri' font instead. Reason: alternative name from document.",
              substitutionWarningHandler->FontWarnings->idx_get(0)->get_Description());

    substitutionWarningHandler->FontWarnings->Clear();

    ASSERT_EQ(0, substitutionWarningHandler->FontWarnings->get_Count());
}

class HandleDocumentSubstitutionWarnings : public IWarningCallback
{
public:
    SharedPtr<WarningInfoCollection> FontWarnings;

    void Warning(SharedPtr<WarningInfo> info) override
    {
        if (info->get_WarningType() == WarningType::FontSubstitution)
        {
            FontWarnings->Warning(info);
        }
    }

    HandleDocumentSubstitutionWarnings() : FontWarnings(MakeObject<WarningInfoCollection>())
    {
    }
};
```

