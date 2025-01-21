using Hl7.Cql.Abstractions.Exceptions;
using Hl7.Cql.CodeGeneration.NET;

namespace CqlSdkPrototype.Elm;

public record ElmApiOptions(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling = default,
    AssemblyCompilerDebugInformationFormat AssemblyCompilerDebugInformationFormat = AssemblyCompilerDebugInformationFormat.None)
{
    public static ElmApiOptions Default { get; } = new();
}