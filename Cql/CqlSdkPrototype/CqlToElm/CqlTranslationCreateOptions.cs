using Hl7.Cql.Abstractions.Exceptions;

namespace CqlSdkPrototype.CqlToElm;

public record CqlTranslationCreateOptions(
    ProcessBatchItemExceptionHandling ProcessBatchItemExceptionHandling)
{
    public static CqlTranslationCreateOptions Default { get; } = new(default(ProcessBatchItemExceptionHandling));
}