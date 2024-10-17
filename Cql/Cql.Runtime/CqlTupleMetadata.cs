using System;
using System.Collections.Generic;
using System.Linq;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents the metadata for a tuple.
/// </summary>
public class CqlTupleMetadata : IEquatable<CqlTupleMetadata>
{
    /// <summary>
    /// Represents the metadata for a tuple.
    /// </summary>
    /// <param name="itemNames">The name for each item in the tuple.</param>
    /// <param name="itemTypes">The <see cref="Type"/> for each item in the tuple.</param>
    public CqlTupleMetadata(
        Type[]? itemTypes = null,
        string[]? itemNames = null)
    {
        ItemNames = itemNames ?? [];
        ItemTypes = itemTypes ?? [];
        if (ItemNames.Count != ItemTypes.Count)
            throw new ArgumentException("Item names and types must have the same number of elements.");

        _signatureHashString = BuildSignatureHashString(ItemNames.Zip(ItemTypes).ToList());
        _toString = $"[{string.Join(", ", ItemNames.Select(pn => $"\"{pn}\""))}]";
        _hashCode = _signatureHashString.GetHashCode();
    }

    internal static string BuildSignatureHashString(IReadOnlyCollection<(string ItemName, Type ItemType)> signature)
    {
        var signatureString = string.Join("+", signature.Select(t => $"{t.ItemName}:{t.ItemType.ToCSharpString()}"));
        var signatureHashString = $"CqlTupleMetadata_{Hasher.Instance.Hash(signatureString)}";
        return signatureHashString;
    }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyList<string> ItemNames { get; }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyList<Type> ItemTypes { get; }

    private readonly string _signatureHashString;
    private readonly int _hashCode;
    private readonly string _toString;

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is CqlTupleMetadata otherTuple) return EqualsImpl(otherTuple);
        return false;
    }

    /// <inheritdoc cref="Equals(object?)"/>
    public virtual bool Equals(CqlTupleMetadata? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return EqualsImpl(obj);
    }

    private bool EqualsImpl(CqlTupleMetadata other) =>
        _signatureHashString == other._signatureHashString
        // && ItemNames.SequenceEqual(other.ItemNames) // This is redundant
        && ItemTypes.SequenceEqual(other.ItemTypes);

    /// <summary>
    /// Equality operator.
    /// </summary>
    public static bool operator==(CqlTupleMetadata? left, CqlTupleMetadata? right) => left?.Equals(right) ?? right is null;

    /// <summary>
    /// Inequality operator.
    /// </summary>
    public static bool operator!=(CqlTupleMetadata? left, CqlTupleMetadata? right) => !(left == right);

    /// <inheritdoc/>
    public override int GetHashCode() => _hashCode;

    /// <inheritdoc/>
    public override string ToString() => _toString;
}