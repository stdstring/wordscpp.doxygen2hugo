using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Logger;
using Doxygen2HugoConverter.Lookup;
using NUnit.Framework;
using System.Xml.Serialization;

namespace Doxygen2HugoConverter.Tests
{
    [TestFixture]
    public class IntegrationTests
    {
        [TestCase("WithoutSourceWeights", false)]
        [TestCase("EmptySourceWeights", true)]
        [TestCase("SourceWithoutChanges", true)]
        [TestCase("SourceWithRemove", true)]
        [TestCase("SourceWithAdd", true)]
        [TestCase("SourceWithAddRemove", true)]
        [TestCase("SourceWithAddWithShift", true)]
        [Explicit]
        public void GenerateExpectedWeights(String testSubdir, Boolean hasSourceWeights)
        {
            ConvertData(testSubdir, hasSourceWeights, true);
            String expectedWeightsPath = Path.Combine(IntegrationTestsData, testSubdir, ExpectedWeightsFilename);
            File.Copy(DestWeightsPath, expectedWeightsPath, true);
        }

        [TestCase("WithoutSourceWeights", false, false)]
        [TestCase("WithoutSourceWeights", false, true)]
        [TestCase("EmptySourceWeights", true, false)]
        [TestCase("EmptySourceWeights", true, true)]
        [TestCase("SourceWithoutChanges", true, false)]
        [TestCase("SourceWithoutChanges", true, true)]
        // Aspose::Words::BuildingBlocks namespace contains SomeUnknownEnum enum definition in the source weights
        [TestCase("SourceWithRemove", true, false)]
        [TestCase("SourceWithRemove", true, true)]
        // Aspose::Words::BuildingBlocks namespace without BuildingBlock,
        //                                                 GlossaryDocument,
        //                                                 BuildingBlockBehavior,
        //                                                 BuildingBlockType definitions in the source weights
        [TestCase("SourceWithAdd", true, false)]
        [TestCase("SourceWithAdd", true, true)]
        // Aspose::Words::BuildingBlocks namespace contains SomeUnknownEnum enum definition and
        // without GlossaryDocument, BuildingBlockBehavior definitions in the source weights
        [TestCase("SourceWithAddRemove", true, false)]
        [TestCase("SourceWithAddRemove", true, true)]
        // Aspose::Words::Loading namespace contains ChmLoadOptions,
        //                                           HtmlLoadOptions,
        //                                           LanguagePreferences,
        //                                           LoadOptions,
        //                                           ResourceLoadingArgs,
        //                                           RtfLoadOptions,
        //                                           TxtLoadOptions,
        //                                           IDocumentLoadingCallback,
        //                                           IResourceLoadingCallback,
        //                                           TxtTrailingSpacesOptions definitions in the source weights
        [TestCase("SourceWithAddWithShift", true, false)]
        [TestCase("SourceWithAddWithShift", true, true)]
        public void ConvertAndCheck(String testSubdir, Boolean hasSourceWeights, Boolean generateDestWeights)
        {
            ConvertData(testSubdir, hasSourceWeights, generateDestWeights);
            String expectedWeightsPath = Path.Combine(IntegrationTestsData, testSubdir, ExpectedWeightsFilename);
            CheckTree(ExpectedData, expectedWeightsPath, ActualData + "cpp\\");
            if (generateDestWeights)
                CheckContent(expectedWeightsPath, DestWeightsPath);
        }

        private void ConvertData(String testSubdir, Boolean hasSourceWeights, Boolean hasDestWeights)
        {
            if (Directory.Exists(DestRoot))
                Directory.Delete(DestRoot, true);
            String? sourceWeights = hasSourceWeights ? Path.Combine(IntegrationTestsData, testSubdir, SourceWeightsFilename) : null;
            String? destWeights = hasDestWeights ? DestWeightsPath : null;
            ConfigData configData = new ConfigData(SourceData, ActualData, Templates, "Aspose::Words", LogLevel.Error, sourceWeights, destWeights);
            Assert.DoesNotThrow(() => ConvertProcessor.Convert(configData));
        }

        private void CheckTree(String expectedDirname, String expectedWeightsPath, String actualDirname)
        {
            LookupData lookupData = RetrieveExpectedWeights(expectedWeightsPath);
            LookupItem rootItem = new LookupItem(String.Empty, 10, lookupData.Children);
            CheckTree(expectedDirname, rootItem, actualDirname);
        }

        private void CheckTree(String expectedDirname, LookupItem currentItem, String actualDirname)
        {
            // process _index.md
            String expectedFile = Directory.GetFiles(expectedDirname).Single();
            String actualFile = Directory.GetFiles(actualDirname).Single();
            CheckContent(expectedFile, currentItem.Weight, actualFile);
            // process subdirs
            IDictionary<String, LookupItem> lookupItemsMap = (currentItem.Children ?? Array.Empty<LookupItem>()).ToDictionary(item => ConvertName(item.Name));
            String[] expectedSubdirs = Directory.GetDirectories(expectedDirname).Order().ToArray();
            String[] actualSubdirs = Directory.GetDirectories(actualDirname).Order().ToArray();
            Assert.AreEqual(expectedSubdirs.Length, actualSubdirs.Length, $"Directories {expectedDirname} and {actualDirname} are differ by subdirs count");
            for (Int32 index = 0; index < expectedSubdirs.Length; ++index)
            {
                String expectedSubdirName = new DirectoryInfo(expectedSubdirs[index]).Name;
                String actualSubdirName = new DirectoryInfo(actualSubdirs[index]).Name;
                Assert.AreEqual(expectedSubdirName, actualSubdirName, $"Expects subdir with name {expectedSubdirName}, but actual are {actualSubdirName}");
                LookupItem expectedLookupItem = lookupItemsMap[expectedSubdirName];
                CheckTree(expectedSubdirs[index], expectedLookupItem, actualSubdirs[index]);
            }
        }

        private void CheckContent(String expectedFilename, Int32 expectedWeight, String actualFilename)
        {
            const String weightHeaderPrefix = "weight: ";
            String[] expectedLines = File.ReadAllLines(expectedFilename);
            String[] actualLines = File.ReadAllLines(actualFilename);
            Assert.AreEqual(expectedLines.Length, actualLines.Length, $"Files {expectedFilename} and {actualFilename} are differ by line count");
            Boolean weightChecked = false;
            for (Int32 index = 0; index < expectedLines.Length; ++index)
            {
                if (!weightChecked && expectedLines[index].StartsWith(weightHeaderPrefix))
                {
                    String expectedLine = $"weight: {expectedWeight}";
                    Assert.AreEqual(expectedLine, actualLines[index], $"Files {expectedFilename} and {actualFilename} have different lines with index {index}");
                    weightChecked = true;
                }
                else
                    Assert.AreEqual(expectedLines[index], actualLines[index], $"Files {expectedFilename} and {actualFilename} have different lines with index {index}");
            }
        }

        private void CheckContent(String expectedFilename, String actualFilename)
        {
            String[] expectedLines = File.ReadAllLines(expectedFilename);
            String[] actualLines = File.ReadAllLines(actualFilename);
            Assert.AreEqual(expectedLines.Length, actualLines.Length, $"Files {expectedFilename} and {actualFilename} are differ by line count");
            for (Int32 index = 0; index < expectedLines.Length; ++index)
                Assert.AreEqual(expectedLines[index], actualLines[index], $"Files {expectedFilename} and {actualFilename} have different lines with index {index}");
        }

        private static String ConvertName(String sourceName) => sourceName.ToLower().Replace("::", ".");

        private static LookupData RetrieveExpectedWeights(String expectedWeightsPath)
        {
            Assert.True(File.Exists(expectedWeightsPath));
            XmlSerializer serializer = new XmlSerializer(typeof(LookupData));
            using (StreamReader reader = new StreamReader(expectedWeightsPath))
                return (LookupData)serializer.Deserialize(reader)!;
        }

        private const String SourceRoot = "..\\..\\..\\..\\..\\SourceData\\";
        private const String SourceData = SourceRoot + "Doxygen\\";
        private const String Templates = SourceRoot + "Templates\\";
        private const String IntegrationTestsData = SourceRoot + "IntegrationTests\\";
        private const String ExpectedData = "..\\..\\..\\..\\..\\DestData\\cpp\\";
        private const String DestRoot = ".\\Output\\";
        private const String ActualData = DestRoot + "Data\\";
        private const String SourceWeightsFilename = "SourceWeights.xml";
        private const String ExpectedWeightsFilename = "ExpectedWeights.xml";
        private const String DestWeightsPath = DestRoot + "DestWeights.xml";
    }
}
