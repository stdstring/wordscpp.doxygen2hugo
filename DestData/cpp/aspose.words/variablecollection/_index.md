---
title: VariableCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of document variables. 
type: docs
weight: 0
url: /cpp/aspose.words/variablecollection/
---
## VariableCollection class


A collection of document variables. 

## Methods

| Method | Description |
| --- | --- |
| void [Add](./add/)(const System::String &, const System::String &) | Adds a document variable to the collection.  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| void [Clear](./clear/)() | Removes all elements from the collection.  |
| bool [Contains](./contains/)(const System::String &) | Determines whether the collection contains a document variable with the given name.  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of elements contained in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::Collections::Generic::KeyValuePair< System::String, System::String > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object that can be used to iterate over all variable in the collection.  |
| System::String [idx_get](./idx_get/)(const System::String &) | Gets or a sets a document variable by the case-insensitive name. null values are not allowed as a right hand side of the assignment and will be replaced by empty string.  |
| System::String [idx_get](./idx_get/)(int32_t) | Gets or sets a document variable at the specified index. null values are not allowed as a right hand side of the assignment and will be replaced by empty string.  |
| void [idx_set](./idx_set/)(const System::String &, const System::String &) | Gets or a sets a document variable by the case-insensitive name. null values are not allowed as a right hand side of the assignment and will be replaced by empty string.  |
| void [idx_set](./idx_set/)(int32_t, const System::String &) | Gets or sets a document variable at the specified index. null values are not allowed as a right hand side of the assignment and will be replaced by empty string.  |
| int32_t [IndexOfKey](./indexofkey/)(const System::String &) | Returns the zero-based index of the specified document variable in the collection.  |
| void [Remove](./remove/)(const System::String &) | Removes a document variable with the specified name from the collection.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a document variable at the specified index.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
