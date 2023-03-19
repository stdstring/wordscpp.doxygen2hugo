---
title: Aspose::Words::Framesets::Frameset::get_IsFrameLinkToFile method
linktitle: get_IsFrameLinkToFile
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Framesets::Frameset::get_IsFrameLinkToFile method. Gets or sets a value indicating whether the web page or document file name specified in the FrameDefaultUrl property is an external resource the frame is linked with in C++.
type: docs
weight: 400
url: /cpp/aspose.words.framesets/frameset/get_isframelinktofile/
---
## Frameset::get_IsFrameLinkToFile method


Gets or sets a value indicating whether the web page or document file name specified in the [FrameDefaultUrl](../get_framedefaulturl/) property is an external resource the frame is linked with.

```cpp
bool Aspose::Words::Framesets::Frameset::get_IsFrameLinkToFile()
```


## Examples



Shows how to access frames on-page. 
```cpp
// Document contains several frames with links to other documents.
auto doc = MakeObject<Document>(MyDir + u"Frameset.docx");

// We can check the default URL (a web page URL or local document) or if the frame is an external resource.
ASSERT_EQ(u"https://file-examples-com.github.io/uploads/2017/02/file-sample_100kB.docx",
          doc->get_Frameset()->get_ChildFramesets()->idx_get(0)->get_ChildFramesets()->idx_get(0)->get_FrameDefaultUrl());
ASSERT_TRUE(doc->get_Frameset()->get_ChildFramesets()->idx_get(0)->get_ChildFramesets()->idx_get(0)->get_IsFrameLinkToFile());

ASSERT_EQ(u"Document.docx", doc->get_Frameset()->get_ChildFramesets()->idx_get(1)->get_FrameDefaultUrl());
ASSERT_FALSE(doc->get_Frameset()->get_ChildFramesets()->idx_get(1)->get_IsFrameLinkToFile());

// Change properties for one of our frames.
doc->get_Frameset()->get_ChildFramesets()->idx_get(0)->get_ChildFramesets()->idx_get(0)->set_FrameDefaultUrl(
    u"https://github.com/aspose-words/Aspose.Words-for-.NET/blob/master/Examples/Data/Absolute%20position%20tab.docx");
doc->get_Frameset()->get_ChildFramesets()->idx_get(0)->get_ChildFramesets()->idx_get(0)->set_IsFrameLinkToFile(false);
```

## See Also

* Class [Frameset](../)
* Namespace [Aspose::Words::Framesets](../../)
* Library [Aspose.Words for C++](../../../)
