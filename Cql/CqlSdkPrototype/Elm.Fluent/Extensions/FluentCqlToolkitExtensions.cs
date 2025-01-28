using CqlSdkPrototype.Cql.Fluent;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static class FluentCqlToolkitExtensions
{
    public static FluentElmToolkit CreateFluentElmToolkit(
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblyProcessorConfig, ElmToAssemblyProcessorConfig>? configure = null)
    {
        var config = new ElmToAssemblyProcessorConfig(ProcessBatchItemExceptionHandling: cqlToolkit.Config.ProcessBatchItemExceptionHandling);
        if (configure is not null) config = configure(config);
        var elmToolkit = new FluentElmToolkit(cqlToolkit.LoggerFactory, config).AddElmFromFluentCqlToolkit(cqlToolkit);
        return elmToolkit;
    }

    public static FluentElmToolkit ProcessCqlToAssemblies(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit
            .ProcessCqlToElm()
            .CreateFluentElmToolkit()
            .ProcessElmToAssemblies();
}
