/*
 * Copyright (c) 2025, Firely, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

namespace Hl7.Cql.Abstractions;

/// <summary>
/// Represents an interface for a singleton pattern.
/// </summary>
/// <typeparam name="TSelf">The type of the implementing class.</typeparam>
public interface ISingleton<out TSelf>
    where TSelf : ISingleton<TSelf>
{
    /// <summary>
    /// Gets the instance of the implementing class.
    /// </summary>
    static virtual TSelf Instance { get; } = Activator.CreateInstance<TSelf>();
}