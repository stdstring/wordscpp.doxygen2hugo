## Utility for convertation of documentation for doxygen in the XML format into the "markdown" format for HUGO

### Requirements

1. Documentation for **doxygen** in the XML format
1. .NET version 7 or higher

### Usage

```
Doxygen2HugoConverter.exe --source=<source-dir> --dest=<dest-dir> --log-level=<log-level> --specific-source=<specific-sourcefile>
```

Here:

* ```<source-dir>``` - root directory with documentation for **doxygen** in the XML format.
* ```<dest-dir>``` - directory for generated result.
* ```<log-level>``` - logging level (one frone the following values ```info```, ```warning```, ```error```; default value is ```info```).
* ```<specific-sourcefile>``` - path to the file with library-specific information

Library-specific information is stored in an XML file; for **Aspose.Words for C++** library, it has the following form:
```
<SpecificInfo>
    <LibraryName>Aspose.Words</LibraryName>
    <RootPageTitle>Aspose.Words for C++</RootPageTitle>
    <RootPageKeywords>"Aspose.Words for C++, Aspose Words, Aspose API Reference."</RootPageKeywords>
    <RootPageDescription>Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks.</RootPageDescription>
    <PageSecondTitle>Aspose.Words for C++ API Reference</PageSecondTitle>
    <IngoredNamespaces>
        <Namespace>namespace_aspose</Namespace>
        <Namespace>namespacestd</Namespace>
    </IngoredNamespaces>
</SpecificInfo>
```

**Attention!**. This utility is checked only for **Aspose.Words for C++** documentation. Nobody is guaranted, that this utility will work correctly for documentations of any other products on C++ without modifications.
