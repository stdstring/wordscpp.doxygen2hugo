---
title: Aspose::Words::Layout::RevisionOptions::get_ShowOriginalRevision method
linktitle: get_ShowOriginalRevision
second_title: Aspose.Words for C++ API Reference
description: 'Aspose::Words::Layout::RevisionOptions::get_ShowOriginalRevision method. Allows to specify whether the original text should be shown instead of revised one. Default value is False in C++.'
type: docs
weight: 1700
url: /cpp/aspose.words.layout/revisionoptions/get_showoriginalrevision/
---
## RevisionOptions::get_ShowOriginalRevision method


Allows to specify whether the original text should be shown instead of revised one. Default value is False.

```cpp
bool Aspose::Words::Layout::RevisionOptions::get_ShowOriginalRevision() const
```


## Examples



Shows how to modify the appearance of revisions. 
```cpp
auto doc = MakeObject<Document>(MyDir + u"Revisions.docx");

// Get the RevisionOptions object that controls the appearance of revisions.
SharedPtr<RevisionOptions> revisionOptions = doc->get_LayoutOptions()->get_RevisionOptions();

// Render insertion revisions in green and italic.
revisionOptions->set_InsertedTextColor(RevisionColor::Green);
revisionOptions->set_InsertedTextEffect(RevisionTextEffect::Italic);

// Render deletion revisions in red and bold.
revisionOptions->set_DeletedTextColor(RevisionColor::Red);
revisionOptions->set_DeletedTextEffect(RevisionTextEffect::Bold);

// The same text will appear twice in a movement revision:
// once at the departure point and once at the arrival destination.
// Render the text at the moved-from revision yellow with a double strike through
// and double-underlined blue at the moved-to revision.
revisionOptions->set_MovedFromTextColor(RevisionColor::Yellow);
revisionOptions->set_MovedFromTextEffect(RevisionTextEffect::DoubleStrikeThrough);
revisionOptions->set_MovedToTextColor(RevisionColor::Blue);
revisionOptions->set_MovedFromTextEffect(RevisionTextEffect::DoubleUnderline);

// Render format revisions in dark red and bold.
revisionOptions->set_RevisedPropertiesColor(RevisionColor::DarkRed);
revisionOptions->set_RevisedPropertiesEffect(RevisionTextEffect::Bold);

// Place a thick dark blue bar on the left side of the page next to lines affected by revisions.
revisionOptions->set_RevisionBarsColor(RevisionColor::DarkBlue);
revisionOptions->set_RevisionBarsWidth(15.0f);

// Show revision marks and original text.
revisionOptions->set_ShowOriginalRevision(true);
revisionOptions->set_ShowRevisionMarks(true);

// Get movement, deletion, formatting revisions, and comments to show up in green balloons
// on the right side of the page.
revisionOptions->set_ShowInBalloons(ShowInBalloons::Format);
revisionOptions->set_CommentColor(RevisionColor::BrightGreen);

// These features are only applicable to formats such as .pdf or .jpg.
doc->Save(ArtifactsDir + u"Revision.RevisionOptions.pdf");
```

## See Also

* Class [RevisionOptions](../)
* Namespace [Aspose::Words::Layout](../../)
* Library [Aspose.Words for C++](../../../)
