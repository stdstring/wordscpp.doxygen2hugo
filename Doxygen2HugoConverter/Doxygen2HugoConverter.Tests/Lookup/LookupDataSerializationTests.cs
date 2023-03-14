using System.Xml.Serialization;
using Doxygen2HugoConverter.Lookup;
using NUnit.Framework;

namespace Doxygen2HugoConverter.Tests.Lookup
{
    [TestFixture]
    public class LookupDataSerializationTests
    {
        [Test]
        public void SerializeTest()
        {
            LookupData source = new LookupData(500,
                new []
                {
                    new LookupItem("Aspose::Words", 500, new []{new LookupItem("Body", 500), new LookupItem("Node", 1000)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 1000),
                    new LookupItem("Aspose::Words::Field", 1500, new []{new LookupItem("Field", 500), new LookupItem("FieldChar", 1000)}),
                });
            const String expected = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n" +
                                    "<LookupData xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" Delta=\"500\">\r\n" +
                                    "  <LookupItem Name=\"Aspose::Words\" Weight=\"500\">\r\n" +
                                    "    <LookupItem Name=\"Body\" Weight=\"500\" />\r\n" +
                                    "    <LookupItem Name=\"Node\" Weight=\"1000\" />\r\n" +
                                    "  </LookupItem>\r\n  <LookupItem Name=\"Aspose::Words::BuildingBlocks\" Weight=\"1000\" />\r\n" +
                                    "  <LookupItem Name=\"Aspose::Words::Field\" Weight=\"1500\">\r\n" +
                                    "    <LookupItem Name=\"Field\" Weight=\"500\" />\r\n" +
                                    "    <LookupItem Name=\"FieldChar\" Weight=\"1000\" />\r\n" +
                                    "  </LookupItem>\r\n" +
                                    "</LookupData>";
            XmlSerializer serializer = new XmlSerializer(typeof(LookupData));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, source);
                Assert.AreEqual(expected, writer.ToString());
            }
        }

        [Test]
        public void DeserializeTest()
        {
            const String source = "<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n" +
                                  "<LookupData Delta=\"500\">\r\n" +
                                  "  <LookupItem Name=\"Aspose::Words\" Weight=\"500\">\r\n" +
                                  "    <LookupItem Name=\"Body\" Weight=\"500\" />\r\n" +
                                  "    <LookupItem Name=\"Node\" Weight=\"1000\" />\r\n" +
                                  "  </LookupItem>\r\n  <LookupItem Name=\"Aspose::Words::BuildingBlocks\" Weight=\"1000\" />\r\n" +
                                  "  <LookupItem Name=\"Aspose::Words::Field\" Weight=\"1500\">\r\n" +
                                  "    <LookupItem Name=\"Field\" Weight=\"500\" />\r\n" +
                                  "    <LookupItem Name=\"FieldChar\" Weight=\"1000\" />\r\n" +
                                  "  </LookupItem>\r\n" +
                                  "</LookupData>";
            LookupData expected = new LookupData(500,
                new[]
                {
                    new LookupItem("Aspose::Words", 500, new []{new LookupItem("Body", 500), new LookupItem("Node", 1000)}),
                    new LookupItem("Aspose::Words::BuildingBlocks", 1000),
                    new LookupItem("Aspose::Words::Field", 1500, new []{new LookupItem("Field", 500), new LookupItem("FieldChar", 1000)}),
                });
            XmlSerializer serializer = new XmlSerializer(typeof(LookupData));
            using (StringReader reader = new StringReader(source))
            {
                LookupData? actual = serializer.Deserialize(reader) as LookupData;
                Assert.IsNotNull(actual);
                CheckLookupData(expected, actual!);
            }
        }

        private void CheckLookupData(LookupData expected, LookupData actual)
        {
            Assert.AreEqual(expected.Delta, actual.Delta);
            if (expected.Children == null)
            {
                Assert.IsNull(actual.Children);
                return;
            }
            Assert.IsNotNull(actual.Children);
            Assert.AreEqual(expected.Children!.Length, actual.Children!.Length);
            for (Int32 index = 0; index < expected.Children.Length; ++index)
                CheckLookupItem(expected.Children[index], actual.Children[index]);
        }

        private void CheckLookupItem(LookupItem expected, LookupItem actual)
        {
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Weight, actual.Weight);
            if (expected.Children == null)
            {
                Assert.IsNull(actual.Children);
                return;
            }
            Assert.IsNotNull(actual.Children);
            Assert.AreEqual(expected.Children!.Length, actual.Children!.Length);
            for (Int32 index = 0; index < expected.Children.Length; ++index)
                CheckLookupItem(expected.Children[index], actual.Children[index]);
        }
    }
}
