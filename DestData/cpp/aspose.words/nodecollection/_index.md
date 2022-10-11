---
title: NodeCollection
second_title: Aspose.Words for C++ API Reference
description: Represents a collection of nodes of a specific type. 
type: docs
weight: 0
url: /cpp/aspose.words/nodecollection/
---
## NodeCollection class


Represents a collection of nodes of a specific type. 

## Methods

| Method | Description |
| --- | --- |
| void [Add](./add/)(const System::SharedPtr< Aspose::Words::Node > &) | Adds a node to the end of the collection.  |
| void [Clear](./clear/)() | Removes all nodes from this collection and from the document.  |
| bool [Contains](./contains/)(const System::SharedPtr< Aspose::Words::Node > &) | Determines whether a node is in the collection.  |
| int32_t [get_Count](./get_count/)() | Gets the number of nodes in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Node > > > [GetEnumerator](./getenumerator/)() override | Provides a simple "foreach" style iteration over the collection of nodes.  |
| System::SharedPtr< Aspose::Words::Node > [idx_get](./idx_get/)(int32_t) | Retrieves a node at the given index.  |
| int32_t [IndexOf](./indexof/)(const System::SharedPtr< Aspose::Words::Node > &) | Returns the zero-based index of the specified node.  |
| void [Insert](./insert/)(int32_t, const System::SharedPtr< Aspose::Words::Node > &) | Inserts a node into the collection at the specified index.  |
| void [Remove](./remove/)(const System::SharedPtr< Aspose::Words::Node > &) | Removes the node from the collection and from the document.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes the node at the specified index from the collection and from the document.  |
| System::ArrayPtr< System::SharedPtr< Aspose::Words::Node > > [ToArray](./toarray/)() | Copies all nodes from the collection to a new array of nodes.  |
