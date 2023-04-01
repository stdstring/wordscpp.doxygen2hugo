---
title: Aspose::Words::Saving::OdtSaveMeasureUnit enum
linktitle: OdtSaveMeasureUnit
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Saving::OdtSaveMeasureUnit enum. Specified units of measure to apply to measurable document content such as shape, widths and other during saving in C++.'
type: docs
weight: 6900
url: /cpp/aspose.words.saving/odtsavemeasureunit/
---
## OdtSaveMeasureUnit enum


Specified units of measure to apply to measurable document content such as shape, widths and other during saving.

```cpp
enum class OdtSaveMeasureUnit
```

### Values

| Name | Value | Description |
| --- | --- | --- |
| Centimeters | 0 | Specifies that the document content is saved using centimeters. |
| Inches | 1 | Specifies that the document content is saved using inches. |


## Examples



Shows how to use different measurement units to define style parameters of a saved ODT document. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Rendering.docx");

// When we export the document to .odt, we can use an OdtSaveOptions object to modify how we save the document.
// We can set the "MeasureUnit" property to "OdtSaveMeasureUnit.Centimeters"
// to define content such as style parameters using the metric system, which Open Office uses.
// We can set the "MeasureUnit" property to "OdtSaveMeasureUnit.Inches"
// to define content such as style parameters using the imperial system, which Microsoft Word uses.
auto saveOptions = MakeObject<OdtSaveOptions>();
saveOptions->set_MeasureUnit(odtSaveMeasureUnit);

doc->Save(ArtifactsDir + u"OdtSaveOptions.Odt11Schema.odt", saveOptions);
```

## See Also

* Namespace [Aspose::Words::Saving](../)
* Library [Aspose.Words for C++](../../)
