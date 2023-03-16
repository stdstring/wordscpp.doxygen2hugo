using Doxygen2HugoConverter.Lookup;
using NUnit.Framework;

namespace Doxygen2HugoConverter.Tests.Lookup
{
    internal static class LookupDataChecker
    {
        public static void Check(LookupData expected, LookupData actual)
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
                Check(expected.Children[index], actual.Children[index]);
        }

        public static void Check(LookupItem expected, LookupItem actual)
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
                Check(expected.Children[index], actual.Children[index]);
        }
    }
}
