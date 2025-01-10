using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApiExtensible<TElmApi>
    where TElmApi : IElmApiExtensible<TElmApi>
{
    static abstract TElmApi Create(ElmApiOptions options);
    ElmApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> Entries { get; }
    TElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions);
    TElmApi AddElmLibraries(IEnumerable<Library> libraries);
    TElmApi Compile();
    TElmApi UseServices(Func<(TElmApi elmApi, ILogger<TElmApi> logger), TElmApi> action); // Useful for extensions methods
}