---
title: IHyphenationCallback
second_title: Aspose.Words for C++ API Reference
description: Implemented by classes which can register hyphenation dictionaries. 
type: docs
weight: 0
url: /cpp/aspose.words/ihyphenationcallback/
---
## IHyphenationCallback class


Implemented by classes which can register hyphenation dictionaries. 

## Methods

| Method | Description |
| --- | --- |
| virtual [RequestDictionary](./requestdictionary/)(System::String) | Notifies application that hyphenation dictionary for the specified language wasn't found and may need to be registered. Implementation should find a dictionary and register it using RegisterDictionary() methods. If dictionary is unavailable for the specified language implementation can opt out of further calls for the same language using RegisterDictionary() with null value.  |
