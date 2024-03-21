namespace Hl7.Cql.CodeGeneration.NET;

internal static class StringExtensions
{
    public static bool SurroundsWith(this string s, char startsWith, char endsWith) =>
        s.StartsWith(startsWith) && s.EndsWith(endsWith);
}