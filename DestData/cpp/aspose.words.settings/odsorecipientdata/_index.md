---
title: OdsoRecipientData
second_title: Aspose.Words for C++ API Reference
description: Represents information about a single record within an external data source that is to be excluded from the mail merge. 
type: docs
weight: 0
url: /cpp/aspose.words.settings/odsorecipientdata/
---
## OdsoRecipientData class


Represents information about a single record within an external data source that is to be excluded from the mail merge. 

## Methods

| Method | Description |
| --- | --- |
|  [OdsoRecipientData](./odsorecipientdata/)() |  |
| System::SharedPtr< Aspose::Words::Settings::OdsoRecipientData > [Clone](./clone/)() | Returns a deep clone of this object.  |
| bool [get_Active](./get_active/)() const | Specifies whether the record from the data source shall be imported into a document when the mail merge is performed. The default value is **true**.  |
| int32_t [get_Column](./get_column/)() const | Specifies the column within the data source that contains unique data for the current record. The default value is 0.  |
| int32_t [get_Hash](./get_hash/)() const | Represents the hash code for this record. Sometimes Microsoft Word uses Hash of a whole record instead of a UniqueTag value. The default value is 0.  |
| System::ArrayPtr< uint8_t > [get_UniqueTag](./get_uniquetag/)() const | Specifies the contents of a given record in the column containing unique data. The default value is **null**.  |
| void [set_Active](./set_active/)(bool) | Specifies whether the record from the data source shall be imported into a document when the mail merge is performed. The default value is **true**.  |
| void [set_Column](./set_column/)(int32_t) | Specifies the column within the data source that contains unique data for the current record. The default value is 0.  |
| void [set_Hash](./set_hash/)(int32_t) | Represents the hash code for this record. Sometimes Microsoft Word uses Hash of a whole record instead of a UniqueTag value. The default value is 0.  |
| void [set_UniqueTag](./set_uniquetag/)(const System::ArrayPtr< uint8_t > &) | Specifies the contents of a given record in the column containing unique data. The default value is **null**.  |
