---
title: FontInfoCollection
second_title: Aspose.Words for C++ API Reference
description: Represents a collection of fonts used in a document. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/fontinfocollection/
---
## FontInfoCollection class


Represents a collection of fonts used in a document. 

## Methods

| Method | Description |
| --- | --- |
| const_iterator [begin](./begin/)() const |  |
| iterator [begin](./begin/)() |  |
| const_iterator [cbegin](./cbegin/)() const |  |
| const_iterator [cend](./cend/)() const |  |
| bool [Contains](./contains/)(const System::String &) | Determines whether the collection contains a font with the given name.  |
| const_iterator [end](./end/)() const |  |
| iterator [end](./end/)() |  |
| int32_t [get_Count](./get_count/)() | Gets the number of elements contained in the collection.  |
| bool [get_EmbedSystemFonts](./get_embedsystemfonts/)() const | Specifies whether or not to embed System fonts into the document. Default value for this property is **false**. This option works only when EmbedTrueTypeFonts option is set to **true**.  |
| bool [get_EmbedTrueTypeFonts](./get_embedtruetypefonts/)() const | Specifies whether or not to embed TrueType fonts in a document when it is saved. Default value for this property is **false**.  |
| bool [get_SaveSubsetFonts](./get_savesubsetfonts/)() const | Specifies whether or not to save a subset of the embedded TrueType fonts with the document. Default value for this property is **false**. This option works only when EmbedTrueTypeFonts property is set to **true**.  |
| System::SharedPtr< System::Collections::Generic::IEnumerator< System::SharedPtr< Aspose::Words::Fonts::FontInfo > > > [GetEnumerator](./getenumerator/)() override | Returns an enumerator object that can be used to iterate over all items in the collection.  |
| System::SharedPtr< Aspose::Words::Fonts::FontInfo > [idx_get](./idx_get/)(const System::String &) | Gets a font with the specified name.  |
| System::SharedPtr< Aspose::Words::Fonts::FontInfo > [idx_get](./idx_get/)(int32_t) | Gets a font at the specified index.  |
| void [set_EmbedSystemFonts](./set_embedsystemfonts/)(bool) | Setter for Aspose::Words::Fonts::FontInfoCollection::get_EmbedSystemFonts.  |
| void [set_EmbedTrueTypeFonts](./set_embedtruetypefonts/)(bool) | Setter for Aspose::Words::Fonts::FontInfoCollection::get_EmbedTrueTypeFonts.  |
| void [set_SaveSubsetFonts](./set_savesubsetfonts/)(bool) | Setter for Aspose::Words::Fonts::FontInfoCollection::get_SaveSubsetFonts.  |
| virtualized_iterator * [virtualizeBeginConstIterator](./virtualizebeginconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeBeginIterator](./virtualizebeginiterator/)() override |  |
| virtualized_iterator * [virtualizeEndConstIterator](./virtualizeendconstiterator/)() const override |  |
| virtualized_iterator * [virtualizeEndIterator](./virtualizeenditerator/)() override |  |
