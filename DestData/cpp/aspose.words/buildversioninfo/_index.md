---
title: Aspose::Words::BuildVersionInfo class
linktitle: BuildVersionInfo
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::BuildVersionInfo class. Provides information about the current product name and version in C++.'
type: docs
weight: 900
url: /cpp/aspose.words/buildversioninfo/
---
## BuildVersionInfo class


Provides information about the current product name and version.

```cpp
class BuildVersionInfo
```

## Methods

| Method | Description |
| --- | --- |
| [BuildVersionInfo](./buildversioninfo/)() |  |
| static [get_Product](./get_product/)() | Gets the full name of the product. |
| static [get_Version](./get_version/)() | Gets the product version. |

## Examples



Shows how to display information about your installed version of Aspose.Words. 
```cpp
std::cout << "I am currently using " << BuildVersionInfo::get_Product() << ", version number " << BuildVersionInfo::get_Version() << "!" << std::endl;
```

## See Also

* Namespace [Aspose::Words](../)
* Library [Aspose.Words for C++](../../)
