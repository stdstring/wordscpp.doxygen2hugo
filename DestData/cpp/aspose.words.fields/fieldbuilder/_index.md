---
title: FieldBuilder
second_title: Aspose.Words for C++ API Reference
description: Builds a field from field code tokens (arguments and switches). 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fieldbuilder/
---
## FieldBuilder class


Builds a field from field code tokens (arguments and switches). 

## Methods

| Method | Description |
| --- | --- |
|  [FieldBuilder](./fieldbuilder/)(Aspose::Words::Fields::FieldType) | Initializes an instance of the FieldBuilder class.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddArgument](./addargument/)(const System::SharedPtr< Aspose::Words::Fields::FieldArgumentBuilder > &) | Adds a field's argument represented by FieldArgumentBuilder to the field's code.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddArgument](./addargument/)(const System::SharedPtr< Aspose::Words::Fields::FieldBuilder > &) | Adds a child field represented by another FieldBuilder to the field's code.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddArgument](./addargument/)(const System::String &) | Adds a field's argument.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddArgument](./addargument/)(double) | Adds a field's argument.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddArgument](./addargument/)(int32_t) | Adds a field's argument.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddSwitch](./addswitch/)(const System::String &) | Adds a field's switch.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddSwitch](./addswitch/)(const System::String &, const System::String &) | Adds a field's switch.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddSwitch](./addswitch/)(const System::String &, double) | Adds a field's switch.  |
| System::SharedPtr< Aspose::Words::Fields::FieldBuilder > [AddSwitch](./addswitch/)(const System::String &, int32_t) | Adds a field's switch.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [BuildAndInsert](./buildandinsert/)(const System::SharedPtr< Aspose::Words::Inline > &) | Builds and inserts a field into the document before the specified inline node.  |
| System::SharedPtr< Aspose::Words::Fields::Field > [BuildAndInsert](./buildandinsert/)(const System::SharedPtr< Aspose::Words::Paragraph > &) | Builds and inserts a field into the document to the end of the specified paragraph.  |
