---
title: get_OleIcon
second_title: Aspose.Words for C++ API Reference
description: Gets the draw aspect of the OLE object. When true, the OLE object is displayed as an icon. When false, the OLE object is displayed as content. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/oleformat/get_oleicon/
---
## OleFormat.get_OleIcon method


Gets the draw aspect of the OLE object. When **true**, the OLE object is displayed as an icon. When **false**, the OLE object is displayed as content.

```cpp
bool Aspose::Words::Drawing::OleFormat::get_OleIcon()
```


Aspose.Words does not allow to set this property to avoid confusion. If you were able to change the draw aspect in Aspose.Words, Microsoft Word would still display the OLE object in its original draw aspect until you edit or update the OLE object in Microsoft Word.

## Examples




Shows how to insert linked and unlinked OLE objects. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Embed a Microsoft Visio drawing into the document as an OLE object.
builder->InsertOleObject(ImageDir + u"Microsoft Visio drawing.vsd", u"Package", false, false, nullptr);

// Insert a link to the file in the local file system and display it as an icon.
builder->InsertOleObject(ImageDir + u"Microsoft Visio drawing.vsd", u"Package", true, true, nullptr);

// Inserting OLE objects creates shapes that store these objects.
ArrayPtr<SharedPtr<Shape>> shapes = doc->GetChildNodes(NodeType::Shape, true)->LINQ_OfType<SharedPtr<Shape>>()->LINQ_ToArray();

ASSERT_EQ(2, shapes->get_Length());
auto isOleObject = [](SharedPtr<Shape> s)
{
    return s->get_ShapeType() == ShapeType::OleObject;
};
ASSERT_EQ(2, shapes->LINQ_Count(isOleObject));

// If a shape contains an OLE object, it will have a valid "OleFormat" property,
// which we can use to verify some aspects of the shape.
SharedPtr<OleFormat> oleFormat = shapes[0]->get_OleFormat();

ASPOSE_ASSERT_EQ(false, oleFormat->get_IsLink());
ASPOSE_ASSERT_EQ(false, oleFormat->get_OleIcon());

oleFormat = shapes[1]->get_OleFormat();

ASPOSE_ASSERT_EQ(true, oleFormat->get_IsLink());
ASPOSE_ASSERT_EQ(true, oleFormat->get_OleIcon());

ASSERT_TRUE(oleFormat->get_SourceFullName().EndsWith(String(u"Images") + System::IO::Path::DirectorySeparatorChar + u"Microsoft Visio drawing.vsd"));
ASSERT_EQ(u"", oleFormat->get_SourceItem());

ASSERT_EQ(u"Microsoft Visio drawing.vsd", oleFormat->get_IconCaption());

doc->Save(ArtifactsDir + u"Shape.OleLinks.docx");

// If the object contains OLE data, we can access it using a stream.
{
    SharedPtr<System::IO::MemoryStream> stream = oleFormat->GetOleEntry(u"\x0001"
                                                                        u"CompObj");
    ArrayPtr<uint8_t> oleEntryBytes = stream->ToArray();
    ASSERT_EQ(76, oleEntryBytes->get_Length());
}
```

