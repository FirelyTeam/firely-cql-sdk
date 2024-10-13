using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Hl7.Cql.Abstractions.Infrastructure;

#pragma warning disable RS0037
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable RS0016

namespace Hl7.Cql.Tuples;

public readonly record struct StructuralValueMetadata
{
    public StructuralValueMetadata(
        Type[] ItemTypes,
        string[] ItemNames)
    {
        this.ItemTypes = ItemTypes;
        this.ItemNames = ItemNames;
        Signature = string.Join("&", ItemTypes.Zip(ItemNames).Select(t => $"{t.Item1.ToCSharpString()} {t.Item2}"));
    }

    public Type[] ItemTypes { get; }
    public string[] ItemNames { get; }
    public string Signature { get; }
    public void Deconstruct(
        out Type[] ItemTypes,
        out string[] ItemNames,
        out string Signature)
    {
        ItemTypes = this.ItemTypes;
        ItemNames = this.ItemNames;
        Signature = this.Signature;
    }
    public override string ToString() => Signature;
    public bool Equals(StructuralValueMetadata? other) =>
        other is {} o &&
        Signature == o.Signature;
}

public interface IStructuralValue : ITuple
{
    StructuralValueMetadata GetMetadata();
}

public interface IStructuralValue<out T1> : IStructuralValue
{
    T1 Item1 { get; }
}

public interface IStructuralValue<out T1, out T2> : IStructuralValue<T1>
{
    T2 Item2 { get; }
}

public interface IStructuralValue<out T1, out T2, out T3> : IStructuralValue<T2>
{
    T3 Item3 { get; }
}

public interface IStructuralValueMetadataProvider
{
    static abstract StructuralValueMetadata Metadata { get; }
}


// Assume this is what the generated tuple will look like, just with a more generic name
[CompilerGenerated]
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

// Assume this is what the generated tuple will look like, just with a more generic name
[CompilerGenerated]
public readonly struct TupleB(string? name = null, DateTime? dob = null)
    : IStructuralValue<string?, DateTime?>,
      IStructuralValueMetadataProvider,
      IEquatable<IStructuralValue<string?, DateTime?>>
{
    public string? Name { get; init; } = name;
    public DateTime? DOB { get; init; } = dob;

    public TupleB(IStructuralValue<string?, DateTime?> other) : this(other.Item1, other.Item2)
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

    public static bool operator ==(TupleB left, IStructuralValue<string?, DateTime?> right) => left.Equals(right);

    public static bool operator !=(TupleB left, IStructuralValue<string?, DateTime?> right) => !(left == right);
}

public static class Test
{
    public static void RunTests()
    {
        var dateTime = new DateTime(2000, 12, 31);

        // Constructor
        TupleA a = new("Paul", dateTime);
        Debug.Assert(a.ToString() == "(Name=Paul, DOB=31-12-2000 00:00:00)");

        // Constructor with named arguments
        TupleA a1 = new(name: "Paul");
        Debug.Assert(a1.ToString() == "(Name=Paul, DOB=)");

        // Object initializer
        TupleA a2 = new TupleA { DOB = dateTime };
        Debug.Assert(a2.ToString() == "(Name=, DOB=31-12-2000 00:00:00)");

        TupleB b = new("Paul", dateTime);
        Debug.Assert(a.Equals(a));
        Debug.Assert(a.Equals((object)a));

        Debug.Assert(a != a1);
        Debug.Assert(!a.Equals(a1));
        Debug.Assert(!a.Equals((object)a1));

        Debug.Assert(a == b);
        Debug.Assert(a.Equals(b));
        Debug.Assert(a.Equals((object)b));

        Debug.Assert(a.GetHashCode() == b.GetHashCode());

        // Copy constructor
        TupleB b1 = new(a);
        Debug.Assert(a.Equals(b1));
        Debug.Assert(a.Equals((object)b1));

        Debug.Assert(a == b1);
        Debug.Assert(a.Equals(b1));
        Debug.Assert(a.Equals((object)b1));

        Debug.Assert(a.GetHashCode() == b1.GetHashCode());
    }
}