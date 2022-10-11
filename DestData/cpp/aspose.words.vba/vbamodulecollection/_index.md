---
title: VbaModuleCollection
second_title: Aspose.Words for C++ API Reference
description: Represents a collection of VbaModule objects. 
type: docs
weight: 0
url: /cpp/aspose.words.vba/vbamodulecollection/
---
## VbaModuleCollection class


Represents a collection of VbaModule objects. 

## Methods

| Method | Description |
| --- | --- |
| void [Add](./add/)(const System::SharedPtr< Aspose::Words::Vba::VbaModule > &) | Adds a module to the collection.  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Returns the number of VBA modules in the collection.  |
| System::SharedPtr< Aspose::Words::Vba::VbaModule > [idx_get](./idx_get/)(const System::String &) | Retrieves a VbaModule object by name, or Null if not found.  |
| System::SharedPtr< Aspose::Words::Vba::VbaModule > [idx_get](./idx_get/)(int32_t) | Retrieves a VbaModule object by index.  |
| void [Remove](./remove/)(const System::SharedPtr< Aspose::Words::Vba::VbaModule > &) | Removes the specified module from the collection.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
