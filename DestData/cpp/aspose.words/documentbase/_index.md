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
| [get_BackgroundShape](./get_backgroundshape/)() const | Gets or sets the background shape of the document. Can be null.  |
| [get_Document](./get_document/)() const override | Gets the document to which this node belongs.  |
| [get_FontInfos](./get_fontinfos/)() const | Provides access to properties of fonts used in this document.  |
| [get_Lists](./get_lists/)() const | Provides access to the list formatting used in the document.  |
| [get_NodeChangingCallback](./get_nodechangingcallback/)() | Called when a node is inserted or removed in the document.  |
| [get_PageColor](./get_pagecolor/)() | Gets or sets the page color of the document. This property is a simpler version of BackgroundShape.  |
| [get_ResourceLoadingCallback](./get_resourceloadingcallback/)() const | Allows to control how external resources are loaded.  |
| [get_Styles](./get_styles/)() const | Returns a collection of styles defined in the document.  |
| [get_WarningCallback](./get_warningcallback/)() const | Called during various document processing procedures when an issue is detected that might result in data or formatting fidelity loss.  |
| [ImportNode](./importnode/)(const System::SharedPtr< Aspose::Words::Node > &, bool) | Imports a node from another document to the current document.  |
| [ImportNode](./importnode/)(const System::SharedPtr< Aspose::Words::Node > &, bool, Aspose::Words::ImportFormatMode) | Imports a node from another document to the current document with an option to control formatting.  |
| [set_BackgroundShape](./set_backgroundshape/)(const System::SharedPtr< Aspose::Words::Drawing::Shape > &) | Setter for Aspose::Words::DocumentBase::get_BackgroundShape.  |
| [set_NodeChangingCallback](./set_nodechangingcallback/)(const System::SharedPtr< Aspose::Words::INodeChangingCallback > &) | Setter for Aspose::Words::DocumentBase::get_NodeChangingCallback.  |
| [set_PageColor](./set_pagecolor/)(System::Drawing::Color) | Setter for Aspose::Words::DocumentBase::get_PageColor.  |
| [set_ResourceLoadingCallback](./set_resourceloadingcallback/)(const System::SharedPtr< Aspose::Words::Loading::IResourceLoadingCallback > &) | Setter for Aspose::Words::DocumentBase::get_ResourceLoadingCallback.  |
| [set_WarningCallback](./set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::DocumentBase::get_WarningCallback.  |
