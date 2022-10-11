---
title: DocSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Doc or Dot format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/docsaveoptions/
---
## DocSaveOptions class


Can be used to specify additional options when saving a document into the Doc or Dot format. 

## Methods

| Method | Description |
| --- | --- |
|  [DocSaveOptions](./docsaveoptions/)() | Initializes a new instance of this class that can be used to save a document in the Doc format.  |
|  [DocSaveOptions](./docsaveoptions/)(Aspose::Words::SaveFormat) | Initializes a new instance of this class that can be used to save a document in the Doc or Dot format.  |
| bool [get_AlwaysCompressMetafiles](./get_alwayscompressmetafiles/)() const | When **false**, small metafiles are not compressed for performance reason. Default value is **true**, all metafiles are compressed regardless of its size.  |
| System::String [get_Password](./get_password/)() const | Gets/sets a password to encrypt document using RC4 encryption method.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can be Doc or Dot.  |
| bool [get_SavePictureBullet](./get_savepicturebullet/)() const | When **false**, PictureBullet data is not saved to output document. Default value is **true**.  |
| bool [get_SaveRoutingSlip](./get_saveroutingslip/)() const | When **false**, RoutingSlip data is not saved to output document. Default value is **true**.  |
| void [set_AlwaysCompressMetafiles](./set_alwayscompressmetafiles/)(bool) | Setter for Aspose::Words::Saving::DocSaveOptions::get_AlwaysCompressMetafiles.  |
| void [set_Password](./set_password/)(const System::String &) | Setter for Aspose::Words::Saving::DocSaveOptions::get_Password.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::DocSaveOptions::get_SaveFormat.  |
| void [set_SavePictureBullet](./set_savepicturebullet/)(bool) | Setter for Aspose::Words::Saving::DocSaveOptions::get_SavePictureBullet.  |
| void [set_SaveRoutingSlip](./set_saveroutingslip/)(bool) | Setter for Aspose::Words::Saving::DocSaveOptions::get_SaveRoutingSlip.  |
