---
title: FieldOptions
second_title: Aspose.Words for C++ API Reference
description: Represents options to control field handling in a document. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldoptions/
---
## FieldOptions class


Represents options to control field handling in a document. 

## Methods

| Method | Description |
| --- | --- |
| const System::SharedPtr< Aspose::Words::Fields::IBarcodeGenerator > & [get_BarcodeGenerator](./get_barcodegenerator/)() const | Gets or set custom barcode generator.  |
| System::ArrayPtr< System::String > [get_BuiltInTemplatesPaths](./get_builtintemplatespaths/)() const | Gets or sets paths of MS Word built-in templates.  |
| const System::SharedPtr< Aspose::Words::Fields::IComparisonExpressionEvaluator > & [get_ComparisonExpressionEvaluator](./get_comparisonexpressionevaluator/)() const | Gets or sets the field comparison expressions evaluator.  |
| const System::SharedPtr< Aspose::Words::Fields::UserInformation > & [get_CurrentUser](./get_currentuser/)() const | Gets or sets the current user information.  |
| System::String [get_CustomTocStyleSeparator](./get_customtocstyleseparator/)() const | Gets or sets custom style separator for the \t switch in FieldToc field.  |
| System::String [get_DefaultDocumentAuthor](./get_defaultdocumentauthor/)() const | Gets or sets default document author's name. If author's name is already specified in built-in document properties, this option is not considered.  |
| const System::SharedPtr< Aspose::Words::Fields::IFieldDatabaseProvider > & [get_FieldDatabaseProvider](./get_fielddatabaseprovider/)() const | Gets a provider that returns a query result for the FieldDatabase field.  |
| Aspose::Words::Fields::FieldIndexFormat [get_FieldIndexFormat](./get_fieldindexformat/)() | Gets or sets a FieldIndexFormat that represents the formatting for the FieldIndex fields in the document.  |
| const System::SharedPtr< Aspose::Words::Fields::IFieldUpdateCultureProvider > & [get_FieldUpdateCultureProvider](./get_fieldupdatecultureprovider/)() const | Gets or sets a provider that returns a culture object specific for each particular field.  |
| Aspose::Words::Fields::FieldUpdateCultureSource [get_FieldUpdateCultureSource](./get_fieldupdateculturesource/)() const | Specifies what culture to use to format the field result.  |
| const System::SharedPtr< Aspose::Words::Fields::IFieldUpdatingCallback > & [get_FieldUpdatingCallback](./get_fieldupdatingcallback/)() const | Gets IFieldUpdatingCallback implementation.  |
| System::String [get_FileName](./get_filename/)() const | Gets or sets the file name of the document.  |
| bool [get_IsBidiTextSupportedOnUpdate](./get_isbiditextsupportedonupdate/)() const | Gets or sets the value indicating whether bidirectional text is fully supported during field update or not.  |
| bool [get_LegacyNumberFormat](./get_legacynumberformat/)() const | Gets or sets the value indicating whether legacy (early than AW 13.10) number format for fields is enabled or not.  |
| const System::SharedPtr< System::Globalization::CultureInfo > & [get_PreProcessCulture](./get_preprocessculture/)() const | Gets or sets the culture to preprocess field values.  |
| const System::SharedPtr< Aspose::Words::Fields::IFieldResultFormatter > & [get_ResultFormatter](./get_resultformatter/)() const | Allows to control how the field result is formatted.  |
| System::String [get_TemplateName](./get_templatename/)() const | Gets or sets the file name of the template used by the document.  |
| const System::SharedPtr< Aspose::Words::Fields::ToaCategories > & [get_ToaCategories](./get_toacategories/)() const | Gets or sets the table of authorities categories.  |
| bool [get_UseInvariantCultureNumberFormat](./get_useinvariantculturenumberformat/)() const | Gets or sets the value indicating that number format is parsed using invariant culture or not.  |
| const System::SharedPtr< Aspose::Words::Fields::IFieldUserPromptRespondent > & [get_UserPromptRespondent](./get_userpromptrespondent/)() const | Gets or sets the respondent to user prompts during field update.  |
| void [set_BarcodeGenerator](./set_barcodegenerator/)(const System::SharedPtr< Aspose::Words::Fields::IBarcodeGenerator > &) | Gets or set custom barcode generator.  |
| void [set_BuiltInTemplatesPaths](./set_builtintemplatespaths/)(const System::ArrayPtr< System::String > &) | Setter for Aspose::Words::Fields::FieldOptions::get_BuiltInTemplatesPaths.  |
| void [set_ComparisonExpressionEvaluator](./set_comparisonexpressionevaluator/)(const System::SharedPtr< Aspose::Words::Fields::IComparisonExpressionEvaluator > &) | Setter for Aspose::Words::Fields::FieldOptions::get_ComparisonExpressionEvaluator.  |
| void [set_CurrentUser](./set_currentuser/)(const System::SharedPtr< Aspose::Words::Fields::UserInformation > &) | Setter for Aspose::Words::Fields::FieldOptions::get_CurrentUser.  |
| void [set_CustomTocStyleSeparator](./set_customtocstyleseparator/)(const System::String &) | Setter for Aspose::Words::Fields::FieldOptions::get_CustomTocStyleSeparator.  |
| void [set_DefaultDocumentAuthor](./set_defaultdocumentauthor/)(const System::String &) | Setter for Aspose::Words::Fields::FieldOptions::get_DefaultDocumentAuthor.  |
| void [set_FieldDatabaseProvider](./set_fielddatabaseprovider/)(const System::SharedPtr< Aspose::Words::Fields::IFieldDatabaseProvider > &) | Sets a provider that returns a query result for the FieldDatabase field.  |
| void [set_FieldIndexFormat](./set_fieldindexformat/)(Aspose::Words::Fields::FieldIndexFormat) | Setter for Aspose::Words::Fields::FieldOptions::get_FieldIndexFormat.  |
| void [set_FieldUpdateCultureProvider](./set_fieldupdatecultureprovider/)(const System::SharedPtr< Aspose::Words::Fields::IFieldUpdateCultureProvider > &) | Setter for Aspose::Words::Fields::FieldOptions::get_FieldUpdateCultureProvider.  |
| void [set_FieldUpdateCultureSource](./set_fieldupdateculturesource/)(Aspose::Words::Fields::FieldUpdateCultureSource) | Setter for Aspose::Words::Fields::FieldOptions::get_FieldUpdateCultureSource.  |
| void [set_FieldUpdatingCallback](./set_fieldupdatingcallback/)(const System::SharedPtr< Aspose::Words::Fields::IFieldUpdatingCallback > &) | Sets IFieldUpdatingCallback implementation.  |
| void [set_FileName](./set_filename/)(const System::String &) | Setter for Aspose::Words::Fields::FieldOptions::get_FileName.  |
| void [set_IsBidiTextSupportedOnUpdate](./set_isbiditextsupportedonupdate/)(bool) | Setter for Aspose::Words::Fields::FieldOptions::get_IsBidiTextSupportedOnUpdate.  |
| void [set_LegacyNumberFormat](./set_legacynumberformat/)(bool) | Setter for Aspose::Words::Fields::FieldOptions::get_LegacyNumberFormat.  |
| void [set_PreProcessCulture](./set_preprocessculture/)(const System::SharedPtr< System::Globalization::CultureInfo > &) | Setter for Aspose::Words::Fields::FieldOptions::get_PreProcessCulture.  |
| void [set_ResultFormatter](./set_resultformatter/)(const System::SharedPtr< Aspose::Words::Fields::IFieldResultFormatter > &) | Setter for Aspose::Words::Fields::FieldOptions::get_ResultFormatter.  |
| void [set_TemplateName](./set_templatename/)(const System::String &) | Setter for Aspose::Words::Fields::FieldOptions::get_TemplateName.  |
| void [set_ToaCategories](./set_toacategories/)(const System::SharedPtr< Aspose::Words::Fields::ToaCategories > &) | Setter for Aspose::Words::Fields::FieldOptions::get_ToaCategories.  |
| void [set_UseInvariantCultureNumberFormat](./set_useinvariantculturenumberformat/)(bool) | Setter for Aspose::Words::Fields::FieldOptions::get_UseInvariantCultureNumberFormat.  |
| void [set_UserPromptRespondent](./set_userpromptrespondent/)(const System::SharedPtr< Aspose::Words::Fields::IFieldUserPromptRespondent > &) | Setter for Aspose::Words::Fields::FieldOptions::get_UserPromptRespondent.  |
