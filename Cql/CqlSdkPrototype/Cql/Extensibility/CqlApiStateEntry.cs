using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql.Extensibility;

public readonly record struct CqlApiStateEntry(CqlLibraryString CqlLibraryString, Library? ElmLibrary = null);