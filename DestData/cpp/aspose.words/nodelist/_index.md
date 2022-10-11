---
title: NodeList
second_title: Aspose.Words for C++ API Reference
description: Represents a collection of nodes matching an XPath query executed using the SelectNodes() method. 
type: docs
weight: 0
url: /cpp/aspose.words/nodelist/
---
## NodeList class


Represents a collection of nodes matching an XPath query executed using the SelectNodes() method. 

## Methods

| Method | Description |
| --- | --- |
|  [NodeList](./nodelist/)(const System::SharedPtr< Aspose::Words::NodeCollection > &) |  |
| int32_t [get_Count](./get_count/)() const | Gets the number of nodes in the list.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Node > > > [GetEnumerator](./getenumerator/)() override | Provides a simple "foreach" style iteration over the collection of nodes.  |
| System::SharedPtr< Aspose::Words::Node > [idx_get](./idx_get/)(int32_t) const | Retrieves a node at the given index.  |
| System::ArrayPtr< System::SharedPtr< Aspose::Words::Node > > [ToArray](./toarray/)() const | Copies all nodes from the collection to a new array of nodes.  |
