using CqlSdkPrototype.Cql;
using Hl7.Cql.Elm;
using Microsoft.Extensions.Logging;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApiExtensible<TElmApi>
    where TElmApi : IElmApiExtensible<TElmApi>
{
    static abstract TElmApi Create(ElmApiOptions options);
    ElmApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmCompilationEntry> Entries { get; }
    TElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions);
    TElmApi AddElmLibraries(IEnumerable<Library> libraries);
    TElmApi Compile(Action<ElmCompileResult>? result = null);
    TElmApi UseServices(Func<(TElmApi elmApi, ILogger<TElmApi> logger), TElmApi> action); // Useful for extensions methods
}

public record ElmCompileResult; // Will contain the result of the compilation ELM, and include the deltas of the entities that were added, updated, or removed.