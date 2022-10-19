---
title: BuildingBlockGallery
second_title: Aspose.Words for C++ API Reference
description: Specifies the predefined gallery into which a building block is classified. 
type: docs
weight: 53
url: /cpp/aspose.words.buildingblocks/buildingblockgallery/
---
## BuildingBlockGallery enum


Specifies the predefined gallery into which a building block is classified.

### Values

| Name | Value | Description |
| --- | --- | --- |
| All | `0` | Specifies that this glossary document entry shall be associated with all possible gallery classification values. |
| AutoText | `0` |  |
| Bibliography | `0` |  |
| CoverPage | `0` |  |
| CustomAutoText | `0` |  |
| CustomBibliography | `0` |  |
| CustomCoverPage | `0` |  |
| CustomEquations | `0` |  |
| CustomFooters | `0` |  |
| CustomHeaders | `0` |  |
| Custom1 | `0` |  |
| Custom2 | `0` |  |
| Custom3 | `0` |  |
| Custom4 | `0` |  |
| Custom5 | `0` |  |
| CustomPageNumber | `0` |  |
| CustomPageNumberAtBottom | `0` |  |
| CustomPageNumberAtMargin | `0` |  |
| CustomPageNumberAtTop | `0` |  |
| CustomQuickParts | `0` |  |
| CustomTableOfContents | `0` |  |
| CustomTables | `0` |  |
| CustomTextBox | `0` |  |
| CustomWatermarks | `0` |  |
| NoGallery | `0` |  |
| QuickParts | `0` |  |
| Equations | `0` |  |
| Footers | `0` |  |
| Headers | `0` |  |
| PageNumber | `0` |  |
| PageNumberAtBottom | `0` |  |
| PageNumberAtMargin | `0` |  |
| PageNumberAtTop | `0` |  |
| StructuredDocumentTagPlaceholderText | `0` |  |
| TableOfContents | `0` |  |
| Tables | `0` |  |
| TextBox | `0` |  |
| Watermarks | `0` |  |
| Default | `0` | Same as **All**. |


Corresponds to the **ST_DocPartGallery** type in OOXML.

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

