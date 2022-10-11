---
title: ShapeBase
second_title: Aspose.Words for C++ API Reference
description: Base class for objects in the drawing layer, such as an AutoShape, freeform, OLE object, ActiveX control, or picture. 
type: docs
weight: 0
url: /cpp/aspose.words.drawing/shapebase/
---
## ShapeBase class


Base class for objects in the drawing layer, such as an AutoShape, freeform, OLE object, ActiveX control, or picture. 

## Methods

| Method | Description |
| --- | --- |
| [AdjustWithEffects](./adjustwitheffects/)(System::Drawing::RectangleF) | Adds to the source rectangle values of the effect extent and returns the final rectangle.  |
| [get_AllowOverlap](./get_allowoverlap/)() | Gets or sets a value that specifies whether this shape can overlap other shapes.  |
| [get_AlternativeText](./get_alternativetext/)() | Defines alternative text to be displayed instead of a graphic.  |
| [get_AnchorLocked](./get_anchorlocked/)() | Specifies whether the shape's anchor is locked.  |
| [get_AspectRatioLocked](./get_aspectratiolocked/)() | Specifies whether the shape's aspect ratio is locked.  |
| [get_BehindText](./get_behindtext/)() | Specifies whether the shape is below or above text.  |
| [get_Bottom](./get_bottom/)() | Gets the position of the bottom edge of the containing block of the shape.  |
| [get_Bounds](./get_bounds/)() | Gets or sets the location and size of the containing block of the shape.  |
| [get_BoundsInPoints](./get_boundsinpoints/)() | Gets the location and size of the containing block of the shape in points, relative to the anchor of the topmost shape.  |
| [get_BoundsWithEffects](./get_boundswitheffects/)() | Gets final extent that this shape object has after applying drawing effects. Value is measured in points.  |
| [get_CanHaveImage](./get_canhaveimage/)() | Returns true if the shape type allows the shape to have an image.  |
| [get_CoordOrigin](./get_coordorigin/)() | The coordinates at the top-left corner of the containing block of this shape.  |
| [get_CoordSize](./get_coordsize/)() | The width and height of the coordinate space inside the containing block of this shape.  |
| [get_DistanceBottom](./get_distancebottom/)() | Returns or sets the distance (in points) between the document text and the bottom edge of the shape.  |
| [get_DistanceLeft](./get_distanceleft/)() | Returns or sets the distance (in points) between the document text and the left edge of the shape.  |
| [get_DistanceRight](./get_distanceright/)() | Returns or sets the distance (in points) between the document text and the right edge of the shape.  |
| [get_DistanceTop](./get_distancetop/)() | Returns or sets the distance (in points) between the document text and the top edge of the shape.  |
| [get_Fill](./get_fill/)() | Gets fill formatting for the shape.  |
| [get_FlipOrientation](./get_fliporientation/)() | Switches the orientation of a shape.  |
| [get_Font](./get_font/)() | Provides access to the font formatting of this object.  |
| [get_Height](./get_height/)() | Gets or sets the height of the containing block of the shape.  |
| [get_HorizontalAlignment](./get_horizontalalignment/)() | Specifies how the shape is positioned horizontally.  |
| [get_HRef](./get_href/)() | Gets or sets the full hyperlink address for a shape.  |
| [get_IsDecorative](./get_isdecorative/)() | Gets or sets the flag that specifies whether the shape is decorative in the document.  |
| [get_IsDeleteRevision](./get_isdeleterevision/)() | Returns true if this object was deleted in Microsoft Word while change tracking was enabled.  |
| [get_IsGroup](./get_isgroup/)() | Returns true if this is a group shape.  |
| [get_IsHorizontalRule](./get_ishorizontalrule/)() | Returns true if this shape is a horizontal rule.  |
| [get_IsImage](./get_isimage/)() | Returns true if this shape is an image shape.  |
| [get_IsInline](./get_isinline/)() | A quick way to determine if this shape is positioned inline with text.  |
| [get_IsInsertRevision](./get_isinsertrevision/)() | Returns true if this object was inserted in Microsoft Word while change tracking was enabled.  |
| [get_IsLayoutInCell](./get_islayoutincell/)() | Gets or sets a flag indicating whether the shape is displayed inside a table or outside of it.  |
| [get_IsMoveFromRevision](./get_ismovefromrevision/)() | Returns **true** if this object was moved (deleted) in Microsoft Word while change tracking was enabled.  |
| [get_IsMoveToRevision](./get_ismovetorevision/)() | Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled.  |
| [get_IsSignatureLine](./get_issignatureline/)() | Indicates that shape is a SignatureLine.  |
| [get_IsTopLevel](./get_istoplevel/)() | Returns true if this shape is not a child of a group shape.  |
| [get_IsWordArt](./get_iswordart/)() | Returns true if this shape is a WordArt object.  |
| [get_Left](./get_left/)() | Gets or sets the position of the left edge of the containing block of the shape.  |
| [get_MarkupLanguage](./get_markuplanguage/)() const | Gets MarkupLanguage used for this graphic object.  |
| [get_Name](./get_name/)() | Gets or sets the optional shape name.  |
| [get_ParentParagraph](./get_parentparagraph/)() | Returns the immediate parent paragraph.  |
| [get_RelativeHorizontalPosition](./get_relativehorizontalposition/)() | Specifies relative to what the shape is positioned horizontally.  |
| [get_RelativeVerticalPosition](./get_relativeverticalposition/)() | Specifies relative to what the shape is positioned vertically.  |
| [get_Right](./get_right/)() | Gets the position of the right edge of the containing block of the shape.  |
| [get_Rotation](./get_rotation/)() | Defines the angle (in degrees) that a shape is rotated. Positive value corresponds to clockwise rotation angle.  |
| [get_ScreenTip](./get_screentip/)() | Defines the text displayed when the mouse pointer moves over the shape.  |
| [get_ShadowFormat](./get_shadowformat/)() | Gets shadow formatting for the shape.  |
| [get_ShapeType](./get_shapetype/)() | Gets the shape type.  |
| [get_SizeInPoints](./get_sizeinpoints/)() | Gets the size of the shape in points.  |
| [get_Target](./get_target/)() | Gets or sets the target frame for the shape hyperlink.  |
| [get_Title](./get_title/)() | Gets or sets the title (caption) of the current shape object.  |
| [get_Top](./get_top/)() | Gets or sets the position of the top edge of the containing block of the shape.  |
| [get_VerticalAlignment](./get_verticalalignment/)() | Specifies how the shape is positioned vertically.  |
| [get_Width](./get_width/)() | Gets or sets the width of the containing block of the shape.  |
| [get_WrapSide](./get_wrapside/)() | Specifies how the text is wrapped around the shape.  |
| [get_WrapType](./get_wraptype/)() | Defines whether the shape is inline or floating. For floating shapes defines the wrapping mode for text around the shape.  |
| [get_ZOrder](./get_zorder/)() | Determines the display order of overlapping shapes.  |
| [GetShapeRenderer](./getshaperenderer/)() | Creates and returns an object that can be used to render this shape into an image.  |
| [LocalToParent](./localtoparent/)(System::Drawing::PointF) | Converts a value from the local coordinate space into the coordinate space of the parent shape.  |
| [set_AllowOverlap](./set_allowoverlap/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_AllowOverlap.  |
| [set_AlternativeText](./set_alternativetext/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_AlternativeText.  |
| [set_AnchorLocked](./set_anchorlocked/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_AnchorLocked.  |
| [set_AspectRatioLocked](./set_aspectratiolocked/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_AspectRatioLocked.  |
| [set_BehindText](./set_behindtext/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_BehindText.  |
| [set_Bounds](./set_bounds/)(System::Drawing::RectangleF) | Setter for Aspose::Words::Drawing::ShapeBase::get_Bounds.  |
| [set_CoordOrigin](./set_coordorigin/)(System::Drawing::Point) | Setter for Aspose::Words::Drawing::ShapeBase::get_CoordOrigin.  |
| [set_CoordSize](./set_coordsize/)(System::Drawing::Size) | Setter for Aspose::Words::Drawing::ShapeBase::get_CoordSize.  |
| [set_DistanceBottom](./set_distancebottom/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceBottom.  |
| [set_DistanceLeft](./set_distanceleft/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceLeft.  |
| [set_DistanceRight](./set_distanceright/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceRight.  |
| [set_DistanceTop](./set_distancetop/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceTop.  |
| [set_FlipOrientation](./set_fliporientation/)(Aspose::Words::Drawing::FlipOrientation) | Setter for Aspose::Words::Drawing::ShapeBase::get_FlipOrientation.  |
| [set_Height](./set_height/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Height.  |
| [set_HorizontalAlignment](./set_horizontalalignment/)(Aspose::Words::Drawing::HorizontalAlignment) | Setter for Aspose::Words::Drawing::ShapeBase::get_HorizontalAlignment.  |
| [set_HRef](./set_href/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_HRef.  |
| [set_IsDecorative](./set_isdecorative/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_IsDecorative.  |
| [set_IsLayoutInCell](./set_islayoutincell/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_IsLayoutInCell.  |
| [set_Left](./set_left/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Left.  |
| [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_Name.  |
| [set_RelativeHorizontalPosition](./set_relativehorizontalposition/)(Aspose::Words::Drawing::RelativeHorizontalPosition) | Setter for Aspose::Words::Drawing::ShapeBase::get_RelativeHorizontalPosition.  |
| [set_RelativeVerticalPosition](./set_relativeverticalposition/)(Aspose::Words::Drawing::RelativeVerticalPosition) | Setter for Aspose::Words::Drawing::ShapeBase::get_RelativeVerticalPosition.  |
| [set_Rotation](./set_rotation/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Rotation.  |
| [set_ScreenTip](./set_screentip/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_ScreenTip.  |
| [set_Target](./set_target/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_Target.  |
| [set_Title](./set_title/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_Title.  |
| [set_Top](./set_top/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Top.  |
| [set_VerticalAlignment](./set_verticalalignment/)(Aspose::Words::Drawing::VerticalAlignment) | Setter for Aspose::Words::Drawing::ShapeBase::get_VerticalAlignment.  |
| [set_Width](./set_width/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Width.  |
| [set_WrapSide](./set_wrapside/)(Aspose::Words::Drawing::WrapSide) | Setter for Aspose::Words::Drawing::ShapeBase::get_WrapSide.  |
| [set_WrapType](./set_wraptype/)(Aspose::Words::Drawing::WrapType) | Setter for Aspose::Words::Drawing::ShapeBase::get_WrapType.  |
| [set_ZOrder](./set_zorder/)(int32_t) | Setter for Aspose::Words::Drawing::ShapeBase::get_ZOrder.  |
