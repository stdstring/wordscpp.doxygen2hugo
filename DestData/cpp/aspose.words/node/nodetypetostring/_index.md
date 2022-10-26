---
title: NodeTypeToString
second_title: Aspose.Words for C++ API Reference
description: A utility method that converts a node type enum value into a user friendly string.
type: docs
weight: 235
url: /cpp/aspose.words/node/nodetypetostring/
---
## Node.NodeTypeToString method


A utility method that converts a node type enum value into a user friendly string.

```cpp
static System::String Aspose::Words::Node::NodeTypeToString(Aspose::Words::NodeType nodeType)
```


## Examples




Shows how to traverse a composite node's tree of child nodes. 
```cpp
void RecurseChildren()
{
    auto doc = MakeObject<Document>(MyDir + u"Paragraphs.docx");

    // Any node that can contain child nodes, such as the document itself, is composite.
    ASSERT_TRUE(doc->get_IsComposite());

    // Invoke the recursive function that will go through and print all the child nodes of a composite node.
    TraverseAllNodes(doc, 0);
}

void TraverseAllNodes(SharedPtr<CompositeNode> parentNode, int depth)
{
    for (SharedPtr<Node> childNode = parentNode->get_FirstChild(); childNode != nullptr; childNode = childNode->get_NextSibling())
    {
        std::cout << (String(u'\t', depth)) << Node::NodeTypeToString(childNode->get_NodeType());

        // Recurse into the node if it is a composite node. Otherwise, print its contents if it is an inline node.
        if (childNode->get_IsComposite())
        {
            std::cout << std::endl;
            TraverseAllNodes(System::DynamicCast<CompositeNode>(childNode), depth + 1);
        }
        else if (System::ObjectExt::Is<Inline>(childNode))
        {
            std::cout << " - \"" << childNode->GetText().Trim() << "\"" << std::endl;
        }
        else
        {
            std::cout << std::endl;
        }
    }
}
```


Shows how to use a node's NextSibling property to enumerate through its immediate children. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Paragraphs.docx");

for (SharedPtr<Node> node = doc->get_FirstSection()->get_Body()->get_FirstChild(); node != nullptr; node = node->get_NextSibling())
{
    std::cout << std::endl;
    std::cout << "Node type: " << Node::NodeTypeToString(node->get_NodeType()) << std::endl;

    String contents = node->GetText().Trim();
    std::cout << (contents == String::Empty ? u"This node contains no text" : String::Format(u"Contents: \"{0}\"", node->GetText().Trim()))
              << std::endl;
}
```

