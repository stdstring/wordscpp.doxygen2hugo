---
title: Accept
second_title: Aspose.Words for C++ API Reference
description: Accepts a visitor. 
type: docs
weight: 14
url: /cpp/aspose.words.markup/structureddocumenttagrangeend/accept/
---
## StructuredDocumentTagRangeEnd.Accept method


Accepts a visitor.

```cpp
bool Aspose::Words::Markup::StructuredDocumentTagRangeEnd::Accept(System::SharedPtr<Aspose::Words::DocumentVisitor> visitor) override
```


| Parameter | Type | Description |
| --- | --- | --- |
| visitor | System::SharedPtr\<Aspose::Words::DocumentVisitor\> | The visitor that will visit the nodes. |

### ReturnValue


True if all nodes were visited; false if [DocumentVisitor](../../../aspose.words/documentvisitor/) stopped the operation before visiting all nodes.

Enumerates over this node and all of its children. Each node calls a corresponding method on [DocumentVisitor](../../../aspose.words/documentvisitor/).

For more info see the Visitor design pattern.

## Examples




Shows how to use a [DocumentVisitor](../../../aspose.words/documentvisitor/) implementation to remove all hidden content from a document. 
```cpp
void RemoveHiddenContentFromDocument()
{
    auto doc = MakeObject<Document>(MyDir + u"Hidden content.docx");

    auto hiddenContentRemover = MakeObject<ExFont::RemoveHiddenContentVisitor>();

    // Below are three types of fields which can accept a document visitor,
    // which will allow it to visit the accepting node, and then traverse its child nodes in a depth-first manner.
    // 1 -  Paragraph node:
    auto para = System::DynamicCast<Paragraph>(doc->GetChild(NodeType::Paragraph, 4, true));
    para->Accept(hiddenContentRemover);

    // 2 -  Table node:
    SharedPtr<Table> table = doc->get_FirstSection()->get_Body()->get_Tables()->idx_get(0);
    table->Accept(hiddenContentRemover);

    // 3 -  Document node:
    doc->Accept(hiddenContentRemover);

    doc->Save(ArtifactsDir + u"Font.RemoveHiddenContentFromDocument.docx");
}

class RemoveHiddenContentVisitor : public DocumentVisitor
{
public:
    VisitorAction VisitFieldStart(SharedPtr<FieldStart> fieldStart) override
    {
        if (fieldStart->get_Font()->get_Hidden())
        {
            fieldStart->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitFieldEnd(SharedPtr<FieldEnd> fieldEnd) override
    {
        if (fieldEnd->get_Font()->get_Hidden())
        {
            fieldEnd->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitFieldSeparator(SharedPtr<FieldSeparator> fieldSeparator) override
    {
        if (fieldSeparator->get_Font()->get_Hidden())
        {
            fieldSeparator->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitRun(SharedPtr<Run> run) override
    {
        if (run->get_Font()->get_Hidden())
        {
            run->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitParagraphStart(SharedPtr<Paragraph> paragraph) override
    {
        if (paragraph->get_ParagraphBreakFont()->get_Hidden())
        {
            paragraph->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitFormField(SharedPtr<FormField> formField) override
    {
        if (formField->get_Font()->get_Hidden())
        {
            formField->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitGroupShapeStart(SharedPtr<GroupShape> groupShape) override
    {
        if (groupShape->get_Font()->get_Hidden())
        {
            groupShape->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitShapeStart(SharedPtr<Shape> shape) override
    {
        if (shape->get_Font()->get_Hidden())
        {
            shape->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitCommentStart(SharedPtr<Comment> comment) override
    {
        if (comment->get_Font()->get_Hidden())
        {
            comment->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitFootnoteStart(SharedPtr<Footnote> footnote) override
    {
        if (footnote->get_Font()->get_Hidden())
        {
            footnote->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitSpecialChar(SharedPtr<SpecialChar> specialChar) override
    {
        if (specialChar->get_Font()->get_Hidden())
        {
            specialChar->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitTableEnd(SharedPtr<Table> table) override
    {
        // The content inside table cells may have the hidden content flag, but the tables themselves cannot.
        // If this table had nothing but hidden content, this visitor would have removed all of it,
        // and there would be no child nodes left.
        // Thus, we can also treat the table itself as hidden content and remove it.
        // Tables which are empty but do not have hidden content will have cells with empty paragraphs inside,
        // which this visitor will not remove.
        if (!table->get_HasChildNodes())
        {
            table->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitCellEnd(SharedPtr<Cell> cell) override
    {
        if (!cell->get_HasChildNodes() && cell->get_ParentNode() != nullptr)
        {
            cell->Remove();
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitRowEnd(SharedPtr<Row> row) override
    {
        if (!row->get_HasChildNodes() && row->get_ParentNode() != nullptr)
        {
            row->Remove();
        }

        return VisitorAction::Continue;
    }
};
```

