---
title: SetMeteredKey
second_title: Aspose.Words for C++ API Reference
description: Sets metered public and private key. If you purchase metered license, when start application, this API should be called, normally, this is enough. However, if always fail to upload consumption data and exceed 24 hours, the license will be set to evaluation status, to avoid such case, you should regularly check the license status, if it is evaluation status, call this API again. 
type: docs
weight: 0
url: /cpp/aspose.words/metered/setmeteredkey/
---
## Metered.SetMeteredKey method


Sets metered public and private key. If you purchase metered license, when start application, this API should be called, normally, this is enough. However, if always fail to upload consumption data and exceed 24 hours, the license will be set to evaluation status, to avoid such case, you should regularly check the license status, if it is evaluation status, call this API again.

```cpp
void Aspose::Words::Metered::SetMeteredKey(const System::String &publicKey, const System::String &privateKey)
```

