---
title: Aspose::Words::Saving::PclSaveOptions::AddPrinterFont method
linktitle: AddPrinterFont
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Saving::PclSaveOptions::AddPrinterFont method. Adds information about font that is uploaded to the printer by manufacturer in C++.'
type: docs
weight: 200
url: /cpp/aspose.words.saving/pclsaveoptions/addprinterfont/
---
## PclSaveOptions::AddPrinterFont method


Adds information about font that is uploaded to the printer by manufacturer.

```cpp
void Aspose::Words::Saving::PclSaveOptions::AddPrinterFont(const System::String &fontFullName, const System::String &fontPclName)
```


| Parameter | Type | Description |
| --- | --- | --- |
| fontFullName | const System::String\& | Full name of the font (e.g. "Times New Roman Bold Italic"). |
| fontPclName | const System::String\& | Name of the font that is used in Pcl document. |

## Examples



Shows how to get a printer to substitute all instances of a specific font with a different font. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_Font()->set_Name(u"Courier");
builder->Write(u"Hello world!");

auto saveOptions = MakeObject<PclSaveOptions>();
saveOptions->AddPrinterFont(u"Courier New", u"Courier");

// When printing this document, the printer will use the "Courier New" font
// to access places where our document used the "Courier" font.
doc->Save(ArtifactsDir + u"PclSaveOptions.AddPrinterFont.pcl", saveOptions);
```

## See Also

* Class [PclSaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
