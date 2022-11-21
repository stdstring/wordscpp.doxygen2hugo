---
title: GetText
second_title: Aspose.Words for C++ API Reference
description: Gets the text of the run.
type: docs
weight: 53
url: /cpp/aspose.words/run/gettext/
---
## Run::GetText method


Gets the text of the run.

```cpp
System::String Aspose::Words::Run::GetText() override
```


### ReturnValue

The text of the run.

## Examples




Shows how to print the node structure of every header and footer in a document. 
```cpp
void HeaderFooterToText()
{
    auto doc = MakeObject<Document>(MyDir + u"DocumentVisitor-compatible features.docx");
    auto visitor = MakeObject<ExDocumentVisitor::HeaderFooterStructurePrinter>();

    // When we get a composite node to accept a document visitor, the visitor visits the accepting node,
    // and then traverses all the node's children in a depth-first manner.
    // The visitor can read and modify each visited node.
    doc->Accept(visitor);

    std::cout << visitor->GetText() << std::endl;

    // An alternative way of accessing a document's header/footers section-by-section is by accessing the collection.
    ArrayPtr<SharedPtr<HeaderFooter>> headerFooters = doc->get_FirstSection()->get_HeadersFooters()->ToArray();
    ASSERT_EQ(3, headerFooters->get_Length());
}

class HeaderFooterStructurePrinter : public DocumentVisitor
{
public:
    HeaderFooterStructurePrinter() : mVisitorIsInsideHeaderFooter(false), mDocTraversalDepth(0)
    {
        mBuilder = MakeObject<System::Text::StringBuilder>();
        mVisitorIsInsideHeaderFooter = false;
    }

    String GetText()
    {
        return mBuilder->ToString();
    }

    VisitorAction VisitRun(SharedPtr<Run> run) override
    {
        if (mVisitorIsInsideHeaderFooter)
        {
            IndentAndAppendLine(String(u"[Run] \"") + run->GetText() + u"\"");
        }

        return VisitorAction::Continue;
    }

    VisitorAction VisitHeaderFooterStart(SharedPtr<HeaderFooter> headerFooter) override
    {
        IndentAndAppendLine(String(u"[HeaderFooter start] HeaderFooterType: ") + System::ObjectExt::ToString(headerFooter->get_HeaderFooterType()));
        mDocTraversalDepth++;
        mVisitorIsInsideHeaderFooter = true;

        return VisitorAction::Continue;
    }

    VisitorAction VisitHeaderFooterEnd(SharedPtr<HeaderFooter> headerFooter) override
    {
        mDocTraversalDepth--;
        IndentAndAppendLine(u"[HeaderFooter end]");
        mVisitorIsInsideHeaderFooter = false;

        return VisitorAction::Continue;
    }

private:
    bool mVisitorIsInsideHeaderFooter;
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

