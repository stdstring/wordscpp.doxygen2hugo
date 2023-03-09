---
title: Aspose::Words::Markup::XmlMapping::get_XPath method
linktitle: get_XPath
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Markup::XmlMapping::get_XPath method. Returns the XPath expression, which is evaluated to find the custom XML node that is mapped to the parent structured document tag in C++.
type: docs
weight: 66
url: /cpp/aspose.words.markup/xmlmapping/get_xpath/
---
## XmlMapping::get_XPath method


Returns the XPath expression, which is evaluated to find the custom XML node that is mapped to the parent structured document tag.

```cpp
System::String Aspose::Words::Markup::XmlMapping::get_XPath() const
```


## Examples



Shows how to set XML mappings for custom XML parts. 
```cpp
auto doc = MakeObject<Document>();

// Construct an XML part that contains text and add it to the document's CustomXmlPart collection.
String xmlPartId = System::Guid::NewGuid().ToString(u"B");
String xmlPartContent = u"<root><text>Text element #1</text><text>Text element #2</text></root>";
SharedPtr<CustomXmlPart> xmlPart = doc->get_CustomXmlParts()->Add(xmlPartId, xmlPartContent);

ASSERT_EQ(u"<root><text>Text element #1</text><text>Text element #2</text></root>", System::Text::Encoding::get_UTF8()->GetString(xmlPart->get_Data()));

// Create a structured document tag that will display the contents of our CustomXmlPart.
auto tag = MakeObject<StructuredDocumentTag>(doc, SdtType::PlainText, MarkupLevel::Block);

// Set a mapping for our structured document tag. This mapping will instruct
// our structured document tag to display a portion of the XML part's text contents that the XPath points to.
// In this case, it will be contents of the the second "<text>" element of the first "<root>" element: "Text element #2".
tag->get_XmlMapping()->SetMapping(xmlPart, u"/root[1]/text[2]", u"xmlns:ns='http://www.w3.org/2001/XMLSchema'");

ASSERT_TRUE(tag->get_XmlMapping()->get_IsMapped());
ASPOSE_ASSERT_EQ(xmlPart, tag->get_XmlMapping()->get_CustomXmlPart());
ASSERT_EQ(u"/root[1]/text[2]", tag->get_XmlMapping()->get_XPath());
ASSERT_EQ(u"xmlns:ns='http://www.w3.org/2001/XMLSchema'", tag->get_XmlMapping()->get_PrefixMappings());

// Add the structured document tag to the document to display the content from our custom part.
doc->get_FirstSection()->get_Body()->AppendChild(tag);
doc->Save(ArtifactsDir + u"StructuredDocumentTag.XmlMapping.docx");
```

## See Also

* Class [XmlMapping](../)
* Namespace [Aspose::Words::Markup](../../)
* Library [Aspose.Words for C++](../../../)
