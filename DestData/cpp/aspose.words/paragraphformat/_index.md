---
title: ParagraphFormat
second_title: Aspose.Words for C++ API Reference
description: Represents all the formatting for a paragraph. 
type: docs
weight: 0
url: /cpp/aspose.words/paragraphformat/
---
## ParagraphFormat class


Represents all the formatting for a paragraph. 

## Methods

| Method | Description |
| --- | --- |
| void [ClearFormatting](./clearformatting/)() | Resets to default paragraph formatting.  |
| bool [get_AddSpaceBetweenFarEastAndAlpha](./get_addspacebetweenfareastandalpha/)() | Gets or sets a flag indicating whether inter-character spacing is automatically adjusted between regions of Latin text and regions of East Asian text in the current paragraph.  |
| bool [get_AddSpaceBetweenFarEastAndDigit](./get_addspacebetweenfareastanddigit/)() | Gets or sets a flag indicating whether inter-character spacing is automatically adjusted between regions of numbers and regions of East Asian text in the current paragraph.  |
| Aspose::Words::ParagraphAlignment [get_Alignment](./get_alignment/)() | Gets or sets text alignment for the paragraph.  |
| bool [get_Bidi](./get_bidi/)() | Gets or sets whether this is a right-to-left paragraph.  |
| System::SharedPtr< Aspose::Words::BorderCollection > [get_Borders](./get_borders/)() | Gets collection of borders of the paragraph.  |
| double [get_CharacterUnitFirstLineIndent](./get_characterunitfirstlineindent/)() | Gets or sets the value (in characters) for the first-line or hanging indent. Use positive values to set the first-line indent, and negative values to set the hanging indent.  |
| double [get_CharacterUnitLeftIndent](./get_characterunitleftindent/)() | Gets or sets the left indent value (in characters) for the specified paragraphs.  |
| double [get_CharacterUnitRightIndent](./get_characterunitrightindent/)() | Gets or sets the right indent value (in characters) for the specified paragraphs.  |
| Aspose::Words::DropCapPosition [get_DropCapPosition](./get_dropcapposition/)() | Gets or sets the position for a drop cap text.  |
| bool [get_FarEastLineBreakControl](./get_fareastlinebreakcontrol/)() | Gets or sets a flag indicating whether East Asian line-breaking rules are applied to the current paragraph.  |
| double [get_FirstLineIndent](./get_firstlineindent/)() | Gets or sets the value (in points) for a first line or hanging indent. Use positive values to set the first-line indent, and negative values to set the hanging indent.  |
| bool [get_HangingPunctuation](./get_hangingpunctuation/)() | Gets or sets a flag indicating whether hanging punctuation is enabled for the current paragraph.  |
| bool [get_IsHeading](./get_isheading/)() | True when the paragraph style is one of the built-in Heading styles.  |
| bool [get_IsListItem](./get_islistitem/)() | True when the paragraph is an item in a bulleted or numbered list.  |
| bool [get_KeepTogether](./get_keeptogether/)() | True if all lines in the paragraph are to remain on the same page.  |
| bool [get_KeepWithNext](./get_keepwithnext/)() | True if the paragraph is to remains on the same page as the paragraph that follows it.  |
| double [get_LeftIndent](./get_leftindent/)() | Gets or sets the value (in points) that represents the left indent for paragraph.  |
| double [get_LineSpacing](./get_linespacing/)() | Gets or sets the line spacing (in points) for the paragraph.  |
| Aspose::Words::LineSpacingRule [get_LineSpacingRule](./get_linespacingrule/)() | Gets or sets the line spacing for the paragraph.  |
| int32_t [get_LinesToDrop](./get_linestodrop/)() | Gets or sets the number of lines of the paragraph text used to calculate the drop cap height.  |
| double [get_LineUnitAfter](./get_lineunitafter/)() | Gets or sets the amount of spacing (in gridlines) after the paragraphs.  |
| double [get_LineUnitBefore](./get_lineunitbefore/)() | Gets or sets the amount of spacing (in gridlines) before the paragraphs.  |
| bool [get_NoSpaceBetweenParagraphsOfSameStyle](./get_nospacebetweenparagraphsofsamestyle/)() | When true, SpaceBefore and SpaceAfter will be ignored between the paragraphs of the same style.  |
| Aspose::Words::OutlineLevel [get_OutlineLevel](./get_outlinelevel/)() | Specifies the outline level of the paragraph in the document.  |
| bool [get_PageBreakBefore](./get_pagebreakbefore/)() | True if a page break is forced before the paragraph.  |
| double [get_RightIndent](./get_rightindent/)() | Gets or sets the value (in points) that represents the right indent for paragraph.  |
| System::SharedPtr< Aspose::Words::Shading > [get_Shading](./get_shading/)() | Returns a Shading object that refers to the shading formatting for the paragraph.  |
| bool [get_SnapToGrid](./get_snaptogrid/)() | Specifies whether the current paragraph should use the document grid lines per page settings when laying out the contents in the paragraph.  |
| double [get_SpaceAfter](./get_spaceafter/)() | Gets or sets the amount of spacing (in points) after the paragraph.  |
| bool [get_SpaceAfterAuto](./get_spaceafterauto/)() | True if the amount of spacing after the paragraph is set automatically.  |
| double [get_SpaceBefore](./get_spacebefore/)() | Gets or sets the amount of spacing (in points) before the paragraph.  |
| bool [get_SpaceBeforeAuto](./get_spacebeforeauto/)() | True if the amount of spacing before the paragraph is set automatically.  |
| System::SharedPtr< Aspose::Words::Style > [get_Style](./get_style/)() | Gets or sets the paragraph style applied to this formatting.  |
| Aspose::Words::StyleIdentifier [get_StyleIdentifier](./get_styleidentifier/)() | Gets or sets the locale independent style identifier of the paragraph style applied to this formatting.  |
| System::String [get_StyleName](./get_stylename/)() | Gets or sets the name of the paragraph style applied to this formatting.  |
| bool [get_SuppressAutoHyphens](./get_suppressautohyphens/)() | Specifies whether the current paragraph should be exempted from any hyphenation which is applied in the document settings.  |
| bool [get_SuppressLineNumbers](./get_suppresslinenumbers/)() | Specifies whether the current paragraph's lines should be exempted from line numbering which is applied in the parent section.  |
| System::SharedPtr< Aspose::Words::TabStopCollection > [get_TabStops](./get_tabstops/)() | Gets the collection of custom tab stops defined for this object.  |
| bool [get_WidowControl](./get_widowcontrol/)() | True if the first and last lines in the paragraph are to remain on the same page as the rest of the paragraph.  |
| bool [get_WordWrap](./get_wordwrap/)() | If this property is **false**, Latin text in the middle of a word can be wrapped for the current paragraph. Otherwise Latin text is wrapped by whole words.  |
| void [set_AddSpaceBetweenFarEastAndAlpha](./set_addspacebetweenfareastandalpha/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_AddSpaceBetweenFarEastAndAlpha.  |
| void [set_AddSpaceBetweenFarEastAndDigit](./set_addspacebetweenfareastanddigit/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_AddSpaceBetweenFarEastAndDigit.  |
| void [set_Alignment](./set_alignment/)(Aspose::Words::ParagraphAlignment) | Setter for Aspose::Words::ParagraphFormat::get_Alignment.  |
| void [set_Bidi](./set_bidi/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_Bidi.  |
| void [set_CharacterUnitFirstLineIndent](./set_characterunitfirstlineindent/)(double) | Setter for Aspose::Words::ParagraphFormat::get_CharacterUnitFirstLineIndent.  |
| void [set_CharacterUnitLeftIndent](./set_characterunitleftindent/)(double) | Setter for Aspose::Words::ParagraphFormat::get_CharacterUnitLeftIndent.  |
| void [set_CharacterUnitRightIndent](./set_characterunitrightindent/)(double) | Setter for Aspose::Words::ParagraphFormat::get_CharacterUnitRightIndent.  |
| void [set_DropCapPosition](./set_dropcapposition/)(Aspose::Words::DropCapPosition) | Setter for Aspose::Words::ParagraphFormat::get_DropCapPosition.  |
| void [set_FarEastLineBreakControl](./set_fareastlinebreakcontrol/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_FarEastLineBreakControl.  |
| void [set_FirstLineIndent](./set_firstlineindent/)(double) | Setter for Aspose::Words::ParagraphFormat::get_FirstLineIndent.  |
| void [set_HangingPunctuation](./set_hangingpunctuation/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_HangingPunctuation.  |
| void [set_KeepTogether](./set_keeptogether/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_KeepTogether.  |
| void [set_KeepWithNext](./set_keepwithnext/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_KeepWithNext.  |
| void [set_LeftIndent](./set_leftindent/)(double) | Setter for Aspose::Words::ParagraphFormat::get_LeftIndent.  |
| void [set_LineSpacing](./set_linespacing/)(double) | Setter for Aspose::Words::ParagraphFormat::get_LineSpacing.  |
| void [set_LineSpacingRule](./set_linespacingrule/)(Aspose::Words::LineSpacingRule) | Setter for Aspose::Words::ParagraphFormat::get_LineSpacingRule.  |
| void [set_LinesToDrop](./set_linestodrop/)(int32_t) | Setter for Aspose::Words::ParagraphFormat::get_LinesToDrop.  |
| void [set_LineUnitAfter](./set_lineunitafter/)(double) | Setter for Aspose::Words::ParagraphFormat::get_LineUnitAfter.  |
| void [set_LineUnitBefore](./set_lineunitbefore/)(double) | Setter for Aspose::Words::ParagraphFormat::get_LineUnitBefore.  |
| void [set_NoSpaceBetweenParagraphsOfSameStyle](./set_nospacebetweenparagraphsofsamestyle/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_NoSpaceBetweenParagraphsOfSameStyle.  |
| void [set_OutlineLevel](./set_outlinelevel/)(Aspose::Words::OutlineLevel) | Setter for Aspose::Words::ParagraphFormat::get_OutlineLevel.  |
| void [set_PageBreakBefore](./set_pagebreakbefore/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_PageBreakBefore.  |
| void [set_RightIndent](./set_rightindent/)(double) | Setter for Aspose::Words::ParagraphFormat::get_RightIndent.  |
| void [set_SnapToGrid](./set_snaptogrid/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_SnapToGrid.  |
| void [set_SpaceAfter](./set_spaceafter/)(double) | Setter for Aspose::Words::ParagraphFormat::get_SpaceAfter.  |
| void [set_SpaceAfterAuto](./set_spaceafterauto/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_SpaceAfterAuto.  |
| void [set_SpaceBefore](./set_spacebefore/)(double) | Setter for Aspose::Words::ParagraphFormat::get_SpaceBefore.  |
| void [set_SpaceBeforeAuto](./set_spacebeforeauto/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_SpaceBeforeAuto.  |
| void [set_Style](./set_style/)(const System::SharedPtr< Aspose::Words::Style > &) | Setter for Aspose::Words::ParagraphFormat::get_Style.  |
| void [set_StyleIdentifier](./set_styleidentifier/)(Aspose::Words::StyleIdentifier) | Setter for Aspose::Words::ParagraphFormat::get_StyleIdentifier.  |
| void [set_StyleName](./set_stylename/)(const System::String &) | Setter for Aspose::Words::ParagraphFormat::get_StyleName.  |
| void [set_SuppressAutoHyphens](./set_suppressautohyphens/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_SuppressAutoHyphens.  |
| void [set_SuppressLineNumbers](./set_suppresslinenumbers/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_SuppressLineNumbers.  |
| void [set_WidowControl](./set_widowcontrol/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_WidowControl.  |
| void [set_WordWrap](./set_wordwrap/)(bool) | Setter for Aspose::Words::ParagraphFormat::get_WordWrap.  |
