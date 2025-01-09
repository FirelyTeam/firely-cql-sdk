using CqlSdkPrototype.Advanced;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql.Extensibility;

public interface ICqlApi
{
}

public interface ICqlApiExtensible<out TSelf> :
    ICqlApi,
    ILogAccessor<TSelf>
    where TSelf : ICqlApiExtensible<TSelf>
{
    CqlApiOptions Options { get; }
    TSelf AddCqlLibraries(IEnumerable<CqlLibraryString> libraries);
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, Library> GetElmLibraries();
    IReadOnlyDictionary<CqlVersionedLibraryIdentifier, CqlTranslationEntry> Entries { get; }
}