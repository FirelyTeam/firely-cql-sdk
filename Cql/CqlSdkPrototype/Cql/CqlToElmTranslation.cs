using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql;

public readonly record struct CqlToElmTranslation(CqlLibraryString CqlLibraryString, Library? ElmLibrary = null) {
    internal LibraryBuilder? ElmLibraryBuilder { get; init; }
}