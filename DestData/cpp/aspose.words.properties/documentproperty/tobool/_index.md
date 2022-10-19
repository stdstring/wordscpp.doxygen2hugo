---
title: ToBool
second_title: Aspose.Words for C++ API Reference
description: Returns the property value as bool. 
type: docs
weight: 79
url: /cpp/aspose.words.properties/documentproperty/tobool/
---
## DocumentProperty.ToBool method


Returns the property value as bool.

```cpp
bool Aspose::Words::Properties::DocumentProperty::ToBool()
```


Throws an exception if the property type is not **Boolean**.

## Examples




Shows various type conversion methods of custom document properties. 
```cpp
auto doc = MakeObject<Document>();
SharedPtr<CustomDocumentProperties> properties = doc->get_CustomDocumentProperties();

System::DateTime authDate = System::DateTime::get_Today();
properties->Add(u"Authorized", true);
properties->Add(u"Authorized By", String(u"John Doe"));
properties->Add(u"Authorized Date", authDate);
properties->Add(u"Authorized Revision", doc->get_BuiltInDocumentProperties()->get_RevisionNumber());
properties->Add(u"Authorized Amount", 123.45);

ASPOSE_ASSERT_EQ(true, properties->idx_get(u"Authorized")->ToBool());
ASSERT_EQ(u"John Doe", System::ObjectExt::ToString(properties->idx_get(u"Authorized By")));
ASSERT_EQ(authDate, properties->idx_get(u"Authorized Date")->ToDateTime());
ASSERT_EQ(1, properties->idx_get(u"Authorized Revision")->ToInt());
ASPOSE_ASSERT_EQ(123.45, properties->idx_get(u"Authorized Amount")->ToDouble());
```

