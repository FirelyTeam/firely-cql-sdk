#nullable enable
using System;
using System.Runtime.CompilerServices;
using Hl7.Cql.Tuples;

namespace CoreTests.Tuples;

// Assume this is what the generated tuple will look like, just with a more generic name
// [CompilerGenerated]
public readonly struct TupleA(string? name = null, DateTime? dob = null)
    : IStructuralValue<string?, DateTime?>,
      IStructuralValueMetadataProvider,
      IEquatable<IStructuralValue<string?, DateTime?>>
{
    public string? Name { get; init; } = name;
    public DateTime? DOB { get; init; } = dob;

    public TupleA(IStructuralValue<string?, DateTime?> other) : this(other.Item1, other.Item2)
    {
        if (other.GetMetadata().Signature != Metadata.Signature)
            throw new ArgumentException("Incompatible metadata", nameof(other));
    }

    public void Deconstruct(out string? name, out DateTime? dob) =>
        (name, dob) = (Name, DOB);

    object? ITuple.this[int index] => index switch
    {
        0 => Name,
        1 => DOB,
        _ => throw new IndexOutOfRangeException()
    };
    int ITuple.Length => 2;
    string? IStructuralValue<string?>.Item1 => Name;
    DateTime? IStructuralValue<string?, DateTime?>.Item2 => DOB;

    StructuralValueMetadata IStructuralValue.GetMetadata() => Metadata;
    public static StructuralValueMetadata Metadata { get; } = new(
        [typeof(string), typeof(DateTime?)],
        ["Name", "DOB"]);

    public override bool Equals(object? other) =>
        other is IStructuralValue<string?, DateTime?> sv
        && Equals(sv);

    public bool Equals(IStructuralValue<string?, DateTime?>? other) =>
        other is not null
        && other.GetMetadata().Signature == Metadata.Signature
        && (Name, DOB) == (other.Item1, other.Item2);

    public override string ToString() => $"(Name={Name}, DOB={DOB})";

    public override int GetHashCode() => (Name, DOB).GetHashCode();

    public static bool operator ==(TupleA left, IStructuralValue<string?, DateTime?> right) => left.Equals(right);

    public static bool operator !=(TupleA left, IStructuralValue<string?, DateTime?> right) => !(left == right);
}