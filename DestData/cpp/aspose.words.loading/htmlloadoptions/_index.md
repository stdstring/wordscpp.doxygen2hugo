---
title: HtmlLoadOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify additional options when loading HTML document into a Document object. 
type: docs
weight: 0
url: /cpp/aspose.words.loading/htmlloadoptions/
---
## HtmlLoadOptions class


Allows to specify additional options when loading HTML document into a Document object. 

## Methods

| Method | Description |
| --- | --- |
|  [HtmlLoadOptions](./htmlloadoptions/)() | Initializes a new instance of this class with default values.  |
|  [HtmlLoadOptions](./htmlloadoptions/)(Aspose::Words::LoadFormat, const System::String &, const System::String &) | A shortcut to initialize a new instance of this class with properties set to the specified values.  |
|  [HtmlLoadOptions](./htmlloadoptions/)(const System::String &) | A shortcut to initialize a new instance of this class with the specified password to load an encrypted document.  |
| Aspose::Words::Loading::BlockImportMode [get_BlockImportMode](./get_blockimportmode/)() const | Gets a value that specifies how properties of block-level elements are imported. Default value is Merge.  |
| bool [get_ConvertSvgToEmf](./get_convertsvgtoemf/)() const | Gets or sets a value indicating whether to convert loaded SVG images to the EMF format. Default value is **false** and, if possible, loaded SVG images are stored as is without conversion.  |
| bool [get_IgnoreNoscriptElements](./get_ignorenoscriptelements/)() const | Gets a value indicating whether to ignore <noscript> HTML elements. Default value is **false**.  |
| Aspose::Words::Loading::HtmlControlType [get_PreferredControlType](./get_preferredcontroltype/)() const | Gets or sets preferred type of document nodes that will represent imported <input> and <select> elements. Default value is FormField.  |
| bool [get_SupportVml](./get_supportvml/)() const | Gets or sets a value indicating whether to support VML images.  |
| int32_t [get_WebRequestTimeout](./get_webrequesttimeout/)() const | The number of milliseconds to wait before the web request times out. The default value is 100000 milliseconds (100 seconds).  |
| void [set_BlockImportMode](./set_blockimportmode/)(Aspose::Words::Loading::BlockImportMode) | Sets a value that specifies how properties of block-level elements are imported. Default value is Merge.  |
| void [set_ConvertSvgToEmf](./set_convertsvgtoemf/)(bool) | Setter for Aspose::Words::Loading::HtmlLoadOptions::get_ConvertSvgToEmf.  |
| void [set_IgnoreNoscriptElements](./set_ignorenoscriptelements/)(bool) | Sets a value indicating whether to ignore <noscript> HTML elements. Default value is **false**.  |
| void [set_PreferredControlType](./set_preferredcontroltype/)(Aspose::Words::Loading::HtmlControlType) | Setter for Aspose::Words::Loading::HtmlLoadOptions::get_PreferredControlType.  |
| void [set_SupportVml](./set_supportvml/)(bool) | Setter for Aspose::Words::Loading::HtmlLoadOptions::get_SupportVml.  |
| void [set_WebRequestTimeout](./set_webrequesttimeout/)(int32_t) | Setter for Aspose::Words::Loading::HtmlLoadOptions::get_WebRequestTimeout.  |
