---
title: ListFormat
second_title: Aspose.Words for C++ API Reference
description: Allows to control what list formatting is applied to a paragraph. 
type: docs
weight: 0
url: /cpp/aspose.words.lists/listformat/
---
## ListFormat class


Allows to control what list formatting is applied to a paragraph. 

## Methods

| Method | Description |
| --- | --- |
| void [ApplyBulletDefault](./applybulletdefault/)() | Starts a new default bulleted list and applies it to the paragraph.  |
| void [ApplyNumberDefault](./applynumberdefault/)() | Starts a new default numbered list and applies it to the paragraph.  |
| bool [get_IsListItem](./get_islistitem/)() | True when the paragraph has bulleted or numbered formatting applied to it.  |
| System::SharedPtr< Aspose::Words::Lists::List > [get_List](./get_list/)() | Gets or sets the list this paragraph is a member of.  |
| System::SharedPtr< Aspose::Words::Lists::ListLevel > [get_ListLevel](./get_listlevel/)() | Returns the list level formatting plus any formatting overrides applied to the current paragraph.  |
| int32_t [get_ListLevelNumber](./get_listlevelnumber/)() | Gets or sets the list level number (0 to 8) for the paragraph.  |
| void [ListIndent](./listindent/)() | Increases the list level of the current paragraph by one level.  |
| void [ListOutdent](./listoutdent/)() | Decreases the list level of the current paragraph by one level.  |
| void [RemoveNumbers](./removenumbers/)() | Removes numbers or bullets from the current paragraph and sets list level to zero.  |
| void [set_List](./set_list/)(const System::SharedPtr< Aspose::Words::Lists::List > &) | Setter for Aspose::Words::Lists::ListFormat::get_List.  |
| void [set_ListLevelNumber](./set_listlevelnumber/)(int32_t) | Setter for Aspose::Words::Lists::ListFormat::get_ListLevelNumber.  |
