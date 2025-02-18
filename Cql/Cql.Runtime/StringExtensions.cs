namespace Hl7.Cql.Runtime;

internal static class StringExtensions
{
    public static string? NullIfEmpty(this string? text) => string.IsNullOrEmpty(text) ? null : text;
}