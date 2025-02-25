/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using Hl7.Cql.Abstractions;

namespace Hl7.Cql.Toolkit;

/// <summary>
/// Represents a toolkit that provides a set of services using configuration settings.
/// </summary>
/// <typeparam name="TSelf">The exact type of the toolkit implementation itself.</typeparam>
/// <typeparam name="TConfig">The type of the toolkit's config.</typeparam>
internal interface IToolkitWithConfig<out TSelf, out TConfig> : IToolkit<TSelf>
    where TSelf : IToolkitWithConfig<TSelf, TConfig>
    where TConfig : class
{
    /// <summary>
    /// Gets the configuration used by the toolkit.
    /// </summary>
    TConfig Config { get; }
}