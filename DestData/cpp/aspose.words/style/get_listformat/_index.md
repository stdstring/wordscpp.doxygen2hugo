---
title: get_ListFormat
second_title: Aspose.Words for C++ API Reference
description: Provides access to the list formatting properties of a paragraph style.
type: docs
weight: 131
url: /cpp/aspose.words/style/get_listformat/
---
## Style::get_ListFormat method


Provides access to the list formatting properties of a paragraph style.

```cpp
System::SharedPtr<Aspose::Words::Lists::ListFormat> Aspose::Words::Style::get_ListFormat()
```

## Remarks


This property is only valid for paragraph styles. For other style types this property returns null.

## Examples



Shows how to create and use a paragraph style with list formatting. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Create a custom paragraph style.
SharedPtr<Style> style = doc->get_Styles()->Add(StyleType::Paragraph, u"MyStyle1");
style->get_Font()->set_Size(24);
style->get_Font()->set_Name(u"Verdana");
style->get_ParagraphFormat()->set_SpaceAfter(12);

// Create a list and make sure the paragraphs that use this style will use this list.
style->get_ListFormat()->set_List(doc->get_Lists()->Add(ListTemplate::BulletDefault));
style->get_ListFormat()->set_ListLevelNumber(0);

// Apply the paragraph style to the document builder's current paragraph, and then add some text.
builder->get_ParagraphFormat()->set_Style(style);
builder->Writeln(u"Hello World: MyStyle1, bulleted list.");

// Change the document builder's style to one that has no list formatting and write another paragraph.
builder->get_ParagraphFormat()->set_Style(doc->get_Styles()->idx_get(u"Normal"));
builder->Writeln(u"Hello World: Normal.");

builder->get_Document()->Save(ArtifactsDir + u"Styles.ParagraphStyleBulletedList.docx");
```

## See Also

* Class [ListFormat](../../../aspose.words.lists/listformat/)
* Class [Style](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words](../../../)
