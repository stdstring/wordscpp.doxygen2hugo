---
title: Aspose::Words::Saving::SaveOptions::get_DmlEffectsRenderingMode method
linktitle: get_DmlEffectsRenderingMode
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Saving::SaveOptions::get_DmlEffectsRenderingMode method. Gets or sets a value determining how DrawingML effects are rendered in C++.'
type: docs
weight: 500
url: /cpp/aspose.words.saving/saveoptions/get_dmleffectsrenderingmode/
---
## SaveOptions::get_DmlEffectsRenderingMode method


Gets or sets a value determining how DrawingML effects are rendered.

```cpp
virtual Aspose::Words::Saving::DmlEffectsRenderingMode Aspose::Words::Saving::SaveOptions::get_DmlEffectsRenderingMode()
```

## Remarks


The default value is [Simplified](../../dmleffectsrenderingmode/).

This property is used when the document is exported to fixed page formats.

## Examples



Shows how to configure the rendering quality of DrawingML effects in a document as we save it to PDF. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"DrawingML shape effects.docx");

// Create a "PdfSaveOptions" object that we can pass to the document's "Save" method
// to modify how that method converts the document to .PDF.
auto options = MakeObject<PdfSaveOptions>();

// Set the "DmlEffectsRenderingMode" property to "DmlEffectsRenderingMode.None" to discard all DrawingML effects.
// Set the "DmlEffectsRenderingMode" property to "DmlEffectsRenderingMode.Simplified"
// to render a simplified version of DrawingML effects.
// Set the "DmlEffectsRenderingMode" property to "DmlEffectsRenderingMode.Fine" to
// render DrawingML effects with more accuracy and also with more processing cost.
options->set_DmlEffectsRenderingMode(effectsRenderingMode);

ASSERT_EQ(DmlRenderingMode::DrawingML, options->get_DmlRenderingMode());

doc->Save(ArtifactsDir + u"PdfSaveOptions.DrawingMLEffects.pdf", options);
```

## See Also

* Enum [DmlEffectsRenderingMode](../../dmleffectsrenderingmode/)
* Class [SaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
