---
title: Revision
second_title: Aspose.Words for C++ API Reference
description: Represents a revision (tracked change) in a document node or style. Use RevisionType to check the type of this revision. 
type: docs
weight: 0
url: /cpp/aspose.words/revision/
---
## Revision class


Represents a revision (tracked change) in a document node or style. Use RevisionType to check the type of this revision. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)() | Accepts this revision.  |
| [get_Author](./get_author/)() | Gets or sets the author of this revision. Can not be empty string or null.  |
| [get_DateTime](./get_datetime/)() | Gets or sets the date/time of this revision.  |
| [get_Group](./get_group/)() | Gets the revision group. Returns null if the revision does not belong to any group.  |
| [get_ParentNode](./get_parentnode/)() | Gets the immediate parent node (owner) of this revision. This property will work for any revision type other than StyleDefinitionChange.  |
| [get_ParentStyle](./get_parentstyle/)() | Gets the immediate parent style (owner) of this revision. This property will work for only for the StyleDefinitionChange revision type.  |
| [get_RevisionType](./get_revisiontype/)() const | Gets the type of this revision.  |
| [Reject](./reject/)() | Reject this revision.  |
| [set_Author](./set_author/)(const System::String\&) | Setter for Aspose::Words::Revision::get_Author.  |
| [set_DateTime](./set_datetime/)(System::DateTime) | Setter for Aspose::Words::Revision::get_DateTime.  |
