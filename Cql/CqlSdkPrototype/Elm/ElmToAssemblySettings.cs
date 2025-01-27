using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

public record ElmToAssemblySettings(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None)
{
    public static ElmToAssemblySettings Default { get; } = new();
}