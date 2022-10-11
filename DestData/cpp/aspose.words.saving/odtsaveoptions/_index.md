---
title: OdtSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Odt or Ott format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/odtsaveoptions/
---
## OdtSaveOptions class


Can be used to specify additional options when saving a document into the Odt or Ott format. 

## Methods

| Method | Description |
| --- | --- |
|  [OdtSaveOptions](./odtsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the Odt format.  |
|  [OdtSaveOptions](./odtsaveoptions/)(Aspose::Words::SaveFormat) | Initializes a new instance of this class that can be used to save a document in the Odt or Ott format.  |
|  [OdtSaveOptions](./odtsaveoptions/)(const System::String &) | Initializes a new instance of this class that can be used to save a document in the Odt format encrypted with a password.  |
| bool [get_IsStrictSchema11](./get_isstrictschema11/)() const | Specifies whether export should correspond to ODT specification 1.1 strictly. OOo 3.0 displays files correctly when they contain elements and attributes of ODT 1.2. Use "false" for this purpose, or "true" for strict conformity of specification 1.1. The default value is **false**.  |
| Aspose::Words::Saving::OdtSaveMeasureUnit [get_MeasureUnit](./get_measureunit/)() const | Allows to specify units of measure to apply to document content. The default value is Centimeters |
| System::String [get_Password](./get_password/)() const | Gets or sets a password to encrypt document.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can be Odt or Ott.  |
| void [set_IsStrictSchema11](./set_isstrictschema11/)(bool) | Setter for Aspose::Words::Saving::OdtSaveOptions::get_IsStrictSchema11.  |
| void [set_MeasureUnit](./set_measureunit/)(Aspose::Words::Saving::OdtSaveMeasureUnit) | Setter for Aspose::Words::Saving::OdtSaveOptions::get_MeasureUnit.  |
| void [set_Password](./set_password/)(const System::String &) | Setter for Aspose::Words::Saving::OdtSaveOptions::get_Password.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::OdtSaveOptions::get_SaveFormat.  |
