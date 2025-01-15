using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;
using Microsoft.Extensions.Logging.Abstractions;

namespace CqlSdkPrototype.Elm;

public record ElmApiOptions(
    ILoggerFactory? ILoggerFactory = null,
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None)
{
    public static ElmApiOptions Default { get; } = new();
    public ILoggerFactory LoggerFactory { get; init; } = ILoggerFactory ?? NullLoggerFactory.Instance;
}