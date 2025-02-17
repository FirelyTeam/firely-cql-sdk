using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Represents a state record by the <see cref="CqlToolkit"/>
/// to convert the input <see cref="CqlLibraryString"/> to
/// the output <see cref="ElmLibrary"/>.
/// </summary>
/// <param name="InCqlLibrary">The input CQL library string.</param>
/// <param name="OutElmLibrary">The output ELM library.</param>
public readonly record struct CqlToolkitConversionRecord(
    CqlLibraryString InCqlLibrary,
    ElmLibrary? OutElmLibrary = null) {

    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => InCqlLibrary.LibraryIdentifier;

    /// <summary>
    /// The library builder service for the ELM library.
    /// This is set from <seealso cref="LibraryBuilderProvider.TryResolveLibrary"/>
    /// when the ELM library is resolved in <see cref="CqlToolkit.ConvertCqlToElm"/>.
    /// </summary>
    internal LibraryBuilder? LibraryBuilder { get; init; }
}