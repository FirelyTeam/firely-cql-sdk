using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

public sealed record ElmToAssemblyProcessorConfig(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None)
{
    public static ElmToAssemblyProcessorConfig Default { get; } = new();
}