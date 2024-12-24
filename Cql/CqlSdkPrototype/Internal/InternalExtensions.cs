using System.Reflection;
using System.Runtime.Loader;

namespace CqlSdkPrototype.Internal;

internal static class InternalExtensions
{
    public static string[] SplitLines(this string multilineString) =>
        multilineString.Split([Environment.NewLine], StringSplitOptions.None);

    public static string Join(this IEnumerable<string> lines) =>
        string.Concat(lines);

    public static string JoinLines(this IEnumerable<string> lines) =>
        string.Join(Environment.NewLine, lines);

    public static string TakeLines(this string multilineString, int count) =>
        multilineString.SplitLines().Take(count).JoinLines();

    public static string TrimFileExtension(this string filePath, string extension) =>
        filePath.EndsWith(extension, StringComparison.OrdinalIgnoreCase)
            ? filePath[..^extension.Length]
            : filePath;

    public static Assembly LoadFromBytes(this AssemblyLoadContext assemblyLoadContext, byte[] bytes)
    {
        using var memoryStream = new MemoryStream(bytes);
        return assemblyLoadContext.LoadFromStream(memoryStream);
    }
}