---
title: Aspose::Words::Document::get_DefaultTabStop method
linktitle: get_DefaultTabStop
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Document::get_DefaultTabStop method. Gets or sets the interval (in points) between the default tab stops in C++.'
type: docs
weight: 1900
url: /cpp/aspose.words/document/get_defaulttabstop/
---
## Document::get_DefaultTabStop method


Gets or sets the interval (in points) between the default tab stops.

```cpp
double Aspose::Words::Document::get_DefaultTabStop()
```


## Examples



Shows how to set a custom interval for tab stop positions. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Set tab stops to appear every 72 points (1 inch).
builder->get_Document()->set_DefaultTabStop(72);

// Each tab character snaps the text after it to the next closest tab stop position.
builder->Writeln(String(u"Hello") + ControlChar::Tab() + u"World!");
builder->Writeln(String(u"Hello") + ControlChar::TabChar + u"World!");
```

## See Also

* Class [Document](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
