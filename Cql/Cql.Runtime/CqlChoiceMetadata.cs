/*
 * Copyright (c) 2023, NCQA and contributors
 * See the file CONTRIBUTORS for details.
 *
 * This file is licensed under the BSD 3-Clause license
 * available at https://raw.githubusercontent.com/FirelyTeam/firely-cql-sdk/main/LICENSE
 */

using System.Collections.Generic;
using System;
using Hl7.Cql.Abstractions;
using System.Linq;
using Hl7.Cql.Abstractions.Infrastructure;

namespace Hl7.Cql.Runtime;

/// <summary>
/// Represents the metadata for a choice type.
/// </summary>
public class CqlChoiceMetadata : IEquatable<CqlChoiceMetadata>
{
    /// <summary>
    /// Represents the metadata for a choice type.
    /// </summary>
    /// <param name="choiceTypes">The <see cref="Type"/> posibilities for this choice.</param>
    public CqlChoiceMetadata(
        Type[]? choiceTypes = null)
    {
        ChoiceTypes = choiceTypes ?? [];

        _signatureHashString = BuildSignatureHashString(ChoiceTypes);
        _toString = $"[{string.Join(", ", ChoiceTypes.Select(t => t.ToCSharpString()))}]";
        _hashCode = _signatureHashString.GetHashCode();
    }

    /// <summary>
    /// The name for each item in the tuple.
    /// </summary>
    public IReadOnlyList<Type> ChoiceTypes { get; }

    internal static string BuildSignatureHashString(IReadOnlyCollection<Type> choices)
    {
        var signatureString = string.Join("+", choices.Select(t => $"{t.ToCSharpString()}"));
        var signatureHashString = $"CqlChoiceMetadata_{Hasher.Instance.Hash(signatureString)}";
        return signatureHashString;
    }

    private readonly string _signatureHashString;
    private readonly int _hashCode;
    private readonly string _toString;

    /// <inheritdoc/>
    public override bool Equals(object? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj is CqlChoiceMetadata otherChoice) return EqualsImpl(otherChoice);
        return false;
    }

    /// <inheritdoc cref="Equals(object?)"/>
    public virtual bool Equals(CqlChoiceMetadata? obj)
    {
        if (obj is null) return false;
        if (ReferenceEquals(this, obj)) return true;
        return EqualsImpl(obj);
    }

    private bool EqualsImpl(CqlChoiceMetadata other) =>
        _signatureHashString == other._signatureHashString
        && ChoiceTypes.SequenceEqual(other.ChoiceTypes);

    /// <summary>
    /// Equality operator.
    /// </summary>
    public static bool operator ==(CqlChoiceMetadata? left, CqlChoiceMetadata? right) => left?.Equals(right) ?? right is null;

    /// <summary>
    /// Inequality operator.
    /// </summary>
    public static bool operator !=(CqlChoiceMetadata? left, CqlChoiceMetadata? right) => !(left == right);

    /// <inheritdoc/>
    public override int GetHashCode() => _hashCode;

    /// <inheritdoc/>
    public override string ToString() => _toString;

}
