---
title: Aspose::Words::Fields::FieldArgumentBuilder class
linktitle: FieldArgumentBuilder
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Fields::FieldArgumentBuilder class. Builds a complex field argument consisting of fields, nodes, and plain text in C++.'
type: docs
weight: 900
url: /cpp/aspose.words.fields/fieldargumentbuilder/
---
## FieldArgumentBuilder class


Builds a complex field argument consisting of fields, nodes, and plain text.

```cpp
class FieldArgumentBuilder : public Aspose::Words::Fields::IFieldBuildingBlock
```

## Methods

| Method | Description |
| --- | --- |
| [AddField](./addfield/)(const System::SharedPtr\<Aspose::Words::Fields::FieldBuilder\>\&) | Adds a field represented by a [FieldBuilder](../fieldbuilder/) to the argument. |
| [AddNode](./addnode/)(const System::SharedPtr\<Aspose::Words::Inline\>\&) | Adds a node to the argument. |
| [AddText](./addtext/)(const System::String\&) | Adds a plain text to the argument. |
| [FieldArgumentBuilder](./fieldargumentbuilder/)() | Initializes an instance of the [FieldArgumentBuilder](./) class. |

## Examples



Shows how to construct fields using a field builder, and then insert them into the document. 
```cpp
auto doc = MakeObject<Document>();

// Below are three examples of field construction done using a field builder.
// 1 -  Single field:
// Use a field builder to add a SYMBOL field which displays the ƒ (Florin) symbol.
auto builder = MakeObject<FieldBuilder>(FieldType::FieldSymbol);
builder->AddArgument(402);
builder->AddSwitch(u"\\f", u"Arial");
builder->AddSwitch(u"\\s", 25);
builder->AddSwitch(u"\\u");
SharedPtr<Field> field = builder->BuildAndInsert(doc->get_FirstSection()->get_Body()->get_FirstParagraph());

ASSERT_EQ(u" SYMBOL 402 \\f Arial \\s 25 \\u ", field->GetFieldCode());

// 2 -  Nested field:
// Use a field builder to create a formula field used as an inner field by another field builder.
auto innerFormulaBuilder = MakeObject<FieldBuilder>(FieldType::FieldFormula);
innerFormulaBuilder->AddArgument(100);
innerFormulaBuilder->AddArgument(u"+");
innerFormulaBuilder->AddArgument(74);

// Create another builder for another SYMBOL field, and insert the formula field
// that we have created above into the SYMBOL field as its argument.
builder = MakeObject<FieldBuilder>(FieldType::FieldSymbol);
builder->AddArgument(innerFormulaBuilder);
field = builder->BuildAndInsert(doc->get_FirstSection()->get_Body()->AppendParagraph(String::Empty));

// The outer SYMBOL field will use the formula field result, 174, as its argument,
// which will make the field display the ® (Registered Sign) symbol since its character number is 174.
ASSERT_EQ(u" SYMBOL \u0013 = 100 + 74 \u0014\u0015 ", field->GetFieldCode());

// 3 -  Multiple nested fields and arguments:
// Now, we will use a builder to create an IF field, which displays one of two custom string values,
// depending on the true/false value of its expression. To get a true/false value
// that determines which string the IF field displays, the IF field will test two numeric expressions for equality.
// We will provide the two expressions in the form of formula fields, which we will nest inside the IF field.
auto leftExpression = MakeObject<FieldBuilder>(FieldType::FieldFormula);
leftExpression->AddArgument(2);
leftExpression->AddArgument(u"+");
leftExpression->AddArgument(3);

auto rightExpression = MakeObject<FieldBuilder>(FieldType::FieldFormula);
rightExpression->AddArgument(2.5);
rightExpression->AddArgument(u"*");
rightExpression->AddArgument(5.2);

// Next, we will build two field arguments, which will serve as the true/false output strings for the IF field.
// These arguments will reuse the output values of our numeric expressions.
auto trueOutput = MakeObject<FieldArgumentBuilder>();
trueOutput->AddText(u"True, both expressions amount to ");
trueOutput->AddField(leftExpression);

auto falseOutput = MakeObject<FieldArgumentBuilder>();
falseOutput->AddNode(MakeObject<Run>(doc, u"False, "));
falseOutput->AddField(leftExpression);
falseOutput->AddNode(MakeObject<Run>(doc, u" does not equal "));
falseOutput->AddField(rightExpression);

// Finally, we will create one more field builder for the IF field and combine all of the expressions.
builder = MakeObject<FieldBuilder>(FieldType::FieldIf);
builder->AddArgument(leftExpression);
builder->AddArgument(u"=");
builder->AddArgument(rightExpression);
builder->AddArgument(trueOutput);
builder->AddArgument(falseOutput);
field = builder->BuildAndInsert(doc->get_FirstSection()->get_Body()->AppendParagraph(String::Empty));

ASSERT_EQ(String(u" IF \u0013 = 2 + 3 \u0014\u0015 = \u0013 = 2.5 * 5.2 \u0014\u0015 ") +
              u"\"True, both expressions amount to \u0013 = 2 + 3 \u0014\u0015\" " +
              u"\"False, \u0013 = 2 + 3 \u0014\u0015 does not equal \u0013 = 2.5 * 5.2 \u0014\u0015\" ",
          field->GetFieldCode());

doc->UpdateFields();
doc->Save(ArtifactsDir + u"Field.SYMBOL.docx");
```

## See Also

* Namespace [Aspose::Words::Fields](../)
* Library [Aspose.Words for C++](../../)
