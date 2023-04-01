---
title: Aspose::Words::Paragraph::get_IsMoveToRevision method
linktitle: get_IsMoveToRevision
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Paragraph::get_IsMoveToRevision method. Returns true if this object was moved (inserted) in Microsoft Word while change tracking was enabled in C++.'
type: docs
weight: 1600
url: /cpp/aspose.words/paragraph/get_ismovetorevision/
---
## Paragraph::get_IsMoveToRevision method


Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled.

```cpp
bool Aspose::Words::Paragraph::get_IsMoveToRevision()
```


## Examples



Shows how to check whether a paragraph is a move revision. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Revisions.docx");

// This document contains "Move" revisions, which appear when we highlight text with the cursor,
// and then drag it to move it to another location
// while tracking revisions in Microsoft Word via "Review" -> "Track changes".
ASSERT_EQ(6, doc->get_Revisions()->LINQ_Count([](SharedPtr<Revision> r) { return r->get_RevisionType() == RevisionType::Moving; }));

SharedPtr<ParagraphCollection> paragraphs = doc->get_FirstSection()->get_Body()->get_Paragraphs();

// Move revisions consist of pairs of "Move from", and "Move to" revisions.
// These revisions are potential changes to the document that we can either accept or reject.
// Before we accept/reject a move revision, the document
// must keep track of both the departure and arrival destinations of the text.
// The second and the fourth paragraph define one such revision, and thus both have the same contents.
ASSERT_EQ(paragraphs->idx_get(1)->GetText(), paragraphs->idx_get(3)->GetText());

// The "Move from" revision is the paragraph where we dragged the text from.
// If we accept the revision, this paragraph will disappear,
// and the other will remain and no longer be a revision.
ASSERT_TRUE(paragraphs->idx_get(1)->get_IsMoveFromRevision());

// The "Move to" revision is the paragraph where we dragged the text to.
// If we reject the revision, this paragraph instead will disappear, and the other will remain.
ASSERT_TRUE(paragraphs->idx_get(3)->get_IsMoveToRevision());
```

## See Also

* Class [Paragraph](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
