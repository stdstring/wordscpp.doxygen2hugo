---
title: IFieldMergingCallback
second_title: Aspose.Words for C++ API Reference
description: Implement this interface if you want to control how data is inserted into merge fields during a mail merge operation. 
type: docs
weight: 0
url: /cpp/aspose.words.mailmerging/ifieldmergingcallback/
---

Implement this interface if you want to control how data is inserted into merge fields during a mail merge operation. 

## Methods

| Method | Description |
| --- | --- |
| virtual [FieldMerging](./fieldmerging/)(System::SharedPtr< Aspose::Words::MailMerging::FieldMergingArgs >) | Called when the Aspose.Words mail merge engine is about to insert data into a merge field in the document.  |
| virtual [ImageFieldMerging](./imagefieldmerging/)(System::SharedPtr< Aspose::Words::MailMerging::ImageFieldMergingArgs >) | Called when the Aspose.Words mail merge engine is about to insert an image into a merge field.  |
