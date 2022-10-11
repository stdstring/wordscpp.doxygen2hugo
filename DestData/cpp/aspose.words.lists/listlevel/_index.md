---
title: ListLevel
second_title: Aspose.Words for C++ API Reference
description: Defines formatting for a list level. 
type: docs
weight: 0
url: /cpp/aspose.words.lists/listlevel/
---
## ListLevel class


Defines formatting for a list level. 

## Methods

| Method | Description |
| --- | --- |
| void [CreatePictureBullet](./createpicturebullet/)() | Creates picture bullet shape for the current list level.  |
| void [DeletePictureBullet](./deletepicturebullet/)() | Deletes picture bullet for the current list level.  |
| bool [Equals](./equals/)(const System::SharedPtr< Aspose::Words::Lists::ListLevel > &) | Compares with the specified ListLevel.  |
| Aspose::Words::Lists::ListLevelAlignment [get_Alignment](./get_alignment/)() const | Gets or sets the justification of the actual number of the list item.  |
| System::String [get_CustomNumberStyleFormat](./get_customnumberstyleformat/)() | Gets the custom number style format for this list level. For example: "a, ç, ĝ, ...".  |
| System::SharedPtr< Aspose::Words::Font > [get_Font](./get_font/)() | Specifies character formatting used for the list label.  |
| System::SharedPtr< Aspose::Words::Drawing::ImageData > [get_ImageData](./get_imagedata/)() | Returns image data of the picture bullet shape for the current list level.  |
| bool [get_IsLegal](./get_islegal/)() const | True if the level turns all inherited numbers to Arabic, false if it preserves their number style.  |
| System::SharedPtr< Aspose::Words::Style > [get_LinkedStyle](./get_linkedstyle/)() | Gets or sets the paragraph style that is linked to this list level.  |
| System::String [get_NumberFormat](./get_numberformat/)() const | Returns or sets the number format for the list level.  |
| double [get_NumberPosition](./get_numberposition/)() const | Returns or sets the position (in points) of the number or bullet for the list level.  |
| Aspose::Words::NumberStyle [get_NumberStyle](./get_numberstyle/)() const | Returns or sets the number style for this list level.  |
| int32_t [get_RestartAfterLevel](./get_restartafterlevel/)() const | Sets or returns the list level that must appear before the specified list level restarts numbering.  |
| int32_t [get_StartAt](./get_startat/)() | Returns or sets the starting number for this list level.  |
| double [get_TabPosition](./get_tabposition/)() const | Returns or sets the tab position (in points) for the list level.  |
| double [get_TextPosition](./get_textposition/)() const | Returns or sets the position (in points) for the second line of wrapping text for the list level.  |
| Aspose::Words::Lists::ListTrailingCharacter [get_TrailingCharacter](./get_trailingcharacter/)() const | Returns or sets the character inserted after the number for the list level.  |
| int32_t [GetHashCode](./gethashcode/)() const override | Calculates hash code for this object.  |
| void [set_Alignment](./set_alignment/)(Aspose::Words::Lists::ListLevelAlignment) | Setter for Aspose::Words::Lists::ListLevel::get_Alignment.  |
| void [set_IsLegal](./set_islegal/)(bool) | Setter for Aspose::Words::Lists::ListLevel::get_IsLegal.  |
| void [set_LinkedStyle](./set_linkedstyle/)(const System::SharedPtr< Aspose::Words::Style > &) | Setter for Aspose::Words::Lists::ListLevel::get_LinkedStyle.  |
| void [set_NumberFormat](./set_numberformat/)(const System::String &) | Setter for Aspose::Words::Lists::ListLevel::get_NumberFormat.  |
| void [set_NumberPosition](./set_numberposition/)(double) | Setter for Aspose::Words::Lists::ListLevel::get_NumberPosition.  |
| void [set_NumberStyle](./set_numberstyle/)(Aspose::Words::NumberStyle) | Setter for Aspose::Words::Lists::ListLevel::get_NumberStyle.  |
| void [set_RestartAfterLevel](./set_restartafterlevel/)(int32_t) | Setter for Aspose::Words::Lists::ListLevel::get_RestartAfterLevel.  |
| void [set_StartAt](./set_startat/)(int32_t) | Setter for Aspose::Words::Lists::ListLevel::get_StartAt.  |
| void [set_TabPosition](./set_tabposition/)(double) | Setter for Aspose::Words::Lists::ListLevel::get_TabPosition.  |
| void [set_TextPosition](./set_textposition/)(double) | Setter for Aspose::Words::Lists::ListLevel::get_TextPosition.  |
| void [set_TrailingCharacter](./set_trailingcharacter/)(Aspose::Words::Lists::ListTrailingCharacter) | Setter for Aspose::Words::Lists::ListLevel::get_TrailingCharacter.  |
| static System::String [GetEffectiveValue](./geteffectivevalue/)(int32_t, Aspose::Words::NumberStyle, const System::String &) | Reports the string representation of the ListLevel object for the specified index of the list item. Parameters specify the NumberStyle and an optional format string used when Custom is specified.  |
