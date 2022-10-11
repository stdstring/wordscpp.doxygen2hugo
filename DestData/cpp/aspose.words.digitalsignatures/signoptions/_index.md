---
title: SignOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify options for document signing. 
type: docs
weight: 0
url: /cpp/aspose.words.digitalsignatures/signoptions/
---
## SignOptions class


Allows to specify options for document signing. 

## Methods

| Method | Description |
| --- | --- |
| [SignOptions](./signoptions/)() |  |
| [get_Comments](./get_comments/)() const | Specifies comments on the digital signature. Default value is **empty string**.  |
| [get_DecryptionPassword](./get_decryptionpassword/)() const | The password to decrypt source document. Default value is **empty string**.  |
| [get_ProviderId](./get_providerid/)() const | Specifies the class ID of the signature provider. Default value is **Empty (all zeroes) Guid**.  |
| [get_SignatureLineId](./get_signaturelineid/)() const | Signature line identifier. Default value is **Empty (all zeroes) Guid**.  |
| [get_SignatureLineImage](./get_signaturelineimage/)() const | The image that will be shown in associated SignatureLine. Default value is **null**.  |
| [get_SignTime](./get_signtime/)() const | The date of signing. Default value is **current time** (Now).  |
| [set_Comments](./set_comments/)(const System::String &) | Setter for Aspose::Words::DigitalSignatures::SignOptions::get_Comments.  |
| [set_DecryptionPassword](./set_decryptionpassword/)(const System::String &) | Setter for Aspose::Words::DigitalSignatures::SignOptions::get_DecryptionPassword.  |
| [set_ProviderId](./set_providerid/)(System::Guid) | Setter for Aspose::Words::DigitalSignatures::SignOptions::get_ProviderId.  |
| [set_SignatureLineId](./set_signaturelineid/)(System::Guid) | Setter for Aspose::Words::DigitalSignatures::SignOptions::get_SignatureLineId.  |
| [set_SignatureLineImage](./set_signaturelineimage/)(const System::ArrayPtr< uint8_t > &) | Setter for Aspose::Words::DigitalSignatures::SignOptions::get_SignatureLineImage.  |
| [set_SignTime](./set_signtime/)(System::DateTime) | Setter for Aspose::Words::DigitalSignatures::SignOptions::get_SignTime.  |