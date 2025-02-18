/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;
using CqlSdkPrototype.Elm.Extensions;
using Hl7.Cql.Abstractions;

namespace CqlSdkPrototype.Invocation.Extensions;

public static class CqlToolkitExtensions
{
    public static LibrarySetInvoker CreateLibrarySetInvoker(
        this CqlToolkit cqlToolkit,
        Mutator<ElmToolkitConfig>? reconfigureElmToolkitConfig = null,
        string name = "") =>
        cqlToolkit
            .ConvertCqlToElm()
            .CreateElmToolkit(reconfigureElmToolkitConfig)
            .CreateLibrarySetInvoker(name);
}
