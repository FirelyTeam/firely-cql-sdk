using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Represents information about the parameters of a CQL function, which includes its name and type.
/// </summary>
/// <param name="Name">The name of the parameter.</param>
/// <param name="Type">The type of the parameter.</param>
public readonly record struct CqlParameterInfo(string Name, Type Type)
{
    /// <summary>
    /// Returns a string representation of the CQL parameter information,
    /// including its type and name.
    /// </summary>
    /// <returns>
    /// A string in the format "<c>{Type}</c> '<c>{Name}</c>'", where <c>{Type}</c>
    /// is the C# representation of the parameter's type and <c>{Name}</c> is the parameter's name.
    /// </returns>
    public override string ToString() => $"{Type.ToCSharpString()} '{Name}'";
}
