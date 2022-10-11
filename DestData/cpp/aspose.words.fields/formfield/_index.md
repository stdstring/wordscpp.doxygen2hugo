---
title: FormField
second_title: Aspose.Words for C++ API Reference
description: Represents a single form field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/formfield/
---
## FormField class


Represents a single form field. 

## Methods

| Method | Description |
| --- | --- |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| bool [get_CalculateOnExit](./get_calculateonexit/)() | True if references to the specified form field are automatically updated whenever the field is exited.  |
| double [get_CheckBoxSize](./get_checkboxsize/)() | Gets or sets the size of the checkbox in points. Has effect only when IsCheckBoxExactSize is true.  |
| bool [get_Checked](./get_checked/)() | Gets or sets the checked status of the check box form field. Default value for this property is **false**.  |
| bool [get_Default](./get_default/)() | Gets or sets the default value of the check box form field. Default value for this property is **false**.  |
| System::SharedPtr< Aspose::Words::Fields::DropDownItemCollection > [get_DropDownItems](./get_dropdownitems/)() | Provides access to the items of a dropdown form field.  |
| int32_t [get_DropDownSelectedIndex](./get_dropdownselectedindex/)() | Gets or sets the index specifying the currently selected item in a dropdown form field.  |
| bool [get_Enabled](./get_enabled/)() | True if a form field is enabled.  |
| System::String [get_EntryMacro](./get_entrymacro/)() | Returns or sets an entry macro name for the form field.  |
| System::String [get_ExitMacro](./get_exitmacro/)() | Returns or sets an exit macro name for the form field.  |
| System::String [get_HelpText](./get_helptext/)() | Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1.  |
| bool [get_IsCheckBoxExactSize](./get_ischeckboxexactsize/)() | Gets or sets the boolean value that indicates whether the size of the textbox is automatic or specified explicitly.  |
| int32_t [get_MaxLength](./get_maxlength/)() | Maximum length for the text field. Zero when the length is not limited.  |
| System::String [get_Name](./get_name/)() | Gets or sets the form field name.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.FormField**.  |
| bool [get_OwnHelp](./get_ownhelp/)() | Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.  |
| bool [get_OwnStatus](./get_ownstatus/)() | Specifies the source of the text that's displayed in the status bar when a form field has the focus.  |
| System::String [get_Result](./get_result/)() | Gets or sets a string that represents the result of this form field.  |
| System::String [get_StatusText](./get_statustext/)() | Returns or sets the text that's displayed in the status bar when a form field has the focus.  |
| System::String [get_TextInputDefault](./get_textinputdefault/)() | Gets or sets the default string or a calculation expression of a text form field.  |
| System::String [get_TextInputFormat](./get_textinputformat/)() | Returns or sets the text formatting for a text form field.  |
| Aspose::Words::Fields::TextFormFieldType [get_TextInputType](./get_textinputtype/)() | Gets or sets the type of a text form field.  |
| Aspose::Words::Fields::FieldType [get_Type](./get_type/)() | Returns the form field type.  |
| void [RemoveField](./removefield/)() | Removes the complete form field, not just the form field special character.  |
| void [set_CalculateOnExit](./set_calculateonexit/)(bool) | Setter for Aspose::Words::Fields::FormField::get_CalculateOnExit.  |
| void [set_CheckBoxSize](./set_checkboxsize/)(double) | Setter for Aspose::Words::Fields::FormField::get_CheckBoxSize.  |
| void [set_Checked](./set_checked/)(bool) | Setter for Aspose::Words::Fields::FormField::get_Checked.  |
| void [set_Default](./set_default/)(bool) | Setter for Aspose::Words::Fields::FormField::get_Default.  |
| void [set_DropDownSelectedIndex](./set_dropdownselectedindex/)(int32_t) | Setter for Aspose::Words::Fields::FormField::get_DropDownSelectedIndex.  |
| void [set_Enabled](./set_enabled/)(bool) | Setter for Aspose::Words::Fields::FormField::get_Enabled.  |
| void [set_EntryMacro](./set_entrymacro/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_EntryMacro.  |
| void [set_ExitMacro](./set_exitmacro/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_ExitMacro.  |
| void [set_HelpText](./set_helptext/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_HelpText.  |
| void [set_IsCheckBoxExactSize](./set_ischeckboxexactsize/)(bool) | Setter for Aspose::Words::Fields::FormField::get_IsCheckBoxExactSize.  |
| void [set_MaxLength](./set_maxlength/)(int32_t) | Setter for Aspose::Words::Fields::FormField::get_MaxLength.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_Name.  |
| void [set_OwnHelp](./set_ownhelp/)(bool) | Setter for Aspose::Words::Fields::FormField::get_OwnHelp.  |
| void [set_OwnStatus](./set_ownstatus/)(bool) | Setter for Aspose::Words::Fields::FormField::get_OwnStatus.  |
| void [set_Result](./set_result/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_Result.  |
| void [set_StatusText](./set_statustext/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_StatusText.  |
| void [set_TextInputDefault](./set_textinputdefault/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_TextInputDefault.  |
| void [set_TextInputFormat](./set_textinputformat/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_TextInputFormat.  |
| void [set_TextInputType](./set_textinputtype/)(Aspose::Words::Fields::TextFormFieldType) | Setter for Aspose::Words::Fields::FormField::get_TextInputType.  |
| void [SetTextInputValue](./settextinputvalue/)(const System::SharedPtr< System::Object > &) | Applies the text format specified in TextInputFormat and stores the value in Result.  |
