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
| System::Drawing::RectangleF [AdjustWithEffects](./adjustwitheffects/)(System::Drawing::RectangleF) | Adds to the source rectangle values of the effect extent and returns the final rectangle.  |
| bool [get_AllowOverlap](./get_allowoverlap/)() | Gets or sets a value that specifies whether this shape can overlap other shapes.  |
| System::String [get_AlternativeText](./get_alternativetext/)() | Defines alternative text to be displayed instead of a graphic.  |
| bool [get_AnchorLocked](./get_anchorlocked/)() | Specifies whether the shape's anchor is locked.  |
| bool [get_AspectRatioLocked](./get_aspectratiolocked/)() | Specifies whether the shape's aspect ratio is locked.  |
| bool [get_BehindText](./get_behindtext/)() | Specifies whether the shape is below or above text.  |
| double [get_Bottom](./get_bottom/)() | Gets the position of the bottom edge of the containing block of the shape.  |
| System::Drawing::RectangleF [get_Bounds](./get_bounds/)() | Gets or sets the location and size of the containing block of the shape.  |
| System::Drawing::RectangleF [get_BoundsInPoints](./get_boundsinpoints/)() | Gets the location and size of the containing block of the shape in points, relative to the anchor of the topmost shape.  |
| System::Drawing::RectangleF [get_BoundsWithEffects](./get_boundswitheffects/)() | Gets final extent that this shape object has after applying drawing effects. Value is measured in points.  |
| bool [get_CanHaveImage](./get_canhaveimage/)() | Returns true if the shape type allows the shape to have an image.  |
| System::Drawing::Point [get_CoordOrigin](./get_coordorigin/)() | The coordinates at the top-left corner of the containing block of this shape.  |
| System::Drawing::Size [get_CoordSize](./get_coordsize/)() | The width and height of the coordinate space inside the containing block of this shape.  |
| double [get_DistanceBottom](./get_distancebottom/)() | Returns or sets the distance (in points) between the document text and the bottom edge of the shape.  |
| double [get_DistanceLeft](./get_distanceleft/)() | Returns or sets the distance (in points) between the document text and the left edge of the shape.  |
| double [get_DistanceRight](./get_distanceright/)() | Returns or sets the distance (in points) between the document text and the right edge of the shape.  |
| double [get_DistanceTop](./get_distancetop/)() | Returns or sets the distance (in points) between the document text and the top edge of the shape.  |
| System::SharedPtr< Aspose::Words::Drawing::Fill > [get_Fill](./get_fill/)() | Gets fill formatting for the shape.  |
| Aspose::Words::Drawing::FlipOrientation [get_FlipOrientation](./get_fliporientation/)() | Switches the orientation of a shape.  |
| System::SharedPtr< Aspose::Words::Font > [get_Font](./get_font/)() | Provides access to the font formatting of this object.  |
| double [get_Height](./get_height/)() | Gets or sets the height of the containing block of the shape.  |
| Aspose::Words::Drawing::HorizontalAlignment [get_HorizontalAlignment](./get_horizontalalignment/)() | Specifies how the shape is positioned horizontally.  |
| System::String [get_HRef](./get_href/)() | Gets or sets the full hyperlink address for a shape.  |
| bool [get_IsDecorative](./get_isdecorative/)() | Gets or sets the flag that specifies whether the shape is decorative in the document.  |
| bool [get_IsDeleteRevision](./get_isdeleterevision/)() | Returns true if this object was deleted in Microsoft Word while change tracking was enabled.  |
| bool [get_IsGroup](./get_isgroup/)() | Returns true if this is a group shape.  |
| bool [get_IsHorizontalRule](./get_ishorizontalrule/)() | Returns true if this shape is a horizontal rule.  |
| bool [get_IsImage](./get_isimage/)() | Returns true if this shape is an image shape.  |
| bool [get_IsInline](./get_isinline/)() | A quick way to determine if this shape is positioned inline with text.  |
| bool [get_IsInsertRevision](./get_isinsertrevision/)() | Returns true if this object was inserted in Microsoft Word while change tracking was enabled.  |
| bool [get_IsLayoutInCell](./get_islayoutincell/)() | Gets or sets a flag indicating whether the shape is displayed inside a table or outside of it.  |
| bool [get_IsMoveFromRevision](./get_ismovefromrevision/)() | Returns **true** if this object was moved (deleted) in Microsoft Word while change tracking was enabled.  |
| bool [get_IsMoveToRevision](./get_ismovetorevision/)() | Returns **true** if this object was moved (inserted) in Microsoft Word while change tracking was enabled.  |
| bool [get_IsSignatureLine](./get_issignatureline/)() | Indicates that shape is a SignatureLine.  |
| bool [get_IsTopLevel](./get_istoplevel/)() | Returns true if this shape is not a child of a group shape.  |
| bool [get_IsWordArt](./get_iswordart/)() | Returns true if this shape is a WordArt object.  |
| double [get_Left](./get_left/)() | Gets or sets the position of the left edge of the containing block of the shape.  |
| Aspose::Words::Drawing::ShapeMarkupLanguage [get_MarkupLanguage](./get_markuplanguage/)() const | Gets MarkupLanguage used for this graphic object.  |
| System::String [get_Name](./get_name/)() | Gets or sets the optional shape name.  |
| System::SharedPtr< Aspose::Words::Paragraph > [get_ParentParagraph](./get_parentparagraph/)() | Returns the immediate parent paragraph.  |
| Aspose::Words::Drawing::RelativeHorizontalPosition [get_RelativeHorizontalPosition](./get_relativehorizontalposition/)() | Specifies relative to what the shape is positioned horizontally.  |
| Aspose::Words::Drawing::RelativeVerticalPosition [get_RelativeVerticalPosition](./get_relativeverticalposition/)() | Specifies relative to what the shape is positioned vertically.  |
| double [get_Right](./get_right/)() | Gets the position of the right edge of the containing block of the shape.  |
| double [get_Rotation](./get_rotation/)() | Defines the angle (in degrees) that a shape is rotated. Positive value corresponds to clockwise rotation angle.  |
| System::String [get_ScreenTip](./get_screentip/)() | Defines the text displayed when the mouse pointer moves over the shape.  |
| System::SharedPtr< Aspose::Words::Drawing::ShadowFormat > [get_ShadowFormat](./get_shadowformat/)() | Gets shadow formatting for the shape.  |
| Aspose::Words::Drawing::ShapeType [get_ShapeType](./get_shapetype/)() | Gets the shape type.  |
| System::Drawing::SizeF [get_SizeInPoints](./get_sizeinpoints/)() | Gets the size of the shape in points.  |
| System::String [get_Target](./get_target/)() | Gets or sets the target frame for the shape hyperlink.  |
| System::String [get_Title](./get_title/)() | Gets or sets the title (caption) of the current shape object.  |
| double [get_Top](./get_top/)() | Gets or sets the position of the top edge of the containing block of the shape.  |
| Aspose::Words::Drawing::VerticalAlignment [get_VerticalAlignment](./get_verticalalignment/)() | Specifies how the shape is positioned vertically.  |
| double [get_Width](./get_width/)() | Gets or sets the width of the containing block of the shape.  |
| Aspose::Words::Drawing::WrapSide [get_WrapSide](./get_wrapside/)() | Specifies how the text is wrapped around the shape.  |
| Aspose::Words::Drawing::WrapType [get_WrapType](./get_wraptype/)() | Defines whether the shape is inline or floating. For floating shapes defines the wrapping mode for text around the shape.  |
| int32_t [get_ZOrder](./get_zorder/)() | Determines the display order of overlapping shapes.  |
| System::SharedPtr< Aspose::Words::Rendering::ShapeRenderer > [GetShapeRenderer](./getshaperenderer/)() | Creates and returns an object that can be used to render this shape into an image.  |
| System::Drawing::PointF [LocalToParent](./localtoparent/)(System::Drawing::PointF) | Converts a value from the local coordinate space into the coordinate space of the parent shape.  |
| void [set_AllowOverlap](./set_allowoverlap/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_AllowOverlap.  |
| void [set_AlternativeText](./set_alternativetext/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_AlternativeText.  |
| void [set_AnchorLocked](./set_anchorlocked/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_AnchorLocked.  |
| void [set_AspectRatioLocked](./set_aspectratiolocked/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_AspectRatioLocked.  |
| void [set_BehindText](./set_behindtext/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_BehindText.  |
| void [set_Bounds](./set_bounds/)(System::Drawing::RectangleF) | Setter for Aspose::Words::Drawing::ShapeBase::get_Bounds.  |
| void [set_CoordOrigin](./set_coordorigin/)(System::Drawing::Point) | Setter for Aspose::Words::Drawing::ShapeBase::get_CoordOrigin.  |
| void [set_CoordSize](./set_coordsize/)(System::Drawing::Size) | Setter for Aspose::Words::Drawing::ShapeBase::get_CoordSize.  |
| void [set_DistanceBottom](./set_distancebottom/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceBottom.  |
| void [set_DistanceLeft](./set_distanceleft/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceLeft.  |
| void [set_DistanceRight](./set_distanceright/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceRight.  |
| void [set_DistanceTop](./set_distancetop/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_DistanceTop.  |
| void [set_FlipOrientation](./set_fliporientation/)(Aspose::Words::Drawing::FlipOrientation) | Setter for Aspose::Words::Drawing::ShapeBase::get_FlipOrientation.  |
| void [set_Height](./set_height/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Height.  |
| void [set_HorizontalAlignment](./set_horizontalalignment/)(Aspose::Words::Drawing::HorizontalAlignment) | Setter for Aspose::Words::Drawing::ShapeBase::get_HorizontalAlignment.  |
| void [set_HRef](./set_href/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_HRef.  |
| void [set_IsDecorative](./set_isdecorative/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_IsDecorative.  |
| void [set_IsLayoutInCell](./set_islayoutincell/)(bool) | Setter for Aspose::Words::Drawing::ShapeBase::get_IsLayoutInCell.  |
| void [set_Left](./set_left/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Left.  |
| void [set_Name](./set_name/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_Name.  |
| void [set_RelativeHorizontalPosition](./set_relativehorizontalposition/)(Aspose::Words::Drawing::RelativeHorizontalPosition) | Setter for Aspose::Words::Drawing::ShapeBase::get_RelativeHorizontalPosition.  |
| void [set_RelativeVerticalPosition](./set_relativeverticalposition/)(Aspose::Words::Drawing::RelativeVerticalPosition) | Setter for Aspose::Words::Drawing::ShapeBase::get_RelativeVerticalPosition.  |
| void [set_Rotation](./set_rotation/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Rotation.  |
| void [set_ScreenTip](./set_screentip/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_ScreenTip.  |
| void [set_Target](./set_target/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_Target.  |
| void [set_Title](./set_title/)(const System::String &) | Setter for Aspose::Words::Drawing::ShapeBase::get_Title.  |
| void [set_Top](./set_top/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Top.  |
| void [set_VerticalAlignment](./set_verticalalignment/)(Aspose::Words::Drawing::VerticalAlignment) | Setter for Aspose::Words::Drawing::ShapeBase::get_VerticalAlignment.  |
| void [set_Width](./set_width/)(double) | Setter for Aspose::Words::Drawing::ShapeBase::get_Width.  |
| void [set_WrapSide](./set_wrapside/)(Aspose::Words::Drawing::WrapSide) | Setter for Aspose::Words::Drawing::ShapeBase::get_WrapSide.  |
| void [set_WrapType](./set_wraptype/)(Aspose::Words::Drawing::WrapType) | Setter for Aspose::Words::Drawing::ShapeBase::get_WrapType.  |
| void [set_ZOrder](./set_zorder/)(int32_t) | Setter for Aspose::Words::Drawing::ShapeBase::get_ZOrder.  |
