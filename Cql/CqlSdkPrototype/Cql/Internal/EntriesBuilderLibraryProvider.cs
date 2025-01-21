using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql.Internal;

internal class EntriesBuilderLibraryProvider(CqlApiStateEntryDictionary.Builder entriesBuilder)
    : ILibraryProvider
{
    public CqlApiStateEntryDictionary.Builder EntriesBuilder { get; set; } = entriesBuilder;

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

        if (EntriesBuilder.TryGetValue(libVer, out var entry) && entry.ElmLibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        return false;
    }
}