/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
    /// Gets why this library cannot be used, when the assembly declares it in a way the toolkit does not accept;
    /// otherwise, <see langword="null"/>.
    /// </summary>
    /// <remarks>
    /// The toolkit does not accept a library type that carries more than one <see cref="CqlLibraryAttribute"/> or
    /// <see cref="GeneratedCodeAttribute"/>, nor a library that more than one type declares. It skips such a library,
    /// and logs this error, rather than failing to load the rest of the library set.
    /// </remarks>
    public Exception? Error { get; init; }

    /// <summary>
    /// Gets whether <see cref="InvocationToolkit"/> runs this library: it has no <see cref="Error"/>, and
    /// <see cref="InvocationToolkit.IsGeneratorToolVersionSupported"/> accepts its <see cref="GeneratorToolVersion"/>.
    /// </summary>
    /// <remarks>
    /// A supported version is necessary for the toolkit to run the library, but not sufficient: loading it
    /// can still fail for other reasons, such as a missing dependency.
    /// </remarks>
    public bool IsSupported => Error is null && InvocationToolkit.IsGeneratorToolVersionSupported(GeneratorToolVersion);
}
