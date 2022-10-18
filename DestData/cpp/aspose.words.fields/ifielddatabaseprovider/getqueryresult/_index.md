---
title: GetQueryResult
second_title: Aspose.Words for C++ API Reference
description: Returns query result. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/ifielddatabaseprovider/getqueryresult/
---
## IFieldDatabaseProvider.GetQueryResult method


Returns query result.

```cpp
virtual System::SharedPtr<Aspose::Words::Fields::FieldDatabaseDataTable> Aspose::Words::Fields::IFieldDatabaseProvider::GetQueryResult(System::String fileName, System::String connection, System::String query, System::SharedPtr<Aspose::Words::Fields::FieldDatabase> field)=0
```


| Parameter | Type | Description |
| --- | --- | --- |
| fileName | `-` | The complete path and file name of the database specified in the \d field switch. |
| connection | `-` | The connection to the data specified in the \c field switch. |
| query | `-` | The set of SQL instructions that query the database specified in the \s field switch. |
| field | `-` | The field being updated. |

### ReturnValue


The [FieldDatabaseDataTable](../../fielddatabasedatatable/) instance that should be used for the field's update.


