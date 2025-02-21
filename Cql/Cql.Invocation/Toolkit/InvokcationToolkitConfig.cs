using Hl7.Cql.Runtime;

namespace Hl7.Cql.Invocation.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="InvocationToolkit"/>.
/// </summary>
/// <param name="ErroredEnumerationContinuation">The exception handling policy to use while processing a batch of items.</param>
public sealed record InvocationToolkitConfig(
    ErroredEnumerationContinuation ErroredEnumerationContinuation = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static InvocationToolkitConfig Default { get; } = new();
}
