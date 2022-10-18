---
title: OutlineOptions
second_title: Aspose.Words for C++ API Reference
description: Allows to specify outline options. 
type: docs
weight: 0
url: /cpp/aspose.words.saving/outlineoptions/
---
## OutlineOptions class


Allows to specify outline options.

```cpp
class OutlineOptions : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| [get_BookmarksOutlineLevels](./get_bookmarksoutlinelevels/)() const | Allows to specify individual bookmarks outline level. |
| [get_CreateMissingOutlineLevels](./get_createmissingoutlinelevels/)() const | Gets or sets a value determining whether or not to create missing outline levels when the document is exported. Default value for this property is **false**. |
| [get_CreateOutlinesForHeadingsInTables](./get_createoutlinesforheadingsintables/)() const | Specifies whether or not to create outlines for headings (paragraphs formatted with the Heading styles) inside tables. |
| [get_DefaultBookmarksOutlineLevel](./get_defaultbookmarksoutlinelevel/)() const | Specifies the default level in the document outline at which to display Word bookmarks. |
| [get_ExpandedOutlineLevels](./get_expandedoutlinelevels/)() const | Specifies how many levels in the document outline to show expanded when the file is viewed. |
| [get_HeadingsOutlineLevels](./get_headingsoutlinelevels/)() const | Specifies how many levels of headings (paragraphs formatted with the Heading styles) to include in the document outline. |
| [OutlineOptions](./outlineoptions/)() |  |
| [set_CreateMissingOutlineLevels](./set_createmissingoutlinelevels/)(bool) | Setter for [Aspose::Words::Saving::OutlineOptions::get_CreateMissingOutlineLevels](./get_createmissingoutlinelevels/). |
| [set_CreateOutlinesForHeadingsInTables](./set_createoutlinesforheadingsintables/)(bool) | Setter for [Aspose::Words::Saving::OutlineOptions::get_CreateOutlinesForHeadingsInTables](./get_createoutlinesforheadingsintables/). |
| [set_DefaultBookmarksOutlineLevel](./set_defaultbookmarksoutlinelevel/)(int32_t) | Setter for [Aspose::Words::Saving::OutlineOptions::get_DefaultBookmarksOutlineLevel](./get_defaultbookmarksoutlinelevel/). |
| [set_ExpandedOutlineLevels](./set_expandedoutlinelevels/)(int32_t) | Setter for [Aspose::Words::Saving::OutlineOptions::get_ExpandedOutlineLevels](./get_expandedoutlinelevels/). |
| [set_HeadingsOutlineLevels](./set_headingsoutlinelevels/)(int32_t) | Setter for [Aspose::Words::Saving::OutlineOptions::get_HeadingsOutlineLevels](./get_headingsoutlinelevels/). |

## Examples




Shows to process bookmarks in headers/footers in a document that we are rendering to PDF. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Bookmarks in headers and footers.docx");

// Create a "PdfSaveOptions" object that we can pass to the document's "Save" method
// to modify how that method converts the document to .PDF.
auto saveOptions = MakeObject<PdfSaveOptions>();

// Set the "PageMode" property to "PdfPageMode.UseOutlines" to display the outline navigation pane in the output PDF.
saveOptions->set_PageMode(PdfPageMode::UseOutlines);

// Set the "DefaultBookmarksOutlineLevel" property to "1" to display all
// bookmarks at the first level of the outline in the output PDF.
saveOptions->get_OutlineOptions()->set_DefaultBookmarksOutlineLevel(1);

// Set the "HeaderFooterBookmarksExportMode" property to "HeaderFooterBookmarksExportMode.None" to
// not export any bookmarks that are inside headers/footers.
// Set the "HeaderFooterBookmarksExportMode" property to "HeaderFooterBookmarksExportMode.First" to
// only export bookmarks in the first section's header/footers.
// Set the "HeaderFooterBookmarksExportMode" property to "HeaderFooterBookmarksExportMode.All" to
// export bookmarks that are in all headers/footers.
saveOptions->set_HeaderFooterBookmarksExportMode(headerFooterBookmarksExportMode);

doc->Save(ArtifactsDir + u"PdfSaveOptions.HeaderFooterBookmarksExportMode.pdf", saveOptions);
```

