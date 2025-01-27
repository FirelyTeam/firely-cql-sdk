using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

public record ElmToolkitSettings(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None)
{
    public static ElmToolkitSettings Default { get; } = new();
    public ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling { get; init; } = ProcessBatchItemExceptionHandling;
    public AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat { get; init; } = AssemblyCompilerDebugInformationFormat;
}