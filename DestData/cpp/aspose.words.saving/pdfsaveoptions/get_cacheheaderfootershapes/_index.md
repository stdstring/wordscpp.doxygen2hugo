---
title: Aspose::Words::Saving::PdfSaveOptions::get_CacheHeaderFooterShapes method
linktitle: get_CacheHeaderFooterShapes
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Saving::PdfSaveOptions::get_CacheHeaderFooterShapes method. Gets or sets a value determining whether or not to cache shapes placed in header and footer of document in C++.'
type: docs
weight: 400
url: /cpp/aspose.words.saving/pdfsaveoptions/get_cacheheaderfootershapes/
---
## PdfSaveOptions::get_CacheHeaderFooterShapes method


Gets or sets a value determining whether or not to cache shapes placed in header and footer of document.

```cpp
bool Aspose::Words::Saving::PdfSaveOptions::get_CacheHeaderFooterShapes() const
```

## Remarks


Default value is **false** and shapes are not cached.

When the value is **true** shapes graphics are written to the PDF document as an xObject.

Some shapes are not supported for caching(shapes with fields, bookmarks, HRefs). 
## See Also

* Class [PdfSaveOptions](../)
* Namespace [Aspose::Words::Saving](../../)
* Library [Aspose.Words for C++](../../../)
