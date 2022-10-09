---
title: IMailMergeDataSource
second_title: Aspose.Words for C++ API Reference
description: Implement this interface to allow mail merge from a custom data source, such as a list of objects. Master-detail data is also supported. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/imailmergedatasource/
---

Implement this interface to allow mail merge from a custom data source, such as a list of objects. Master-detail data is also supported. 

## Methods

| Method | Description |
| --- | --- |
| virtual [get_TableName](./get_tablename/)() | Returns the name of the data source.  |
| virtual [GetChildDataSource](./getchilddatasource/)(System::String) | The Aspose.Words mail merge engine invokes this method when it encounters a beginning of a nested mail merge region.  |
| virtual [GetValue](./getvalue/)(System::String, System::SharedPtr< System::Object > &) |  |
| virtual [MoveNext](./movenext/)() | Advances to the next record in the data source.  |
