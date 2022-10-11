---
title: Odso
second_title: Aspose.Words for C++ API Reference
description: Specifies the Office Data Source Object (ODSO) settings for a mail merge data source. 
type: docs
weight: 0
url: /cpp/aspose.words.settings/odso/
---
## Odso class


Specifies the Office Data Source Object (ODSO) settings for a mail merge data source. 

## Methods

| Method | Description |
| --- | --- |
|  [Odso](./odso/)() |  |
| System::SharedPtr< Aspose::Words::Settings::Odso > [Clone](./clone/)() | Returns a deep clone of this object.  |
| char16_t [get_ColumnDelimiter](./get_columndelimiter/)() const | Specifies the character which shall be interpreted as the column delimiter used to separate columns within external data sources. The default value is 0 which means there is no column delimiter defined.  |
| System::String [get_DataSource](./get_datasource/)() const | Specifies the location of the external data source to be connected to a document to perform the mail merge. The default value is an empty string.  |
| Aspose::Words::Settings::OdsoDataSourceType [get_DataSourceType](./get_datasourcetype/)() const | Specifies the type of the external data source to be connected to as part of the ODSO connection information for this mail merge. The default value is Default.  |
| System::SharedPtr< Aspose::Words::Settings::OdsoFieldMapDataCollection > [get_FieldMapDatas](./get_fieldmapdatas/)() const | Gets a collection of objects that specify how columns from the external data source are mapped to the predefined merge field names in the document. This object is never null.  |
| bool [get_FirstRowContainsColumnNames](./get_firstrowcontainscolumnnames/)() const | Specifies that a hosting application shall treat the first row of data in the specified external data source as a header row containing the names of each column in the data source. The default value is **false**.  |
| System::SharedPtr< Aspose::Words::Settings::OdsoRecipientDataCollection > [get_RecipientDatas](./get_recipientdatas/)() const | Gets a collection of objects that specify inclusion/exclusion of individual records in the mail merge. This object is never null.  |
| System::String [get_TableName](./get_tablename/)() const | Specifies the particular set of data that a source shall be connected to within an external data source. The default value is an empty string.  |
| System::String [get_UdlConnectString](./get_udlconnectstring/)() const | Specifies the Universal Data Link (UDL) connection string used to connect to an external data source. The default value is an empty string.  |
| void [set_ColumnDelimiter](./set_columndelimiter/)(char16_t) | Setter for Aspose::Words::Settings::Odso::get_ColumnDelimiter.  |
| void [set_DataSource](./set_datasource/)(const System::String &) | Specifies the location of the external data source to be connected to a document to perform the mail merge. The default value is an empty string.  |
| void [set_DataSourceType](./set_datasourcetype/)(Aspose::Words::Settings::OdsoDataSourceType) | Setter for Aspose::Words::Settings::Odso::get_DataSourceType.  |
| void [set_FieldMapDatas](./set_fieldmapdatas/)(const System::SharedPtr< Aspose::Words::Settings::OdsoFieldMapDataCollection > &) | Sets a collection of objects that specify how columns from the external data source are mapped to the predefined merge field names in the document. This object is never null.  |
| void [set_FirstRowContainsColumnNames](./set_firstrowcontainscolumnnames/)(bool) | Setter for Aspose::Words::Settings::Odso::get_FirstRowContainsColumnNames.  |
| void [set_RecipientDatas](./set_recipientdatas/)(const System::SharedPtr< Aspose::Words::Settings::OdsoRecipientDataCollection > &) | Sets a collection of objects that specify inclusion/exclusion of individual records in the mail merge. This object is never null.  |
| void [set_TableName](./set_tablename/)(const System::String &) | Specifies the particular set of data that a source shall be connected to within an external data source. The default value is an empty string.  |
| void [set_UdlConnectString](./set_udlconnectstring/)(const System::String &) | Specifies the Universal Data Link (UDL) connection string used to connect to an external data source. The default value is an empty string.  |
