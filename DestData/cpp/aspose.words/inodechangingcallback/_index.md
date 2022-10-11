---
title: INodeChangingCallback
second_title: Aspose.Words for C++ API Reference
description: Implement this interface if you want to receive notifications when nodes are inserted or removed in the document. 
type: docs
weight: 0
url: /cpp/aspose.words/inodechangingcallback/
---
## INodeChangingCallback class


Implement this interface if you want to receive notifications when nodes are inserted or removed in the document. 

## Methods

| Method | Description |
| --- | --- |
| virtual void [NodeInserted](./nodeinserted/)(System::SharedPtr< Aspose::Words::NodeChangingArgs >) | Called when a node belonging to this document has been inserted into another node.  |
| virtual void [NodeInserting](./nodeinserting/)(System::SharedPtr< Aspose::Words::NodeChangingArgs >) | Called just before a node belonging to this document is about to be inserted into another node.  |
| virtual void [NodeRemoved](./noderemoved/)(System::SharedPtr< Aspose::Words::NodeChangingArgs >) | Called when a node belonging to this document has been removed from its parent.  |
| virtual void [NodeRemoving](./noderemoving/)(System::SharedPtr< Aspose::Words::NodeChangingArgs >) | Called just before a node belonging to this document is about to be removed from the document.  |
