using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="InvocationToolkit"/>.
/// </summary>
/// <param name="EnumerationExceptionContinuation">The continuation policy to use when an exception occurs during enumeration.</param>
public sealed record InvocationToolkitConfig(
    EnumerationExceptionContinuation EnumerationExceptionContinuation = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static InvocationToolkitConfig Default { get; } = new();

    /// Gets the continuation policy to use when an exception occurs during enumeration.
    public EnumerationExceptionContinuation EnumerationExceptionContinuation { get; init; } = EnumerationExceptionContinuation;
}
