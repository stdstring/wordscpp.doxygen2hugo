using System.Xml.Linq;
using Doxygen2HugoConverter.Config;

namespace Doxygen2HugoConverter.Refs
{
    internal static class RefParser
    {
        public static IList<NamespaceRef> ParseIndexFile(ConfigData config)
        {
            XDocument document = XDocument.Load(Path.Combine(config.SourceDirectory, Common.IndexFilename));
            XElement root = document.Root!;
            return root.Elements("compound").Choose(ParseCompoundElement).ToList();
        }

        public static MemberRef? ParseMemberRef(XElement source)
        {
            String refId = source.GetAttributeValue("refid");
            String name = source.GetChildElementValue("name");
            return source.GetAttributeValue("prot") switch
            {
                "public" => new MemberRef(refId, name),
                _ => null
            };
        }

        private static NamespaceEntityRef? ParseNamespaceEntityRef(XElement source)
        {
            String refId = source.GetAttributeValue("refid");
            String name = source.GetChildElementValue("name");
            return source.GetAttributeValue("kind") switch
            {
                "enum" => new NamespaceEntityRef.EnumEntityRef(refId, name),
                "enumvalue" => null,
                "typedef" => new NamespaceEntityRef.TypedefEntityRef(refId, name),
                _ => throw new InvalidOperationException("Unsupported kind")
            };
        }

        private static NamespaceRef ParseNamespaceRef(this XElement source)
        {
            String refId = source.GetAttributeValue("refid");
            String name = source.GetChildElementValue("name");
            NamespaceEntityRef[] childEntities = source.Elements("member").Choose(ParseNamespaceEntityRef).ToArray();
            return new NamespaceRef(refId, name, childEntities);
        }

        private static NamespaceRef? ParseCompoundElement(XElement source) =>
            source.GetAttributeValue("kind") switch
            {
                "namespace" => source.ParseNamespaceRef(),
                "class" => null,
                "interface" => null,
                "file" => null,
                "dir" => null,
                _ => throw new InvalidOperationException("Unsupported kind")
            };
    }
}
