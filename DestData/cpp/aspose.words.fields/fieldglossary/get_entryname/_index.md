---
title: get_EntryName
second_title: Aspose.Words for C++ API Reference
description: Gets or sets the name of the glossary entry to insert.
type: docs
weight: 1
url: /cpp/aspose.words.fields/fieldglossary/get_entryname/
---
## FieldGlossary::get_EntryName method


Gets or sets the name of the glossary entry to insert.

```cpp
System::String Aspose::Words::Fields::FieldGlossary::get_EntryName() override
```


## Examples



Shows how to display a building block with AUTOTEXT and GLOSSARY fields. 
```cpp
auto doc = MakeObject<Document>();

// Create a glossary document and add an AutoText building block to it.
doc->set_GlossaryDocument(MakeObject<GlossaryDocument>());
auto buildingBlock = MakeObject<BuildingBlock>(doc->get_GlossaryDocument());
buildingBlock->set_Name(u"MyBlock");
buildingBlock->set_Gallery(BuildingBlockGallery::AutoText);
buildingBlock->set_Category(u"General");
buildingBlock->set_Description(u"MyBlock description");
buildingBlock->set_Behavior(BuildingBlockBehavior::Paragraph);
doc->get_GlossaryDocument()->AppendChild(buildingBlock);

// Create a source and add it as text to our building block.
auto buildingBlockSource = MakeObject<Document>();
auto buildingBlockSourceBuilder = MakeObject<DocumentBuilder>(buildingBlockSource);
buildingBlockSourceBuilder->Writeln(u"Hello World!");

SharedPtr<Node> buildingBlockContent = doc->get_GlossaryDocument()->ImportNode(buildingBlockSource->get_FirstSection(), true);
buildingBlock->AppendChild(buildingBlockContent);

// Set a file which contains parts that our document, or its attached template may not contain.
doc->get_FieldOptions()->set_BuiltInTemplatesPaths(MakeArray<String>({MyDir + u"Busniess brochure.dotx"}));

auto builder = MakeObject<DocumentBuilder>(doc);

// Below are two ways to use fields to display the contents of our building block.
// 1 -  Using an AUTOTEXT field:
auto fieldAutoText = System::DynamicCast<FieldAutoText>(builder->InsertField(FieldType::FieldAutoText, true));
fieldAutoText->set_EntryName(u"MyBlock");

ASSERT_EQ(u" AUTOTEXT  MyBlock", fieldAutoText->GetFieldCode());

// 2 -  Using a GLOSSARY field:
auto fieldGlossary = System::DynamicCast<FieldGlossary>(builder->InsertField(FieldType::FieldGlossary, true));
fieldGlossary->set_EntryName(u"MyBlock");

ASSERT_EQ(u" GLOSSARY  MyBlock", fieldGlossary->GetFieldCode());

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.AUTOTEXT.GLOSSARY.dotx");
```

