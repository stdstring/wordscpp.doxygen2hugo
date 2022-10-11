---
title: MappedDataFieldCollection
second_title: Aspose.Words for C++ API Reference
description: Allows to automatically map between names of fields in your data source and names of mail merge fields in the document. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/mappeddatafieldcollection/
---
## MappedDataFieldCollection class


Allows to automatically map between names of fields in your data source and names of mail merge fields in the document. 

## Methods

| Method | Description |
| --- | --- |
| void [Add](./add/)(const System::String &, const System::String &) | Adds a new field mapping.  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| void [Clear](./clear/)() | Removes all elements from the collection.  |
| bool [ContainsKey](./containskey/)(const System::String &) | Determines whether a mapping from the specified field in the document exists in the collection.  |
| bool [ContainsValue](./containsvalue/)(const System::String &) | Determines whether a mapping from the specified field in the data source exists in the collection.  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of elements contained in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::Collections::Generic::KeyValuePair< System::String, System::String > > > [GetEnumerator](./getenumerator/)() override | Returns a dictionary enumerator object that can be used to iterate over all items in the collection.  |
| System::String [idx_get](./idx_get/)(const System::String &) | Gets or sets the name of the field in the data source associated with the specified mail merge field.  |
| void [idx_set](./idx_set/)(const System::String &, const System::String &) | Gets or sets the name of the field in the data source associated with the specified mail merge field.  |
| void [Remove](./remove/)(const System::String &) | Removes a field mapping.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
