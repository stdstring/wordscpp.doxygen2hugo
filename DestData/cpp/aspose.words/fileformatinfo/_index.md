---
title: FileFormatInfo
second_title: Aspose.Words for C++ API Reference
description: Contains data returned by FileFormatUtil document format detection methods. 
type: docs
weight: 0
url: /cpp/aspose.words/fileformatinfo/
---
## FileFormatInfo class


Contains data returned by [FileFormatUtil](./fileformatutil/) document format detection methods.

## Methods

| Method | Description |
| --- | --- |
| [get_Encoding](./get_encoding/)() const | Gets the detected encoding if applicable to the current document format. At the moment detects encoding only for HTML documents. |
| [get_HasDigitalSignature](./get_hasdigitalsignature/)() const | Returns true if this document contains a digital signature. This property merely informs that a digital signature is present on a document, but it does not specify whether the signature is valid or not. |
| [get_IsEncrypted](./get_isencrypted/)() const | Returns true if the document is encrypted and requires a password to open. |
| [get_LoadFormat](./get_loadformat/)() const | Gets the detected document format. |
