---
title: DigitalSignatureUtil
second_title: Aspose.Words for C++ API Reference
description: Provides methods for signing document. 
type: docs
weight: 0
url: /cpp/aspose.words.digitalsignatures/digitalsignatureutil/
---
## DigitalSignatureUtil class


Provides methods for signing document. 

## Methods

| Method | Description |
| --- | --- |
| static System::SharedPtr< Aspose::Words::DigitalSignatures::DigitalSignatureCollection > [LoadSignatures](./loadsignatures/)(const System::SharedPtr< System::IO::Stream > &) | Loads digital signatures from document using stream.  |
| static System::SharedPtr< Aspose::Words::DigitalSignatures::DigitalSignatureCollection > [LoadSignatures](./loadsignatures/)(const System::String &) | Loads digital signatures from document.  |
| static System::SharedPtr< Aspose::Words::DigitalSignatures::DigitalSignatureCollection > [LoadSignatures](./loadsignatures/)(std::basic_istream< CharType, Traits > &) |  |
| static void [RemoveAllSignatures](./removeallsignatures/)(const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< System::IO::Stream > &) | Removes all digital signatures from document in source stream and writes unsigned document to destination stream. **Output will be written to the start of stream and stream size will be updated with content length.** |
| static void [RemoveAllSignatures](./removeallsignatures/)(const System::String &, const System::String &) | Removes all digital signatures from source file and writes unsigned file to destination file.  |
| static void [RemoveAllSignatures](./removeallsignatures/)(std::basic_istream< CharType, Traits > &, std::basic_ostream< CharType, Traits > &) |  |
| static void [Sign](./sign/)(const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< Aspose::Words::DigitalSignatures::CertificateHolder > &) | Signs source document using given CertificateHolder with digital signature and writes signed document to destination stream. Document should be either Doc or Docx.**Output will be written to the start of stream and stream size will be updated with content length.** |
| static void [Sign](./sign/)(const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< Aspose::Words::DigitalSignatures::CertificateHolder > &, const System::SharedPtr< Aspose::Words::DigitalSignatures::SignOptions > &) | Signs source document using given CertificateHolder and SignOptions with digital signature and writes signed document to destination stream. Document should be either Doc or Docx.**Output will be written to the start of stream and stream size will be updated with content length.** |
| static void [Sign](./sign/)(const System::String &, const System::String &, const System::SharedPtr< Aspose::Words::DigitalSignatures::CertificateHolder > &) | Signs source document using given CertificateHolder with digital signature and writes signed document to destination file. Document should be either Doc or Docx.  |
| static void [Sign](./sign/)(const System::String &, const System::String &, const System::SharedPtr< Aspose::Words::DigitalSignatures::CertificateHolder > &, const System::SharedPtr< Aspose::Words::DigitalSignatures::SignOptions > &) | Signs source document using given CertificateHolder and SignOptions with digital signature and writes signed document to destination file. Document should be either Doc or Docx.  |
| static void [Sign](./sign/)(std::basic_istream< CharType, Traits > &, std::basic_ostream< CharType, Traits > &, System::SharedPtr< Aspose::Words::DigitalSignatures::CertificateHolder >) |  |
| static void [Sign](./sign/)(std::basic_istream< CharType, Traits > &, std::basic_ostream< CharType, Traits > &, System::SharedPtr< Aspose::Words::DigitalSignatures::CertificateHolder >, System::SharedPtr< Aspose::Words::DigitalSignatures::SignOptions >) |  |
|  [DigitalSignatureUtil](./digitalsignatureutil/)() |  |
