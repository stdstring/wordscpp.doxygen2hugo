---
title: Style
second_title: Aspose.Words for C++ API Reference
description: Represents a single built-in or user-defined style. 
type: docs
weight: 0
url: /cpp/aspose.words/style/
---
## Style class


Represents a single built-in or user-defined style. 

## Methods

| Method | Description |
| --- | --- |
| bool [Equals](./equals/)(const System::SharedPtr< Aspose::Words::Style > &) | Compares with the specified style. Styles Istds are compared for built-in styles only. Styles defaults are not included in comparison. Base style, linked style and next paragraph style are recursively compared.  |
| System::ArrayPtr< System::String > [get_Aliases](./get_aliases/)() | Gets all aliases of this style. If style has no aliases then empty array of string is returned.  |
| System::String [get_BaseStyleName](./get_basestylename/)() | Gets/sets the name of the style this style is based on.  |
| bool [get_BuiltIn](./get_builtin/)() | True if this style is one of the built-in styles in MS Word.  |
| System::SharedPtr< Aspose::Words::DocumentBase > [get_Document](./get_document/)() | Gets the owner document.  |
| System::SharedPtr< Aspose::Words::Font > [get_Font](./get_font/)() | Gets the character formatting of the style.  |
| bool [get_IsHeading](./get_isheading/)() | True when the style is one of the built-in Heading styles.  |
| bool [get_IsQuickStyle](./get_isquickstyle/)() const | Specifies whether this style is shown in the Quick Style gallery inside MS Word UI.  |
| System::String [get_LinkedStyleName](./get_linkedstylename/)() | Gets the name of the Style linked to this one. Returns Empty string if no styles are linked.  |
| System::SharedPtr< Aspose::Words::Lists::List > [get_List](./get_list/)() | Gets the list that defines formatting of this list style.  |
| System::SharedPtr< Aspose::Words::Lists::ListFormat > [get_ListFormat](./get_listformat/)() | Provides access to the list formatting properties of a paragraph style.  |
| System::String [get_Name](./get_name/)() const | Gets or sets the name of the style.  |
| System::String [get_NextParagraphStyleName](./get_nextparagraphstylename/)() | Gets/sets the name of the style to be applied automatically to a new paragraph inserted after a paragraph formatted with the specified style.  |
| System::SharedPtr< Aspose::Words::ParagraphFormat > [get_ParagraphFormat](./get_paragraphformat/)() | Gets the paragraph formatting of the style.  |
| Aspose::Words::StyleIdentifier [get_StyleIdentifier](./get_styleidentifier/)() const | Gets the locale independent style identifier for a built-in style.  |
| System::SharedPtr< Aspose::Words::StyleCollection > [get_Styles](./get_styles/)() const | Gets the collection of styles this style belongs to.  |
| Aspose::Words::StyleType [get_Type](./get_type/)() const | Gets the style type (paragraph or character).  |
| void [Remove](./remove/)() | Removes the specified style from the document.  |
| void [set_BaseStyleName](./set_basestylename/)(const System::String &) | Setter for Aspose::Words::Style::get_BaseStyleName.  |
| void [set_IsQuickStyle](./set_isquickstyle/)(bool) | Setter for Aspose::Words::Style::get_IsQuickStyle.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Style::get_Name.  |
| void [set_NextParagraphStyleName](./set_nextparagraphstylename/)(const System::String &) | Setter for Aspose::Words::Style::get_NextParagraphStyleName.  |
