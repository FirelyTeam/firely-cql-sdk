/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions.Infrastructure;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static partial class CqlToolkitExtensions
{
    /// <summary>
    /// Creates a logger for the specified <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <returns>An <see cref="ILogger"/> instance.</returns>
    private static ILogger CreateLogger(this CqlToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExtensions));

    /// <summary>
    /// Configures the <see cref="CqlToolkit"/> to ignore exceptions.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit instance.</param>
    /// <param name="stopAfterFirstException">If set to <c>true</c>, stops after the first exception; otherwise, continues.</param>
    /// <returns>The configured <see cref="CqlToolkit"/> instance.</returns>
    public static CqlToolkit SetExceptionHandlingToIgnore(this CqlToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            EnumerationExceptionContinuation = stopAfterFirstException ? EnumerationExceptionContinuation.Break : EnumerationExceptionContinuation.Continue
        });

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
