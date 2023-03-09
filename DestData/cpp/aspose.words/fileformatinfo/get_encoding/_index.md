---
title: Aspose::Words::FileFormatInfo::get_Encoding method
linktitle: get_Encoding
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::FileFormatInfo::get_Encoding method. Gets the detected encoding if applicable to the current document format. At the moment detects encoding only for HTML documents in C++.
type: docs
weight: 1
url: /cpp/aspose.words/fileformatinfo/get_encoding/
---
## FileFormatInfo::get_Encoding method


Gets the detected encoding if applicable to the current document format. At the moment detects encoding only for HTML documents.

```cpp
System::SharedPtr<System::Text::Encoding> Aspose::Words::FileFormatInfo::get_Encoding() const
```


## Examples



Shows how to detect encoding in an html file. 
```cpp
SharedPtr<FileFormatInfo> info = FileFormatUtil::DetectFileFormat(MyDir + u"Document.html");

ASSERT_EQ(LoadFormat::Html, info->get_LoadFormat());

// The Encoding property is used only when we create a FileFormatInfo object for an html document.
ASSERT_EQ(u"Windows-1252", info->get_Encoding()->get_WebName());
ASSERT_EQ(1252, info->get_Encoding()->get_CodePage());
```

## See Also

* Class [FileFormatInfo](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
