---
title: Clone
second_title: Aspose.Words for C++ API Reference
description: Makes a deep clone of this object. 
type: docs
weight: 66
url: /cpp/aspose.words.markup/customxmlschemacollection/clone/
---
## CustomXmlSchemaCollection.Clone method


Makes a deep clone of this object.

```cpp
System::SharedPtr<Aspose::Words::Markup::CustomXmlSchemaCollection> Aspose::Words::Markup::CustomXmlSchemaCollection::Clone()
```


## Examples




Shows how to work with an XML schema collection. 
```cpp
auto doc = MakeObject<Document>();

String xmlPartId = System::Guid::NewGuid().ToString(u"B");
String xmlPartContent = u"<root><text>Hello, World!</text></root>";
SharedPtr<CustomXmlPart> xmlPart = doc->get_CustomXmlParts()->Add(xmlPartId, xmlPartContent);

// Add an XML schema association.
xmlPart->get_Schemas()->Add(u"http://www.w3.org/2001/XMLSchema");

// Clone the custom XML part's XML schema association collection,
// and then add a couple of new schemas to the clone.
SharedPtr<CustomXmlSchemaCollection> schemas = xmlPart->get_Schemas()->Clone();
schemas->Add(u"http://www.w3.org/2001/XMLSchema-instance");
schemas->Add(u"http://schemas.microsoft.com/office/2006/metadata/contentType");

ASSERT_EQ(3, schemas->get_Count());
ASSERT_EQ(2, schemas->IndexOf(u"http://schemas.microsoft.com/office/2006/metadata/contentType"));

// Enumerate the schemas and print each element.
{
    SharedPtr<System::Collections::Generic::IEnumerator<String>> enumerator = schemas->GetEnumerator();
    while (enumerator->MoveNext())
    {
        std::cout << enumerator->get_Current() << std::endl;
    }
}

// Below are three ways of removing schemas from the collection.
// 1 -  Remove a schema by index:
schemas->RemoveAt(2);

// 2 -  Remove a schema by value:
schemas->Remove(u"http://www.w3.org/2001/XMLSchema");

// 3 -  Use the "Clear" method to empty the collection at once.
schemas->Clear();

ASSERT_EQ(0, schemas->get_Count());
```

