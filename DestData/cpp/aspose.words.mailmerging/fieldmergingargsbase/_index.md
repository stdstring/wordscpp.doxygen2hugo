---
title: FieldMergingArgsBase
second_title: Aspose.Words for C++ API Reference
description: Base class for FieldMergingArgs and ImageFieldMergingArgs. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/fieldmergingargsbase/
---
## FieldMergingArgsBase class


Base class for FieldMergingArgs and ImageFieldMergingArgs. 

## Methods

| Method | Description |
| --- | --- |
| const System::SharedPtr< Aspose::Words::Document > & [get_Document](./get_document/)() const | Returns the Document object for which the mail merge is performed.  |
| System::String [get_DocumentFieldName](./get_documentfieldname/)() const | Gets the name of the merge field as specified in the document.  |
| const System::SharedPtr< Aspose::Words::Fields::FieldMergeField > & [get_Field](./get_field/)() const | Gets the object that represents the current merge field.  |
| System::String [get_FieldName](./get_fieldname/)() const | Gets the name of the merge field in the data source.  |
| const System::SharedPtr< System::Object > & [get_FieldValue](./get_fieldvalue/)() const | Gets the value of the field from the data source.  |
| int32_t [get_RecordIndex](./get_recordindex/)() const | Gets the zero based index of the record that is being merged.  |
| System::String [get_TableName](./get_tablename/)() const | Gets the name of the data table for the current merge operation or empty string if the name is not available.  |
| void [set_FieldValue](./set_fieldvalue/)(const System::SharedPtr< System::Object > &) | Sets the value of the field from the data source.  |
