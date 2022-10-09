---
title: LoadOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify additional options (such as password or base URI) when loading a document into a Document object. 
type: docs
weight: 0
url: /cpp/aspose.words.loading/loadoptions/
---

Allows to specify additional options (such as password or base URI) when loading a document into a Document object. 

## Methods

| Method | Description |
| --- | --- |
| [LoadOptions](./loadoptions/)() | Initializes a new instance of this class with default values.  |
| [LoadOptions](./loadoptions/)(Aspose::Words::LoadFormat, const System::String &, const System::String &) | A shortcut to initialize a new instance of this class with properties set to the specified values.  |
| [LoadOptions](./loadoptions/)(const System::String &) | A shortcut to initialize a new instance of this class with the specified password to load an encrypted document.  |
| [get_BaseUri](./get_baseuri/)() const | Gets or sets the string that will be used to resolve relative URIs found in the document into absolute URIs when required. Can be null or empty string. Default is null.  |
| [get_ConvertMetafilesToPng](./get_convertmetafilestopng/)() const | Gets or sets whether to convert metafile (Wmf or Emf) images to Png image format.  |
| [get_ConvertShapeToOfficeMath](./get_convertshapetoofficemath/)() const | Gets or sets whether to convert shapes with EquationXML to Office Math objects.  |
| [get_Encoding](./get_encoding/)() const | Gets or sets the encoding that will be used to load an HTML, TXT, or CHM document if the encoding is not specified inside the document. Can be null. Default is null.  |
| [get_FlatOpcXmlMappingOnly](./get_flatopcxmlmappingonly/)() const | Gets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| [get_FontSettings](./get_fontsettings/)() const | Allows to specify document font settings.  |
| [get_LanguagePreferences](./get_languagepreferences/)() const | Gets language preferences that will be used when document is loading.  |
| [get_LoadFormat](./get_loadformat/)() const | Specifies the format of the document to be loaded. Default is Auto.  |
| [get_MswVersion](./get_mswversion/)() const | Allows to specify that the document loading process should match a specific MS Word version. Default value is Word2019 |
| [get_Password](./get_password/)() const | Gets or sets the password for opening an encrypted document. Can be null or empty string. Default is null.  |
| [get_PreserveIncludePictureField](./get_preserveincludepicturefield/)() const | Gets or sets whether to preserve the INCLUDEPICTURE field when reading Microsoft Word formats. The default value is false.  |
| [get_ProgressCallback](./get_progresscallback/)() const | Called during loading a document and accepts data about loading progress.  |
| [get_ResourceLoadingCallback](./get_resourceloadingcallback/)() const | Allows to control how external resources (images, style sheets) are loaded when a document is imported from HTML, MHTML.  |
| [get_TempFolder](./get_tempfolder/)() const | Allows to use temporary files when reading document. By default this property is **null** and no temporary files are used.  |
| [get_UpdateDirtyFields](./get_updatedirtyfields/)() const | Specifies whether to update the fields with the **dirty** attribute.  |
| [get_WarningCallback](./get_warningcallback/)() const | Called during a load operation, when an issue is detected that might result in data or formatting fidelity loss.  |
| [set_BaseUri](./set_baseuri/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_BaseUri.  |
| [set_ConvertMetafilesToPng](./set_convertmetafilestopng/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_ConvertMetafilesToPng.  |
| [set_ConvertShapeToOfficeMath](./set_convertshapetoofficemath/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_ConvertShapeToOfficeMath.  |
| [set_Encoding](./set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Loading::LoadOptions::get_Encoding.  |
| [set_FlatOpcXmlMappingOnly](./set_flatopcxmlmappingonly/)(bool) | Sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| [set_FontSettings](./set_fontsettings/)(const System::SharedPtr< Aspose::Words::Fonts::FontSettings > &) | Setter for Aspose::Words::Loading::LoadOptions::get_FontSettings.  |
| [set_LoadFormat](./set_loadformat/)(Aspose::Words::LoadFormat) | Setter for Aspose::Words::Loading::LoadOptions::get_LoadFormat.  |
| [set_MswVersion](./set_mswversion/)(Aspose::Words::Settings::MsWordVersion) | Setter for Aspose::Words::Loading::LoadOptions::get_MswVersion.  |
| [set_Password](./set_password/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_Password.  |
| [set_PreserveIncludePictureField](./set_preserveincludepicturefield/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_PreserveIncludePictureField.  |
| [set_ProgressCallback](./set_progresscallback/)(const System::SharedPtr< Aspose::Words::Loading::IDocumentLoadingCallback > &) | Called during loading a document and accepts data about loading progress.  |
| [set_ResourceLoadingCallback](./set_resourceloadingcallback/)(const System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > &) | Setter for Aspose::Words::Loading::LoadOptions::get_ResourceLoadingCallback.  |
| [set_TempFolder](./set_tempfolder/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_TempFolder.  |
| [set_UpdateDirtyFields](./set_updatedirtyfields/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_UpdateDirtyFields.  |
| [set_WarningCallback](./set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::Loading::LoadOptions::get_WarningCallback.  |
