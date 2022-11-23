---
title: get_Password
second_title: Aspose.Words for C++ API Reference
description: Gets or sets a password to encrypt document.
type: docs
weight: 40
url: /cpp/aspose.words.saving/odtsaveoptions/get_password/
---
## OdtSaveOptions::get_Password method


Gets or sets a password to encrypt document.

```cpp
System::String Aspose::Words::Saving::OdtSaveOptions::get_Password() const
```


In order to save document without encryption this property should be null or empty string.

## Examples



Shows how to encrypt a saved ODT/OTT document with a password, and then load it using Aspose.Words. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);
builder->Writeln(u"Hello world!");

// Create a new OdtSaveOptions, and pass either "SaveFormat.Odt",
// or "SaveFormat.Ott" as the format to save the document in.
auto saveOptions = MakeObject<OdtSaveOptions>(saveFormat);
saveOptions->set_Password(u"@sposeEncrypted_1145");

String extensionString = FileFormatUtil::SaveFormatToExtension(saveFormat);

// If we open this document with an appropriate editor,
// it will prompt us for the password we specified in the SaveOptions object.
doc->Save(ArtifactsDir + u"OdtSaveOptions.Encrypt" + extensionString, saveOptions);

SharedPtr<FileFormatInfo> docInfo = FileFormatUtil::DetectFileFormat(ArtifactsDir + u"OdtSaveOptions.Encrypt" + extensionString);

ASSERT_TRUE(docInfo->get_IsEncrypted());

// If we wish to open or edit this document again using Aspose.Words,
// we will have to provide a LoadOptions object with the correct password to the loading constructor.
doc = MakeObject<Document>(ArtifactsDir + u"OdtSaveOptions.Encrypt" + extensionString, MakeObject<LoadOptions>(u"@sposeEncrypted_1145"));

ASSERT_EQ(u"Hello world!", doc->GetText().Trim());
```

