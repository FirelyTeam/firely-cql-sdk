using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql;

public readonly record struct CqlToElmConversion(CqlLibraryString CqlLibraryString, Library? ElmLibrary = null) {
    internal LibraryBuilder? ElmLibraryBuilder { get; init; }
}