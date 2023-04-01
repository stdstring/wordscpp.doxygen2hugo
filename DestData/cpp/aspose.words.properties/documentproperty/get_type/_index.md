---
title: Aspose::Words::Properties::DocumentProperty::get_Type method
linktitle: get_Type
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Properties::DocumentProperty::get_Type method. Gets the data type of the property in C++.'
type: docs
weight: 400
url: /cpp/aspose.words.properties/documentproperty/get_type/
---
## DocumentProperty::get_Type method


Gets the data type of the property.

```cpp
Aspose::Words::Properties::PropertyType Aspose::Words::Properties::DocumentProperty::get_Type() const
```


## Examples



Shows how to work with built-in document properties. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Properties.docx");

// The "Document" object contains some of its metadata in its members.
std::cout << "Document filename:\n\t \"" << doc->get_OriginalFileName() << "\"" << std::endl;

// The document also stores metadata in its built-in properties.
// Each built-in property is a member of the document's "BuiltInDocumentProperties" object.
std::cout << "Built-in Properties:" << std::endl;
for (const auto& docProperty : System::IterateOver(doc->get_BuiltInDocumentProperties()))
{
    std::cout << docProperty->get_Name() << std::endl;
    std::cout << String::Format(u"\tType:\t{0}", docProperty->get_Type()) << std::endl;

    // Some properties may store multiple values.
    if (System::ObjectExt::Is<System::Collections::Generic::ICollection<SharedPtr<System::Object>>>(docProperty->get_Value()))
    {
        for (const auto& value : System::IterateOver(
                 System::DynamicCast_noexcept<System::Collections::Generic::ICollection<SharedPtr<System::Object>>>(docProperty->get_Value())))
        {
            std::cout << "\tValue:\t\"" << value << "\"" << std::endl;
        }
    }
    else
    {
        std::cout << "\tValue:\t\"" << docProperty->get_Value() << "\"" << std::endl;
    }
}
```


Shows how to work with a document's custom properties. 
```cpp
auto doc = MakeObject<Document>();
SharedPtr<CustomDocumentProperties> properties = doc->get_CustomDocumentProperties();

ASSERT_EQ(0, properties->get_Count());

// Custom document properties are key-value pairs that we can add to the document.
properties->Add(u"Authorized", true);
properties->Add(u"Authorized By", String(u"John Doe"));
properties->Add(u"Authorized Date", System::DateTime::get_Today());
properties->Add(u"Authorized Revision", doc->get_BuiltInDocumentProperties()->get_RevisionNumber());
properties->Add(u"Authorized Amount", 123.45);

// The collection sorts the custom properties in alphabetic order.
ASSERT_EQ(1, properties->IndexOf(u"Authorized Amount"));
ASSERT_EQ(5, properties->get_Count());

// Print every custom property in the document.
{
    SharedPtr<System::Collections::Generic::IEnumerator<SharedPtr<DocumentProperty>>> enumerator = properties->GetEnumerator();
    while (enumerator->MoveNext())
    {
        std::cout << String::Format(u"Name: \"{0}\"\n\tType: \"{1}\"\n\tValue: \"{2}\"", enumerator->get_Current()->get_Name(),
                                    enumerator->get_Current()->get_Type(), enumerator->get_Current()->get_Value())
                  << std::endl;
    }
}

// Display the value of a custom property using a DOCPROPERTY field.
auto builder = MakeObject<DocumentBuilder>(doc);
auto field = System::DynamicCast<FieldDocProperty>(builder->InsertField(u" DOCPROPERTY \"Authorized By\""));
field->Update();

ASSERT_EQ(u"John Doe", field->get_Result());

// We can find these custom properties in Microsoft Word via "File" -> "Properties" > "Advanced Properties" > "Custom".
doc->Save(ArtifactsDir + u"DocumentProperties.DocumentPropertyCollection.docx");

// Below are three ways or removing custom properties from a document.
// 1 -  Remove by index:
properties->RemoveAt(1);

ASSERT_FALSE(properties->Contains(u"Authorized Amount"));
ASSERT_EQ(4, properties->get_Count());

// 2 -  Remove by name:
properties->Remove(u"Authorized Revision");

ASSERT_FALSE(properties->Contains(u"Authorized Revision"));
ASSERT_EQ(3, properties->get_Count());

// 3 -  Empty the entire collection at once:
properties->Clear();

ASSERT_EQ(0, properties->get_Count());
```

## See Also

* Enum [PropertyType](../../propertytype/)
* Class [DocumentProperty](../)
* Namespace [Aspose::Words::Properties](../../)
* Library [Aspose.Words for C++](../../../)
