using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit;

/// <summary>
/// Represents the result of generating C# source code for a specified CQL library.
/// </summary>
/// <remarks>This record encapsulates the identifier of the CQL library and the corresponding generated C# source
/// code. It is immutable and designed for use in scenarios where CQL libraries are processed into C# code.</remarks>
/// <param name="LibraryIdentifier">The identifier of the CQL library, including version information.</param>
/// <param name="CSharpSourceCode">The generated C# source code corresponding to the specified CQL library.</param>
public readonly record struct ElmToolkitCSharpResultRecord(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    string CSharpSourceCode);