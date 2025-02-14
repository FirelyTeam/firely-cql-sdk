using CqlSdkPrototype.Cql;

namespace CqlSdkPrototype.Elm.Extensions;

public static class CqlToolkitExtensions
{
    public static ElmToolkit ToFluentElmToolkit(
        this CqlToolkit cqlToolkit,
        Func<ElmToolkitConfig, ElmToolkitConfig>? configure = null)
    {
        var config = new ElmToolkitConfig(ErroredEnumerationContinuation: cqlToolkit.Config.ErroredEnumerationContinuation);
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
