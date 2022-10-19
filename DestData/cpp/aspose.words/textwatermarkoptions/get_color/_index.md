---
title: get_Color
second_title: Aspose.Words for C++ API Reference
description: Gets or sets font color. The default value is Color.Silver. 
type: docs
weight: 14
url: /cpp/aspose.words/textwatermarkoptions/get_color/
---
## TextWatermarkOptions.get_Color method


Gets or sets font color. The default value is Color.Silver.

```cpp
System::Drawing::Color Aspose::Words::TextWatermarkOptions::get_Color() const
```


## Examples




Shows how to create a text watermark. 
```cpp
auto doc = MakeObject<Document>();

// Add a plain text watermark.
doc->get_Watermark()->SetText(u"Aspose Watermark");

// If we wish to edit the text formatting using it as a watermark,
// we can do so by passing a TextWatermarkOptions object when creating the watermark.
auto textWatermarkOptions = MakeObject<TextWatermarkOptions>();
textWatermarkOptions->set_FontFamily(u"Arial");
textWatermarkOptions->set_FontSize(36.0f);
textWatermarkOptions->set_Color(System::Drawing::Color::get_Black());
textWatermarkOptions->set_Layout(WatermarkLayout::Diagonal);
textWatermarkOptions->set_IsSemitrasparent(false);

doc->get_Watermark()->SetText(u"Aspose Watermark", textWatermarkOptions);

doc->Save(ArtifactsDir + u"Document.TextWatermark.docx");

// We can remove a watermark from a document like this.
if (doc->get_Watermark()->get_Type() == WatermarkType::Text)
{
    doc->get_Watermark()->Remove();
}
```

