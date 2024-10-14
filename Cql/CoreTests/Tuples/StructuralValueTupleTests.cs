#nullable enable
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Hl7.Cql.Abstractions.Infrastructure;

namespace CoreTests.Tuples;

#region Tests

[TestClass]
public partial class StructuralValueTupleBasicTests
{
    [TestMethod]
    public void Constructor_ShouldSetProperties()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);

        // Act
        TupleA a = new("Paul", dateTime);

        // Assert
        Assert.AreEqual("(Name=Paul, DOB=31-12-2000 00:00:00)", a.ToString());
    }

    [TestMethod]
    public void ConstructorWithNamedArguments_ShouldSetProperties()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);

        // Act
        TupleA a1 = new(name: "Paul");

        // Assert
        Assert.AreEqual("(Name=Paul, DOB=)", a1.ToString());
    }

    [TestMethod]
    public void ObjectInitializer_ShouldSetProperties()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);

        // Act
        TupleA a2 = new TupleA { DOB = dateTime };

        // Assert
        Assert.AreEqual("(Name=, DOB=31-12-2000 00:00:00)", a2.ToString());
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithItself()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        bool result = a.Equals(a);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        bool result = a.Equals((object)a);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnFalse_WhenComparingWithDifferentInstance()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleA a1 = new("John", dateTime);

        // Act
        bool result = a.Equals(a1);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnFalse_WhenComparingWithDifferentObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleA a1 = new("John", dateTime);

        // Act
        bool result = a.Equals((object)a1);

        // Assert
        Assert.IsFalse(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithEquivalentTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleB b = new("Paul", dateTime);

        // Act
        bool result = a.Equals(b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void Equals_ShouldReturnTrue_WhenComparingWithEquivalentObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleB b = new("Paul", dateTime);

        // Act
        bool result = a.Equals((object)b);

        // Assert
        Assert.IsTrue(result);
    }

    [TestMethod]
    public void GetHashCode_ShouldReturnSameValue_WhenCalledOnEquivalentTuples()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);
        TupleB b = new("Paul", dateTime);

        // Act
        int hashCodeA = a.GetHashCode();
        int hashCodeB = b.GetHashCode();

        // Assert
        Assert.AreEqual(hashCodeA, hashCodeB);
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals(b1));
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals((object)b1));
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentTuple_WhenComparingWithOriginalTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a == b1);
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentObject_WhenComparingWithOriginalTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals(b1));
    }

    [TestMethod]
    public void CopyConstructor_ShouldCreateEquivalentObject_WhenComparingWithOriginalObject()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);

        // Assert
        Assert.IsTrue(a.Equals((object)b1));
    }

    [TestMethod]
    public void GetHashCode_ShouldReturnSameValue_WhenCalledOnCopiedTuple()
    {
        // Arrange
        var dateTime = new DateTime(2000, 12, 31);
        TupleA a = new("Paul", dateTime);

        // Act
        TupleB b1 = new(a);
        int hashCodeA = a.GetHashCode();
        int hashCodeB = b1.GetHashCode();

        // Assert
        Assert.AreEqual(hashCodeA, hashCodeB);
    }
}

[TestClass]
public partial class StructuralValueTupleSerializationTests
{
    [TestMethod]
    public void TestJsonSerializationNested()
    {
        TupleAddress homeAddr =
            new("Home", "Joe Street", "Springfield", "USA");

        TupleAddress workAddr =
            new("Work", "Sue Street", "Jumpville", "Canada");

        TuplePerson person =
            new("John", 10, [homeAddr, workAddr]);

        var serializedJson = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
        Assert.AreEqual(
            """
            {
              "Name": "John",
              "Id": 10,
              "Addresses": [
                {
                  "AddressType": "Home",
                  "Street": "Joe Street",
                  "City": "Springfield",
                  "Country": "USA"
                },
                {
                  "AddressType": "Work",
                  "Street": "Sue Street",
                  "City": "Jumpville",
                  "Country": "Canada"
                }
              ]
            }
            """, serializedJson);
    }
}

#endregion

#region Generated C# as part of Library

partial class StructuralValueTupleBasicTests
{
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


    // Assume this is what the generated tuple will look like, just with a more generic name
    // [CompilerGenerated]
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
}

partial class StructuralValueTupleSerializationTests
{
    // Assume this is what the generated tuple will look like, just with a more generic name
    // [CompilerGenerated]
    public readonly struct TuplePerson(string? name = null, int? id = null, TupleAddress[]? addresses = null)
        : IStructuralValue<string?, int?, TupleAddress[]?>,
          IStructuralValueMetadataProvider,
          IEquatable<IStructuralValue<string?, int?, TupleAddress[]?>>
    {
        public string? Name { get; init; } = name;
        public int? Id { get; init; } = id;
        public TupleAddress[]? Addresses { get; init; } = addresses;

        public TuplePerson(IStructuralValue<string?, int?, TupleAddress[]?> other) : this(
            other.Item1, other.Item2, other.Item3)
        {
            if (other.GetMetadata().Signature != Metadata.Signature)
                throw new ArgumentException("Incompatible metadata", nameof(other));
        }

        public void Deconstruct(
            out string? name,
            out int? id,
            out TupleAddress[]? addresses) =>
            (name, id, addresses) = (Name, Id, Addresses);

        object? ITuple.this[int index] => index switch
        {
            0 => Name,
            1 => Id,
            2 => Addresses,
            _ => throw new IndexOutOfRangeException()
        };

        int ITuple.Length => 4;
        string? IStructuralValue<string?>.Item1 => Name;
        int? IStructuralValue<string?, int?>.Item2 => Id;
        TupleAddress[]? IStructuralValue<string?, int?, TupleAddress[]?>.Item3 => Addresses;

        StructuralValueMetadata IStructuralValue.GetMetadata() => Metadata;

        public static StructuralValueMetadata Metadata { get; } = new(
            [typeof(string), typeof(DateTime?)],
            ["Name", "DOB"]);

        public override bool Equals(object? other) =>
            other is IStructuralValue<string?, DateTime?> sv
            && Equals(sv);

        public bool Equals(IStructuralValue<string?, int?, TupleAddress[]?>? other) =>
            other is not null
            && other.GetMetadata().Signature == Metadata.Signature
            && (Name, Id, Addresses) == (other.Item1, other.Item2, other.Item3);

        public override string ToString() => (AddressType: Name, Street: Id, City: Addresses).ToString();

        public override int GetHashCode() => (AddressType: Name, Street: Id, City: Addresses).GetHashCode();

        public static bool operator ==(TuplePerson left, IStructuralValue<string?, DateTime?> right) =>
            left.Equals(right);

        public static bool operator !=(TuplePerson left, IStructuralValue<string?, DateTime?> right) =>
            !(left == right);
    }


    // Assume this is what the generated tuple will look like, just with a more generic name
    // [CompilerGenerated]
    public readonly struct TupleAddress
        (string? addressType = null, string? street = null, string? city = null, string? country = null)
        : IStructuralValue<string?, string?, string?, string?>,
          IStructuralValueMetadataProvider,
          IEquatable<IStructuralValue<string?, string?, string?, string?>>
    {
        public string? AddressType { get; init; } = addressType;
        public string? Street { get; init; } = street;
        public string? City { get; init; } = city;
        public string? Country { get; init; } = country;

        public TupleAddress(IStructuralValue<string?, string?, string?, string?> other) : this(
            other.Item1, other.Item2, other.Item3, other.Item4)
        {
            if (other.GetMetadata().Signature != Metadata.Signature)
                throw new ArgumentException("Incompatible metadata", nameof(other));
        }

        public void Deconstruct(
            out string? addressType,
            out string? street,
            out string? city,
            out string? country) =>
            (addressType, street, city, country) = (AddressType, Street, City, Country);

        object? ITuple.this[int index] => index switch
        {
            0 => AddressType,
            1 => Street,
            2 => City,
            3 => Country,
            _ => throw new IndexOutOfRangeException()
        };

        int ITuple.Length => 4;
        string? IStructuralValue<string?>.Item1 => AddressType;
        string? IStructuralValue<string?, string?>.Item2 => Street;
        string? IStructuralValue<string?, string?, string?>.Item3 => City;
        string? IStructuralValue<string?, string?, string?, string?>.Item4 => Country;

        StructuralValueMetadata IStructuralValue.GetMetadata() => Metadata;

        public static StructuralValueMetadata Metadata { get; } = new(
            [typeof(string), typeof(DateTime?)],
            ["Name", "DOB"]);

        public override bool Equals(object? other) =>
            other is IStructuralValue<string?, DateTime?> sv
            && Equals(sv);

        public bool Equals(IStructuralValue<string?, string?, string?, string?>? other) =>
            other is not null
            && other.GetMetadata().Signature == Metadata.Signature
            && (AddressType, Street, City, Country) == (other.Item1, other.Item2, other.Item3, other.Item4);

        public override string ToString() => (AddressType, Street, City, Country).ToString();

        public override int GetHashCode() => (AddressType, Street, City, Country).GetHashCode();

        public static bool operator ==(TupleAddress left, IStructuralValue<string?, DateTime?> right) =>
            left.Equals(right);

        public static bool operator !=(TupleAddress left, IStructuralValue<string?, DateTime?> right) =>
            !(left == right);
    }
}

#endregion

#region Runtime SDK

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

public interface IStructuralValue<out T1, out T2, out T3> : IStructuralValue<T1, T2>
{
    T3 Item3 { get; }
}

public interface IStructuralValue<out T1, out T2, out T3, out T4> : IStructuralValue<T1, T2, T3>
{
    T4 Item4 { get; }
}

public interface IStructuralValueMetadataProvider
{
    static abstract StructuralValueMetadata Metadata { get; }
}

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
        out Type[] itemTypes,
        out string[] itemNames,
        out string signature)
    {
        itemTypes = ItemTypes;
        itemNames = ItemNames;
        signature = Signature;
    }
    public override string ToString() => Signature;

    public bool Equals(StructuralValueMetadata? other) =>
        other is { } o &&
        Signature == o.Signature;
}

#endregion