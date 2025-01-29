using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Elm;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Represents a translation from a CQL library to an ELM library.
/// </summary>
/// <param name="CqlLibraryString">The input CQL library string.</param>
/// <param name="ElmLibrary">The output ELM library.</param>
public readonly record struct CqlToElmTranslation(
    CqlLibraryString CqlLibraryString,
    Library? ElmLibrary = null) {

    /// <summary>
    /// The builder for the ELM library. This is set during <seealso cref="CqlToElmTranslator.AddCqlLibraries"/>.
    /// </summary>
    internal LibraryBuilder? ElmLibraryBuilder { get; init; }
}