---
title: EditableRange
second_title: Aspose.Words for C++ API Reference
description: Represents a single editable range. 
type: docs
weight: 0
url: /cpp/aspose.words/editablerange/
---
## EditableRange class


Represents a single editable range. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::EditableRangeEnd > [get_EditableRangeEnd](./get_editablerangeend/)() | Gets the node that represents the end of the editable range.  |
| System::SharedPtr< Aspose::Words::EditableRangeStart > [get_EditableRangeStart](./get_editablerangestart/)() const | Gets the node that represents the start of the editable range.  |
| Aspose::Words::EditorType [get_EditorGroup](./get_editorgroup/)() | Returns or sets an alias (or editing group) which shall be used to determine if the current user shall be allowed to edit this editable range.  |
| int32_t [get_Id](./get_id/)() | Gets the editable range identifier.  |
| System::String [get_SingleUser](./get_singleuser/)() | Returns or sets the single user for editable range.  |
| void [Remove](./remove/)() | Removes the editable range from the document. Does not remove content inside the editable range.  |
| void [set_EditorGroup](./set_editorgroup/)(Aspose::Words::EditorType) | Setter for Aspose::Words::EditableRange::get_EditorGroup.  |
| void [set_SingleUser](./set_singleuser/)(const System::String &) | Setter for Aspose::Words::EditableRange::get_SingleUser.  |
