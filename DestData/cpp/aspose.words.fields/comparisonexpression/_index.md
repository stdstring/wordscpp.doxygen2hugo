---
title: ComparisonExpression
second_title: Aspose.Words for C++ API Reference
description: The comparison expression. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/comparisonexpression/
---
## ComparisonExpression class


The comparison expression.

```cpp
class ComparisonExpression : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| [get_ComparisonOperator](./get_comparisonoperator/)() const | Gets the comparison operator. |
| [get_LeftExpression](./get_leftexpression/)() const | Gets the left expression. |
| [get_RightExpression](./get_rightexpression/)() const | Gets the right expression. |

## Examples




Shows how to implement custom evaluation for the IF and COMPARE fields. 
```cpp
void ConditionEvaluationExtensionPoint(String fieldCode, int8_t comparisonResult, String comparisonError, String expectedResult)
{
    const String left = u"\"left expression\"";
    const String operator_ = u"<>";
    const String right = u"\"right expression\"";

    auto builder = MakeObject<DocumentBuilder>();

    // Field codes that we use in this example:
    // 1.   " IF {0} {1} {2} \"true argument\" \"false argument\" ".
    // 2.   " COMPARE {0} {1} {2} ".
    SharedPtr<Field> field = builder->InsertField(String::Format(fieldCode, left, operator_, right), nullptr);

    // If the "comparisonResult" is undefined, we create "ComparisonEvaluationResult" with string, instead of bool.
    SharedPtr<ComparisonEvaluationResult> result = comparisonResult != -1       ? MakeObject<ComparisonEvaluationResult>(comparisonResult == 1)
                                                   : comparisonError != nullptr ? MakeObject<ComparisonEvaluationResult>(comparisonError)
                                                                                : nullptr;

    auto evaluator = MakeObject<ExField::ComparisonExpressionEvaluator>(result);
    builder->get_Document()->get_FieldOptions()->set_ComparisonExpressionEvaluator(evaluator);

    builder->get_Document()->UpdateFields();

    ASSERT_EQ(expectedResult, field->get_Result());
    evaluator->AssertInvocationsCount(1)->AssertInvocationArguments(0, left, operator_, right);
}

class ComparisonExpressionEvaluator : public IComparisonExpressionEvaluator
{
public:
    ComparisonExpressionEvaluator(SharedPtr<ComparisonEvaluationResult> result)
        : mInvocations(MakeObject<System::Collections::Generic::List<ArrayPtr<String>>>())
    {
        mResult = result;
    }

    SharedPtr<ComparisonEvaluationResult> Evaluate(SharedPtr<Field> field, SharedPtr<ComparisonExpression> expression) override
    {
        mInvocations->Add(MakeArray<String>({expression->get_LeftExpression(), expression->get_ComparisonOperator(), expression->get_RightExpression()}));

        return mResult;
    }

    SharedPtr<ExField::ComparisonExpressionEvaluator> AssertInvocationsCount(int expected)
    {
        EXPECT_EQ(expected, mInvocations->get_Count());
        return System::MakeSharedPtr(this);
    }

    SharedPtr<ExField::ComparisonExpressionEvaluator> AssertInvocationArguments(int invocationIndex, String expectedLeftExpression,
                                                                                String expectedComparisonOperator, String expectedRightExpression)
    {
        ArrayPtr<String> arguments = mInvocations->idx_get(invocationIndex);

        EXPECT_EQ(expectedLeftExpression, arguments[0]);
        EXPECT_EQ(expectedComparisonOperator, arguments[1]);
        EXPECT_EQ(expectedRightExpression, arguments[2]);

        return System::MakeSharedPtr(this);
    }

protected:
    virtual ~ComparisonExpressionEvaluator()
    {
    }

private:
    SharedPtr<ComparisonEvaluationResult> mResult;
    SharedPtr<System::Collections::Generic::List<ArrayPtr<String>>> mInvocations;
};
```

