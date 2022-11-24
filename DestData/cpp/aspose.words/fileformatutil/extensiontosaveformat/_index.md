---
title: ExtensionToSaveFormat
second_title: Aspose.Words for C++ API Reference
description: Converts a file name extension into a SaveFormat value.
type: docs
weight: 40
url: /cpp/aspose.words/fileformatutil/extensiontosaveformat/
---
## FileFormatUtil::ExtensionToSaveFormat method


Converts a file name extension into a [SaveFormat](../../saveformat/) value.

```cpp
static Aspose::Words::SaveFormat Aspose::Words::FileFormatUtil::ExtensionToSaveFormat(const System::String &extension)
```


| Parameter | Type | Description |
| --- | --- | --- |
| extension | const System::String\& | The file extension. Can be with or without a leading dot. Case-insensitive. |
## Remarks


If the extension cannot be recognized, returns **Unknown**.

## Examples



Shows how to use the [FileFormatUtil](../) methods to detect the format of a document. 
```cpp
// Load a document from a file that is missing a file extension, and then detect its file format.
{
    SharedPtr<System::IO::FileStream> docStream = System::IO::File::OpenRead(MyDir + u"Word document with missing file extension");
    SharedPtr<FileFormatInfo> info = FileFormatUtil::DetectFileFormat(docStream);
    LoadFormat loadFormat = info->get_LoadFormat();

    ASSERT_EQ(LoadFormat::Doc, loadFormat);

    // Below are two methods of converting a LoadFormat to its corresponding SaveFormat.
    // 1 -  Get the file extension string for the LoadFormat, then get the corresponding SaveFormat from that string:
    String fileExtension = FileFormatUtil::LoadFormatToExtension(loadFormat);
    SaveFormat saveFormat = FileFormatUtil::ExtensionToSaveFormat(fileExtension);

    // 2 -  Convert the LoadFormat directly to its SaveFormat:
    saveFormat = FileFormatUtil::LoadFormatToSaveFormat(loadFormat);

    // Load a document from the stream, and then save it to the automatically detected file extension.
    auto doc = MakeObject<Document>(docStream);

    ASSERT_EQ(u".doc", FileFormatUtil::SaveFormatToExtension(saveFormat));

    doc->Save(ArtifactsDir + u"File.SaveToDetectedFileFormat" + FileFormatUtil::SaveFormatToExtension(saveFormat));
}
```

