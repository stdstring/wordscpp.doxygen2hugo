---
title: UnregisterDictionary
second_title: Aspose.Words for C++ API Reference
description: Unregisters a hyphenation dictionary for the specified language. This is different from registering Null dictionary. Unregistering a dictionary enables callback for the specified language. 
type: docs
weight: 79
url: /cpp/aspose.words/hyphenation/unregisterdictionary/
---
## Hyphenation.UnregisterDictionary method


Unregisters a hyphenation dictionary for the specified language. This is different from registering Null dictionary. Unregistering a dictionary enables callback for the specified language.

```cpp
static void Aspose::Words::Hyphenation::UnregisterDictionary(const System::String &language)
```


| Parameter | Type | Description |
| --- | --- | --- |
| language | const System::String\& | A language name, e.g. "en-US". See .NET documentation for "culture name" and RFC 4646 for details. If null or empty string then all dictionaries are unregistered. |

## Examples




Shows how to register a hyphenation dictionary. 
```cpp
// A hyphenation dictionary contains a list of strings that define hyphenation rules for the dictionary's language.
// When a document contains lines of text in which a word could be split up and continued on the next line,
// hyphenation will look through the dictionary's list of strings for that word's substrings.
// If the dictionary contains a substring, then hyphenation will split the word across two lines
// by the substring and add a hyphen to the first half.
// Register a dictionary file from the local file system to the "de-CH" locale.
Hyphenation::RegisterDictionary(u"de-CH", MyDir + u"hyph_de_CH.dic");

ASSERT_TRUE(Hyphenation::IsDictionaryRegistered(u"de-CH"));

// Open a document containing text with a locale matching that of our dictionary,
// and save it to a fixed-page save format. The text in that document will be hyphenated.
auto doc = MakeObject<Document>(MyDir + u"German text.docx");

ASSERT_TRUE(doc->get_FirstSection()->get_Body()->get_FirstParagraph()->get_Runs()->LINQ_OfType<SharedPtr<Run>>()->LINQ_All(
    [](SharedPtr<Run> r) { return r->get_Font()->get_LocaleId() == MakeObject<System::Globalization::CultureInfo>(u"de-CH")->get_LCID(); }));

doc->Save(ArtifactsDir + u"Hyphenation.Dictionary.Registered.pdf");

// Re-load the document after un-registering the dictionary,
// and save it to another PDF, which will not have hyphenated text.
Hyphenation::UnregisterDictionary(u"de-CH");

ASSERT_FALSE(Hyphenation::IsDictionaryRegistered(u"de-CH"));

doc = MakeObject<Document>(MyDir + u"German text.docx");
doc->Save(ArtifactsDir + u"Hyphenation.Dictionary.Unregistered.pdf");
```

