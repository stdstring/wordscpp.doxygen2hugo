---
title: PageSavingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for the PageSaving() event. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/pagesavingargs/
---
## PageSavingArgs class


Provides data for the PageSaving() event. 

## Methods

| Method | Description |
| --- | --- |
|  [PageSavingArgs](./pagesavingargs/)() |  |
| bool [get_KeepPageStreamOpen](./get_keeppagestreamopen/)() const | Specifies whether Aspose.Words should keep the stream open or close it after saving a document page.  |
| System::String [get_PageFileName](./get_pagefilename/)() const | Gets or sets the file name where the document page will be saved to.  |
| int32_t [get_PageIndex](./get_pageindex/)() const | Current page index.  |
| System::SharedPtr< System::IO::Stream > [get_PageStream](./get_pagestream/)() const | Allows to specify the stream where the document page will be saved to.  |
| void [set_KeepPageStreamOpen](./set_keeppagestreamopen/)(bool) | Setter for Aspose::Words::Saving::PageSavingArgs::get_KeepPageStreamOpen.  |
| void [set_PageFileName](./set_pagefilename/)(const System::String &) | Setter for Aspose::Words::Saving::PageSavingArgs::get_PageFileName.  |
| void [set_PageStream](./set_pagestream/)(const System::SharedPtr< System::IO::Stream > &) | Setter for Aspose::Words::Saving::PageSavingArgs::get_PageStream.  |
| void [set_PageStream](./set_pagestream/)(std::basic_ostream< CharType, Traits > &) |  |
