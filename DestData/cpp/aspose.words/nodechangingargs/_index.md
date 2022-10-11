---
title: NodeChangingArgs
second_title: Aspose.Words for C++ API Reference
description: Provides data for methods of the INodeChangingCallback interface. 
type: docs
weight: 0
url: /cpp/aspose.words/nodechangingargs/
---
## NodeChangingArgs class


Provides data for methods of the INodeChangingCallback interface. 

## Methods

| Method | Description |
| --- | --- |
| Aspose::Words::NodeChangingAction [get_Action](./get_action/)() const | Gets a value indicating what type of node change event is occurring.  |
| System::SharedPtr< Aspose::Words::Node > [get_NewParent](./get_newparent/)() const | Gets the node's parent that will be set after the operation completes.  |
| System::SharedPtr< Aspose::Words::Node > [get_Node](./get_node/)() const | Gets the Node that is being added or removed.  |
| System::SharedPtr< Aspose::Words::Node > [get_OldParent](./get_oldparent/)() const | Gets the node's parent before the operation began.  |
