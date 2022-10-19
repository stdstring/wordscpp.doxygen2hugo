---
title: HtmlLoadOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify additional options when loading HTML document into a Document object. 
type: docs
weight: 27
url: /cpp/aspose.words.loading/htmlloadoptions/
---
## HtmlLoadOptions class


Allows to specify additional options when loading HTML document into a [Document](../aspose.words/document/) object.

```cpp
class HtmlLoadOptions : public Aspose::Words::Loading::LoadOptions
```

## Methods

| Method | Description |
| --- | --- |
| [get_BaseUri](../loadoptions/get_baseuri/)() const | Gets or sets the string that will be used to resolve relative URIs found in the document into absolute URIs when required. Can be null or empty string. Default is null. |
| [get_BlockImportMode](./get_blockimportmode/)() const | Gets a value that specifies how properties of block-level elements are imported. Default value is **Merge**. |
| [get_ConvertMetafilesToPng](../loadoptions/get_convertmetafilestopng/)() const | Gets or sets whether to convert metafile (**Wmf** or **Emf**) images to **Png** image format. |
| [get_ConvertShapeToOfficeMath](../loadoptions/get_convertshapetoofficemath/)() const | Gets or sets whether to convert shapes with EquationXML to Office [Math](../../aspose.words.math/) objects. |
| [get_ConvertSvgToEmf](./get_convertsvgtoemf/)() const | Gets or sets a value indicating whether to convert loaded SVG images to the EMF format. Default value is **false** and, if possible, loaded SVG images are stored as is without conversion. |
| [get_Encoding](../loadoptions/get_encoding/)() const | Gets or sets the encoding that will be used to load an HTML, TXT, or CHM document if the encoding is not specified inside the document. Can be null. Default is null. |
| [get_FlatOpcXmlMappingOnly](../loadoptions/get_flatopcxmlmappingonly/)() const | Gets value determining which document formats are allowed to be mapped by [XmlMapping](../../aspose.words.markup/structureddocumenttag/get_xmlmapping/). By default only **FlatOpc** document format is allowed to be mapped. |
| [get_FontSettings](../loadoptions/get_fontsettings/)() const | Allows to specify document font settings. |
| [get_IgnoreNoscriptElements](./get_ignorenoscriptelements/)() const | Gets a value indicating whether to ignore <noscript> HTML elements. Default value is **false**. |
| [get_LanguagePreferences](../loadoptions/get_languagepreferences/)() const | Gets language preferences that will be used when document is loading. |
| [get_LoadFormat](../loadoptions/get_loadformat/)() const | Specifies the format of the document to be loaded. Default is **Auto**. |
| [get_MswVersion](../loadoptions/get_mswversion/)() const | Allows to specify that the document loading process should match a specific MS Word version. Default value is **Word2019** |
| [get_Password](../loadoptions/get_password/)() const | Gets or sets the password for opening an encrypted document. Can be null or empty string. Default is null. |
| [get_PreferredControlType](./get_preferredcontroltype/)() const | Gets or sets preferred type of document nodes that will represent imported <input> and <select> elements. Default value is **FormField**. |
| [get_PreserveIncludePictureField](../loadoptions/get_preserveincludepicturefield/)() const | Gets or sets whether to preserve the INCLUDEPICTURE field when reading Microsoft Word formats. The default value is false. |
| [get_ProgressCallback](../loadoptions/get_progresscallback/)() const | Called during loading a document and accepts data about loading progress. |
| [get_ResourceLoadingCallback](../loadoptions/get_resourceloadingcallback/)() const | Allows to control how external resources (images, style sheets) are loaded when a document is imported from HTML, MHTML. |
| [get_SupportVml](./get_supportvml/)() const | Gets or sets a value indicating whether to support VML images. |
| [get_TempFolder](../loadoptions/get_tempfolder/)() const | Allows to use temporary files when reading document. By default this property is **null** and no temporary files are used. |
| [get_UpdateDirtyFields](../loadoptions/get_updatedirtyfields/)() const | Specifies whether to update the fields with the **dirty** attribute. |
| [get_WarningCallback](../loadoptions/get_warningcallback/)() const | Called during a load operation, when an issue is detected that might result in data or formatting fidelity loss. |
| [get_WebRequestTimeout](./get_webrequesttimeout/)() const | The number of milliseconds to wait before the web request times out. The default value is 100000 milliseconds (100 seconds). |
| [HtmlLoadOptions](./htmlloadoptions/)() | Initializes a new instance of this class with default values. |
| [HtmlLoadOptions](./htmlloadoptions/)(const System::String\&) | A shortcut to initialize a new instance of this class with the specified password to load an encrypted document. |
| [HtmlLoadOptions](./htmlloadoptions/)(Aspose::Words::LoadFormat, const System::String\&, const System::String\&) | A shortcut to initialize a new instance of this class with properties set to the specified values. |
| [LoadOptions](../loadoptions/loadoptions/)() | Initializes a new instance of this class with default values. |
| [LoadOptions](../loadoptions/loadoptions/)(const System::String\&) | A shortcut to initialize a new instance of this class with the specified password to load an encrypted document. |
| [LoadOptions](../loadoptions/loadoptions/)(Aspose::Words::LoadFormat, const System::String\&, const System::String\&) | A shortcut to initialize a new instance of this class with properties set to the specified values. |
| [set_BaseUri](../loadoptions/set_baseuri/)(const System::String\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_BaseUri](../loadoptions/get_baseuri/). |
| [set_BlockImportMode](./set_blockimportmode/)(Aspose::Words::Loading::BlockImportMode) | Sets a value that specifies how properties of block-level elements are imported. Default value is **Merge**. |
| [set_ConvertMetafilesToPng](../loadoptions/set_convertmetafilestopng/)(bool) | Setter for [Aspose::Words::Loading::LoadOptions::get_ConvertMetafilesToPng](../loadoptions/get_convertmetafilestopng/). |
| [set_ConvertShapeToOfficeMath](../loadoptions/set_convertshapetoofficemath/)(bool) | Setter for [Aspose::Words::Loading::LoadOptions::get_ConvertShapeToOfficeMath](../loadoptions/get_convertshapetoofficemath/). |
| [set_ConvertSvgToEmf](./set_convertsvgtoemf/)(bool) | Setter for [Aspose::Words::Loading::HtmlLoadOptions::get_ConvertSvgToEmf](./get_convertsvgtoemf/). |
| [set_Encoding](../loadoptions/set_encoding/)(const System::SharedPtr\<System::Text::Encoding\>\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_Encoding](../loadoptions/get_encoding/). |
| [set_FlatOpcXmlMappingOnly](../loadoptions/set_flatopcxmlmappingonly/)(bool) | Sets value determining which document formats are allowed to be mapped by [XmlMapping](../../aspose.words.markup/structureddocumenttag/get_xmlmapping/). By default only **FlatOpc** document format is allowed to be mapped. |
| [set_FontSettings](../loadoptions/set_fontsettings/)(const System::SharedPtr\<Aspose::Words::Fonts::FontSettings\>\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_FontSettings](../loadoptions/get_fontsettings/). |
| [set_IgnoreNoscriptElements](./set_ignorenoscriptelements/)(bool) | Sets a value indicating whether to ignore <noscript> HTML elements. Default value is **false**. |
| [set_LoadFormat](../loadoptions/set_loadformat/)(Aspose::Words::LoadFormat) | Setter for [Aspose::Words::Loading::LoadOptions::get_LoadFormat](../loadoptions/get_loadformat/). |
| [set_MswVersion](../loadoptions/set_mswversion/)(Aspose::Words::Settings::MsWordVersion) | Setter for [Aspose::Words::Loading::LoadOptions::get_MswVersion](../loadoptions/get_mswversion/). |
| [set_Password](../loadoptions/set_password/)(const System::String\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_Password](../loadoptions/get_password/). |
| [set_PreferredControlType](./set_preferredcontroltype/)(Aspose::Words::Loading::HtmlControlType) | Setter for [Aspose::Words::Loading::HtmlLoadOptions::get_PreferredControlType](./get_preferredcontroltype/). |
| [set_PreserveIncludePictureField](../loadoptions/set_preserveincludepicturefield/)(bool) | Setter for [Aspose::Words::Loading::LoadOptions::get_PreserveIncludePictureField](../loadoptions/get_preserveincludepicturefield/). |
| [set_ProgressCallback](../loadoptions/set_progresscallback/)(const System::SharedPtr\<Aspose::Words::Loading::IDocumentLoadingCallback\>\&) | Called during loading a document and accepts data about loading progress. |
| [set_ResourceLoadingCallback](../loadoptions/set_resourceloadingcallback/)(const System::SharedPtr\<Aspose::Words::Loading::IResourceLoadingCallback\>\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_ResourceLoadingCallback](../loadoptions/get_resourceloadingcallback/). |
| [set_SupportVml](./set_supportvml/)(bool) | Setter for [Aspose::Words::Loading::HtmlLoadOptions::get_SupportVml](./get_supportvml/). |
| [set_TempFolder](../loadoptions/set_tempfolder/)(const System::String\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_TempFolder](../loadoptions/get_tempfolder/). |
| [set_UpdateDirtyFields](../loadoptions/set_updatedirtyfields/)(bool) | Setter for [Aspose::Words::Loading::LoadOptions::get_UpdateDirtyFields](../loadoptions/get_updatedirtyfields/). |
| [set_WarningCallback](../loadoptions/set_warningcallback/)(const System::SharedPtr\<Aspose::Words::IWarningCallback\>\&) | Setter for [Aspose::Words::Loading::LoadOptions::get_WarningCallback](../loadoptions/get_warningcallback/). |
| [set_WebRequestTimeout](./set_webrequesttimeout/)(int32_t) | Setter for [Aspose::Words::Loading::HtmlLoadOptions::get_WebRequestTimeout](./get_webrequesttimeout/). |
