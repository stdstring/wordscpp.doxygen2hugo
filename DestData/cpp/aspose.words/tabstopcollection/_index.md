---
title: TabStopCollection
second_title: Aspose.Words for C++ API Reference
description: A collection of TabStop objects that represent custom tabs for a paragraph or a style. 
type: docs
weight: 0
url: /cpp/aspose.words/tabstopcollection/
---
## TabStopCollection class


A collection of TabStop objects that represent custom tabs for a paragraph or a style. 

## Methods

| Method | Description |
| --- | --- |
| void [Add](./add/)(const System::SharedPtr< Aspose::Words::TabStop > &) | Adds or replaces a tab stop in the collection.  |
| void [Add](./add/)(double, Aspose::Words::TabAlignment, Aspose::Words::TabLeader) | Adds or replaces a tab stop in the collection.  |
| System::SharedPtr< Aspose::Words::TabStop > [After](./after/)(double) | Gets a first tab stop to the right of the specified position.  |
| System::SharedPtr< Aspose::Words::TabStop > [Before](./before/)(double) | Gets a first tab stop to the left of the specified position.  |
| void [Clear](./clear/)() | Deletes all tab stop positions.  |
| bool [Equals](./equals/)(const System::SharedPtr< Aspose::Words::TabStopCollection > &) | Determines whether the specified TabStopCollection is equal in value to the current TabStopCollection.  |
| bool [Equals](./equals/)(System::SharedPtr< System::Object >) override | Determines whether the specified object is equal in value to the current object.  |
| int32_t [get_Count](./get_count/)() | Gets the number of tab stops in the collection.  |
| int32_t [GetHashCode](./gethashcode/)() const override | Serves as a hash function for this type.  |
| int32_t [GetIndexByPosition](./getindexbyposition/)(double) | Gets the index of a tab stop with the specified position in points.  |
| double [GetPositionByIndex](./getpositionbyindex/)(int32_t) | Gets the position (in points) of the tab stop at the specified index.  |
| System::SharedPtr< Aspose::Words::TabStop > [idx_get](./idx_get/)(double) | Gets a tab stop at the specified position.  |
| System::SharedPtr< Aspose::Words::TabStop > [idx_get](./idx_get/)(int32_t) | Gets a tab stop at the given index.  |
| void [RemoveByIndex](./removebyindex/)(int32_t) | Removes a tab stop at the specified index from the collection.  |
| void [RemoveByPosition](./removebyposition/)(double) | Removes a tab stop at the specified position from the collection.  |
