using CqlSdkPrototype.Advanced;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApi<out TElmApi> :
    ILogAccessor<TElmApi>
    where TElmApi : IElmApi<TElmApi>
{
    //static abstract TElmApi Create(ElmApiOptions options);
    static abstract TElmApi Create(IServiceProvider serviceProvider);
    ElmApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> Entries { get; }
    TElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions);
    TElmApi AddElmLibraries(IEnumerable<Library> libraries);
    TElmApi Compile(Action<ElmCompileResult>? result = null);
}

public record ElmCompileResult; // Will contain the result of the compilation ELM, and include the deltas of the entities that were added, updated, or removed.