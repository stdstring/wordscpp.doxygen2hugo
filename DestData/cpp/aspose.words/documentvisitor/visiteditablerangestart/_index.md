---
title: Aspose::Words::DocumentVisitor::VisitEditableRangeStart method
linktitle: VisitEditableRangeStart
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::DocumentVisitor::VisitEditableRangeStart method. Called when a start of an editable range is encountered in the document in C++.'
type: docs
weight: 1700
url: /cpp/aspose.words/documentvisitor/visiteditablerangestart/
---
## DocumentVisitor::VisitEditableRangeStart method


Called when a start of an editable range is encountered in the document.

```cpp
virtual Aspose::Words::VisitorAction Aspose::Words::DocumentVisitor::VisitEditableRangeStart(System::SharedPtr<Aspose::Words::EditableRangeStart> editableRangeStart)
```


| Parameter | Type | Description |
| --- | --- | --- |
| editableRangeStart | System::SharedPtr\<Aspose::Words::EditableRangeStart\> | The object that is being visited. |

### ReturnValue

A [VisitorAction](../../visitoraction/) value that specifies how to continue the enumeration.

## Examples



Shows how to print the node structure of every editable range in a document. 
```cpp
void EditableRangeToText()
{
    auto doc = MakeObject<Document>(MyDir + u"DocumentVisitor-compatible features.docx");
    auto visitor = MakeObject<ExDocumentVisitor::EditableRangeStructurePrinter>();

    // When we get a composite node to accept a document visitor, the visitor visits the accepting node,
    // and then traverses all the node's children in a depth-first manner.
    // The visitor can read and modify each visited node.
    doc->Accept(visitor);

    std::cout << visitor->GetText() << std::endl;
}

class EditableRangeStructurePrinter : public DocumentVisitor
{
public:
    EditableRangeStructurePrinter() : mVisitorIsInsideEditableRange(false), mDocTraversalDepth(0)
    {
        mBuilder = MakeObject<System::Text::StringBuilder>();
        mVisitorIsInsideEditableRange = false;
    }

    String GetText()
    {
        return mBuilder->ToString();
    }

    VisitorAction VisitRun(SharedPtr<Run> run) override
    {
        // We want to print the contents of runs, but only if they are inside shapes, as they would be in the case of text boxes
        if (mVisitorIsInsideEditableRange)
        {
            IndentAndAppendLine(String(u"[Run] \"") + run->GetText() + u"\"");
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitEditableRangeStart(SharedPtr<EditableRangeStart> editableRangeStart) override
    {
        IndentAndAppendLine(String(u"[EditableRange start] ID: ") + editableRangeStart->get_Id() + u" Owner: " +
                            editableRangeStart->get_EditableRange()->get_SingleUser());
        mDocTraversalDepth++;
        mVisitorIsInsideEditableRange = true;

        return VisitorAction::Continue;
    }

    VisitorAction VisitEditableRangeEnd(SharedPtr<EditableRangeEnd> editableRangeEnd) override
    {
        mDocTraversalDepth--;
        IndentAndAppendLine(u"[EditableRange end]");
        mVisitorIsInsideEditableRange = false;

        return VisitorAction::Continue;
    }

private:
    bool mVisitorIsInsideEditableRange;
    int mDocTraversalDepth;
    SharedPtr<System::Text::StringBuilder> mBuilder;

    void IndentAndAppendLine(String text)
    {
        for (int i = 0; i < mDocTraversalDepth; i++)
        {
            mBuilder->Append(u"|  ");
        }

        mBuilder->AppendLine(text);
    }
};
```

## See Also

* Enum [VisitorAction](../../visitoraction/)
* Class [EditableRangeStart](../../editablerangestart/)
* Class [DocumentVisitor](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
