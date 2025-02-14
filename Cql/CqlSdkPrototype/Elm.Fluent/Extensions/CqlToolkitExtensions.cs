using CqlSdkPrototype.Cql;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static class CqlToolkitExtensions
{
    public static ElmToolkit ToFluentElmToolkit(
        this CqlToolkit cqlToolkit,
        Func<ElmToAssemblyCompilerConfig, ElmToAssemblyCompilerConfig>? configure = null)
    {
        var config = new ElmToAssemblyCompilerConfig(ErroredEnumerationContinuation: cqlToolkit.Config.ErroredEnumerationContinuation);
        if (configure is not null) config = configure(config);
        var elmToolkit = new ElmToolkit(cqlToolkit.LoggerFactory, config).AddElmFromFluentCqlToolkit(cqlToolkit);
        return elmToolkit;
    }

    public static ElmToolkit CompileCqlToAssemblies(
        this CqlToolkit cqlToolkit) =>
        cqlToolkit
            .ConvertCqlToElm()
            .ToFluentElmToolkit()
            .CompileElmToAssemblies();
}
