---
title: Aspose::Words::Markup
second_title: Aspose.Words for C++ API Reference
description: The Aspose.Words.Markup namespace contains classes that represent customer defined semantics in a document: smart tags, custom XML and structured document tags (content controls). 
type: docs
weight: 0
url: /cpp/aspose.words.markup/
---

The **Aspose.Words.Markup** namespace contains classes that represent customer defined semantics in a document: smart tags, custom XML and structured document tags (content controls). 

## Classes

| Class | Description |
| --- | --- |
| [custompart](./custompart/) | Represents a custom (arbitrary content) part, that is not defined by the ISO/IEC 29500 standard.  |
| [custompartcollection](./custompartcollection/) | Represents a collection of CustomPart objects.  |
| [customxmlpart](./customxmlpart/) | Represents a Custom XML Data Storage Part (custom XML data within a package).  |
| [customxmlpartcollection](./customxmlpartcollection/) | Represents a collection of Custom XML Parts. The items are CustomXmlPart objects.  |
| [customxmlproperty](./customxmlproperty/) | Represents a single custom XML attribute or a smart tag property.  |
| [customxmlpropertycollection](./customxmlpropertycollection/) | Represents a collection of custom XML attributes or smart tag properties.  |
| [customxmlschemacollection](./customxmlschemacollection/) | A collection of strings that represent XML schemas that are associated with a custom XML part.  |
| [sdtlistitem](./sdtlistitem/) | This element specifies a single list item within a parent ComboBox or DropDownList structured document tag.  |
| [sdtlistitemcollection](./sdtlistitemcollection/) | Provides access to SdtListItem elements of a structured document tag.  |
| [smarttag](./smarttag/) | This element specifies the presence of a smart tag around one or more inline structures (runs, images, fields,etc.) within a paragraph.  |
| [structureddocumenttag](./structureddocumenttag/) | Represents a structured document tag (SDT or content control) in a document.  |
| [structureddocumenttagcollection](./structureddocumenttagcollection/) | A collection of IStructuredDocumentTag instances that represent the structured document tags in the specified range.  |
| [structureddocumenttagrangeend](./structureddocumenttagrangeend/) | Represents an end of **ranged** structured document tag which accepts multi-sections content. See also StructuredDocumentTagRangeStart node.  |
| [structureddocumenttagrangestart](./structureddocumenttagrangestart/) | Represents a start of **ranged** structured document tag which accepts multi-sections content. See also StructuredDocumentTagRangeEnd.  |
| [xmlmapping](./xmlmapping/) | Specifies the information that is used to establish a mapping between the parent structured document tag and an XML element stored within a custom XML data part in the document.  |
## Interfaces

| Interface | Description |
| --- | --- |
| [istructureddocumenttag](./istructureddocumenttag/) | Interface to define a common data for StructuredDocumentTag and StructuredDocumentTagRangeStart.  |
## Enums

| Enum | Description |
| --- | --- |
| [MarkupLevel](./markuplevel/) | Specifies the level in the document tree where a particular StructuredDocumentTag can occur.  |
| [SdtAppearance](./sdtappearance/) | Specifies the appearance of a structured document tag.  |
| [SdtCalendarType](./sdtcalendartype/) | Specifies the possible types of calendars which can be used to specify CalendarType in an Office Open XML document.  |
| [SdtDateStorageFormat](./sdtdatestorageformat/) | Specifies how the date for a date SDT is stored/retrieved when the SDT is bound to an XML node in the document's data store.  |
| [SdtType](./sdttype/) | Specifies the type of a structured document tag (SDT) node.  |
