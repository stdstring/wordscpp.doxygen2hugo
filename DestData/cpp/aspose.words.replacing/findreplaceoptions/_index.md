---
title: FindReplaceOptions
second_title: Aspose.Words for C++ API Reference
description: Specifies options for find/replace operations. 
type: docs
weight: 0
url: /cpp/aspose.words.replacing/findreplaceoptions/
---
## FindReplaceOptions class


Specifies options for find/replace operations. 

## Methods

| Method | Description |
| --- | --- |
|  [FindReplaceOptions](./findreplaceoptions/)() |  |
|  [FindReplaceOptions](./findreplaceoptions/)(Aspose::Words::Replacing::FindReplaceDirection) |  |
|  [FindReplaceOptions](./findreplaceoptions/)(Aspose::Words::Replacing::FindReplaceDirection, const System::SharedPtr< Aspose::Words::Replacing::IReplacingCallback > &) |  |
|  [FindReplaceOptions](./findreplaceoptions/)(const System::SharedPtr< Aspose::Words::Replacing::IReplacingCallback > &) |  |
| System::SharedPtr< Aspose::Words::Font > [get_ApplyFont](./get_applyfont/)() const | Text formatting applied to new content.  |
| System::SharedPtr< Aspose::Words::ParagraphFormat > [get_ApplyParagraphFormat](./get_applyparagraphformat/)() const | Paragraph formatting applied to new content.  |
| Aspose::Words::Replacing::FindReplaceDirection [get_Direction](./get_direction/)() const | Selects direction for replace. Default value is Forward.  |
| bool [get_FindWholeWordsOnly](./get_findwholewordsonly/)() const | True indicates the oldValue must be a standalone word.  |
| bool [get_IgnoreDeleted](./get_ignoredeleted/)() const | Gets or sets a boolean value indicating either to ignore text inside delete revisions. The default value is **false**.  |
| bool [get_IgnoreFieldCodes](./get_ignorefieldcodes/)() const | Gets or sets a boolean value indicating either to ignore text inside field codes. The default value is **false**.  |
| bool [get_IgnoreFields](./get_ignorefields/)() const | Gets or sets a boolean value indicating either to ignore text inside fields. The default value is **false**.  |
| bool [get_IgnoreFootnotes](./get_ignorefootnotes/)() const | Gets or sets a boolean value indicating either to ignore footnotes. The default value is **false**.  |
| bool [get_IgnoreInserted](./get_ignoreinserted/)() const | Gets or sets a boolean value indicating either to ignore text inside insert revisions. The default value is **false**.  |
| bool [get_LegacyMode](./get_legacymode/)() const | Gets or sets a boolean value indicating that old find/replace algorithm is used.  |
| bool [get_MatchCase](./get_matchcase/)() const | True indicates case-sensitive comparison, false indicates case-insensitive comparison.  |
| System::SharedPtr< Aspose::Words::Replacing::IReplacingCallback > [get_ReplacingCallback](./get_replacingcallback/)() const | The user-defined method which is called before every replace occurrence.  |
| bool [get_SmartParagraphBreakReplacement](./get_smartparagraphbreakreplacement/)() const | Gets or sets a boolean value indicating either it is allowed to replace paragraph break when there is no next sibling paragraph. The default value is **false**.  |
| bool [get_UseLegacyOrder](./get_uselegacyorder/)() const | True indicates that a text search is performed sequentially from top to bottom considering the text boxes. Default value is false.  |
| bool [get_UseSubstitutions](./get_usesubstitutions/)() const | Gets or sets a boolean value indicating whether to recognize and use substitutions within replacement patterns. The default value is **false**.  |
| void [set_Direction](./set_direction/)(Aspose::Words::Replacing::FindReplaceDirection) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_Direction.  |
| void [set_FindWholeWordsOnly](./set_findwholewordsonly/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_FindWholeWordsOnly.  |
| void [set_IgnoreDeleted](./set_ignoredeleted/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreDeleted.  |
| void [set_IgnoreFieldCodes](./set_ignorefieldcodes/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreFieldCodes.  |
| void [set_IgnoreFields](./set_ignorefields/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreFields.  |
| void [set_IgnoreFootnotes](./set_ignorefootnotes/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreFootnotes.  |
| void [set_IgnoreInserted](./set_ignoreinserted/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_IgnoreInserted.  |
| void [set_LegacyMode](./set_legacymode/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_LegacyMode.  |
| void [set_MatchCase](./set_matchcase/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_MatchCase.  |
| void [set_ReplacingCallback](./set_replacingcallback/)(const System::SharedPtr< Aspose::Words::Replacing::IReplacingCallback > &) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_ReplacingCallback.  |
| void [set_SmartParagraphBreakReplacement](./set_smartparagraphbreakreplacement/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_SmartParagraphBreakReplacement.  |
| void [set_UseLegacyOrder](./set_uselegacyorder/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_UseLegacyOrder.  |
| void [set_UseSubstitutions](./set_usesubstitutions/)(bool) | Setter for Aspose::Words::Replacing::FindReplaceOptions::get_UseSubstitutions.  |
