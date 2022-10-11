---
title: DocumentBase
second_title: Aspose.Words for C++ API Reference
description: Provides the abstract base class for a main document and a glossary document of a Word document. 
type: docs
weight: 0
url: /cpp/aspose.words/documentbase/
---
## DocumentBase class


Provides the abstract base class for a main document and a glossary document of a Word document. 

## Methods

| Method | Description |
| --- | --- |
| System::SharedPtr< Aspose::Words::Drawing::Shape > [get_BackgroundShape](./get_backgroundshape/)() const | Gets or sets the background shape of the document. Can be null.  |
| System::SharedPtr< Aspose::Words::DocumentBase > [get_Document](./get_document/)() const override | Gets the document to which this node belongs.  |
| System::SharedPtr< Aspose::Words::Fonts::FontInfoCollection > [get_FontInfos](./get_fontinfos/)() const | Provides access to properties of fonts used in this document.  |
| System::SharedPtr< Aspose::Words::Lists::ListCollection > [get_Lists](./get_lists/)() const | Provides access to the list formatting used in the document.  |
| System::SharedPtr< Aspose::Words::INodeChangingCallback > [get_NodeChangingCallback](./get_nodechangingcallback/)() | Called when a node is inserted or removed in the document.  |
| System::Drawing::Color [get_PageColor](./get_pagecolor/)() | Gets or sets the page color of the document. This property is a simpler version of BackgroundShape.  |
| System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > [get_ResourceLoadingCallback](./get_resourceloadingcallback/)() const | Allows to control how external resources are loaded.  |
| System::SharedPtr< Aspose::Words::StyleCollection > [get_Styles](./get_styles/)() const | Returns a collection of styles defined in the document.  |
| System::SharedPtr< Aspose::Words::IWarningCallback > [get_WarningCallback](./get_warningcallback/)() const | Called during various document processing procedures when an issue is detected that might result in data or formatting fidelity loss.  |
| System::SharedPtr< Aspose::Words::Node > [ImportNode](./importnode/)(const System::SharedPtr< Aspose::Words::Node > &, bool) | Imports a node from another document to the current document.  |
| System::SharedPtr< Aspose::Words::Node > [ImportNode](./importnode/)(const System::SharedPtr< Aspose::Words::Node > &, bool, Aspose::Words::ImportFormatMode) | Imports a node from another document to the current document with an option to control formatting.  |
| void [set_BackgroundShape](./set_backgroundshape/)(const System::SharedPtr< Aspose::Words::Drawing::Shape > &) | Setter for Aspose::Words::DocumentBase::get_BackgroundShape.  |
| void [set_NodeChangingCallback](./set_nodechangingcallback/)(const System::SharedPtr< Aspose::Words::INodeChangingCallback > &) | Setter for Aspose::Words::DocumentBase::get_NodeChangingCallback.  |
| void [set_PageColor](./set_pagecolor/)(System::Drawing::Color) | Setter for Aspose::Words::DocumentBase::get_PageColor.  |
| void [set_ResourceLoadingCallback](./set_resourceloadingcallback/)(const System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > &) | Setter for Aspose::Words::DocumentBase::get_ResourceLoadingCallback.  |
| void [set_WarningCallback](./set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::DocumentBase::get_WarningCallback.  |
