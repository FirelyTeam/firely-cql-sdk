namespace Hl7.Cql.Abstractions.Exceptions;

/// <summary>
/// The exception policy to use while processing a batch of items.
/// </summary>
public enum ProcessBatchItemExceptionHandling
{
    /// <summary>
    /// Throw an exception when an error occurs.
    /// </summary>
    ThrowException = 0,

    /// <summary>
    /// Ignore the exception and continue to the next library.
    /// </summary>
    IgnoreExceptionAndContinue = 1,

    /// <summary>
    /// Ignore the exception and break the process.
    /// </summary>
    IgnoreExceptionAndBreak = 2,
}