---
title: StreamFontSource
second_title: Aspose.Words for C++ API Reference
description: Base class for user-defined stream font source. 
type: docs
weight: 0
url: /cpp/aspose.words.fonts/streamfontsource/
---
## StreamFontSource class


Base class for user-defined stream font source. 

## Methods

| Method | Description |
| --- | --- |
| [get_CacheKey](./get_cachekey/)() const | The key of this source in the cache.  |
| [get_Priority](../fontsourcebase/get_priority/)() const | Returns the font source priority.  |
| [get_Type](./get_type/)() override | Returns the type of the font source.  |
| [get_WarningCallback](../fontsourcebase/get_warningcallback/)() const | Called during processing of font source when an issue is detected that might result in formatting fidelity loss.  |
| [GetAvailableFonts](../fontsourcebase/getavailablefonts/)() | Returns list of fonts available via this source.  |
| virtual [OpenFontDataStream](./openfontdatastream/)() | This method should open the stream with font data on demand.  |
| [set_WarningCallback](../fontsourcebase/set_warningcallback/)(const System::SharedPtr< Aspose::Words::IWarningCallback > &) | Setter for Aspose::Words::Fonts::FontSourceBase::get_WarningCallback.  |
