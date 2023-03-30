## Utility for convertation of documentation for doxygen in the XML format into the "markdown" format for HUGO

### Requirements

1. Documentation for **doxygen** in the XML format
1. .NET version 7 or higher

### Usage

```
Doxygen2HugoConverter.exe --source=<source-dir>
                          --dest=<dest-dir>
                          --templates=<templates-dir>
                          --namespace=<namespace-prefix>
                          --log-level=<log-level>
                          --source-weight=<source-weights-path>
                          --dest-weight=<dest-weights-path>
```

Here:

* ```<source-dir>``` - root directory with documentation for **doxygen** in the XML format.
* ```<dest-dir>``` - directory for generated result.
* ```<templates-dir>``` - directory with templates for pages headers (e.g., see here https://github.com/Aspose/API-Reference-Front-Matters/tree/main/cpp/words).
* ```<namespace-prefix>``` - prefix of namespaces, which we want to process (e.g., Aspose::Words).
* ```<log-level>``` - logging level (one frone the following values ```info```, ```warning```, ```error```; default value is ```info```).
* ```<source-weights-path>``` - path to file with source weights; can be omitted - in this case, weights will be generated with delta defined inside the app.
* ```<dest-weights-path>``` - path to file with dest weights; can be omitted - in this case, weights won't be saved into the file.

Empty data about weights has the following view:
```
<LookupData Delta="1000" />
```
In common form, data about weights has the following view:
```
<LookupData Delta="1000">
  <LookupItem Name="Aspose::Words" Weight="1000">
    <LookupItem Name="AbsolutePositionTab" Weight="1000">
      <LookupItem Name="Accept" Weight="1000" />
      ...
    </LookupItem>
    ...
  </LookupItem>
  ...
</LookupData>
```

**Attention!**. This utility is checked only for **Aspose.Words for C++** documentation. Nobody is guaranted, that this utility will work correctly for documentations of any other products on C++ without modifications.
