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

    public static IEnumerable<(CqlVersionedLibraryIdentifier libraryIdentifier, ElmLibrary elmLibrary)> GetCqlToolkitResults(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit.ArtifactsByIds.Values
                  .SelectWhere(conversionRecord => conversionRecord switch
                  {
                      { LibraryIdentifier: {} id, ResultElmLibrary: { } elmLib } => (true, (id, elmLib)),
                      _ => default
                  });
}
