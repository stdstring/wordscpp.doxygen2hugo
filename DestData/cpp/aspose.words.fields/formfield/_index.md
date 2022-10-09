---
title: formfield
second_title: Aspose.Words for C++ API Reference
description: Represents a single form field. 
type: docs
weight: 0
url: /cpp/aspose.words.fields/formfield/
---

Represents a single form field. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [get_CalculateOnExit](./get_calculateonexit/)() | True if references to the specified form field are automatically updated whenever the field is exited.  |
| [get_CheckBoxSize](./get_checkboxsize/)() | Gets or sets the size of the checkbox in points. Has effect only when IsCheckBoxExactSize is true.  |
| [get_Checked](./get_checked/)() | Gets or sets the checked status of the check box form field. Default value for this property is **false**.  |
| [get_Default](./get_default/)() | Gets or sets the default value of the check box form field. Default value for this property is **false**.  |
| [get_DropDownItems](./get_dropdownitems/)() | Provides access to the items of a dropdown form field.  |
| [get_DropDownSelectedIndex](./get_dropdownselectedindex/)() | Gets or sets the index specifying the currently selected item in a dropdown form field.  |
| [get_Enabled](./get_enabled/)() | True if a form field is enabled.  |
| [get_EntryMacro](./get_entrymacro/)() | Returns or sets an entry macro name for the form field.  |
| [get_ExitMacro](./get_exitmacro/)() | Returns or sets an exit macro name for the form field.  |
| [get_HelpText](./get_helptext/)() | Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1.  |
| [get_IsCheckBoxExactSize](./get_ischeckboxexactsize/)() | Gets or sets the boolean value that indicates whether the size of the textbox is automatic or specified explicitly.  |
| [get_MaxLength](./get_maxlength/)() | Maximum length for the text field. Zero when the length is not limited.  |
| [get_Name](./get_name/)() | Gets or sets the form field name.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.FormField**.  |
| [get_OwnHelp](./get_ownhelp/)() | Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1.  |
| [get_OwnStatus](./get_ownstatus/)() | Specifies the source of the text that's displayed in the status bar when a form field has the focus.  |
| [get_Result](./get_result/)() | Gets or sets a string that represents the result of this form field.  |
| [get_StatusText](./get_statustext/)() | Returns or sets the text that's displayed in the status bar when a form field has the focus.  |
| [get_TextInputDefault](./get_textinputdefault/)() | Gets or sets the default string or a calculation expression of a text form field.  |
| [get_TextInputFormat](./get_textinputformat/)() | Returns or sets the text formatting for a text form field.  |
| [get_TextInputType](./get_textinputtype/)() | Gets or sets the type of a text form field.  |
| [get_Type](./get_type/)() | Returns the form field type.  |
| [RemoveField](./removefield/)() | Removes the complete form field, not just the form field special character.  |
| [set_CalculateOnExit](./set_calculateonexit/)(bool) | Setter for Aspose::Words::Fields::FormField::get_CalculateOnExit.  |
| [set_CheckBoxSize](./set_checkboxsize/)(double) | Setter for Aspose::Words::Fields::FormField::get_CheckBoxSize.  |
| [set_Checked](./set_checked/)(bool) | Setter for Aspose::Words::Fields::FormField::get_Checked.  |
| [set_Default](./set_default/)(bool) | Setter for Aspose::Words::Fields::FormField::get_Default.  |
| [set_DropDownSelectedIndex](./set_dropdownselectedindex/)(int32_t) | Setter for Aspose::Words::Fields::FormField::get_DropDownSelectedIndex.  |
| [set_Enabled](./set_enabled/)(bool) | Setter for Aspose::Words::Fields::FormField::get_Enabled.  |
| [set_EntryMacro](./set_entrymacro/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_EntryMacro.  |
| [set_ExitMacro](./set_exitmacro/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_ExitMacro.  |
| [set_HelpText](./set_helptext/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_HelpText.  |
| [set_IsCheckBoxExactSize](./set_ischeckboxexactsize/)(bool) | Setter for Aspose::Words::Fields::FormField::get_IsCheckBoxExactSize.  |
| [set_MaxLength](./set_maxlength/)(int32_t) | Setter for Aspose::Words::Fields::FormField::get_MaxLength.  |
| [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_Name.  |
| [set_OwnHelp](./set_ownhelp/)(bool) | Setter for Aspose::Words::Fields::FormField::get_OwnHelp.  |
| [set_OwnStatus](./set_ownstatus/)(bool) | Setter for Aspose::Words::Fields::FormField::get_OwnStatus.  |
| [set_Result](./set_result/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_Result.  |
| [set_StatusText](./set_statustext/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_StatusText.  |
| [set_TextInputDefault](./set_textinputdefault/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_TextInputDefault.  |
| [set_TextInputFormat](./set_textinputformat/)(const System::String &) | Setter for Aspose::Words::Fields::FormField::get_TextInputFormat.  |
| [set_TextInputType](./set_textinputtype/)(Aspose::Words::Fields::TextFormFieldType) | Setter for Aspose::Words::Fields::FormField::get_TextInputType.  |
| [SetTextInputValue](./settextinputvalue/)(const System::SharedPtr< System::Object > &) | Applies the text format specified in TextInputFormat and stores the value in Result.  |
