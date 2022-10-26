---
title: get_FlatOpcXmlMappingOnly
second_title: Aspose.Words for C++ API Reference
description: Gets or sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.
type: docs
weight: 92
url: /cpp/aspose.words.saving/saveoptions/get_flatopcxmlmappingonly/
---
## SaveOptions.get_FlatOpcXmlMappingOnly method


Gets or sets value determining which document formats are allowed to be mapped by [XmlMapping](../../../aspose.words.markup/structureddocumenttag/get_xmlmapping/). By default only **FlatOpc** document format is allowed to be mapped.

```cpp
bool Aspose::Words::Saving::SaveOptions::get_FlatOpcXmlMappingOnly() const
```


## Examples




Shows how to binding structured document tags to any format. 
```cpp
// If true - SDT will contain raw HTML text.
// If false - mapped HTML will parsed and resulting document will be inserted into SDT content.
auto loadOptions = MakeObject<LoadOptions>();
loadOptions->set_FlatOpcXmlMappingOnly(isFlatOpcXmlMappingOnly);
auto doc = MakeObject<Document>(MyDir + u"Structured document tag with HTML content.docx", loadOptions);

SharedPtr<SaveOptions> saveOptions = SaveOptions::CreateSaveOptions(SaveFormat::Pdf);
saveOptions->set_FlatOpcXmlMappingOnly(isFlatOpcXmlMappingOnly);

doc->Save(ArtifactsDir + u"LoadOptions.FlatOpcXmlMappingOnly.pdf", saveOptions);
```

