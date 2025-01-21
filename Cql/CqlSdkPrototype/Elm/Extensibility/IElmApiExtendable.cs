using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Elm.Extensibility;

public interface IElmApiExtendable
{
    ILoggerFactory LoggerFactory { get; }
    ElmApiOptions Options { get; }
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, ElmApiStateEntry> Entries { get; }
    ElmApi WithOptions(Func<ElmApiOptions, ElmApiOptions> replaceOptions);
    ElmApi AddElmLibraries(IEnumerable<Library> libraries);
    ElmApi Compile();
}