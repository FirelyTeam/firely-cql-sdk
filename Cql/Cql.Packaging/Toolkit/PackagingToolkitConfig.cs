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
/// <param name="EnumerationExceptionContinuation">The continuation policy to use when an exception occurs during enumeration.</param>
public record PackagingToolkitConfig(
    EnumerationExceptionContinuation EnumerationExceptionContinuation)
{
    /// <summary>
    /// Creates a new instance of the <see cref="PackagingToolkitConfig"/> class.
    /// </summary>
    public PackagingToolkitConfig() : this(EnumerationExceptionContinuation.Throw) { }

    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static PackagingToolkitConfig Default { get; } = new();

    /// <summary>
    /// Gets the continuation policy to use when an exception occurs during enumeration.
    /// </summary>
    public EnumerationExceptionContinuation EnumerationExceptionContinuation { get; init; } = EnumerationExceptionContinuation;
}
