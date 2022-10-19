---
title: get_Ancestor
second_title: Aspose.Words for C++ API Reference
description: Returns the parent Comment object. Returns null for top-level comments. 
type: docs
weight: 40
url: /cpp/aspose.words/comment/get_ancestor/
---
## Comment.get_Ancestor method


Returns the parent [Comment](../) object. Returns null for top-level comments.

```cpp
System::SharedPtr<Aspose::Words::Comment> Aspose::Words::Comment::get_Ancestor()
```


## Examples




Shows how to print all of a document's comments and their replies. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Comments.docx");

SharedPtr<NodeCollection> comments = doc->GetChildNodes(NodeType::Comment, true);

// If a comment has no ancestor, it is a "top-level" comment as opposed to a reply-type comment.
// Print all top-level comments along with any replies they may have.
auto hasNullAncestor = [](SharedPtr<Comment> c)
{
    return c->get_Ancestor() == nullptr;
};

for (auto comment : System::IterateOver(comments->LINQ_OfType<SharedPtr<Comment>>()->LINQ_Where(hasNullAncestor)))
{
    std::cout << "Top-level comment:" << std::endl;
    std::cout << "\t\"" << comment->GetText().Trim() << "\", by " << comment->get_Author() << std::endl;
    std::cout << "Has " << comment->get_Replies()->get_Count() << " replies" << std::endl;
    for (const auto& commentReply : System::IterateOver<Comment>(comment->get_Replies()))
    {
        std::cout << "\t\"" << commentReply->GetText().Trim() << "\", by " << commentReply->get_Author() << std::endl;
    }
    std::cout << std::endl;
}
```

