/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql.Internal;
using CqlSdkPrototype.Infrastructure;
using Hl7.Cql.CqlToElm;
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Cql;

/// <summary>
/// Represents a state record by the <see cref="CqlToolkit"/>
/// to convert the source <see cref="CqlLibraryString"/> to
/// the result <see cref="ElmLibrary"/>.
/// </summary>
/// <param name="SourceCqlLibrary">The source CQL library string.</param>
/// <param name="ResultElmLibrary">The result ELM library.</param>
public readonly record struct CqlToolkitConversionRecord(
    CqlLibraryString SourceCqlLibrary,
    ElmLibrary? ResultElmLibrary = null) {

    /// <summary>
    /// The library identifier of the input CQL library.
    /// </summary>
    public CqlVersionedLibraryIdentifier LibraryIdentifier => SourceCqlLibrary.LibraryIdentifier;

    /// <summary>
    /// The library builder service for the ELM library.
    /// This is set from <seealso cref="LibraryBuilderProvider.TryResolveLibrary"/>
    /// when the ELM library is resolved in <see cref="CqlToolkit.ConvertCqlToElm"/>.
    /// </summary>
    internal LibraryBuilder? LibraryBuilder { get; init; }
}
