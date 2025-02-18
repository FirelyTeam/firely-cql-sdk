/*
 * Copyright (c) 2025, Firely and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */
 
using Hl7.Cql.Runtime;

namespace CqlSdkPrototype.Packaging;

#pragma warning disable RS0027
public record PackagingToolkitConfig(
#pragma warning restore RS0027
    ErroredEnumerationContinuation ErroredEnumerationContinuation = default)
{
    /// <summary>
    /// Gets the default configuration settings.
    /// </summary>
    public static PackagingToolkitConfig Default { get; } = new PackagingToolkitConfig();

    public ErroredEnumerationContinuation ErroredEnumerationContinuation { get; init; } = ErroredEnumerationContinuation;
}
