---
title: SdtListItemCollection
second_title: Aspose.Words for C++ API Reference
description: Provides access to SdtListItem elements of a structured document tag. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/sdtlistitemcollection/
---
## SdtListItemCollection class


Provides access to SdtListItem elements of a structured document tag. 

## Methods

| Method | Description |
| --- | --- |
| void [Add](./add/)(const System::SharedPtr< Aspose::Words::Markup::SdtListItem > &) | Adds an item to this collection.  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| void [Clear](./clear/)() | Clears all items from this collection.  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets number of items in the collection.  |
| System::SharedPtr< Aspose::Words::Markup::SdtListItem > [get_SelectedValue](./get_selectedvalue/)() | Specifies currently selected value in this list. Null value allowed, meaning that no currently selected entry is associated with this list item collection.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Markup::SdtListItem > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object that can be used to iterate over all items in the collection.  |
| System::SharedPtr< Aspose::Words::Markup::SdtListItem > [idx_get](./idx_get/)(int32_t) | Returns a SdtListItem object given its zero-based index in the collection.  |
| void [RemoveAt](./removeat/)(int32_t) | Removes a list item at the specified index.  |
| void [set_SelectedValue](./set_selectedvalue/)(const System::SharedPtr< Aspose::Words::Markup::SdtListItem > &) | Setter for Aspose::Words::Markup::SdtListItemCollection::get_SelectedValue.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
