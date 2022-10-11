---
title: DocumentPartSavingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for the DocumentPartSaving() callback. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/documentpartsavingargs/
---
## DocumentPartSavingArgs class


Provides data for the DocumentPartSaving() callback. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Document > [get_Document](./get_document/)() const | Gets the document object that is being saved.  |
| System::String [get_DocumentPartFileName](./get_documentpartfilename/)() const | Gets or sets the file name (without path) where the document part will be saved to.  |
| System::SharedPtr< System::IO::Stream > [get_DocumentPartStream](./get_documentpartstream/)() const | Allows to specify the stream where the document part will be saved to.  |
| bool [get_KeepDocumentPartStreamOpen](./get_keepdocumentpartstreamopen/)() const | Specifies whether Aspose.Words should keep the stream open or close it after saving a document part.  |
| void [set_DocumentPartFileName](./set_documentpartfilename/)(const System::String &) | Setter for Aspose::Words::Saving::DocumentPartSavingArgs::get_DocumentPartFileName.  |
| void [set_DocumentPartStream](./set_documentpartstream/)(const System::SharedPtr< System::IO::Stream > &) | Setter for Aspose::Words::Saving::DocumentPartSavingArgs::get_DocumentPartStream.  |
| void [set_DocumentPartStream](./set_documentpartstream/)(std::basic_ostream< CharType, Traits > &) |  |
| void [set_KeepDocumentPartStreamOpen](./set_keepdocumentpartstreamopen/)(bool) | Setter for Aspose::Words::Saving::DocumentPartSavingArgs::get_KeepDocumentPartStreamOpen.  |
