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
| [Accept](./accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) override | Accepts a visitor. |
| [Clone](../../aspose.words/node/clone/)(bool) | Creates a duplicate of the node. |
| [get_CalculateOnExit](./get_calculateonexit/)() | True if references to the specified form field are automatically updated whenever the field is exited. |
| [get_CheckBoxSize](./get_checkboxsize/)() | Gets or sets the size of the checkbox in points. Has effect only when [IsCheckBoxExactSize](./get_ischeckboxexactsize/) is true. |
| [get_Checked](./get_checked/)() | Gets or sets the checked status of the check box form field. Default value for this property is **false**. |
| [get_CustomNodeId](../../aspose.words/node/get_customnodeid/)() const | Specifies custom node identifier. |
| [get_Default](./get_default/)() | Gets or sets the default value of the check box form field. Default value for this property is **false**. |
| virtual [get_Document](../../aspose.words/node/get_document/)() const | Gets the document to which this node belongs. |
| [get_DropDownItems](./get_dropdownitems/)() | Provides access to the items of a dropdown form field. |
| [get_DropDownSelectedIndex](./get_dropdownselectedindex/)() | Gets or sets the index specifying the currently selected item in a dropdown form field. |
| [get_Enabled](./get_enabled/)() | True if a form field is enabled. |
| [get_EntryMacro](./get_entrymacro/)() | Returns or sets an entry macro name for the form field. |
| [get_ExitMacro](./get_exitmacro/)() | Returns or sets an exit macro name for the form field. |
| [get_Font](../../aspose.words/inline/get_font/)() | Provides access to the font formatting of this object. |
| [get_HelpText](./get_helptext/)() | Returns or sets the text that's displayed in a message box when the form field has the focus and the user presses F1. |
| [get_IsCheckBoxExactSize](./get_ischeckboxexactsize/)() | Gets or sets the boolean value that indicates whether the size of the textbox is automatic or specified explicitly. |
| virtual [get_IsComposite](../../aspose.words/node/get_iscomposite/)() | Returns true if this node can contain other nodes. |
| [get_IsDeleteRevision](../../aspose.words/inline/get_isdeleterevision/)() | Returns true if this object was deleted in Microsoft Word while change tracking was enabled. |
| [get_IsFormatRevision](../../aspose.words/inline/get_isformatrevision/)() | Returns true if formatting of the object was changed in Microsoft Word while change tracking was enabled. |
| [get_IsInsertRevision](../../aspose.words/inline/get_isinsertrevision/)() | Returns true if this object was inserted in Microsoft Word while change tracking was enabled. |
| [get_IsMoveFromRevision](../../aspose.words/inline/get_ismovefromrevision/)() | Returns **true** if this object was moved (deleted) in Microsoft Word while change tracking was enabled. |
| [get_IsMoveToRevision](../../aspose.words/inline/get_ismovetorevision/)() | Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled. |
| [get_MaxLength](./get_maxlength/)() | Maximum length for the text field. Zero when the length is not limited. |
| [get_Name](./get_name/)() | Gets or sets the form field name. |
| [get_NextSibling](../../aspose.words/node/get_nextsibling/)() | Gets the node immediately following this node. |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.FormField**. |
| [get_OwnHelp](./get_ownhelp/)() | Specifies the source of the text that's displayed in a message box when a form field has the focus and the user presses F1. |
| [get_OwnStatus](./get_ownstatus/)() | Specifies the source of the text that's displayed in the status bar when a form field has the focus. |
| [get_ParentNode](../../aspose.words/node/get_parentnode/)() | Gets the immediate parent of this node. |
| [get_ParentParagraph](../../aspose.words/inline/get_parentparagraph/)() | Retrieves the parent [Paragraph](../../aspose.words/paragraph/) of this node. |
| [get_PreviousSibling](../../aspose.words/node/get_previoussibling/)() | Gets the node immediately preceding this node. |
| [get_Range](../../aspose.words/node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node. |
| [get_Result](./get_result/)() | Gets or sets a string that represents the result of this form field. |
| [get_StatusText](./get_statustext/)() | Returns or sets the text that's displayed in the status bar when a form field has the focus. |
| [get_TextInputDefault](./get_textinputdefault/)() | Gets or sets the default string or a calculation expression of a text form field. |
| [get_TextInputFormat](./get_textinputformat/)() | Returns or sets the text formatting for a text form field. |
| [get_TextInputType](./get_textinputtype/)() | Gets or sets the type of a text form field. |
| [get_Type](./get_type/)() | Returns the form field type. |
| [GetAncestor](../../aspose.words/node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified [NodeType](../../aspose.words/nodetype/). |
| [GetAncestorOf](../../aspose.words/node/getancestorof/)() |  |
| [GetText](../../aspose.words/specialchar/gettext/)() override | Gets the special character that this node represents. |
| [NextPreOrder](../../aspose.words/node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm. |
| static [NodeTypeToString](../../aspose.words/node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string. |
| [PreviousPreOrder](../../aspose.words/node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm. |
| [Remove](../../aspose.words/node/remove/)() | Removes itself from the parent. |
| [RemoveField](./removefield/)() | Removes the complete form field, not just the form field special character. |
| [set_CalculateOnExit](./set_calculateonexit/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_CalculateOnExit](./get_calculateonexit/). |
| [set_CheckBoxSize](./set_checkboxsize/)(double) | Setter for [Aspose::Words::Fields::FormField::get_CheckBoxSize](./get_checkboxsize/). |
| [set_Checked](./set_checked/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_Checked](./get_checked/). |
| [set_CustomNodeId](../../aspose.words/node/set_customnodeid/)(int32_t) | Setter for [Aspose::Words::Node::get_CustomNodeId](../../aspose.words/node/get_customnodeid/). |
| [set_Default](./set_default/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_Default](./get_default/). |
| [set_DropDownSelectedIndex](./set_dropdownselectedindex/)(int32_t) | Setter for [Aspose::Words::Fields::FormField::get_DropDownSelectedIndex](./get_dropdownselectedindex/). |
| [set_Enabled](./set_enabled/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_Enabled](./get_enabled/). |
| [set_EntryMacro](./set_entrymacro/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_EntryMacro](./get_entrymacro/). |
| [set_ExitMacro](./set_exitmacro/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_ExitMacro](./get_exitmacro/). |
| [set_HelpText](./set_helptext/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_HelpText](./get_helptext/). |
| [set_IsCheckBoxExactSize](./set_ischeckboxexactsize/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_IsCheckBoxExactSize](./get_ischeckboxexactsize/). |
| [set_MaxLength](./set_maxlength/)(int32_t) | Setter for [Aspose::Words::Fields::FormField::get_MaxLength](./get_maxlength/). |
| [set_Name](./set_name/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_Name](./get_name/). |
| [set_OwnHelp](./set_ownhelp/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_OwnHelp](./get_ownhelp/). |
| [set_OwnStatus](./set_ownstatus/)(bool) | Setter for [Aspose::Words::Fields::FormField::get_OwnStatus](./get_ownstatus/). |
| [set_Result](./set_result/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_Result](./get_result/). |
| [set_StatusText](./set_statustext/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_StatusText](./get_statustext/). |
| [set_TextInputDefault](./set_textinputdefault/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_TextInputDefault](./get_textinputdefault/). |
| [set_TextInputFormat](./set_textinputformat/)(const System::String\&) | Setter for [Aspose::Words::Fields::FormField::get_TextInputFormat](./get_textinputformat/). |
| [set_TextInputType](./set_textinputtype/)(Aspose::Words::Fields::TextFormFieldType) | Setter for [Aspose::Words::Fields::FormField::get_TextInputType](./get_textinputtype/). |
| [SetTextInputValue](./settextinputvalue/)(const System::SharedPtr\<System::Object\>\&) | Applies the text format specified in [TextInputFormat](./get_textinputformat/) and stores the value in [Result](./get_result/). |
| [ToString](../../aspose.words/node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format. |
| [ToString](../../aspose.words/node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options. |
