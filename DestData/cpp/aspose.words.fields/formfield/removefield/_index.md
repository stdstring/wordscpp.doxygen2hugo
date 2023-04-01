---
title: Aspose::Words::Fields::FormField::RemoveField method
linktitle: RemoveField
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Fields::FormField::RemoveField method. Removes the complete form field, not just the form field special character in C++.'
type: docs
weight: 2400
url: /cpp/aspose.words.fields/formfield/removefield/
---
## FormField::RemoveField method


Removes the complete form field, not just the form field special character.

```cpp
void Aspose::Words::Fields::FormField::RemoveField()
```


## Examples



Shows how to delete a form field. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Form fields.docx");

SharedPtr<FormField> formField = doc->get_Range()->get_FormFields()->idx_get(3);
formField->RemoveField();
```

## See Also

* Class [FormField](../)
* Namespace [Aspose::Words::Fields](../../)
* Library [Aspose.Words for C++](../../../)
