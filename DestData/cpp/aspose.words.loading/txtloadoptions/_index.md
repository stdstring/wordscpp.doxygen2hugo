---
title: TxtLoadOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify additional options when loading Text document into a Document object. 
type: docs
weight: 0
url: /cpp/aspose.words.loading/txtloadoptions/
---
## TxtLoadOptions class


Allows to specify additional options when loading Text document into a Document object. 

## Methods

| Method | Description |
| --- | --- |
| [get_BaseUri](../loadoptions/get_baseuri/)() const | Gets or sets the string that will be used to resolve relative URIs found in the document into absolute URIs when required. Can be null or empty string. Default is null.  |
| [get_ConvertMetafilesToPng](../loadoptions/get_convertmetafilestopng/)() const | Gets or sets whether to convert metafile (Wmf or Emf) images to Png image format.  |
| [get_ConvertShapeToOfficeMath](../loadoptions/get_convertshapetoofficemath/)() const | Gets or sets whether to convert shapes with EquationXML to Office Math objects.  |
| [get_DetectNumberingWithWhitespaces](./get_detectnumberingwithwhitespaces/)() const | Allows to specify how numbered list items are recognized when document is imported from plain text format. The default value is true.  |
| [get_DocumentDirection](./get_documentdirection/)() const | Gets or sets a document direction. The default value is LeftToRight.  |
| [get_Encoding](../loadoptions/get_encoding/)() const | Gets or sets the encoding that will be used to load an HTML, TXT, or CHM document if the encoding is not specified inside the document. Can be null. Default is null.  |
| [get_FlatOpcXmlMappingOnly](../loadoptions/get_flatopcxmlmappingonly/)() const | Gets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| [get_FontSettings](../loadoptions/get_fontsettings/)() const | Allows to specify document font settings.  |
| [get_LanguagePreferences](../loadoptions/get_languagepreferences/)() const | Gets language preferences that will be used when document is loading.  |
| [get_LeadingSpacesOptions](./get_leadingspacesoptions/)() const | Gets or sets preferred option of a leading space handling. Default value is ConvertToIndent.  |
| [get_LoadFormat](../loadoptions/get_loadformat/)() const | Specifies the format of the document to be loaded. Default is Auto.  |
| [get_MswVersion](../loadoptions/get_mswversion/)() const | Allows to specify that the document loading process should match a specific MS Word version. Default value is Word2019 |
| [get_Password](../loadoptions/get_password/)() const | Gets or sets the password for opening an encrypted document. Can be null or empty string. Default is null.  |
| [get_PreserveIncludePictureField](../loadoptions/get_preserveincludepicturefield/)() const | Gets or sets whether to preserve the INCLUDEPICTURE field when reading Microsoft Word formats. The default value is false.  |
| [get_ProgressCallback](../loadoptions/get_progresscallback/)() const | Called during loading a document and accepts data about loading progress.  |
| [get_ResourceLoadingCallback](../loadoptions/get_resourceloadingcallback/)() const | Allows to control how external resources (images, style sheets) are loaded when a document is imported from HTML, MHTML.  |
| [get_TempFolder](../loadoptions/get_tempfolder/)() const | Allows to use temporary files when reading document. By default this property is **null** and no temporary files are used.  |
| [get_TrailingSpacesOptions](./get_trailingspacesoptions/)() const | Gets or sets preferred option of a trailing space handling. Default value is Trim.  |
| [get_UpdateDirtyFields](../loadoptions/get_updatedirtyfields/)() const | Specifies whether to update the fields with the **dirty** attribute.  |
| [get_WarningCallback](../loadoptions/get_warningcallback/)() const | Called during a load operation, when an issue is detected that might result in data or formatting fidelity loss.  |
| [LoadOptions](../loadoptions/loadoptions/)() | Initializes a new instance of this class with default values.  |
| [LoadOptions](../loadoptions/loadoptions/)(const System::String &) | A shortcut to initialize a new instance of this class with the specified password to load an encrypted document.  |
| [LoadOptions](../loadoptions/loadoptions/)(Aspose::Words::LoadFormat, const System::String &, const System::String &) | A shortcut to initialize a new instance of this class with properties set to the specified values.  |
| [set_BaseUri](../loadoptions/set_baseuri/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_BaseUri.  |
| [set_ConvertMetafilesToPng](../loadoptions/set_convertmetafilestopng/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_ConvertMetafilesToPng.  |
| [set_ConvertShapeToOfficeMath](../loadoptions/set_convertshapetoofficemath/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_ConvertShapeToOfficeMath.  |
| [set_DetectNumberingWithWhitespaces](./set_detectnumberingwithwhitespaces/)(bool) | Setter for Aspose::Words::Loading::TxtLoadOptions::get_DetectNumberingWithWhitespaces.  |
| [set_DocumentDirection](./set_documentdirection/)(Aspose::Words::Loading::DocumentDirection) | Setter for Aspose::Words::Loading::TxtLoadOptions::get_DocumentDirection.  |
| [set_Encoding](../loadoptions/set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Loading::LoadOptions::get_Encoding.  |
| [set_FlatOpcXmlMappingOnly](../loadoptions/set_flatopcxmlmappingonly/)(bool) | Sets value determining which document formats are allowed to be mapped by XmlMapping. By default only FlatOpc document format is allowed to be mapped.  |
| [set_FontSettings](../loadoptions/set_fontsettings/)(const System::SharedPtr< Aspose::Words::Fonts::FontSettings > &) | Setter for Aspose::Words::Loading::LoadOptions::get_FontSettings.  |
| [set_LeadingSpacesOptions](./set_leadingspacesoptions/)(Aspose::Words::Loading::TxtLeadingSpacesOptions) | Setter for Aspose::Words::Loading::TxtLoadOptions::get_LeadingSpacesOptions.  |
| [set_LoadFormat](../loadoptions/set_loadformat/)(Aspose::Words::LoadFormat) | Setter for Aspose::Words::Loading::LoadOptions::get_LoadFormat.  |
| [set_MswVersion](../loadoptions/set_mswversion/)(Aspose::Words::Settings::MsWordVersion) | Setter for Aspose::Words::Loading::LoadOptions::get_MswVersion.  |
| [set_Password](../loadoptions/set_password/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_Password.  |
| [set_PreserveIncludePictureField](../loadoptions/set_preserveincludepicturefield/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_PreserveIncludePictureField.  |
| [set_ProgressCallback](../loadoptions/set_progresscallback/)(const System::SharedPtr< Aspose::Words::Loading::IDocumentLoadingCallback > &) | Called during loading a document and accepts data about loading progress.  |
| [set_ResourceLoadingCallback](../loadoptions/set_resourceloadingcallback/)(const System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > &) | Setter for Aspose::Words::Loading::LoadOptions::get_ResourceLoadingCallback.  |
| [set_TempFolder](../loadoptions/set_tempfolder/)(const System::String &) | Setter for Aspose::Words::Loading::LoadOptions::get_TempFolder.  |
| [set_TrailingSpacesOptions](./set_trailingspacesoptions/)(Aspose::Words::Loading::TxtTrailingSpacesOptions) | Setter for Aspose::Words::Loading::TxtLoadOptions::get_TrailingSpacesOptions.  |
| [set_UpdateDirtyFields](../loadoptions/set_updatedirtyfields/)(bool) | Setter for Aspose::Words::Loading::LoadOptions::get_UpdateDirtyFields.  |
| [set_WarningCallback](../loadoptions/set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::Loading::LoadOptions::get_WarningCallback.  |
| [TxtLoadOptions](./txtloadoptions/)() | Initializes a new instance of this class with default values.  |
