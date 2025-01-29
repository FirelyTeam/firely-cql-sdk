using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql.Internal;

/// <summary>
/// Provides the implementation for <seealso cref="ILibraryProvider"/> which resolves library builders given a library name and version on a <seealso cref="System.Collections.Immutable.ImmutableDictionary{CqlSdkPrototype.Infrastructure.CqlVersionedLibraryIdentifier,CqlSdkPrototype.Cql.CqlToElmTranslation}.Builder"/>.
/// </summary>00
/// <param name="builder"></param>
internal sealed class LibraryProvider(CqlToElmTranslationDictionary.Builder builder)
    : ILibraryProvider
{
    public CqlToElmTranslationDictionary.Builder Builder { get; set; } = builder;

    public bool TryResolveLibrary(
        string libraryName,
        string? version,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error)
    {
        error = null;
        libraryBuilder = null;

        var libVer = CqlVersionedLibraryIdentifier.FromNameAndVersion(
            CqlLibraryIdentifier.Parse(libraryName),
            version is null ? null : CqlLibraryVersion.Parse(version));

        if (Builder.TryGetValue(libVer, out var processItem) && processItem.ElmLibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        return false;
    }
}