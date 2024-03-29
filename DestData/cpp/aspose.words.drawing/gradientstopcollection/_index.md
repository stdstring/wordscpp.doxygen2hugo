---
title: Aspose::Words::Drawing::GradientStopCollection class
linktitle: GradientStopCollection
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Drawing::GradientStopCollection class. Contains a collection of GradientStop objects in C++.'
type: docs
weight: 300
url: /cpp/aspose.words.drawing/gradientstopcollection/
---
## GradientStopCollection class


Contains a collection of [GradientStop](../gradientstop/) objects.

```cpp
class GradientStopCollection : public System::Collections::Generic::IEnumerable<System::SharedPtr<Aspose::Words::Drawing::GradientStop>>
```

## Methods

| Method | Description |
| --- | --- |
| [Add](./add/)(const System::SharedPtr\<Aspose::Words::Drawing::GradientStop\>\&) | Adds a specified [GradientStop](../gradientstop/) to a gradient. |
| [get_Count](./get_count/)() | Gets an integer value indicating the number of items in the collection. |
| [GetEnumerator](./getenumerator/)() override | Returns an enumerator that iterates through the collection. |
| [idx_get](./idx_get/)(int32_t) | Gets or sets a [GradientStop](../gradientstop/) object in the collection. |
| [idx_set](./idx_set/)(int32_t, const System::SharedPtr\<Aspose::Words::Drawing::GradientStop\>\&) | Gets or sets a [GradientStop](../gradientstop/) object in the collection. |
| [Insert](./insert/)(int32_t, const System::SharedPtr\<Aspose::Words::Drawing::GradientStop\>\&) | Inserts a [GradientStop](../gradientstop/) to the collection at a specified index. |
| [Remove](./remove/)(const System::SharedPtr\<Aspose::Words::Drawing::GradientStop\>\&) | Removes a specified [GradientStop](../gradientstop/) from the collection. |
| [RemoveAt](./removeat/)(int32_t) | Removes a [GradientStop](../gradientstop/) from the collection at a specified index. |

## Examples



Shows how to add gradient stops to the gradient fill. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Shape> shape = builder->InsertShape(ShapeType::Rectangle, 80, 80);
shape->get_Fill()->TwoColorGradient(System::Drawing::Color::get_Green(), System::Drawing::Color::get_Red(), GradientStyle::Horizontal,
                                    GradientVariant::Variant2);

// Get gradient stops collection.
SharedPtr<GradientStopCollection> gradientStops = shape->get_Fill()->get_GradientStops();

// Change first gradient stop.
gradientStops->idx_get(0)->set_Color(System::Drawing::Color::get_Aqua());
gradientStops->idx_get(0)->set_Position(0.1);
gradientStops->idx_get(0)->set_Transparency(0.25);

// Add new gradient stop to the end of collection.
auto gradientStop = MakeObject<GradientStop>(System::Drawing::Color::get_Brown(), 0.5);
gradientStops->Add(gradientStop);

// Remove gradient stop at index 1.
gradientStops->RemoveAt(1);
// And insert new gradient stop at the same index 1.
gradientStops->Insert(1, MakeObject<GradientStop>(System::Drawing::Color::get_Chocolate(), 0.75, 0.3));

// Remove last gradient stop in the collection.
gradientStop = gradientStops->idx_get(2);
gradientStops->Remove(gradientStop);

ASSERT_EQ(2, gradientStops->get_Count());

ASSERT_EQ(System::Drawing::Color::get_Aqua().ToArgb(), gradientStops->idx_get(0)->get_Color().ToArgb());
ASSERT_NEAR(0.1, gradientStops->idx_get(0)->get_Position(), 0.01);
ASSERT_NEAR(0.25, gradientStops->idx_get(0)->get_Transparency(), 0.01);

ASSERT_EQ(System::Drawing::Color::get_Chocolate().ToArgb(), gradientStops->idx_get(1)->get_Color().ToArgb());
ASSERT_NEAR(0.75, gradientStops->idx_get(1)->get_Position(), 0.01);
ASSERT_NEAR(0.3, gradientStops->idx_get(1)->get_Transparency(), 0.01);

// Use the compliance option to define the shape using DML
// if you want to get "GradientStops" property after the document saves.
auto saveOptions = MakeObject<OoxmlSaveOptions>();
saveOptions->set_Compliance(OoxmlCompliance::Iso29500_2008_Strict);

doc->Save(ArtifactsDir + u"Shape.GradientStops.docx", saveOptions);
```

## See Also

* Namespace [Aspose::Words::Drawing](../)
* Library [Aspose.Words for C++](../../)
