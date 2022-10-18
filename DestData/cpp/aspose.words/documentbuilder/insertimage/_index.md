---
title: InsertImage
second_title: Aspose.Words for C++ API Reference
description: Inserts an image from a byte array into the document. The image is inserted inline and at 100% scale. 
type: docs
weight: 0
url: /cpp/aspose.words/documentbuilder/insertimage/
---
## DocumentBuilder.InsertImage(const System::ArrayPtr\<uint8_t\>\&) method


Inserts an image from a byte array into the document. The image is inserted inline and at 100% scale.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::ArrayPtr<uint8_t> &imageBytes)
```

## DocumentBuilder.InsertImage(const System::ArrayPtr\<uint8_t\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method


Inserts an image from a byte array at the specified position and size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::ArrayPtr<uint8_t> &imageBytes, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```

## DocumentBuilder.InsertImage(const System::ArrayPtr\<uint8_t\>\&, double, double) method


Inserts an inline image from a byte array into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::ArrayPtr<uint8_t> &imageBytes, double width, double height)
```

## DocumentBuilder.InsertImage(const System::SharedPtr\<System::Drawing::Image\>\&) method


Inserts an image from a **Image** object into the document. The image is inserted inline and at 100% scale.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::SharedPtr<System::Drawing::Image> &image)
```

## DocumentBuilder.InsertImage(const System::SharedPtr\<System::Drawing::Image\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method


Inserts an image from a **Image** object at the specified position and size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::SharedPtr<System::Drawing::Image> &image, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```

## DocumentBuilder.InsertImage(const System::SharedPtr\<System::Drawing::Image\>\&, double, double) method


Inserts an inline image from a **Image** object into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::SharedPtr<System::Drawing::Image> &image, double width, double height)
```

## DocumentBuilder.InsertImage(const System::SharedPtr\<System::IO::Stream\>\&) method


Inserts an image from a stream into the document. The image is inserted inline and at 100% scale.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::SharedPtr<System::IO::Stream> &stream)
```

## DocumentBuilder.InsertImage(const System::SharedPtr\<System::IO::Stream\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method


Inserts an image from a stream at the specified position and size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::SharedPtr<System::IO::Stream> &stream, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```

## DocumentBuilder.InsertImage(const System::SharedPtr\<System::IO::Stream\>\&, double, double) method


Inserts an inline image from a stream into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::SharedPtr<System::IO::Stream> &stream, double width, double height)
```

## DocumentBuilder.InsertImage(const System::String\&) method


Inserts an image from a file or URL into the document. The image is inserted inline and at 100% scale.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::String &fileName)
```

## DocumentBuilder.InsertImage(const System::String\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method


Inserts an image from a file or URL at the specified position and size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::String &fileName, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```

## DocumentBuilder.InsertImage(const System::String\&, double, double) method


Inserts an inline image from a file or URL into the document and scales it to the specified size.

```cpp
System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(const System::String &fileName, double width, double height)
```

## DocumentBuilder.InsertImage(std::basic_istream\<CharType, Traits\>\&) method




```cpp
template<typename CharType,typename Traits> System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(std::basic_istream<CharType, Traits> &stream)
```

## DocumentBuilder.InsertImage(std::basic_istream\<CharType, Traits\>\&, Aspose::Words::Drawing::RelativeHorizontalPosition, double, Aspose::Words::Drawing::RelativeVerticalPosition, double, double, double, Aspose::Words::Drawing::WrapType) method




```cpp
template<typename CharType,typename Traits> System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(std::basic_istream<CharType, Traits> &stream, Aspose::Words::Drawing::RelativeHorizontalPosition horzPos, double left, Aspose::Words::Drawing::RelativeVerticalPosition vertPos, double top, double width, double height, Aspose::Words::Drawing::WrapType wrapType)
```

## DocumentBuilder.InsertImage(std::basic_istream\<CharType, Traits\>\&, double, double) method




```cpp
template<typename CharType,typename Traits> System::SharedPtr<Aspose::Words::Drawing::Shape> Aspose::Words::DocumentBuilder::InsertImage(std::basic_istream<CharType, Traits> &stream, double width, double height)
```

