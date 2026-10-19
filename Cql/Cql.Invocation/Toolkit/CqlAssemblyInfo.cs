/*
 * Copyright (c) 2026, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

#nullable enable

using Hl7.Cql.CodeGeneration.NET;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// An assembly and the CQL libraries that the code generator wrote into it, as read from the assembly's metadata
/// by <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/>.
/// </summary>
/// <remarks>
/// Holds the <see cref="Hl7.Cql.CodeGeneration.NET.AssemblyBinary"/> it was read from, so that a host can check
/// the libraries and then pass the same assembly to <see cref="InvocationToolkit.AddAssemblyBinaries"/>. That keeps
/// the assembly in memory for as long as this instance is: to keep only the outcome of the check, keep the
/// <see cref="CqlLibraryInfo"/> values of <see cref="Libraries"/> instead.
/// </remarks>
[DebuggerDisplay("{AssemblyName.Name,nq}: {Libraries.Count} CQL libraries")]
public sealed class CqlAssemblyInfo
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CqlAssemblyInfo"/> class.
    /// </summary>
    /// <exception cref="InvalidOperationException">Two of the libraries have the same identifier.</exception>
    internal CqlAssemblyInfo(
        AssemblyBinary assemblyBinary,
        AssemblyName assemblyName,
        IEnumerable<CqlLibraryInfo> libraryInfos)
    {
        AssemblyBinary = assemblyBinary;
        AssemblyName = assemblyName;

        var libraries = new Dictionary<CqlVersionedLibraryIdentifier, CqlLibraryInfo>();
        foreach (var libraryInfo in libraryInfos)
        {
            if (!libraries.TryAdd(libraryInfo.LibraryIdentifier, libraryInfo))
                throw new InvalidOperationException(
                    $"Assembly '{assemblyName.Name}' holds more than one library type for CQL library '{libraryInfo.LibraryIdentifier}'.");
        }

        Libraries = libraries.ToFrozenDictionary();
        IsSupported = Libraries.Count > 0 && Libraries.Values.All(library => library.IsSupported);
    }

    /// <summary>
    /// Gets the assembly the libraries were read from, with its debug symbols when the caller supplied them,
    /// as passed to <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/>.
    /// </summary>
    public AssemblyBinary AssemblyBinary { get; }

    /// <summary>
    /// Gets the identity of the assembly the libraries were read from, as its metadata states it.
    /// </summary>
    public AssemblyName AssemblyName { get; }

    /// <summary>
    /// Gets the libraries the code generator wrote into the assembly, by their identifier and version.
    /// Empty when the assembly holds no library the code generator wrote.
    /// </summary>
    public IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlLibraryInfo> Libraries { get; }

    /// <summary>
    /// Gets whether <see cref="InvocationToolkit"/> runs every CQL library in the assembly: <see langword="true"/> when
    /// the assembly holds at least one, and <see cref="CqlLibraryInfo.IsSupported"/> is <see langword="true"/> for each.
    /// </summary>
    /// <remarks>
    /// <see langword="false"/> for an assembly that holds no CQL library, because the toolkit has nothing to run from it.
    /// Check whether <see cref="Libraries"/> is empty to tell that apart from an assembly whose libraries the toolkit
    /// does not run. A supported generator version is necessary for the toolkit to run a library, but not sufficient:
    /// loading it can still fail for other reasons, such as a missing dependency.
    /// </remarks>
    public bool IsSupported { get; }
}
