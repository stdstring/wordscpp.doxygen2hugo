---
title: Aspose::Words::DocumentBase::get_NodeChangingCallback method
linktitle: get_NodeChangingCallback
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::DocumentBase::get_NodeChangingCallback method. Called when a node is inserted or removed in the document in C++.
type: docs
weight: 500
url: /cpp/aspose.words/documentbase/get_nodechangingcallback/
---
## DocumentBase::get_NodeChangingCallback method


Called when a node is inserted or removed in the document.

```cpp
System::SharedPtr<Aspose::Words::INodeChangingCallback> Aspose::Words::DocumentBase::get_NodeChangingCallback()
```


## Examples



Shows how customize node changing with a callback. 
```cpp
void FontChangeViaCallback()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    // Set the node changing callback to custom implementation,
    // then add/remove nodes to get it to generate a log.
    auto callback = MakeObject<ExDocument::HandleNodeChangingFontChanger>();
    doc->set_NodeChangingCallback(callback);

    builder->Writeln(u"Hello world!");
    builder->Writeln(u"Hello again!");
    builder->InsertField(u" HYPERLINK \"https://www.google.com/\" ");
    builder->InsertShape(ShapeType::Rectangle, 300, 300);

    doc->get_Range()->get_Fields()->idx_get(0)->Remove();

    std::cout << callback->GetLog() << std::endl;
}

class HandleNodeChangingFontChanger : public INodeChangingCallback
{
public:
    String GetLog()
    {
        return mLog->ToString();
    }

    HandleNodeChangingFontChanger() : mLog(MakeObject<System::Text::StringBuilder>())
    {
    }

private:
    SharedPtr<System::Text::StringBuilder> mLog;

    void NodeInserted(SharedPtr<NodeChangingArgs> args) override
    {
        mLog->AppendLine(String::Format(u"\tType:\t{0}", args->get_Node()->get_NodeType()));
        mLog->AppendLine(String::Format(u"\tHash:\t{0}", System::ObjectExt::GetHashCode(args->get_Node())));

        if (args->get_Node()->get_NodeType() == NodeType::Run)
        {
            SharedPtr<Aspose::Words::Font> font = (System::DynamicCast<Run>(args->get_Node()))->get_Font();
            mLog->Append(String::Format(u"\tFont:\tChanged from \"{0}\" {1}pt", font->get_Name(), font->get_Size()));

            font->set_Size(24);
            font->set_Name(u"Arial");

            mLog->AppendLine(String::Format(u" to \"{0}\" {1}pt", font->get_Name(), font->get_Size()));
            mLog->AppendLine(String::Format(u"\tContents:\n\t\t\"{0}\"", args->get_Node()->GetText()));
        }
    }

    void NodeInserting(SharedPtr<NodeChangingArgs> args) override
    {
        mLog->AppendLine(String::Format(u"\n{0:dd/MM/yyyy HH:mm:ss:fff}\tNode insertion:", System::DateTime::get_Now()));
    }

    void NodeRemoved(SharedPtr<NodeChangingArgs> args) override
    {
        mLog->AppendLine(String::Format(u"\tType:\t{0}", args->get_Node()->get_NodeType()));
        mLog->AppendLine(String::Format(u"\tHash code:\t{0}", System::ObjectExt::GetHashCode(args->get_Node())));
    }

    void NodeRemoving(SharedPtr<NodeChangingArgs> args) override
    {
        mLog->AppendLine(String::Format(u"\n{0:dd/MM/yyyy HH:mm:ss:fff}\tNode removal:", System::DateTime::get_Now()));
    }
};
```

## See Also

* Interface [INodeChangingCallback](../../inodechangingcallback/)
* Class [DocumentBase](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
