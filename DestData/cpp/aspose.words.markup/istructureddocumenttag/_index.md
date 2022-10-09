---
title: IStructuredDocumentTag
second_title: Aspose.Words for C++ API Reference
description: Interface to define a common data for StructuredDocumentTag and StructuredDocumentTagRangeStart. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/istructureddocumenttag/
---

Interface to define a common data for StructuredDocumentTag and StructuredDocumentTagRangeStart. 

## Methods

| Method | Description |
| --- | --- |
| virtual [get_Color](./get_color/)() | Gets the color of the structured document tag.  |
| virtual [get_Id](./get_id/)() | Specifies a unique read-only persistent numerical Id for this **SDT**.  |
| virtual [get_IsShowingPlaceholderText](./get_isshowingplaceholdertext/)() | Specifies whether the content of this **SDT** shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| virtual [get_Level](./get_level/)() const | Gets the level at which this **SDT** occurs in the document tree.  |
| virtual [get_LockContentControl](./get_lockcontentcontrol/)() | When set to true, this property will prohibit a user from deleting this **SDT**.  |
| virtual [get_LockContents](./get_lockcontents/)() | When set to true, this property will prohibit a user from editing the contents of this **SDT**.  |
| virtual [get_Placeholder](./get_placeholder/)() | Gets the BuildingBlock containing placeholder text which should be displayed when this SDT run contents are empty, the associated mapped XML element is empty as specified via the XmlMapping element or the IsShowingPlaceholderText element is true.  |
| virtual [get_PlaceholderName](./get_placeholdername/)() | Gets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| virtual [get_SdtType](./get_sdttype/)() | Gets type of this **Structured document tag**.  |
| virtual [get_Tag](./get_tag/)() const | Specifies a tag associated with the current SDT node. Can not be null.  |
| virtual [get_Title](./get_title/)() const | Specifies the friendly name associated with this **SDT**. Can not be null.  |
| virtual [get_WordOpenXML](./get_wordopenxml/)() | Gets a string that represents the XML contained within the node in the FlatOpc format.  |
| virtual [get_XmlMapping](./get_xmlmapping/)() | Gets an object that represents the mapping of this structured document tag to XML data in a custom XML part of the current document.  |
| virtual [IsRanged](./isranged/)() | Returns true if this instance is a ranged structured document tag.  |
| virtual [set_Color](./set_color/)(System::Drawing::Color) | Sets the color of the structured document tag.  |
| virtual [set_IsShowingPlaceholderText](./set_isshowingplaceholdertext/)(bool) | Specifies whether the content of this **SDT** shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| virtual [set_LockContentControl](./set_lockcontentcontrol/)(bool) | When set to true, this property will prohibit a user from deleting this **SDT**.  |
| virtual [set_LockContents](./set_lockcontents/)(bool) | When set to true, this property will prohibit a user from editing the contents of this **SDT**.  |
| virtual [set_PlaceholderName](./set_placeholdername/)(System::String) | Sets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| virtual [set_Tag](./set_tag/)(System::String) | Specifies a tag associated with the current SDT node. Can not be null.  |
| virtual [set_Title](./set_title/)(System::String) | Specifies the friendly name associated with this **SDT**. Can not be null.  |
| virtual [StructuredDocumentTagNode](./structureddocumenttagnode/)() | Returns Node object that implements this interface.  |
