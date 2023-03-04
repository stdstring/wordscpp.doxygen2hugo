using Doxygen2HugoConverter.Config;
using Doxygen2HugoConverter.Logger;
using NUnit.Framework;

namespace Doxygen2HugoConverter.Tests
{
    [TestFixture]
    public class SmokeTests
    {
        [Test]
        public void CollectAndCheck()
        {
            const String sourceData = "..\\..\\..\\..\\..\\SourceData\\Doxygen\\";
            const String expectedData = "..\\..\\..\\..\\..\\DestData";
            const String templates = "..\\..\\..\\..\\..\\SourceData\\Templates\\";
            const String actualData = ".\\out";
            ConfigData configData = new ConfigData(sourceData, actualData, templates, "Aspose::Words", LogLevel.Info);
            Assert.DoesNotThrow(() => ConvertProcessor.Convert(configData));
            CheckTree(expectedData, actualData);
        }

        private void CheckTree(String expectedDirname, String actualDirname)
        {
            String[] expectedFiles = Directory.GetFiles(expectedDirname).Order().ToArray();
            String[] actualFiles = Directory.GetFiles(actualDirname).Order().ToArray();
            Assert.AreEqual(expectedFiles.Length, actualFiles.Length, $"Directories {expectedDirname} and {actualDirname} are differ by file count");
            for (Int32 index = 0; index < expectedFiles.Length; ++index)
            {
                String expectedFilename = Path.GetFileName(expectedFiles[index]);
                String actualFilename = Path.GetFileName(actualFiles[index]);
                Assert.AreEqual(expectedFilename, actualFilename, $"Expects file with name {expectedFilename}, but actual are {actualFilename}");
                CheckContent(expectedFiles[index], actualFiles[index]);
            }
            String[] expectedSubdirs = Directory.GetDirectories(expectedDirname).Order().ToArray();
            String[] actualSubdirs = Directory.GetDirectories(actualDirname).Order().ToArray();
            Assert.AreEqual(expectedFiles.Length, actualFiles.Length, $"Directories {expectedDirname} and {actualDirname} are differ by subdirs count");
            for (Int32 index = 0; index < expectedSubdirs.Length; ++index)
            {
                String expectedSubdirName = new DirectoryInfo(expectedSubdirs[index]).Name;
                String actualSubdirName = new DirectoryInfo(actualSubdirs[index]).Name;
                Assert.AreEqual(expectedSubdirName, actualSubdirName, $"Expects subdir with name {expectedSubdirName}, but actual are {actualSubdirName}");
                CheckTree(expectedSubdirs[index], actualSubdirs[index]);
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
    }
}
