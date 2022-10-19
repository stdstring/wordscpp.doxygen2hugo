---
title: SaveFormatToLoadFormat
second_title: Aspose.Words for C++ API Reference
description: Converts a SaveFormat value to a LoadFormat value if possible. 
type: docs
weight: 105
url: /cpp/aspose.words/fileformatutil/saveformattoloadformat/
---
## FileFormatUtil.SaveFormatToLoadFormat method


Converts a [SaveFormat](../../saveformat/) value to a [LoadFormat](../../loadformat/) value if possible.

```cpp
static Aspose::Words::LoadFormat Aspose::Words::FileFormatUtil::SaveFormatToLoadFormat(Aspose::Words::SaveFormat saveFormat)
```


## Examples




Shows how to convert a save format to its corresponding load format. 
```cpp
ASSERT_EQ(LoadFormat::Html, FileFormatUtil::SaveFormatToLoadFormat(SaveFormat::Html));

// Some file types can have documents saved to, but not loaded from using Aspose.Words.
// If we attempt to convert a save format of such a type to a load format, an exception will be thrown.
ASSERT_THROW(FileFormatUtil::SaveFormatToLoadFormat(SaveFormat::Jpeg), System::ArgumentException);
```

