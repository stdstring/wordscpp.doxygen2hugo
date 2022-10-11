---
title: ListLevelCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of list formatting for each level in a list. 
type: docs
weight: 0
url: /cpp/aspose.words.lists/listlevelcollection/
---
## ListLevelCollection class


A collection of list formatting for each level in a list. 

## Methods

| Method | Description |
| --- | --- |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of levels in this list.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Lists::ListLevel > > > [GetEnumerator](./getenumerator/)() override | Gets the enumerator object that will enumerate levels in this list.  |
| System::SharedPtr< Aspose::Words::Lists::ListLevel > [idx_get](./idx_get/)(int32_t) | Gets a list level by index.  |
| void [idx_set](./idx_set/)(int32_t, const System::SharedPtr< Aspose::Words::Lists::ListLevel > &) | Gets a list level by index.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
