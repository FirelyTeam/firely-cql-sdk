/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Abstract class for invoking a CQL library on an instance.
/// </summary>
/// <param name="librarySetInvoker">The library set invoker that created this instance.</param>
/// <param name="library">The CQL library instance.</param>
public abstract class LibraryInstanceInvoker(
    LibrarySetInvoker librarySetInvoker,
    ILibrary library) : LibraryInvoker(librarySetInvoker)
{
    /// <summary>
    /// Gets the CQL library instance.
    /// </summary>
    public ILibrary Library { get; } = library;

    /// <summary>
    /// Gets the versioned identifier of the CQL library.
    /// </summary>
    public override CqlVersionedLibraryIdentifier LibraryIdentifier { get; } =
        CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(library.Name, library.Version);

    /// <inheritdoc />
    public override IReadOnlyCollection<CqlVersionedLibraryIdentifier> DependencyLibraryIdentifiers { get; } =
        library.Dependencies
               .Select(dep => CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(dep.Name, dep.Version))
               .ToList();

    /// <summary>
    /// Gets the dictionary of named definition invokers for the CQL library.
    /// </summary>
    public abstract override IReadOnlyDictionary<DefinitionNamedSignature, DefinitionInvoker> NamedDefinitions { get; }
}