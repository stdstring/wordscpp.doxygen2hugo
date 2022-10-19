---
title: get_Next
second_title: Aspose.Words for C++ API Reference
description: Returns or sets a TextBox that represents the next TextBox in a sequence of shapes. 
type: docs
weight: 92
url: /cpp/aspose.words.drawing/textbox/get_next/
---
## TextBox.get_Next method


Returns or sets a [TextBox](../) that represents the next [TextBox](../) in a sequence of shapes.

```cpp
System::SharedPtr<Aspose::Words::Drawing::TextBox> Aspose::Words::Drawing::TextBox::get_Next()
```


## Examples




Shows how to link text boxes. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> textBoxShape1 = builder->InsertShape(ShapeType::TextBox, 100, 100);
SharedPtr<TextBox> textBox1 = textBoxShape1->get_TextBox();
builder->Writeln();

SharedPtr<Shape> textBoxShape2 = builder->InsertShape(ShapeType::TextBox, 100, 100);
SharedPtr<TextBox> textBox2 = textBoxShape2->get_TextBox();
builder->Writeln();

SharedPtr<Shape> textBoxShape3 = builder->InsertShape(ShapeType::TextBox, 100, 100);
SharedPtr<TextBox> textBox3 = textBoxShape3->get_TextBox();
builder->Writeln();

SharedPtr<Shape> textBoxShape4 = builder->InsertShape(ShapeType::TextBox, 100, 100);
SharedPtr<TextBox> textBox4 = textBoxShape4->get_TextBox();

// Create links between some of the text boxes.
if (textBox1->IsValidLinkTarget(textBox2))
{
    textBox1->set_Next(textBox2);
}

if (textBox2->IsValidLinkTarget(textBox3))
{
    textBox2->set_Next(textBox3);
}

// Only an empty text box may have a link.
ASSERT_TRUE(textBox3->IsValidLinkTarget(textBox4));

builder->MoveTo(textBoxShape4->get_LastParagraph());
builder->Write(u"Hello world!");

ASSERT_FALSE(textBox3->IsValidLinkTarget(textBox4));

if (textBox1->get_Next() != nullptr && textBox1->get_Previous() == nullptr)
{
    std::cout << "This TextBox is the head of the sequence" << std::endl;
}

if (textBox2->get_Next() != nullptr && textBox2->get_Previous() != nullptr)
{
    std::cout << "This TextBox is the middle of the sequence" << std::endl;
}

if (textBox3->get_Next() == nullptr && textBox3->get_Previous() != nullptr)
{
    std::cout << "This TextBox is the tail of the sequence" << std::endl;

    // Break the forward link between textBox2 and textBox3, and then verify that they are no longer linked.
    textBox3->get_Previous()->BreakForwardLink();

    ASSERT_TRUE(textBox2->get_Next() == nullptr);
    ASSERT_TRUE(textBox3->get_Previous() == nullptr);
}

doc->Save(ArtifactsDir + u"Shape.CreateLinkBetweenTextBoxes.docx");
```

