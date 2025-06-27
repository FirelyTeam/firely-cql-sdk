/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CqlToElm.Toolkit;
using Hl7.Cql.Runtime;

namespace Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static class CqlToolkitElmExtensions
{
    /// <summary>
    /// Creates an instance of <see cref="ElmToolkit"/> using the provided <see cref="CqlToolkit"/>.
    /// </summary>
    ///
    /// <param name="cqlToolkit">
    /// The <see cref="CqlToolkit"/> instance to use for creating the <see cref="ElmToolkit"/>,
    /// using the same <see cref="CqlToolkit.BatchProcessExceptionContinuation"/>..
    /// </param>
    ///
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    ///
    /// <param name="libraryPredicate">The optional handler which libraries to add.</param>
    ///
    /// <returns>An instance of <see cref="ElmToolkit"/>.</returns>
    public static ElmToolkit CreateElmToolkit(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null,
        Func<CqlVersionedLibraryIdentifier, bool>? libraryPredicate = null) =>
        new ElmToolkit(cqlToolkit.LoggerFactory, elmToolkitConfig, cqlToolkit.BatchProcessExceptionContinuation)
            .AddElmFromCqlToolkit(cqlToolkit, libraryPredicate);

    [Experimental("FirelyCqlSdkPreview")]
    internal static ElmToolkit CreateElmToolkit2(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null,
        ElmToolkitCallbacks? elmToolkitCallbacks = null,
        Func<CqlVersionedLibraryIdentifier, bool>? libraryPredicate = null) =>
        new ElmToolkit(
                loggerFactory: cqlToolkit.LoggerFactory,
                config: elmToolkitConfig,
                batchProcessExceptionContinuation: cqlToolkit.BatchProcessExceptionContinuation,
                callbacks: elmToolkitCallbacks)
            .AddElmFromCqlToolkit(cqlToolkit, libraryPredicate);

    /// <summary>
    /// Compiles CQL to assemblies using the provided <see cref="CqlToolkit"/>.
    /// </summary>
    ///
    /// <param name="cqlToolkit">
    /// The <see cref="CqlToolkit"/> instance to use for creating the <see cref="ElmToolkit"/>,
    /// using the same <see cref="CqlToolkit.BatchProcessExceptionContinuation"/>..
    /// </param>
    ///
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    ///
    /// <returns>An instance of <see cref="ElmToolkit"/> with the compiled assemblies.</returns>
    public static ElmToolkit CompileToAssemblies(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null) =>
        cqlToolkit
            .TranslateToElm()
            .CreateElmToolkit(elmToolkitConfig)
            .CompileToAssemblies();
}
