using CqlSdkPrototype.Cql.Fluent;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static class FluentCqlToolkitExtensions
{
    public static FluentElmToolkit ToFluentElmToolkit(
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblyCompilerConfig, ElmToAssemblyCompilerConfig>? configure = null)
    {
        var config = new ElmToAssemblyCompilerConfig(EnumerationExceptionHandling: cqlToolkit.Config.EnumerationExceptionHandling);
        if (configure is not null) config = configure(config);
        var elmToolkit = new FluentElmToolkit(cqlToolkit.LoggerFactory, config).AddElmFromFluentCqlToolkit(cqlToolkit);
        return elmToolkit;
    }

    public static FluentElmToolkit CompileCqlToAssemblies(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit
            .TranslateCqlToElm()
            .ToFluentElmToolkit()
            .CompileElmToAssemblies();
}
