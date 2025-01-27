using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql.Internal;

internal class CqlToolkitProcessItemsLibraryProvider(CqlToolkitProcessItems.Builder processItemsBuilder)
    : ILibraryProvider
{
    public CqlToolkitProcessItems.Builder ProcessItemsBuilder { get; set; } = processItemsBuilder;

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

        if (ProcessItemsBuilder.TryGetValue(libVer, out var processItem) && processItem.ElmLibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        return false;
    }
}