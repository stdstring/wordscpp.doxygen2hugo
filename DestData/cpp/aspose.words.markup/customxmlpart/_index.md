---
title: CustomXmlPart
second_title: Aspose.Words for C++ API Reference
description: Represents a Custom XML Data Storage Part (custom XML data within a package). 
type: docs
weight: 0
url: /cpp/aspose.words.markup/customxmlpart/
---
## CustomXmlPart class


Represents a Custom XML Data Storage Part (custom XML data within a package). 

## Methods

| Method | Description |
| --- | --- |
|  [CustomXmlPart](./customxmlpart/)() |  |
| System::SharedPtr< Aspose::Words::Markup::CustomXmlPart > [Clone](./clone/)() | Makes a "deep enough" copy of the object. Does not duplicate the bytes of the Data value.  |
| System::ArrayPtr< uint8_t > [get_Data](./get_data/)() const | Gets or sets the XML content of this Custom XML Data Storage Part.  |
| int64_t [get_DataChecksum](./get_datachecksum/)() | Specifies a cyclic redundancy check (CRC) checksum of the Data content.  |
| System::String [get_Id](./get_id/)() const | Gets or sets the string that identifies this custom XML part within an OOXML document.  |
| System::SharedPtr< Aspose::Words::Markup::CustomXmlSchemaCollection > [get_Schemas](./get_schemas/)() const | Specifies the set of XML schemas that are associated with this custom XML part.  |
| void [set_Data](./set_data/)(const System::ArrayPtr< uint8_t > &) | Setter for Aspose::Words::Markup::CustomXmlPart::get_Data.  |
| void [set_Id](./set_id/)(const System::String &) | Setter for Aspose::Words::Markup::CustomXmlPart::get_Id.  |
