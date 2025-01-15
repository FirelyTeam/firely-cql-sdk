using CqlSdkPrototype.Cql;

namespace CqlSdkPrototype.Elm;

public static class CqlApiOptionsExtensions
{
    public static ElmApiOptions CreateElmApiOptions(this CqlApiOptions cqlApiOptions)
    {
        return ElmApiOptions.Default with
        {
            LoggerFactory = cqlApiOptions.LoggerFactory,
            ProcessBatchItemExceptionHandling = cqlApiOptions.ProcessBatchItemExceptionHandling,
        };
    }
}