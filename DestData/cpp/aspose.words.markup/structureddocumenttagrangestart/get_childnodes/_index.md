---
title: get_ChildNodes
second_title: Aspose.Words for C++ API Reference
description: Gets all nodes between this range start node and the range end node. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/structureddocumenttagrangestart/get_childnodes/
---
## StructuredDocumentTagRangeStart.get_ChildNodes method


Gets all nodes between this range start node and the range end node.

```cpp
System::SharedPtr<Aspose::Words::NodeCollection> Aspose::Words::Markup::StructuredDocumentTagRangeStart::get_ChildNodes()
```


## Examples




Shows how to get child nodes of [StructuredDocumentTagRangeStart](../). 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Multi-section structured document tags.docx");
auto tag =
    System::DynamicCast_noexcept<StructuredDocumentTagRangeStart>(doc->GetChildNodes(NodeType::StructuredDocumentTagRangeStart, true)->idx_get(0));

std::cout << "StructuredDocumentTagRangeStart values:" << std::endl;
std::cout << "\t|Child nodes count: " << tag->get_ChildNodes()->get_Count() << "\n" << std::endl;

for (const auto& node : System::IterateOver(tag->get_ChildNodes()))
{
    std::cout << String::Format(u"\t|Child node type: {0}", node->get_NodeType()) << std::endl;
}

for (const auto& node : System::IterateOver(tag->GetChildNodes(NodeType::Run, true)))
{
    std::cout << "\t|Child node text: " << node->GetText() << std::endl;
}
```

