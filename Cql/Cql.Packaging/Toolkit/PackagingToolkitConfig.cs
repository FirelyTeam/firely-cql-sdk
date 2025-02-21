/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Runtime;

namespace Hl7.Cql.Packaging.Toolkit;

#pragma warning disable RS0027
/// <summary>
/// Represents the configuration settings for the packaging toolkit.
/// </summary>
/// <param name="ErroredEnumerationContinuation">The continuation setting for errored enumerations.</param>
public record PackagingToolkitConfig(
#pragma warning restore RS0027
    ErroredEnumerationContinuation ErroredEnumerationContinuation = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static PackagingToolkitConfig Default { get; } = new PackagingToolkitConfig();

    /// <summary>
    /// Gets the continuation setting for errored enumerations.
    /// </summary>
    public ErroredEnumerationContinuation ErroredEnumerationContinuation { get; init; } = ErroredEnumerationContinuation;
}
