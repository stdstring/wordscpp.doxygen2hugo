---
title: DigitalSignatureCollection
second_title: Aspose.Words for C++ API Reference
description: Provides a read-only collection of digital signatures attached to a document. 
type: docs
weight: 0
url: /cpp/aspose.words.digitalsignatures/digitalsignaturecollection/
---
## DigitalSignatureCollection class


Provides a read-only collection of digital signatures attached to a document. 

## Methods

| Method | Description |
| --- | --- |
|  [DigitalSignatureCollection](./digitalsignaturecollection/)() |  |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of elements contained in the collection.  |
| bool [get_IsValid](./get_isvalid/)() | Returns **true** if all digital signatures in this collection are valid and the document has not been tampered with Also returns **true** if there are no digital signatures. Returns **false** if at least one digital signature is invalid.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::DigitalSignatures::DigitalSignature > > > [GetEnumerator](./getenumerator/)() override | Returns a dictionary enumerator object that can be used to iterate over all items in the collection.  |
| System::SharedPtr< Aspose::Words::DigitalSignatures::DigitalSignature > [idx_get](./idx_get/)(int32_t) | Gets a document signature at the specified index.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
