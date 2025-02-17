using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql.Internal;

/// <summary>
/// Provides the implementation for <seealso cref="ILibraryProvider"/>
/// which resolves a <seealso cref="LibraryBuilder"/> given a library name and version on a <seealso cref="CqlToolkitConversionDictionary.Builder"/>.
/// </summary>
/// <param name="conversionsBuilder"></param>
internal sealed class LibraryBuilderProvider(
    CqlToolkitConversionDictionary.Builder conversionsBuilder)
    : ILibraryProvider
{
    public CqlToolkitServices? CqlToElmTranslatorServices { get; set; }

    public CqlToolkitConversionDictionary.Builder ConversionsBuilder { get; set; } = conversionsBuilder;

    bool ILibraryProvider.TryResolveLibrary(
        string libraryName,
        string? version,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error) => TryResolveLibrary(CqlVersionedLibraryIdentifier.ParseFromNameAndVersion(libraryName, version), out libraryBuilder, out error);

    public bool TryResolveLibrary(
        CqlVersionedLibraryIdentifier libVer,
        [NotNullWhen(true)] out LibraryBuilder? libraryBuilder,
        out string? error)
    {
        error = null;
        libraryBuilder = null;

        if (!ConversionsBuilder.TryGetValue(libVer, out var elmTranslation))
            return false;

        if (elmTranslation.ElmLibraryBuilder is { } lb)
        {
            libraryBuilder = lb;
            return true;
        }

        Debug.Assert(CqlToElmTranslatorServices is not null);
        if (CqlToElmTranslatorServices is not null)
        {
            var logger = CqlToElmTranslatorServices.LoggerFactory.CreateLogger<LibraryBuilderProvider>();
            logger.LogInformation("Parsing CQL for {id}", libVer);
            libraryBuilder = CqlToElmTranslatorServices.CqlToElmConverter.GetBuilder(CqlToElmTranslatorServices.LibraryVisitor, elmTranslation.InCqlLibraryString.Cql);
            ConversionsBuilder[libVer] = elmTranslation with { ElmLibraryBuilder = libraryBuilder };
            return true;
        }


        return false;
    }
}