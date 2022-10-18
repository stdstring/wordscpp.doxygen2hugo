---
title: Sign
second_title: Aspose.Words for C++ API Reference
description: Signs source document using given CertificateHolder with digital signature and writes signed document to destination stream. Document should be either Doc or Docx.Output will be written to the start of stream and stream size will be updated with content length.
type: docs
weight: 0
url: /cpp/aspose.words.digitalsignatures/digitalsignatureutil/sign/
---
## DigitalSignatureUtil.Sign(const System::SharedPtr\<System::IO::Stream\>\&, const System::SharedPtr\<System::IO::Stream\>\&, const System::SharedPtr\<Aspose::Words::DigitalSignatures::CertificateHolder\>\&) method


Signs source document using given [CertificateHolder](../certificateholder/) with digital signature and writes signed document to destination stream. [Document](../../aspose.words/document/) should be either **Doc** or **Docx**.**Output will be written to the start of stream and stream size will be updated with content length.**

```cpp
static void Aspose::Words::DigitalSignatures::DigitalSignatureUtil::Sign(const System::SharedPtr<System::IO::Stream> &srcStream, const System::SharedPtr<System::IO::Stream> &dstStream, const System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> &certHolder)
```

## DigitalSignatureUtil.Sign(const System::SharedPtr\<System::IO::Stream\>\&, const System::SharedPtr\<System::IO::Stream\>\&, const System::SharedPtr\<Aspose::Words::DigitalSignatures::CertificateHolder\>\&, const System::SharedPtr\<Aspose::Words::DigitalSignatures::SignOptions\>\&) method


Signs source document using given [CertificateHolder](../certificateholder/) and [SignOptions](../signoptions/) with digital signature and writes signed document to destination stream. [Document](../../aspose.words/document/) should be either **Doc** or **Docx**.**Output will be written to the start of stream and stream size will be updated with content length.**

```cpp
static void Aspose::Words::DigitalSignatures::DigitalSignatureUtil::Sign(const System::SharedPtr<System::IO::Stream> &srcStream, const System::SharedPtr<System::IO::Stream> &dstStream, const System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> &certHolder, const System::SharedPtr<Aspose::Words::DigitalSignatures::SignOptions> &signOptions)
```

## DigitalSignatureUtil.Sign(const System::String\&, const System::String\&, const System::SharedPtr\<Aspose::Words::DigitalSignatures::CertificateHolder\>\&) method


Signs source document using given [CertificateHolder](../certificateholder/) with digital signature and writes signed document to destination file. [Document](../../aspose.words/document/) should be either **Doc** or **Docx**.

```cpp
static void Aspose::Words::DigitalSignatures::DigitalSignatureUtil::Sign(const System::String &srcFileName, const System::String &dstFileName, const System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> &certHolder)
```

## DigitalSignatureUtil.Sign(const System::String\&, const System::String\&, const System::SharedPtr\<Aspose::Words::DigitalSignatures::CertificateHolder\>\&, const System::SharedPtr\<Aspose::Words::DigitalSignatures::SignOptions\>\&) method


Signs source document using given [CertificateHolder](../certificateholder/) and [SignOptions](../signoptions/) with digital signature and writes signed document to destination file. [Document](../../aspose.words/document/) should be either **Doc** or **Docx**.

```cpp
static void Aspose::Words::DigitalSignatures::DigitalSignatureUtil::Sign(const System::String &srcFileName, const System::String &dstFileName, const System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> &certHolder, const System::SharedPtr<Aspose::Words::DigitalSignatures::SignOptions> &signOptions)
```

## DigitalSignatureUtil.Sign(std::basic_istream\<CharType, Traits\>\&, std::basic_ostream\<CharType, Traits\>\&, System::SharedPtr\<Aspose::Words::DigitalSignatures::CertificateHolder\>) method




```cpp
template<typename CharType,typename Traits> static void Aspose::Words::DigitalSignatures::DigitalSignatureUtil::Sign(std::basic_istream<CharType, Traits> &srcStream, std::basic_ostream<CharType, Traits> &dstStream, System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> certHolder)
```

## DigitalSignatureUtil.Sign(std::basic_istream\<CharType, Traits\>\&, std::basic_ostream\<CharType, Traits\>\&, System::SharedPtr\<Aspose::Words::DigitalSignatures::CertificateHolder\>, System::SharedPtr\<Aspose::Words::DigitalSignatures::SignOptions\>) method




```cpp
template<typename CharType,typename Traits> static void Aspose::Words::DigitalSignatures::DigitalSignatureUtil::Sign(std::basic_istream<CharType, Traits> &srcStream, std::basic_ostream<CharType, Traits> &dstStream, System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> certHolder, System::SharedPtr<Aspose::Words::DigitalSignatures::SignOptions> signOptions)
```

