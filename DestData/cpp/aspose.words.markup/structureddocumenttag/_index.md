---
title: StructuredDocumentTag
second_title: Aspose.Words for C++ API Reference
description: Represents a structured document tag (SDT or content control) in a document. 
type: docs
weight: 0
url: /cpp/aspose.words.markup/structureddocumenttag/
---
## StructuredDocumentTag class


Represents a structured document tag (SDT or content control) in a document. 

## Methods

| Method | Description |
| --- | --- |
| [Accept](./accept/)(System::SharedPtr\<Aspose::Words::DocumentVisitor\>) override | Accepts a visitor.  |
| [AppendChild](../../aspose.words/compositenode/appendchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the end of the list of child nodes for this node.  |
| [Clear](./clear/)() | Clears contents of this structured document tag and displays a placeholder if it is defined.  |
| [Clone](../../aspose.words/node/clone/)(bool) | Creates a duplicate of the node.  |
| [get_Appearance](./get_appearance/)() const | Gets/sets the appearance of a structured document tag.  |
| [get_BuildingBlockCategory](./get_buildingblockcategory/)() | Specifies category of building block for this **SDT** node. Can not be null.  |
| [get_BuildingBlockGallery](./get_buildingblockgallery/)() | Specifies type of building block for this **SDT**. Can not be null.  |
| [get_CalendarType](./get_calendartype/)() | Specifies the type of calendar for this **SDT**. Default is Default |
| [get_Checked](./get_checked/)() | Gets/Sets current state of the Checkbox **SDT**. Default value for this property is false.  |
| [get_ChildNodes](../../aspose.words/compositenode/get_childnodes/)() | Gets all immediate child nodes of this node.  |
| [get_Color](./get_color/)() override | Gets or sets the color of the structured document tag.  |
| [get_ContentsFont](./get_contentsfont/)() | Font formatting that will be applied to text entered into **SDT**.  |
| [get_Count](../../aspose.words/compositenode/get_count/)() | Gets the number of immediate children of this node.  |
| [get_CustomNodeId](../../aspose.words/node/get_customnodeid/)() const | Specifies custom node identifier.  |
| [get_DateDisplayFormat](./get_datedisplayformat/)() | String that represents the format in which dates are displayed. Can not be null.  |
| [get_DateDisplayLocale](./get_datedisplaylocale/)() | Allows to set/get the language format for the date displayed in this **SDT**.  |
| [get_DateStorageFormat](./get_datestorageformat/)() | Gets/sets format in which the date for a date SDT is stored when the **SDT** is bound to an XML node in the document's data store. Default value is DateTime |
| virtual [get_Document](../../aspose.words/node/get_document/)() const | Gets the document to which this node belongs.  |
| [get_EndCharacterFont](./get_endcharacterfont/)() | Font formatting that will be applied to the last character of text entered into **SDT**.  |
| [get_FirstChild](../../aspose.words/compositenode/get_firstchild/)() const | Gets the first child of the node.  |
| [get_FullDate](./get_fulldate/)() | Specifies the full date and time last entered into this **SDT**.  |
| [get_HasChildNodes](../../aspose.words/compositenode/get_haschildnodes/)() | Returns true if this node has any child nodes.  |
| [get_Id](./get_id/)() override | Specifies a unique read-only persistent numerical Id for this **SDT**.  |
| [get_IsComposite](../../aspose.words/compositenode/get_iscomposite/)() override | Returns true as this node can have child nodes.  |
| [get_IsShowingPlaceholderText](./get_isshowingplaceholdertext/)() override | Specifies whether the content of this **SDT** shall be interpreted to contain placeholder text (as opposed to regular text contents within the SDT). if set to true, this state shall be resumed (showing placeholder text) upon opening this document.  |
| [get_IsTemporary](./get_istemporary/)() const | Specifies whether this **SDT** shall be removed from the WordProcessingML document when its contents are modified.  |
| [get_LastChild](../../aspose.words/compositenode/get_lastchild/)() const | Gets the last child of the node.  |
| [get_Level](./get_level/)() const override | Gets the level at which this **SDT** occurs in the document tree.  |
| [get_ListItems](./get_listitems/)() | Gets SdtListItemCollection associated with this **SDT**.  |
| [get_LockContentControl](./get_lockcontentcontrol/)() override | When set to true, this property will prohibit a user from deleting this **SDT**.  |
| [get_LockContents](./get_lockcontents/)() override | When set to true, this property will prohibit a user from editing the contents of this **SDT**.  |
| [get_Multiline](./get_multiline/)() | Specifies whether this **SDT** allows multiple lines of text.  |
| [get_NextSibling](../../aspose.words/node/get_nextsibling/)() | Gets the node immediately following this node.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.StructuredDocumentTag**.  |
| [get_ParentNode](../../aspose.words/node/get_parentnode/)() | Gets the immediate parent of this node.  |
| [get_Placeholder](./get_placeholder/)() override | Gets the BuildingBlock containing placeholder text which should be displayed when this SDT run contents are empty, the associated mapped XML element is empty as specified via the XmlMapping element or the IsShowingPlaceholderText element is true.  |
| [get_PlaceholderName](./get_placeholdername/)() override | Gets or sets Name of the BuildingBlock containing placeholder text. BuildingBlock with this name Name has to be present in the GlossaryDocument otherwise InvalidOperationException will occur.  |
| [get_PreviousSibling](../../aspose.words/node/get_previoussibling/)() | Gets the node immediately preceding this node.  |
| [get_Range](../../aspose.words/node/get_range/)() | Returns a **Range** object that represents the portion of a document that is contained in this node.  |
| [get_SdtType](./get_sdttype/)() override | Gets type of this **Structured document tag**.  |
| [get_Style](./get_style/)() | Gets or sets the Style of the structured document tag.  |
| [get_StyleName](./get_stylename/)() | Gets or sets the name of the style applied to the structured document tag.  |
| [get_Tag](./get_tag/)() const override | Specifies a tag associated with the current SDT node. Can not be null.  |
| [get_Title](./get_title/)() const override | Specifies the friendly name associated with this **SDT**. Can not be null.  |
| [get_WordOpenXML](./get_wordopenxml/)() override | Gets a string that represents the XML contained within the node in the FlatOpc format.  |
| [get_XmlMapping](./get_xmlmapping/)() override | Gets an object that represents the mapping of this structured document tag to XML data in a custom XML part of the current document.  |
| [GetAncestor](../../aspose.words/node/getancestor/)(Aspose::Words::NodeType) | Gets the first ancestor of the specified NodeType.  |
| [GetAncestorOf](../../aspose.words/node/getancestorof/)() |  |
| [GetChild](../../aspose.words/compositenode/getchild/)(Aspose::Words::NodeType, int32_t, bool) | Returns an Nth child node that matches the specified type.  |
| [GetChildNodes](../../aspose.words/compositenode/getchildnodes/)(Aspose::Words::NodeType, bool) | Returns a live collection of child nodes that match the specified type.  |
| [GetEnumerator](../../aspose.words/compositenode/getenumerator/)() override | Provides support for the for each style iteration over the child nodes of this node.  |
| [GetText](../../aspose.words/compositenode/gettext/)() override | Gets the text of this node and of all its children.  |
| [IndexOf](../../aspose.words/compositenode/indexof/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Returns the index of the specified child node in the child node array.  |
| [InsertAfter](../../aspose.words/compositenode/insertafter/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately after the specified reference node.  |
| [InsertBefore](../../aspose.words/compositenode/insertbefore/)(const System::SharedPtr\<Aspose::Words::Node\>\&, const System::SharedPtr\<Aspose::Words::Node\>\&) | Inserts the specified node immediately before the specified reference node.  |
| [NextPreOrder](../../aspose.words/node/nextpreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets next node according to the pre-order tree traversal algorithm.  |
| static [NodeTypeToString](../../aspose.words/node/nodetypetostring/)(Aspose::Words::NodeType) | A utility method that converts a node type enum value into a user friendly string.  |
| [PrependChild](../../aspose.words/compositenode/prependchild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Adds the specified node to the beginning of the list of child nodes for this node.  |
| [PreviousPreOrder](../../aspose.words/node/previouspreorder/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Gets the previous node according to the pre-order tree traversal algorithm.  |
| [Remove](../../aspose.words/node/remove/)() | Removes itself from the parent.  |
| [RemoveAllChildren](../../aspose.words/compositenode/removeallchildren/)() | Removes all the child nodes of the current node.  |
| [RemoveChild](../../aspose.words/compositenode/removechild/)(const System::SharedPtr\<Aspose::Words::Node\>\&) | Removes the specified child node.  |
| [RemoveSelfOnly](./removeselfonly/)() | Removes just this SDT node itself, but keeps the content of it inside the document tree.  |
| [RemoveSmartTags](../../aspose.words/compositenode/removesmarttags/)() | Removes all SmartTag descendant nodes of the current node.  |
| [SelectNodes](../../aspose.words/compositenode/selectnodes/)(const System::String\&) | Selects a list of nodes matching the XPath expression.  |
| [SelectSingleNode](../../aspose.words/compositenode/selectsinglenode/)(const System::String\&) | Selects the first Node that matches the XPath expression.  |
| [set_Appearance](./set_appearance/)(Aspose::Words::Markup::SdtAppearance) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Appearance.  |
| [set_BuildingBlockCategory](./set_buildingblockcategory/)(const System::String\&) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_BuildingBlockCategory.  |
| [set_BuildingBlockGallery](./set_buildingblockgallery/)(const System::String\&) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_BuildingBlockGallery.  |
| [set_CalendarType](./set_calendartype/)(Aspose::Words::Markup::SdtCalendarType) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_CalendarType.  |
| [set_Checked](./set_checked/)(bool) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Checked.  |
| [set_Color](./set_color/)(System::Drawing::Color) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Color.  |
| [set_CustomNodeId](../../aspose.words/node/set_customnodeid/)(int32_t) | Setter for Aspose::Words::Node::get_CustomNodeId.  |
| [set_DateDisplayFormat](./set_datedisplayformat/)(const System::String\&) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_DateDisplayFormat.  |
| [set_DateDisplayLocale](./set_datedisplaylocale/)(int32_t) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_DateDisplayLocale.  |
| [set_DateStorageFormat](./set_datestorageformat/)(Aspose::Words::Markup::SdtDateStorageFormat) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_DateStorageFormat.  |
| [set_FullDate](./set_fulldate/)(System::DateTime) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_FullDate.  |
| [set_IsShowingPlaceholderText](./set_isshowingplaceholdertext/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_IsShowingPlaceholderText.  |
| [set_IsTemporary](./set_istemporary/)(bool) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_IsTemporary.  |
| [set_LockContentControl](./set_lockcontentcontrol/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_LockContentControl.  |
| [set_LockContents](./set_lockcontents/)(bool) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_LockContents.  |
| [set_Multiline](./set_multiline/)(bool) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Multiline.  |
| [set_PlaceholderName](./set_placeholdername/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_PlaceholderName.  |
| [set_Style](./set_style/)(const System::SharedPtr\<Aspose::Words::Style\>\&) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Style.  |
| [set_StyleName](./set_stylename/)(const System::String\&) | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_StyleName.  |
| [set_Tag](./set_tag/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Tag.  |
| [set_Title](./set_title/)(System::String) override | Setter for Aspose::Words::Markup::StructuredDocumentTag::get_Title.  |
| [SetCheckedSymbol](./setcheckedsymbol/)(int32_t, const System::String\&) | Sets the symbol used to represent the checked state of a check box content control.  |
| [SetTemplateWeakPtr](../../aspose.words/compositenode/settemplateweakptr/)(uint32_t) override |  |
| [SetUncheckedSymbol](./setuncheckedsymbol/)(int32_t, const System::String\&) | Sets the symbol used to represent the unchecked state of a check box content control.  |
| [StructuredDocumentTag](./structureddocumenttag/)(const System::SharedPtr\<Aspose::Words::DocumentBase\>\&, Aspose::Words::Markup::SdtType, Aspose::Words::Markup::MarkupLevel) | Initializes a new instance of the **Structured document tag** class.  |
| [ToString](../../aspose.words/node/tostring/)(Aspose::Words::SaveFormat) | Exports the content of the node into a string in the specified format.  |
| [ToString](../../aspose.words/node/tostring/)(const System::SharedPtr\<Aspose::Words::Saving::SaveOptions\>\&) | Exports the content of the node into a string using the specified save options.  |
