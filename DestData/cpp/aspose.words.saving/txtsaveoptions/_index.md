---
title: TxtSaveOptions
second_title: Aspose.Words for C++ API Reference
description: Can be used to specify additional options when saving a document into the Text format. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/txtsaveoptions/
---
## TxtSaveOptions class


Can be used to specify additional options when saving a document into the Text format. 

## Methods

| Method | Description |
| --- | --- |
|  [TxtSaveOptions](./txtsaveoptions/)() |  |
| bool [get_AddBidiMarks](./get_addbidimarks/)() const | Specifies whether to add bi-directional marks before each BiDi run when exporting in plain text format. The default value is **false**.  |
| System::SharedPtr< Aspose::Words::Saving::TxtListIndentation > [get_ListIndentation](./get_listindentation/)() const | Gets a ListIndentation object that specifies how many and which character to use for indentation of list levels. By default it is zero count of character '\0', that means no indentation.  |
| int32_t [get_MaxCharactersPerLine](./get_maxcharactersperline/)() const | Gets or sets an integer value that specifies the maximum number of characters per one line. The default value is 0, that means no limit.  |
| bool [get_PreserveTableLayout](./get_preservetablelayout/)() const | Specifies whether the program should attempt to preserve layout of tables when saving in the plain text format. The default value is **false**.  |
| Aspose::Words::SaveFormat [get_SaveFormat](./get_saveformat/)() override | Specifies the format in which the document will be saved if this save options object is used. Can only be Text.  |
| bool [get_SimplifyListLabels](./get_simplifylistlabels/)() const | Specifies whether the program should simplify list labels in case of complex label formatting not being adequately represented by plain text. If set to **true**, numbered list labels are written in simple numeric format and itemized list labels as simple ASCII characters. The default value is **false**.  |
| void [set_AddBidiMarks](./set_addbidimarks/)(bool) | Setter for Aspose::Words::Saving::TxtSaveOptions::get_AddBidiMarks.  |
| void [set_MaxCharactersPerLine](./set_maxcharactersperline/)(int32_t) | Setter for Aspose::Words::Saving::TxtSaveOptions::get_MaxCharactersPerLine.  |
| void [set_PreserveTableLayout](./set_preservetablelayout/)(bool) | Setter for Aspose::Words::Saving::TxtSaveOptions::get_PreserveTableLayout.  |
| void [set_SaveFormat](./set_saveformat/)(Aspose::Words::SaveFormat) override | Setter for Aspose::Words::Saving::TxtSaveOptions::get_SaveFormat.  |
| void [set_SimplifyListLabels](./set_simplifylistlabels/)(bool) | Setter for Aspose::Words::Saving::TxtSaveOptions::get_SimplifyListLabels.  |
