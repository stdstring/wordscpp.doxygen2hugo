---
title: Create
second_title: Aspose.Words for C++ API Reference
description: Creates CertificateHolder object using byte array of PKCS12 store and its password. 
type: docs
weight: 0
url: /cpp/aspose.words.digitalsignatures/certificateholder/create/
---
## CertificateHolder.Create(const System::ArrayPtr\<uint8_t\>\&, const System::SharedPtr\<System::Security::SecureString\>\&) method


Creates [CertificateHolder](./) object using byte array of PKCS12 store and its password.

```cpp
static System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> Aspose::Words::DigitalSignatures::CertificateHolder::Create(const System::ArrayPtr<uint8_t> &certBytes, const System::SharedPtr<System::Security::SecureString> &password)
```

## CertificateHolder.Create(const System::ArrayPtr\<uint8_t\>\&, const System::String\&) method


Creates [CertificateHolder](./) object using byte array of PKCS12 store and its password.

```cpp
static System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> Aspose::Words::DigitalSignatures::CertificateHolder::Create(const System::ArrayPtr<uint8_t> &certBytes, const System::String &password)
```

## CertificateHolder.Create(const System::String\&, const System::String\&) method


Creates [CertificateHolder](./) object using path to PKCS12 store and its password.

```cpp
static System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> Aspose::Words::DigitalSignatures::CertificateHolder::Create(const System::String &fileName, const System::String &password)
```

## CertificateHolder.Create(const System::String\&, const System::String\&, const System::String\&) method


Creates [CertificateHolder](./) object using path to PKCS12 store, its password and the alias by using which private key and certificate will be found.

```cpp
static System::SharedPtr<Aspose::Words::DigitalSignatures::CertificateHolder> Aspose::Words::DigitalSignatures::CertificateHolder::Create(const System::String &fileName, const System::String &password, const System::String &alias)
```

