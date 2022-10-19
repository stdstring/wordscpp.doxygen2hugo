---
title: get_FieldName
second_title: Aspose.Words for C++ API Reference
description: Gets the name of the merge field in the data source. 
type: docs
weight: 40
url: /cpp/aspose.words.mailmerging/fieldmergingargsbase/get_fieldname/
---
## FieldMergingArgsBase.get_FieldName method


Gets the name of the merge field in the data source.

```cpp
System::String Aspose::Words::MailMerging::FieldMergingArgsBase::get_FieldName() const
```


If you have a mapping from a document field name to a different data source field name, then this is the mapped field name.

If you specified a field name prefix, for example "Image:MyFieldName" in the document, then **FieldName** returns field name without the prefix, that is "MyFieldName". 
