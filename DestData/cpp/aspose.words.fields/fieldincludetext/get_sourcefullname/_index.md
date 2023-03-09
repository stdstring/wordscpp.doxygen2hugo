---
title: Aspose::Words::Fields::FieldIncludeText::get_SourceFullName method
linktitle: get_SourceFullName
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Fields::FieldIncludeText::get_SourceFullName method. Gets or sets the location of the document using an IRI in C++.
type: docs
weight: 66
url: /cpp/aspose.words.fields/fieldincludetext/get_sourcefullname/
---
## FieldIncludeText::get_SourceFullName method


Gets or sets the location of the document using an IRI.

```cpp
System::String Aspose::Words::Fields::FieldIncludeText::get_SourceFullName() override
```


## Examples



Shows how to create an INCLUDETEXT field, and set its properties. 
```cpp
void FieldIncludeText_()
{
    auto doc = MakeObject<Document>();
    auto builder = MakeObject<DocumentBuilder>(doc);

    // Below are two ways to use INCLUDETEXT fields to display the contents of an XML file in the local file system.
    // 1 -  Perform an XSL transformation on an XML document:
    SharedPtr<FieldIncludeText> fieldIncludeText =
        CreateFieldIncludeText(builder, MyDir + u"CD collection data.xml", false, u"text/xml", u"XML", u"ISO-8859-1");
    fieldIncludeText->set_XslTransformation(MyDir + u"CD collection XSL transformation.xsl");

    builder->Writeln();

    // 2 -  Use an XPath to take specific elements from an XML document:
    fieldIncludeText = CreateFieldIncludeText(builder, MyDir + u"CD collection data.xml", false, u"text/xml", u"XML", u"ISO-8859-1");
    fieldIncludeText->set_NamespaceMappings(u"xmlns:n='myNamespace'");
    fieldIncludeText->set_XPath(u"/catalog/cd/title");

    doc->Save(ArtifactsDir + u"Field.INCLUDETEXT.docx");
}

SharedPtr<FieldIncludeText> CreateFieldIncludeText(SharedPtr<DocumentBuilder> builder, String sourceFullName, bool lockFields, String mimeType,
                                                   String textConverter, String encoding)
{
    auto fieldIncludeText = System::DynamicCast<FieldIncludeText>(builder->InsertField(FieldType::FieldIncludeText, true));
    fieldIncludeText->set_SourceFullName(sourceFullName);
    fieldIncludeText->set_LockFields(lockFields);
    fieldIncludeText->set_MimeType(mimeType);
    fieldIncludeText->set_TextConverter(textConverter);
    fieldIncludeText->set_Encoding(encoding);

    return fieldIncludeText;
}
```

## See Also

* Class [FieldIncludeText](../)
* Namespace [Aspose::Words::Fields](../../)
* Library [Aspose.Words for C++](../../../)
