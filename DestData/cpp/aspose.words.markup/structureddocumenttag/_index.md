---
title: StructuredDocumentTag
second_title: Aspose.Words for C++ API Reference
description: Represents a structured document tag (SDT or content control) in a document. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/structureddocumenttag/
---
## StructuredDocumentTag class


Represents a structured document tag (SDT or content control) in a document. 

## Methods

| Method | Description |
| --- | --- |
|  [StructuredDocumentTag](./structureddocumenttag/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, Aspose::Words::Markup::SdtType, Aspose::Words::Markup::MarkupLevel) | Initializes a new instance of the **Structured document tag** class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| void [Clear](./clear/)() | Clears contents of this structured document tag and displays a placeholder if it is defined.  |
| Aspose::Words::Markup::SdtAppearance [get_Appearance](./get_appearance/)() const | Gets/sets the appearance of a structured document tag.  |
| System::String [get_BuildingBlockCategory](./get_buildingblockcategory/)() | Specifies category of building block for this **SDT** node. Can not be null.  |
| System::String [get_BuildingBlockGallery](./get_buildingblockgallery/)() | Specifies type of building block for this **SDT**. Can not be null.  |
| Aspose::Words::Markup::SdtCalendarType [get_CalendarType](./get_calendartype/)() | Specifies the type of calendar for this **SDT**. Default is Default |
| bool [get_Checked](./get_checked/)() | Gets/Sets current state of the Checkbox **SDT**. Default value for this property is false.  |
| System::Drawing::Color [get_Color](./get_color/)() override | Gets or sets the color of the structured document tag.  |
| System::SharedPtr< Aspose::Words::Font > [get_ContentsFont](./get_contentsfont/)() | Font formatting that will be applied to text entered into **SDT**.  |
| System::String [get_DateDisplayFormat](./get_datedisplayformat/)() | String that represents the format in which dates are displayed. Can not be null.  |
| int32_t [get_DateDisplayLocale](./get_datedisplaylocale/)() | Allows to set/get the language format for the date displayed in this **SDT**.  |
| Aspose::Words::Markup::SdtDateStorageFormat [get_DateStorageFormat](./get_datestorageformat/)() | Gets/sets format in which the date for a date SDT is stored when the **SDT** is bound to an XML node in the document's data store. Default value is DateTime |
| System::SharedPtr< Aspose::Words::Font > [get_EndCharacterFont](./get_endcharacterfont/)() | Font formatting that will be applied to the last character of text entered into **SDT**.  |
| System::DateTime [get_FullDate](./get_fulldate/)() | Specifies the full date and time last entered into this **SDT**.  |
| int32_t [get_Id](./get_id/)() override | Specifies a unique read-only persistent numerical Id for this **SDT**.  |
| bool [get_IsShowingPlaceholderText](./get_isshowingplaceholdertext/)() override | Specifies whether the content of this **SDT** shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| bool [get_IsTemporary](./get_istemporary/)() const | Specifies whether this **SDT** shall be removed from the WordProcessingML document when its contents are modified.  |
| Aspose::Words::Markup::MarkupLevel [get_Level](./get_level/)() const override | Gets the level at which this **SDT** occurs in the document tree.  |
| System::SharedPtr< Aspose::Words::Markup::SdtListItemCollection > [get_ListItems](./get_listitems/)() | Gets SdtListItemCollection associated with this **SDT**.  |
| bool [get_LockContentControl](./get_lockcontentcontrol/)() override | When set to true, this property will prohibit a user from deleting this **SDT**.  |
| bool [get_LockContents](./get_lockcontents/)() override | When set to true, this property will prohibit a user from editing the contents of this **SDT**.  |
| bool [get_Multiline](./get_multiline/)() | Specifies whether this **SDT** allows multiple lines of text.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.StructuredDocumentTag**.  |
| System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock > [get_Placeholder](./get_placeholder/)() override | Gets the BuildingBlock containing placeholder text which should be displayed when this SDT run contents are empty, the associated mapped XML element is empty as specified via the XmlMapping element or the IsShowingPlaceholderText element is true.  |
| System::String [get_PlaceholderName](./get_placeholdername/)() override | Gets or sets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| Aspose::Words::Markup::SdtType [get_SdtType](./get_sdttype/)() override | Gets type of this **Structured document tag**.  |
| System::SharedPtr< Aspose::Words::Style > [get_Style](./get_style/)() | Gets or sets the Style of the structured document tag.  |
| System::String [get_StyleName](./get_stylename/)() | Gets or sets the name of the style applied to the structured document tag.  |
| System::String [get_Tag](./get_tag/)() const override | Specifies a tag associated with the current SDT node. Can not be null.  |
| System::String [get_Title](./get_title/)() const override | Specifies the friendly name associated with this **SDT**. Can not be null.  |
| System::String [get_WordOpenXML](./get_wordopenxml/)() override | Gets a string that represents the XML contained within the node in the FlatOpc format.  |
| System::SharedPtr< Aspose::Words::Markup::XmlMapping > [get_XmlMapping](./get_xmlmapping/)() override | Gets an object that represents the mapping of this structured document tag to XML data in a custom XML part of the current document.  |
| void [RemoveSelfOnly](./removeselfonly/)() | Removes just this SDT node itself, but keeps the content of it inside the document tree.  |
| void [set_Appearance](./set_appearance/)(Aspose::Words::Markup::SdtAppearance) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Appearance.  |
| void [set_BuildingBlockCategory](./set_buildingblockcategory/)(const System::String &) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_BuildingBlockCategory.  |
| void [set_BuildingBlockGallery](./set_buildingblockgallery/)(const System::String &) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_BuildingBlockGallery.  |
| void [set_CalendarType](./set_calendartype/)(Aspose::Words::Markup::SdtCalendarType) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_CalendarType.  |
| void [set_Checked](./set_checked/)(bool) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Checked.  |
| void [set_Color](./set_color/)(System::Drawing::Color) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Color.  |
| void [set_DateDisplayFormat](./set_datedisplayformat/)(const System::String &) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_DateDisplayFormat.  |
| void [set_DateDisplayLocale](./set_datedisplaylocale/)(int32_t) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_DateDisplayLocale.  |
| void [set_DateStorageFormat](./set_datestorageformat/)(Aspose::Words::Markup::SdtDateStorageFormat) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_DateStorageFormat.  |
| void [set_FullDate](./set_fulldate/)(System::DateTime) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_FullDate.  |
| void [set_IsShowingPlaceholderText](./set_isshowingplaceholdertext/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_IsShowingPlaceholderText.  |
| void [set_IsTemporary](./set_istemporary/)(bool) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_IsTemporary.  |
| void [set_LockContentControl](./set_lockcontentcontrol/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_LockContentControl.  |
| void [set_LockContents](./set_lockcontents/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_LockContents.  |
| void [set_Multiline](./set_multiline/)(bool) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Multiline.  |
| void [set_PlaceholderName](./set_placeholdername/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_PlaceholderName.  |
| void [set_Style](./set_style/)(const System::SharedPtr< Aspose::Words::Style > &) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Style.  |
| void [set_StyleName](./set_stylename/)(const System::String &) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_StyleName.  |
| void [set_Tag](./set_tag/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Tag.  |
| void [set_Title](./set_title/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Title.  |
| void [SetCheckedSymbol](./setcheckedsymbol/)(int32_t, const System::String &) | Sets the symbol used to represent the checked state of a check box content control.  |
| void [SetUncheckedSymbol](./setuncheckedsymbol/)(int32_t, const System::String &) | Sets the symbol used to represent the unchecked state of a check box content control.  |
