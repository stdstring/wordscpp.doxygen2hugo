---
title: Aspose::Words::Fields::FieldHyperlink::get_IsImageMap method
linktitle: get_IsImageMap
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Fields::FieldHyperlink::get_IsImageMap method. Gets or sets whether to append coordinates to the hyperlink for a server-side image map in C++.'
type: docs
weight: 200
url: /cpp/aspose.words.fields/fieldhyperlink/get_isimagemap/
---
## FieldHyperlink::get_IsImageMap method


Gets or sets whether to append coordinates to the hyperlink for a server-side image map.

```cpp
bool Aspose::Words::Fields::FieldHyperlink::get_IsImageMap()
```


## Examples



Shows how to use HYPERLINK fields to link to documents in the local file system. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

auto field = System::DynamicCast<FieldHyperlink>(builder->InsertField(FieldType::FieldHyperlink, true));

// When we click this HYPERLINK field in Microsoft Word,
// it will open the linked document and then place the cursor at the specified bookmark.
field->set_Address(MyDir + u"Bookmarks.docx");
field->set_SubAddress(u"MyBookmark3");
field->set_ScreenTip(String(u"Open ") + field->get_Address() + u" on bookmark " + field->get_SubAddress() + u" in a new window");

builder->Writeln();

// When we click this HYPERLINK field in Microsoft Word,
// it will open the linked document, and automatically scroll down to the specified iframe.
field = System::DynamicCast<FieldHyperlink>(builder->InsertField(FieldType::FieldHyperlink, true));
field->set_Address(MyDir + u"Iframes.html");
field->set_ScreenTip(String(u"Open ") + field->get_Address());
field->set_Target(u"iframe_3");
field->set_OpenInNewWindow(true);
field->set_IsImageMap(false);

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.HYPERLINK.docx");
```

## See Also

* Class [FieldHyperlink](../)
* Namespace [Aspose::Words::Fields](../../)
* Library [Aspose.Words for C++](../../../)
