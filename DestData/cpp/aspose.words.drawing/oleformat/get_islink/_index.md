---
title: Aspose::Words::Drawing::OleFormat::get_IsLink method
linktitle: get_IsLink
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Drawing::OleFormat::get_IsLink method. Returns true if the OLE object is linked (when SourceFullName is specified) in C++.
type: docs
weight: 40
url: /cpp/aspose.words.drawing/oleformat/get_islink/
---
## OleFormat::get_IsLink method


Returns true if the OLE object is linked (when [SourceFullName](../get_sourcefullname/) is specified).

```cpp
bool Aspose::Words::Drawing::OleFormat::get_IsLink()
```


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

## See Also

* Class [OleFormat](../)
* Namespace [Aspose::Words::Drawing](../../)
* Library [Aspose.Words for C++](../../../)
