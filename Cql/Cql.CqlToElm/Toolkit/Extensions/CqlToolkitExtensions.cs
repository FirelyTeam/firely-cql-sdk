/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
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
    /// Gets the CQL toolkit results.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <returns>An enumerable collection of <see cref="CqlToolkitResultRecord"/>.</returns>
    public static IEnumerable<CqlToolkitResultRecord> GetCqlToolkitResults(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.Conversions.Values
                  .SelectWhere(conversionRecord => conversionRecord switch
                  {
                      { LibraryIdentifier: { } id, ResultElmLibrary: { } elmLib } => (true, new CqlToolkitResultRecord(id, elmLib)),
                      _ => default
                  });
}
