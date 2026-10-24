/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Immutable;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Internal;

/// <summary>
/// Provides functionality for resolving and building libraries based on CQL (Clinical Quality Language) identifiers.
/// </summary>
/// <remarks>This class implements <see cref="ILibraryProvider"/> to facilitate the resolution of libraries by
/// their name and version. It supports both pre-existing library builders and dynamic creation of library builders
/// using CQL translation services.</remarks>
/// <param name="cqlToolkitArtifactsByIdBuilder"></param>
internal sealed class LibraryBuilderProvider(
    CqlToolkitArtifactsById.Builder cqlToolkitArtifactsByIdBuilder)
    : ILibraryProvider
{
    public CqlToolkitServices? CqlToElmTranslatorServices { get; set; }

    public CqlToolkitArtifactsById.Builder CqlToolkitArtifactsByIdBuilder { get; set; } = cqlToolkitArtifactsByIdBuilder;

    /// <summary>
    /// The ELM libraries that resolve an include when the toolkit holds no CQL for it.
    /// </summary>
    public ImmutableDictionary<CqlVersionedLibraryIdentifier, ElmLibrary> ReferenceLibrariesById { get; set; } =
        ImmutableDictionary<CqlVersionedLibraryIdentifier, ElmLibrary>.Empty;

    private readonly Dictionary<CqlVersionedLibraryIdentifier, LibraryBuilder> _referenceBuildersById = [];

    /// <summary>
    /// The libraries whose CQL is being parsed, outermost first. Parsing a library resolves its includes, so a library on
    /// this chain that is resolved again is included by itself or by a library it includes, which CQL does not allow.
    /// </summary>
    private readonly List<CqlVersionedLibraryIdentifier> _librariesBeingParsed = [];

    bool ILibraryProvider.TryResolveLibrary(
        string libraryName,
        string? version,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error) => TryResolveLibrary(CqlVersionedLibraryIdentifier.ParseFromIdentifierAndVersion(libraryName, version), out libraryBuilder, out error);

    public bool TryResolveLibrary(
        CqlVersionedLibraryIdentifier libVer,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error)
    {
        error = null;
        libraryBuilder = null;

        if (!CqlToolkitArtifactsByIdBuilder.TryGetValue(libVer, out var elmTranslation))
            return TryResolveReferenceLibrary(libVer, out libraryBuilder, out error);

        if (elmTranslation.LibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        Debug.Assert(CqlToElmTranslatorServices is not null);
        if (CqlToElmTranslatorServices is null)
            return false;

        // The builder of a library is stored once its CQL is parsed, and parsing it resolves its includes. A library
        // resolved while its own CQL is being parsed is on a cycle of includes, which CQL does not allow, and parsing it
        // again would resolve the same includes again, without end.
        var cycleStart = _librariesBeingParsed.IndexOf(libVer);
        if (cycleStart >= 0)
        {
            error = DescribeIncludeCycle(_librariesBeingParsed.Skip(cycleStart).ToList());
            return false;
        }

        var logger = CqlToElmTranslatorServices.LoggerFactory.CreateLogger<LibraryBuilderProvider>();
        logger.LogInformation("Parsing CQL for {id}", libVer);
        _librariesBeingParsed.Add(libVer);
        try
        {
            libraryBuilder = CqlToElmTranslatorServices.CqlToElmConverter.GetBuilder(CqlToElmTranslatorServices.LibraryVisitor, elmTranslation.SourceCqlLibrary.Cql);
        }
        finally
        {
            _librariesBeingParsed.RemoveAt(_librariesBeingParsed.Count - 1);
        }

        CqlToolkitArtifactsByIdBuilder[libVer] = elmTranslation with { LibraryBuilder = libraryBuilder };
        return true;
    }

    // The error for a cycle of includes, which names each library along it, the first repeated at the end. Which library
    // is resolved first, and so where the cycle is met, depends on the order the libraries are translated in, so the cycle
    // is reported from the library that sorts first, and the error reads the same whatever the order.
    private string DescribeIncludeCycle(IReadOnlyList<CqlVersionedLibraryIdentifier> cycle)
    {
        var start = cycle.Select((library, index) => (Name: library.ToString(), Index: index)).MinBy(entry => entry.Name, StringComparer.Ordinal).Index;
        var fromStart = cycle.Skip(start).Concat(cycle.Take(start)).ToList();
        var messaging = CqlToElmTranslatorServices!.ServiceProvider.GetRequiredService<MessageProvider>();
        return messaging.UnableToResolveLibraryOnIncludeCycle(
            fromStart[0].Identifier.ToString(),
            fromStart[0].Version?.ToString(),
            fromStart.Append(fromStart[0]).Select(DescribeLibrary));
    }

    // A library as the messages name one: "A version '1.0.0'", or "A" when it declares no version.
    private static string DescribeLibrary(CqlVersionedLibraryIdentifier libVer) =>
        libVer.Version is { } version ? $"{libVer.Identifier} version '{version}'" : libVer.Identifier.ToString();

    private bool TryResolveReferenceLibrary(
        CqlVersionedLibraryIdentifier libVer,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error)
    {
        error = null;
        if (_referenceBuildersById.TryGetValue(libVer, out libraryBuilder))
            return true;

        if (!ReferenceLibrariesById.TryGetValue(libVer, out var elmLibrary) || CqlToElmTranslatorServices is null)
            return false;

        var logger = CqlToElmTranslatorServices.LoggerFactory.CreateLogger<LibraryBuilderProvider>();
        logger.LogInformation("Resolving {id} from its ELM", libVer);
        var builder = CqlToElmTranslatorServices.LibraryVisitor.CreateReferenceBuilder(elmLibrary, out var conflictingNames);
        if (conflictingNames.Count > 0)
        {
            var messaging = CqlToElmTranslatorServices.ServiceProvider.GetRequiredService<MessageProvider>();
            error = messaging.UnableToResolveReferenceLibrary(libVer.Identifier.ToString(), libVer.Version?.ToString(), conflictingNames);
            return false;
        }

        libraryBuilder = builder;
        _referenceBuildersById[libVer] = libraryBuilder;
        return true;
    }
}
