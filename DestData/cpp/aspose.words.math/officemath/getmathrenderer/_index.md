---
title: GetMathRenderer
second_title: Aspose.Words for C++ API Reference
description: Creates and returns an object that can be used to render this equation into an image.
type: docs
weight: 92
url: /cpp/aspose.words.math/officemath/getmathrenderer/
---
## OfficeMath::GetMathRenderer method


Creates and returns an object that can be used to render this equation into an image.

```cpp
System::SharedPtr<Aspose::Words::Rendering::OfficeMathRenderer> Aspose::Words::Math::OfficeMath::GetMathRenderer()
```


### ReturnValue

The renderer object for this equation.

This method just invokes the [OfficeMathRenderer](../../../aspose.words.rendering/officemathrenderer/) constructor and passes this object as a parameter.

## Examples




Shows how to render an Office [Math](../../) object into an image file in the local file system. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Office math.docx");

auto math = System::DynamicCast<OfficeMath>(doc->GetChild(NodeType::OfficeMath, 0, true));

// Create an "ImageSaveOptions" object to pass to the node renderer's "Save" method to modify
// how it renders the OfficeMath node into an image.
auto saveOptions = MakeObject<ImageSaveOptions>(SaveFormat::Png);

// Set the "Scale" property to 5 to render the object to five times its original size.
saveOptions->set_Scale(5.0f);

math->GetMathRenderer()->Save(ArtifactsDir + u"Shape.RenderOfficeMath.png", saveOptions);
```

