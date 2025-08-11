namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Represents information about a CQL operand, including its name and type.
/// </summary>
/// <param name="Name">The name of the operand.</param>
/// <param name="Type">The type of the operand.</param>
public readonly record struct CqlOperandInfo(string Name, Type Type);
