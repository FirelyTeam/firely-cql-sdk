/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Invocation.Toolkit.Errors;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// An assembly and the CQL libraries that the code generator wrote into it, as read from the assembly's metadata
/// by <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/>, or why its bytes could not be read.
/// </summary>
/// <remarks>
/// Holds the <see cref="Hl7.Cql.CodeGeneration.NET.AssemblyBinary"/> it was read from, so that a host can check
/// the libraries and then pass the same assembly to <see cref="InvocationToolkit.AddAssemblyBinaries"/>. That keeps
/// the assembly in memory for as long as this instance is: to keep only the outcome of the check, keep the
/// <see cref="CqlLibraryInfo"/> values of <see cref="Libraries"/> instead.
/// </remarks>
[DebuggerDisplay("{AssemblyName?.Name ?? ReadError?.GetMessage(),nq}: {Libraries.Count} CQL libraries")]
public sealed class CqlAssemblyInfo
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CqlAssemblyInfo"/> class for an assembly whose bytes could
    /// not be read.
    /// </summary>
    /// <param name="assemblyBinary">The assembly that could not be read.</param>
    /// <param name="readError">Why its bytes could not be read.</param>
    internal CqlAssemblyInfo(AssemblyBinary assemblyBinary, ICqlAssemblyInfoError readError)
    {
        AssemblyBinary = assemblyBinary;
        ReadError = readError;
        HasReadErrors = true;
        Libraries = FrozenDictionary<CqlVersionedLibraryIdentifier, CqlLibraryInfo>.Empty;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CqlAssemblyInfo"/> class.
    /// </summary>
    /// <param name="assemblyBinary">The assembly the libraries were read from.</param>
    /// <param name="assemblyName">The identity of the assembly.</param>
    /// <param name="cqlLibraryInfos">The libraries, one per identifier.</param>
    internal CqlAssemblyInfo(
        AssemblyBinary assemblyBinary,
        AssemblyName assemblyName,
        IEnumerable<CqlLibraryInfo> cqlLibraryInfos)
    {
        AssemblyBinary = assemblyBinary;
        AssemblyName = assemblyName;

        var libraries = new Dictionary<CqlVersionedLibraryIdentifier, CqlLibraryInfo>();
        foreach (var cqlLibraryInfo in cqlLibraryInfos)
        {
            libraries.Add(cqlLibraryInfo.LibraryIdentifier, cqlLibraryInfo);

            // The first library decides it, each further one can only clear it, and without any it stays false.
            IsSupported = libraries.Count == 1
                ? cqlLibraryInfo.IsSupported
                : IsSupported && cqlLibraryInfo.IsSupported;
            HasReadErrors |= cqlLibraryInfo.ReadError is not null;
        }

        Libraries = libraries.ToFrozenDictionary();
    }

    /// <summary>
    /// Gets the assembly the libraries were read from, with its debug symbols when the caller supplied them,
    /// as passed to <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/>.
    /// </summary>
    public AssemblyBinary AssemblyBinary { get; }

    /// <summary>
    /// Gets the identity of the assembly the libraries were read from, as its metadata states it.
    /// <see langword="null"/> when its bytes could not be read: see <see cref="ReadError"/>.
    /// </summary>
    public AssemblyName? AssemblyName { get; }

    /// <summary>
    /// Gets why the bytes of <see cref="AssemblyBinary"/> could not be read, or <see langword="null"/> when they were.
    /// </summary>
    /// <remarks>
    /// One of the <see cref="ICqlAssemblyInfoError"/> values: <see cref="CqlAssemblyUnreadableError"/>,
    /// <see cref="CqlAssemblyWithoutMetadataError"/>, <see cref="CqlModuleWithoutManifestError"/> or
    /// <see cref="CqlLibraryAttributeValueError"/>. <see cref="Libraries"/> is then empty, and the toolkit cannot load
    /// the assembly. An error in one library is reported on that library instead, through
    /// <see cref="CqlLibraryInfo.ReadError"/>.
    /// </remarks>
    public ICqlAssemblyInfoError? ReadError { get; }

    /// <summary>
    /// Gets the libraries the code generator wrote into the assembly, by their identifier and version.
    /// Empty when the assembly holds no library the code generator wrote, or when its bytes could not be read.
    /// </summary>
    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlLibraryInfo> Libraries { get; }

    /// <summary>
    /// Gets whether <see cref="InvocationToolkit"/> runs every CQL library in the assembly: <see langword="true"/> when
    /// the assembly holds at least one, and <see cref="CqlLibraryInfo.IsSupported"/> is <see langword="true"/> for each.
    /// </summary>
    /// <remarks>
    /// <see langword="false"/> for an assembly that holds no CQL library, because the toolkit has nothing to run from it,
    /// and for one whose bytes could not be read. Check <see cref="ReadError"/> and whether <see cref="Libraries"/> is
    /// empty to tell those apart from an assembly whose libraries the toolkit does not run. A supported generator
    /// version is necessary for the toolkit to run a library, but not sufficient: loading it can still fail for other
    /// reasons, such as a missing dependency.
    /// </remarks>
    [MemberNotNullWhen(true, nameof(AssemblyName))]
    public bool IsSupported { get; }

    /// <summary>
    /// Gets whether the assembly has a <see cref="ReadError"/>, or any of its libraries has a
    /// <see cref="CqlLibraryInfo.ReadError"/>: the assembly declares that library in a way the toolkit does not accept,
    /// so the toolkit skips it while it loads the assembly's other libraries.
    /// </summary>
    public bool HasReadErrors { get; }
}
