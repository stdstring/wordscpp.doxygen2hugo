---
title: Aspose::Words::Fields::FieldType enum
linktitle: FieldType
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::Fields::FieldType enum. Specifies Microsoft Word field types in C++.
type: docs
weight: 1652
url: /cpp/aspose.words.fields/fieldtype/
---
## FieldType enum


Specifies Microsoft Word field types.

```cpp
enum class FieldType
```

### Values

| Name | Value | Description |
| --- | --- | --- |
| FieldNone | 0 | [Field](../field/) type is not specified or unknown. |
| FieldCannotParse | 1 | Specifies that the field was unable to be parsed. |
| FieldAddin | 81 | Specifies the ADDIN field. |
| FieldAddressBlock | 93 | Specifies the ADDRESSBLOCK field. |
| FieldAdvance | 84 | Specifies the ADVANCE field. |
| FieldAsk | 38 | Specifies the ASK field. |
| FieldAuthor | 17 | Specifies the AUTHOR field. |
| FieldAutoNum | 54 | Specifies the AUTONUM field. |
| FieldAutoNumLegal | 53 | Specifies the AUTONUMLGL field. |
| FieldAutoNumOutline | 52 | Specifies the AUTONUMOUT field. |
| FieldAutoText | 79 | Specifies the AUTOTEXT field. |
| FieldAutoTextList | 89 | Specifies the AUTOTEXTLIST field. |
| FieldBarcode | 63 | Specifies the BARCODE field. |
| FieldBibliography | 100500 | Specifies the BIBLIOGRAPHY field. |
| FieldBidiOutline | 92 | Specifies the BIDIOUTLINE field. |
| FieldCitation | 1980 | Specifies the CITATION field. |
| FieldComments | 19 | Specifies the COMMENTS field. |
| FieldCompare | 80 | Specifies the COMPARE field. |
| FieldCreateDate | 21 | Specifies the CREATEDATE field. |
| FieldData | 40 | Specifies the DATA field. |
| FieldDatabase | 78 | Specifies the DATABASE field. |
| FieldDate | 31 | Specifies the DATE field. |
| FieldDDE | 45 | Specifies the DDE field. |
| FieldDisplayBarcode | 6301 | Specifies the DISPLAYBARCODE field. |
| FieldMergeBarcode | 6302 | Specifies the MERGEBARCODE field. |
| FieldDDEAuto | 46 | Specifies the DDEAUTO field. |
| FieldDocProperty | 85 | Specifies the DOCPROPERTY field. |
| FieldDocVariable | 64 | Specifies the DOCVARIABLE field. |
| FieldEditTime | 25 | Specifies the EDITTIME field. |
| FieldEmbed | 58 | Specifies the EMBED field. |
| FieldEquation | 49 | Specifies the EQ field. |
| FieldFileName | 29 | Specifies the FILENAME field. |
| FieldFileSize | 69 | Specifies the FILESIZE field. |
| FieldFillIn | 39 | Specifies the FILLIN field. |
| FieldFootnoteRef | 5 | Specifies the FOOTNOTEREF field. |
| FieldFormCheckBox | 71 | Specifies the FORMCHECKBOX field. |
| FieldFormDropDown | 83 | Specifies the FORMDROPDOWN field. |
| FieldFormTextInput | 70 | Specifies the FORMTEXT field. |
| FieldFormula | 34 | Specifies the = (formula) field. |
| FieldGreetingLine | 94 | Specifies the GREETINGLINE field. |
| FieldGlossary | 47 | Specifies the GLOSSARY field. |
| FieldGoToButton | 50 | Specifies the GOTOBUTTON field. |
| FieldHtmlActiveX | 91 | Specifies the field that represents an HTML control. |
| FieldHyperlink | 88 | Specifies the HYPERLINK field. |
| FieldIf | 7 | Specifies the IF field. |
| FieldInclude | 36 | Specifies the INCLUDE field. |
| FieldIncludePicture | 67 | Specifies the INCLUDEPICTURE field. |
| FieldIncludeText | 68 | Specifies the INCLUDETEXT field. |
| FieldIndex | 8 | Specifies the INDEX field. |
| FieldIndexEntry | 4 | Specifies the XE field. |
| FieldInfo | 14 | Specifies the INFO field. |
| FieldImport | 55 | Specifies the IMPORT field. |
| FieldKeyword | 18 | Specifies the KEYWORDS field. |
| FieldLastSavedBy | 20 | Specifies the LASTSAVEDBY field. |
| FieldLink | 56 | Specifies the LINK field. |
| FieldListNum | 90 | Specifies the LISTNUM field. |
| FieldMacroButton | 51 | Specifies the MACROBUTTON field. |
| FieldMergeField | 59 | Specifies the MERGEFIELD field. |
| FieldMergeRec | 44 | Specifies the MERGEREC field. |
| FieldMergeSeq | 75 | Specifies the MERGESEQ field. |
| FieldNext | 41 | Specifies the NEXT field. |
| FieldNextIf | 42 | Specifies the NEXTIF field. |
| FieldNoteRef | 72 | Specifies the NOTEREF field. |
| FieldNumChars | 28 | Specifies the NUMCHARS field. |
| FieldNumPages | 26 | Specifies the NUMPAGES field. |
| FieldNumWords | 27 | Specifies the NUMWORDS field. |
| FieldOcx | 87 | Specifies the OCX field. Normally, Aspose.Words will represent an ActiveX control as a [Shape](../../aspose.words.drawing/shape/) object, but for some documents, where a control does not have data and/or seems to be invalid, it will be represented as a field. |
| FieldPage | 33 | Specifies the PAGE field. |
| FieldPageRef | 37 | Specifies the PAGEREF field. |
| FieldPrint | 48 | Specifies the PRINT field. |
| FieldPrintDate | 23 | Specifies the PRINTDATE field. |
| FieldPrivate | 77 | Specifies the PRIVATE field. |
| FieldQuote | 35 | Specifies the QUOTE field. |
| FieldRef | 3 | Specifies the REF field. |
| FieldRefNoKeyword | 2 | Specifies that the field represents a REF field where the keyword has been omitted. |
| FieldRefDoc | 11 | Specifies the RD field. |
| FieldRevisionNum | 24 | Specifies the REVNUM field. |
| FieldSaveDate | 22 | Specifies the SAVEDATE field. |
| FieldSection | 65 | Specifies the SECTION field. |
| FieldSectionPages | 66 | Specifies the SECTIONPAGES field. |
| FieldSequence | 12 | Specifies the SEQ field. |
| FieldSet | 6 | Specifies the SET field. |
| FieldShape | 95 | Specifies the SHAPE field. |
| FieldSkipIf | 43 | Specifies the SKIPIF field. |
| FieldStyleRef | 10 | Specifies the STYLEREF field. |
| FieldSubject | 16 | Specifies the SUBJECT field. |
| FieldSymbol | 57 | Specifies the SYMBOL field. |
| FieldTemplate | 30 | Specifies the TEMPLATE field. |
| FieldTime | 32 | Specifies the TIME field. |
| FieldTitle | 15 | Specifies the TITLE field. |
| FieldTOA | 73 | Specifies the TOA field. |
| FieldTOAEntry | 74 | Specifies the TA field. |
| FieldTOC | 13 | Specifies the TOC field. |
| FieldTOCEntry | 9 | Specifies the TC field. |
| FieldUserAddress | 62 | Specifies the USERADDRESS field. |
| FieldUserInitials | 61 | Specifies the USERINITIALS field. |
| FieldUserName | 60 | Specifies the USERNAME field. |


## Examples



Shows how to insert a field into a document using a field code. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

SharedPtr<Field> field = builder->InsertField(u"DATE \\@ \"dddd, MMMM dd, yyyy\"");

ASSERT_EQ(FieldType::FieldDate, field->get_Type());
ASSERT_EQ(u"DATE \\@ \"dddd, MMMM dd, yyyy\"", field->GetFieldCode());

// This overload of the InsertField method automatically updates inserted fields.
ASSERT_LE(System::Math::Abs((System::DateTime::Parse(field->get_Result()) - System::DateTime::get_Today()).get_Hours()), 24);
```


Shows how to work with a [FieldStart](../fieldstart/) node. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

auto field = System::DynamicCast<FieldDate>(builder->InsertField(FieldType::FieldDate, true));
field->get_Format()->set_DateTimeFormat(u"dddd, MMMM dd, yyyy");
field->Update();

SharedPtr<FieldChar> fieldStart = field->get_Start();

ASSERT_EQ(FieldType::FieldDate, fieldStart->get_FieldType());
ASPOSE_ASSERT_EQ(false, fieldStart->get_IsDirty());
ASPOSE_ASSERT_EQ(false, fieldStart->get_IsLocked());

// Retrieve the facade object which represents the field in the document.
field = System::DynamicCast<FieldDate>(fieldStart->GetField());

ASPOSE_ASSERT_EQ(false, field->get_IsLocked());
ASSERT_EQ(u" DATE  \\@ \"dddd, MMMM dd, yyyy\"", field->GetFieldCode());

// Update the field to show the current date.
field->Update();
```

## See Also

* Namespace [Aspose::Words::Fields](../)
* Library [Aspose.Words for C++](../../)
