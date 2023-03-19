---
title: Aspose::Words::CommentCollection class
linktitle: CommentCollection
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::CommentCollection class. Provides typed access to a collection of Comment nodes in C++.
type: docs
weight: 1200
url: /cpp/aspose.words/commentcollection/
---
## CommentCollection class


Provides typed access to a collection of [Comment](../comment/) nodes.

```cpp
class CommentCollection : public Aspose::Words::NodeCollection
```

## Methods

| Method | Description |
| --- | --- |
| [Add](../nodecollection/add/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds a node to the end of the collection. |
| [Clear](../nodecollection/clear/)() | Removes all nodes from this collection and from the document. |
| [Contains](../nodecollection/contains/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Determines whether a node is in the collection. |
| [get_Count](../nodecollection/get_count/)() | Gets the number of nodes in the collection. |
| [GetEnumerator](../nodecollection/getenumerator/)() override | Provides a simple "foreach" style iteration over the collection of nodes. |
| [idx_get](./idx_get/)(int32_t) | Retrieves a **Comment** at the given index. |
| [IndexOf](../nodecollection/indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the zero-based index of the specified node. |
| [Insert](../nodecollection/insert/)(int32_t, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts a node into the collection at the specified index. |
| [Remove](../nodecollection/remove/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the node from the collection and from the document. |
| [RemoveAt](../nodecollection/removeat/)(int32_t) | Removes the node at the specified index from the collection and from the document. |
| [ToArray](../nodecollection/toarray/)() | Copies all nodes from the collection to a new array of nodes. |

## Examples



Shows how to mark a comment as "done". 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);
builder->Writeln(u"Helo world!");

// Insert a comment to point out an error.
auto comment = MakeObject<Comment>(doc, u"John Doe", u"J.D.", System::DateTime::get_Now());
comment->SetText(u"Fix the spelling error!");
doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(comment);

// Comments have a "Done" flag, which is set to "false" by default.
// If a comment suggests that we make a change within the document,
// we can apply the change, and then also set the "Done" flag afterwards to indicate the correction.
ASSERT_FALSE(comment->get_Done());

doc->get_FirstSection()->get_Body()->get_FirstParagraph()->get_Runs()->idx_get(0)->set_Text(u"Hello world!");
comment->set_Done(true);

// Comments that are "done" will differentiate themselves
// from ones that are not "done" with a faded text color.
comment = MakeObject<Comment>(doc, u"John Doe", u"J.D.", System::DateTime::get_Now());
comment->SetText(u"Add text to this paragraph.");
builder->get_CurrentParagraph()->AppendChild(comment);

doc->Save(ArtifactsDir + u"Comment.Done.docx");
```

## See Also

* Class [NodeCollection](../nodecollection/)
* Namespace [Aspose::Words](../)
* Library [Aspose.Words for C++](../../)
