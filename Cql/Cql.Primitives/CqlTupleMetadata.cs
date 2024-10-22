using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Primitives;

/// <summary>
/// Represents the metadata for a CQL value tuple.
/// CQL value tuples are represented as <see cref="ITuple"/> instances with the first element being a <see cref="CqlTupleMetadata"/> instance.
/// </summary>
public class CqlTupleMetadata : IEquatable<CqlTupleMetadata>
{
    private static Hasher Hasher { get; } = Hasher.Instance;
    internal const string? PropertyPrefix = "CqlTupleMetadata_";

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

        _toString = $"[{string.Join(", ", ItemNames.Select(pn => $"\"{pn}\""))}]";

        // For some odd reason, if this is not lazy, the hash code is occasionally fails deep inside the Hasher with NullReferenceException, whenever a library is created.
        _signatureHashStringLazy = new Lazy<string>(() => BuildSignatureHashString(ItemTypes.Zip(ItemNames).ToList(), PropertyPrefix, _toString));

        //_hashCode = _signatureHashStringLazy.GetHashCode();
    }

    internal static string BuildSignatureHashString(
        IEnumerable<(Type propType, string propName)> tupleProps,
        string? prepend = null,
        string? toString = null)
    {
        string signatureString = "";
        var hasher = Hasher;
        try
        {
            signatureString = string.Join(
                "+",
                tupleProps.Select(t => $"{t.propName}:{t.propType.ToCSharpString()}"));
            var signatureHashString = $"{prepend}{hasher.Hash(signatureString)}";
            return signatureHashString;
        }
        catch (Exception e)
        {
            _ = e;
            throw new Exception(
                $"Could not calculate hash. signatureString:'{signatureString}', toString:{toString}, hasher:{(hasher is null ? "is null" : "exists")}",
                e);
        }
    }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyList<string> ItemNames { get; }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyList<Type> ItemTypes { get; }

    private readonly Lazy<string> _signatureHashStringLazy;
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
        _signatureHashStringLazy.Value == other._signatureHashStringLazy.Value
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
    public override int GetHashCode() => _signatureHashStringLazy.Value.GetHashCode();

    /// <inheritdoc/>
    public override string ToString() => _toString;
}