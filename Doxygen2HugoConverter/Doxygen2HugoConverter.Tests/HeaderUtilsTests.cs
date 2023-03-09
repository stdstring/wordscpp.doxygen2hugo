using NUnit.Framework;

namespace Doxygen2HugoConverter.Tests
{
    [TestFixture]
    public class HeaderUtilsTests
    {
        [Test]
        public void ParseDataTests()
        {
            const String source = "---\r\n" +
                                  "title: Aspose.Words for C++\r\n" +
                                  "linktitle: Aspose.Words for C++\r\n" +
                                  "type: docs\r\n" +
                                  "weight: 10\r\n" +
                                  "url: /cpp/\r\n" +
                                  "keywords: \"Aspose.Words for C++, Aspose Words, Aspose API Reference.\"\r\n" +
                                  "description: \"Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks.\"\r\n" +
                                  "is_root: true\r\n" +
                                  "---";
            IDictionary<String, String> expectedData = new Dictionary<String, String>
            {
                {"title", "Aspose.Words for C++"},
                {"linktitle", "Aspose.Words for C++"},
                {"type", "docs"},
                {"weight", "10"},
                {"url", "/cpp/"},
                {"keywords", "\"Aspose.Words for C++, Aspose Words, Aspose API Reference.\""},
                {"description", "\"Aspose.Words is a class library that can be used by developers for various platforms for a variety of document processing tasks.\""},
                {"is_root", "true"}
            };
            Assert.That(HeaderUtils.ParseData(source), Is.EquivalentTo(expectedData));
        }
    }

    [TestFixture]
    public class HeaderTemplateTests
    {
        [Test]
        public void CreateFromSourceTest()
        {
            const String source = "---\r\n" +
                                  "title: $title\r\n" +
                                  "linktitle: $linktitle\r\n" +
                                  "second_title: Aspose.Words for C++ API Reference\r\n" +
                                  "description: $description in C++.\r\n" +
                                  "type: docs\r\n" +
                                  "weight: $weight\r\n" +
                                  "url: /cpp/$ref/\r\n" +
                                  "---";
            Func<IDictionary<String, String>, String> generatorFunc = HeaderTemplateFactory.CreateFromSource(source);
            const String expected = "---\r\n" +
                                    "title: Aspose::Words::Document::Accept method\r\n" +
                                    "linktitle: Accept\r\n" +
                                    "second_title: Aspose.Words for C++ API Reference\r\n" +
                                    "description: Aspose::Words::Document::Accept method. Accepts a visitor in C++.\r\n" +
                                    "type: docs\r\n" +
                                    "weight: 14\r\n" +
                                    "url: /cpp/aspose.words/document/accept/\r\n" +
                                    "---";
            Assert.AreEqual(expected, generatorFunc(new Dictionary<String, String>
            {
                {"title", "Aspose::Words::Document::Accept method"},
                {"linktitle", "Accept"},
                {"description", "Aspose::Words::Document::Accept method. Accepts a visitor"},
                {"weight", "14"},
                {"ref", "aspose.words/document/accept"}
            }));
        }
    }
}
