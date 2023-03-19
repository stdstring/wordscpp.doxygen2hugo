---
title: Aspose::Words::NodeType enum
linktitle: NodeType
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::NodeType enum. Specifies the type of a Word document node in C++.
type: docs
weight: 10200
url: /cpp/aspose.words/nodetype/
---
## NodeType enum


Specifies the type of a Word document node.

```cpp
enum class NodeType
```

### Values

| Name | Value | Description |
| --- | --- | --- |
| Any | 0 | Indicates all node types. Allows to select all children. |
| Document | 1 | A [Document](../document/) object that, as the root of the document tree, provides access to the entire Word document. A [Document](../document/) node can have [Section](../section/) nodes. |
| Section | 2 | A [Section](../section/) object that corresponds to one section in a Word document. A [Section](../section/) node can have **Body** and **HeaderFooter** nodes. |
| Body | 3 | A [Body](../body/) object that contains the main text of a section (main text story). A [Body](../body/) node can have [Paragraph](../paragraph/) and [Table](../../aspose.words.tables/table/) nodes. |
| HeaderFooter | 4 | A [HeaderFooter](../headerfooter/) object that contains text of a particular header or footer inside a section. A [HeaderFooter](../headerfooter/) node can have [Paragraph](../paragraph/) and [Table](../../aspose.words.tables/table/) nodes. |
| Table | 5 | A [Table](../../aspose.words.tables/table/) object that represents a table in a Word document. A [Table](../../aspose.words.tables/table/) node can have [Row](../../aspose.words.tables/row/) nodes. |
| Row | 6 | A row of a table. A [Row](../../aspose.words.tables/row/) node can have [Cell](../../aspose.words.tables/cell/) nodes. |
| Cell | 7 | A cell of a table row. A [Cell](../../aspose.words.tables/cell/) node can have [Paragraph](../paragraph/) and [Table](../../aspose.words.tables/table/) nodes. |
| Paragraph | 8 | A paragraph of text. A [Paragraph](../paragraph/) node is a container for inline level elements [Run](../run/), [FieldStart](../../aspose.words.fields/fieldstart/), [FieldSeparator](../../aspose.words.fields/fieldseparator/), [FieldEnd](../../aspose.words.fields/fieldend/), [FormField](../../aspose.words.fields/formfield/), [Shape](../../aspose.words.drawing/shape/), [GroupShape](../../aspose.words.drawing/groupshape/), [Footnote](../../aspose.words.notes/footnote/), [Comment](../comment/), [SpecialChar](../specialchar/), as well as [BookmarkStart](../bookmarkstart/) and [BookmarkEnd](../bookmarkend/). |
| BookmarkStart | 9 | A beginning of a bookmark marker. |
| BookmarkEnd | 10 | An end of a bookmark marker. |
| EditableRangeStart | 11 | A beginning of an editable range. |
| EditableRangeEnd | 12 | An end of an editable range. |
| MoveFromRangeStart | 13 | A beginning of an MoveFrom range. |
| MoveFromRangeEnd | 14 | An end of an MoveFrom range. |
| MoveToRangeStart | 15 | A beginning of an MoveTo range. |
| MoveToRangeEnd | 16 | An end of an MoveTo range. |
| GroupShape | 17 | A group of shapes, images, OLE objects or other group shapes. A [GroupShape](../../aspose.words.drawing/groupshape/) node can contain other [Shape](../../aspose.words.drawing/shape/) and [GroupShape](../../aspose.words.drawing/groupshape/) nodes. |
| Shape | 18 | A drawing object, such as an OfficeArt shape, image or an OLE object. A [Shape](../../aspose.words.drawing/shape/) node can contain [Paragraph](../paragraph/) and [Table](../../aspose.words.tables/table/) nodes. |
| Comment | 19 | A comment in a Word document. A [Comment](../comment/) node can have [Paragraph](../paragraph/) and [Table](../../aspose.words.tables/table/) nodes. |
| Footnote | 20 | A footnote or endnote in a Word document. A [Footnote](../../aspose.words.notes/footnote/) node can have [Paragraph](../paragraph/) and [Table](../../aspose.words.tables/table/) nodes. |
| Run | 21 | A run of text. |
| FieldStart | 22 | A special character that designates the start of a Word field. |
| FieldSeparator | 23 | A special character that separates the field code from the field result. |
| FieldEnd | 24 | A special character that designates the end of a Word field. |
| FormField | 25 | A form field. |
| SpecialChar | 26 | A special character that is not one of the more specific special character types. |
| SmartTag | 27 | A smart tag around one or more inline structures (runs, images, fields,etc.) within a paragraph. |
| StructuredDocumentTag | 28 | Allows to define customer-specific information and its means of presentation. |
| StructuredDocumentTagRangeStart | 29 | A start of **ranged** structured document tag which accepts multi-sections content. |
| StructuredDocumentTagRangeEnd | 30 | A end of **ranged** structured document tag which accepts multi-sections content. |
| GlossaryDocument | 31 | A glossary document within the main document. |
| BuildingBlock | 32 | A building block within a glossary document (e.g. glossary document entry). |
| CommentRangeStart | 33 | A marker node that represents the start of a commented range. |
| CommentRangeEnd | 34 | A marker node that represents the end of a commented range. |
| OfficeMath | 35 | An Office [Math](../../aspose.words.math/) object. Can be equation, function, matrix or one of other mathematical objects. Can be a collection of mathematical object and also can contain some non-mathematical objects such as runs of text. |
| SubDocument | 36 | A subdocument node which is a link to another document. |
| System | 37 | Reserved for internal use by [Aspose.Words](../). |
| Null | 38 | Reserved for internal use by [Aspose.Words](../). |


## Examples



Shows how to traverse through a composite node's collection of child nodes. 
```cpp
auto doc = MakeObject<Document>();

// Add two runs and one shape as child nodes to the first paragraph of this document.
auto paragraph = System::DynamicCast<Paragraph>(doc->GetChild(NodeType::Paragraph, 0, true));
paragraph->AppendChild(MakeObject<Run>(doc, u"Hello world! "));

auto shape = MakeObject<Shape>(doc, ShapeType::Rectangle);
shape->set_Width(200);
shape->set_Height(200);
// Note that the 'CustomNodeId' is not saved to an output file and exists only during the node lifetime.
shape->set_CustomNodeId(100);
shape->set_WrapType(WrapType::Inline);
paragraph->AppendChild(shape);

paragraph->AppendChild(MakeObject<Run>(doc, u"Hello again!"));

// Iterate through the paragraph's collection of immediate children,
// and print any runs or shapes that we find within.
SharedPtr<NodeCollection> children = paragraph->get_ChildNodes();

ASSERT_EQ(3, paragraph->get_ChildNodes()->get_Count());

for (const auto& child : System::IterateOver(children))
{
    switch (child->get_NodeType())
    {
    case NodeType::Run:
        std::cout << "Run contents:" << std::endl;
        std::cout << "\t\"" << child->GetText().Trim() << "\"" << std::endl;
        break;

    case NodeType::Shape: {
        auto childShape = System::DynamicCast<Shape>(child);
        std::cout << "Shape:" << std::endl;
        std::cout << String::Format(u"\t{0}, {1}x{2}", childShape->get_ShapeType(), childShape->get_Width(), childShape->get_Height()) << std::endl;
        ASSERT_EQ(100, shape->get_CustomNodeId());
        break;
    }

    default:
        break;
    }
}
```

## See Also

* Namespace [Aspose::Words](../)
* Library [Aspose.Words for C++](../../)
