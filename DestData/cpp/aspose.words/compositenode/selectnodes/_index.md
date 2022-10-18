---
title: SelectNodes
second_title: Aspose.Words for C++ API Reference
description: Selects a list of nodes matching the XPath expression. 
type: docs
weight: 0
url: /cpp/aspose.words/compositenode/selectnodes/
---
## CompositeNode.SelectNodes method


Selects a list of nodes matching the XPath expression.

```cpp
System::SharedPtr<Aspose::Words::NodeList> Aspose::Words::CompositeNode::SelectNodes(const System::String &xpath)
```


| Parameter | Type | Description |
| --- | --- | --- |
| xpath | `-` | The XPath expression. |

### ReturnValue


A list of nodes matching the XPath query.

Only expressions with element names are supported at the moment. Expressions that use attribute names are not supported.


