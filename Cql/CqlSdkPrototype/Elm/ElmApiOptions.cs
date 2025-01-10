using CqlSdkPrototype.App;
using CqlSdkPrototype.Cql;
using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

public record ElmApiOptions(
    LoggingOptions? LoggingOptions = null,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None)
{
    public static ElmApiOptions Default { get; } = new();
    public LoggingOptions LoggingOptions { get; init; } = LoggingOptions ?? LoggingOptions.Default;
}

public static class CqlApiOptionsExtensions
{
    public static ElmApiOptions CreateElmApiOptions(this CqlApiOptions cqlApiOptions)
    {
        return ElmApiOptions.Default with
        {
            LoggingOptions = cqlApiOptions.LoggingOptions,
            ProcessBatchItemExceptionHandling = cqlApiOptions.ProcessBatchItemExceptionHandling,
        };
    }
}