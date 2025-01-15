using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApiExtendable<TElmApi>
    where TElmApi : IElmApiExtendable<TElmApi>
{
    ILoggerFactory LoggerFactory { get; }
    ElmApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmApiStateEntry> Entries { get; }
    TElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions);
    TElmApi AddElmLibraries(IEnumerable<Library> libraries);
    TElmApi Compile();
    TResult UseLogger<TResult>(Func<TElmApi, ILogger<TElmApi>, TResult> action); // Useful for extensions methods
}