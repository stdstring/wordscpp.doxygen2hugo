using System.Xml.Serialization;

namespace Doxygen2HugoConverter.Lookup
{
    [XmlRoot("LookupItem")]
    public class LookupItem
    {
        public LookupItem()
        {
        }

        public LookupItem(String name, Int32 weight)
        {
            Name = name;
            Weight = weight;
        }

        public LookupItem(String name, Int32 weight, LookupItem[]? children)
        {
            Name = name;
            Weight = weight;
            Children = children;
        }

        [XmlAttribute("Name")]
        public String Name { get; set; } = "";

        [XmlAttribute("Weight")]
        public Int32 Weight { get; set; }

        [XmlElement("LookupItem")]
        public LookupItem[]? Children { get; set; }
    }

    [XmlRoot("LookupData")]
    public class LookupData
    {
        public LookupData()
        {
        }

        public LookupData(Int32 delta)
        {
            Delta = delta;
        }

        public LookupData(Int32 delta, LookupItem[]? children)
        {
            Delta = delta;
            Children = children;
        }

        [XmlAttribute("Delta")]
        public Int32 Delta { get; set; }

        [XmlElement("LookupItem")]
        public LookupItem[]? Children { get; set; }
    }
}
