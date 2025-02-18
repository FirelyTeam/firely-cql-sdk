using CqlSdkPrototype.Infrastructure;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Represents a result record by the <see cref="CqlToolkit"/>.
/// </summary>
/// <param name="LibraryIdentifier">The library identifier of the input library.</param>
/// <param name="ElmLibrary">The result ELM library.</param>
public readonly record struct CqlToolkitResultRecord(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    ElmLibrary ElmLibrary);