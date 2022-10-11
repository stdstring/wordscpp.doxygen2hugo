---
title: LayoutOptions
second_title: Aspose.Words for C++ API Reference
description: Holds the options that allow controlling the document layout process. 
type: docs
weight: 0
url: /cpp/aspose.words.layout/layoutoptions/
---
## LayoutOptions class


Holds the options that allow controlling the document layout process. 

## Methods

| Method | Description |
| --- | --- |
|  [LayoutOptions](./layoutoptions/)() |  |
| System::SharedPtr< Aspose::Words::Layout::IPageLayoutCallback > [get_Callback](./get_callback/)() const | Gets IPageLayoutCallback implementation used by page layout model.  |
| Aspose::Words::Layout::CommentDisplayMode [get_CommentDisplayMode](./get_commentdisplaymode/)() const | Gets or sets the way comments are rendered. Default value is ShowInBalloons.  |
| Aspose::Words::Layout::ContinuousSectionRestart [get_ContinuousSectionPageNumberingRestart](./get_continuoussectionpagenumberingrestart/)() const | Gets or sets the mode of behavior for computing page numbers when a continuous section restarts the page numbering.  |
| bool [get_IgnorePrinterMetrics](./get_ignoreprintermetrics/)() const | Gets or sets indication of whether the "Use printer metrics to lay out document" compatibility option is ignored. Default is True.  |
| System::SharedPtr< Aspose::Words::Layout::RevisionOptions > [get_RevisionOptions](./get_revisionoptions/)() const | Gets revision options.  |
| bool [get_ShowHiddenText](./get_showhiddentext/)() const | Gets or sets indication of whether hidden text in the document is rendered. Default is False.  |
| bool [get_ShowParagraphMarks](./get_showparagraphmarks/)() const | Gets or sets indication of whether paragraph marks are rendered. Default is False.  |
| System::SharedPtr< Aspose::Words::Shaping::ITextShaperFactory > [get_TextShaperFactory](./get_textshaperfactory/)() const | Gets or sets ITextShaperFactory implementation used for Advanced Typography rendering features.  |
| void [set_Callback](./set_callback/)(const System::SharedPtr< Aspose::Words::Layout::IPageLayoutCallback > &) | Sets IPageLayoutCallback implementation used by page layout model.  |
| void [set_CommentDisplayMode](./set_commentdisplaymode/)(Aspose::Words::Layout::CommentDisplayMode) | Setter for Aspose::Words::Layout::LayoutOptions::get_CommentDisplayMode.  |
| void [set_ContinuousSectionPageNumberingRestart](./set_continuoussectionpagenumberingrestart/)(Aspose::Words::Layout::ContinuousSectionRestart) | Setter for Aspose::Words::Layout::LayoutOptions::get_ContinuousSectionPageNumberingRestart.  |
| void [set_IgnorePrinterMetrics](./set_ignoreprintermetrics/)(bool) | Setter for Aspose::Words::Layout::LayoutOptions::get_IgnorePrinterMetrics.  |
| void [set_ShowHiddenText](./set_showhiddentext/)(bool) | Setter for Aspose::Words::Layout::LayoutOptions::get_ShowHiddenText.  |
| void [set_ShowParagraphMarks](./set_showparagraphmarks/)(bool) | Setter for Aspose::Words::Layout::LayoutOptions::get_ShowParagraphMarks.  |
| void [set_TextShaperFactory](./set_textshaperfactory/)(const System::SharedPtr< Aspose::Words::Shaping::ITextShaperFactory > &) | Setter for Aspose::Words::Layout::LayoutOptions::get_TextShaperFactory.  |
