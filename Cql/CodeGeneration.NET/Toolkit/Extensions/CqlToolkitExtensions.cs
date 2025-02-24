/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static class CqlToolkitExtensions
{
    /// <summary>
    /// Creates an instance of <see cref="ElmToolkit"/> using the provided <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The <see cref="CqlToolkit"/> instance to use for creating the <see cref="ElmToolkit"/>.</param>
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    /// <returns>An instance of <see cref="ElmToolkit"/>.</returns>
    public static ElmToolkit CreateElmToolkit(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null) =>
        new ElmToolkit(cqlToolkit.LoggerFactory, elmToolkitConfig, cqlToolkit.EnumerationExceptionContinuation)
            .AddElmFromCqlToolkit(cqlToolkit);

    /// <summary>
    /// Compiles CQL to assemblies using the provided <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The <see cref="CqlToolkit"/> instance to use for compilation.</param>
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    /// <returns>An instance of <see cref="ElmToolkit"/> with the compiled assemblies.</returns>
    public static ElmToolkit CompileCqlToAssemblies(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null) =>
        cqlToolkit
            .ConvertCqlToElm()
            .CreateElmToolkit(elmToolkitConfig)
            .ConvertElmToAssemblies();
}
