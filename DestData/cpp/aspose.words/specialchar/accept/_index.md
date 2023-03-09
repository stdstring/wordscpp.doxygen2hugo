---
title: Aspose::Words::SpecialChar::Accept method
linktitle: Accept
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::SpecialChar::Accept method. Accepts a visitor in C++.
type: docs
weight: 1
url: /cpp/aspose.words/specialchar/accept/
---
## SpecialChar::Accept method


Accepts a visitor.

```cpp
bool Aspose::Words::SpecialChar::Accept(System::SharedPtr<Aspose::Words::DocumentVisitor> visitor) override
```


| Parameter | Type | Description |
| --- | --- | --- |
| visitor | System::SharedPtr\<Aspose::Words::DocumentVisitor\> | The visitor that will visit the node. |

### ReturnValue

False if the visitor requested the enumeration to stop.
## Remarks


Calls [DocumentVisitor.VisitSpecialChar](../../documentvisitor/visitspecialchar/).

For more info see the Visitor design pattern.

## See Also

* Class [DocumentVisitor](../../documentvisitor/)
* Class [SpecialChar](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
