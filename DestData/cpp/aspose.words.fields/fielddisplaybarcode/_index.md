---
title: FieldDisplayBarcode
second_title: Aspose.Words for C++ API Reference
description: Implements the DISPLAYBARCODE field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/fielddisplaybarcode/
---
## FieldDisplayBarcode class


Implements the DISPLAYBARCODE field. 

## Methods

| Method | Description |
| --- | --- |
| [get_AddStartStopChar](./get_addstartstopchar/)() | Gets or sets whether to add Start/Stop characters for barcode types NW7 and CODE39.  |
| [get_BackgroundColor](./get_backgroundcolor/)() | Gets or sets the background color of the barcode symbol. Valid values are in the range [0, 0xFFFFFF].  |
| [get_BarcodeType](./get_barcodetype/)() | Gets or sets the barcode type (QR, etc.)  |
| [get_BarcodeValue](./get_barcodevalue/)() | Gets or sets the barcode value.  |
| [get_CaseCodeStyle](./get_casecodestyle/)() | Gets or sets the style of a Case Code for barcode type ITF14. The valid values are [STD|EXT|ADD].  |
| [get_DisplayResult](../field/get_displayresult/)() | Gets the text that represents the displayed field result.  |
| [get_DisplayText](./get_displaytext/)() | Gets or sets whether to display barcode data (text) along with image.  |
| [get_End](../field/get_end/)() const | Gets the node that represents the field end.  |
| [get_ErrorCorrectionLevel](./get_errorcorrectionlevel/)() | Gets or sets an error correction level of QR Code. Valid values are [0, 3].  |
| [get_FieldEnd](../field/get_fieldend/)() const | Gets the node that represents the field end.  |
| [get_FieldStart](../field/get_fieldstart/)() const | Gets the node that represents the start of the field.  |
| [get_FixCheckDigit](./get_fixcheckdigit/)() | Gets or sets whether to fix the check digit if it’s invalid.  |
| [get_ForegroundColor](./get_foregroundcolor/)() | Gets or sets the foreground color of the barcode symbol. Valid values are in the range [0, 0xFFFFFF].  |
| [get_Format](../field/get_format/)() | Gets a FieldFormat object that provides typed access to field's formatting.  |
| [get_IsDirty](../field/get_isdirty/)() | Gets or sets whether the current result of the field is no longer correct (stale) due to other modifications made to the document.  |
| [get_IsLocked](../field/get_islocked/)() | Gets or sets whether the field is locked (should not recalculate its result).  |
| [get_LocaleId](../field/get_localeid/)() | Gets or sets the LCID of the field.  |
| [get_PosCodeStyle](./get_poscodestyle/)() | Gets or sets the style of a Point of Sale barcode (barcode types UPCA|UPCE|EAN13|EAN8). The valid values (case insensitive) are [STD|SUP2|SUP5|CASE].  |
| [get_Result](../field/get_result/)() | Gets or sets text that is between the field separator and field end.  |
| [get_ScalingFactor](./get_scalingfactor/)() | Gets or sets a scaling factor for the symbol. The value is in whole percentage points and the valid values are [10, 1000].  |
| [get_Separator](../field/get_separator/)() | Gets the node that represents the field separator. Can be null.  |
| [get_Start](../field/get_start/)() const | Gets the node that represents the start of the field.  |
| [get_SymbolHeight](./get_symbolheight/)() | Gets or sets the height of the symbol. The units are in TWIPS (1/1440 inch).  |
| [get_SymbolRotation](./get_symbolrotation/)() | Gets or sets the rotation of the barcode symbol. Valid values are [0, 3].  |
| virtual [get_Type](../field/get_type/)() const | Gets the Microsoft Word field type.  |
| [GetFieldCode](../field/getfieldcode/)() | Returns text between field start and field separator (or field end if there is no separator). Both field code and field result of child fields are included.  |
| [GetFieldCode](../field/getfieldcode/)(bool) | Returns text between field start and field separator (or field end if there is no separator).  |
| [Remove](../field/remove/)() | Removes the field from the document. Returns a node right after the field. If the field's end is the last child of its parent node, returns its parent paragraph. If the field is already removed, returns **null**.  |
| [set_AddStartStopChar](./set_addstartstopchar/)(bool) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_AddStartStopChar.  |
| [set_BackgroundColor](./set_backgroundcolor/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_BackgroundColor.  |
| [set_BarcodeType](./set_barcodetype/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_BarcodeType.  |
| [set_BarcodeValue](./set_barcodevalue/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_BarcodeValue.  |
| [set_CaseCodeStyle](./set_casecodestyle/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_CaseCodeStyle.  |
| [set_DisplayText](./set_displaytext/)(bool) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_DisplayText.  |
| [set_ErrorCorrectionLevel](./set_errorcorrectionlevel/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_ErrorCorrectionLevel.  |
| [set_FixCheckDigit](./set_fixcheckdigit/)(bool) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_FixCheckDigit.  |
| [set_ForegroundColor](./set_foregroundcolor/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_ForegroundColor.  |
| [set_IsDirty](../field/set_isdirty/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsDirty.  |
| [set_IsLocked](../field/set_islocked/)(bool) | Setter for Aspose::Words::Fields::Field::get_IsLocked.  |
| [set_LocaleId](../field/set_localeid/)(int32_t) | Setter for Aspose::Words::Fields::Field::get_LocaleId.  |
| [set_PosCodeStyle](./set_poscodestyle/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_PosCodeStyle.  |
| [set_Result](../field/set_result/)(const System::String &) | Setter for Aspose::Words::Fields::Field::get_Result.  |
| [set_ScalingFactor](./set_scalingfactor/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_ScalingFactor.  |
| [set_SymbolHeight](./set_symbolheight/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_SymbolHeight.  |
| [set_SymbolRotation](./set_symbolrotation/)(const System::String &) | Setter for Aspose::Words::Fields::FieldDisplayBarcode::get_SymbolRotation.  |
| [Unlink](../field/unlink/)() | Performs the field unlink.  |
| [Update](../field/update/)() | Performs the field update. Throws if the field is being updated already.  |
| [Update](../field/update/)(bool) | Performs a field update. Throws if the field is being updated already.  |
