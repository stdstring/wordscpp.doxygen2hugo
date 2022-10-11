---
title: DropDownItemCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of strings that represent all the items in a drop-down form field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/dropdownitemcollection/
---
## DropDownItemCollection class


A collection of strings that represent all the items in a drop-down form field. 

## Methods

| Method | Description |
| --- | --- |
| int32_t [Add](./add/)(const System::String &) | Adds a string to the end of the collection.  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| void [Clear](./clear/)() | Removes all elements from the collection.  |
| bool [Contains](./contains/)(const System::String &) | Determines whether the collection contains the specified value.  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of elements contained in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::String > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object that can be used to iterate over all items in the collection.  |
| System::String [idx_get](./idx_get/)(int32_t) | Gets or sets the element at the specified index.  |
| void [idx_set](./idx_set/)(int32_t, const System::String &) | Gets or sets the element at the specified index.  |
| int32_t [IndexOf](./indexof/)(const System::String &) | Returns the zero-based index of the specified value in the collection.  |
| void [Insert](./insert/)(int32_t, const System::String &) | Inserts a string into the collection at the specified index.  |
| void [Remove](./remove/)(const System::String &) | Removes the specified value from the collection.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a value at the specified index.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
