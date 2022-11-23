---
title: Accept
second_title: Aspose.Words for C++ API Reference
description: Accepts a visitor.
type: docs
weight: 14
url: /cpp/aspose.words.markup/smarttag/accept/
---
## SmartTag::Accept method


Accepts a visitor.

```cpp
bool Aspose::Words::Markup::SmartTag::Accept(System::SharedPtr<Aspose::Words::DocumentVisitor> visitor) override
```


| Parameter | Type | Description |
| --- | --- | --- |
| visitor | System::SharedPtr\<Aspose::Words::DocumentVisitor\> | The visitor that will visit the nodes. |

### ReturnValue

True if all nodes were visited; false if [DocumentVisitor](../../../aspose.words/documentvisitor/) stopped the operation before visiting all nodes.

Enumerates over this node and all of its children. Each node calls a corresponding method on [DocumentVisitor](../../../aspose.words/documentvisitor/).

For more info see the Visitor design pattern.

## Examples



Shows how to create smart tags. 
```cpp
void Create()
{
    auto doc = MakeObject<Document>();

    // A smart tag appears in a document with Microsoft Word recognizes a part of its text as some form of data,
    // such as a name, date, or address, and converts it to a hyperlink that displays a purple dotted underline.
    auto smartTag = MakeObject<SmartTag>(doc);

    // Smart tags are composite nodes that contain their recognized text in its entirety.
    // Add contents to this smart tag manually.
    smartTag->AppendChild(MakeObject<Run>(doc, u"May 29, 2019"));

    // Microsoft Word may recognize the above contents as being a date.
    // Smart tags use the "Element" property to reflect the type of data they contain.
    smartTag->set_Element(u"date");

    // Some smart tag types process their contents further into custom XML properties.
    smartTag->get_Properties()->Add(MakeObject<CustomXmlProperty>(u"Day", String::Empty, u"29"));
    smartTag->get_Properties()->Add(MakeObject<CustomXmlProperty>(u"Month", String::Empty, u"5"));
    smartTag->get_Properties()->Add(MakeObject<CustomXmlProperty>(u"Year", String::Empty, u"2019"));

    // Set the smart tag's URI to the default value.
    smartTag->set_Uri(u"urn:schemas-microsoft-com:office:smarttags");

    doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(smartTag);
    doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(MakeObject<Run>(doc, u" is a date. "));

    // Create another smart tag for a stock ticker.
    smartTag = MakeObject<SmartTag>(doc);
    smartTag->set_Element(u"stockticker");
    smartTag->set_Uri(u"urn:schemas-microsoft-com:office:smarttags");

    smartTag->AppendChild(MakeObject<Run>(doc, u"MSFT"));

    doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(smartTag);
    doc->get_FirstSection()->get_Body()->get_FirstParagraph()->AppendChild(MakeObject<Run>(doc, u" is a stock ticker."));

    // Print all the smart tags in our document using a document visitor.
    doc->Accept(MakeObject<ExSmartTag::SmartTagPrinter>());

    // Older versions of Microsoft Word support smart tags.
    doc->Save(ArtifactsDir + u"SmartTag.Create.doc");

    // Use the "RemoveSmartTags" method to remove all smart tags from a document.
    ASSERT_EQ(2, doc->GetChildNodes(NodeType::SmartTag, true)->get_Count());

    doc->RemoveSmartTags();

    ASSERT_EQ(0, doc->GetChildNodes(NodeType::SmartTag, true)->get_Count());
}

class SmartTagPrinter : public DocumentVisitor
{
public:
    VisitorAction VisitSmartTagStart(SharedPtr<SmartTag> smartTag) override
    {
        std::cout << "Smart tag type: " << smartTag->get_Element() << std::endl;
        return VisitorAction::Continue;
    }

    VisitorAction VisitSmartTagEnd(SharedPtr<SmartTag> smartTag) override
    {
        std::cout << "\tContents: \"" << smartTag->ToString(SaveFormat::Text) << "\"" << std::endl;

        if (smartTag->get_Properties()->get_Count() == 0)
        {
            std::cout << "\tContains no properties" << std::endl;
        }
        else
        {
            std::cout << "\tProperties: ";
            auto properties = MakeArray<String>(smartTag->get_Properties()->get_Count());
            int index = 0;

            for (const auto& cxp : System::IterateOver(smartTag->get_Properties()))
            {
                properties[index++] = String::Format(u"\"{0}\" = \"{1}\"", cxp->get_Name(), cxp->get_Value());
            }

            std::cout << String::Join(u", ", properties) << std::endl;
        }

        return VisitorAction::Continue;
    }
};
```

