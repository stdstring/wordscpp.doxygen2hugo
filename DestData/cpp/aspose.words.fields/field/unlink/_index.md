---
title: Unlink
second_title: Aspose.Words for C++ API Reference
description: Performs the field unlink. 
type: docs
weight: 235
url: /cpp/aspose.words.fields/field/unlink/
---
## Field.Unlink method


Performs the field unlink.

```cpp
bool Aspose::Words::Fields::Field::Unlink()
```


### ReturnValue


**True** if the field has been unlinked, otherwise **false**.

Replaces the field with its most recent result.

Some fields, such as XE (Index Entry) fields and SEQ (Sequence) fields, cannot be unlinked.

## Examples




Shows how to unlink a field. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Linked fields.docx");
doc->get_Range()->get_Fields()->idx_get(1)->Unlink();
```

