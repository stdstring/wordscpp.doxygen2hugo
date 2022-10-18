---
title: get_IsEndOfSection
second_title: Aspose.Words for C++ API Reference
description: True if this paragraph is the last paragraph in the Body (main text story) of a Section; false otherwise. 
type: docs
weight: 0
url: /cpp/aspose.words/paragraph/get_isendofsection/
---
## Paragraph.get_IsEndOfSection method


True if this paragraph is the last paragraph in the **Body** (main text story) of a **Section**; false otherwise.

```cpp
bool Aspose::Words::Paragraph::get_IsEndOfSection()
```


## Examples




Shows how to insert the contents of one document to a bookmark in another document. 
```cpp
void InsertAtBookmark()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    builder->StartBookmark(u"InsertionPoint");
    builder->Write(u"We will insert a document here: ");
    builder->EndBookmark(u"InsertionPoint");

    auto docToInsert = MakeObject<Document>();
    builder = MakeObject<DocumentBuilder>(docToInsert);

    builder->Write(u"Hello world!");

    docToInsert->Save(ArtifactsDir + u"NodeImporter.InsertAtMergeField.docx");

    SharedPtr<Bookmark> bookmark = doc->get_Range()->get_Bookmarks()->idx_get(u"InsertionPoint");
    InsertDocument(bookmark->get_BookmarkStart()->get_ParentNode(), docToInsert);

    ASSERT_EQ(String(u"We will insert a document here: ") + u"\rHello world!", doc->GetText().Trim());
}

static void InsertDocument(SharedPtr<Node> insertionDestination, SharedPtr<Document> docToInsert)
{
    if (insertionDestination->get_NodeType() == NodeType::Paragraph || insertionDestination->get_NodeType() == NodeType::Table)
    {
        SharedPtr<CompositeNode> destinationParent = insertionDestination->get_ParentNode();

        auto importer = MakeObject<NodeImporter>(docToInsert, insertionDestination->get_Document(), ImportFormatMode::KeepSourceFormatting);

        // Loop through all block-level nodes in the section's body,
        // then clone and insert every node that is not the last empty paragraph of a section.
        for (const auto& srcSection : System::IterateOver(docToInsert->get_Sections()->LINQ_OfType<SharedPtr<Section>>()))
        {
            for (const auto& srcNode : System::IterateOver(srcSection->get_Body()))
            {
                if (srcNode->get_NodeType() == NodeType::Paragraph)
                {
                    auto para = System::DynamicCast<Paragraph>(srcNode);
                    if (para->get_IsEndOfSection() && !para->get_HasChildNodes())
                    {
                        continue;
                    }
                }

                SharedPtr<Node> newNode = importer->ImportNode(srcNode, true);

                destinationParent->InsertAfter(newNode, insertionDestination);
                insertionDestination = newNode;
            }
        }
    }
    else
    {
        throw System::ArgumentException(u"The destination node should be either a paragraph or table.");
    }
}
```

