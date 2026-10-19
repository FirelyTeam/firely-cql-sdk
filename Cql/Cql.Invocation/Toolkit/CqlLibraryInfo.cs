/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.Abstractions;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// A CQL library type that the code generator wrote, as read from an assembly's metadata by
/// <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/>.
/// </summary>
/// <param name="LibraryIdentifier">The library's identifier and version, from its <see cref="CqlLibraryAttribute"/>.</param>
/// <param name="GeneratorToolVersion">
/// The version of the code generator that wrote the library, from its <see cref="GeneratedCodeAttribute"/>.
/// </param>
public sealed record CqlLibraryInfo(
    CqlVersionedLibraryIdentifier LibraryIdentifier,
    Version GeneratorToolVersion)
{
    /// <summary>
    /// Gets whether <see cref="InvocationToolkit"/> runs this library, as decided by
    /// <see cref="InvocationToolkit.IsGeneratorToolVersionSupported"/>.
    /// </summary>
    /// <remarks>
    /// A supported version is necessary for the toolkit to run the library, but not sufficient: loading it
    /// can still fail for other reasons, such as a missing dependency.
    /// </remarks>
    public bool IsSupported => InvocationToolkit.IsGeneratorToolVersionSupported(GeneratorToolVersion);
}
