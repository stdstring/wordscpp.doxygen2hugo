---
title: TableSubstitutionRule
second_title: Aspose.Words for C++ API Reference
description: Table font substitution rule. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/tablesubstitutionrule/
---
## TableSubstitutionRule class


Table font substitution rule.

```cpp
class TableSubstitutionRule : public Aspose::Words::Fonts::FontSubstitutionRule
```

## Methods

| Method | Description |
| --- | --- |
| [AddSubstitutes](./addsubstitutes/)(const System::String\&, const System::ArrayPtr\<System::String\>\&) | Adds substitute font names for given original font name. |
| virtual [get_Enabled](../fontsubstitutionrule/get_enabled/)() | Specifies whether the rule is enabled or not. |
| [GetSubstitutes](./getsubstitutes/)(const System::String\&) | Returns array containing substitute font names for the specified original font name. |
| [Load](./load/)(const System::String\&) | Loads table substitution settings from XML file. |
| [Load](./load/)(const System::SharedPtr\<System::IO::Stream\>\&) | Loads table substitution settings from XML stream. |
| [LoadAndroidSettings](./loadandroidsettings/)() | Loads predefined table substitution settings for Linux platform. |
| [LoadLinuxSettings](./loadlinuxsettings/)() | Loads predefined table substitution settings for Linux platform. |
| [LoadWindowsSettings](./loadwindowssettings/)() | Loads predefined table substitution settings for Windows platform. |
| [Save](./save/)(const System::String\&) | Saves the current table substitution settings to file. |
| [Save](./save/)(const System::SharedPtr\<System::IO::Stream\>\&) | Saves the current table substitution settings to stream. |
| virtual [set_Enabled](../fontsubstitutionrule/set_enabled/)(bool) | Setter for [Aspose::Words::Fonts::FontSubstitutionRule::get_Enabled](../fontsubstitutionrule/get_enabled/). |
| [SetSubstitutes](./setsubstitutes/)(const System::String\&, const System::ArrayPtr\<System::String\>\&) | Override substitute font names for given original font name. |

## Examples




Shows how to access font substitution tables for Windows and Linux. 
```cpp
auto doc = MakeObject<Document>();
auto fontSettings = MakeObject<FontSettings>();
doc->set_FontSettings(fontSettings);

// Create a new table substitution rule and load the default Microsoft Windows font substitution table.
SharedPtr<TableSubstitutionRule> tableSubstitutionRule = fontSettings->get_SubstitutionSettings()->get_TableSubstitution();
tableSubstitutionRule->LoadWindowsSettings();

// In Windows, the default substitute for the "Times New Roman CE" font is "Times New Roman".
ASPOSE_ASSERT_EQ(MakeArray<String>({u"Times New Roman"}), tableSubstitutionRule->GetSubstitutes(u"Times New Roman CE")->LINQ_ToArray());

// We can save the table in the form of an XML document.
tableSubstitutionRule->Save(ArtifactsDir + u"FontSettings.TableSubstitutionRule.Windows.xml");

// Linux has its own substitution table.
// There are multiple substitute fonts for "Times New Roman CE".
// If the first substitute, "FreeSerif" is also unavailable,
// this rule will cycle through the others in the array until it finds an available one.
tableSubstitutionRule->LoadLinuxSettings();
ASPOSE_ASSERT_EQ(MakeArray<String>({u"FreeSerif", u"Liberation Serif", u"DejaVu Serif"}),
                 tableSubstitutionRule->GetSubstitutes(u"Times New Roman CE")->LINQ_ToArray());

// Save the Linux substitution table in the form of an XML document using a stream.
{
    auto fileStream = MakeObject<System::IO::FileStream>(ArtifactsDir + u"FontSettings.TableSubstitutionRule.Linux.xml", System::IO::FileMode::Create);
    tableSubstitutionRule->Save(fileStream);
}
```

