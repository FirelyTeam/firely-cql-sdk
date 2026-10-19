/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Invocation.Toolkit.Internal;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;
using static Hl7.Cql.Invocation.Toolkit.StringBuilderExtensions;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Abstract base class for invoking CQL libraries.
/// </summary>
public abstract class LibraryInvoker
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LibraryInvoker"/> class.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker that created this instance.</param>
    protected LibraryInvoker(LibrarySetInvoker librarySetInvoker)
    {
        LibrarySetInvoker = librarySetInvoker;
    }

    /// <summary>
    /// Gets the library set invoker that created the <see cref="LibraryInvoker"/>.
    /// </summary>
    public LibrarySetInvoker LibrarySetInvoker { get; }

    /// <summary>
    /// Gets the CQL library this invoker was created from, as its type's attributes declare it, with the version of the
    /// code generator that wrote it.
    /// </summary>
    /// <remarks>
    /// <see langword="null"/> for an invoker that <see cref="TryCreateFromType"/> did not create. For one it did, this
    /// equals the entry <see cref="InvocationToolkit.ReadCqlAssemblyInfo"/> reads for the same type from the
    /// assembly's metadata.
    /// </remarks>
    internal CqlLibraryInfo? LibraryInfo { get; private set; }

    /// <summary>
    /// A convenience property to get the library set name.
    /// </summary>
    public string LibrarySetName => LibrarySetInvoker.LibrarySetName;

    /// <summary>
    /// Gets the versioned identifier of the CQL library.
    /// </summary>
    public abstract CqlVersionedLibraryIdentifier LibraryIdentifier { get; }

    /// <summary>
    /// Gets the versioned identifiers of the CQL library's library dependencies.
    /// </summary>
    public abstract IReadOnlyCollection<CqlVersionedLibraryIdentifier> DependencyLibraryIdentifiers { get; }

    /// <summary>
    /// Selects the dependency libraries for the current library.
    /// </summary>
    /// <param name="includeSelf">
    /// A boolean value indicating whether the current library should be included in the result.
    /// If <c>true</c>, the current library is included; otherwise, it is excluded.
    /// </param>
    /// <param name="recursive">
    /// A boolean value indicating whether the selection should include dependencies recursively.
    /// If <c>true</c>, all transitive dependencies are included; otherwise, only direct dependencies are included.
    /// </param>
    /// <returns>
    /// An <see cref="IEnumerable{T}"/> of <see cref="LibraryInvoker"/> representing the selected dependency libraries.
    /// </returns>
    public IEnumerable<LibraryInvoker> SelectDependencyLibraries(
        bool includeSelf = false,
        bool recursive = false)
    {
        var visited = new HashSet<LibraryInvoker>();
        var stack = new Stack<LibraryInvoker>();

        if (includeSelf)
            stack.Push(this);
        else
            foreach (var dependency in SelectDirectDependencyLibraries())
                stack.Push(dependency);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            if (visited.Add(current))
            {
                yield return current;

                if (recursive)
                {
                    foreach (var dependency in current.SelectDirectDependencyLibraries())
                    {
                        if (!visited.Contains(dependency))
                            stack.Push(dependency);
                    }
                }
            }
        }
    }

    private IEnumerable<LibraryInvoker> SelectDirectDependencyLibraries()
    {
        var libraryInvokers = LibrarySetInvoker.LibraryInvokers;
        var logger = LibrarySetInvoker.CreateLogger<LibraryInvoker>();
        return DependencyLibraryIdentifiers
            .TrySelect(
                depId => libraryInvokers[depId],
                s => s
                     .SetContinuation(LibrarySetInvoker.BatchProcessExceptionContinuation)
                     .AddLoggerExceptionHandler(logger, (depId, logMessage) => logMessage("No library invoker was found for {lib}", depId)));
    }

    /// <summary>
    /// Gets the dictionary of definition invokers for the CQL library.
    /// </summary>
    public abstract IReadOnlyDictionary<DefinitionSignature, DefinitionInvoker> Definitions { get; }

    /// <summary>
    /// Tries to create a <see cref="LibraryInvoker"/> instance from the specified type.
    /// </summary>
    /// <param name="librarySetInvoker">The library set invoker that created the <see cref="LibraryInvoker"/>.</param>
    /// <param name="libraryType">The type of the library.</param>
    /// <param name="cqlLibraryInfos">
    /// The CQL libraries the type declares, as <see cref="CqlLibraryTypeRule.GetLibraryInfos"/> reads them.
    /// </param>
    /// <param name="libraryInvoker">When this method returns, contains the created <see cref="LibraryInvoker"/> instance, if the creation succeeded; otherwise, <see langword="null"/>.</param>
    /// <returns><see langword="true"/> if the creation succeeded; otherwise, <see langword="false"/>.</returns>
    internal static bool TryCreateFromType(
        LibrarySetInvoker librarySetInvoker,
        Type libraryType,
        IReadOnlyList<CqlLibraryInfo> cqlLibraryInfos,
        [NotNullWhen(true)] out LibraryInvoker? libraryInvoker)
    {
        libraryInvoker = null;
        var logger = librarySetInvoker.CreateLogger<LibraryInvoker>();

        if (cqlLibraryInfos.Count == 0)
        {
            logger?.LogDebug(
                "Skipping type {type} because it is not a CQL library the code generator wrote.",
                libraryType.FullName);
            return false;
        }

        // A type that declares more than one library carries an error, on every entry, so the first stands for all.
        var cqlLibraryInfo = cqlLibraryInfos[0];
        if (cqlLibraryInfo.ReadError is { } readError)
        {
            logger?.LogError("Skipping type {type}: {error}", libraryType.FullName, readError.GetMessage());
            return false;
        }

        if (!cqlLibraryInfo.IsSupported)
        {
            logger?.LogWarning(
                "Skipping CQL library {lib} in type {type} because code generator version {ver} wrote it, "
                + "while this toolkit runs versions {min} up to, but not including, {firstUnsupported}.",
                cqlLibraryInfo.LibraryIdentifier,
                libraryType.FullName,
                cqlLibraryInfo.GeneratorToolVersion,
                LibrarySetInvoker.MinSupportedGeneratorToolVersion,
                LibrarySetInvoker.FirstUnsupportedGeneratorToolVersion);
            return false;
        }

        if (!LibraryInstanceInvoker_6_0.TryCreate(librarySetInvoker, libraryType, out libraryInvoker))
            return false;

        libraryInvoker.LibraryInfo = cqlLibraryInfo;
        logger?.LogDebug(
            "Loaded CQL library {lib} from type {type}, which code generator version {ver} wrote.",
            cqlLibraryInfo.LibraryIdentifier,
            libraryType.FullName,
            cqlLibraryInfo.GeneratorToolVersion);
        return true;
    }


    /// <inheritdoc />
    public override string ToString() =>
        StartBrace()
            .AppendMemberIf(LibrarySetName, LibrarySetName is {Length:>0})
            .AppendMember(LibraryIdentifier)
            .EndBrace();
}