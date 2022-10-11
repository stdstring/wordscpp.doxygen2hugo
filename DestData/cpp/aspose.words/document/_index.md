---
title: Document
second_title: Aspose.Words for C++ API Reference
description: Represents a Word document. 
type: docs
weight: 0
url: /cpp/aspose.words/document/
---
## Document class


Represents a Word document. 

## Methods

| Method | Description |
| --- | --- |
| [Document](./document/)() | Creates a blank Word document.  |
| [Document](./document/)(const System::SharedPtr< System::IO::Stream > &) | Opens an existing document from a stream. Automatically detects the file format.  |
| [Document](./document/)(const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< Aspose::Words::Loading::LoadOptions > &) | Opens an existing document from a stream. Allows to specify additional options such as an encryption password.  |
| [Document](./document/)(const System::String &) | Opens an existing document from a file. Automatically detects the file format.  |
| [Document](./document/)(const System::String &, const System::SharedPtr< Aspose::Words::Loading::LoadOptions > &) | Opens an existing document from a file. Allows to specify additional options such as an encryption password.  |
| [Document](./document/)(std::istream &) |  |
| [Document](./document/)(std::istream &, const System::SharedPtr< Aspose::Words::Loading::LoadOptions > &) |  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [AcceptAllRevisions](./acceptallrevisions/)() | Accepts all tracked changes in the document.  |
| [AppendDocument](./appenddocument/)(const System::SharedPtr< Aspose::Words::Document > &, Aspose::Words::ImportFormatMode) | Appends the specified document to the end of this document.  |
| [AppendDocument](./appenddocument/)(const System::SharedPtr< Aspose::Words::Document > &, Aspose::Words::ImportFormatMode, const System::SharedPtr< Aspose::Words::ImportFormatOptions > &) | Appends the specified document to the end of this document.  |
| [Cleanup](./cleanup/)() | Cleans unused styles and lists from the document.  |
| [Cleanup](./cleanup/)(const System::SharedPtr< Aspose::Words::CleanupOptions > &) | Cleans unused styles and lists from the document depending on given CleanupOptions.  |
| [Clone](./clone/)() | Performs a deep copy of the Document.  |
| [Compare](./compare/)(const System::SharedPtr< Aspose::Words::Document > &, const System::String &, System::DateTime) | Compares this document with another document producing changes as number of edit and format revisions Revision.  |
| [Compare](./compare/)(const System::SharedPtr< Aspose::Words::Document > &, const System::String &, System::DateTime, const System::SharedPtr< Aspose::Words::Comparing::CompareOptions > &) | Compares this document with another document producing changes as a number of edit and format revisions Revision. Allows to specify comparison options using CompareOptions.  |
| [CopyStylesFromTemplate](./copystylesfromtemplate/)(const System::SharedPtr< Aspose::Words::Document > &) | Copies styles from the specified template to a document.  |
| [CopyStylesFromTemplate](./copystylesfromtemplate/)(const System::String &) | Copies styles from the specified template to a document.  |
| [EnsureMinimum](./ensureminimum/)() | If the document contains no sections, creates one section with one paragraph.  |
| [ExpandTableStylesToDirectFormatting](./expandtablestylestodirectformatting/)() | Converts formatting specified in table styles into direct formatting on tables in the document.  |
| [ExtractPages](./extractpages/)(int32_t, int32_t) | Returns the Document object representing specified range of pages.  |
| [get_AttachedTemplate](./get_attachedtemplate/)() | Gets or sets the full path of the template attached to the document.  |
| [get_AutomaticallyUpdateStyles](./get_automaticallyupdatestyles/)() | Gets or sets a flag indicating whether the styles in the document are updated to match the styles in the attached template each time the document is opened in MS Word.  |
| [get_BuiltInDocumentProperties](./get_builtindocumentproperties/)() const | Returns a collection that represents all the built-in document properties of the document.  |
| [get_CompatibilityOptions](./get_compatibilityoptions/)() | Provides access to document compatibility options (that is, the user preferences entered on the **Compatibility** tab of the **Options** dialog in Word).  |
| [get_Compliance](./get_compliance/)() | Gets the OOXML compliance version determined from the loaded document content. Makes sense only for OOXML documents.  |
| [get_CustomDocumentProperties](./get_customdocumentproperties/)() | Returns a collection that represents all the custom document properties of the document.  |
| [get_CustomXmlParts](./get_customxmlparts/)() const | Gets or sets the collection of Custom XML Data Storage Parts.  |
| [get_DefaultTabStop](./get_defaulttabstop/)() | Gets or sets the interval (in points) between the default tab stops.  |
| [get_DigitalSignatures](./get_digitalsignatures/)() const | Gets the collection of digital signatures for this document and their validation results.  |
| [get_EndnoteOptions](./get_endnoteoptions/)() | Provides options that control numbering and positioning of endnotes in this document.  |
| [get_FieldOptions](./get_fieldoptions/)() | Gets a **FieldOptions** object that represents options to control field handling in the document.  |
| [get_FirstSection](./get_firstsection/)() | Gets the first section in the document.  |
| [get_FontSettings](./get_fontsettings/)() const | Gets or sets document font settings.  |
| [get_FootnoteOptions](./get_footnoteoptions/)() | Provides options that control numbering and positioning of footnotes in this document.  |
| [get_Frameset](./get_frameset/)() const | Returns a Frameset instance if this document represents a frames page.  |
| [get_GlossaryDocument](./get_glossarydocument/)() const | Gets or sets the glossary document within this document or template. A glossary document is a storage for AutoText, AutoCorrect and Building Block entries defined in a document.  |
| [get_GrammarChecked](./get_grammarchecked/)() | Returns **true** if the document has been checked for grammar.  |
| [get_HasMacros](./get_hasmacros/)() | Returns **true** if the document has a VBA project (macros).  |
| [get_HasRevisions](./get_hasrevisions/)() | Returns **true** if the document has any tracked changes.  |
| [get_HyphenationOptions](./get_hyphenationoptions/)() | Provides access to document hyphenation options.  |
| [get_LastSection](./get_lastsection/)() | Gets the last section in the document.  |
| [get_LayoutOptions](./get_layoutoptions/)() const | Gets a **LayoutOptions** object that represents options to control the layout process of this document.  |
| [get_MailMerge](./get_mailmerge/)() | Returns a **MailMerge** object that represents the mail merge functionality for the document.  |
| [get_MailMergeSettings](./get_mailmergesettings/)() | Gets or sets the object that contains all of the mail merge information for a document.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Document**.  |
| [get_OriginalFileName](./get_originalfilename/)() const | Gets the original file name of the document.  |
| [get_OriginalLoadFormat](./get_originalloadformat/)() const | Gets the format of the original document that was loaded into this object.  |
| [get_PackageCustomParts](./get_packagecustomparts/)() const | Gets or sets the collection of custom parts (arbitrary content) that are linked to the OOXML package using "unknown relationships".  |
| [get_PageCount](./get_pagecount/)() | Gets the number of pages in the document as calculated by the most recent page layout operation.  |
| [get_ProtectionType](./get_protectiontype/)() | Gets the currently active document protection type.  |
| [get_RemovePersonalInformation](./get_removepersonalinformation/)() | Gets or sets a flag indicating that Microsoft Word will remove all user information from comments, revisions and document properties upon saving the document.  |
| [get_Revisions](./get_revisions/)() | Gets a collection of revisions (tracked changes) that exist in this document.  |
| [get_RevisionsView](./get_revisionsview/)() const | Gets or sets a value indicating whether to work with the original or revised version of a document.  |
| [get_Sections](./get_sections/)() | Returns a collection that represents all sections in the document.  |
| [get_ShadeFormData](./get_shadeformdata/)() | Specifies whether to turn on the gray shading on form fields.  |
| [get_ShowGrammaticalErrors](./get_showgrammaticalerrors/)() | Specifies whether to display grammar errors in this document.  |
| [get_ShowSpellingErrors](./get_showspellingerrors/)() | Specifies whether to display spelling errors in this document.  |
| [get_SpellingChecked](./get_spellingchecked/)() | Returns **true** if the document has been checked for spelling.  |
| [get_Theme](./get_theme/)() | Gets the Theme object for this document.  |
| [get_TrackRevisions](./get_trackrevisions/)() | **True** if changes are tracked when this document is edited in Microsoft Word.  |
| [get_Variables](./get_variables/)() | Returns the collection of variables added to a document or template.  |
| [get_VbaProject](./get_vbaproject/)() const | Gets or sets a VbaProject.  |
| [get_VersionsCount](./get_versionscount/)() | Gets the number of document versions that was stored in the DOC document.  |
| [get_ViewOptions](./get_viewoptions/)() | Provides options to control how the document is displayed in Microsoft Word.  |
| [get_Watermark](./get_watermark/)() | Provides access to the document watermark.  |
| [get_WebExtensionTaskPanes](./get_webextensiontaskpanes/)() const | Returns a collection that represents a list of task pane add-ins.  |
| [get_WriteProtection](./get_writeprotection/)() | Provides access to the document write protection options.  |
| [GetPageInfo](./getpageinfo/)(int32_t) | Gets the page size, orientation and other information about a page that might be useful for printing or rendering.  |
| [JoinRunsWithSameFormatting](./joinrunswithsameformatting/)() | Joins runs with same formatting in all paragraphs of the document.  |
| [NormalizeFieldTypes](./normalizefieldtypes/)() | Changes field type values FieldType of FieldStart, FieldSeparator, FieldEnd in the whole document so that they correspond to the field types contained in the field codes.  |
| [Protect](./protect/)(Aspose::Words::ProtectionType) | Protects the document from changes without changing the existing password or assigns a random password.  |
| [Protect](./protect/)(Aspose::Words::ProtectionType, const System::String &) | Protects the document from changes and optionally sets a protection password.  |
| [RemoveExternalSchemaReferences](./removeexternalschemareferences/)() | Removes external XML schema references from this document.  |
| [RemoveMacros](./removemacros/)() | Removes all macros (the VBA project) as well as toolbars and command customizations from the document.  |
| [RenderToScale](./rendertoscale/)(int32_t, const System::SharedPtr< System::Drawing::Graphics > &, float, float, float) | Renders a document page into a object to a specified scale.  |
| [RenderToSize](./rendertosize/)(int32_t, const System::SharedPtr< System::Drawing::Graphics > &, float, float, float, float) | Renders a document page into a object to a specified size.  |
| [Save](./save/)(const System::SharedPtr< System::IO::Stream > &, Aspose::Words::SaveFormat) | Saves the document to a stream using the specified format.  |
| [Save](./save/)(const System::SharedPtr< System::IO::Stream > &, const System::SharedPtr< Aspose::Words::Saving::SaveOptions > &) | Saves the document to a stream using the specified save options.  |
| [Save](./save/)(const System::String &) | Saves the document to a file. Automatically determines the save format from the extension.  |
| [Save](./save/)(const System::String &, Aspose::Words::SaveFormat) | Saves the document to a file in the specified format.  |
| [Save](./save/)(const System::String &, const System::SharedPtr< Aspose::Words::Saving::SaveOptions > &) | Saves the document to a file using the specified save options.  |
| [Save](./save/)(std::basic_ostream< CharType, Traits > &, Aspose::Words::SaveFormat) |  |
| [Save](./save/)(std::basic_ostream< CharType, Traits > &, System::SharedPtr< Aspose::Words::Saving::SaveOptions >) |  |
| [set_AttachedTemplate](./set_attachedtemplate/)(const System::String &) | Setter for Aspose::Words::Document::get_AttachedTemplate.  |
| [set_AutomaticallyUpdateStyles](./set_automaticallyupdatestyles/)(bool) | Setter for Aspose::Words::Document::get_AutomaticallyUpdateStyles.  |
| [set_CustomXmlParts](./set_customxmlparts/)(const System::SharedPtr< Aspose::Words::Markup::CustomXmlPartCollection > &) | Setter for Aspose::Words::Document::get_CustomXmlParts.  |
| [set_DefaultTabStop](./set_defaulttabstop/)(double) | Setter for Aspose::Words::Document::get_DefaultTabStop.  |
| [set_FontSettings](./set_fontsettings/)(const System::SharedPtr< Aspose::Words::Fonts::FontSettings > &) | Setter for Aspose::Words::Document::get_FontSettings.  |
| [set_GlossaryDocument](./set_glossarydocument/)(const System::SharedPtr< Aspose::Words::BuildingBlocks::GlossaryDocument > &) | Setter for Aspose::Words::Document::get_GlossaryDocument.  |
| [set_GrammarChecked](./set_grammarchecked/)(bool) | Setter for Aspose::Words::Document::get_GrammarChecked.  |
| [set_MailMergeSettings](./set_mailmergesettings/)(const System::SharedPtr< Aspose::Words::Settings::MailMergeSettings > &) | Setter for Aspose::Words::Document::get_MailMergeSettings.  |
| [set_PackageCustomParts](./set_packagecustomparts/)(const System::SharedPtr< Aspose::Words::Markup::CustomPartCollection > &) | Setter for Aspose::Words::Document::get_PackageCustomParts.  |
| [set_RemovePersonalInformation](./set_removepersonalinformation/)(bool) | Setter for Aspose::Words::Document::get_RemovePersonalInformation.  |
| [set_RevisionsView](./set_revisionsview/)(Aspose::Words::RevisionsView) | Setter for Aspose::Words::Document::get_RevisionsView.  |
| [set_ShadeFormData](./set_shadeformdata/)(bool) | Setter for Aspose::Words::Document::get_ShadeFormData.  |
| [set_ShowGrammaticalErrors](./set_showgrammaticalerrors/)(bool) | Setter for Aspose::Words::Document::get_ShowGrammaticalErrors.  |
| [set_ShowSpellingErrors](./set_showspellingerrors/)(bool) | Setter for Aspose::Words::Document::get_ShowSpellingErrors.  |
| [set_SpellingChecked](./set_spellingchecked/)(bool) | Setter for Aspose::Words::Document::get_SpellingChecked.  |
| [set_TrackRevisions](./set_trackrevisions/)(bool) | Setter for Aspose::Words::Document::get_TrackRevisions.  |
| [set_VbaProject](./set_vbaproject/)(const System::SharedPtr< Aspose::Words::Vba::VbaProject > &) | Setter for Aspose::Words::Document::get_VbaProject.  |
| [StartTrackRevisions](./starttrackrevisions/)(const System::String &) | Starts automatically marking all further changes you make to the document programmatically as revision changes.  |
| [StartTrackRevisions](./starttrackrevisions/)(const System::String &, System::DateTime) | Starts automatically marking all further changes you make to the document programmatically as revision changes.  |
| [StopTrackRevisions](./stoptrackrevisions/)() | Stops automatic marking of document changes as revisions.  |
| [UnlinkFields](./unlinkfields/)() | Unlinks fields in the whole document.  |
| [Unprotect](./unprotect/)() | Removes protection from the document regardless of the password.  |
| [Unprotect](./unprotect/)(const System::String &) | Removes protection from the document if a correct password is specified.  |
| [UpdateFields](./updatefields/)() | Updates the values of fields in the whole document.  |
| [UpdateListLabels](./updatelistlabels/)() | Updates list labels for all list items in the document.  |
| [UpdatePageLayout](./updatepagelayout/)() | Rebuilds the page layout of the document.  |
| [UpdateTableLayout](./updatetablelayout/)() |  |
| [UpdateThumbnail](./updatethumbnail/)() | Updates Thumbnail of the document using default options.  |
| [UpdateThumbnail](./updatethumbnail/)(const System::SharedPtr< Aspose::Words::Rendering::ThumbnailGeneratingOptions > &) | Updates Thumbnail of the document according to the specified options.  |
| [UpdateWordCount](./updatewordcount/)() | Updates word count properties of the document.  |
| [UpdateWordCount](./updatewordcount/)(bool) | Updates word count properties of the document, optionally updates Lines property.  |
