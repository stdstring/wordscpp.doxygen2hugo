---
title: get_Document
second_title: Aspose.Words for C++ API Reference
description: Gets the owner document.
type: docs
weight: 53
url: /cpp/aspose.words/style/get_document/
---
## Style::get_Document method


Gets the owner document.

```cpp
System::SharedPtr<Aspose::Words::DocumentBase> Aspose::Words::Style::get_Document()
```


## Examples




Shows how to access a document's style collection. 
```cpp
auto doc = MakeObject<Document>();

ASSERT_EQ(4, doc->get_Styles()->get_Count());

// Enumerate and list all the styles that a document created using Aspose.Words contains by default.
{
    SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<Style>>> stylesEnum = doc->get_Styles()->GetEnumerator();
    while (stylesEnum->MoveNext())
    {
        SharedPtr<Style> curStyle = stylesEnum->get_Current();
        std::cout << String::Format(u"Style name:\t\"{0}\", of type \"{1}\"", curStyle->get_Name(), curStyle->get_Type()) << std::endl;
        std::cout << "\tSubsequent style:\t" << curStyle->get_NextParagraphStyleName() << std::endl;
        std::cout << String::Format(u"\tIs heading:\t\t\t{0}", curStyle->get_IsHeading()) << std::endl;
        std::cout << String::Format(u"\tIs QuickStyle:\t\t{0}", curStyle->get_IsQuickStyle()) << std::endl;

        ASPOSE_ASSERT_EQ(doc, curStyle->get_Document());
    }
}
```

