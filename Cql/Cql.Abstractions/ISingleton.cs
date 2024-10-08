using System;

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