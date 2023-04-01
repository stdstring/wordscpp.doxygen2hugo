---
title: Aspose::Words::Fields::IFieldDatabaseProvider::GetQueryResult method
linktitle: GetQueryResult
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Fields::IFieldDatabaseProvider::GetQueryResult method. Returns query result in C++.'
type: docs
weight: 100
url: /cpp/aspose.words.fields/ifielddatabaseprovider/getqueryresult/
---
## IFieldDatabaseProvider::GetQueryResult method


Returns query result.

```cpp
virtual System::SharedPtr<Aspose::Words::Fields::FieldDatabaseDataTable> Aspose::Words::Fields::IFieldDatabaseProvider::GetQueryResult(System::String fileName, System::String connection, System::String query, System::SharedPtr<Aspose::Words::Fields::FieldDatabase> field)=0
```


| Parameter | Type | Description |
| --- | --- | --- |
| fileName | System::String | The complete path and file name of the database specified in the \d field switch. |
| connection | System::String | The connection to the data specified in the \c field switch. |
| query | System::String | The set of SQL instructions that query the database specified in the \s field switch. |
| field | System::SharedPtr\<Aspose::Words::Fields::FieldDatabase\> | The field being updated. |

### ReturnValue

The [FieldDatabaseDataTable](../../fielddatabasedatatable/) instance that should be used for the field's update.

## See Also

* Class [FieldDatabaseDataTable](../../fielddatabasedatatable/)
* Class [FieldDatabase](../../fielddatabase/)
* Interface [IFieldDatabaseProvider](../)
* Namespace [Aspose::Words::Fields](../../)
* Library [Aspose.Words for C++](../../../)
