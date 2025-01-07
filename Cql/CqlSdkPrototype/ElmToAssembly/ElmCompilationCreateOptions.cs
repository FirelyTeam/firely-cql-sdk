using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.ElmToAssembly;

public record ElmCompilationCreateOptions(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling)

{
    public static ElmCompilationCreateOptions Default { get; } = new(default(ProcessBatchItemExceptionHandling));
}