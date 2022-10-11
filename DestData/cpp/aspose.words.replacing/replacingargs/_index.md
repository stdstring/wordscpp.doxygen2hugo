---
title: ReplacingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for a custom replace operation. 
type: docs
weight: 0
url: /cpp/aspose.words.replacing/replacingargs/
---
## ReplacingArgs class


Provides data for a custom replace operation. 

## Methods

| Method | Description |
| --- | --- |
| int32_t [get_GroupIndex](./get_groupindex/)() const | Identifies, by index, a captured group in the Match that is to be replaced with the Replacement string.  |
| System::String [get_GroupName](./get_groupname/)() const | Identifies, by name, a captured group in the Match that is to be replaced with the Replacement string.  |
| System::SharedPtr< System::Text::RegularExpressions::Match > [get_Match](./get_match/)() const | The Match resulting from a single regular expression match during a **Replace**.  |
| System::SharedPtr< Aspose::Words::Node > [get_MatchNode](./get_matchnode/)() const | Gets the node that contains the beginning of the match.  |
| int32_t [get_MatchOffset](./get_matchoffset/)() const | Gets the zero-based starting position of the match from the start of the node that contains the beginning of the match.  |
| System::String [get_Replacement](./get_replacement/)() const | Gets or sets the replacement string.  |
| void [set_GroupIndex](./set_groupindex/)(int32_t) | Setter for Aspose::Words::Replacing::ReplacingArgs::get_GroupIndex.  |
| void [set_GroupName](./set_groupname/)(const System::String &) | Setter for Aspose::Words::Replacing::ReplacingArgs::get_GroupName.  |
| void [set_Replacement](./set_replacement/)(const System::String &) | Setter for Aspose::Words::Replacing::ReplacingArgs::get_Replacement.  |
