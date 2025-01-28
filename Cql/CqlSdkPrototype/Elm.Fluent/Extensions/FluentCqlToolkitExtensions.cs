using CqlSdkPrototype.Cql.Fluent;

namespace CqlSdkPrototype.Elm.Fluent.Extensions;

public static class FluentCqlToolkitExtensions
{
    public static FluentElmToolkit ToFluentElmToolkit(
        this FluentCqlToolkit cqlToolkit,
        Func<ElmToAssemblySettings, ElmToAssemblySettings>? configureOptions = null)
    {
        var elmApiOptions = new ElmToAssemblySettings(ProcessBatchItemExceptionHandling: cqlToolkit.Settings.ProcessBatchItemExceptionHandling);
        if (configureOptions is not null) elmApiOptions = configureOptions(elmApiOptions);
        var elmApi = new FluentElmToolkit(cqlToolkit.LoggerFactory, elmApiOptions).AddElmFrom(cqlToolkit);
        return elmApi;
    }

    public static FluentElmToolkit ProcessCqlToAssemblies(
        this FluentCqlToolkit cqlToolkit) =>
        cqlToolkit
            .ProcessCqlToElm()
            .ToFluentElmToolkit()
            .ProcessElmToAssemblies();
}
