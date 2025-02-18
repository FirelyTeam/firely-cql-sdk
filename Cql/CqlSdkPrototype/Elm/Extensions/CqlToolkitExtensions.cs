/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
using CqlSdkPrototype.Cql;
using Hl7.Cql.Abstractions;

namespace CqlSdkPrototype.Elm.Extensions;

public static class CqlToolkitExtensions
{
    public static ElmToolkit CreateElmToolkit(
        this CqlToolkit cqlToolkit,
        Mutator<ElmToolkitConfig>? reconfigure = null)
    {
        var config = new ElmToolkitConfig(ErroredEnumerationContinuation: cqlToolkit.Config.ErroredEnumerationContinuation);
        if (reconfigure is not null) config = reconfigure(config);
        var elmToolkit = new ElmToolkit(cqlToolkit.LoggerFactory, config).AddElmFromCqlToolkit(cqlToolkit);
        return elmToolkit;
    }

    public static ElmToolkit CompileCqlToAssemblies(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit
            .ConvertCqlToElm()
            .CreateElmToolkit()
            .ConvertElmToAssemblies();
}
