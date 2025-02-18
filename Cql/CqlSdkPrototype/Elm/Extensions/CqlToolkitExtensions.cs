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
