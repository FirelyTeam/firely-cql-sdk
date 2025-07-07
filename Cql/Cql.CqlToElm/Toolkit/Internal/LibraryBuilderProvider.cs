/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

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
            return false;

        if (elmTranslation.LibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        Debug.Assert(CqlToElmTranslatorServices is not null);
        if (CqlToElmTranslatorServices is not null)
        {
            var logger = CqlToElmTranslatorServices.LoggerFactory.CreateLogger<LibraryBuilderProvider>();
            logger.LogInformation("Parsing CQL for {id}", libVer);
            libraryBuilder = CqlToElmTranslatorServices.CqlToElmConverter.GetBuilder(CqlToElmTranslatorServices.LibraryVisitor, elmTranslation.SourceCqlLibrary.Cql);
            CqlToolkitArtifactsByIdBuilder[libVer] = elmTranslation with { LibraryBuilder = libraryBuilder };
            return true;
        }


        return false;
    }
}
