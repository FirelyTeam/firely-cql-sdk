/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

/// <summary>
/// Configuration settings for the <see cref="PackagingToolkit"/>.
/// </summary>
/// <param name="ErroredEnumerationContinuation">The exception handling policy to use while processing a batch of items.</param>
public record PackagingToolkitConfig(
    ErroredEnumerationContinuation ErroredEnumerationContinuation)
{
    /// <summary>
    /// Creates a new instance of the <see cref="PackagingToolkitConfig"/> class.
    /// </summary>
    public PackagingToolkitConfig() : this(ErroredEnumerationContinuation.Throw) { }

    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static PackagingToolkitConfig Default { get; } = new();

    /// <summary>
    /// Gets the continuation setting for errored enumerations.
    /// </summary>
    public ErroredEnumerationContinuation ErroredEnumerationContinuation { get; init; } = ErroredEnumerationContinuation;
}
