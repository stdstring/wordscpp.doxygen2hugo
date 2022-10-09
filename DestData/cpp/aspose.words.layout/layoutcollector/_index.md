---
title: LayoutCollector
second_title: Aspose.Words for C++ API Reference
description: This class allows to compute page numbers of document nodes. 
type: docs
weight: 0
url: /cpp/aspose.words.layout/layoutcollector/
---

This class allows to compute page numbers of document nodes. 

## Methods

| Method | Description |
| --- | --- |
| [LayoutCollector](./layoutcollector/)(const System::SharedPtr< Aspose::Words::Document > &) | Initializes an instance of this class.  |
| [Clear](./clear/)() | Clears all collected layout data. Call this method after document was manually updated, or layout was rebuilt.  |
| [get_Document](./get_document/)() const | Gets or sets the document this collector instance is attached to.  |
| [GetEndPageIndex](./getendpageindex/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets 1-based index of the page where node ends. Returns 0 if node cannot be mapped to a page.  |
| [GetEntity](./getentity/)(const System::SharedPtr< Aspose::Words::Node > &) | Returns an opaque position of the LayoutEnumerator which corresponds to the specified node. You can use returned value as an argument to Current given the document being enumerated and the document of the node are the same.  |
| [GetNumPagesSpanned](./getnumpagesspanned/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets number of pages the specified node spans. 0 if node is within a single page. This is the same as GetEndPageIndex() - GetStartPageIndex().  |
| [GetStartPageIndex](./getstartpageindex/)(const System::SharedPtr< Aspose::Words::Node > &) | Gets 1-based index of the page where node begins. Returns 0 if node cannot be mapped to a page.  |
| [set_Document](./set_document/)(const System::SharedPtr< Aspose::Words::Document > &) | Setter for Aspose::Words::Layout::LayoutCollector::get_Document.  |
