using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql.Extensibility;

public readonly record struct CqlTranslationEntry(CqlLibraryString CqlLibraryString, Library? ElmLibrary = null);