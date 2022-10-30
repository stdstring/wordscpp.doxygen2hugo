---
title: idx_get
second_title: Aspose.Words for C++ API Reference
description: Retrieves a building block at the given index.
type: docs
weight: 1
url: /cpp/aspose.words.buildingblocks/buildingblockcollection/idx_get/
---
## BuildingBlockCollection::idx_get method


Retrieves a building block at the given index.

```cpp
System::SharedPtr<Aspose::Words::BuildingBlocks::BuildingBlock> Aspose::Words::BuildingBlocks::BuildingBlockCollection::idx_get(int32_t index)
```


| Parameter | Type | Description |
| --- | --- | --- |
| index | int32_t | An index into the list of building blocks. |

The index is zero-based.

Negative indexes are allowed and indicate access from the back of the collection. For example -1 means the last item, -2 means the second before last and so on.

If index is greater than or equal to the number of items in the list, this returns a null reference.

If index is negative and its absolute value is greater than the number of items in the list, this returns a null reference.

## Examples




Shows ways of accessing building blocks in a glossary document. 
```cpp
void GlossaryDocument_()
{
    auto doc = MakeObject<Document>();
    auto glossaryDoc = MakeObject<GlossaryDocument>();

    for (int i = 1; i <= 5; ++i)
    {
        auto block = MakeObject<BuildingBlock>(glossaryDoc);
        block->set_Name(String(u"Block ") + System::Convert::ToString(i));
        glossaryDoc->AppendChild(block);
    }
    ASSERT_EQ(5, glossaryDoc->get_BuildingBlocks()->get_Count());

    doc->set_GlossaryDocument(glossaryDoc);

    // There are various ways of accessing building blocks.
    // 1 -  Get the first/last building blocks in the collection:
    ASSERT_EQ(u"Block 1", glossaryDoc->get_FirstBuildingBlock()->get_Name());
    ASSERT_EQ(u"Block 5", glossaryDoc->get_LastBuildingBlock()->get_Name());

    // 2 -  Get a building block by index:
    ASSERT_EQ(u"Block 2", glossaryDoc->get_BuildingBlocks()->idx_get(1)->get_Name());
    ASSERT_EQ(u"Block 3", glossaryDoc->get_BuildingBlocks()->ToArray()->idx_get(2)->get_Name());

    // 3 -  Get the first building block that matches a gallery, name and category:
    ASSERT_EQ(u"Block 4", glossaryDoc->GetBuildingBlock(BuildingBlockGallery::All, u"(Empty Category)", u"Block 4")->get_Name());

    // We will do that using a custom visitor,
    // which will give every BuildingBlock in the GlossaryDocument a unique GUID
    auto visitor = MakeObject<ExBuildingBlocks::GlossaryDocVisitor>();
    glossaryDoc->Accept(visitor);

    std::cout << visitor->GetText() << std::endl;

    // In Microsoft Word, we can access the building blocks via "Insert" -> "Quick Parts" -> "Building Blocks Organizer".
    doc->Save(ArtifactsDir + u"BuildingBlocks.GlossaryDocument.dotx");
}

class GlossaryDocVisitor : public DocumentVisitor
{
public:
    GlossaryDocVisitor()
    {
        mBlocksByGuid = MakeObject<System::Collections::Generic::Dictionary<System::Guid, SharedPtr<BuildingBlock>>>();
        mBuilder = MakeObject<System::Text::StringBuilder>();
    }

    String GetText()
    {
        return mBuilder->ToString();
    }

    SharedPtr<System::Collections::Generic::Dictionary<System::Guid, SharedPtr<BuildingBlock>>> GetDictionary()
    {
        return mBlocksByGuid;
    }

    VisitorAction VisitGlossaryDocumentStart(SharedPtr<GlossaryDocument> glossary) override
    {
        mBuilder->AppendLine(u"Glossary document found!");
        return VisitorAction::Continue;
    }

    VisitorAction VisitGlossaryDocumentEnd(SharedPtr<GlossaryDocument> glossary) override
    {
        mBuilder->AppendLine(u"Reached end of glossary!");
        mBuilder->AppendLine(String(u"BuildingBlocks found: ") + mBlocksByGuid->get_Count());
        return VisitorAction::Continue;
    }

    VisitorAction VisitBuildingBlockStart(SharedPtr<BuildingBlock> block) override
    {
        block->set_Guid(System::Guid::NewGuid());
        mBlocksByGuid->Add(block->get_Guid(), block);
        return VisitorAction::Continue;
    }

    VisitorAction VisitBuildingBlockEnd(SharedPtr<BuildingBlock> block) override
    {
        mBuilder->AppendLine(String(u"\tVisited block \"") + block->get_Name() + u"\"");
        mBuilder->AppendLine(String(u"\t Type: ") + System::ObjectExt::ToString(block->get_Type()));
        mBuilder->AppendLine(String(u"\t Gallery: ") + System::ObjectExt::ToString(block->get_Gallery()));
        mBuilder->AppendLine(String(u"\t Behavior: ") + System::ObjectExt::ToString(block->get_Behavior()));
        mBuilder->AppendLine(String(u"\t Description: ") + block->get_Description());

        return VisitorAction::Continue;
    }

private:
    SharedPtr<System::Collections::Generic::Dictionary<System::Guid, SharedPtr<BuildingBlock>>> mBlocksByGuid;
    SharedPtr<System::Text::StringBuilder> mBuilder;
};
```

