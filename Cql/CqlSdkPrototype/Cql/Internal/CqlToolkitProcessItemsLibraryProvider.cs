using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql.Internal;

/// <summary>
/// Provides the implementation for <seealso cref="ILibraryProvider"/> which resolves library builders given a library name and version on a <seealso cref="CqlToElmConversionDictionary.Builder"/>.
/// </summary>00
/// <param name="processItemsBuilder"></param>
internal class CqlToolkitProcessItemsLibraryProvider(CqlToElmConversionDictionary.Builder processItemsBuilder)
    : ILibraryProvider
{
    public CqlToElmConversionDictionary.Builder ProcessItemsBuilder { get; set; } = processItemsBuilder;

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