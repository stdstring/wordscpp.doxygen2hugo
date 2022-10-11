---
title: PageLayoutCallbackArgs
second_title: Aspose.Words for C++ API Reference
description: An argument passed into Notify()
type: docs
weight: 0
url: /cpp/aspose.words.layout/pagelayoutcallbackargs/
---
## PageLayoutCallbackArgs class


An argument passed into Notify()

## Methods

| Method | Description |
| --- | --- |
| const System::SharedPtr< Aspose::Words::Document > & [get_Document](./get_document/)() const | Gets document.  |
| Aspose::Words::Layout::PageLayoutEvent [get_Event](./get_event/)() const | Gets event.  |
| int32_t [get_PageIndex](./get_pageindex/)() | Gets 0-based index of the page in the document this event relates to. Returns negative value if there is no associated page, or if page was removed during reflow.  |
