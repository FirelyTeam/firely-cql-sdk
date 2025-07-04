/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;
using Hl7.Cql.Toolkit;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static partial class CqlToolkitExtensions
{
    private static ILogger CreateLogger(this CqlToolkit cqlToolkit) =>
        cqlToolkit.CreateLogger(typeof(CqlToolkitExtensions));

    /// <summary>
    /// Retrieves the results from the specified <see cref="CqlToolkit"/> instance,  providing a collection of tuples
    /// containing library identifiers and their corresponding ELM libraries.
    /// </summary>
    /// <remarks>This method filters and transforms the artifacts stored in the <paramref name="cqlToolkit"/>
    /// instance,  returning only those with valid library identifiers and ELM libraries.</remarks>
    /// <param name="cqlToolkit">The <see cref="CqlToolkit"/> instance from which to retrieve the results.</param>
    /// <returns>An enumerable collection of tuples, where each tuple contains a <see cref="CqlVersionedLibraryIdentifier"/>
    /// representing the library identifier and an <see cref="ElmLibrary"/> representing the corresponding ELM library.</returns>
    public static IEnumerable<(CqlVersionedLibraryIdentifier libraryIdentifier, ElmLibrary elmLibrary)> GetCqlToolkitResults(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.ArtifactsById.Values
                  .SelectWhere(conversionRecord => conversionRecord switch
                  {
                      { LibraryIdentifier: {} id, ResultElmLibrary: { } elmLib } => (true, (id, elmLib)),
                      _ => default
                  });
}
