---
title: get_Id
second_title: Aspose.Words for C++ API Reference
description: Specifies a unique read-only persistent numerical Id for this structured document tag.
type: docs
weight: 66
url: /cpp/aspose.words.markup/structureddocumenttagrangestart/get_id/
---
## StructuredDocumentTagRangeStart::get_Id method


Specifies a unique read-only persistent numerical Id for this structured document tag.

```cpp
int32_t Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_Id() override
```


Id attribute shall follow these rules:* The document shall retain structured document tag ids only if the whole document is cloned [Clone](../../../aspose.words/document/clone/).
* During **ImportNode()** Id shall be retained if import does not cause conflicts with other structured document tag Ids in the target document.
* If multiple structured document tag nodes specify the same decimal number value for the Id attribute, then the first structured document tag in the document shall maintain this original Id, and all subsequent structured document tag nodes shall have new identifiers assigned to them when the document is loaded.
* During standalone structured document tag **Clone()** operation new unique ID will be generated for the cloned structured document tag node.
* If Id is not specified in the source document, then the structured document tag node shall have a new unique identifier assigned to it when the document is loaded.



## Examples



Shows how to get the properties of multi-section structured document tags. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Multi-section structured document tags.docx");

auto rangeStartTag =
    System::DynamicCast_noexcept<StructuredDocumentTagRangeStart>(doc->GetChildNodes(NodeType::StructuredDocumentTagRangeStart, true)->idx_get(0));
auto rangeEndTag =
    System::DynamicCast_noexcept<StructuredDocumentTagRangeEnd>(doc->GetChildNodes(NodeType::StructuredDocumentTagRangeEnd, true)->idx_get(0));

std::cout << "StructuredDocumentTagRangeStart values:" << std::endl;
std::cout << "\t|Id: " << rangeStartTag->get_Id() << std::endl;
std::cout << "\t|Title: " << rangeStartTag->get_Title() << std::endl;
std::cout << "\t|PlaceholderName: " << rangeStartTag->get_PlaceholderName() << std::endl;
std::cout << String::Format(u"\t|IsShowingPlaceholderText: {0}", rangeStartTag->get_IsShowingPlaceholderText()) << std::endl;
std::cout << String::Format(u"\t|LockContentControl: {0}", rangeStartTag->get_LockContentControl()) << std::endl;
std::cout << String::Format(u"\t|LockContents: {0}", rangeStartTag->get_LockContents()) << std::endl;
std::cout << String::Format(u"\t|Level: {0}", rangeStartTag->get_Level()) << std::endl;
std::cout << String::Format(u"\t|NodeType: {0}", rangeStartTag->get_NodeType()) << std::endl;
std::cout << "\t|RangeEnd: " << rangeStartTag->get_RangeEnd() << std::endl;
std::cout << "\t|Color: " << rangeStartTag->get_Color().ToArgb() << std::endl;
std::cout << String::Format(u"\t|SdtType: {0}", rangeStartTag->get_SdtType()) << std::endl;
std::cout << "\t|Tag: " << rangeStartTag->get_Tag() << "\n" << std::endl;

std::cout << "StructuredDocumentTagRangeEnd values:" << std::endl;
std::cout << "\t|Id: " << rangeEndTag->get_Id() << std::endl;
std::cout << String::Format(u"\t|NodeType: {0}", rangeEndTag->get_NodeType()) << std::endl;
```

