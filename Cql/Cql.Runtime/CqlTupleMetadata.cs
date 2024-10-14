using System;
using System.Collections.Generic;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents the metadata for a tuple.
/// </summary>
public class CqlTupleMetadata
{
    /// <summary>
    /// Represents the metadata for a tuple.
    /// </summary>
    /// <param name="itemNames">The name for each item in the tuple.</param>
    /// <param name="itemTypes">The <see cref="Type"/> for each item in the tuple.</param>
    public CqlTupleMetadata(
        string[]? itemNames = null,
        Type[]? itemTypes = null)
    {
        ItemNames = itemNames ?? [];
        Types = itemTypes ?? [];
        if (ItemNames.Count != Types.Count)
            throw new ArgumentException("Item names and types must have the same number of elements.");
    }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyCollection<string> ItemNames { get; }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyCollection<Type> Types { get; }
}