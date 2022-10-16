---
title: StoryType
second_title: Aspose.Words for C++ API Reference
description: Text of a Word document is stored in stories. StoryType identifies a story. 
type: docs
weight: 0
url: /cpp/aspose.words/storytype/
---
## StoryType enum


Text of a Word document is stored in stories. **StoryType** identifies a story.


## Examples




Shows how to remove all shapes from a node. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Use a DocumentBuilder to insert a shape. This is an inline shape,
// which has a parent Paragraph, which is a child node of the first section's Body.
builder->InsertShape(ShapeType::Cube, 100.0, 100.0);

ASSERT_EQ(1, doc->GetChildNodes(NodeType::Shape, true)->get_Count());

// We can delete all shapes from the child paragraphs of this Body.
ASSERT_EQ(StoryType::MainText, doc->get_FirstSection()->get_Body()->get_StoryType());
doc->get_FirstSection()->get_Body()->DeleteShapes();

ASSERT_EQ(0, doc->GetChildNodes(NodeType::Shape, true)->get_Count());
```

