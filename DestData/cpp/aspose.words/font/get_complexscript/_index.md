---
title: Aspose::Words::Font::get_ComplexScript method
linktitle: get_ComplexScript
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Font::get_ComplexScript method. Specifies whether the contents of this run shall be treated as complex script text regardless of their Unicode character values when determining the formatting for this run in C++.
type: docs
weight: 900
url: /cpp/aspose.words/font/get_complexscript/
---
## Font::get_ComplexScript method


Specifies whether the contents of this run shall be treated as complex script text regardless of their Unicode character values when determining the formatting for this run.

```cpp
bool Aspose::Words::Font::get_ComplexScript()
```


## Examples



Shows how to add text that is always treated as complex script. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_Font()->set_ComplexScript(true);

builder->Writeln(u"Text treated as complex script.");

doc->Save(ArtifactsDir + u"Font.ComplexScript.docx");
```

## See Also

* Class [Font](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
