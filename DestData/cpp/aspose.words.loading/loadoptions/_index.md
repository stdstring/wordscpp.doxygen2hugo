---
title: LoadOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify additional options (such as password or base URI) when loading a document into a Document object. 
type: docs
weight: 0
url: /cpp/aspose.words.loading/loadoptions/
---
## LoadOptions class


Allows to specify additional options (such as password or base URI) when loading a document into a Document object. 

## Methods

| Method | Description |
| --- | --- |
|  [LoadOptions](./loadoptions/)() | Initializes a new instance of this class with default values.  |
|  [LoadOptions](./loadoptions/)(Aspose::Words::LoadFormat, const System::String &, const System::String &) | A shortcut to initialize a new instance of this class with properties set to the specified values.  |
|  [LoadOptions](./loadoptions/)(const System::String &) | A shortcut to initialize a new instance of this class with the specified password to load an encrypted document.  |
| System::String [get_BaseUri](./get_baseuri/)() const | Gets or sets the string that will be used to resolve relative URIs found in the document into absolute URIs when required. Can be null or empty string. Default is null.  |
| bool [get_ConvertMetafilesToPng](./get_convertmetafilestopng/)() const | Gets or sets whether to convert metafile (Wmf or Emf) images to Png image format.  |
| bool [get_ConvertShapeToOfficeMath](./get_convertshapetoofficemath/)() const | Gets or sets whether to convert shapes with EquationXML to Office Math objects.  |
| System::SharedPtr< System::Text::Encoding > [get_Encoding](./get_encoding/)() const | Gets or sets the encoding that will be used to load an HTML, TXT, or CHM document if the encoding is not specified inside the document. Can be null. Default is null.  |
| bool [get_FlatOpcXmlMappingOnly](./get_flatopcxmlmappingonly/)() const | Gets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| System::SharedPtr< Aspose::Words::Fonts::FontSettings > [get_FontSettings](./get_fontsettings/)() const | Allows to specify document font settings.  |
| System::SharedPtr< Aspose::Words::Loading::LanguagePreferences > [get_LanguagePreferences](./get_languagepreferences/)() const | Gets language preferences that will be used when document is loading.  |
| Aspose::Words::LoadFormat [get_LoadFormat](./get_loadformat/)() const | Specifies the format of the document to be loaded. Default is Auto.  |
| Aspose::Words::Settings::MsWordVersion [get_MswVersion](./get_mswversion/)() const | Allows to specify that the document loading process should match a specific MS Word version. Default value is Word2019 |
| System::String [get_Password](./get_password/)() const | Gets or sets the password for opening an encrypted document. Can be null or empty string. Default is null.  |
| bool [get_PreserveIncludePictureField](./get_preserveincludepicturefield/)() const | Gets or sets whether to preserve the INCLUDEPICTURE field when reading Microsoft Word formats. The default value is false.  |
| System::SharedPtr< Aspose::Words::Loading::IDocumentLoadingCallback > [get_ProgressCallback](./get_progresscallback/)() const | Called during loading a document and accepts data about loading progress.  |
| System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > [get_ResourceLoadingCallback](./get_resourceloadingcallback/)() const | Allows to control how external resources (images, style sheets) are loaded when a document is imported from HTML, MHTML.  |
| System::String [get_TempFolder](./get_tempfolder/)() const | Allows to use temporary files when reading document. By default this property is **null** and no temporary files are used.  |
| bool [get_UpdateDirtyFields](./get_updatedirtyfields/)() const | Specifies whether to update the fields with the **dirty** attribute.  |
| System::SharedPtr< Aspose::Words::IWarningCallback > [get_WarningCallback](./get_warningcallback/)() const | Called during a load operation, when an issue is detected that might result in data or formatting fidelity loss.  |
| void [set_BaseUri](./set_baseuri/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_BaseUri.  |
| void [set_ConvertMetafilesToPng](./set_convertmetafilestopng/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_ConvertMetafilesToPng.  |
| void [set_ConvertShapeToOfficeMath](./set_convertshapetoofficemath/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_ConvertShapeToOfficeMath.  |
| void [set_Encoding](./set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Loading::LoadOptions::get_Encoding.  |
| void [set_FlatOpcXmlMappingOnly](./set_flatopcxmlmappingonly/)(bool) | Sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| void [set_FontSettings](./set_fontsettings/)(const System::SharedPtr< Aspose::Words::Fonts::FontSettings > &) | Setter for Aspose::Words::Loading::LoadOptions::get_FontSettings.  |
| void [set_LoadFormat](./set_loadformat/)(Aspose::Words::LoadFormat) | Setter for Aspose::Words::Loading::LoadOptions::get_LoadFormat.  |
| void [set_MswVersion](./set_mswversion/)(Aspose::Words::Settings::MsWordVersion) | Setter for Aspose::Words::Loading::LoadOptions::get_MswVersion.  |
| void [set_Password](./set_password/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_Password.  |
| void [set_PreserveIncludePictureField](./set_preserveincludepicturefield/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_PreserveIncludePictureField.  |
| void [set_ProgressCallback](./set_progresscallback/)(const System::SharedPtr< Aspose::Words::Loading::IDocumentLoadingCallback > &) | Called during loading a document and accepts data about loading progress.  |
| void [set_ResourceLoadingCallback](./set_resourceloadingcallback/)(const System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > &) | Setter for Aspose::Words::Loading::LoadOptions::get_ResourceLoadingCallback.  |
| void [set_TempFolder](./set_tempfolder/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_TempFolder.  |
| void [set_UpdateDirtyFields](./set_updatedirtyfields/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_UpdateDirtyFields.  |
| void [set_WarningCallback](./set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::Loading::LoadOptions::get_WarningCallback.  |
