using System.Xml.Linq;

namespace Doxygen2HugoConverter
{
    internal static class XUtils
    {
        public static String GetAttributeValue(this XElement source, String attributeName) =>
            source.Attributes(attributeName).Single().Value;

        public static String? FindAttributeValue(this XElement source, String attributeName) =>
            source.Attribute(attributeName)?.Value;

        public static XElement GetChildElement(this XElement source, String elementName) =>
            source.Elements(elementName).Single();

        public static String GetChildElementValue(this XElement source, String elementName) =>
            source.GetChildElement(elementName).Value;

        public static String? FindChildElementValue(this XElement source, String elementName) =>
            source.Element(elementName)?.Value;
    }

    internal static class NameUtils
    {
        public static String CreateNamespaceFolderName(String name) =>
            name.ToLower().Replace("::", ".");

        public static String CreateSimpleFolderName(String name) => name.ToLower();

        public static String GetClassName(String fullName)
        {
            switch (fullName.LastIndexOf(Common.NameDelimiter, StringComparison.Ordinal))
            {
                case var lastDelimiterPos when lastDelimiterPos > 0:
                    return fullName.Substring(lastDelimiterPos + Common.NameDelimiter.Length);
                default:
                    throw new InvalidOperationException("Bad class name");
            }
        }
    }

    internal static class EnumerableUtils
    {
        public static IEnumerable<TItem> Choose<TItem>(this IEnumerable<TItem?> source) where TItem : class
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return source.Where(item => item != null)!;
        }

        public static IEnumerable<TDest> Choose<TSource, TDest>(this IEnumerable<TSource> source, Func<TSource, TDest?> mapFunc) where TDest : class
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            if (mapFunc == null)
                throw new ArgumentNullException(nameof(mapFunc));
            return source.Select(mapFunc).Choose();
        }

        // TODO (std_string) : think about name
        public static IEnumerable<TItem> CreateFrame<TItem>(this IEnumerable<TItem> source, TItem frameStart, TItem frameEnd)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));
            return source.Prepend(frameStart).Append(frameEnd);
        }

        public static IEnumerable<TItem> CreateSingle<TItem>(TItem item)
        {
            return Enumerable.Repeat(item, 1);
        }

        public static void Iterate<TItem>(this IEnumerable<TItem> source, Action<TItem> action)
        {
            foreach (TItem item in source)
                action(item);
        }
    }

    internal static class ListUtils
    {
        public static Boolean IsEmpty<TItem>(this IList<TItem> source)
        {
            return source.Count == 0;
        }
    }
}
