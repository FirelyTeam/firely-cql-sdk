/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.CodeGeneration.NET.Toolkit;
using Hl7.Cql.CodeGeneration.NET.Toolkit.Extensions;
using Hl7.Cql.CqlToElm.Toolkit;

namespace Hl7.Cql.Invocation.Toolkit.Extensions;

/// <summary>
/// Provides extension methods for the <see cref="CqlToolkit"/> class.
/// </summary>
public static class CqlToolkitExtensions
{
    /// <summary>
    /// Creates a <see cref="LibrarySetInvoker"/> from the specified <see cref="CqlToolkit"/>.
    /// </summary>
    /// <param name="cqlToolkit">The CQL toolkit to use for creating the library set invoker.</param>
    /// <param name="elmToolkitConfig">The configuration for the ELM toolkit.</param>
    /// <param name="name">The name of the library set invoker.</param>
    /// <returns>A new instance of <see cref="LibrarySetInvoker"/>.</returns>
    public static LibrarySetInvoker CreateLibrarySetInvoker(
        this CqlToolkit cqlToolkit,
        ElmToolkitConfig? elmToolkitConfig = null,
        string name = "") =>
        cqlToolkit
            .ConvertCqlToElm()
            .CreateElmToolkit(elmToolkitConfig)
            .CreateLibrarySetInvoker(name);
}
