---
title: List
second_title: Aspose.Words for C++ API Reference
description: Represents formatting of a list. 
type: docs
weight: 0
url: /cpp/aspose.words.lists/list/
---
## List class


Represents formatting of a list. 

## Methods

| Method | Description |
| --- | --- |
| int32_t [CompareTo](./compareto/)(System::SharedPtr< Aspose::Words::Lists::List >) override | Compares the specified list to the current list.  |
| bool [Equals](./equals/)(const System::SharedPtr< Aspose::Words::Lists::List > &) | Compares with the specified list.  |
| bool [Equals](./equals/)(System::SharedPtr< System::Object >) override |  |
| System::SharedPtr< Aspose::Words::DocumentBase > [get_Document](./get_document/)() const | Gets the owner document.  |
| bool [get_IsListStyleDefinition](./get_isliststyledefinition/)() | Returns true if this list is a definition of a list style.  |
| bool [get_IsListStyleReference](./get_isliststylereference/)() | Returns true if this list is a reference to a list style.  |
| bool [get_IsMultiLevel](./get_ismultilevel/)() | Returns true when the list contains 9 levels; false when 1 level.  |
| bool [get_IsRestartAtEachSection](./get_isrestartateachsection/)() | Specifies whether list should be restarted at each section. Default value is **false**.  |
| int32_t [get_ListId](./get_listid/)() const | Gets the unique identifier of the list.  |
| System::SharedPtr< Aspose::Words::Lists::ListLevelCollection > [get_ListLevels](./get_listlevels/)() | Gets the collection of list levels for this list.  |
| System::SharedPtr< Aspose::Words::Style > [get_Style](./get_style/)() | Gets the list style that this list references or defines.  |
| int32_t [GetHashCode](./gethashcode/)() const override | Calculates hash code for this list object.  |
| void [set_IsRestartAtEachSection](./set_isrestartateachsection/)(bool) | Setter for Aspose::Words::Lists::List::get_IsRestartAtEachSection.  |
