---
title: StyleIdentifier
second_title: Aspose.Words for C++ API Reference
description: Locale independent style identifier. 
type: docs
weight: 0
url: /cpp/aspose.words/styleidentifier/
---
## StyleIdentifier enum


Locale independent style identifier.


The names of built-in styles in MS Word are localized for different languages. Using a style identifier you can find the correct style regardless of the document language.

All user defined styles are assigned the **StyleIdentifier.User** value.

## Examples




Shows how to change the style of existing text. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Below are two ways of referencing styles.
// 1 -  Using the style name:
builder->get_Font()->set_StyleName(u"Emphasis");
builder->Writeln(u"Text originally in \"Emphasis\" style");

// 2 -  Using a built-in style identifier:
builder->get_Font()->set_StyleIdentifier(StyleIdentifier::IntenseEmphasis);
builder->Writeln(u"Text originally in \"Intense Emphasis\" style");

// Convert all uses of one style to another,
// using the above methods to reference old and new styles.
for (const auto& run : System::IterateOver(doc->GetChildNodes(NodeType::Run, true)->LINQ_OfType<SharedPtr<Run>>()))
{
    if (run->get_Font()->get_StyleName() == u"Emphasis")
    {
        run->get_Font()->set_StyleName(u"Strong");
    }

    if (run->get_Font()->get_StyleIdentifier() == StyleIdentifier::IntenseEmphasis)
    {
        run->get_Font()->set_StyleIdentifier(StyleIdentifier::Strong);
    }
}

doc->Save(ArtifactsDir + u"Font.ChangeStyle.docx");
```

