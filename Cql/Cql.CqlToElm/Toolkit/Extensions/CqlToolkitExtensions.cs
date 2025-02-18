/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.CqlToElm.Toolkit.Extensions;

public static partial class CqlToolkitExtensions
{
    private static ILogger CreateLogger(this CqlToolkit cqlToolkit) =>
        cqlToolkit.LoggerFactory.CreateLogger(typeof(CqlToolkitExtensions));

    public static CqlToolkit SetExceptionHandlingToIgnore(this CqlToolkit cqlToolkit, bool stopAfterFirstException = false) =>
        cqlToolkit.Reconfigure(o => o with
        {
            ErroredEnumerationContinuation = stopAfterFirstException ? ErroredEnumerationContinuation.Break : ErroredEnumerationContinuation.Continue
        });

    public static IEnumerable<CqlToolkitResultRecord> GetCqlToolkitResults(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.Conversions.Values
                  .SelectWhere(conversionRecord => conversionRecord switch
                  {
                      { LibraryIdentifier: { } id, ResultElmLibrary: { } elmLib } => (true, new CqlToolkitResultRecord(id, elmLib)),
                      _                                                           => default
                  });
}
