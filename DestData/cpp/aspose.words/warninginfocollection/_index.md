---
title: WarningInfoCollection
second_title: Aspose.Words for C++ API Reference
description: Represents a typed collection of WarningInfo objects. 
type: docs
weight: 0
url: /cpp/aspose.words/warninginfocollection/
---
## WarningInfoCollection class


Represents a typed collection of WarningInfo objects. 

## Methods

| Method | Description |
| --- | --- |
|  [WarningInfoCollection](./warninginfocollection/)() |  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| void [Clear](./clear/)() | Removes all elements from the collection.  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of elements contained in the collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::WarningInfo > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object that can be used to iterate over all items in the collection.  |
| System::SharedPtr< Aspose::Words::WarningInfo > [idx_get](./idx_get/)(int32_t) | Gets an item at the specified index.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
| void [Warning](./warning/)(System::SharedPtr< Aspose::Words::WarningInfo >) override | Implements the IWarningCallback interface. Adds a warning to this collection.  |
