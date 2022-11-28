using System.Xml.Serialization;

namespace Doxygen2HugoConverter;

[XmlRoot("SpecificInfo")]
public class SpecificInfo
{
    [XmlElement("LibraryName")]
    public String LibraryName { get; set; } = "";

    [XmlElement("RootPageTitle")]
    public String RootPageTitle { get; set; } = "";

    [XmlElement("RootPageKeywords")]
    public String RootPageKeywords { get; set; } = "";

    [XmlElement("RootPageDescription")]
    public String RootPageDescription { get; set; } = "";

    [XmlElement("PageSecondTitle")]
    public String PageSecondTitle { get; set; } = "";

    [XmlArray("IngoredNamespaces")]
    [XmlArrayItem("Namespace")]
    public String[] IngoredNamespaces { get; set; } = Array.Empty<String>();
}