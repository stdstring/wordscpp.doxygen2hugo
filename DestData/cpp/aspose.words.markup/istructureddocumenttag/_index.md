---
title: IStructuredDocumentTag
second_title: Aspose.Words for C++ API Reference
description: Interface to define a common data for StructuredDocumentTag and StructuredDocumentTagRangeStart. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/istructureddocumenttag/
---
## IStructuredDocumentTag class


Interface to define a common data for StructuredDocumentTag and StructuredDocumentTagRangeStart. 

## Methods

| Method | Description |
| --- | --- |
| virtual System::Drawing::Color [get_Color](./get_color/)() | Gets the color of the structured document tag.  |
| virtual int32_t [get_Id](./get_id/)() | Specifies a unique read-only persistent numerical Id for this **SDT**.  |
| virtual bool [get_IsShowingPlaceholderText](./get_isshowingplaceholdertext/)() | Specifies whether the content of this **SDT** shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| virtual Aspose::Words::Markup::MarkupLevel [get_Level](./get_level/)() const | Gets the level at which this **SDT** occurs in the document tree.  |
| virtual bool [get_LockContentControl](./get_lockcontentcontrol/)() | When set to true, this property will prohibit a user from deleting this **SDT**.  |
| virtual bool [get_LockContents](./get_lockcontents/)() | When set to true, this property will prohibit a user from editing the contents of this **SDT**.  |
| virtual System::SharedPtr< Aspose::Words::BuildingBlocks::BuildingBlock > [get_Placeholder](./get_placeholder/)() | Gets the BuildingBlock containing placeholder text which should be displayed when this SDT run contents are empty, the associated mapped XML element is empty as specified via the XmlMapping element or the IsShowingPlaceholderText element is true.  |
| virtual System::String [get_PlaceholderName](./get_placeholdername/)() | Gets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| virtual Aspose::Words::Markup::SdtType [get_SdtType](./get_sdttype/)() | Gets type of this **Structured document tag**.  |
| virtual System::String [get_Tag](./get_tag/)() const | Specifies a tag associated with the current SDT node. Can not be null.  |
| virtual System::String [get_Title](./get_title/)() const | Specifies the friendly name associated with this **SDT**. Can not be null.  |
| virtual System::String [get_WordOpenXML](./get_wordopenxml/)() | Gets a string that represents the XML contained within the node in the FlatOpc format.  |
| virtual System::SharedPtr< Aspose::Words::Markup::XmlMapping > [get_XmlMapping](./get_xmlmapping/)() | Gets an object that represents the mapping of this structured document tag to XML data in a custom XML part of the current document.  |
| virtual bool [IsRanged](./isranged/)() | Returns true if this instance is a ranged structured document tag.  |
| virtual void [set_Color](./set_color/)(System::Drawing::Color) | Sets the color of the structured document tag.  |
| virtual void [set_IsShowingPlaceholderText](./set_isshowingplaceholdertext/)(bool) | Specifies whether the content of this **SDT** shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| virtual void [set_LockContentControl](./set_lockcontentcontrol/)(bool) | When set to true, this property will prohibit a user from deleting this **SDT**.  |
| virtual void [set_LockContents](./set_lockcontents/)(bool) | When set to true, this property will prohibit a user from editing the contents of this **SDT**.  |
| virtual void [set_PlaceholderName](./set_placeholdername/)(System::String) | Sets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| virtual void [set_Tag](./set_tag/)(System::String) | Specifies a tag associated with the current SDT node. Can not be null.  |
| virtual void [set_Title](./set_title/)(System::String) | Specifies the friendly name associated with this **SDT**. Can not be null.  |
| virtual System::SharedPtr< Aspose::Words::Node > [StructuredDocumentTagNode](./structureddocumenttagnode/)() | Returns Node object that implements this interface.  |
