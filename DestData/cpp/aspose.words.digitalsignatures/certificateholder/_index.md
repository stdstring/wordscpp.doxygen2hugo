---
title: CertificateHolder
second_title: Aspose.Words for C++ API Reference
description: Represents a holder of X509Certificate2 instance. 
type: docs
weight: 0
url: /cpp/aspose.words.digitalsignatures/certificateholder/
---
## CertificateHolder class


Represents a holder of **X509Certificate2** instance.

## Methods

| Method | Description |
| --- | --- |
| static [Create](./create/)(const System::ArrayPtr\<uint8_t\>\&, const System::SharedPtr\<System::Security::SecureString\>\&) | Creates [CertificateHolder](./) object using byte array of PKCS12 store and its password. |
| static [Create](./create/)(const System::ArrayPtr\<uint8_t\>\&, const System::String\&) | Creates [CertificateHolder](./) object using byte array of PKCS12 store and its password. |
| static [Create](./create/)(const System::String\&, const System::String\&) | Creates [CertificateHolder](./) object using path to PKCS12 store and its password. |
| static [Create](./create/)(const System::String\&, const System::String\&, const System::String\&) | Creates [CertificateHolder](./) object using path to PKCS12 store, its password and the alias by using which private key and certificate will be found. |
| [get_Certificate](./get_certificate/)() | Returns the instance of **X509Certificate2** which holds private, public keys and certificate chain. |
