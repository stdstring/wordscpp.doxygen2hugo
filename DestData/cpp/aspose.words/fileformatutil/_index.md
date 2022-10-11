---
title: FileFormatUtil
second_title: Aspose.Words for C++ API Reference
description: Provides utility methods for working with file formats, such as detecting file format or converting file extensions to/from file format enums. 
type: docs
weight: 0
url: /cpp/aspose.words/fileformatutil/
---
## FileFormatUtil class


Provides utility methods for working with file formats, such as detecting file format or converting file extensions to/from file format enums. 

## Methods

| Method | Description |
| --- | --- |
| static Aspose::Words::LoadFormat [ContentTypeToLoadFormat](./contenttypetoloadformat/)(const System::String &) | Converts IANA content type into a load format enumerated value.  |
| static Aspose::Words::SaveFormat [ContentTypeToSaveFormat](./contenttypetosaveformat/)(const System::String &) | Converts IANA content type into a save format enumerated value.  |
| static System::SharedPtr< Aspose::Words::FileFormatInfo > [DetectFileFormat](./detectfileformat/)(const System::SharedPtr< System::IO::Stream > &) | Detects and returns the information about a format of a document stored in a stream.  |
| static System::SharedPtr< Aspose::Words::FileFormatInfo > [DetectFileFormat](./detectfileformat/)(const System::String &) | Detects and returns the information about a format of a document stored in a disk file.  |
| static System::SharedPtr< Aspose::Words::FileFormatInfo > [DetectFileFormat](./detectfileformat/)(std::basic_istream< CharType, Traits > &) |  |
| static Aspose::Words::SaveFormat [ExtensionToSaveFormat](./extensiontosaveformat/)(const System::String &) | Converts a file name extension into a SaveFormat value.  |
| static System::String [ImageTypeToExtension](./imagetypetoextension/)(Aspose::Words::Drawing::ImageType) | Converts an Aspose.Words image type enumerated value into a file extension. The returned extension is a lower-case string with a leading dot.  |
| static System::String [LoadFormatToExtension](./loadformattoextension/)(Aspose::Words::LoadFormat) | Converts a load format enumerated value into a file extension. The returned extension is a lower-case string with a leading dot.  |
| static Aspose::Words::SaveFormat [LoadFormatToSaveFormat](./loadformattosaveformat/)(Aspose::Words::LoadFormat) | Converts a LoadFormat value to a SaveFormat value if possible.  |
| static System::String [SaveFormatToExtension](./saveformattoextension/)(Aspose::Words::SaveFormat) | Converts a save format enumerated value into a file extension. The returned extension is a lower-case string with a leading dot.  |
| static Aspose::Words::LoadFormat [SaveFormatToLoadFormat](./saveformattoloadformat/)(Aspose::Words::SaveFormat) | Converts a SaveFormat value to a LoadFormat value if possible.  |
|  [FileFormatUtil](./fileformatutil/)() |  |
