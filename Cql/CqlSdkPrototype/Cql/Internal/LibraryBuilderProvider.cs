using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql.Internal;

/// <summary>
/// Provides the implementation for <seealso cref="ILibraryProvider"/>
/// which resolves a <seealso cref="LibraryBuilder"/> given a library name and version on a <seealso cref="CqlToElmTranslationDictionary.Builder"/>.
/// </summary>
/// <param name="translationsBuilder"></param>
internal sealed class LibraryBuilderProvider(CqlToElmTranslationDictionary.Builder translationsBuilder)
    : ILibraryProvider
{
    public CqlToElmTranslationDictionary.Builder TranslationsBuilder { get; set; } = translationsBuilder;

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

        if (TranslationsBuilder.TryGetValue(libVer, out var processItem)
            && processItem.ElmLibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        return false;
    }
}