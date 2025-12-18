using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Internal;

/// <summary>
/// Represents a delegate that resolves a <see cref="FileInfo"/> instance
/// for a given <see cref="CqlVersionedLibraryIdentifier"/>.
/// </summary>
/// <param name="libraryIdentifier">
/// The versioned identifier of the FHIR resource library for which the file information is being resolved.
/// </param>
/// <returns>
/// A <see cref="FileInfo"/> instance representing the resolved FHIR resource file resolved from the library identifier.
/// </returns>
/// <remarks>
/// It should not be assumed that the file exists.
/// </remarks>
public delegate FileInfo ResourceFileInfoResolver(CqlVersionedLibraryIdentifier libraryIdentifier);