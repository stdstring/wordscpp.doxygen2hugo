---
title: MailMergeSettings
second_title: Aspose.Words for C++ API Reference
description: Specifies all of the mail merge information for a document. 
type: docs
weight: 0
url: /cpp/aspose.words.settings/mailmergesettings/
---

Specifies all of the mail merge information for a document. 

## Methods

| Method | Description |
| --- | --- |
| [MailMergeSettings](./mailmergesettings/)() |  |
| [Clear](./clear/)() | Clears the mail merge settings in such a way that when the document is saved, no mail merge settings will be saved and it will become a normal document.  |
| [Clone](./clone/)() | Returns a deep clone of this object.  |
| [get_ActiveRecord](./get_activerecord/)() const | Specifies the one-based index of the record from the data source which shall be displayed in Microsoft Word. The default value is 1.  |
| [get_AddressFieldName](./get_addressfieldname/)() const | Specifies the column within the data source that contains e-mail addresses. The default value is an empty string.  |
| [get_CheckErrors](./get_checkerrors/)() const | Specifies the type of error reporting which shall be conducted by Microsoft Word when performing a mail merge. The default value is Default.  |
| [get_ConnectString](./get_connectstring/)() const | Specifies the connection string used to connect to an external data source. The default value is an empty string.  |
| [get_DataSource](./get_datasource/)() const | Specifies the path to the mail-merge data source. The default value is an empty string.  |
| [get_DataType](./get_datatype/)() const | Specifies the type of the mail-merge data source and the method of data access. The default value is Default.  |
| [get_Destination](./get_destination/)() const | Specifies how Microsoft Word will output the results of a mail merge. The default value is Default.  |
| [get_DoNotSupressBlankLines](./get_donotsupressblanklines/)() const | Specifies how an application performing the mail merge shall handle blank lines in the merged documents resulting from the mail merge. The default value is **false**.  |
| [get_HeaderSource](./get_headersource/)() const | Specifies the path to the mail-merge header source. The default value is an empty string.  |
| [get_LinkToQuery](./get_linktoquery/)() const | Not sure about this one. The Microsoft Word Automation Reference suggests that this specifies that the query is executed every time the document is opened in Microsoft Word. But the OOXML specification suggests that this specifies that the query contains a reference to an external query file which contains the actual query. The default value is **false**.  |
| [get_MailAsAttachment](./get_mailasattachment/)() const | Specifies that the documents produced during a mail merge operation should be emailed as an attachment rather than the body of the actual e-mail. The default value is **false**.  |
| [get_MailSubject](./get_mailsubject/)() const | Specifies the text which shall appear in the subject line of the e-mails or faxes produced during mail merge. The default value is an empty string.  |
| [get_MainDocumentType](./get_maindocumenttype/)() const | Specifies the mail-merge main document type. The default value is Default.  |
| [get_Odso](./get_odso/)() const | Gets the object that specifies the Office Data Source Object (ODSO) settings.  |
| [get_Query](./get_query/)() const | Contains the Structured Query Language string that shall be run against the specified external data source to return the set of records which shall be imported into the document when the mail merge operation is performed. The default value is an empty string.  |
| [get_ViewMergedData](./get_viewmergeddata/)() const | Specifies that Microsoft Word shall display the data from the specified external data source where merge fields have been inserted (e.g. preview merged data). The default value is **false**.  |
| [set_ActiveRecord](./set_activerecord/)(int32_t) | Specifies the one-based index of the record from the data source which shall be displayed in Microsoft Word. The default value is 1.  |
| [set_AddressFieldName](./set_addressfieldname/)(const System::String &) | Specifies the column within the data source that contains e-mail addresses. The default value is an empty string.  |
| [set_CheckErrors](./set_checkerrors/)(Aspose::Words::Settings::MailMergeCheckErrors) | Specifies the type of error reporting which shall be conducted by Microsoft Word when performing a mail merge. The default value is Default.  |
| [set_ConnectString](./set_connectstring/)(const System::String &) | Specifies the connection string used to connect to an external data source. The default value is an empty string.  |
| [set_DataSource](./set_datasource/)(const System::String &) | Specifies the path to the mail-merge data source. The default value is an empty string.  |
| [set_DataType](./set_datatype/)(Aspose::Words::Settings::MailMergeDataType) | Specifies the type of the mail-merge data source and the method of data access. The default value is Default.  |
| [set_Destination](./set_destination/)(Aspose::Words::Settings::MailMergeDestination) | Specifies how Microsoft Word will output the results of a mail merge. The default value is Default.  |
| [set_DoNotSupressBlankLines](./set_donotsupressblanklines/)(bool) | Specifies how an application performing the mail merge shall handle blank lines in the merged documents resulting from the mail merge. The default value is **false**.  |
| [set_HeaderSource](./set_headersource/)(const System::String &) | Specifies the path to the mail-merge header source. The default value is an empty string.  |
| [set_LinkToQuery](./set_linktoquery/)(bool) | Setter for Aspose::Words::Settings::MailMergeSettings::get_LinkToQuery.  |
| [set_MailAsAttachment](./set_mailasattachment/)(bool) | Specifies that the documents produced during a mail merge operation should be emailed as an attachment rather than the body of the actual e-mail. The default value is **false**.  |
| [set_MailSubject](./set_mailsubject/)(const System::String &) | Specifies the text which shall appear in the subject line of the e-mails or faxes produced during mail merge. The default value is an empty string.  |
| [set_MainDocumentType](./set_maindocumenttype/)(Aspose::Words::Settings::MailMergeMainDocumentType) | Setter for Aspose::Words::Settings::MailMergeSettings::get_MainDocumentType.  |
| [set_Odso](./set_odso/)(const System::SharedPtr< Aspose::Words::Settings::Odso > &) | Sets the object that specifies the Office Data Source Object (ODSO) settings.  |
| [set_Query](./set_query/)(const System::String &) | Contains the Structured Query Language string that shall be run against the specified external data source to return the set of records which shall be imported into the document when the mail merge operation is performed. The default value is an empty string.  |
| [set_ViewMergedData](./set_viewmergeddata/)(bool) | Specifies that Microsoft Word shall display the data from the specified external data source where merge fields have been inserted (e.g. preview merged data). The default value is **false**.  |
