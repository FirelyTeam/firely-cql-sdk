using CqlSdkPrototype.Cql;
using CqlSdkPrototype.Elm;

namespace CqlSdkPrototype.Runtime;

public static class RuntimeApiExtensions
{
    public static RuntimeApiOptions CreateRuntimeApiOptions(this CqlApiOptions cqlApiOptions)
    {
        return RuntimeApiOptions.Default with
        {
            LoggerFactory = cqlApiOptions.LoggerFactory,
        };
    }

    public static RuntimeApiOptions CreateRuntimeApiOptions(this ElmApiOptions cqlApiOptions)
    {
        return RuntimeApiOptions.Default with
        {
            LoggerFactory = cqlApiOptions.LoggerFactory,
        };
    }
}