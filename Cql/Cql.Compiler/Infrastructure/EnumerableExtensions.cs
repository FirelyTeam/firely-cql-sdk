using System.Collections.Generic;
using System.Diagnostics;

namespace Hl7.Cql.Compiler.Infrastructure;

internal static class EnumerableExtensions
{
    /// <summary>
    /// Pair items in an enumeration with their ordinals starting at 1.
    /// </summary>
    public static IEnumerable<(T Item, Ordinal Ordinal)> WithOrdinals<T>(this IEnumerable<T> source)
    {
        int i = 0;
        foreach (var item in source)
        {
            ++i;
            yield return (item, new Ordinal(i));
        }
    }
}

internal readonly struct Ordinal
{
    private readonly int _value;

    public Ordinal(int value)
    {
        Debug.Assert(value >= 0);
        _value = value;
    }

    public int Value => _value;

    public override string ToString() => 
        $"{_value}{OrdinalIndicator(_value)}";

    private static string OrdinalIndicator(int ordinal) => ordinal switch
    {
        1 => "st", // 1st
        2 => "nd", // 2nd
        3 => "rd", // 3rd
        _ => "th"  // 0th, 4th, 5th, etc.
    };
}