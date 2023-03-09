---
title: Aspose::Words::Node::get_Document method
linktitle: get_Document
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Node::get_Document method. Gets the document to which this node belongs in C++.
type: docs
weight: 40
url: /cpp/aspose.words/node/get_document/
---
## Node::get_Document method


Gets the document to which this node belongs.

```cpp
virtual System::SharedPtr<Aspose::Words::DocumentBase> Aspose::Words::Node::get_Document() const
```

## Remarks


The node always belongs to a document even if it has just been created and not yet added to the tree, or if it has been removed from the tree.

## Examples



Shows how to create a node and set its owning document. 
```cpp
auto doc = MakeObject<Document>();
auto para = MakeObject<Paragraph>(doc);
para->AppendChild(MakeObject<Run>(doc, u"Hello world!"));

// We have not yet appended this paragraph as a child to any composite node.
ASSERT_TRUE(para->get_ParentNode() == nullptr);

// If a node is an appropriate child node type of another composite node,
// we can attach it as a child only if both nodes have the same owner document.
// The owner document is the document we passed to the node's constructor.
// We have not attached this paragraph to the document, so the document does not contain its text.
ASPOSE_ASSERT_EQ(para->get_Document(), doc);
ASSERT_EQ(String::Empty, doc->GetText().Trim());

// Since the document owns this paragraph, we can apply one of its styles to the paragraph's contents.
para->get_ParagraphFormat()->set_Style(doc->get_Styles()->idx_get(u"Heading 1"));

// Add this node to the document, and then verify its contents.
doc->get_FirstSection()->get_Body()->AppendChild(para);

ASPOSE_ASSERT_EQ(doc->get_FirstSection()->get_Body(), para->get_ParentNode());
ASSERT_EQ(u"Hello world!", doc->GetText().Trim());
```

## See Also

* Class [DocumentBase](../../documentbase/)
* Class [Node](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
