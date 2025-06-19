namespace Hl7.Cql.Runtime.Parsing;

/// <summary>
/// Represents a handler for CQL parse errors.
/// </summary>
/// <param name="parseError">The CQL parse error that occurred.</param>
public delegate void CqlParseErrorHandler(CqlParseError parseError);