using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Represents information about the parameters of a CQL function, which includes its name and type.
/// </summary>
/// <param name="Name">The name of the parameter.</param>
/// <param name="Type">The type of the parameter.</param>
public readonly record struct CqlParameterInfo(string Name, Type Type)
{
    public override string ToString() => $"{Type.ToCSharpString()} '{Name}'";
}
