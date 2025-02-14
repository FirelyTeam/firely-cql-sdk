using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Represents a conversion record used by the <see cref="CqlToolkit"/>
/// to convert the input <see cref="CqlLibraryString"/> to
/// output <see cref="ElmLibrary"/>.
/// </summary>
/// <param name="InCqlLibraryString">The input CQL library string.</param>
/// <param name="OutElmLibrary">The output ELM library.</param>
public readonly record struct CqlToolkitConversionRecord(
    CqlLibraryString InCqlLibraryString,
    ElmLibrary? OutElmLibrary = null) {

    /// <summary>
    /// The builder for the ELM library. This is set during <seealso cref="CqlToolkit.AddCqlLibraries"/>.
    /// </summary>
    internal LibraryBuilder? ElmLibraryBuilder { get; init; }
}