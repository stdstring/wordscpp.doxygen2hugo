---
title: Aspose::Words::WebExtensions::WebExtensionBinding::WebExtensionBinding constructor
linktitle: WebExtensionBinding
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::WebExtensions::WebExtensionBinding::WebExtensionBinding constructor. Creates web extension binding with specified parameters in C++.
type: docs
weight: 100
url: /cpp/aspose.words.webextensions/webextensionbinding/webextensionbinding/
---
## WebExtensionBinding::WebExtensionBinding constructor


Creates web extension binding with specified parameters.

```cpp
Aspose::Words::WebExtensions::WebExtensionBinding::WebExtensionBinding(const System::String &id, Aspose::Words::WebExtensions::WebExtensionBindingType bindingType, const System::String &appRef)
```


| Parameter | Type | Description |
| --- | --- | --- |
| id | const System::String\& | Binding identifier. |
| bindingType | Aspose::Words::WebExtensions::WebExtensionBindingType | Binding type. |
| appRef | const System::String\& | Binding key used to map the binding entry in this list with the bound data in the document. |

## Examples



Shows how to add a web extension to a document. 
```cpp
auto doc = MakeObject<Document>();

// Create task pane with "MyScript" add-in, which will be used by the document,
// then set its default location.
auto myScriptTaskPane = MakeObject<TaskPane>();
doc->get_WebExtensionTaskPanes()->Add(myScriptTaskPane);
myScriptTaskPane->set_DockState(TaskPaneDockState::Right);
myScriptTaskPane->set_IsVisible(true);
myScriptTaskPane->set_Width(300);
myScriptTaskPane->set_IsLocked(true);

// If there are multiple task panes in the same docking location, we can set this index to arrange them.
myScriptTaskPane->set_Row(1);

// Create an add-in called "MyScript Math Sample", which the task pane will display within.
SharedPtr<WebExtension> webExtension = myScriptTaskPane->get_WebExtension();

// Set application store reference parameters for our add-in, such as the ID.
webExtension->get_Reference()->set_Id(u"WA104380646");
webExtension->get_Reference()->set_Version(u"1.0.0.0");
webExtension->get_Reference()->set_StoreType(WebExtensionStoreType::OMEX);
webExtension->get_Reference()->set_Store(System::Globalization::CultureInfo::get_CurrentCulture()->get_Name());
webExtension->get_Properties()->Add(MakeObject<WebExtensionProperty>(u"MyScript", u"MyScript Math Sample"));
webExtension->get_Bindings()->Add(MakeObject<WebExtensionBinding>(u"MyScript", WebExtensionBindingType::Text, u"104380646"));

// Allow the user to interact with the add-in.
webExtension->set_IsFrozen(false);

// We can access the web extension in Microsoft Word via Developer -> Add-ins.
doc->Save(ArtifactsDir + u"Document.WebExtension.docx");

// Remove all web extension task panes at once like this.
doc->get_WebExtensionTaskPanes()->Clear();

ASSERT_EQ(0, doc->get_WebExtensionTaskPanes()->get_Count());
```

## See Also

* Enum [WebExtensionBindingType](../../webextensionbindingtype/)
* Class [WebExtensionBinding](../)
* Namespace [Aspose::Words::WebExtensions](../../)
* Library [Aspose.Words for C++](../../../)
