---
title: CreatePictureBullet
second_title: Aspose.Words for C++ API Reference
description: Creates picture bullet shape for the current list level.
type: docs
weight: 1
url: /cpp/aspose.words.lists/listlevel/createpicturebullet/
---
## ListLevel::CreatePictureBullet method


Creates picture bullet shape for the current list level.

```cpp
void Aspose::Words::Lists::ListLevel::CreatePictureBullet()
```


## Examples




Shows how to set a custom image icon for list item labels. 
```cpp
auto doc = MakeObject<Document>();

SharedPtr<List> list = doc->get_Lists()->Add(ListTemplate::BulletCircle);

// Create a picture bullet for the current list level, and set an image from a local file system
// as the icon that the bullets for this list level will display.
list->get_ListLevels()->idx_get(0)->CreatePictureBullet();
list->get_ListLevels()->idx_get(0)->get_ImageData()->SetImage(ImageDir + u"Logo icon.ico");

ASSERT_TRUE(list->get_ListLevels()->idx_get(0)->get_ImageData()->get_HasImage());

auto builder = MakeObject<DocumentBuilder>(doc);

builder->get_ListFormat()->set_List(list);
builder->Writeln(u"Hello world!");
builder->Write(u"Hello again!");

doc->Save(ArtifactsDir + u"Lists.CreatePictureBullet.docx");

list->get_ListLevels()->idx_get(0)->DeletePictureBullet();

ASSERT_TRUE(list->get_ListLevels()->idx_get(0)->get_ImageData() == nullptr);
```

