using System.Diagnostics;

namespace Hl7.Cql.Compiler.Infrastructure;

/// <summary>
/// Wraps a positive integer and ToString it as 0th, 1st, 2nd, 3rd, 4th, etc...
/// </summary>
internal readonly struct Ordinal
{
    public const int Unspecified = -1;

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