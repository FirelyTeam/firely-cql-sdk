using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql.Extensibility;

public readonly record struct CqlToolkitProcessItem(CqlLibraryString CqlLibraryString, Library? ElmLibrary = null) {
    internal LibraryBuilder? ElmLibraryBuilder { get; init; }
}