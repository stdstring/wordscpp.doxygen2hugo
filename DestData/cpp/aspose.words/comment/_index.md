---
title: Comment
second_title: Aspose.Words for C++ API Reference
description: Represents a container for text of a comment. 
type: docs
weight: 0
url: /cpp/aspose.words/comment/
---
## Comment class


Represents a container for text of a comment. 

## Methods

| Method | Description |
| --- | --- |
|  [Comment](./comment/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Comment** class.  |
|  [Comment](./comment/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, const System::String &, const System::String &, System::DateTime) | Initializes a new instance of the **Comment** class.  |
| bool [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| System::SharedPtr< Aspose::Words::Comment > [AddReply](./addreply/)(const System::String &, const System::String &, System::DateTime, const System::String &) | Adds a reply to this comment.  |
| System::SharedPtr< Aspose::Words::Comment > [get_Ancestor](./get_ancestor/)() | Returns the parent Comment object. Returns null for top-level comments.  |
| System::String [get_Author](./get_author/)() const | Returns or sets the author name for a comment.  |
| System::DateTime [get_DateTime](./get_datetime/)() const | Gets the date and time that the comment was made.  |
| bool [get_Done](./get_done/)() const | Gets or sets flag indicating that the comment has been marked done.  |
| int32_t [get_Id](./get_id/)() const | Gets the comment identifier.  |
| System::String [get_Initial](./get_initial/)() const | Returns or sets the initials of the user associated with a specific comment.  |
| Aspose::Words::NodeType [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Comment**.  |
| System::SharedPtr< Aspose::Words::CommentCollection > [get_Replies](./get_replies/)() | Returns a collection of Comment objects that are immediate children of the specified comment.  |
| Aspose::Words::StoryType [get_StoryType](./get_storytype/)() override | Returns **StoryType.Comments**.  |
| void [RemoveAllReplies](./removeallreplies/)() | Removes all replies to this comment.  |
| void [RemoveReply](./removereply/)(const System::SharedPtr< Aspose::Words::Comment > &) | Removes the specified reply to this comment.  |
| void [set_Author](./set_author/)(const System::String &) | Setter for Aspose::Words::Comment::get_Author.  |
| void [set_DateTime](./set_datetime/)(System::DateTime) | Setter for Aspose::Words::Comment::get_DateTime.  |
| void [set_Done](./set_done/)(bool) | Setter for Aspose::Words::Comment::get_Done.  |
| void [set_Initial](./set_initial/)(const System::String &) | Setter for Aspose::Words::Comment::get_Initial.  |
| void [SetText](./settext/)(const System::String &) | This is a convenience method that allows to easily set text of the comment.  |
