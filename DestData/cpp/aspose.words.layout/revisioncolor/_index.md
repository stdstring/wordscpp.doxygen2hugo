---
title: RevisionColor
second_title: Aspose.Words for C++ API Reference
description: Allows to specify color of document revisions. 
type: docs
weight: 131
url: /cpp/aspose.words.layout/revisioncolor/
---
## RevisionColor enum


Allows to specify color of document revisions.

### Values

| Name | Value | Description |
| --- | --- | --- |
| Auto | `0` | Default. |
| Black | `0` | Represents 000000 color. |
| Blue | `0` | Represents 2e97d3 color. |
| BrightGreen | `0` | Represents 84a35b color. |
| ClassicBlue | `0` | Represents 0000ff color. |
| ClassicRed | `0` | Represents ff0000 color. |
| DarkBlue | `0` | Represents 376e96 color. |
| DarkRed | `0` | Represents 881824 color. |
| DarkYellow | `0` | Represents e09a2b color. |
| Gray25 | `0` | Represents a0a3a9 color. |
| Gray50 | `0` | Represents 50565e color. |
| Green | `0` | Represents 2c6234 color. |
| Pink | `0` | Represents ce338f color. |
| Red | `0` | Represents b5082e color. |
| Teal | `0` | Represents 1b9cab color. |
| Turquoise | `0` | Represents 3eafc2 color. |
| Violet | `0` | Represents 633277 color. |
| White | `0` | Represents ffffff color. |
| Yellow | `0` | Represents fad272 color. |
| NoHighlight | `0` | No color is used to highlight revision changes. |
| ByAuthor | `0` | Revisions of each author receive their own color for highlighting from a predfined set of hi-contrast colors. |


## Examples




Shows how to alter the appearance of revisions in a rendered output document. 
```cpp
auto doc = MakeObject<Document>();
auto builder = MakeObject<DocumentBuilder>(doc);

// Insert a revision, then change the color of all revisions to green.
builder->Writeln(u"This is not a revision.");
doc->StartTrackRevisions(u"John Doe", System::DateTime::get_Now());
builder->Writeln(u"This is a revision.");
doc->StopTrackRevisions();
builder->Writeln(u"This is not a revision.");

// Remove the bar that appears to the left of every revised line.
doc->get_LayoutOptions()->get_RevisionOptions()->set_InsertedTextColor(RevisionColor::BrightGreen);
doc->get_LayoutOptions()->get_RevisionOptions()->set_ShowRevisionBars(false);

doc->Save(ArtifactsDir + u"Document.LayoutOptionsRevisions.pdf");
```

