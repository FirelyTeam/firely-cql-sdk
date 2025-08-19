/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Packaging;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

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

/// <summary>
/// Provides extension methods for resolving file information related to FHIR resource libraries.
/// </summary>
/// <remarks>
/// This class includes methods to create resolvers that map FHIR resource library identifiers
/// to corresponding file information, such as resolving files from a specified directory.
/// </remarks>
public static class ResourceFileInfoResolvers
{
    /// <summary>
    /// Creates a <see cref="ResourceFileInfoResolver"/> that resolves file information
    /// for FHIR resource library located in a specified directory.
    /// </summary>
    /// <param name="directory">
    /// The directory from which the FHIR resource library files are resolved.
    /// </param>
    /// <param name="resourceType">
    /// The type of the resource, defaulting to "Library".
    /// </param>
    /// <returns>
    /// A <see cref="ResourceFileInfoResolver"/> that resolves a <see cref="FileInfo"/>
    /// instance for a given <see cref="CqlVersionedLibraryIdentifier"/> by locating the corresponding
    /// file in the specified directory.
    /// </returns>
    /// <remarks>
    /// The resolver assumes that the file name corresponds to the library identifier and version
    /// using the <see cref="ResourceFileName"/> to construct the file name.
    /// It does not guarantee that the resolved file exists.
    /// </remarks>
    public static ResourceFileInfoResolver FromDirectory(
        DirectoryInfo directory,
        string resourceType = "Library") =>
        libraryIdentifier =>
        {
            ResourceFileName resourceFileName = ResourceFileName.Create(resourceType, libraryIdentifier.Identifier, libraryIdentifier.Version);
            FileInfo fileInfo = new (Path.Combine(directory.FullName, resourceFileName));
            return fileInfo;
        };
}