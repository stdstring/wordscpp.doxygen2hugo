---
title: get_IsRestartAtEachSection
second_title: Aspose.Words for C++ API Reference
description: Specifies whether list should be restarted at each section. Default value is false.
type: docs
weight: 79
url: /cpp/aspose.words.lists/list/get_isrestartateachsection/
---
## List::get_IsRestartAtEachSection method


Specifies whether list should be restarted at each section. Default value is **false**.

```cpp
bool Aspose::Words::Lists::List::get_IsRestartAtEachSection()
```


This option is supported only in RTF, DOC and DOCX document formats.

This option will be written to DOCX only if [OoxmlCompliance](../../../aspose.words.saving/ooxmlcompliance/) is higher then **Ecma376_2006**.

## Examples




Shows how to configure a list to restart numbering at each section. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

doc->get_Lists()->Add(ListTemplate::NumberDefault);

SharedPtr<Aspose::Words::Lists::List> list = doc->get_Lists()->idx_get(0);
list->set_IsRestartAtEachSection(restartListAtEachSection);

// The "IsRestartAtEachSection" property will only be applicable when
// the document's OOXML compliance level is to a standard that is newer than "OoxmlComplianceCore.Ecma376".
auto options = MakeObject<OoxmlSaveOptions>();
options->set_Compliance(OoxmlCompliance::Iso29500_2008_Transitional);

builder->get_ListFormat()->set_List(list);

builder->Writeln(u"List item 1");
builder->Writeln(u"List item 2");
builder->InsertBreak(BreakType::SectionBreakNewPage);
builder->Writeln(u"List item 3");
builder->Writeln(u"List item 4");

doc->Save(ArtifactsDir + u"OoxmlSaveOptions.RestartingDocumentList.docx", options);

doc = MakeObject<Document>(ArtifactsDir + u"OoxmlSaveOptions.RestartingDocumentList.docx");

ASPOSE_ASSERT_EQ(restartListAtEachSection, doc->get_Lists()->idx_get(0)->get_IsRestartAtEachSection());
```

