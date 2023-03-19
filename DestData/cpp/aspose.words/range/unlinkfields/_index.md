---
title: Aspose::Words::Range::UnlinkFields method
linktitle: UnlinkFields
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Range::UnlinkFields method. Unlinks fields in this range in C++.
type: docs
weight: 1000
url: /cpp/aspose.words/range/unlinkfields/
---
## Range::UnlinkFields method


Unlinks fields in this range.

```cpp
void Aspose::Words::Range::UnlinkFields()
```

## Remarks


Replaces all the fields in this range with their most recent results.

To unlink fields in the whole document use [UnlinkFields](./).

## Examples



Shows how to unlink all fields in a range. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Linked fields.docx");

auto newSection = System::DynamicCast<Section>(doc->get_Sections()->idx_get(0)->Clone(true));
doc->get_Sections()->Add(newSection);

doc->get_Sections()->idx_get(1)->get_Range()->UnlinkFields();
```

## See Also

* Class [Range](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
