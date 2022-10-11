---
title: XmlMapping
second_title: Aspose.Words for C++ API Reference
description: Specifies the information that is used to establish a mapping between the parent structured document tag and an XML element stored within a custom XML data part in the document. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/xmlmapping/
---
## XmlMapping class


Specifies the information that is used to establish a mapping between the parent structured document tag and an XML element stored within a custom XML data part in the document. 

## Methods

| Method | Description |
| --- | --- |
| void [Delete](./delete/)() | Deletes mapping of the parent structured document to XML data.  |
| System::SharedPtr< Aspose::Words::Markup::CustomXmlPart > [get_CustomXmlPart](./get_customxmlpart/)() | Returns the custom XML data part to which the parent structured document tag is mapped.  |
| bool [get_IsMapped](./get_ismapped/)() | Returns **true** if the parent structured document tag is successfully mapped to XML data.  |
| System::String [get_PrefixMappings](./get_prefixmappings/)() const | Returns XML namespace prefix mappings to evaluate the XPath.  |
| System::String [get_StoreItemId](./get_storeitemid/)() | Specifies the custom XML data identifier for the custom XML data part which shall be used to evaluate the XPath expression.  |
| System::String [get_XPath](./get_xpath/)() const | Returns the XPath expression, which is evaluated to find the custom XML node that is mapped to the parent structured document tag.  |
| bool [SetMapping](./setmapping/)(const System::SharedPtr< Aspose::Words::Markup::CustomXmlPart > &, const System::String &, const System::String &) | Sets a mapping between the parent structured document tag and an XML node of a custom XML data part.  |
