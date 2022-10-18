---
title: get_LastPrinted
second_title: Aspose.Words for C++ API Reference
description: Gets or sets the date when the document was last printed in UTC. 
type: docs
weight: 0
url: /cpp/aspose.words.properties/builtindocumentproperties/get_lastprinted/
---
## BuiltInDocumentProperties.get_LastPrinted method


Gets or sets the date when the document was last printed in UTC.

```cpp
System::DateTime Aspose::Words::Properties::BuiltInDocumentProperties::get_LastPrinted()
```


For documents originated from RTF format this property returns the local time of last print operation.

If the document was never printed, this property will return DateTime.MinValue.

Aspose.Words does not update this property.

## Examples




Shows how to work with document properties in the "Origin" category. 
```cpp
// Open a document that we have created and edited using Microsoft Word.
auto doc = MakeObject<Document>(MyDir + u"Properties.docx");
SharedPtr<BuiltInDocumentProperties> properties = doc->get_BuiltInDocumentProperties();

// The following built-in properties contain information regarding the creation and editing of this document.
// We can right-click this document in Windows Explorer and find
// these properties via "Properties" -> "Details" -> "Origin" category.
// Fields such as PRINTDATE and EDITTIME can display these values in the document body.
std::cout << "Created using " << properties->get_NameOfApplication() << ", on " << properties->get_CreatedTime() << std::endl;
std::cout << "Minutes spent editing: " << properties->get_TotalEditingTime() << std::endl;
std::cout << "Date/time last printed: " << properties->get_LastPrinted() << std::endl;
std::cout << "Template document: " << properties->get_Template() << std::endl;

// We can also change the values of built-in properties.
properties->set_Company(u"Doe Ltd.");
properties->set_Manager(u"Jane Doe");
properties->set_Version(5);
properties->set_RevisionNumber(properties->get_RevisionNumber() + 1);

// Microsoft Word updates the following properties automatically when we save the document.
// To use these properties with Aspose.Words, we will need to set values for them manually.
properties->set_LastSavedBy(u"John Doe");
properties->set_LastSavedTime(System::DateTime::get_Now());

// We can right-click this document in Windows Explorer and find these properties in "Properties" -> "Details" -> "Origin".
doc->Save(ArtifactsDir + u"DocumentProperties.Origin.docx");
```

