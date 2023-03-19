---
title: Aspose::Words::IHyphenationCallback interface
linktitle: IHyphenationCallback
second_title: Aspose.Words for C++ API Reference
description: Aspose::Words::IHyphenationCallback interface. Implemented by classes which can register hyphenation dictionaries in C++.
type: docs
weight: 7800
url: /cpp/aspose.words/ihyphenationcallback/
---
## IHyphenationCallback interface


Implemented by classes which can register hyphenation dictionaries.

```cpp
class IHyphenationCallback : public System::Object
```

## Methods

| Method | Description |
| --- | --- |
| virtual [RequestDictionary](./requestdictionary/)(System::String) | Notifies application that hyphenation dictionary for the specified language wasn't found and may need to be registered. Implementation should find a dictionary and register it using [RegisterDictionary()](../) methods. If dictionary is unavailable for the specified language implementation can opt out of further calls for the same language using [RegisterDictionary()](../) with null value. |

## Examples



Shows how to open and register a dictionary from a file. 
```cpp
void RegisterDictionary()
{
    // Set up a callback that tracks warnings that occur during hyphenation dictionary registration.
    auto warningInfoCollection = MakeObject<WarningInfoCollection>();
    Hyphenation::set_WarningCallback(warningInfoCollection);

    // Register an English (US) hyphenation dictionary by stream.
    SharedPtr<System::IO::Stream> dictionaryStream = MakeObject<System::IO::FileStream>(MyDir + u"hyph_en_US.dic", System::IO::FileMode::Open);
    Hyphenation::RegisterDictionary(u"en-US", dictionaryStream);

    ASSERT_EQ(0, warningInfoCollection->get_Count());

    // Open a document with a locale that Microsoft Word may not hyphenate on an English machine, such as German.
    auto doc = MakeObject<Document>(MyDir + u"German text.docx");

    // To hyphenate that document upon saving, we need a hyphenation dictionary for the "de-CH" language code.
    // This callback will handle the automatic request for that dictionary.
    Hyphenation::set_Callback(MakeObject<ExHyphenation::CustomHyphenationDictionaryRegister>());

    // When we save the document, German hyphenation will take effect.
    doc->Save(ArtifactsDir + u"Hyphenation.RegisterDictionary.pdf");

    // This dictionary contains two identical patterns, which will trigger a warning.
    ASSERT_EQ(1, warningInfoCollection->get_Count());
    ASSERT_EQ(WarningType::MinorFormattingLoss, warningInfoCollection->idx_get(0)->get_WarningType());
    ASSERT_EQ(WarningSource::Layout, warningInfoCollection->idx_get(0)->get_Source());
    ASSERT_EQ(String(u"Hyphenation dictionary contains duplicate patterns. The only first found pattern will be used. ") +
                  u"Content can be wrapped differently.",
              warningInfoCollection->idx_get(0)->get_Description());
}

class CustomHyphenationDictionaryRegister : public IHyphenationCallback
{
public:
    CustomHyphenationDictionaryRegister()
    {
        mHyphenationDictionaryFiles = MakeObject<System::Collections::Generic::Dictionary<String, String>>();
        mHyphenationDictionaryFiles->Add(u"en-US", MyDir + u"hyph_en_US.dic");
        mHyphenationDictionaryFiles->Add(u"de-CH", MyDir + u"hyph_de_CH.dic");
    }

    void RequestDictionary(String language) override
    {
        std::cout << (String(u"Hyphenation dictionary requested: ") + language);

        if (Hyphenation::IsDictionaryRegistered(language))
        {
            std::cout << ", is already registered." << std::endl;
            return;
        }

        if (mHyphenationDictionaryFiles->ContainsKey(language))
        {
            Hyphenation::RegisterDictionary(language, mHyphenationDictionaryFiles->idx_get(language));
            std::cout << ", successfully registered." << std::endl;
            return;
        }

        std::cout << ", no respective dictionary file known by this Callback." << std::endl;
    }

private:
    SharedPtr<System::Collections::Generic::Dictionary<String, String>> mHyphenationDictionaryFiles;
};
```

## See Also

* Namespace [Aspose::Words](../)
* Library [Aspose.Words for C++](../../)
