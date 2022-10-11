---
title: TxtSaveOptionsBase
second_title: Aspose.Words for C++ API Reference
description: The base class for specifying additional options when saving a document into a text based formats. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/txtsaveoptionsbase/
---
## TxtSaveOptionsBase class


The base class for specifying additional options when saving a document into a text based formats. 

## Methods

| Method | Description |
| --- | --- |
|  [TxtSaveOptionsBase](./txtsaveoptionsbase/)() |  |
| System::SharedPtr< System::Text::Encoding > [get_Encoding](./get_encoding/)() const | Specifies the encoding to use when exporting in text formats. Default value is **Encoding.UTF8**.  |
| Aspose::Words::Saving::TxtExportHeadersFootersMode [get_ExportHeadersFootersMode](./get_exportheadersfootersmode/)() const | Specifies the way headers and footers are exported to the text formats. Default value is PrimaryOnly.  |
| bool [get_ForcePageBreaks](./get_forcepagebreaks/)() const | Allows to specify whether the page breaks should be preserved during export. The default value is **false**.  |
| System::String [get_ParagraphBreak](./get_paragraphbreak/)() const | Specifies the string to use as a paragraph break when exporting in text formats.  |
| void [set_Encoding](./set_encoding/)(const System::SharedPtr< System::Text::Encoding > &) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_Encoding.  |
| void [set_ExportHeadersFootersMode](./set_exportheadersfootersmode/)(Aspose::Words::Saving::TxtExportHeadersFootersMode) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_ExportHeadersFootersMode.  |
| void [set_ForcePageBreaks](./set_forcepagebreaks/)(bool) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_ForcePageBreaks.  |
| void [set_ParagraphBreak](./set_paragraphbreak/)(const System::String &) | Setter for Aspose::Words::Saving::TxtSaveOptionsBase::get_ParagraphBreak.  |
