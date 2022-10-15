---
title: WriteProtection
second_title: Aspose.Words for C++ API Reference
description: Specifies write protection settings for a document. 
type: docs
weight: 0
url: /cpp/aspose.words.settings/writeprotection/
---
## WriteProtection class


Specifies write protection settings for a document.

## Methods

| Method | Description |
| --- | --- |
| [get_IsWriteProtected](./get_iswriteprotected/)() | Returns true when a write protection password is set. |
| [get_ReadOnlyRecommended](./get_readonlyrecommended/)() const | Specifies whether the document author has recommended that the document be opened as read-only. |
| [set_ReadOnlyRecommended](./set_readonlyrecommended/)(bool) | Setter for [Aspose::Words::Settings::WriteProtection::get_ReadOnlyRecommended](./get_readonlyrecommended/). |
| [SetPassword](./setpassword/)(const System::String\&) | Sets the write protection password for the document. |
| [ValidatePassword](./validatepassword/)(const System::String\&) | Returns true if the specified password is the same as the write-protection password the document was protected with. If document is not write-protected with password then returns false. |
