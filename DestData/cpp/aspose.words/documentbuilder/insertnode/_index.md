---
title: Aspose::Words::DocumentBuilder::InsertNode method
linktitle: InsertNode
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::DocumentBuilder::InsertNode method. Inserts a node before the cursor in C++.'
type: docs
weight: 3800
url: /cpp/aspose.words/documentbuilder/insertnode/
---
## DocumentBuilder::InsertNode method


Inserts a node before the cursor.

```cpp
void Aspose::Words::DocumentBuilder::InsertNode(const System::SharedPtr<Aspose::Words::Node> &node)
```


## Examples



Shows how to insert a linked image into a document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

String imageFileName = ImageDir + u"Windows MetaFile.wmf";

// Below are two ways of applying an image to a shape so that it can display it.
// 1 -  Set the shape to contain the image.
auto shape = MakeObject<Shape>(builder->get_Document(), ShapeType::Image);
shape->set_WrapType(WrapType::Inline);
shape->get_ImageData()->SetImage(imageFileName);

builder->InsertNode(shape);

doc->Save(ArtifactsDir + u"Image.CreateLinkedImage.Embedded.docx");

// Every image that we store in shape will increase the size of our document.
ASSERT_TRUE(70000 < MakeObject<System::IO::FileInfo>(ArtifactsDir + u"Image.CreateLinkedImage.Embedded.docx")->get_Length());

doc->get_FirstSection()->get_Body()->get_FirstParagraph()->RemoveAllChildren();

// 2 -  Set the shape to link to an image file in the local file system.
shape = MakeObject<Shape>(builder->get_Document(), ShapeType::Image);
shape->set_WrapType(WrapType::Inline);
shape->get_ImageData()->set_SourceFullName(imageFileName);

builder->InsertNode(shape);
doc->Save(ArtifactsDir + u"Image.CreateLinkedImage.Linked.docx");

// Linking to images will save space and result in a smaller document.
// However, the document can only display the image correctly while
// the image file is present at the location that the shape's "SourceFullName" property points to.
ASSERT_TRUE(10000 > MakeObject<System::IO::FileInfo>(ArtifactsDir + u"Image.CreateLinkedImage.Linked.docx")->get_Length());
```

## See Also

* Class [Node](../../node/)
* Class [DocumentBuilder](../)
* Namespace [Aspose::Words](../../)
* Library [Aspose.Words for C++](../../../)
