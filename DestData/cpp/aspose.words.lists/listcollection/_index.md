---
title: ListCollection
second_title: Aspose.Words for C++ API Reference
description: Stores and manages formatting of bulleted and numbered lists used in a document. 
type: docs
weight: 0
url: /cpp/aspose.words.lists/listcollection/
---
## ListCollection class


Stores and manages formatting of bulleted and numbered lists used in a document. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Lists::List > [Add](./add/)(Aspose::Words::Lists::ListTemplate) | Creates a new list based on a predefined template and adds it to the collection of lists in the document.  |
| System::SharedPtr< Aspose::Words::Lists::List > [Add](./add/)(const System::SharedPtr< Aspose::Words::Style > &) | Creates a new list that references a list style and adds it to the collection of lists in the document.  |
| System::SharedPtr< Aspose::Words::Lists::List > [AddCopy](./addcopy/)(const System::SharedPtr< Aspose::Words::Lists::List > &) | Creates a new list by copying the specified list and adding it to the collection of lists in the document.  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the count of numbered and bulleted lists in the document.  |
| System::SharedPtr< Aspose::Words::DocumentBase > [get_Document](./get_document/)() const | Gets the owner document.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Lists::List > > > [GetEnumerator](./getenumerator/)() override | Gets the enumerator object that will enumerate lists in the document.  |
| System::SharedPtr< Aspose::Words::Lists::List > [GetListByListId](./getlistbylistid/)(int32_t) | Gets a list by a list identifier.  |
| System::SharedPtr< Aspose::Words::Lists::List > [idx_get](./idx_get/)(int32_t) | Gets a list by index.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
