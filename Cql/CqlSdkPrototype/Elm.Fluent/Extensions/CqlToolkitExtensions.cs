using CqlSdkPrototype.Cql.Fluent;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static class CqlToolkitExtensions
{
    public static ElmToolkit ToFluentElmToolkit(
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblyCompilerConfig, ElmToAssemblyCompilerConfig>? configure = null)
    {
        var config = new ElmToAssemblyCompilerConfig(EnumerationExceptionHandling: cqlToolkit.Config.EnumerationExceptionHandling);
        if (configure is not null) config = configure(config);
        var elmToolkit = new ElmToolkit(cqlToolkit.LoggerFactory, config).AddElmFromFluentCqlToolkit(cqlToolkit);
        return elmToolkit;
    }

    public static ElmToolkit CompileCqlToAssemblies(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit
            .TranslateCqlToElm()
            .ToFluentElmToolkit()
            .CompileElmToAssemblies();
}
