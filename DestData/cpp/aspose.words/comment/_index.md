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
| [Comment](./comment/)(const System::SharedPtr< Aspose::Words::DocumentBase > &) | Initializes a new instance of the **Comment** class.  |
| [Comment](./comment/)(const System::SharedPtr< Aspose::Words::DocumentBase > &, const System::String &, const System::String &, System::DateTime) | Initializes a new instance of the **Comment** class.  |
| [Accept](./accept/)(System::SharedPtr< Aspose::Words::DocumentVisitor >) override | Accepts a visitor.  |
| [AddReply](./addreply/)(const System::String &, const System::String &, System::DateTime, const System::String &) | Adds a reply to this comment.  |
| [get_Ancestor](./get_ancestor/)() | Returns the parent Comment object. Returns null for top-level comments.  |
| [get_Author](./get_author/)() const | Returns or sets the author name for a comment.  |
| [get_DateTime](./get_datetime/)() const | Gets the date and time that the comment was made.  |
| [get_Done](./get_done/)() const | Gets or sets flag indicating that the comment has been marked done.  |
| [get_Id](./get_id/)() const | Gets the comment identifier.  |
| [get_Initial](./get_initial/)() const | Returns or sets the initials of the user associated with a specific comment.  |
| [get_NodeType](./get_nodetype/)() const override | Returns **NodeType.Comment**.  |
| [get_Replies](./get_replies/)() | Returns a collection of Comment objects that are immediate children of the specified comment.  |
| [get_StoryType](./get_storytype/)() override | Returns **StoryType.Comments**.  |
| [RemoveAllReplies](./removeallreplies/)() | Removes all replies to this comment.  |
| [RemoveReply](./removereply/)(const System::SharedPtr< Aspose::Words::Comment > &) | Removes the specified reply to this comment.  |
| [set_Author](./set_author/)(const System::String &) | Setter for Aspose::Words::Comment::get_Author.  |
| [set_DateTime](./set_datetime/)(System::DateTime) | Setter for Aspose::Words::Comment::get_DateTime.  |
| [set_Done](./set_done/)(bool) | Setter for Aspose::Words::Comment::get_Done.  |
| [set_Initial](./set_initial/)(const System::String &) | Setter for Aspose::Words::Comment::get_Initial.  |
| [SetText](./settext/)(const System::String &) | This is a convenience method that allows to easily set text of the comment.  |
