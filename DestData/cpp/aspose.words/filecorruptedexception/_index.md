---
title: Aspose::Words::FileCorruptedException typedef
linktitle: FileCorruptedException
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::FileCorruptedException typedef. Thrown during document load, when the document appears to be corrupted and impossible to load in C++.
type: docs
weight: 13300
url: /cpp/aspose.words/filecorruptedexception/
---
## FileCorruptedException typedef


Thrown during document load, when the document appears to be corrupted and impossible to load.

```cpp
using Aspose::Words::FileCorruptedException = typedef System::ExceptionWrapper<Details_FileCorruptedException>
```


## Examples



Shows how to catch a FileCorruptedException. 
```cpp
try
{
    // If we get an "Unreadable content" error message when trying to open a document using Microsoft Word,
    // chances are that we will get an exception thrown when trying to load that document using Aspose.Words.
    auto doc = MakeObject<Document>(MyDir + u"Corrupted document.docx");
}
catch (FileCorruptedException& e)
{
    std::cout << e->get_Message() << std::endl;
}
```

## See Also

* Namespace [Aspose::Words](../)
* Library [Aspose.Words for C++](../../)
