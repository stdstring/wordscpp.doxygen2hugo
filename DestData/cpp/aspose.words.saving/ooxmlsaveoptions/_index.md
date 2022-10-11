---
title: OoxmlSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Docx, Docm, Dotx, Dotm or FlatOpc format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/ooxmlsaveoptions/
---
## OoxmlSaveOptions class


Can be used to specify additional options when saving a document into the Docx, Docm, Dotx, Dotm or FlatOpc format. 

## Methods

| Method | Description |
| --- | --- |
|  [OoxmlSaveOptions](./ooxmlsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the Docx format.  |
|  [OoxmlSaveOptions](./ooxmlsaveoptions/)(Aspose::Words::SaveFormat) | Initializes a new instance of this class that can be used to save a document in the Docx, Docm, Dotx, Dotm or FlatOpc format.  |
| Aspose::Words::Saving::OoxmlCompliance [get_Compliance](./get_compliance/)() | Specifies the OOXML version for the output document. The default value is Ecma376_2006.  |
| Aspose::Words::Saving::CompressionLevel [get_CompressionLevel](./get_compressionlevel/)() const | Specifies the compression level used to save document. The default value is Normal.  |
| bool [get_KeepLegacyControlChars](./get_keeplegacycontrolchars/)() const | Keeps original representation of legacy control characters.  |
| System::String [get_Password](./get_password/)() const | Gets/sets a password to encrypt document using ECMA376 Standard encryption algorithm.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can be Docx, Docm, Dotx, Dotm or FlatOpc.  |
| void [set_Compliance](./set_compliance/)(Aspose::Words::Saving::OoxmlCompliance) | Setter for Aspose::Words::Saving::OoxmlSaveOptions::get_Compliance.  |
| void [set_CompressionLevel](./set_compressionlevel/)(Aspose::Words::Saving::CompressionLevel) | Setter for Aspose::Words::Saving::OoxmlSaveOptions::get_CompressionLevel.  |
| void [set_KeepLegacyControlChars](./set_keeplegacycontrolchars/)(bool) | Setter for Aspose::Words::Saving::OoxmlSaveOptions::get_KeepLegacyControlChars.  |
| void [set_Password](./set_password/)(const System::String &) | Setter for Aspose::Words::Saving::OoxmlSaveOptions::get_Password.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::OoxmlSaveOptions::get_SaveFormat.  |
